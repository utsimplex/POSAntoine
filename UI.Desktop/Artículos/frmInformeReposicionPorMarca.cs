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
    public partial class frmInformeReposicionPorMarca : Form
    {
        public frmInformeReposicionPorMarca(string marca)
        {
            InitializeComponent();
            this.Text = this.Text + " " + marca;
        }

        
    }
}
