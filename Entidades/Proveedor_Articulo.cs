using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;

namespace Entidades
{
    public class Proveedor_Articulo
    {
        //NOMBRE PROVEEDOR (CF (PROVEEDOR))
        string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        //CODIGO DEL ARTICULO (CF (ARTICULOS))
        string _CodigoArticulo;
        public string CodigoArticulo
        {
            get { return _CodigoArticulo; }
            set { _CodigoArticulo = value; }
        }

        //COSTO COMPRA AL PROVEEDOR
        SqlMoney _costoCompraProveedor;
        public SqlMoney CostoCompraProveedor
        {
            get { return _costoCompraProveedor; }
            set { _costoCompraProveedor = value; }
        }
    } 
}
