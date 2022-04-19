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
    public partial class frmDetallesVentas : Form
    {
        public frmDetallesVentas()
        {
            InitializeComponent();
        }


        #region Variables

        Data.Database.Ventas_Articulos Datos_VentasArticulos = new Data.Database.Ventas_Articulos();
        
        #endregion


        private void frmDetallesVentas_Load(object sender, EventArgs e)
        {

            this.dgvListado.DataSource = Datos_VentasArticulos.GetAll();
            this.dgvListado.Columns["Subtotal"].Visible = false;
            this.dgvListado.Columns["DescripcionArticulo"].Visible = false;


        }
    }
}
