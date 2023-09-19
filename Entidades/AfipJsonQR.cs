using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AfipJsonQR
    {
        public int Version { get; set; }
        public string Fecha { get; set; }
        public long CUIT { get; set; }
        public int PuntoDeVenta { get; set; }
        public int TipoComprobante { get; set; }
        public long NumeroComprobante { get; set; }
        public decimal Importe { get; set; }
        public string Moneda { get; set; }
        public decimal Cotizacion { get; set; }
        public int TipoDocumentoReceptor { get; set; }
        public long NumeroDocumentoReceptor { get; set; }
        public string TipoCodigoAutorizacion { get; set; }
        public long CodigoAutorizacion { get; set; }
    }
}
