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
using System.Reflection;
using Data.Database;

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
            ventaLocal = new Venta() { TipoOperacion="V",Usuario=usr.usuario};
            parametrosEmpresa = this.Datos_ParametrosAdapter.obtenerParametrosEmpresa();
            this.ObtieneParametrosEmpresaAUI();
            this.ObtieneClienteGenerico();
            this.AsignaDatosClienteUI();
            medioDePago = "";

        }
        //MODO READONLY -- SOLO PUEDE MODIFICAR EL MEDIO DE PAGO SI ES QUE LA CAJA NO ESTA CERRADA
        public frmVenta(Usuario usr,Venta vtaSelec)
        {
            InitializeComponent();
            ventaLocal = vtaSelec;
            parametrosEmpresa = this.Datos_ParametrosAdapter.obtenerParametrosEmpresa();
            this.ObtieneParametrosEmpresaAUI();
            usuarioLogueado = usr;
            modo = "READONLY";
            txtFechaHoraVta.Text = vtaSelec.FechaHora.ToString("dd ' de ' MMMM ', ' yyyy"); 
            txtDcto.Text = vtaSelec.Descuento.ToString();
            txtDniCuit.Text = vtaSelec.NumeroDocumentoCliente.ToString();
            txtNombRazCli.Text = Datos_ClienteAdapter.GetOne((long)vtaSelec.NumeroDocumentoCliente).Nombre;
            txtNumeroVenta.Text = vtaSelec.NumeroVenta.ToString();
            txtTotal.Text = vtaSelec.Total.ToString("c");
            dgvArticulosVtaActual.DataSource = Datos_VentasArticulosAdapter.GetAll(vtaSelec.NumeroVenta, vtaSelec.TipoOperacion);
            cajaAbierta = Datos_CajasAdapter.GetEstadoCajaAbierta(vtaSelec.CajaId);
            btnConfirmar.Enabled = cbxMedioDePago.Enabled=cajaAbierta;
            btnFacturar.Enabled = cajaAbierta && vtaSelec.NumeroTicketFiscal == null;
            txtDcto.ReadOnly = true;
            btnBuscarCliente.Visible = false;
            ventaLocal = vtaSelec;
             btnAgregarArt.Enabled = btnBuscarCliente.Enabled = btnQuitar.Enabled = txtDcto.Enabled = txtDctoPesos.Enabled=false;
            btnReimprimir.Visible = true;
            //cbxMedioDePago.SelectedText = vtaSelec.TipoPago;



        }


        #region /*/*/*/ VARIABLES LOCALES \*\*\*\

        Entidades.Cliente clienteActual;

        Data.Database.ClienteAdapter Datos_ClienteAdapter = new Data.Database.ClienteAdapter();
        Data.Database.VentasAdapter Datos_VentasAdapter = new Data.Database.VentasAdapter();
        Data.Database.Ventas_Articulos Datos_VentasArticulosAdapter = new Data.Database.Ventas_Articulos();
        Data.Database.InformeVentaAdapter Datos_InformesAdapter = new Data.Database.InformeVentaAdapter();
        Data.Database.ArticuloAdapter Datos_ArticulosAdapter = new Data.Database.ArticuloAdapter();
        Data.Database.MedioDePagoAdapter Datos_MedioDePagoAdapter = new Data.Database.MedioDePagoAdapter();
        Data.Database.ParametrosAdapter Datos_ParametrosAdapter = ParametrosAdapter.GetInstance();
        Data.Database.CajasAdapter Datos_CajasAdapter = new Data.Database.CajasAdapter();
        Artículos.frmListadoArticulos formListaArticulos;
        List<MedioDePago> listaMedioDePagos = new List<MedioDePago>();
        string modo;
        Entidades.Usuario usuarioLogueado;
        Entidades.Venta ventaLocal;
        Entidades.ParametrosEmpresa parametrosEmpresa;
        Venta vtaModificar;
        bool cajaAbierta = false;
        public string medioDePago;

        #endregion







        #region /*/*/*/ EVENTOS \*\*\*\

        // CLICK - Buscar Cliente
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
               clienteActual = BuscarCliente();
            this.AsignaDatosClienteUI();
            //txtNombRazCli.Text = clienteActual.Nombre + " " + clienteActual.Apellido;
            //txtDniCuit.Text = clienteActual.NumeroDocumento;
               
        }

        // CLICK - Agregar Articulo
        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            AñadirArticuloVtaActual();
        }


        // EVENTO LOAD
        private void frmVenta_Load(object sender, EventArgs e)
        {
            cbxMedioDePago.Items.Clear();
            listaMedioDePagos = Datos_MedioDePagoAdapter.GetMultipleActivo("%").Where(x => x.Activo == true).OrderBy(x=>x.Default).OrderBy(x=>x.Descripcion).ToList();
            if (listaMedioDePagos != null)
            {
                cbxMedioDePago.DataSource = listaMedioDePagos;
                cbxMedioDePago.DisplayMember = "descripcion";
                cbxMedioDePago.ValueMember = "id";
                cbxMedioDePago.SelectedIndex = listaMedioDePagos.FindIndex(x => x.Default == true);
            }
            txtTotal.ReadOnly = true;
            //EVALUO UN CAMPO PARA VER SI ES EDICION O ALTA DE VENTA NUEVA
            if (modo == "Alta")
            {
                formListaArticulos = new UI.Desktop.Artículos.frmListadoArticulos();
                if (formListaArticulos.IsDisposed == false)
                    ConfigurarGrillaDetalles();

                int ultNroVta = Datos_VentasAdapter.getUltNroVenta();
                ventaLocal.NumeroVenta = ultNroVta + 1;
                this.txtNumeroVenta.Text = Convert.ToString(ultNroVta + 1);
            }
            else //LOAD MODO READONLY
            {
                cbxMedioDePago.SelectedValue = listaMedioDePagos.First(medioDePago=>medioDePago.Descripcion== ventaLocal.TipoPago).id;
                formListaArticulos = new UI.Desktop.Artículos.frmListadoArticulos();
                ConfigurarGrillaDetalles();
                    this.Text = "VER VENTA";
                formListaArticulos.ListaArticulosVtaActual = Datos_VentasArticulosAdapter.GetAll(Convert.ToInt32(txtNumeroVenta.Text), ventaLocal.TipoOperacion);

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
            if (modo == "Alta")
            {

                if (e.ColumnIndex != 6 && e.ColumnIndex != 7 && dgvArticulosVtaActual.Rows.Count > 0)
                {
                    MessageBox.Show("No se puede editar esta columna", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                if (e.ColumnIndex == 6 && dgvArticulosVtaActual.Rows.Count > 0)
                {
                    MessageBox.Show("Ingrese el monto de descuento", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    decimal precio = Convert.ToDecimal(dgvArticulosVtaActual.Rows[dgvArticulosVtaActual.CurrentCell.RowIndex].Cells["Precio"].Value);
                    int cantidad = Convert.ToInt32(dgvArticulosVtaActual.Rows[dgvArticulosVtaActual.CurrentCell.RowIndex].Cells["Cantidad"].Value);
                    frmIngresaDescuento descuento = new frmIngresaDescuento("$", precio * cantidad);
                    if (descuento.ShowDialog() == DialogResult.OK)
                    {
                        dgvArticulosVtaActual.Rows[dgvArticulosVtaActual.CurrentCell.RowIndex].Cells["Descuento_porcentaje"].Value = Convert.ToDecimal(0);
                        dgvArticulosVtaActual.Rows[dgvArticulosVtaActual.CurrentCell.RowIndex].Cells["Descuento"].Value = descuento.descuento;
                    }
                    AplicarDescuento();
                }
                else if (e.ColumnIndex == 7 && dgvArticulosVtaActual.Rows.Count > 0)
                {
                    MessageBox.Show("Ingrese el porcentaje de descuento", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmIngresaDescuento descuento = new frmIngresaDescuento("%", 0);
                    if (descuento.ShowDialog() == DialogResult.OK)
                    {
                        dgvArticulosVtaActual.Rows[dgvArticulosVtaActual.CurrentCell.RowIndex].Cells["Descuento_porcentaje"].Value = descuento.descuento;
                        dgvArticulosVtaActual.Rows[dgvArticulosVtaActual.CurrentCell.RowIndex].Cells["Descuento"].Value = Convert.ToDecimal(0);
                    }
                    AplicarDescuento();
                }
            }



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
            if (!String.IsNullOrEmpty(this.txtDcto.Text))
            {
                if (!String.IsNullOrEmpty(this.txtDctoPesos.Text))
                    this.txtDctoPesos.Text = "";
            }
                AplicarDescuento();
        }
        private void txtDctoPesos_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtDctoPesos.Text))
            {
                if (!String.IsNullOrEmpty(this.txtDcto.Text))
                    this.txtDcto.Text = "";
            }
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
            if(modo=="Alta" && dgvArticulosVtaActual.SelectedRows.Count==1)
            {
                string codArtiQuitar = dgvArticulosVtaActual.SelectedRows[0].Cells["CodigoArticulo"].Value.ToString();

                Venta_Articulo artiDevuelto = formListaArticulos.ListaArticulosVtaActual.Where(x => x.CodigoArticulo == codArtiQuitar).FirstOrDefault();
                    if (artiDevuelto != null)
                    {
                        formListaArticulos.ListaArticulosVtaActual.Remove(artiDevuelto);
                        ActualizarVtaActual();
                        AplicarDescuento();
                    }
            }
        }

        // CLICK - BOTON ACEPTAR
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (modo == "Alta")
            {

                if (this.dgvArticulosVtaActual.RowCount != 0)
                {
                    this.setMedioPago();
                    DialogResult construyeVenta = this.ConstruirVenta();
                    if (construyeVenta != DialogResult.Cancel)
                    { 
                        this.GuardarVenta();
                        if (construyeVenta == DialogResult.Yes)
                        {
                            ventaLocal = Datos_VentasAdapter.GetOne(ventaLocal.NumeroVenta);
                            if (ventaLocal.NumeroTicketFiscal != null)
                            { PrinterDrawing prt = new PrinterDrawing(ventaLocal, formListaArticulos.ListaArticulosVtaActual.ToList(), "FISCAL"); }
                            else
                            {
                                PrinterDrawing prt = new PrinterDrawing(ventaLocal, formListaArticulos.ListaArticulosVtaActual.ToList(), "CLIENTE");
                            }
                        }
                    this.Dispose();
                    }
                }
                else
                    MessageBox.Show("No se puede generar un comprobante sin lineas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //actualizo el medio de pago
                this.setMedioPago();
                this.GuardarVenta();
                this.Dispose();

            }
        }


        private async void btnFacturar_Click(object sender, EventArgs e)
        {
            if (modo == "Alta")
            {
                if (this.dgvArticulosVtaActual.RowCount != 0 && Convert.ToDouble(this.txtTotal.Text) > 0)
                {
                    this.setMedioPago();
                    DialogResult construyeVenta = this.ConstruirVenta();
                    if (construyeVenta != DialogResult.Cancel)
                    {
                        this.GuardarVenta();
                        await this.FacturarVentaAsync();
                        if(construyeVenta == DialogResult.Yes)
                        {
                            ventaLocal = Datos_VentasAdapter.GetOne(ventaLocal.NumeroVenta);
                            if (ventaLocal.NumeroTicketFiscal != null)
                            { PrinterDrawing prt = new PrinterDrawing(ventaLocal, formListaArticulos.ListaArticulosVtaActual.ToList(), "FISCAL"); }
                            else
                            {
                                PrinterDrawing prt = new PrinterDrawing(ventaLocal, formListaArticulos.ListaArticulosVtaActual.ToList(), "CLIENTE");
                            }
                        }
                    this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("No se puede emitir un comprobante en $0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //actualizo el medio de pago
                this.setMedioPago();
                this.GuardarVenta();
                await this.FacturarVentaAsync();
                this.Dispose();

            }
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
            this.dgvArticulosVtaActual.Columns["descuento"].HeaderText = "Descuento ($)";
            this.dgvArticulosVtaActual.Columns["descuento"].DefaultCellStyle.Format = "c";
            this.dgvArticulosVtaActual.Columns["descuento_porcentaje"].HeaderText = "Descuento ($)";
            this.dgvArticulosVtaActual.Columns["descuento_porcentaje"].DefaultCellStyle.Format = "#.\\%";
            this.dgvArticulosVtaActual.Columns["CodigoArticulo"].HeaderText = "Código";
            this.dgvArticulosVtaActual.Columns["DescripcionArticulo"].HeaderText = "Descripción";
            this.dgvArticulosVtaActual.Columns["Precio"].HeaderText = "Precio ($)";
            this.dgvArticulosVtaActual.Columns["Precio"].DefaultCellStyle.Format = "c";
            this.dgvArticulosVtaActual.Columns["subtotal"].HeaderText = "SubTotal ($)";
            this.dgvArticulosVtaActual.Columns["subtotal"].DefaultCellStyle.Format = "c";

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
         
        //AÑADIR artículo a esta venta
        private void AñadirArticuloVtaActual()
        {
            
            formListaArticulos.ModoForm = UI.Desktop.Artículos.frmListadoArticulos.TipoForm.SeleccionDeArticulo;
           
            formListaArticulos.ShowDialog();
                     
            ActualizarVtaActual();
            AplicarDescuento();

            }

        //QUITAR artículo a esta venta
        //private void ElimArticuloVtaActual()
        //{
        //    if(dgvArticulosVtaActual.SelectedRows.Count > 0)
        //    {

        //    string codArtToElim = dgvArticulosVtaActual.SelectedRows[0].Cells["CodigoArticulo"].Value.ToString();
        //    Entidades.Venta_Articulo vtaArtToElim;
        //    foreach (Entidades.Venta_Articulo vtaArti in formListaArticulos.ListaArticulosVtaActual)
        //    {
        //        if (vtaArti.CodigoArticulo == codArtToElim)
        //        {
        //            vtaArtToElim = vtaArti;
        //            formListaArticulos.ListaArticulosVtaActual.Remove(vtaArtToElim);
        //            break;
        //        }
        //    }

        //    ActualizarVtaActual();
        //    }

            
        //}
        
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
            }
                ActualizarTotal();
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
                    var previoSubtotal = filaArt.Cantidad * Convert.ToDecimal(filaArt.Precio.ToString());
                    //filaArt.Subtotal = filaArt.Cantidad * Convert.ToDecimal(filaArt.Precio.ToString());
                    if (filaArt.Descuento_porcentaje != 0)
                    {
                        filaArt.Subtotal = previoSubtotal- (previoSubtotal * filaArt.Descuento_porcentaje/100);
                    }
                    else if (filaArt.Descuento != 0)
                    {
                        filaArt.Subtotal = previoSubtotal - filaArt.Descuento;

                    }
                    else
                    {
                        filaArt.Subtotal = previoSubtotal;
                    }
                    //filaArt.Descuento = (filaArt.Descuento_porcentaje/100)* filaArt.Subtotal;
                    total = Math.Round(total + Convert.ToDecimal(filaArt.Subtotal.ToString()),2);

                }

                this.txtTotal.Text = total.ToString("c");

                //Titulo de las columnas
                this.dgvArticulosVtaActual.Columns["Descuento"].HeaderText = "Descuento ($)";
                this.dgvArticulosVtaActual.Columns["Descuento_porcentaje"].HeaderText = "Descuento (%)";
                this.dgvArticulosVtaActual.Columns["CodigoArticulo"].HeaderText = "Código";
                this.dgvArticulosVtaActual.Columns["DescripcionArticulo"].HeaderText = "Descripción";
                this.dgvArticulosVtaActual.Columns["Precio"].HeaderText = "Precio ($)";
            }
            else //SI EL MODO ES MODIFICACION
            {
                //Decimal total = 0;

                
                ////Actualizar TOTAL -           filaArtVtaActual ya tiene el subtotal negativo
                //foreach (Entidades.Venta_Articulo filaArtVtaActual in formListaArticulos.ListaArticulosVtaActual)
                //{
                    
                //        if(filaArtVtaActual.TipoOperacion == "D")
                //        {
                //            total = Convert.ToDecimal(total + Convert.ToDecimal(filaArtVtaActual.Subtotal.ToString()));
                //        }
                    
                //}//ESTO NO FUNCIONA
                //this.txtTotal.Text = Convert.ToString(total);
            }
            this.dgvArticulosVtaActual.Refresh();
        }

        //APLICAR DESCUENTO
        private void AplicarDescuento()
        {
            ActualizarTotal();
            
            Decimal total = Convert.ToDecimal(txtTotal.Text);

            if (txtDcto.Text != "" && txtDcto.Text != "0")
            {
                Decimal descuentoTotal = (Convert.ToDecimal(txtTotal.Text) * Convert.ToDecimal(txtDcto.Text)) / 100;
                ventaLocal.Descuento = descuentoTotal;
                txtTotal.Text = (total - descuentoTotal).ToString("c");
            }
            else if (txtDctoPesos.Text != "" && txtDctoPesos.Text!="0")
            {
                Decimal descuentoTotal = Convert.ToDecimal(txtDctoPesos.Text);
                //Decimal total = Convert.ToDecimal(txtTotal.Text);
                if (descuentoTotal <= total)
                {
                    txtTotal.Text = (total - descuentoTotal).ToString("c");
                    ventaLocal.Descuento = descuentoTotal;
                }
                else
                {
                    MessageBox.Show("El monto de descuento es mayor al total. No puede aplicarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDctoPesos.Text = "";
                }
            }
            else
            {
                //ActualizarTotal();
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
        private DialogResult ConstruirVenta()
        {
            var formularioConfirmacion = this.ConfirmarVenta(); 
            DialogResult formConfirmarVenta = formularioConfirmacion.ShowDialog();
            if (modo == "Alta")
            {

                if (formConfirmarVenta == DialogResult.OK || formConfirmarVenta == DialogResult.Yes)
                {
                    foreach (Venta_Articulo lineaVta in formListaArticulos.ListaArticulosVtaActual)
                    {
                        lineaVta.NumeroVenta = ventaLocal.NumeroVenta;
                        lineaVta.TipoOperacion = ventaLocal.TipoOperacion;
                    }
                    ventaLocal.FechaHora = Convert.ToDateTime(DateTime.Now);

                    //#Data Fiscal
                    this.SetDatosClienteEnVenta();

                    ventaLocal.Total = Convert.ToDecimal(txtTotal.Text);
                    double Neto = Math.Round(Convert.ToDouble(txtTotal.Text) / 1.21,2);
                    ventaLocal.Neto = Convert.ToDouble(Neto.ToString("0.00"));
                    double Iva = Math.Round(Convert.ToDouble(ventaLocal.Total) - Neto,2);
                    ventaLocal.Iva = Convert.ToDouble(Iva.ToString("0.00"));

                    //TO-DO:FIX ON CUENTAS CORRIENTES
                    if (formularioConfirmacion.cuentaCorriente)
                    {
                        ventaLocal.Pagado = false;
                        ventaLocal.MontoPagado = 0;
                    }
                    else
                    {
                    ventaLocal.Pagado = true;
                    ventaLocal.MontoPagado = ventaLocal.Total;
                    }
                    //TO-DO: Evaluar parametro de Usuario para saber si el emisor es Monotributista
                    bool Monotributista = Convert.ToInt32(parametrosEmpresa.SituacionFiscal) == (int)FeConstantes.SituacionFiscal.MONOTRIBUTO;
                    
                    if (Monotributista)
                        ventaLocal.TipoComprobante = (int)FeConstantes.TipoComprobante.FacturaC;
                    else
                        ventaLocal.TipoComprobante = lblTipoComprobante.Text == "FACTURA B" ? (int)FeConstantes.TipoComprobante.FacturaB : clienteActual.TipoComprobante;
                }

                //Se imprime afuera
                //if (formConfirmarVenta == DialogResult.Yes)
                //{
                //    PrinterDrawing prt = new PrinterDrawing(ventaLocal, formListaArticulos.ListaArticulosVtaActual.ToList(), "CLIENTE");
                //}

                //if (formConfirmarVenta != DialogResult.Cancel)
                //{
                //    ActualizarStock();
                //}
            }
            else if (modo == "Devolucion")
            {
                //TODO:Devoluciones
                //Ventas.frmConfirmarVta formConfirmarVenta = new frmConfirmarVta();
                //formConfirmarVenta.Text = "Devolucion de Venta - Confirmar";
                //formConfirmarVenta.txtTotal.Text = this.txtTotal.Text;

                //string medio = null;

                //if (rbEfectivo.Checked)
                //{
                //    medio = "Efectivo";
                //    //vtaNueva.TipoPago = "Efectivo"; 
                //}
                //else if (rbTarjeta.Checked)
                //{
                //    medio = "Debito/Credito";
                //    // vtaNueva.TipoPago = "Debito/Credito";
                //}
                //else if (rbMP.Checked)
                //{
                //    medio = "Mercado Pago";
                //}

                //vtaModificar.TipoPago = medio;

                //formConfirmarVenta.txtTipoPago.Text = vtaModificar.TipoPago;
                //formConfirmarVenta.ShowDialog();

                //if (formConfirmarVenta.DialogResult == DialogResult.OK || formConfirmarVenta.DialogResult == DialogResult.Yes)
                //{
                //    vtaModificar.NumeroVenta = Convert.ToInt32(txtNumeroVenta.Text);
                //    vtaModificar.FechaHora = Convert.ToDateTime(DateTime.Now);
                //    vtaModificar.DniCliente = txtDniCuit.Text;
                //    vtaModificar.Total = Convert.ToDecimal(txtTotal.Text);
                //    vtaModificar.Usuario = usuarioLogueado.usuario;

                //    if (txtDcto.Text == "")
                //    {
                //        vtaModificar.Descuento = 0;
                //    }
                //    else
                //    {
                //        vtaModificar.Descuento = Convert.ToDecimal(txtDcto.Text);
                //    }

                //    //Datos_VentasAdapter.RegistrarVenta(vtaModificar);


                //    foreach (Entidades.Venta_Articulo lineaVta in formListaArticulos.ListaArticulosVtaActual)
                //    {
                //        //    if (lineaVta.TipoOperacion == "D")
                //        //    {
                //        lineaVta.NumeroVenta = vtaModificar.NumeroVenta;
                //        //        Datos_VentasArticulosAdapter.RegistrarLineaVta(lineaVta);
                //        //    }
                //    }
                //}

                //if (formConfirmarVenta.DialogResult == DialogResult.Yes)
                //{
                //    int numVenta = Convert.ToInt32(txtNumeroVenta.Text);

                //    string sql = "SELECT Ventas.numVenta, Ventas.fechaHora, Ventas.TipoPago, Ventas.Total, Clientes.dni, Clientes.apellido + ', ' + Clientes.nombre AS [Nombre y Apellido], Ventas_Articulos.CFARTCODIGO, Articulos.Descripcion, Ventas_Articulos.cantidad, Ventas_Articulos.precio FROM [Ventas] INNER JOIN [Ventas_Articulos] on Ventas.numVenta = Ventas_Articulos.CFVENNumVenta AND Ventas.TipoOperacion = Ventas_Articulos.TipoOperacion INNER JOIN [Articulos] on Ventas_Articulos.CFArtCodigo = Articulos.codigo LEFT JOIN [Clientes] on Ventas.dniCliente = Clientes.dni  WHERE (Ventas.numVenta =" + numVenta + " AND Ventas.tipooperacion = 'D' )";

                //    if (Datos_InformesAdapter.BuscarRegistros(sql))
                //    {
                //        System.IO.Directory.CreateDirectory("C:\\XML");
                //        string url = "C:\\XML\\informeVenta.xml";

                //        Datos_InformesAdapter.tablas.WriteXml(url, XmlWriteMode.WriteSchema);

                //    }

                //    frmInformeVenta formInformeVenta = new frmInformeVenta();
                //    formInformeVenta.ShowDialog();
                //    System.IO.File.Delete("C:\\XML\\informeVenta.xml");

                //}

                //if (formConfirmarVenta.DialogResult != DialogResult.Cancel)
                //{
                //    ActualizarStock();
                //}
            }
            return formConfirmarVenta;
        }


        //GUARDAR VENTA desde Variable Local
        private void GuardarVenta()
        {
            if(modo=="Alta")
            {
            Datos_VentasAdapter.RegistrarVenta(ventaLocal);

            foreach (Venta_Articulo lineaVta in formListaArticulos.ListaArticulosVtaActual)
            {
                //lineaVta.NumeroVenta = ventaLocal.NumeroVenta;
                //lineaVta.TipoOperacion = ventaLocal.TipoOperacion;
                Datos_VentasArticulosAdapter.RegistrarLineaVta(lineaVta);
            }
            ActualizarStock();
            }
            else if(modo=="READONLY")
            {
                Datos_VentasAdapter.ActualizarMedioDePago(ventaLocal);
            }
        }
        
        private async Task FacturarVentaAsync()
        {
            //TO-DO: FIX TOMAR PARAMETRO GENERAL - segundo parametro si es monotributista
            bool esMonotributo = Convert.ToInt32(parametrosEmpresa.SituacionFiscal) == (int)FeConstantes.SituacionFiscal.MONOTRIBUTO;
            await Facturador.facturarAsync(ventaLocal, esMonotributo);
        }
        private void setMedioPago()
        {

            //if (rbEfectivo.Checked)
            //{
            //    ventaLocal.TipoPago = "Efectivo";
            //    //vtaNueva.TipoPago = "Efectivo"; 
            //}
            //else if (rbTarjeta.Checked)
            //{
            //    ventaLocal.TipoPago = "Debito/Credito";
            //    // vtaNueva.TipoPago = "Debito/Credito";
            //}
            //else if (rbMP.Checked)
            //{
            //    ventaLocal.TipoPago = "Mercado Pago";
            //}
            //else
            //    ventaLocal.TipoPago = "";
            medioDePago = cbxMedioDePago.Text;
            ventaLocal.TipoPago = this.cbxMedioDePago.Text;
        }
        //GUARDAR VENTA
        private frmConfirmarVta ConfirmarVenta()
        {
            frmConfirmarVta formConfirmarVenta = new frmConfirmarVta();
            formConfirmarVenta.txtTotal.Text = this.txtTotal.Text;

           
            formConfirmarVenta.txtTipoPago.Text = ventaLocal.TipoPago;
            return formConfirmarVenta;
        }

        private void SetDatosClienteEnVenta()
        {
            ventaLocal.NumeroDocumentoCliente = clienteActual != null ? Convert.ToInt64(clienteActual.NumeroDocumento) : 0;
            //ventaLocal.SituacionFiscalCliente = clienteActual.TipoCliente; TO - DO: asignar id de situacion Fiscal
            ventaLocal.SituacionFiscalCliente = (int)FeConstantes.SituacionFiscal.ConsumidorFinal;
            ventaLocal.NombreCliente = clienteActual != null ? clienteActual.Nombre + " " + clienteActual.Apellido : "";
            ventaLocal.DireccionCliente = clienteActual != null ? clienteActual.Direccion : "";
            ventaLocal.TipoDocumentoCliente = clienteActual != null && clienteActual.TipoDocumento != null ? clienteActual.TipoDocumento : (int)FeConstantes.TipoDocumento.SIN_IDENTIFICAR;
        }
        private void ObtieneParametrosEmpresaAUI()
        {
            lblDireccion.Text = parametrosEmpresa.Direccion;
            lblNombreNegocio.Text = parametrosEmpresa.Nombre;
            lblTelefono.Text = parametrosEmpresa.Telefono;
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
            txtTipoComprobante.Text = GetEnumDescription((FeConstantes.TipoComprobante)clienteActual.TipoComprobante);
        }
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
            return attribute == null ? value.ToString() : attribute.Description;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            if (ventaLocal.NumeroTicketFiscal != null)
            { PrinterDrawing prt = new PrinterDrawing(ventaLocal, formListaArticulos.ListaArticulosVtaActual.ToList(), "FISCAL"); }
            else
            {
                PrinterDrawing prt = new PrinterDrawing(ventaLocal, formListaArticulos.ListaArticulosVtaActual.ToList(), "CLIENTE");
            }
        }

        
    }
}
