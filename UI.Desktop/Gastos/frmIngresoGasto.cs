using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Gastos
{
    public partial class frmIngresoGasto : Form
    {
        int? cajaId;
        Data.Database.CajasAdapter Datos_CajasAdapter = new Data.Database.CajasAdapter();
        Data.Database.GastosAdapter Datos_GastosAdapter = new Data.Database.GastosAdapter();
        Data.Database.MovimientoCajaAdapter Datos_MovimientosAdapter = new Data.Database.MovimientoCajaAdapter();
        Entidades.Gasto gastoActual = new Entidades.Gasto();
        public frmIngresoGasto()
        {
            InitializeComponent();
            CajaAbierta();
            CompleteCombox();
            chkbxEgreso.Enabled = cajaId != null;

        }
        private void CompleteCombox()
        {
            cbxTipoGasto.Items.Add("Alquiler");
            cbxTipoGasto.Items.Add("Compra de Mercaderia");
            cbxTipoGasto.Items.Add("Gastos Varios");
            cbxTipoGasto.Items.Add("Insumos");
            cbxTipoGasto.Items.Add("Sueldos");
            cbxTipoGasto.Items.Add("Transporte");

        }
        private void CajaAbierta()
        {
            Entidades.Caja cajaActual = Datos_CajasAdapter.GetCajaAbierta();
            if (cajaActual != null)
                cajaId = cajaActual.ID;
        }
        private void controlesAmodelo()
        {
            gastoActual = new Entidades.Gasto()
            {
                CajaId = cajaId!=null && chkbxEgreso.Checked ? cajaId: null,
                Descripcion = txtDescripcion.Text.Trim(),
                Monto = Convert.ToDecimal(txtMonto.Text),
                TipoGasto = cbxTipoGasto.SelectedItem.ToString(),
                Fecha = dtpFecha.Value

            };
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            controlesAmodelo();
            try
            {
            Datos_GastosAdapter.registrarGasto(ref gastoActual);
            if(gastoActual.CajaId != null && chkbxEgreso.Checked)
            {
                Entidades.MovimientoCaja movimiento = new Entidades.MovimientoCaja((int)gastoActual.CajaId, "Gasto" + gastoActual.id.ToString(), false, Convert.ToDecimal(txtMonto.Text), "Admin", "");
                Datos_MovimientosAdapter.registrarMovimiento(movimiento);
            }
                MessageBox.Show("Movimiento Registrado con éxito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar un gasto: " + ex.Message);
            }
        }
    }
}
