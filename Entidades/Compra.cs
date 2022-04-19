using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;

namespace Entidades
{
    class Compra
    {
        // NUMERO DE COMPRA
        int _numCompra;
        public int NumCompra
        {
            get { return _numCompra; }
            set { _numCompra = value; }
        }

        //FECHA DE COMPRA
        DateTime _fecha_comp;
        public DateTime FechaCompra
        {
            get { return _fecha_comp; }
            set { _fecha_comp = value; }
        }

        //FECHA DE RECEPCION
        DateTime _fecha_recep;
        public DateTime FechaRecep
        {
            get { return _fecha_recep; }
            set { _fecha_recep = value; }
        }

        //ID USUARIO / EMPLEADO (CF(Usuario)
        int _IdUsuario;
        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario= value; }
        }

        //TOTAL  de la compra
        SqlMoney _total;
        public SqlMoney Total
        {
            get { return _total; }
            set { _total = value; }
        }
       




    }
}
