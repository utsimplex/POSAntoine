using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gasto
    {
        public int id { get; set; }
        public DateTime Fecha {get; set;}
        public string TipoGasto { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion {get; set; }
        public int? CajaId { get; set; }
    }
}
