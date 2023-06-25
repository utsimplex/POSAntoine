using Data.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Cajas
{
    public partial class frmCajas : frmBaseListado
    {

        #region /*/*/*   VARIABLES LOCALES   *\*\*\

        //Data.Database.InformeVentaAdapter Datos_InformeAdapter = new InformeVentaAdapter();
        Data.Database.CajasAdapter Datos_CajasAdapter = new Data.Database.CajasAdapter();
        Entidades.Usuario usrActual;
        Entidades.Caja cajaSeleccionada;
        //LISTA DE ARTICULOS
        public BindingList<Entidades.Caja> ListaCajas;


        #endregion


        public frmCajas(Entidades.Usuario usr)
        {
            InitializeComponent();
                        usrActual = usr;
            limpiarUI();
        }

        // Ocultar controles innecesarios
        private void limpiarUI()
        {
            btnExportar.Visible = false;
            btnImportar.Visible = false;
            btnEliminar.Visible = false;
            btnExportar.Enabled = false;
            btnImportar.Enabled = false;
            btnEliminar.Enabled = false;
        }



        #region /*/*/*   METODOS   *\*\*\
        // ACTUALIZAR LISTA DE Cajas
        private void ActualizarListaCajas()
        {
            //dgvListado.DataSource = Datos_CajasAdapter.GetAll();
            //dgvListado.Refresh();

            ListaCajas = Datos_CajasAdapter.GetCajas();

            dgvListado.DataSource = ListaCajas.ToList();
            dgvListado.Size = new Size(1080, 429);
            AcomodarGrilla();
        }


        private void AcomodarGrilla()
        {
            this.dgvListado.Columns["ID"].Width = 35;

            this.dgvListado.Columns["fechaCaja"].DisplayIndex = 1;
            this.dgvListado.Columns["fechaCaja"].HeaderText = "Fecha de caja";

            this.dgvListado.Columns["fechaApertura"].DisplayIndex = 2;
            this.dgvListado.Columns["fechaApertura"].HeaderText = "Fecha apertura";


            this.dgvListado.Columns["descripcion"].HeaderText = "Descripción";
            this.dgvListado.Columns["descripcion"].Width = 200;
            this.dgvListado.Columns["descripcion"].DisplayIndex = 3;

            this.dgvListado.Columns["saldoInicial"].DisplayIndex = 4;
            this.dgvListado.Columns["saldoInicial"].HeaderText = "Saldo Inicial";

            this.dgvListado.Columns["abreUsuario"].DisplayIndex = 5;
            this.dgvListado.Columns["abreUsuario"].HeaderText = "Abierta por";

            this.dgvListado.Columns["fechaCierre"].DisplayIndex = 6;
            this.dgvListado.Columns["fechaCierre"].HeaderText = "Fecha cierre";

            this.dgvListado.Columns["saldoFinal"].DisplayIndex = 7;
            this.dgvListado.Columns["saldoFinal"].HeaderText = "Saldo Final";


            this.dgvListado.Columns["montoNetoMovimientos"].DisplayIndex = 8;
            this.dgvListado.Columns["montoNetoMovimientos"].HeaderText = "Neto movimientos";

            this.dgvListado.Columns["montoVentasTotal"].DisplayIndex = 9;

            this.dgvListado.Columns["montoVentasTotal"].HeaderText = "Neto ventas";

            this.dgvListado.Columns["cierraUsuario"].DisplayIndex = 10;

            this.dgvListado.Columns["cierraUsuario"].HeaderText = "Cerrada por";

            //this.dgvListado.Columns["descripcion"].HeaderText = "Descripción";
            //this.dgvListado.Columns["stockMin"].HeaderText = "Stock Min.";
            //this.dgvListado.Columns["precio"].HeaderText = "Precio ($)";
            //this.dgvListado.Columns["stock"].Width = 45;
            //this.dgvListado.Columns["stockMin"].Width = 45;
            //this.dgvListado.Columns["precio"].Width = 75;
        }

        #endregion

        #region /*/*/*   EVENTOS   *\*\*\
        private void frmCajas_Load(object sender, EventArgs e)
        {
            ActualizarListaCajas();
        }


        #endregion

        private void tbxFiltro_TextChanged_1(object sender, EventArgs e)
        {
            this.dgvListado.DataSource = ListaCajas.Where(c => c.AbreUsuario == tbxFiltro.Text).ToList();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows[0] != null)
                if (Datos_CajasAdapter.CajaTieneMovimientos((int)dgvListado.SelectedRows[0].Cells["id"].Value))
                {
                    MessageBox.Show("No se puede editar una caja con ventas y/o movimientos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            else
                {
                    cajaSeleccionada = ListaCajas.First(x => x.ID == (int)dgvListado.SelectedRows[0].Cells["id"].Value);
                    frmAperturaCaja formCaja = new frmAperturaCaja(usrActual, cajaSeleccionada);
                    formCaja.ShowDialog();
                    //MostrarFormularioEdicionCaja
                    this.ActualizarListaCajas();
                }
        }
    }
}
