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
    public partial class frmAperturaCaja : Form
    {
        #region /*/*/*   VARIABLES LOCALES   *\*\*\

        //Data.Database.InformeVentaAdapter Datos_InformeAdapter = new InformeVentaAdapter();
        Data.Database.CajasAdapter Datos_CajasAdapter = new Data.Database.CajasAdapter();
        Entidades.Usuario usrActual;
        public Entidades.Caja caja = null;

        #endregion


        public frmAperturaCaja(Entidades.Usuario usr)
        {
            InitializeComponent();
            usrActual = usr;
            txtUsuario.Text = usrActual.usuario;
        }
        public frmAperturaCaja(Entidades.Usuario usr,Entidades.Caja cajaActual)
        {
            InitializeComponent();
            usrActual = usr;
            txtUsuario.Text = usrActual.usuario;
            caja = cajaActual;
            this.DatosCajaUI();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            this.Close();
        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            if (caja == null)
                caja = Datos_CajasAdapter.CrearAbrirCaja(usrActual.usuario, dtpFechaCaja.Value, Convert.ToDecimal(txtSaldoInicial.Text.Trim()), txtDescripcion.Text);
            else
                Datos_CajasAdapter.ActualizaCaja(usrActual.usuario, dtpFechaCaja.Value, Convert.ToDecimal(txtSaldoInicial.Text.Trim()), txtDescripcion.Text, caja.ID);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void DatosCajaUI()
        {
            this.txtSaldoInicial.Text = caja.SaldoInicial.ToString();
            txtDescripcion.Text = caja.Descripcion;
            txtCajaNro.Text = caja.ID.ToString();
            txtUsuario.Text = caja.AbreUsuario.ToString();

        }
    }
}
