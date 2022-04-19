using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using Data.Database;

namespace UI.Desktop.Proveedores
{
    public partial class frmArticulosDelProveedor : Form
    {
        public frmArticulosDelProveedor(string nomProv)
        {
            InitializeComponent();

     //     Lista de artículos - Configuración de la vista
     //     ------------------------------------------------------------------
            this.dgvTodosArti.DataSource = Datos_ArticuloAdapter.GetAll();
            this.dgvTodosArti.Columns["stock"].Visible = false;
            this.dgvTodosArti.Columns["stockMin"].Visible = false;
            this.dgvTodosArti.Columns["precio"].Visible = false;
            this.dgvTodosArti.Columns["descripcion"].Width = 250;
            this.dgvTodosArti.Columns["codigo"].Width = 100;

           //-----------------------------------------------------------------
          
            nombreProvActual = nomProv;
            this.Text = "Artículos de " + nombreProvActual;
            this.ConfigurarTabla();
           
                           
        }


        #region **** Variables Locales ***

        ArticuloAdapter Datos_ArticuloAdapter = new ArticuloAdapter();
        Proveedores_Articulos_Adapter Datos_ProveedorArticuloAdapter = new Proveedores_Articulos_Adapter();
        string nombreProvActual;
        Entidades.Proveedor_Articulo provArticulo = new Entidades.Proveedor_Articulo();

      
               // DataSet, Table y Rows

            
                 
              public DataTable dtArticulosDelProveedor = new DataTable();
                    
               DataColumn codigoCol = new DataColumn("codigo",typeof(string));
        
               DataColumn descripcionCol = new DataColumn("descripcion",typeof(string));
               DataColumn costoCompraProvCol = new DataColumn("costoCompraProv",typeof(decimal));
        

        public void ConfigurarTabla()
               {
                 //Agrego columnas a la tabla de artículos del proveedor
                   dtArticulosDelProveedor.Columns.Add(codigoCol);
                   dtArticulosDelProveedor.Columns.Add(descripcionCol);
                   dtArticulosDelProveedor.Columns.Add(costoCompraProvCol);
            
             /*      dgvArticulosProveedor.Columns[codigo].HeaderText = "Código";
                   dgvArticulosProveedor.Columns["descripcion"].HeaderText = "Descripción";
                   dgvArticulosProveedor.Columns["descripcion"].Width = 100;
                   dgvArticulosProveedor.Columns["costoCompra"].HeaderText = "Costo ($)";
                 
               */  
              }
        
        
        
        #endregion



        #region METODOS
        // Agregar un articulo al proveedor
        private void AgregarArticuloAlProveedor()
        {
            //TODO ESTE CODIGO CREA UNA FILA DE ARTICULOS DEL PROVEEDOR Y LE CARGA LOS DATOS

      
            provArticulo.CodigoArticulo = this.dgvTodosArti.SelectedRows[0].Cells["codigo"].Value.ToString();
            string descArt = this.dgvTodosArti.SelectedRows[0].Cells["descripcion"].Value.ToString();
            Proveedores.frmIngresarCostoCompra formIngresarCosto = new frmIngresarCostoCompra(nombreProvActual, provArticulo.CodigoArticulo, descArt);


            if (formIngresarCosto.ShowDialog() == DialogResult.OK)
            {
                //Si se ingreso el costo, asigno a ProvArticulo los valores.
                provArticulo.Nombre = nombreProvActual;
                provArticulo.CostoCompraProveedor = Convert.ToDecimal(formIngresarCosto.txtCostoCompra.Text);
                
                //Cargo datos en la fila nueva (de la tabla de artículos del proveedor)
                DataRow rowArtiDelProv = dtArticulosDelProveedor.NewRow();

                rowArtiDelProv[codigoCol] = provArticulo.CodigoArticulo.ToString();
                rowArtiDelProv[descripcionCol] = descArt;
                rowArtiDelProv[costoCompraProvCol] = formIngresarCosto.txtCostoCompra.Text;//Convert.ToDecimal(formIngresarCosto.txtCostoCompra.Text);

                //Agrego la fila al DataTable (origen de datos de la grilla con artículos del proveedor)
                dtArticulosDelProveedor.Rows.Add(rowArtiDelProv);

                //Actualizo la lista con el articulo nuevo agregado.
                ActualizarListaproveedorDT();
            }
        }

        //Actualizar Lista de articulos del Proveedor desde BD
        private void ActualizarListaProveedorBD()
        {
            // Carga en la grilla los Articulos del Proveedor seleccionado.
            this.dgvArticulosProveedor.DataSource = Datos_ProveedorArticuloAdapter.GetArticulosProveedor(nombreProvActual);
            dgvArticulosProveedor.Columns["codigo"].HeaderText = "Código";
            dgvArticulosProveedor.Columns["descripcion"].HeaderText = "Descripción";
            dgvArticulosProveedor.Columns["descripcion"].Width = 250;
            dgvArticulosProveedor.Columns["costoCompraProv"].HeaderText = "Costo ($)";
            dgvArticulosProveedor.Columns["costoCompraProv"].Width = 75;
        }

        //Actualizar Lista de articulos del Proveedor desde DT
        private void ActualizarListaproveedorDT()
        {
            
            
            
            this.dgvArticulosProveedor.DataSource = dtArticulosDelProveedor;
        }

        #endregion 


        #region EVENTOS

        //CLICK Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //CLICK Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //LOAD
        private void frmArticulosDelProveedor_Load(object sender, EventArgs e)
        {
            ActualizarListaProveedorBD();
        }

        //CLICK Añadir al Proveedor --> 
        private void btnAñadirArtiAlProv_Click(object sender, EventArgs e)
        {

            AgregarArticuloAlProveedor();
        }

        #endregion

        private void txtFiltroArticulos_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltroArticulos.Text == "")
            {
                this.dgvTodosArti.DataSource = Datos_ArticuloAdapter.GetAll();
            }
            else
            {
                this.dgvTodosArti.DataSource = Datos_ArticuloAdapter.Busqueda(txtFiltroArticulos.Text);
            }
        }

        private void btnQuitarFiltro1_Click(object sender, EventArgs e)
        {
            txtFiltroArticulos.Text = "";
        }

      

    }
}
