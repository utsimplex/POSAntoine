using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;

namespace Entidades
{
    public class Articulo
    {
        
        // CODIGO
        string _Codigo;
        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        // DESCRIPCION
        string _Descripcion;
        public string Descripcion 
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }


        // STOCK
        int _Stock;
        public int Stock
        {
            get { return _Stock; }
            set { _Stock = value; }
        }
        
        // STOCK MINIMO
        int _StockMin;
        public int StockMin
        {
            get { return _StockMin; }
            set { _StockMin = value; }
        }

        // PRECIO
        SqlMoney _Precio;
        public SqlMoney Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

        // MARCA
        string _Proveedor;
        public string Proveedor
        {
            get { return _Proveedor; }
            set { _Proveedor = value; }
        }

        // Habilitado
        string _Habilitado;
        public string Habilitado
        {
            get { return _Habilitado; }
            set { _Habilitado = value; }
        }
        
    }
}
