using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;
using System.Web.Script.Serialization;

namespace Entidades
{
    public class Seña
    {
        //NUMERO DE VENTA
        public int NumeroSeña { get; set; }

        //FECHA-HORA DE VENTA
        public DateTime FechaHora { get; set; }

        //TIPO DE PAGO
        public string TipoPago { get; set; }

        // TOTAL DEL COMPROBANTE (Decimal)
        public decimal Total { get; set; }

        //DNICLIENTE
        public string DniCliente { get; set; }

        public bool Pagado { get; set; }
        public decimal MontoPagado { get; set; }
        //IDEMPLEADO
        public string Usuario { get; set; }
        public int? CajaId { get; set; }

        public int? NumVentaAplicada { get; set; }
        //public <List>Seña_Articulo detalle {get;set;}


        //public int? TipoDocumentoCliente { get; set; }
        //public long? NumeroDocumentoCliente { get; set; }
        //public string NombreCliente { get; set; }
        //public long? CuitEmisor { get; set; }
        //public string DireccionCliente { get; set; }
    }    
}
