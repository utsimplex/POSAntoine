using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop.Artículos
{
    public partial class frmConsultaRapidaStockPrecio : Form
    {
        public frmConsultaRapidaStockPrecio()
        {
            InitializeComponent();
        }

        #region VARIABLES LOCALES

        Data.Database.ArticuloAdapter Datos_ArticulosAdapter = new Data.Database.ArticuloAdapter();
        
        

        #endregion


        #region EVENTOS

        //LOAD
        private void frmConsultaRapidaStockPrecio_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        //CAMBIA TEXTO BUSQUEDA
        private void txtArti_TextChanged(object sender, EventArgs e)
        {
            if (txtArti.Text == "")
            {
                dgvArticulos.DataSource = Datos_ArticulosAdapter.GetAll();
            }
            else
            {
                dgvArticulos.DataSource = Datos_ArticulosAdapter.Busqueda(txtArti.Text);
            }
        }
       
        //CLICK CERRAR
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //CLICK LISTA ARTICULOS - SELECCIONAR ARTICULO
        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.MostrarDatosArtSelect();
        }

        //QUITAR FILTRO CLICK
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.txtArti.Text = "";
            this.ActualizarLista();
            this.txtCodigo.Text = "SELECCIONE";
            this.txtDescripcion.Text = "UN ARTÍCULO";

        }


        // TECLAS ACCESO RAPIDO
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            
            switch (keyData)
            {

                    case Keys.Escape:
                    this.Close();
                    break;
                                
                default:

                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        #endregion





        #region METODOS

        //ACTUALIZAR LISTA
        private void ActualizarLista()
        {
            this.dgvArticulos.DataSource = Datos_ArticulosAdapter.GetAll();
            // ocultar todas las columnas salvo codigo y descripcion
            for (int i = 0; i < dgvArticulos.ColumnCount; i++)
            {
                if (dgvArticulos.Columns[i].HeaderText != "Codigo" && dgvArticulos.Columns[i].HeaderText != "Descripcion")
                {
                    dgvArticulos.Columns[i].Visible = false;
                }
            }
            this.dgvArticulos.Columns["codigo"].HeaderText = "Codigo";
            this.dgvArticulos.Columns["descripcion"].HeaderText = "Descripción";
            this.dgvArticulos.Columns["codigo"].Width = 130;
            this.dgvArticulos.Columns["descripcion"].Width = 310;
            //this.dgvArticulos.Columns["stock"].Visible = false;
            //this.dgvArticulos.Columns["stockmin"].Visible = false;
            //this.dgvArticulos.Columns["precio"].Visible = false;
            //this.dgvArticulos.Columns["proveedor"].Visible = false;
            //this.dgvArticulos.Columns["habilitado"].Visible = false;
            
           
            
        }
        
        //SELECCIONAR ARTÍCULO
        private void MostrarDatosArtSelect()
        {
            this.txtCodigo.Text = dgvArticulos.SelectedRows[0].Cells["codigo"].Value.ToString().ToUpper();
            this.txtDescripcion.Text = dgvArticulos.SelectedRows[0].Cells["descripcion"].Value.ToString().ToUpper();
            this.txtPrecio.Text = dgvArticulos.SelectedRows[0].Cells["precio"].Value.ToString();
            if (dgvArticulos.SelectedRows[0].Cells["stock"].Value.ToString() == "0")
            {
                this.txtStock.Text = "SIN STOCK";
                this.txtStock.ForeColor = Color.Red;
            }
            else
            {
                this.txtStock.Text = dgvArticulos.SelectedRows[0].Cells["stock"].Value.ToString();
                this.txtStock.ForeColor = Color.DarkBlue;
            }

        }

        #endregion

        

     
       
       
        
       
    }
}
