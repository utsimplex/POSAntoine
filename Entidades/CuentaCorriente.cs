using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaCorriente
    {
        public string Cliente { get; set; }
        public string Documento { get; set; }
        public int Venta { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public decimal Pagado { get; set; }
        public string Facturado { get; set; }
        public decimal Pendiente { get; set; }
    }
}
