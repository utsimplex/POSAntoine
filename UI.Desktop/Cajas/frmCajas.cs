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
        //Data.Database.VentasAdapter Datos_VentasAdapter = new Data.Database.VentasAdapter();
        Entidades.Usuario usrActual;


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
        // ACTUALIZAR LISTA DE VENTAS
        private void ActualizarListaCajas()
        {
            //dgvListado.DataSource = Datos_CajasAdapter.GetAll();
            //dgvListado.Refresh();
            dgvListado.Size = new Size(820, 429);

        }


        #endregion

        #region /*/*/*   EVENTOS   *\*\*\
        private void frmCajas_Load(object sender, EventArgs e)
        {
            ActualizarListaCajas();
        }


        #endregion

    }
}
