using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;
using System.ComponentModel;
using static Entidades.FeConstantes;
using System.Reflection;

namespace Entidades
{
    public class Articulo
    {
        public Articulo()
        {
            // Inicializa el objeto Familia en el constructor
            Familia1 = new Familia();
            Familia2 = new Familia();
        }

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
        decimal _Precio;
        public decimal Precio
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

        // CAMPO PERSONALIZADO 1
        string _CampoPersonalizado1;
        public string CampoPersonalizado1
        {
            get { return _CampoPersonalizado1; }
            set { _CampoPersonalizado1 = value; }
        }
       
        // CAMPO PERSONALIZADO 2
        string _CampoPersonalizado2;
        public string CampoPersonalizado2
        {
            get { return _CampoPersonalizado2; }
            set { _CampoPersonalizado2 = value; }
        }


        public Familia Familia1 { get; set; }

        public Familia Familia2 { get; set; }

        public string CodigoArtiProveedor { get; set; }

        public decimal? Costo { get; set; }


        public string CodigoBarras { get; set; }




    }
}
