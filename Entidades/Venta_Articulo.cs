using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;
namespace Entidades
{
  public  class Venta_Articulo
    {
        //NUMERO DE VENTA CF(Venta)
        int _NumeroVenta;
        public int NumeroVenta
        {
            get { return _NumeroVenta; }
            set { _NumeroVenta = value; }
        }

        //CODIGO DEL ARTICULO CF(Articulo)
        string _CodigoArticulo;
        public string CodigoArticulo
        {
            get { return _CodigoArticulo; }
            set { _CodigoArticulo = value; }
        }

        //DESCRIPCION DEL ARTICULO
        string _DescripcionArticulo;
        public string DescripcionArticulo
        {
            get { return _DescripcionArticulo; }
            set { _DescripcionArticulo = value; }
        }

        // CANTIDAD 
        int _cantidad;
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        // PRECIO DEL ARTICULO
        decimal _Precio;
        public decimal Precio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }

      // SUBTOTAL = PRECIO * CANTIDAD
        decimal _Subtotal;
        public decimal Subtotal
        {
            get { return _Subtotal; }
            set { _Subtotal = value; }
        }

        //TIPO DE Operacion (Venta - Devolucion)
        string _TipoOperacion;
        public string TipoOperacion
        {
            get { return _TipoOperacion; }
            set { _TipoOperacion = value; }
        }
    }
}
