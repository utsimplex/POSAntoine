using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop.Proveedores
{
    public partial class frmModifCosto : Form
    {
        public frmModifCosto()
        {
            InitializeComponent();
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCostoIngresado())
            {
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private bool ValidarCostoIngresado()
        {
            // al ingresar .. en el costo sale error y se cuelga. hay q corregir esto
            try
            {
                this.txtCosto.Text = txtCosto.Text.Replace(".", ",");
                txtCosto.Text = Decimal.Round(Convert.ToDecimal(txtCosto.Text), 2).ToString();
                return true;
            }
            catch (Exception Ex)
            {
                Ex = new Exception("-Error. Ingrese nuevamente el costo");

                MessageBox.Show(Ex.Message);
                return false;
            }

        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar)) //Al pulsar un nro
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else if (Char.IsControl(e.KeyChar) || Char.IsPunctuation(e.KeyChar)) //Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false; //Se acepta (todo OK)
            }
            else //Para todo lo demas
            {
                e.Handled = true; //No se acepta (si pulsas cualquier otra cosa pues no se envia)
            }
        }
    }
}
