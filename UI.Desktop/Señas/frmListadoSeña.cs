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
using UI.Desktop.Artículos;

namespace UI.Desktop.Seña
{
    public partial class frmListadoSeña : frmBaseListado
    {

        public List<Entidades.Seña> ListaSeñas;
        public List<Entidades.Seña> ListaSeñasFiltrado;
        public string DNICliente;
        public Entidades.Seña señaActual;
        Data.Database.SeñasAdapter Datos_SeñasAdapter = new Data.Database.SeñasAdapter();

        public frmListadoSeña(string DniCliente)
        {
            InitializeComponent();
            btnAñadirNuevo.Visible = btnEliminar.Visible = btnModificar.Visible = false;
            DNICliente = DniCliente;
            ActualizarLista();
        }
        private void ActualizarLista()
        {
            ListaSeñas = Datos_SeñasAdapter.GetAllSeñas(DNICliente);
            ListaSeñasFiltrado = ListaSeñas.Where(a => a.NumVentaAplicada == null).ToList();

            dgvListado.DataSource = ListaSeñasFiltrado;

            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvListado.Size = new Size(1077, 490);
            this.dgvListado.Location = new Point(7, 56);


            dgvListado.Columns["NumVentaAplicada"].Visible = false;

        }
        override public void dgvListado_DoubleClick(object sender, EventArgs e)
        {
         SeleccionarSeña();
        }
        private void SeleccionarSeña()
        {
            if (!(this.dgvListado.SelectedRows.Count > 0))
            {
                return;
            }

                señaActual = new Entidades.Seña();

                señaActual.NumeroSeña = Convert.ToInt32(dgvListado.SelectedRows[0].Cells["NumeroSeña"].Value.ToString());
                señaActual.DniCliente = dgvListado.SelectedRows[0].Cells["DniCliente"].Value.ToString();
                señaActual.FechaHora = Convert.ToDateTime(dgvListado.SelectedRows[0].Cells["FechaHora"].Value.ToString());
                señaActual.TipoPago = dgvListado.SelectedRows[0].Cells["TipoPago"].Value.ToString();
                señaActual.Total = Convert.ToDecimal(dgvListado.SelectedRows[0].Cells["Total"].Value.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();


        }

    }
}
