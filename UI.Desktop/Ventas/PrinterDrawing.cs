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



namespace UI.Desktop.Ventas
{
    public class PrinterDrawing
    {
        //public CatalogoParametros parametros = new CatalogoParametros();
        //public CatalogoTipoCaja tipoCaja = new CatalogoTipoCaja();
        //public CatalogoCaja caja = new CatalogoCaja();
        public Venta _venta_Actual = new Venta();
        public List<Venta_Articulo> _venta_actual_articulos = new List<Venta_Articulo>();
        string nombreComandera = "";
        string _cabeceraComanda = "";
        string _directorioLogo = "";
        string _direccionComanda = "";
        string _telefonoComanda = "";
        string _imprimeFechaEmision = "";
        string _imprimeFechaEntrega = "";
        string _modo = ""; //Modo: CLIENTE ; COCINA
        string _prefijoCaja = ""; //Modo: DELIVERY ; MOSTRADOR
        public PrinterDrawing(Venta _venta, List<Venta_Articulo> _venta_articulos, string modo)
        {
            _venta_Actual = _venta;
            _venta_actual_articulos = _venta_articulos;
            _modo = modo;
            _directorioLogo = "C:\\ElArbolito\\ArbolitoDeAntoine.png";
            nombreComandera = "GP-C80180 Series";
            _cabeceraComanda = "El Arbolito de Antoine";
            _direccionComanda = "Chacabuco 842 - Venado Tuerto";
            _telefonoComanda = "Whatsapp: 3462-262000";
            //_direccionComanda = parametros.getOne("DIRECCION").Valor;
            //_telefonoComanda = parametros.getOne("TELEFONO").Valor;
            //_imprimeFechaEmision = parametros.getOne("EMISION").Valor;
            //_imprimeFechaEntrega = parametros.getOne("ENTREGA").Valor;
            //_prefijoCaja = tipoCaja.getOne(caja.getOne(_venta.caja).idTipoCaja).prefijo;
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
                    SizeF priceWidth = ev.Graphics.MeasureString("$ " + Convert.ToString(item.Precio), comandaNormalFont);
                    SizeF totalWidth = ev.Graphics.MeasureString("$ " + item.Subtotal.ToString(), comandaNormalFont);

                    //item.comanda = item.comanda ?? item.descripcion_linea.Replace("\r\n", string.Empty).Replace("1- ", "1 - ");
                    //item.comanda = item.comanda.Replace("\r\n", string.Empty).Replace("1- ", "1 - ");

                    ev.Graphics.DrawString(item.DescripcionArticulo, comandaNormalFont, Brushes.Black, 10, height, new StringFormat());
                    height += 15;
                    ev.Graphics.DrawString(item.Cantidad.ToString(), comandaNormalFont, Brushes.Black, 110 + qtyWidth.Width, height, new StringFormat());
                    ev.Graphics.DrawString("$ " + Convert.ToString(item.Precio), comandaNormalFont, Brushes.Black, 170 + (50 - priceWidth.Width), height, new StringFormat());
                    ev.Graphics.DrawString("$ " + item.Subtotal.ToString(), comandaNormalFont, Brushes.Black, 230 + (50 - totalWidth.Width), height, new StringFormat());
                    height += 20;

                }
                //Print Line
                ev.Graphics.DrawString(line, normalFont, Brushes.Black, 10, height, new StringFormat());
                height += 20;

                //Print Net Total
                //ev.Graphics.DrawString("Total", normalFont, Brushes.Black, 160, height, new StringFormat());

                SizeF netWidth = ev.Graphics.MeasureString("$" + _venta_Actual.Total.ToString(), descuentoFont);
                ev.Graphics.DrawString("Descuento", descuentoFont, Brushes.Black, 10, height, new StringFormat());
                ev.Graphics.DrawString("$" + _venta_Actual.Descuento.ToString(), descuentoFont, Brushes.Black, 220 + (50 - netWidth.Width), height, new StringFormat());
                height += 20;
                SizeF netWidth2 = ev.Graphics.MeasureString("$" + _venta_Actual.Total.ToString(), totalFont);
                ev.Graphics.DrawString("Total", totalFont, Brushes.Black, 10, height, new StringFormat());
                ev.Graphics.DrawString("$" + _venta_Actual.Total.ToString(), totalFont, Brushes.Black, 230 + (50 - netWidth2.Width), height, new StringFormat());
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
            else
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
        }


    }
}
