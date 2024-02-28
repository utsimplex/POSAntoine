using Data.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Cajas
{
    public partial class frmCierreCaja : Form
    {
        #region /*/*/*   VARIABLES LOCALES Y PUBLICAS   *\*\*\

        //Data.Database.InformeVentaAdapter Datos_InformeAdapter = new InformeVentaAdapter();
        Data.Database.CajasAdapter Datos_CajasAdapter = new Data.Database.CajasAdapter();
        Entidades.Usuario usrActual;
        public Entidades.Caja caja = null;
        public List<Entidades.VentasXMP> ventasXMP=null;

        #endregion


        public frmCierreCaja(Entidades.Usuario usr, Entidades.Caja cajaActual)
        {
            InitializeComponent();
            usrActual = usr;
            caja = cajaActual;
            txtAbiertaPorUsr.Text = usrActual.usuario;
            txtAbiertaPorUsr.Text = caja.AbreUsuario;
            txtCajaNro.Text = caja.ID.ToString();
            txtDescripcion.Text = caja.Descripcion;
            txtSaldoInicial.Text = caja.SaldoInicial.ToString();
            txtSaldoInicial.ReadOnly = true;
            txtCerradaPorUsr.Text = usr.usuario;
            dtpFechaCaja.Value = caja.FechaCaja;
            dtpFechaApertura.Value = caja.FechaApertura;
            txtVentas.Text = Math.Round(Datos_CajasAdapter.GetVentas(caja.ID), 2).ToString();
            txtEfectivoRendir.Text = Math.Round(Datos_CajasAdapter.GetRendirEfectivo(caja.ID), 2).ToString();
            ventasXMP = Datos_CajasAdapter.GetVentasMP(caja.ID);
            dgvVentasxMP.DataSource = ventasXMP;
            dgvVentasxMP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentasxMP.Columns["Total"].DefaultCellStyle.Format = "c";


        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            //Try to close the cash register
            try
            {
               

                
                //Set the user who closed the cash register
                caja.CierraUsuario = usrActual.usuario;

                //Close the cash register
                Datos_CajasAdapter.CerrarCaja(caja.ID, caja.CierraUsuario);

                //Set the dialog result to OK and close the window
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            //Catch any exceptions
            catch (Exception ex)
            {
                //Show an error message
                MessageBox.Show("Error al cerrar la caja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
