using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop.Artículos
{
    public partial class frmValorizacionDeInventario : Form
    {
        public frmValorizacionDeInventario(int ofrecidos, int stock, decimal valor)
        {
            InitializeComponent();
            this.lblArtOfrecidos.Text = ofrecidos.ToString();
            this.lblArtStock.Text = stock.ToString();


            this.lblValorizacion.Text = AgregarSignoPeso(valor.ToString());
        }


        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string AgregarSignoPeso(string texto)
        {
            texto = "$" + texto;
            return texto;
        }

        
    }
}
