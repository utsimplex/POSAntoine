using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop.Ventas
{
    public partial class frmConfirmarVta : Form
    {
        public bool cuentaCorriente=false;
        public frmConfirmarVta()
        {
            InitializeComponent();
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            if (txtPago.Text != "")
            {
                txtVuelto.Text = Convert.ToString(Convert.ToDecimal(txtPago.Text) - Convert.ToDecimal(txtTotal.Text));
            }
            else if (txtPago.Text == "")
            {
                txtVuelto.Text = "0";
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmConfirmarVta_Load(object sender, EventArgs e)
        {

        }

        private void btnCtaCte_Click(object sender, EventArgs e)
        {
            this.cuentaCorriente = true;
            this.DialogResult = DialogResult.OK;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
        }
    }
}
