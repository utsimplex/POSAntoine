using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Database;
using System.Text.RegularExpressions;

namespace UI.Desktop.Proveedores
{
    public partial class frmProveedorABM : frmBaseABM
    {
        // Constructor 1
        public frmProveedorABM()
        {
            InitializeComponent();
          this.Text = "Añadir nuevo Proveedor";
          this.groupBox1.Text = "Ingreso de datos";
          List<Entidades.Proveedor_Articulo> esquemaTabla = new List<Entidades.Proveedor_Articulo>();
          this.dgvArticulosProveedor.DataSource = esquemaTabla;
          ConfigurarVistaGrilla();
        }

         //Constructor 2 (Modo Modificcion)
        public frmProveedorABM(Entidades.Proveedor prov)
        {
            InitializeComponent();

            this.Text = "Modificar datos del Proveedor";
            this.groupBox1.Text = "Edición de datos";
            txtNombre.ReadOnly = true;
            txtApellido.Visible = false;
            txtDireccion.Text = prov.Direccion;
            txtEmail.Text = prov.Email;
            txtNroDoc.Text = prov.Dni;
            txtTelefono.Text = prov.Telefono;
            txtNombre.Text = prov.Nombre;
            provToEdit = prov;

            // Actualizar Grilla Articulos del Proveedor

            ActualizarListaArticulosProveedor();
            ConfigurarVistaGrilla();

            

        }

        private void ConfigurarVistaGrilla()
        {
            this.dgvArticulosProveedor.Columns[0].HeaderText = "Código";
            this.dgvArticulosProveedor.Columns[0].Width = 125;
            this.dgvArticulosProveedor.Columns[0].ReadOnly = true;
            this.dgvArticulosProveedor.Columns[1].HeaderText = "Descripción";
            this.dgvArticulosProveedor.Columns[1].Width = 315;
            this.dgvArticulosProveedor.Columns[1].ReadOnly = true;

            this.dgvArticulosProveedor.Columns[2].HeaderText = "Costo de Compra ($)";
            this.dgvArticulosProveedor.Columns[2].Width = 95;
            this.dgvArticulosProveedor.Columns[2].ReadOnly = false;
        }



        #region ///***///***///***/// V A R I A B L E S \\\***\\\***\\\***\\\

        ProveedorAdapter Datos_ProveedorAdapter = new ProveedorAdapter();
        Entidades.Proveedor provToEdit;
        Proveedores_Articulos_Adapter DatosArticulosProveedor = new Proveedores_Articulos_Adapter();
        
        #endregion
        
        #region ///***///***///***/// P R O P I E D A D E S \\\***\\\***\\\***\\\

        TipoForm _modoForm;
        public TipoForm ModoForm
        {
            get { return _modoForm; }
            set { _modoForm = value; }
        }


        #endregion



        #region ///***///***///***/// E N U M E R A D O R E S \\\***\\\***\\\***\\\


        public enum TipoForm
        {
            Alta,
            Edicion

        }


        #endregion



        #region ///***///***///***/// M E T O D O S \\\***\\\***\\\***\\\


        //**********************************G U A R D A R Proveedor ************************ \\
        public void Guardar()
        {
            if (ModoForm == TipoForm.Alta)
            {

                // Genero una nueva instancia de la entidad
                Entidades.Proveedor newProveedor = new Entidades.Proveedor();

                // Valido Datos
                if (Validar())
                {
                    try
                    {
                       
                        // TXT to nuevoCliente
                        newProveedor.Nombre = txtNombre.Text.Trim();
                        newProveedor.Dni = txtNroDoc.Text.Trim();
                        newProveedor.Direccion = txtDireccion.Text.Trim();
                        newProveedor.Telefono = txtTelefono.Text.Trim();
                        newProveedor.Email = txtEmail.Text.Trim();

                        // nuevoCliente to Base de Datos (capa de datos)
                        Datos_ProveedorAdapter.AñadirNuevo(newProveedor);

                        GuardarArticulosDelProveedor();
                        this.Close();
                                                                       
                    }
                    catch (Exception ex)
                    {
                        // Muestro cualquier error de la aplicacion
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        // Libero objetos
                        newProveedor = null;
                    }
                }//Fin try
            }//Fin Alta
            else if (ModoForm == TipoForm.Edicion)
            {
                if (Validar())
                {
                    try
                    {
                        provToEdit.Direccion = txtDireccion.Text;
                        provToEdit.Dni = txtNroDoc.Text;
                        provToEdit.Email = txtEmail.Text;
                        provToEdit.Telefono = txtTelefono.Text;
                        provToEdit.Nombre = txtNombre.Text;

                        Datos_ProveedorAdapter.Actualizar(provToEdit);

                        GuardarArticulosDelProveedor();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        // Muestro cualquier error de la aplicacion
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }               
            }
        }
        

        //*********************** V A L I D A R Proveedor  *********************** \\
        bool Validar()
        {
                string mensaje = "";
                txtNombre.Text = txtNombre.Text.Trim();
                //Valido Nombre
                if (txtNombre.Text.Trim() == "")
                    mensaje += "- El Nombre no puede estar en blanco." + "\n";
                if (txtEmail.Text != "")
                {
                    if (!(Regex.IsMatch(txtEmail.Text, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")))
                    {
                        mensaje += "- El email no tiene el formato correcto." + "\n";
                    }
                }
                //Consulta BD para no añadir proveedor repetido
                ProveedorAdapter Proveedor = new ProveedorAdapter();
            
                List<Entidades.Proveedor> ListaProveedores = Proveedor.GetAll();

                if (ModoForm == TipoForm.Alta)
                {
                    foreach (Entidades.Proveedor prov in ListaProveedores)
                    {
                        if (prov.Nombre == txtNombre.Text)
                        {
                            mensaje += "Ya existe un proveedor registrado con ese Nombre." + "\n";
                        }
                    }
                } 

                // Mostrar Errors
                if (!String.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
          
                return true;
            

        }


        //*********************** G U A R D A R Articulos en la lista del Proveedor  *********************** \\
        protected void GuardarArticulosDelProveedor()
        {
            DataTable ListaArticulosProveedor = new DataTable();

            // Lista de articulos del proveedor
            ListaArticulosProveedor = DatosArticulosProveedor.GetArticulosProveedor(txtNombre.Text);

            bool guardar = false;

            if (ValidarArticulosDelProveedor() == true)
            {
                Proveedores_Articulos_Adapter Datos_ProveedoresArticulos = new Proveedores_Articulos_Adapter();

                // Lista del Form
                foreach (DataGridViewRow rowVisible in dgvArticulosProveedor.Rows)
                {
                    Entidades.Proveedor_Articulo ProvArtiNuevo = new Entidades.Proveedor_Articulo();

                    ProvArtiNuevo.CodigoArticulo = rowVisible.Cells["codigo"].Value.ToString();
                    ProvArtiNuevo.CostoCompraProveedor = Convert.ToDecimal(rowVisible.Cells["costoCompraProv"].Value);
                    ProvArtiNuevo.Nombre = txtNombre.Text;

                    // Lista en Base de Datos
                    if (ListaArticulosProveedor.Rows.Count == 0)
                    {
                        Datos_ProveedoresArticulos.AñadirNuevo(ProvArtiNuevo);
                    }
                    else
                    {
                        foreach (DataRow rowprovArtiExistentes in ListaArticulosProveedor.Rows)
                        {
                            if (rowprovArtiExistentes["codigo"].ToString() == ProvArtiNuevo.CodigoArticulo)
                            {
                                
                                guardar = false;
                                break;
                            }
                            else
                            {
                                guardar = true;
                            }

                        }
                        if (guardar == true)
                        {
                            Datos_ProveedoresArticulos.AñadirNuevo(ProvArtiNuevo);
                        }
                    }
                }
            }
        }


        //*********************** A Ñ A D I R Artículo a lista del proveedor **************************//
        protected void AñadirArticuloAlProveedor()
        {
            if (Validar())
            {
                // FORM Articulos del Proveedor - Seleccionar articulos del proveedor
                // Creo el formulario Articulos del Proveedor
                Proveedores.frmArticulosDelProveedor formArticulosDelProveedor = new frmArticulosDelProveedor(txtNombre.Text.ToString());
               
                //  
                if (dgvArticulosProveedor.Rows.Count != 0)
                {
                    
                    int i = 0;
                    foreach (DataGridViewRow row in dgvArticulosProveedor.Rows)
                    {
                        DataRow rowArtiDelProv = formArticulosDelProveedor.dtArticulosDelProveedor.NewRow();

                        rowArtiDelProv["codigo"] = dgvArticulosProveedor.Rows[i].Cells["codigo"].Value.ToString();
                        rowArtiDelProv["descripcion"] = dgvArticulosProveedor.Rows[i].Cells["descripcion"].Value.ToString();
                        rowArtiDelProv["costoCompraProv"] = Convert.ToDecimal(dgvArticulosProveedor.Rows[i].Cells["costoCompraProv"].Value.ToString());

                        formArticulosDelProveedor.dtArticulosDelProveedor.Rows.Add(rowArtiDelProv);
                        i = i + 1;
                    }
                    formArticulosDelProveedor.dgvArticulosProveedor.DataSource = formArticulosDelProveedor.dtArticulosDelProveedor;
                }




                formArticulosDelProveedor.ShowDialog();

                if (formArticulosDelProveedor.DialogResult == DialogResult.OK)
                {
                    this.dgvArticulosProveedor.DataSource = formArticulosDelProveedor.dtArticulosDelProveedor;
                }
            }
            

                
        }


        //****************** Se añadieron artículos para el proveedor?? ************************//
        protected bool ValidarArticulosDelProveedor()
        {
            if (dgvArticulosProveedor.RowCount == 0)
            {
                //MessageBox.Show("No se han seleccionado los artículos que ofrece este proveedor", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; } // No se cargaron artículos para este proveedor
            else
            { return true; }  // El provedor ofrece 'count' artículos
            
        }
        

        //************* ACTUALIZAR LISTA DE ARTICULOS DEL PROVEEDOR
        private void ActualizarListaArticulosProveedor()
        {
            dgvArticulosProveedor.DataSource = DatosArticulosProveedor.GetArticulosProveedor(provToEdit.Nombre);
        }

        #endregion



        #region ///***///***///*** E V E N T O S \\\***\\\***\\\***\\\


        // TXT NOMBRE***********************************************************
        protected void txtNombre_Leave(object sender, EventArgs e)
        {
            try
            {
                Validar();
            }
            catch (Exception ex)
            {
                // Muestro cualquier error de validación
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        // BTN GUARDAR CLICK****************************************************
        override protected void btnGuardar_Click(object sender, EventArgs e)
        {
           this.Guardar(); 
           

        }

        // BTN CANCELAR CLICK***************************************************
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // BTN + (Agregar artículos a la grilla)********************************
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AñadirArticuloAlProveedor();
        }



        #endregion

        private void btnModifCosto_Click(object sender, EventArgs e)
        {
            //Abro form modificar costo y le asigno nombre del proveedor y descripcion del articulo
            Proveedores.frmModifCosto formModificarCosto = new frmModifCosto();
            formModificarCosto.txtProveedor.Text = this.provToEdit.Nombre;
            formModificarCosto.txtDescrART.Text = this.dgvArticulosProveedor.SelectedRows[0].Cells[1].Value.ToString();

            //Si modifico el costo, entonces guardo los cambios
            if (formModificarCosto.ShowDialog() == DialogResult.OK)
            {
                //CREO EL OBJETO PROV_ARTI_MODIFICADO y le Asigno los valores correspondientes con el nuevo precio.
                Entidades.Proveedor_Articulo prov_arti_Modificado = new Entidades.Proveedor_Articulo();
                prov_arti_Modificado.Nombre = provToEdit.Nombre;

                //Redondeo a 2 decimales.
                prov_arti_Modificado.CostoCompraProveedor = Decimal.Round(Convert.ToDecimal(formModificarCosto.txtCosto.Text),2);

                prov_arti_Modificado.CodigoArticulo = this.dgvArticulosProveedor.SelectedRows[0].Cells[0].Value.ToString();

                DatosArticulosProveedor.ModificarCosto(prov_arti_Modificado);

                ActualizarListaArticulosProveedor();
            }

        }

        private void frmProveedorABM_Load(object sender, EventArgs e)
        {
            //DESACTIVA LISTADO DE PRODUCTOS DEL PROVEEDOR
            this.gbProvArti.Visible = false;
        }


        


       

    }

       
}
