using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Database;
using Entidades;

namespace UI.Desktop.Ventas
{
    public partial class frmHistorialVentas : frmBaseListado
    {
        public frmHistorialVentas(Entidades.Usuario usr)
        {
            InitializeComponent();
            base.btnAñadirNuevo.Visible = false;
            base.btnEliminar.Visible = false;
            base.btnExportar.Visible = false;
            base.btnImportar.Visible = false;
            base.btnModificar.Visible = false;
            usrActual = usr;
        }


        #region /*/*/*   VARIABLES LOCALES   *\*\*\

        Data.Database.InformeVentaAdapter Datos_InformeAdapter = new InformeVentaAdapter();
        Data.Database.VentasAdapter Datos_VentasAdapter = new Data.Database.VentasAdapter();
        Entidades.Usuario usrActual;
        List<Venta> ListaVentas;

        #endregion

        #region /*/*/*   METODOS   *\*\*\

        // ACTUALIZAR LISTA DE VENTAS
        private void ActualizarLista()
        {
            //Solamente voy a la base de datos si mi variable local de ventas esta vacia
            if(ListaVentas == null)
            ListaVentas = Datos_VentasAdapter.GetAll();

            int? ultimaCaja = ListaVentas.Max(x => x.CajaId);
            if (chbxSoloCajaAbierta.Checked && ultimaCaja != null)
                dgvListado.DataSource = ListaVentas.Where(x=>x.CajaId ==ultimaCaja).ToList();
            else
                dgvListado.DataSource = ListaVentas;
            //dgvListado.Refresh();
            dgvListado.Columns["DniCliente"].Visible = dgvListado.Columns["TipoDocumentoClienteRO"].Visible = dgvListado.Columns["CuitEmisor"].Visible = dgvListado.Columns["SituacionFiscalClienteRO"].Visible
                = dgvListado.Columns["QRBase64RO"].Visible = dgvListado.Columns["puntoDeVentaRO"].Visible = dgvListado.Columns["numeroDeComprobanteFiscalRO"].Visible = dgvListado.Columns["TipoOperacion"].Visible  =false;
            dgvListado.Columns["Neto"].Visible = dgvListado.Columns["Iva"].Visible = dgvListado.Columns["TipoComprobante"].Visible = dgvListado.Columns["NumeroTicketFiscal"].Visible = dgvListado.Columns["CAE"].Visible =
                dgvListado.Columns["VencimientoCAE"].Visible = dgvListado.Columns["DireccionCliente"].Visible = dgvListado.Columns["LetraComprobateRO"].Visible = dgvListado.Columns["TipoDocumentoCliente"].Visible =
                dgvListado.Columns["SituacionFiscalCliente"].Visible = dgvListado.Columns["PuntoDeVenta"].Visible = false;
            dgvListado.Columns["CajaID"].HeaderText = "N° Caja";
            dgvListado.Columns["NumeroDocumentoCliente"].HeaderText = "Documento Cliente";
            dgvListado.Columns["NombreCliente"].HeaderText = "Cliente";
            dgvListado.Columns["ComprobanteFiscalRO"].HeaderText = "Factura";
            dgvListado.Size = new Size(820, 429);

        }

        //Modificar Comprobante
        private void ModificarComprobante()
        {
            Entidades.Venta vtaSeleccionada = new Entidades.Venta();

            vtaSeleccionada.Descuento = Convert.ToDecimal(dgvListado.SelectedRows[0].Cells["Descuento"].Value.ToString());
            vtaSeleccionada.DniCliente = dgvListado.SelectedRows[0].Cells["DniCliente"].Value.ToString();
            vtaSeleccionada.FechaHora = Convert.ToDateTime(dgvListado.SelectedRows[0].Cells["FechaHora"].Value);
            vtaSeleccionada.NumeroVenta = Convert.ToInt32(dgvListado.SelectedRows[0].Cells["NumeroVenta"].Value.ToString());
            vtaSeleccionada.TipoPago = dgvListado.SelectedRows[0].Cells["TipoPago"].Value.ToString();
            vtaSeleccionada.Total = Convert.ToDecimal(dgvListado.SelectedRows[0].Cells["Total"].Value.ToString());
            vtaSeleccionada.Usuario = dgvListado.SelectedRows[0].Cells["Usuario"].Value.ToString();
            vtaSeleccionada.TipoOperacion = dgvListado.SelectedRows[0].Cells["TipoOperacion"].Value.ToString();

            if (dgvListado.SelectedRows[0].Cells["NumeroVenta"].Value.ToString() != "")
            {
                frmVenta formModificarVenta = new frmVenta(usrActual, Datos_VentasAdapter.GetOne((int)dgvListado.SelectedRows[0].Cells["NumeroVenta"].Value));
                formModificarVenta.Text = "Modificar Venta";
                formModificarVenta.ShowDialog();
                ActualizarLista();
                
            }

        }




        #endregion

        private void frmHistorialVentas_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxFiltro_TextChanged_1(object sender, EventArgs e)
        {
            VentasAdapter adapter = new VentasAdapter();
            if (tbxFiltro.Text == "")
            {
                dgvListado.DataSource = adapter.GetAll();

            }
            else
            {
                dgvListado.DataSource = adapter.Busqueda(tbxFiltro.Text);
            }
        }

        private void btnVerComprobante_Click(object sender, EventArgs e)
        {
            int numVenta = Convert.ToInt32(this.dgvListado.SelectedRows[0].Cells["NumeroVenta"].Value.ToString());

            //Venta ventaActual = ListaVentas.First(x=> x.NumeroVenta == numVenta);
            Venta ventaActual = Datos_VentasAdapter.GetOne(numVenta);

            frmVenta formVentaReadOnly = new frmVenta(usrActual, ventaActual);
            if(formVentaReadOnly.ShowDialog() != DialogResult.Cancel)
            {
            //TO-DO: si se factura habria que actualizar los datos fiscales
            this.dgvListado.SelectedRows[0].Cells["TipoPago"].Value = formVentaReadOnly.medioDePago;
            dgvListado.Refresh();
            }
            //string tipooperacion = (this.dgvListado.SelectedRows[0].Cells["TipoOperacion"].Value.ToString());

            //string sql = "SELECT Ventas.numVenta, Ventas.fechaHora, Ventas.TipoPago, Ventas.Total, Clientes.dni, Clientes.apellido + ', ' + Clientes.nombre AS [Nombre y Apellido], Ventas_Articulos.CFARTCODIGO, Articulos.Descripcion, Ventas_Articulos.cantidad, Ventas_Articulos.precio FROM [Ventas] INNER JOIN [Ventas_Articulos] on Ventas.numVenta = Ventas_Articulos.CFVENNumVenta AND Ventas.TipoOperacion = Ventas_Articulos.TipoOperacion INNER JOIN [Articulos] on Ventas_Articulos.CFArtCodigo = Articulos.codigo LEFT JOIN [Clientes] on Ventas.dniCliente = Clientes.dni  WHERE (Ventas.numVenta =" + numVenta + " AND Ventas.TipoOperacion = '" + tipooperacion+ "'" + ")";

            //if (Datos_InformeAdapter.BuscarRegistros(sql))
            //{
            //    System.IO.Directory.CreateDirectory("C:\\XML");
            //    string url = "C:\\XML\\informeVenta.xml";

            //    Datos_InformeAdapter.tablas.WriteXml(url, XmlWriteMode.WriteSchema);

            //}

            //frmInformeVenta formInformeVenta = new frmInformeVenta();
            //formInformeVenta.ShowDialog();
            //System.IO.File.Delete("C:\\XML\\informeVenta.xml"); 
        }

        private void btnFiltroFechaDesde_Click(object sender, EventArgs e)
        {
            //Abro formulario para seleccionar fech
            Ventas.frmBuscarPorFecha formSeleccionFecha = new frmBuscarPorFecha();

            if (formSeleccionFecha.ShowDialog() == DialogResult.OK)
            {
                chbxSoloCajaAbierta.Checked = false;

                if (formSeleccionFecha.TipoBusqueda == "Fecha Desde")
                {
                    dgvListado.DataSource = ListaVentas.Where(x=>x.FechaHora.Date >= formSeleccionFecha.dtpFechaDesde.Value);
                    //dgvListado.DataSource = Datos_VentasAdapter.BusquedaFechaDesde(formSeleccionFecha.dtpFechaDesde.Value);
                }
                if (formSeleccionFecha.TipoBusqueda == "Desde-Hasta")
                {
                    dgvListado.DataSource = ListaVentas.Where(x=>x.FechaHora.Date >= formSeleccionFecha.dtpDHDesde.Value && x.FechaHora.Date <= formSeleccionFecha.dtpDHHasta.Value);
                    //dgvListado.DataSource = Datos_VentasAdapter.BusquedaFechaDesde(formSeleccionFecha.dtpDHDesde.Value, formSeleccionFecha.dtpDHHasta.Value);
                }
            }

        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnModificarComprobante_Click(object sender, EventArgs e)
        {
            this.ModificarComprobante();
        }

        private void btnBuscarPorCliente_Click(object sender, EventArgs e)
        {
            GetVentasCliente();
        }

        private void GetVentasCliente()
        {
            //Abro formulario para seleccionar fech
            Ventas.frmBuscarPorFecha formSeleccionFecha = new frmBuscarPorFecha();
            //Activo la pestaña buscar por Cliente
            formSeleccionFecha.tcPestañas.SelectedTab = formSeleccionFecha.pBuscarPorCliente;
            
            if (formSeleccionFecha.ShowDialog() == DialogResult.OK)
            {
                //Obtengo el DNI Del Cliente Seleccionado;
                string dniClienteSeleccionado = formSeleccionFecha.dniClienteSeleccionado;
                dgvListado.DataSource = Datos_VentasAdapter.Busqueda(dniClienteSeleccionado);
            }
        }

        private void chbxSoloCajaAbierta_CheckedChanged(object sender, EventArgs e)
        {
            this.ActualizarLista();
        }
    }
}
