using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MedioDePago
    {
        public int id { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public bool Default { get; set; }
    }
}
