using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;

namespace Entidades
{
    class Precio
    {

        // FECHA DESDE PRECIO
        DateTime _FechaDesde;
        public DateTime FechaDesde
        {
            get { return _FechaDesde; }
            set { _FechaDesde = value; }
        }

        //CODIGO DE ARTICULO
        string _CodigoArt;
        public string CodigoArt
        {
            get { return _CodigoArt; }
            set { _CodigoArt = value; }
        }

        //PRECIO
        SqlMoney _Precio;
        public SqlMoney ValorPrecio
        {
            get { return _Precio; }
            set { _Precio = value; }
        }
    }
}
