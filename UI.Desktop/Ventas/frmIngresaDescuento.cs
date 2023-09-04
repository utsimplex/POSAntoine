using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Ventas
{
    public partial class frmIngresaDescuento : Form
    {
        public decimal descuento = 0;
        public string _modo = "";
        public decimal _precioMaximo = 0;
        public frmIngresaDescuento()
        {
            InitializeComponent();
        }
        public frmIngresaDescuento(string modo, decimal precio)
        {
            InitializeComponent();
            _modo = modo;
            _precioMaximo = Math.Abs(precio);
            if (_modo == "%")
            {
                this.groupBox1.Text = "Porcentaje";

            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtDescuento.Text) && Convert.ToInt32(this.txtDescuento.Text)>0)
            { 
                if(_modo== "%") 
                { 
                    descuento = Convert.ToInt32(this.txtDescuento.Text.ToString());
                }
                else if( _modo =="$")
                {
                    descuento = Convert.ToDecimal(this.txtDescuento.Text.ToString());
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtDescuento_Leave(object sender, EventArgs e)
        {
            if(_modo =="%" && !String.IsNullOrEmpty(this.txtDescuento.Text))
            {
                if (Convert.ToInt32(this.txtDescuento.Text.ToString()) > 100)
                {
                    MessageBox.Show("El valor del porcentaje no puede superar el 100%");
                    this.txtDescuento.Text = "0";
                }
            }
            else if(!String.IsNullOrEmpty(this.txtDescuento.Text))
            {
                if (Convert.ToInt32(this.txtDescuento.Text.ToString()) > _precioMaximo)
                {
                    MessageBox.Show("El monto de descuento no puede superar el monto total de la linea");
                    this.txtDescuento.Text = "0";
                }
            }
        }

        private void txtDescuento_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {

                case (char)Keys.Enter:
                    this.btnAceptar_Click(sender, null);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;

                case (char)Keys.Escape:
                    this.Close();
                    break;
            }
        }
    }
}
