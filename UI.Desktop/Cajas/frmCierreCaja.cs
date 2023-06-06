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
            txtCerradaPorUsr.Text = usr.usuario;
            dtpFechaCaja.Value = caja.FechaCaja;
            dtpFechaApertura.Value = caja.FechaApertura;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            this.Close();
        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSaldoFinal.Text))
                {
                    throw new Exception("El campo 'Saldo Final' no puede estar vacío.");
                }

                caja.SaldoFinal = new SqlMoney(Convert.ToDecimal(txtSaldoFinal.Text));
                caja.CierraUsuario = usrActual.usuario;

                Datos_CajasAdapter.CerrarCaja(caja.ID, caja.SaldoFinal, caja.CierraUsuario);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la caja: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
