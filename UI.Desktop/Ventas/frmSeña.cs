using Data.Database;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Ventas
{
    public partial class frmSeña : Form
    {
        /*VARIABLES LOCALES*/

        Entidades.Cliente clienteActual;

        Data.Database.ClienteAdapter Datos_ClienteAdapter = new Data.Database.ClienteAdapter();
        Data.Database.SeñasAdapter Datos_SeñasAdapter = new Data.Database.SeñasAdapter();
        Data.Database.SeñaArticuloAdapter Datos_SeñaArticulosAdapter = new Data.Database.SeñaArticuloAdapter();
        Data.Database.InformeVentaAdapter Datos_InformesAdapter = new Data.Database.InformeVentaAdapter();
        Data.Database.ArticuloAdapter Datos_ArticulosAdapter = new Data.Database.ArticuloAdapter();
        Data.Database.MedioDePagoAdapter Datos_MedioDePagoAdapter = new Data.Database.MedioDePagoAdapter();
        Data.Database.DescuentoAdapter Datos_DescuentoAdapter = new Data.Database.DescuentoAdapter();
        Data.Database.ParametrosAdapter Datos_ParametrosAdapter = ParametrosAdapter.GetInstance();
        Data.Database.CajasAdapter Datos_CajasAdapter = new Data.Database.CajasAdapter();
        Artículos.frmListadoArticulos formListaArticulos;
        List<MedioDePago> listaMedioDePagos = new List<MedioDePago>();
        string modo;
        Entidades.Usuario usuarioLogueado;
        Entidades.Seña señaLocal;
        Entidades.ParametrosEmpresa parametrosEmpresa;
        Venta vtaModificar;
        bool cajaAbierta = false;
        public string medioDePago;
        public frmSeña(Usuario usr)
        {
            InitializeComponent();
            usuarioLogueado = usr;
            DateTime fecha = DateTime.Today;
            string f = fecha.ToString("dd ' de ' MMMM ', ' yyyy");
            txtFechaHoraVta.Text = f;
            modo = "Alta";
            señaLocal = new Entidades.Seña();
            parametrosEmpresa = this.Datos_ParametrosAdapter.obtenerParametrosEmpresa();
            this.ObtieneClienteGenerico();
            this.AsignaDatosClienteUI();
            medioDePago = "";

            if (señaLocal.CajaId!= null)
            {
                var caja = Datos_CajasAdapter.GetEstadoCajaAbierta(señaLocal.CajaId);
                cajaAbierta = Datos_CajasAdapter.GetEstadoCajaAbierta(señaLocal.CajaId);

            }
        }
        private Entidades.Cliente BuscarCliente()
        {
            Clientes.frmListadoClientes formListaClientes = new UI.Desktop.Clientes.frmListadoClientes();
            formListaClientes.ModoForm = UI.Desktop.Clientes.frmListadoClientes.TipoForm.SeleccionDeCliente;

            if (formListaClientes.ShowDialog() == DialogResult.Yes)
            {
                clienteActual = Datos_ClienteAdapter.GetOne((long)formListaClientes.dniClienteSelecccionado);
            }
            else
            {
                //keep the original value
                //clienteActual = new Entidades.Cliente();
                //clienteActual.Nombre = "No Registrado";
                //clienteActual.Apellido = " ";
                //clienteActual.NumeroDocumento = "No Registrado";
                //clienteActual.Email = "No Registrado";
                //clienteActual.Telefono = "No Registrado";
            }

            return clienteActual;


        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            AñadirArticuloSeñaActual();
        }
        private void ObtieneClienteGenerico()
        {
            //obtiene cliente generico para 
            clienteActual = Datos_ClienteAdapter.GetOne(0);
        }
        private void AsignaDatosClienteUI()
        {
            txtNombRazCli.Text = clienteActual.Nombre + " " + clienteActual.Apellido;
            txtDniCuit.Text = clienteActual.NumeroDocumento;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            clienteActual = BuscarCliente();
            this.AsignaDatosClienteUI();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.construyeSeña();
            try
            {
                if(señaValida())
                {
                this.guardarSeña();
                this.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private bool señaValida()
        {
            bool esValido = true;
            string mensajes = "";
            if(this.señaLocal.DniCliente == "0")
            {
                esValido = false;
                mensajes = "El cliente utilizado no puede ser el cliente generico \n";
            }
            if(this.señaLocal.Total==0)
            {
                esValido = false;
                mensajes += "El monto de la seña no puede ser 0";
            }
            if (this.formListaArticulos.ListaArticulosVtaActual.Count == 0)
            {
                esValido = false;
                mensajes += "Tiene que seleccionar al menos un articulo";
            }
            if(!esValido)
            MessageBox.Show("La seña no se puede guardar." + mensajes, "Error",MessageBoxButtons.OK);

            return esValido;
        }
        private void construyeSeña()
        {
            this.señaLocal = new Entidades.Seña()
            {
                CajaId = 0,
                DniCliente = clienteActual.NumeroDocumento,
                FechaHora = DateTime.Now,
                MontoPagado = Convert.ToDecimal(this.txtTotal.Text),
                Total = Convert.ToDecimal(this.txtTotal.Text),
                NumeroSeña = Convert.ToInt32(this.txtNumeroVenta.Text),
                Usuario=usuarioLogueado.Nombre,
                TipoPago = cbxMedioDePago.Text,
                Pagado = true ,
            };
        }
        private void guardarSeña()
        {
            if (modo == "Alta")
            {
                Datos_SeñasAdapter.RegistrarSeña(señaLocal, formListaArticulos.ListaArticulosSeñaActual.ToList());
                }
            else if (modo == "READONLY")
            {
                Datos_SeñasAdapter.ActualizarMedioDePago(señaLocal);
            }
        }
        private void AñadirArticuloSeñaActual()
        {

            formListaArticulos.ModoForm = UI.Desktop.Artículos.frmListadoArticulos.TipoForm.SeleccionDeArticuloParaSeña;

            formListaArticulos.ShowDialog();

            ActualizarSeñaActual();

        }
        private void ActualizarSeñaActual()
        {

            if (formListaArticulos.ListaArticulosVtaActual.Count != 0)
            {
                // Actualizar Grilla
                //Asignar cualquier boludes al data source.
                // NO SIRVE  this.dgvArticulosVtaActual.DataSource = null;
                this.dgvArticulosVtaActual.DataSource = formListaArticulos.ReturnListArtVtaActual();

                //Vuelvo a establecer el ancho de columnas (si no lo hago se desordena todo, S.H.I.T)
                ConfigurarAnchoColumnas();

            }
        }
        private void ConfigurarGrillaDetalles()
        {
            if (modo == "Alta")
            {
                //Establecer origen (vacío) para que muestre las columnas
                this.dgvArticulosVtaActual.DataSource = formListaArticulos.ReturnListArtVtaActual();
            }
            //Ocultar columnas innecesarias
            this.dgvArticulosVtaActual.Columns["NumeroVenta"].Visible = false;
            this.dgvArticulosVtaActual.Columns["TipoOperacion"].Visible = false;
            this.dgvArticulosVtaActual.Columns["descuento"].Visible = false;
            this.dgvArticulosVtaActual.Columns["descuento_porcentaje"].Visible = false;
            this.dgvArticulosVtaActual.Columns["subtotal"].Visible = false;
            this.dgvArticulosVtaActual.Columns["imprimeCambio"].Visible = false;
            //Agrego la columna subtotal a la grilla.
            /*           DataGridViewColumn subTotal = new DataGridViewColumn();
                       subTotal.Name = "subTotal";
                       subTotal.HeaderText = "Subtotal";
                       subTotal.CellTemplate = dgvArticulosVtaActual.Columns["Precio"].CellTemplate;
                       this.dgvArticulosVtaActual.Columns.Add(subTotal);
           */
            //Titulo de las columnas
            this.dgvArticulosVtaActual.Columns["CodigoArticulo"].HeaderText = "Código";
            this.dgvArticulosVtaActual.Columns["DescripcionArticulo"].HeaderText = "Descripción";

            //Ancho de las columnas
            ConfigurarAnchoColumnas();



        }

        //Configura Ancho de columnas de la grilla de articulos a vender.
        private void ConfigurarAnchoColumnas()
        {
            this.dgvArticulosVtaActual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulosVtaActual.Columns["DescripcionArticulo"].Width = 200;
            this.dgvArticulosVtaActual.Columns["Cantidad"].Width = 65;
            this.dgvArticulosVtaActual.Columns["codigoArticulo"].Width = 70;
            this.dgvArticulosVtaActual.Columns["descuento"].Width = 65;
            this.dgvArticulosVtaActual.Columns["descuento_porcentaje"].Width = 65;
            this.dgvArticulosVtaActual.Columns["Precio"].Width = 65;
            this.dgvArticulosVtaActual.Columns["subtotal"].Width = 90;

            //Establecer Subtotal como ultima columna.
            //            this.dgvArticulosVtaActual.Columns["Subtotal"].DisplayIndex = 5;
            //Ocultar columnas innecesarias
            this.dgvArticulosVtaActual.Columns["NumeroVenta"].Visible = false;
        }

        private void frmSeña_Load(object sender, EventArgs e)
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

            if (modo == "Alta")
            {
                formListaArticulos = new UI.Desktop.Artículos.frmListadoArticulos();
                if (formListaArticulos.IsDisposed == false)
                    ConfigurarGrillaDetalles();

                int ultNroVta = Datos_SeñasAdapter.GetUltimoNumeroSeña();
                señaLocal.NumeroSeña = ultNroVta + 1;
                this.txtNumeroVenta.Text = Convert.ToString(ultNroVta + 1);
            }
            else //LOAD MODO READONLY
            {
                cbxMedioDePago.SelectedValue = listaMedioDePagos.First(medioDePago => medioDePago.Descripcion == señaLocal.TipoPago.ToUpper()).id;
                formListaArticulos = new UI.Desktop.Artículos.frmListadoArticulos();
                ConfigurarGrillaDetalles();
                this.Text = "VER VENTA";
                formListaArticulos.ListaArticulosSeñaActual = new BindingList<Seña_Articulo>(Datos_SeñaArticulosAdapter.GetArticulosPorSeña(Convert.ToInt32(txtNumeroVenta.Text)));

            }
        }
    }
}
