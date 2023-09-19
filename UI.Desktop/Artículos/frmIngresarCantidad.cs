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
    public partial class frmIngresarCantidad : Form
    {
        public frmIngresarCantidad()
        {
            InitializeComponent();
        }
        public frmIngresarCantidad(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
        }

    
        private void cantidad_ValueChanged(object sender, EventArgs e)
        {
            if (cantidad.Value != 0)
                this.btnAceptar.Enabled = true;
            else
                this.btnAceptar.Enabled = false;
        }
    }
}
