using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using Data.Database;

namespace UI.Desktop.Ventas
{
    public class PrinterDrawing
    {
        //public CatalogoParametros parametros = new CatalogoParametros();
        //public CatalogoTipoCaja tipoCaja = new CatalogoTipoCaja();
        //public CatalogoCaja caja = new CatalogoCaja();
        public Venta _venta_Actual = new Venta();
        public List<Venta_Articulo> _venta_actual_articulos = new List<Venta_Articulo>();
        ParametrosAdapter Datos_ParametrosAdapter = new ParametrosAdapter();
        ParametrosEmpresa parametrosEmpresa = new ParametrosEmpresa();
        string nombreComandera = "";
        string _cabeceraComanda = "";
        string _directorioLogo = "";
        string _direccionComanda = "";
        string _telefonoComanda = "";
        //string _imprimeFechaEmision = "";
        //string _imprimeFechaEntrega = "";
        string _nombreFiscal = "";
        string _situacionFiscal = "";
        string _inicioActividades = "";
        string _direccionFiscal = "";
        string _ingBrutos = "";
        string _cuit = "";
        string _modo = ""; //Modo: CLIENTE ; COCINA
        string _prefijoCaja = ""; //Modo: DELIVERY ; MOSTRADOR
        public PrinterDrawing(Venta _venta, List<Venta_Articulo> _venta_articulos, string modo)
        {
            parametrosEmpresa =  this.Datos_ParametrosAdapter.getOne();
            _venta_Actual = _venta;
            _venta_actual_articulos = _venta_articulos;
            _modo = modo;
            //_directorioLogo = "C:\\ElArbolito\\ArbolitoDeAntoine.png";
            //nombreComandera = "GP-C80180 Series";
            //_cabeceraComanda = "El Arbolito de Antoine";
            //_direccionComanda = "Chacabuco 842 - Venado Tuerto";
            //_telefonoComanda = "Whatsapp: 3462-262000";
            //_nombreFiscal = "Florencia Anahi Polvaran";
            //_situacionFiscal = "Responsable Monotributo";
            //_inicioActividades = "01/07/2021";
            //_direccionFiscal = "Chacabuco 842 - Venado Tuerto";
            //_ingBrutos = "0324185027";
            //_cuit = "20350319250";
            _directorioLogo = parametrosEmpresa.ImagenPath;
            nombreComandera = parametrosEmpresa.Impresora1;
            _cabeceraComanda = parametrosEmpresa.Nombre;
            _direccionComanda = parametrosEmpresa.Direccion;
            _telefonoComanda = parametrosEmpresa.Telefono;
            _nombreFiscal = parametrosEmpresa.NombreFiscal;
            _situacionFiscal = FeConstantes.GetEnumDescription((FeConstantes.SituacionFiscal)Convert.ToInt32(parametrosEmpresa.SituacionFiscal));
            _inicioActividades = parametrosEmpresa.InicioDeActividades;
            _direccionFiscal = parametrosEmpresa.DireccionFiscal;
            _ingBrutos = parametrosEmpresa.IngresosBrutos;
            _cuit = parametrosEmpresa.CUIT;
            this.PrintTicket();
            //Print(nombreComandera.Valor, GetDocument());

        }

        public string printer = @"\\{0}\POS58";
        public static string PrinterName
        {
            //get { return nombreComandera.Valor; }
            get { return "GP-C80180 Series"; }
            //get { return printer.FormatWith(Environment.MachineName); }
        }

        private void PrintTicket()
        {

            try
            {
                PrintDocument pd = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();

                pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
                pd.PrinterSettings.PrinterName = nombreComandera; //"80mm Thermal Printer";
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            Font headingFont = new System.Drawing.Font("Calibri", 14, System.Drawing.FontStyle.Bold);
            Font boldFont = new System.Drawing.Font("Calibri", 11, System.Drawing.FontStyle.Bold);
            Font normalFont = new System.Drawing.Font("Calibri", 11, System.Drawing.FontStyle.Regular);
            Font lessNormalFont = new System.Drawing.Font("Calibri", 8, System.Drawing.FontStyle.Regular);
            Font numPedidoFont = new System.Drawing.Font("Calibri", 14, System.Drawing.FontStyle.Bold);
            Font comandaNormalFont = new System.Drawing.Font("Calibri", 9, System.Drawing.FontStyle.Regular);
            Font comandaCocinaFont = new System.Drawing.Font("Calibri", 12, System.Drawing.FontStyle.Regular);
            Font descuentoFont = new System.Drawing.Font("Calibri", 10, System.Drawing.FontStyle.Bold);
            Font totalFont = new System.Drawing.Font("Calibri", 12, System.Drawing.FontStyle.Bold);
            Font totalCocinaFont = new System.Drawing.Font("Calibri", 16, System.Drawing.FontStyle.Bold);

            float topMargin = ev.MarginBounds.Top;
            float leftMargin = ev.MarginBounds.Left;

            string line = string.Concat(Enumerable.Repeat("-", 60)); ;
            float height = 10;

            if (_modo == "CLIENTE")
            {
                Image img = Image.FromFile(_directorioLogo);
                ev.Graphics.DrawImage(img, new PointF(70, height));
                img.Dispose();
                height += 140;
                //Print Cabecera
                ev.Graphics.DrawString(_cabeceraComanda, headingFont, Brushes.Black, 50, height, new StringFormat());
                height += 30;
                //Print Direccion
                ev.Graphics.DrawString(_direccionComanda, lessNormalFont, Brushes.Black, 65, height, new StringFormat());
                height += 20;
                ////Print Telefono
                ev.Graphics.DrawString(_telefonoComanda, lessNormalFont, Brushes.Black, 80, height, new StringFormat());
                height += 20;

                //Print Info
                ev.Graphics.DrawString("X", numPedidoFont, Brushes.Black, 131, height, new StringFormat());
                height += 20;
                ev.Graphics.DrawString("Documento no valido como Factura", lessNormalFont, Brushes.Black, 60, height, new StringFormat());
                height += 15;

                //Print Receipt Date
                ev.Graphics.DrawString("N° " + _venta_Actual.NumeroVenta, numPedidoFont, Brushes.Black, 10, height, new StringFormat());
                height += 20;
                //if (!String.IsNullOrWhiteSpace(_venta_Actual.Usuario))
                //{
                //    ev.Graphics.DrawString("Atendido por: "+_venta_Actual.Usuario, normalFont, Brushes.Black, 10, height, new StringFormat());
                //    height += 15;

                //}
                // DATOS DEL CLIENTE
                //if (!String.IsNullOrWhiteSpace(_venta_Actual.direccion_cliente))
                //{
                //    ev.Graphics.DrawString(_venta_Actual.direccion_cliente, headingFont, Brushes.Black, 10, height, new StringFormat());
                //    height += 25;
                //}
                //if (!String.IsNullOrWhiteSpace(_venta_Actual.telefono_cliente))
                //{
                //    ev.Graphics.DrawString(_venta_Actual.telefono_cliente, normalFont, Brushes.Black, 10, height, new StringFormat());
                //    height += 20;
                //}
                //if (!String.IsNullOrWhiteSpace(_venta_Actual.Descripcion))
                //{
                //    ev.Graphics.DrawString(_venta_Actual.Descripcion, normalFont, Brushes.Black, 10, height, new StringFormat());
                //    height += 20;
                //}

                //Print Line
                ev.Graphics.DrawString(line, normalFont, Brushes.Black, 10, height, new StringFormat());
                height += 20;

                //Printe Table Headings
                ev.Graphics.DrawString("Articulo", boldFont, Brushes.Black, 10, height, new StringFormat());
                ev.Graphics.DrawString("Cant", boldFont, Brushes.Black, 110, height, new StringFormat());
                ev.Graphics.DrawString("Precio", boldFont, Brushes.Black, 170, height, new StringFormat());
                ev.Graphics.DrawString("Total", boldFont, Brushes.Black, 230, height, new StringFormat());
                height += 20;

                //Print Line
                ev.Graphics.DrawString(line, normalFont, Brushes.Black, 10, height, new StringFormat());
                height += 20;

                //Printe Table Rows
                foreach (var item in _venta_actual_articulos)
                {
                    SizeF qtyWidth = ev.Graphics.MeasureString(item.Cantidad.ToString(), comandaNormalFont);
                    SizeF priceWidth = ev.Graphics.MeasureString(item.Precio.ToString("c"), comandaNormalFont);
                    SizeF totalWidth = ev.Graphics.MeasureString(item.Subtotal.ToString("c"), comandaNormalFont);


                    ev.Graphics.DrawString(item.DescripcionArticulo, comandaNormalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 15;
                    ev.Graphics.DrawString(item.Cantidad.ToString(), comandaNormalFont, Brushes.Black, 105 + qtyWidth.Width, height, new StringFormat());
                    ev.Graphics.DrawString(item.Precio.ToString("c"), comandaNormalFont, Brushes.Black, 16 + (50 - priceWidth.Width), height, new StringFormat());
                    ev.Graphics.DrawString(item.Subtotal.ToString("c"), comandaNormalFont, Brushes.Black, 230 + (50 - totalWidth.Width), height, new StringFormat());
                    if (item.Descuento != 0)
                    {
                        height += 15;
                        ev.Graphics.DrawString("Descuento", comandaNormalFont, Brushes.Black, 110 + qtyWidth.Width, height, new StringFormat());
                        ev.Graphics.DrawString((item.Descuento *-1).ToString("c"), comandaNormalFont, Brushes.Black, 230 + (50 - totalWidth.Width), height, new StringFormat());
                    }
                    else if(item.Descuento_porcentaje !=0)
                    {
                        height += 15;
                        ev.Graphics.DrawString("Descuento", comandaNormalFont, Brushes.Black, 110 + qtyWidth.Width, height, new StringFormat());
                        ev.Graphics.DrawString((item.Descuento_porcentaje/100*item.Cantidad * item.Precio *-1).ToString("c"), comandaNormalFont, Brushes.Black, 230 + (50 - totalWidth.Width), height, new StringFormat());
                    }
                    height += 20;

                }
                //Print Line
                ev.Graphics.DrawString(line, normalFont, Brushes.Black, 10, height, new StringFormat());
                height += 20;

                //Print Net Total
                //ev.Graphics.DrawString("Total", normalFont, Brushes.Black, 160, height, new StringFormat());

                SizeF netWidth = ev.Graphics.MeasureString((_venta_Actual.Total*-1).ToString("c"), descuentoFont);
                ev.Graphics.DrawString("Descuento", descuentoFont, Brushes.Black, 10, height, new StringFormat());
                ev.Graphics.DrawString((_venta_Actual.Descuento *-1).ToString("c"), descuentoFont, Brushes.Black, 220 + (50 - netWidth.Width), height, new StringFormat());
                height += 20;
                SizeF netWidth2 = ev.Graphics.MeasureString(_venta_Actual.Total.ToString("c"), totalFont);
                ev.Graphics.DrawString("Total", totalFont, Brushes.Black, 10, height, new StringFormat());
                ev.Graphics.DrawString(_venta_Actual.Total.ToString("c"), totalFont, Brushes.Black, 230 + (50 - netWidth2.Width), height, new StringFormat());
                height += 20;

                //Print Line
                ev.Graphics.DrawString(line, normalFont, Brushes.Black, 10, height, new StringFormat());
                height += 20;

                //if (_imprimeFechaEmision == "true")
                //{
                    ev.Graphics.DrawString("Emision " + _venta_Actual.FechaHora.ToString(), lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 20;
                //}
                //if (_imprimeFechaEntrega == "true" && _venta_Actual.minutos_estimados != null)
                //{
                //    ev.Graphics.DrawString("Entrega Estimada " + _venta_Actual.fecha.AddMinutes((int)_venta_Actual.minutos_estimados).ToString("dd/MM/yyyy HH:mm"), lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                //}
                ev.HasMorePages = false;
            }
            else if (_modo=="COCINA")
            {
                //MODO COCINA
                //Print Cabecera
                ev.Graphics.DrawString(" PEDIDO # " + _venta_Actual.NumeroVenta, headingFont, Brushes.Black, 10, height, new StringFormat());
                height += 20;
                if (!String.IsNullOrWhiteSpace(_venta_Actual.DniCliente))
                {
                    ev.Graphics.DrawString(_venta_Actual.DniCliente, numPedidoFont, Brushes.Black, 10, height, new StringFormat());
                    height += 20;
                }
                //if (!String.IsNullOrWhiteSpace(_venta_Actual.nombre_cliente))
                //{
                //    ev.Graphics.DrawString(_venta_Actual.nombre_cliente, numPedidoFont, Brushes.Black, 10, height, new StringFormat());
                //    height += 20;
                //}
                //if (!String.IsNullOrWhiteSpace(_venta_Actual.direccion_cliente))
                //{
                //    ev.Graphics.DrawString(_venta_Actual.direccion_cliente, numPedidoFont, Brushes.Black, 10, height, new StringFormat());
                //    height += 20;
                //}
                //if (!String.IsNullOrWhiteSpace(_venta_Actual.telefono_cliente))
                //{
                //    ev.Graphics.DrawString(_venta_Actual.telefono_cliente, numPedidoFont, Brushes.Black, 10, height, new StringFormat());
                //    height += 20;
                //}

                foreach (var item in _venta_actual_articulos)
                {
                    //item.comanda = item.comanda ?? item.descripcion_linea;
                    //item.comanda = item.comanda.Replace("\r\n", string.Empty) ?? item.descripcion_linea.Replace("\r\n", string.Empty);
                    ev.Graphics.DrawString(item.DescripcionArticulo.ToString()+" ", comandaCocinaFont, Brushes.Black, 10, height, new StringFormat());
                    height += 20;
                }

                ev.Graphics.DrawString("$" + _venta_Actual.Total.ToString(), totalCocinaFont, Brushes.Black, 180 , height, new StringFormat());
                    height += 20;
                ev.Graphics.DrawString("Emision " + _venta_Actual.FechaHora.ToString(), lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                //if (_venta_Actual.minutos_estimados != null)
                //{
                //ev.Graphics.DrawString("Entrega Estimada " + _venta_Actual.fecha.AddMinutes((int)_venta_Actual.minutos_estimados).ToString("dd/MM/yyyy HH:mm"), lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                //    height += 20;
                //}
                ev.HasMorePages = false;

            }
                 else if (_modo == "FISCAL")
                {
                    //Print Cabecera

                    ev.Graphics.DrawString(_cabeceraComanda, headingFont, Brushes.Black, 10, height, new StringFormat());
                    height += 25;
                    ev.Graphics.DrawString(_nombreFiscal, lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 15;
                    ev.Graphics.DrawString("C.U.I.T. " + _cuit, lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 15;
                    ev.Graphics.DrawString("Ing. Brutos: " + _ingBrutos, lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 15;
                    ev.Graphics.DrawString("Domicilio: " + _direccionFiscal, lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 15;
                    ev.Graphics.DrawString("Inicio de Actividades: " + _inicioActividades, lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 15;
                    ev.Graphics.DrawString(_situacionFiscal, lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 10;

                    //Print Line
                    ev.Graphics.DrawString(line, normalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 15;
                    ///DATOS CABECERA FACTURA
                    ev.Graphics.DrawString("FACTURA '" + _venta_Actual.letraComprobateRO + "'     N° " + _venta_Actual.puntoDeVentaRO + "-" + _venta_Actual.numeroDeComprobanteFiscalRO, lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 15;
                    ev.Graphics.DrawString("Fecha: " + _venta_Actual.FechaHora.ToString("dd/MM/yyyy"), lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 15;
                    //ev.Graphics.DrawString("Hora: " + _venta_Actual.fecha.ToString("HH:mm:ss"), lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                    //height += 10;

                    //Print Line
                    ev.Graphics.DrawString(line, normalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 15;

                    ///DATOS CLIENTE
                    if (_venta_Actual.TipoDocumentoCliente == (int)FeConstantes.TipoDocumento.SIN_IDENTIFICAR)
                    {
                        string NroDNI = _venta_Actual.TipoDocumentoCliente == (int)FeConstantes.TipoDocumento.SIN_IDENTIFICAR ? "" : " Nro: " + _venta_Actual.NumeroDocumentoCliente.ToString();
                        ev.Graphics.DrawString(_venta_Actual.tipoDocumentoClienteRO + NroDNI, lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                        height += 15;
                        ev.Graphics.DrawString("A " + _venta_Actual.situacionFiscalClienteRO, lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                        height += 15;
                    }
                    else
                    {
                        ev.Graphics.DrawString(_venta_Actual.NombreCliente, lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                        height += 15;
                        ev.Graphics.DrawString(_venta_Actual.tipoDocumentoClienteRO + " Nro: " + _venta_Actual.NumeroDocumentoCliente.ToString(), lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                        height += 15;
                        ev.Graphics.DrawString("A " + _venta_Actual.situacionFiscalClienteRO, lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                        height += 15;
                        ev.Graphics.DrawString(_venta_Actual.DireccionCliente, lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                        height += 10;
                    }

                    //Print Line
                    ev.Graphics.DrawString(line, normalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 15;

                    ev.Graphics.DrawString("Ref:" + _venta_Actual.CajaId.ToString(), lessNormalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 15;

                    //Print Receipt Date
                    ev.Graphics.DrawString("N° " + _venta_Actual.NumeroVenta, numPedidoFont, Brushes.Black, 10, height, new StringFormat());
                    height += 20;
                    //Print Line
                    ev.Graphics.DrawString(line, normalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 15;

                    //Printe Table Headings
                    ev.Graphics.DrawString("Item", boldFont, Brushes.Black, 10, height, new StringFormat());
                    ev.Graphics.DrawString("Cant", boldFont, Brushes.Black, 70, height, new StringFormat());
                    ev.Graphics.DrawString("P. Unit", boldFont, Brushes.Black, 120, height, new StringFormat());
                    ev.Graphics.DrawString("Total", boldFont, Brushes.Black, 230, height, new StringFormat());
                    height += 10;

                    //Print Line
                    ev.Graphics.DrawString(line, normalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 20;

                    //Printe Table Rows
                    foreach (var item in _venta_actual_articulos)
                    {
                        SizeF qtyWidth = ev.Graphics.MeasureString(item.Cantidad.ToString(), comandaNormalFont);
                        SizeF priceWidth = ev.Graphics.MeasureString((item.Subtotal / item.Cantidad).ToString("c"), comandaNormalFont);
                        SizeF netPriceWidth = ev.Graphics.MeasureString(item.Subtotal.ToString("c"), comandaNormalFont);
                        SizeF totalWidth = ev.Graphics.MeasureString(item.Subtotal.ToString("c"), comandaNormalFont);
                        SizeF netTotalWidth = ev.Graphics.MeasureString(item.Subtotal.ToString("c"), comandaNormalFont);

                        //item.comanda = item.comanda ?? item.descripcion_linea.Replace("\r\n", string.Empty).Replace("1- ", "1 - ");
                        //item.comanda = item.comanda.Replace("\r\n", string.Empty).Replace("1- ", "1 - ");

                        ev.Graphics.DrawString(item.DescripcionArticulo, comandaNormalFont, Brushes.Black, 10, height, new StringFormat());
                        height += 15;
                        ev.Graphics.DrawString(item.Cantidad.ToString(), comandaNormalFont, Brushes.Black, 80, height, new StringFormat());
                        if (_venta_Actual.letraComprobateRO == "A")
                        {
                            //ev.Graphics.DrawString("$ " + item.monto_neto_unitario.ToString("0.00"), comandaNormalFont, Brushes.Black, 170 - netPriceWidth.Width, height, new StringFormat());
                            //ev.Graphics.DrawString("(21)", comandaNormalFont, Brushes.Black, 180, height, new StringFormat());
                            //ev.Graphics.DrawString("$ " + item.monto_neto.ToString("0.00"), comandaNormalFont, Brushes.Black, 275 - netTotalWidth.Width, height, new StringFormat());
                            height += 15;
                        }
                        else
                        {
                            ev.Graphics.DrawString(item.Precio.ToString("c"), comandaNormalFont, Brushes.Black, 170 - priceWidth.Width, height, new StringFormat());
                            ev.Graphics.DrawString("(21)", comandaNormalFont, Brushes.Black, 180, height, new StringFormat());
                            ev.Graphics.DrawString(item.Subtotal.ToString("c"), comandaNormalFont, Brushes.Black, 275 - totalWidth.Width, height, new StringFormat());
                            height += 15;
                        if (item.Descuento != 0)
                        {
                            height += 15;
                            ev.Graphics.DrawString("Descuento", comandaNormalFont, Brushes.Black, 110 + qtyWidth.Width, height, new StringFormat());
                            //ev.Graphics.DrawString("$ " + Convert.ToString(item.Precio), comandaNormalFont, Brushes.Black, 170 + (50 - priceWidth.Width), height, new StringFormat());
                            ev.Graphics.DrawString("- " +  (item.Descuento *-1).ToString("c"), comandaNormalFont, Brushes.Black, 230 + (50 - totalWidth.Width), height, new StringFormat());
                        }
                        else if (item.Descuento_porcentaje != 0)
                        {
                            height += 15;
                            ev.Graphics.DrawString("Descuento", comandaNormalFont, Brushes.Black, 110 + qtyWidth.Width, height, new StringFormat());
                            //ev.Graphics.DrawString("$ " + Convert.ToString(item.Precio), comandaNormalFont, Brushes.Black, 170 + (50 - priceWidth.Width), height, new StringFormat());
                            ev.Graphics.DrawString((item.Descuento_porcentaje / 100 * item.Cantidad * item.Precio *-1).ToString("c"), comandaNormalFont, Brushes.Black, 230 + (50 - totalWidth.Width), height, new StringFormat());
                        }
                    }

                    }
                    //Print Line
                if (_venta_Actual.Descuento != Convert.ToDecimal(0))
                {
                    SizeF descuentoWidth = ev.Graphics.MeasureString((_venta_Actual.Descuento *-1).ToString("c"), comandaNormalFont);
                    ev.Graphics.DrawString("DESCUENTO", comandaNormalFont, Brushes.Black, 10, height, new StringFormat());
                    ev.Graphics.DrawString((_venta_Actual.Descuento *-1).ToString("c"), comandaNormalFont, Brushes.Black, 275- descuentoWidth.Width, height, new StringFormat());

                    height += 15;
                }
                    ev.Graphics.DrawString(line, normalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 20;
                //Print Net Total
                //ev.Graphics.DrawString("Total", normalFont, Brushes.Black, 160, height, new StringFormat());
                if (_venta_Actual.letraComprobateRO == "A")
                {
                    SizeF netWidth = ev.Graphics.MeasureString(Convert.ToDouble(_venta_Actual.Neto).ToString("c"), totalFont);
                    ev.Graphics.DrawString("SubTotal", totalFont, Brushes.Black, 100, height, new StringFormat());
                    //ev.Graphics.DrawString("$", totalFont, Brushes.Black, 180, height, new StringFormat());
                    ev.Graphics.DrawString(Convert.ToDouble(_venta_Actual.Neto).ToString("c"), totalFont, Brushes.Black, 275 - netWidth.Width, height, new StringFormat());
                    height += 20;
                    SizeF ivaWidth = ev.Graphics.MeasureString(Convert.ToDouble(_venta_Actual.Iva).ToString("c"), totalFont);
                    ev.Graphics.DrawString("IVA 21%", totalFont, Brushes.Black, 100, height, new StringFormat());
                    //ev.Graphics.DrawString("$", totalFont, Brushes.Black, 180, height, new StringFormat());
                    ev.Graphics.DrawString(Convert.ToDouble(_venta_Actual.Iva).ToString("c"), totalFont, Brushes.Black, 275 - ivaWidth.Width, height, new StringFormat());
                    height += 20;
                    SizeF totalWidth = ev.Graphics.MeasureString(_venta_Actual.Total.ToString("c"), totalFont);
                    ev.Graphics.DrawString("Total", totalFont, Brushes.Black, 120, height, new StringFormat());
                    ev.Graphics.DrawString("$", totalFont, Brushes.Black, 180, height, new StringFormat());
                    ev.Graphics.DrawString(_venta_Actual.Total.ToString("c"), totalFont, Brushes.Black, 275 - totalWidth.Width, height, new StringFormat());
                    height += 25;
                }
                else
                {
                    SizeF netWidth = ev.Graphics.MeasureString("Total " + _venta_Actual.Total.ToString("c"), totalFont);
                    ev.Graphics.DrawString("Total " + _venta_Actual.Total.ToString("c"), totalFont, Brushes.Black, 275 - netWidth.Width, height, new StringFormat());
                    height += 25;
                }

                    ev.Graphics.DrawString("*** FACTURACION ELECTRÓNICA ***", lessNormalFont, Brushes.Black, 60, height, new StringFormat());
                    height += 15;
                    //Print Line
                    ev.Graphics.DrawString("CAE: " + _venta_Actual.CAE, lessNormalFont, Brushes.Black, 60, height, new StringFormat());
                    height += 15;
                    ev.Graphics.DrawString("Fecha Vto CAE: " + ((DateTime)_venta_Actual.VencimientoCAE).ToString("dd/MM/yyyy"), lessNormalFont, Brushes.Black, 60, height, new StringFormat());
                    height += 15;

                    byte[] encbuff = System.Text.Encoding.UTF8.GetBytes("JSON");
                    Convert.ToBase64String(encbuff);
                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(_venta_Actual.QRBase64RO, QRCodeGenerator.ECCLevel.Q);
                    //pictureBoxQRCode.BackgroundImage = qrCodeData.GetGraphic(20);
                    QRCode qrCode = new QRCode(qrCodeData);
                    //Image qr = new Bitmap(qrCode.GetGraphic(20), new Size(100, 100));
                    ev.Graphics.DrawImage(qrCode.GetGraphic(40), 70, height, 140, 140);

                    ev.HasMorePages = false;
                }
        }


    }
}
