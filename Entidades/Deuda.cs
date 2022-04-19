using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;

namespace Entidades
{
    class Deuda
    {

        //FECHA DE CANCELACION
        DateTime _FechaCancel;
        public DateTime FechaCancel
        {
            get { return _FechaCancel; }
            set { _FechaCancel = value; }
        }

        //DNI CLIENTE DEUDOR
        int _dni;
        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        //MONTO QUE DEBE
        SqlMoney _Monto;
        public SqlMoney Monto
        {
            get { return _Monto; }
            set { _Monto = value; }
        }
    }
}
