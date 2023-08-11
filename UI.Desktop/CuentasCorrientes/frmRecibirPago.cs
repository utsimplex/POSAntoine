using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UI.Desktop.CuentasCorrientes
{
    public partial class frmRecibirPago : Form
    {
        List<MedioDePago> listaMedioDePagos = new List<MedioDePago>();
        Data.Database.MedioDePagoAdapter Datos_MedioDePagoAdapter = new Data.Database.MedioDePagoAdapter();
        //private Data.Database.MovimientoCajaAdapter movimientoAdapter = new Data.Database.MovimientoCajaAdapter();
        //private Entidades.Caja caja = null;
        //private Entidades.Usuario usr = null;
        public string MedioDePago = "";
        public decimal montoIngresado = 0;
        public frmRecibirPago()
        {
            InitializeComponent();
            this.txtTotal.Enabled = true;
            this.txtTotal.BackColor = Color.White;
        }

        public frmRecibirPago(decimal monto_indicado)
        {
            InitializeComponent();
            this.txtTotal.Text =  monto_indicado.ToString();
            this.txtTotal.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmRecibirPago_Load(object sender, EventArgs e)
        {
            cbxMedioDePago.Items.Clear();
            listaMedioDePagos = Datos_MedioDePagoAdapter.GetMultipleActivo("%").Where(x => x.Activo == true).OrderBy(x => x.Default).OrderBy(x => x.Descripcion).ToList();
            if (listaMedioDePagos != null)
            {
                cbxMedioDePago.DataSource = listaMedioDePagos;
                cbxMedioDePago.DisplayMember = "descripcion";
                cbxMedioDePago.ValueMember = "id";
                cbxMedioDePago.SelectedIndex = listaMedioDePagos.FindIndex(x => x.Default == true);
            }
        }
        //private void GuardarPago()
        //{
        //    movimientoAdapter.registrarMovimiento(new Entidades.MovimientoCaja(caja.ID, txtMotivo.Text, isIngreso, Convert.ToDecimal(txtMonto.Text), usrActual, null));

        //}
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.MedioDePago = this.cbxMedioDePago.Text;
            montoIngresado = Convert.ToDecimal(txtTotal.Text);
            this.DialogResult = DialogResult.Yes;
            this.Close();
            //Imprimir el comprobante recepcion de plata
            //guardar

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //guardar
            this.MedioDePago = this.cbxMedioDePago.Text;
            montoIngresado = Convert.ToDecimal(txtTotal.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
