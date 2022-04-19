using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop.Mensajes
{
    public partial class frmConfirmar : Form
    {
        public frmConfirmar(string mensaje,string boton)
        {
            InitializeComponent();
            lblAtencion.Text = mensaje;
            btnSi.Text = "Si " + boton;
            btnNo.Text = "No " + boton;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
