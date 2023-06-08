using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;

namespace UI.Desktop.Cajas
{
    public partial class frmMovimientoCaja : Form
    {
        private Boolean isIngreso = false;
        private Data.Database.MovimientoCajaAdapter movimientoAdapter = new Data.Database.MovimientoCajaAdapter();
        private Entidades.Caja caja = null;
        private string usrActual = null;

        public frmMovimientoCaja(Boolean ingresaEfectivo, Entidades.Caja cajaActual, string usr)
        {
            InitializeComponent();
            isIngreso = ingresaEfectivo;
            lblLabel.Text = isIngreso ? "Monto a ingresar:" : "Monto a retirar";
            caja = cajaActual;
            usrActual = usr;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            movimientoAdapter.registrarMovimiento(new Entidades.MovimientoCaja(caja.ID, txtMotivo.Text, isIngreso, Convert.ToDecimal(txtMonto.Text), usrActual));
        }
    }
}
