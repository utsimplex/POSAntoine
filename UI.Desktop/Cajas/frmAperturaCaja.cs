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
        //Data.Database.VentasAdapter Datos_VentasAdapter = new Data.Database.VentasAdapter();
        Entidades.Usuario usrActual;

        #endregion


        public frmAperturaCaja(Entidades.Usuario usr)
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
