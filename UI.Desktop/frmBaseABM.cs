using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class frmBaseABM : Form
    {
        public frmBaseABM()
        {
            InitializeComponent();
        }

        // LOAD
        private void frmBaseABM_Load(object sender, EventArgs e)
        {
          
            
        }

        virtual protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        virtual protected void txtNroDoc_Leave(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    



      
      
      
        
     

      

        

    }
}
