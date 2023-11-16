using Data.Database;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Artículos
{
    public partial class frmActualizarCodigosDeBarra : frmBASEListaArticulos
    {
       

        public frmActualizarCodigosDeBarra()
        {
            InitializeComponent();
            this.OrdenarColumnas("codigo", "descripcion", "codigobarras");
            this.FiltrarConSinCodigo();
            
        }

        private void FiltrarConSinCodigo()
        {
            this.AplicaFiltros();
            if(!(cbxSinCodigoOnly.CheckState == CheckState.Indeterminate)) 
            {

                if (!cbxSinCodigoOnly.Checked) 
                {
                    this.ListaArticulosFiltrados = this.ListaArticulosFiltrados.Where(x => x.CodigoBarras != null && x.CodigoBarras != "").ToList();
                    this.Text = "Lista de Artículos: SOLO CON CODIGO DE BARRA";
                }
                else
                {
                    this.ListaArticulosFiltrados = this.ListaArticulosFiltrados.Where(x => x.CodigoBarras == null || x.CodigoBarras == "").ToList();
                    this.Text = "Lista de Artículos: SOLO SIN CODIGO DE BARRA";
                }

                dgvListado.DataSource = this.ListaArticulosFiltrados;
                this.OcultarColumnasGrid();
            
            }
        }

        private void btnCargarCodigos_Click(object sender, EventArgs e)
        {
            frmEscanearCodigos frmEscanearCodigos = new frmEscanearCodigos(this.ListaArticulosFiltrados);
            frmEscanearCodigos.ShowDialog();
            this.LimpiarFiltros();
            this.ActualizarLista();
            this.AplicaFiltros();

            this.cbxSinCodigoOnly.CheckState = CheckState.Indeterminate;
            this.FiltrarConSinCodigo();
            this.OcultarColumnasGrid();
        }

        protected override void btnMostrarTodos_Click_1(object sender, EventArgs e)
        {
            base.btnMostrarTodos_Click_1(sender, e);
            this.cbxSinCodigoOnly.CheckState = CheckState.Indeterminate;
            this.FiltrarConSinCodigo();
            this.OcultarColumnasGrid();
        }

        private void cbxSinCodigoOnly_CheckedChanged(object sender, EventArgs e)
        {
            //this.LimpiarFiltros ();
            this.FiltrarConSinCodigo();
            this.OcultarColumnasGrid();
        }
    
        private void OcultarColumnasGrid()
        {
            foreach (DataGridViewColumn column in this.dgvListado.Columns)
            {
                column.Visible = false;
            }

            // Mostrar solo las columnas deseadas
            dgvListado.Columns["codigo"].Visible = true;
            dgvListado.Columns["descripcion"].Visible = true;
            dgvListado.Columns["codigobarras"].Visible = true;
            dgvListado.Columns["proveedor"].Visible = true;
            dgvListado.Columns["familia1"].Visible = true;
            dgvListado.Columns["familia2"].Visible = true;

            // Setear ancho en toda la grilla
            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Setear el ancho de cada columna
            this.dgvListado.Columns["descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dgvListado.Columns["descripcion"].Width = 300;

            this.dgvListado.Columns["codigobarras"].HeaderText = "Código de barras";
            this.dgvListado.Columns["codigobarras"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.dgvListado.Columns["codigobarras"].Width = 120;

        }
    }
}
