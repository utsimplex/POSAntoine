using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;
namespace Entidades
{
  public  class Seña_Articulo
    {
        //NUMERO DE VENTA CF(Venta)
        public int numeroSeña { get; set; }
        
        //CODIGO DEL ARTICULO CF(Articulo)
        public string codigoArticulo { get; set; }

        //DESCRIPCION DEL ARTICULO
        public string descripcionArticulo { get; set; }
        public int cantidad { get; set; }

    }
}
