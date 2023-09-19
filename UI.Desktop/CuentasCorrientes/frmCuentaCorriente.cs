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
    public partial class frmCuentaCorriente : Form
    {

        Entidades.Cliente clienteActual;
        Entidades.Caja cajaActual;
        Entidades.CobroCuentaCorriente cobroCuentaCorriente;
        List<CuentaCorriente> cuentaCorrienteList;
        List<CobroCuentaCorriente> cobroCuentaCorrienteList;
        List<CuentaCorriente> cuentaCorrienteSeleccionada;
        Usuario User;

        Data.Database.VentasAdapter Datos_VentasAdapter = new Data.Database.VentasAdapter();
        Data.Database.ClienteAdapter Datos_ClienteAdapter = new Data.Database.ClienteAdapter();
        Data.Database.CajasAdapter Datos_CajaAdapter = new Data.Database.CajasAdapter();
        Data.Database.CuentaCorrienteAdapter Datos_CuentaCorrienteAdapter = new Data.Database.CuentaCorrienteAdapter();
        Data.Database.MovimientoCajaAdapter Datos_MovimientoCaja = new Data.Database.MovimientoCajaAdapter();
        Data.Database.CobroCuentaCorrienteAdapter Datos_CobroCuentaCorriente = new Data.Database.CobroCuentaCorrienteAdapter();
        DialogResult recibePagoResult;
        string facturasSeleccionadas = "";
        decimal montoAPagar = 0;
        public frmCuentaCorriente(Usuario usr, Caja caja)
        {
            InitializeComponent();
            cajaActual = caja;
            User = usr;
        }

        public frmCuentaCorriente(string documentoCliente,Usuario usr)
        {
            InitializeComponent();
            User = usr;
            cajaActual = Datos_CajaAdapter.GetCajaAbierta();
            if(cajaActual==null)
            {
                MessageBox.Show("No existen Cajas Abiertas. No podra recibir nuevos pagos.");
                this.btnPagarSeleccion.Enabled = this.btnRecibirPago.Enabled = false;
            }
            clienteActual = Datos_ClienteAdapter.GetOne(Convert.ToInt64(documentoCliente));
            if (clienteActual != null)
            {
                this.BuscarCuentaCorriente();
                this.BuscarCobrosCuentaCorriente();
            }
            this.AsignaDatosClienteUI();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            clienteActual = BuscarCliente();
            if(clienteActual!=null)
            {
                this.BuscarCuentaCorriente();
            }
            this.AsignaDatosClienteUI();
        }
        private Entidades.Cliente BuscarCliente()
        {
            Clientes.frmListadoClientes formListaClientes = new UI.Desktop.Clientes.frmListadoClientes();
            formListaClientes.ModoForm = UI.Desktop.Clientes.frmListadoClientes.TipoForm.SeleccionDeCliente;

            if (formListaClientes.ShowDialog() == DialogResult.Yes)
            {
                clienteActual = Datos_ClienteAdapter.GetOne((long)formListaClientes.dniClienteSelecccionado);
            }
            return clienteActual;


        }
        private void RegistrarPagoCuentaCorriente()
        {
            if (recibePagoResult == DialogResult.OK || recibePagoResult == DialogResult.Yes)
            {

                Datos_CobroCuentaCorriente.AñadirNuevo(cobroCuentaCorriente);

                //cuentaCorrienteSeleccionada.ForEach(CC =>
                //{
                //    ActualizaFactura(CC.Venta, CC.Pendiente, true);
                //});
            }
        }
        private void GuardarPago()
        {
            if(recibePagoResult == DialogResult.OK || recibePagoResult== DialogResult.Yes)
            {
                
                Datos_MovimientoCaja.registrarMovimiento(new Entidades.MovimientoCaja(cajaActual.ID, "Pago Cta Cte", true, montoAPagar, User.usuario, facturasSeleccionadas));

                //cuentaCorrienteSeleccionada.ForEach(CC =>
                //{
                //    ActualizaFactura(CC.Venta, CC.Pendiente, true);
                //});
            }
        }
        private void ImprimirPago()
        {
            if (recibePagoResult == DialogResult.Yes)
            {
             //imprime movimiento en comandera   
            }
        }
        private void ActualizaFactura(int NumVenta, decimal MontoPagado, bool EsTotal)
        {
            Datos_VentasAdapter.ActualizarPago(NumVenta, MontoPagado, EsTotal);
        }
        private void BuscarFacturasACancelar ( decimal monto)
        {
            //hago un ordenamiento de facturas para pagar desde la mas vieja a la mas nueva cuando se recibe unpago
            cuentaCorrienteList.Where(x=>x.Pendiente>0)
                .OrderBy(x => x.Fecha)
                .ToList()
                .ForEach(CC => {
                    if(monto>=CC.Pendiente)
                    {
                        facturasSeleccionadas += String.IsNullOrEmpty(facturasSeleccionadas) ? CC.Venta.ToString() : " - " + CC.Venta.ToString();
                        monto -= CC.Pendiente;
                        ActualizaFactura(CC.Venta,CC.Pendiente,true);
                    }
                    else if(monto>0)
                    {
                        facturasSeleccionadas += String.IsNullOrEmpty(facturasSeleccionadas) ? CC.Venta.ToString() : " - " + CC.Venta.ToString();
                        ActualizaFactura(CC.Venta, monto,false);
                        monto = 0;
                    }
                });
        }
        private List<Entidades.CuentaCorriente> BuscarCuentaCorriente()
        {
            
                cuentaCorrienteList = Datos_CuentaCorrienteAdapter.GetPendientesCliente(Convert.ToInt64(clienteActual.NumeroDocumento));
            
            return cuentaCorrienteList;

        }
        private List<Entidades.CobroCuentaCorriente> BuscarCobrosCuentaCorriente()
        {

            cobroCuentaCorrienteList = Datos_CobroCuentaCorriente.GetMultipleCliente(clienteActual.NumeroDocumento);

            return cobroCuentaCorrienteList;

        }
        private void AsignaDatosClienteUI()
        {
            tbxCliente.Text = clienteActual.Nombre + " " + clienteActual.Apellido;
            if (cuentaCorrienteList != null && cuentaCorrienteList.Count > 0)
            {
                tbxPendiente.Text = "$" + cuentaCorrienteList.Sum(X => X.Pendiente).ToString();
                dgvFacturas.DataSource = cuentaCorrienteList;
            }
            else
            {
                tbxPendiente.Text = "$0.00";
                dgvFacturas.DataSource = cuentaCorrienteList;
            }
            if (cobroCuentaCorrienteList != null && cobroCuentaCorrienteList.Count > 0)
            {
                dgvCobros.DataSource = cobroCuentaCorrienteList;
                dgvCobros.Columns[0].Visible = false;
            }
        }

        private void btnPagarSeleccion_Click(object sender, EventArgs e)
        {
            montoAPagar = 0;
            facturasSeleccionadas = "";
            cobroCuentaCorriente = new CobroCuentaCorriente();
            cuentaCorrienteSeleccionada = new List<CuentaCorriente>();
            if (dgvFacturas.SelectedRows.Count>0)
            {
                foreach(DataGridViewRow row in dgvFacturas.SelectedRows)
                {
                    cuentaCorrienteSeleccionada.Add(cuentaCorrienteList.First(x => x.Venta == (int)row.Cells["Venta"].Value));
                    montoAPagar += Convert.ToDecimal(row.Cells["Pendiente"].Value);
                    facturasSeleccionadas += String.IsNullOrEmpty(facturasSeleccionadas)? row.Cells["Venta"].Value.ToString(): " - "+ row.Cells["Venta"].Value.ToString();
                }
                if (montoAPagar > 0)
                {
                    frmRecibirPago formRecibePago = new frmRecibirPago(montoAPagar);
                    recibePagoResult = formRecibePago.ShowDialog();
                    //evaluo dentro de cada metodo si corresponde realizar la accion o no
                    montoAPagar = formRecibePago.montoIngresado;
                    cobroCuentaCorriente = new CobroCuentaCorriente()
                    {
                        FacturasAfectadas = facturasSeleccionadas,
                        FechaHora = DateTime.Now,
                        MedioDePago = formRecibePago.MedioDePago,
                        MontoRecibido = formRecibePago.montoIngresado,
                        NumeroDocumentoCliente = clienteActual.NumeroDocumento
                    };
                    RegistrarPagoCuentaCorriente();
                    if (formRecibePago.MedioDePago.ToLower() == "efectivo")
                        GuardarPago();
                    ImprimirPago();
                    RefrescarGrilla();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecibirPago_Click(object sender, EventArgs e)
        {
            montoAPagar = 0;
            facturasSeleccionadas = "";
            cuentaCorrienteSeleccionada = new List<CuentaCorriente>();//limpio la variable

            frmRecibirPago formRecibePago = new frmRecibirPago();
            recibePagoResult = formRecibePago.ShowDialog();
            //buscar Facturas a Cancelar
            montoAPagar = formRecibePago.montoIngresado;
            if (montoAPagar > 0)
            {
                BuscarFacturasACancelar(montoAPagar);
                //evaluo dentro de cada metodo si corresponde realizar la accion o no
                cobroCuentaCorriente = new CobroCuentaCorriente()
                {
                    FacturasAfectadas = facturasSeleccionadas,
                    FechaHora = DateTime.Now,
                    MedioDePago = formRecibePago.MedioDePago,
                    MontoRecibido = formRecibePago.montoIngresado,
                    NumeroDocumentoCliente = clienteActual.NumeroDocumento
                };
                RegistrarPagoCuentaCorriente();
                if(formRecibePago.MedioDePago.ToLower()=="efectivo")
                GuardarPago();

                ImprimirPago();
                RefrescarGrilla();
            }
        }
        private void RefrescarGrilla()
        {
            if (clienteActual != null)
            {
                this.BuscarCuentaCorriente();
                this.BuscarCobrosCuentaCorriente();
            }
                this.AsignaDatosClienteUI();
        }

        private void chkbxPendientes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxPendientes.Checked)
            {
                chkbxVencidas.Checked = false;
                this.dgvFacturas.DataSource = cuentaCorrienteList.Where(x => x.Total != x.Pagado).ToList();
            }
            else
                this.dgvFacturas.DataSource = cuentaCorrienteList;
        }

        private void chkbxVencidas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxVencidas.Checked)
            {
                chkbxPendientes.Checked = false;
                this.dgvFacturas.DataSource = cuentaCorrienteList.Where(x => x.Total != x.Pagado && x.Fecha.Date.AddDays(30) <= DateTime.Today).ToList();
            }
            else
            { 
            this.dgvFacturas.DataSource = cuentaCorrienteList;
            }
        }

        private void tabCobros_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void tabGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.tabGeneral.SelectedTab.Name == "tabCobros")
                this.btnPagarSeleccion.Enabled = this.btnRecibirPago.Enabled = false;
            else
                this.btnPagarSeleccion.Enabled = this.btnRecibirPago.Enabled = true;
        }
    }
}
