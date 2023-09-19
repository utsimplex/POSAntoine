using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CobroCuentaCorriente
    {
        public int id { get; set; }
        public string NumeroDocumentoCliente { get; set; }
        public string FacturasAfectadas { get; set; }
        public DateTime FechaHora {get; set;}
        public string MedioDePago {get; set; }
        public decimal MontoRecibido { get; set; }
    }
}
