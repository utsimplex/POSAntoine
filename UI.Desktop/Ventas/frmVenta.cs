using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using System.Globalization;
using System.Threading.Tasks;

namespace UI.Desktop.Ventas
{
    public partial class frmVenta : Form
    {
        //Variables de Clase
        public frmVenta(Usuario usr)
        {
            InitializeComponent();
            usuarioLogueado = usr;
                        DateTime fecha = DateTime.Today;
            string f = fecha.ToString("dd ' de ' MMMM ', ' yyyy");
            txtFechaHoraVta.Text = f;
            modo = "Alta";
            ventaLocal = new Venta();
                   
        }
        //MODO EDICION
        public frmVenta(Usuario usr,Venta vtaSelec)
        {
            InitializeComponent();
            ventaLocal = vtaSelec;

            usuarioLogueado = usr;
            modo = "Modificacion";
            txtFechaHoraVta.Text = vtaSelec.FechaHora.ToString("dd ' de ' MMMM ', ' yyyy"); 
            txtDcto.Text = vtaSelec.Descuento.ToString();
            txtDniCuit.Text = vtaSelec.DniCliente.ToString();
            txtNombRazCli.Text = Datos_ClienteAdapter.GetOne(vtaSelec.DniCliente).Nombre;
            txtNumeroVenta.Text = vtaSelec.NumeroVenta.ToString();
            txtTotal.Text = vtaSelec.Total.ToString();
            dgvArticulosVtaActual.DataSource = Datos_VentasArticulosAdapter.GetAll(vtaSelec.NumeroVenta, vtaSelec.TipoOperacion);
            txtDcto.ReadOnly = true;
            btnBuscarCliente.Visible = false;
            btnQuitar.Text = "Devolver";
            vtaModificar = vtaSelec;

        }


        #region /*/*/*/ VARIABLES LOCALES \*\*\*\

        Entidades.Cliente clienteActual;

        Data.Database.ClienteAdapter Datos_ClienteAdapter = new Data.Database.ClienteAdapter();
        Data.Database.VentasAdapter Datos_VentasAdapter = new Data.Database.VentasAdapter();
        Data.Database.Ventas_Articulos Datos_VentasArticulosAdapter = new Data.Database.Ventas_Articulos();
        Data.Database.InformeVentaAdapter Datos_InformesAdapter = new Data.Database.InformeVentaAdapter();
        Data.Database.ArticuloAdapter Datos_ArticulosAdapter = new Data.Database.ArticuloAdapter();
        Artículos.frmListadoArticulos formListaArticulos;
        string modo;
        Entidades.Usuario usuarioLogueado;
        Entidades.Venta ventaLocal;
        Venta vtaModificar;

        #endregion







        #region /*/*/*/ EVENTOS \*\*\*\

        // CLICK - Buscar Cliente
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
               clienteActual = BuscarCliente();
            txtNombRazCli.Text = clienteActual.Nombre + " " + clienteActual.Apellido;
            txtDniCuit.Text = clienteActual.NumeroDocumento;
               
        }

        // CLICK - Agregar Articulo
        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            AñadirArticuloVtaActual();
        }

        // CLICK - BOTON ACEPTAR
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ConfirmarVenta();
        }

  

        // EVENTO LOAD
        private void frmVenta_Load(object sender, EventArgs e)
        {
            txtTotal.ReadOnly = true;
            //EVALUO UN CAMPO PARA VER SI ES EDICION O ALTA DE VENTA NUEVA
            if (modo == "Alta")
            {
                formListaArticulos = new UI.Desktop.Artículos.frmListadoArticulos();
                if (formListaArticulos.IsDisposed == false)
                    ConfigurarGrillaDetalles();

                int ultNroVta = Datos_VentasAdapter.getUltNroVenta();

                this.txtNumeroVenta.Text = Convert.ToString(ultNroVta + 1);
            }
            else //LOAD MODO MODIFICACION
            {
                int statusVenta = Datos_VentasAdapter.getStatusVenta(vtaModificar.NumeroVenta);
                if(statusVenta == 0)
                {

                formListaArticulos = new UI.Desktop.Artículos.frmListadoArticulos();
                ConfigurarGrillaDetalles();
                    this.Text = "Realizar Devolución";
                    gbTotal.Text = "Total a devolver";
                formListaArticulos.ListaArticulosVtaActual = Datos_VentasArticulosAdapter.GetAll(Convert.ToInt32(txtNumeroVenta.Text), vtaModificar.TipoOperacion);
                btnAgregarArt.Visible = false;
                }
                else
                {
                    MessageBox.Show("Esta venta ya tiene devoluciones registradas. No puede modificarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.None;
                    this.Close();
                }

            }//ELSE---> ACA ESTA EN MODO MODIFICAR, x lo tanto no cargo nada de lo anterior
        }


        //DobleClick CANTIDAD - Modificar celda
        private void dgvArticulosVtaActual_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (dgvArticulosVtaActual.CurrentCell.ColumnIndex == 3 && modo == "Alta")
            //{
            //    dgvArticulosVtaActual.BeginEdit(true);
                               
            //}
            //else
            //{
                MessageBox.Show("No se puede editar esta columna", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            

        }


        //TECLAS ACCESO RAPIDO
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.C:
                
                
                  clienteActual = BuscarCliente();
                    txtNombRazCli.Text = clienteActual.Nombre + " " + clienteActual.Apellido;
                    txtDniCuit.Text = clienteActual.NumeroDocumento;
                 
                    break;

                case Keys.Add:
                    this.AñadirArticuloVtaActual();
                    break;

                case Keys.Subtract:
                    //this.ElimArticuloVtaActual();
                    break;

                case Keys.Escape:
                    this.Dispose();
                    break;

                case Keys.Enter:
                    //this.ConfirmarVenta();
                    break;

               
                


                default:

                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Fin Edicion de celda.
      

        //DESCUENTO - Modificar valor del porcentaje de descuento.
        private void txtDcto_Leave(object sender, EventArgs e)
        {
            AplicarDescuento();
        }

        //BTN QUITAR CLICK
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (modo == "Modificacion")
            {
                // AGARRO EL CODIGO DE LO QUE QUIERO DEVOLVER
                string codArtiQuitar = dgvArticulosVtaActual.SelectedRows[0].Cells["CodigoArticulo"].Value.ToString();
                // AGARRO LA CANTIDAD QUE VENDI
                int cantArtiDevolver = Convert.ToInt32(dgvArticulosVtaActual.SelectedRows[0].Cells["Cantidad"].Value.ToString());

                if (this.devolverArticuloOK(codArtiQuitar))
                {
                devolverArticulo(codArtiQuitar, cantArtiDevolver);
                }
                else
                {
                    MessageBox.Show("El artículo " + codArtiQuitar + " ya fue seleccionado para su devolución.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        private async void btnFacturar_Click(object sender, EventArgs e)
        {
            this.ConstruirVenta();
            this.GuardarVenta();
            await this.FacturarVentaAsync();
        }
        #endregion


        #region /*/*/*/ M E T O D O S \*\*\*\

        //Configurar Grilla Detalles
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
            this.dgvArticulosVtaActual.Columns["Precio"].HeaderText = "Precio ($)";

            //Ancho de las columnas
            ConfigurarAnchoColumnas();

            

        }

        //Configura Ancho de columnas de la grilla de articulos a vender.
        private void ConfigurarAnchoColumnas()
        {
            this.dgvArticulosVtaActual.Columns["DescripcionArticulo"].Width = 200;
            this.dgvArticulosVtaActual.Columns["Cantidad"].Width = 65;
            //Establecer Subtotal como ultima columna.
//            this.dgvArticulosVtaActual.Columns["Subtotal"].DisplayIndex = 5;
            //Ocultar columnas innecesarias
            this.dgvArticulosVtaActual.Columns["NumeroVenta"].Visible = false;
        }

        //BUSCAR CLIENTE
        private Entidades.Cliente BuscarCliente()
        {
            Clientes.frmListadoClientes formListaClientes = new UI.Desktop.Clientes.frmListadoClientes();
            formListaClientes.ModoForm = UI.Desktop.Clientes.frmListadoClientes.TipoForm.SeleccionDeCliente;

            if (formListaClientes.ShowDialog() == DialogResult.Yes)
            {
                clienteActual = Datos_ClienteAdapter.GetOne(formListaClientes.dniClienteSelecccionado);
            }
            else
            {
                clienteActual = new Entidades.Cliente();
                clienteActual.Nombre = "No Registrado";
                clienteActual.Apellido = " ";
                clienteActual.NumeroDocumento = "No Registrado";
                clienteActual.Email = "No Registrado";
                clienteActual.Telefono = "No Registrado";
            }

            return clienteActual;


        }
         
        //AÑADIR artículo a esta venta
        private void AñadirArticuloVtaActual()
        {
            
            formListaArticulos.ModoForm = UI.Desktop.Artículos.frmListadoArticulos.TipoForm.SeleccionDeArticulo;
           
            formListaArticulos.ShowDialog();
                     
            ActualizarVtaActual();

            }

        //QUITAR artículo a esta venta
        private void ElimArticuloVtaActual()
        {
            if(dgvArticulosVtaActual.SelectedRows.Count > 0)
            {

            string codArtToElim = dgvArticulosVtaActual.SelectedRows[0].Cells["CodigoArticulo"].Value.ToString();
            Entidades.Venta_Articulo vtaArtToElim;
            foreach (Entidades.Venta_Articulo vtaArti in formListaArticulos.ListaArticulosVtaActual)
            {
                if (vtaArti.CodigoArticulo == codArtToElim)
                {
                    vtaArtToElim = vtaArti;
                    formListaArticulos.ListaArticulosVtaActual.Remove(vtaArtToElim);
                    break;
                }
            }

            ActualizarVtaActual();
            }

            
        }
        
        //Actualizar Grilla - Lista Vta Actual
        private void ActualizarVtaActual()
        {
                     
            if (formListaArticulos.ListaArticulosVtaActual.Count != 0)
            {
                // Actualizar Grilla
                //Asignar cualquier boludes al data source.
                // NO SIRVE  this.dgvArticulosVtaActual.DataSource = null;
                this.dgvArticulosVtaActual.DataSource = formListaArticulos.ReturnListArtVtaActual();

                //Vuelvo a establecer el ancho de columnas (si no lo hago se desordena todo, S.H.I.T)
                ConfigurarAnchoColumnas();

                //Actualizar Total
                ActualizarTotal();
            }
        }

        //Actualizar Total
        private void ActualizarTotal()
        {
            if (modo == "Alta")
            {
                //Inicializar TOTAL
                Decimal total = 0;

                //Actualizar SUB-TOTAL
                foreach (Entidades.Venta_Articulo filaArt in formListaArticulos.ListaArticulosVtaActual)
                {
                    filaArt.Subtotal = filaArt.Cantidad * Convert.ToDecimal(filaArt.Precio.ToString());
                    total = Convert.ToDecimal(total + Convert.ToDecimal(filaArt.Subtotal.ToString()));

                }

                this.txtTotal.Text = total.ToString();

                //Titulo de las columnas
                this.dgvArticulosVtaActual.Columns["CodigoArticulo"].HeaderText = "Código";
                this.dgvArticulosVtaActual.Columns["DescripcionArticulo"].HeaderText = "Descripción";
                this.dgvArticulosVtaActual.Columns["Precio"].HeaderText = "Precio ($)";
            }
            else //SI EL MODO ES MODIFICACION
            {
                Decimal total = 0;

                
                //Actualizar TOTAL -           filaArtVtaActual ya tiene el subtotal negativo
                foreach (Entidades.Venta_Articulo filaArtVtaActual in formListaArticulos.ListaArticulosVtaActual)
                {
                    
                        if(filaArtVtaActual.TipoOperacion == "D")
                        {
                            total = Convert.ToDecimal(total + Convert.ToDecimal(filaArtVtaActual.Subtotal.ToString()));
                        }
                    
                }//ESTO NO FUNCIONA
                this.txtTotal.Text = Convert.ToString(total);
            }
            this.dgvArticulosVtaActual.Refresh();
        }

        //APLICAR DESCUENTO
        private void AplicarDescuento()
        {
            ActualizarTotal();
            
            if (txtDcto.Text != "")
            {
                Decimal descuentoTotal = (Convert.ToDecimal(txtTotal.Text) * Convert.ToDecimal(txtDcto.Text)) / 100;
                Decimal total = Convert.ToDecimal(txtTotal.Text);
                txtTotal.Text = Convert.ToString(total - descuentoTotal);
            }
            else
            {
                ActualizarTotal();
            }
        }

        //Descontar Stock SOTCK
        private void ActualizarStock()
        {
            if (modo == "Alta")
            {
                Articulo artiBD;

                foreach (Venta_Articulo arti in formListaArticulos.ListaArticulosVtaActual)
                {
                    if(arti.TipoOperacion == "V")
                {
                    artiBD = Datos_ArticulosAdapter.BuscarArticulo(arti.CodigoArticulo);

                    artiBD.Stock = (artiBD.Stock - arti.Cantidad);

                    Datos_ArticulosAdapter.Actualizar(artiBD);
                }


                }
            }else if (modo == "Modificacion")
            {
                Articulo artiBD;

                foreach (Venta_Articulo arti in formListaArticulos.ListaArticulosVtaActual)
                {
                    if (arti.TipoOperacion == "D")
                    {
                        artiBD = Datos_ArticulosAdapter.BuscarArticulo(arti.CodigoArticulo);

                        artiBD.Stock = (artiBD.Stock - arti.Cantidad);

                        Datos_ArticulosAdapter.Actualizar(artiBD);
                    }


                }
            }

        }

        //REINGRESAR AL Stock SOTCK
        private void ActualizarStock(string cod, int cant)
        {
            if (modo == "Modificacion")
            {
                Articulo artiBD;

                foreach (Venta_Articulo arti in formListaArticulos.ListaArticulosVtaActual)
                {
                    artiBD = Datos_ArticulosAdapter.BuscarArticulo(arti.CodigoArticulo);

                    artiBD.Stock = (artiBD.Stock - arti.Cantidad);

                    Datos_ArticulosAdapter.Actualizar(artiBD);


                }
            }

        }
        
        //VALIDAR VENTA
        private bool ValidarVenta()
        {
            //Este metodo devuelve true si la venta es valida
            return Convert.ToDouble(this.ventaLocal.Total) != 0 ;
        }
        //GENERAR VENTA a Variable Local
        private void ConstruirVenta()
        {
            if (modo == "Alta")
            {
                //Entidades.Venta vtaNueva = new Entidades.Venta();
                ventaLocal.TipoOperacion = "V";
                frmConfirmarVta formConfirmarVenta = new frmConfirmarVta();

                formConfirmarVenta.txtTotal.Text = this.txtTotal.Text;

                string medio = null;

                if (rbEfectivo.Checked)
                {
                    medio = "Efectivo";
                    //vtaNueva.TipoPago = "Efectivo"; 
                }
                else if (rbTarjeta.Checked)
                {
                    medio = "Debito/Credito";
                    // vtaNueva.TipoPago = "Debito/Credito";
                }
                else if (rbMP.Checked)
                {
                    medio = "Mercado Pago";
                }

                ventaLocal.TipoPago = medio;

                formConfirmarVenta.txtTipoPago.Text = ventaLocal.TipoPago;
                formConfirmarVenta.ShowDialog();

                if (formConfirmarVenta.DialogResult == DialogResult.OK || formConfirmarVenta.DialogResult == DialogResult.Yes)
                {
                    ventaLocal.NumeroVenta = Convert.ToInt32(txtNumeroVenta.Text);
                    ventaLocal.FechaHora = Convert.ToDateTime(DateTime.Now);
                    //ventaLocal.DniCliente = txtDniCuit.Text;
                    
                    //#Data Fiscal
                    ventaLocal.NumeroDocumentoCliente = Convert.ToInt64(clienteActual.NumeroDocumento);
                    //ventaLocal.SituacionFiscalCliente = clienteActual.TipoCliente; TO-DO: asignar id de situacion Fiscal
                    ventaLocal.NombreCliente = clienteActual.Nombre;
                    ventaLocal.DireccionCliente = clienteActual.Direccion;
                    ventaLocal.TipoDocumentoCliente = clienteActual !=null && clienteActual.TipoDocumento!=null? clienteActual.TipoDocumento:(int)FeConstantes.TipoDocumento.SIN_IDENTIFICAR;
                    ventaLocal.Total = Convert.ToDecimal(txtTotal.Text);
                    double Neto = Convert.ToDouble(txtTotal.Text) / 1.21;
                    ventaLocal.Neto = Convert.ToDouble(Neto.ToString("0.00"));
                    double Iva = Convert.ToDouble(ventaLocal.Total) - Neto;
                    ventaLocal.Iva = Convert.ToDouble(Iva.ToString("0.00"));
                    //TO-DO: Evaluar parametro de Usuario para saber si el emisor es Monotributista
                    bool Monotributista = true;
                    if (Monotributista)
                        ventaLocal.TipoComprobante = (int)FeConstantes.TipoComprobante.FacturaC;
                    else
                        ventaLocal.TipoComprobante = lblTipoComprobante.Text == "FACTURA B" ? (int)FeConstantes.TipoComprobante.FacturaC : clienteActual.TipoComprobante; 
                    
                    ventaLocal.Usuario = usuarioLogueado.usuario;

                    if (txtDcto.Text == "")
                    {
                        ventaLocal.Descuento = 0;
                    }
                    else
                    {
                        ventaLocal.Descuento = Convert.ToInt32(txtDcto.Text);
                    }

                }

                if (formConfirmarVenta.DialogResult == DialogResult.Yes)
                {
                    PrinterDrawing prt = new PrinterDrawing(ventaLocal, formListaArticulos.ListaArticulosVtaActual.ToList(), "CLIENTE");
                }

                if (formConfirmarVenta.DialogResult != DialogResult.Cancel)
                {
                    ActualizarStock();
                }
            }
            else if (modo == "Modificacion")
            {
                Ventas.frmConfirmarVta formConfirmarVenta = new frmConfirmarVta();
                formConfirmarVenta.Text = "Modificar Venta - Confirmar";
                formConfirmarVenta.txtTotal.Text = this.txtTotal.Text;

                string medio = null;

                if (rbEfectivo.Checked)
                {
                    medio = "Efectivo";
                    //vtaNueva.TipoPago = "Efectivo"; 
                }
                else if (rbTarjeta.Checked)
                {
                    medio = "Debito/Credito";
                    // vtaNueva.TipoPago = "Debito/Credito";
                }
                else if (rbMP.Checked)
                {
                    medio = "Mercado Pago";
                }

                vtaModificar.TipoPago = medio;

                formConfirmarVenta.txtTipoPago.Text = vtaModificar.TipoPago;
                formConfirmarVenta.ShowDialog();

                if (formConfirmarVenta.DialogResult == DialogResult.OK || formConfirmarVenta.DialogResult == DialogResult.Yes)
                {
                    vtaModificar.NumeroVenta = Convert.ToInt32(txtNumeroVenta.Text);
                    vtaModificar.FechaHora = Convert.ToDateTime(DateTime.Now);
                    vtaModificar.DniCliente = txtDniCuit.Text;
                    vtaModificar.Total = Convert.ToDecimal(txtTotal.Text);
                    vtaModificar.Usuario = usuarioLogueado.usuario;

                    if (txtDcto.Text == "")
                    {
                        vtaModificar.Descuento = 0;
                    }
                    else
                    {
                        vtaModificar.Descuento = Convert.ToInt32(txtDcto.Text);
                    }

                    Datos_VentasAdapter.RegistrarVenta(vtaModificar);


                    foreach (Entidades.Venta_Articulo lineaVta in formListaArticulos.ListaArticulosVtaActual)
                    {
                        if (lineaVta.TipoOperacion == "D")
                        {
                            lineaVta.NumeroVenta = vtaModificar.NumeroVenta;
                            Datos_VentasArticulosAdapter.RegistrarLineaVta(lineaVta);
                        }
                    }
                }

                if (formConfirmarVenta.DialogResult == DialogResult.Yes)
                {
                    int numVenta = Convert.ToInt32(txtNumeroVenta.Text);

                    string sql = "SELECT Ventas.numVenta, Ventas.fechaHora, Ventas.TipoPago, Ventas.Total, Clientes.dni, Clientes.apellido + ', ' + Clientes.nombre AS [Nombre y Apellido], Ventas_Articulos.CFARTCODIGO, Articulos.Descripcion, Ventas_Articulos.cantidad, Ventas_Articulos.precio FROM [Ventas] INNER JOIN [Ventas_Articulos] on Ventas.numVenta = Ventas_Articulos.CFVENNumVenta AND Ventas.TipoOperacion = Ventas_Articulos.TipoOperacion INNER JOIN [Articulos] on Ventas_Articulos.CFArtCodigo = Articulos.codigo LEFT JOIN [Clientes] on Ventas.dniCliente = Clientes.dni  WHERE (Ventas.numVenta =" + numVenta + " AND Ventas.tipooperacion = 'D' )";

                    if (Datos_InformesAdapter.BuscarRegistros(sql))
                    {
                        System.IO.Directory.CreateDirectory("C:\\XML");
                        string url = "C:\\XML\\informeVenta.xml";

                        Datos_InformesAdapter.tablas.WriteXml(url, XmlWriteMode.WriteSchema);

                    }

                    frmInformeVenta formInformeVenta = new frmInformeVenta();
                    formInformeVenta.ShowDialog();
                    System.IO.File.Delete("C:\\XML\\informeVenta.xml");

                }

                if (formConfirmarVenta.DialogResult != DialogResult.Cancel)
                {
                    ActualizarStock();
                }
            }

        }


        //GUARDAR VENTA desde Variable Local
        private void GuardarVenta()
        {
            Datos_VentasAdapter.RegistrarVenta(ventaLocal);

            foreach (Venta_Articulo lineaVta in formListaArticulos.ListaArticulosVtaActual)
            {
                lineaVta.NumeroVenta = ventaLocal.NumeroVenta;
                lineaVta.TipoOperacion = ventaLocal.TipoOperacion;
                Datos_VentasArticulosAdapter.RegistrarLineaVta(lineaVta);
            }
        }
        
        private async Task FacturarVentaAsync()
        {
            await Facturador.facturarAsync(ventaLocal);
        }
        //GUARDAR VENTA
        private void ConfirmarVenta()
        {
            if (modo == "Alta")
            {
                Entidades.Venta vtaNueva = new Entidades.Venta();
                vtaNueva.TipoOperacion = "V";
                Ventas.frmConfirmarVta formConfirmarVenta = new frmConfirmarVta();

                formConfirmarVenta.txtTotal.Text = this.txtTotal.Text;

                string medio = null;

                if (rbEfectivo.Checked)
                {
                    medio = "Efectivo";
                    //vtaNueva.TipoPago = "Efectivo"; 
                }
                else if (rbTarjeta.Checked)
                {
                    medio = "Debito/Credito";
                   // vtaNueva.TipoPago = "Debito/Credito";
                } else if (rbMP.Checked)
                {
                    medio = "Mercado Pago";
                }

                vtaNueva.TipoPago = medio;

                formConfirmarVenta.txtTipoPago.Text = vtaNueva.TipoPago;
                formConfirmarVenta.ShowDialog();

                if (formConfirmarVenta.DialogResult == DialogResult.OK || formConfirmarVenta.DialogResult == DialogResult.Yes)
                {
                    vtaNueva.NumeroVenta = Convert.ToInt32(txtNumeroVenta.Text);
                    vtaNueva.FechaHora = Convert.ToDateTime(DateTime.Now);
                    vtaNueva.DniCliente = txtDniCuit.Text;
                    vtaNueva.Total = Convert.ToDecimal(txtTotal.Text);
                    vtaNueva.Usuario = usuarioLogueado.usuario;

                    if (txtDcto.Text == "")
                    {
                        vtaNueva.Descuento = 0;
                    }
                    else
                    {
                        vtaNueva.Descuento = Convert.ToInt32(txtDcto.Text);
                    }

                    Datos_VentasAdapter.RegistrarVenta(vtaNueva);


                    foreach (Entidades.Venta_Articulo lineaVta in formListaArticulos.ListaArticulosVtaActual)
                    {
                        lineaVta.NumeroVenta = vtaNueva.NumeroVenta;
                        lineaVta.TipoOperacion = vtaNueva.TipoOperacion;
                        Datos_VentasArticulosAdapter.RegistrarLineaVta(lineaVta);
                    }
                }

                if (formConfirmarVenta.DialogResult == DialogResult.Yes)
                {
                    PrinterDrawing prt = new PrinterDrawing(vtaNueva, formListaArticulos.ListaArticulosVtaActual.ToList(), "CLIENTE");
                    //int numVenta = Convert.ToInt32(txtNumeroVenta.Text);

                    //string sql = "SELECT Ventas.numVenta, Ventas.fechaHora, Ventas.TipoPago, Ventas.Total, Clientes.dni, Clientes.apellido + ', ' + Clientes.nombre AS [Nombre y Apellido], Ventas_Articulos.CFARTCODIGO, Articulos.Descripcion, Ventas_Articulos.cantidad, Ventas_Articulos.precio FROM [Ventas] INNER JOIN [Ventas_Articulos] on Ventas.numVenta = Ventas_Articulos.CFVENNumVenta AND Ventas.TipoOperacion = Ventas_Articulos.TipoOperacion  INNER JOIN [Articulos] on Ventas_Articulos.CFArtCodigo = Articulos.codigo LEFT JOIN [Clientes] on Ventas.dniCliente = Clientes.dni WHERE (Ventas.numVenta =" + numVenta + " AND Ventas.tipooperacion = 'V' )";

                    //if (Datos_InformesAdapter.BuscarRegistros(sql))
                    // {
                    //     System.IO.Directory.CreateDirectory("C:\\XML");
                    //     string url = "C:\\XML\\informeVenta.xml";

                        //     Datos_InformesAdapter.tablas.WriteXml(url, XmlWriteMode.WriteSchema);

                        // }

                        // frmInformeVenta formInformeVenta = new frmInformeVenta();
                        // formInformeVenta.ShowDialog();
                        //System.IO.File.Delete("C:\\XML\\informeVenta.xml"); 

                }

                if (formConfirmarVenta.DialogResult != DialogResult.Cancel)
                    {
                        ActualizarStock();
                    }
            }else if (modo == "Modificacion")
            {
                Ventas.frmConfirmarVta formConfirmarVenta = new frmConfirmarVta();
                formConfirmarVenta.Text = "Modificar Venta - Confirmar";
                formConfirmarVenta.txtTotal.Text = this.txtTotal.Text;

                string medio = null;

                if (rbEfectivo.Checked)
                {
                    medio = "Efectivo";
                    //vtaNueva.TipoPago = "Efectivo"; 
                }
                else if (rbTarjeta.Checked)
                {
                    medio = "Debito/Credito";
                    // vtaNueva.TipoPago = "Debito/Credito";
                }
                else if (rbMP.Checked)
                {
                    medio = "Mercado Pago";
                }

                vtaModificar.TipoPago = medio;

                formConfirmarVenta.txtTipoPago.Text = vtaModificar.TipoPago;
                formConfirmarVenta.ShowDialog();

                if (formConfirmarVenta.DialogResult == DialogResult.OK || formConfirmarVenta.DialogResult == DialogResult.Yes)
                {
                    vtaModificar.NumeroVenta = Convert.ToInt32(txtNumeroVenta.Text);
                    vtaModificar.FechaHora = Convert.ToDateTime(DateTime.Now);
                    vtaModificar.DniCliente = txtDniCuit.Text;
                    vtaModificar.Total = Convert.ToDecimal(txtTotal.Text);
                    vtaModificar.Usuario = usuarioLogueado.usuario;

                    if (txtDcto.Text == "")
                    {
                        vtaModificar.Descuento = 0;
                    }
                    else
                    {
                        vtaModificar.Descuento = Convert.ToInt32(txtDcto.Text);
                    }
                   
                    Datos_VentasAdapter.RegistrarVenta(vtaModificar);


                    foreach (Entidades.Venta_Articulo lineaVta in formListaArticulos.ListaArticulosVtaActual)
                    {
                      if(lineaVta.TipoOperacion == "D")
                        {
                        lineaVta.NumeroVenta = vtaModificar.NumeroVenta;
                        Datos_VentasArticulosAdapter.RegistrarLineaVta(lineaVta);
                        }
                    }
                }

                if (formConfirmarVenta.DialogResult == DialogResult.Yes)
                {
                    int numVenta = Convert.ToInt32(txtNumeroVenta.Text);

                    string sql = "SELECT Ventas.numVenta, Ventas.fechaHora, Ventas.TipoPago, Ventas.Total, Clientes.dni, Clientes.apellido + ', ' + Clientes.nombre AS [Nombre y Apellido], Ventas_Articulos.CFARTCODIGO, Articulos.Descripcion, Ventas_Articulos.cantidad, Ventas_Articulos.precio FROM [Ventas] INNER JOIN [Ventas_Articulos] on Ventas.numVenta = Ventas_Articulos.CFVENNumVenta AND Ventas.TipoOperacion = Ventas_Articulos.TipoOperacion INNER JOIN [Articulos] on Ventas_Articulos.CFArtCodigo = Articulos.codigo LEFT JOIN [Clientes] on Ventas.dniCliente = Clientes.dni  WHERE (Ventas.numVenta =" + numVenta + " AND Ventas.tipooperacion = 'D' )";

                    if (Datos_InformesAdapter.BuscarRegistros(sql))
                    {
                        System.IO.Directory.CreateDirectory("C:\\XML");
                        string url = "C:\\XML\\informeVenta.xml";

                        Datos_InformesAdapter.tablas.WriteXml(url, XmlWriteMode.WriteSchema);

                    }

                    frmInformeVenta formInformeVenta = new frmInformeVenta();
                    formInformeVenta.ShowDialog();
                    System.IO.File.Delete("C:\\XML\\informeVenta.xml");

                }

                if (formConfirmarVenta.DialogResult != DialogResult.Cancel)
                {
                    ActualizarStock();
                }
        else if(formConfirmarVenta.DialogResult == DialogResult.Cancel)
                {
                    this.Focus();
                }
            }
            
        }

        #endregion


        private bool devolverArticuloOK(string cod) 
        {
            bool puedoDevolver = true;
            foreach (Venta_Articulo arti in formListaArticulos.ListaArticulosVtaActual)
            {
                if (arti.CodigoArticulo == cod && arti.Cantidad <0)
                {
                    puedoDevolver = false;
                }
            }

            return puedoDevolver;
        }

        //DESCONTAR STOCK DE LA LISTA DE ARTICULOS VENTA ACTUAL (q esta en el formListaArticulos, FALTA CONFIRMAR PARA GUARDAR LOS 
        //CAMBIOS EN LA BD Y ACTUALIZAR EL STOCK VERDADERO.
        private void devolverArticulo(string cod, int cant)
        {
            Venta_Articulo artiDevuelto = new Venta_Articulo();
            foreach (Venta_Articulo arti in formListaArticulos.ListaArticulosVtaActual)
            {
                if (arti.CodigoArticulo == cod)
                {
                   
                    artiDevuelto.CodigoArticulo = cod;
                    artiDevuelto.Cantidad = arti.Cantidad * (-1);
                    artiDevuelto.Subtotal = Convert.ToDecimal(artiDevuelto.Cantidad * Convert.ToDecimal(arti.Precio.ToString()));
                    artiDevuelto.DescripcionArticulo = "DEVOLUCION " + arti.DescripcionArticulo;
                    artiDevuelto.NumeroVenta = arti.NumeroVenta;
                    artiDevuelto.Precio = arti.Precio;
                    artiDevuelto.TipoOperacion = "D";
                }
            }
            vtaModificar.TipoOperacion = "D";
            formListaArticulos.ListaArticulosVtaActual.Add(artiDevuelto);
            ActualizarVtaActual();
        }

        private void dgvArticulosVtaActual_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dgvArticulosVtaActual.SelectedRows[0].Cells["CodigoArticulo"].Value != null)
            {

            string codigo = this.dgvArticulosVtaActual.SelectedRows[0].Cells["CodigoArticulo"].Value.ToString();
            int cantidad = Convert.ToInt32(this.dgvArticulosVtaActual.SelectedRows[0].Cells["cantidad"].Value);

           formListaArticulos.ModificarCantidadVtaActual(codigo, cantidad);
            ActualizarVtaActual();
            }        




        }

       

    }
}
