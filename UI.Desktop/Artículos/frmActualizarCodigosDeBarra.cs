using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Artículos
{
    public partial class frmActualizarCodigosDeBarra : frmBASEListaArticulos
    {
        public frmActualizarCodigosDeBarra()
        {
            InitializeComponent();
            this.OrdenarColumnas("codigo", "descripcion", "codigobarras");


        }

        private void btnCargarCodigos_Click(object sender, EventArgs e)
        {

        }
    }
}
