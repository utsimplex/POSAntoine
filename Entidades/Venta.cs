using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;
using System.Web.Script.Serialization;

namespace Entidades
{
   public class Venta
    {
        //NUMERO DE VENTA
        public int NumeroVenta{get; set;}
        
        //FECHA-HORA DE VENTA
        public DateTime FechaHora {get; set;}
    
        //TIPO DE PAGO
        public string TipoPago {get; set;}

        //TIPO DE Operacion (Venta - Devolucion)
        public string TipoOperacion { get; set; }
        
        // TOTAL DEL COMPROBANTE (Decimal)
        public decimal Total { get; set; }

        // DESCUENTO
       public decimal Descuento { get; set; }

       //DNICLIENTE
       public string DniCliente { get; set; }

        public bool Pagado { get; set; }
        public decimal MontoPagado { get; set; }
        //IDEMPLEADO
        public string Usuario { get; set; }
        public int CajaId { get; set; }

        //modulo de facturacion
        public double? Neto { get; set; }
        public double? Iva { get; set; }
        public int? TipoComprobante { get; set; }
        public int? PuntoDeVenta { get; set; }
        public string NumeroTicketFiscal { get; set; }
        public string CAE { get; set; }
        public DateTime? VencimientoCAE { get; set; }
        public int? TipoDocumentoCliente { get; set; }
        public long? NumeroDocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public long? CuitEmisor { get; set; }
        public string DireccionCliente{ get; set; }
        public int? SituacionFiscalCliente { get; set; }

        //propiedades read-only
        public string tipoDocumentoClienteRO
        {
            get
            {
                switch (TipoDocumentoCliente)
                {
                    case (int)FeConstantes.TipoDocumento.CUIL:
                        return "CUIL";
                    case (int)FeConstantes.TipoDocumento.CDI:
                        return "CDI";
                    case (int)FeConstantes.TipoDocumento.LC:
                        return "LC";
                    case (int)FeConstantes.TipoDocumento.CI_Extranjera:
                        return "CI EXTRANJERA";
                    case (int)FeConstantes.TipoDocumento.CUIT:
                        return "CUIT";
                    case (int)FeConstantes.TipoDocumento.DNI:
                        return "DNI";
                    case (int)FeConstantes.TipoDocumento.en_tramite:
                        return "EN TRAMITE;";
                    case (int)FeConstantes.TipoDocumento.LE:
                        return "LE;";
                    case (int)FeConstantes.TipoDocumento.Pasaporte:
                        return "PASAPORTE";
                    case (int)FeConstantes.TipoDocumento.SIN_IDENTIFICAR:
                        return "SIN IDENTIFICAR";
                    default: return "";
                }
            }
        }
        public string QRBase64RO
        {
            get
            {
                //TO-DO:Parameter
                string url = "https://serviciosweb.afip.gob.ar/genericos/comprobantes/cae.aspx?p=";
                string link;
                AfipJsonQR Data = new AfipJsonQR()
                {
                    Version = 1,
                    Fecha = this.FechaHora.ToString("yyyy-MM-dd"),
                    CUIT = (long)this.CuitEmisor,
                    PuntoDeVenta = (int)this.PuntoDeVenta,
                    TipoComprobante = (int)TipoComprobante,
                    NumeroComprobante = Convert.ToInt64(this.NumeroTicketFiscal),
                    Importe = Convert.ToDecimal(this.Total),
                    Moneda = "PES",
                    Cotizacion = 1,
                    NumeroDocumentoReceptor = (int)TipoDocumentoCliente == (int)FeConstantes.TipoDocumento.SIN_IDENTIFICAR ? 0 : (long)this.NumeroDocumentoCliente,
                    TipoDocumentoReceptor = (int)TipoDocumentoCliente,
                    TipoCodigoAutorizacion = "E",
                    CodigoAutorizacion = Convert.ToInt64(this.CAE)

                };

                link = new JavaScriptSerializer().Serialize(Data);
                byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(link);
                return url + Convert.ToBase64String(encbuff);
                //return base64;
            }
        }
        public string situacionFiscalClienteRO
        {
            get
            {
                switch (SituacionFiscalCliente)
                {
                    case (int)FeConstantes.SituacionFiscal.ConsumidorFinal:
                        return "CONSUMIDOR FINAL";
                    case (int)FeConstantes.SituacionFiscal.EXENTO:
                        return "EXENTO";
                    case (int)FeConstantes.SituacionFiscal.MONOTRIBUTO:
                        return "MONOTRIBUTO";
                    case (int)FeConstantes.SituacionFiscal.NOALCANZADO:
                        return "NO ALCANZADO";
                    case (int)FeConstantes.SituacionFiscal.NOCATEGORIZADO:
                        return "NO CATEGORIZADO";
                    case (int)FeConstantes.SituacionFiscal.ResponsableInscripto:
                        return "RESPONSABLE INSCRIPTO";
                    default: return "";
                }
            }
        }
        public string letraComprobateRO
        {
            get
            {
                switch (TipoComprobante)
                {
                    case (int)FeConstantes.TipoComprobante.FacturaA:
                        return "A";
                    case (int)FeConstantes.TipoComprobante.FacturaB:
                        return "B";
                    case (int)FeConstantes.TipoComprobante.FacturaC:
                        return "C";
                    case (int)FeConstantes.TipoComprobante.NDA:
                        return "ND A";
                    case (int)FeConstantes.TipoComprobante.NCA:
                        return "NC A";
                    case (int)FeConstantes.TipoComprobante.NDB:
                        return "ND B";
                    case (int)FeConstantes.TipoComprobante.NCB:
                        return "NC B";
                    case (int)FeConstantes.TipoComprobante.NDC:
                        return "ND C";
                    case (int)FeConstantes.TipoComprobante.NCC:
                        return "NC C";
                    default: return "";
                }
            }
        }
        public string puntoDeVentaRO
        {
            get
            {
                return ((int)(this.PuntoDeVenta)).ToString("00000");
            }
        }
        public string numeroDeComprobanteFiscalRO
        {
            get
            {
                return Convert.ToInt32(this.NumeroTicketFiscal).ToString("00000000");
            }
        }
        public string comprobanteFiscalRO
        {
            get
            {
                switch (TipoComprobante)
                {
                    case (int)FeConstantes.TipoComprobante.FacturaA:
                        return "A " + ((int)(this.PuntoDeVenta)).ToString("00000") + " - " + Convert.ToInt32(this.NumeroTicketFiscal).ToString("00000000");
                    case (int)FeConstantes.TipoComprobante.FacturaB:
                        return "B " + ((int)(this.PuntoDeVenta)).ToString("00000") + " - " + Convert.ToInt32(this.NumeroTicketFiscal).ToString("00000000");
                    case (int)FeConstantes.TipoComprobante.NDA:
                        return "ND A " + ((int)(this.PuntoDeVenta)).ToString("00000") + " - " + Convert.ToInt32(this.NumeroTicketFiscal).ToString("00000000");
                    case (int)FeConstantes.TipoComprobante.NCA:
                        return "NC A " + ((int)(this.PuntoDeVenta)).ToString("00000") + " - " + Convert.ToInt32(this.NumeroTicketFiscal).ToString("00000000");
                    case (int)FeConstantes.TipoComprobante.NDB:
                        return "ND B " + ((int)(this.PuntoDeVenta)).ToString("00000") + " - " + Convert.ToInt32(this.NumeroTicketFiscal).ToString("00000000");
                    case (int)FeConstantes.TipoComprobante.NCB:
                        return "NC B " + ((int)(this.PuntoDeVenta)).ToString("00000") + " - " + Convert.ToInt32(this.NumeroTicketFiscal).ToString("00000000");
                    default: return "";
                }
            }
        }






    }
}
