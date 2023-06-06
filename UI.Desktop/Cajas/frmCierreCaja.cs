using Data.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Cajas
{
    public partial class frmCierreCaja : Form
    {
        #region /*/*/*   VARIABLES LOCALES   *\*\*\

        //Data.Database.InformeVentaAdapter Datos_InformeAdapter = new InformeVentaAdapter();
        Data.Database.CajasAdapter Datos_CajasAdapter = new Data.Database.CajasAdapter();
        Entidades.Usuario usrActual;
        public Entidades.Caja caja = null;

        #endregion


        public frmCierreCaja(Entidades.Usuario usr)
        {
            InitializeComponent();
            usrActual = usr;
            txtUsuario.Text = usrActual.usuario;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            this.Close();
        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            caja = Datos_CajasAdapter.CrearAbrirCaja(usrActual.usuario, dtpFechaCaja.Value, Convert.ToDecimal(txtSaldoInicial.Text.Trim()), txtDescripcion.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
