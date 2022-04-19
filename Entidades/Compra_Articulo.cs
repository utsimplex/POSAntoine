using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Entidades
{
    class Compra_Articulo
    {
        //CODIGO DEL ARTICULO CF(Articulo)
        string _CodigoArticulo;
        public string CodigoArticulo
        {
            get { return _CodigoArticulo; }
            set { _CodigoArticulo = value; }
        }

        // NUMERO DE COMPRA CF(Compra)
        int _numCompra;
        public int NumCompra
        {
            get { return _numCompra; }
            set { _numCompra = value; }
        }

        // CANTIDAD 
        int _cantidad;
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        
    }
}
