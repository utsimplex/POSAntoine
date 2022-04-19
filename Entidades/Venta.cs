using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;

namespace Entidades
{
   public class Venta
    {
        //NUMERO DE VENTA
        int _NumeroVenta;
        public int NumeroVenta
        {
            get { return _NumeroVenta; }
            set { _NumeroVenta = value; }
        }
        
        //FECHA-HORA DE VENTA
        DateTime _FechaHora;
        public DateTime FechaHora
        {
            get { return _FechaHora; }
            set { _FechaHora= value; }
        }

    
        //TIPO DE PAGO
        string _TipoPago;
        public string TipoPago
        {
            get { return _TipoPago; }
            set { _TipoPago= value; }
        }

        //TIPO DE Operacion (Venta - Devolucion)
        string _TipoOperacion;
        public string TipoOperacion
        {
            get { return _TipoOperacion; }
            set { _TipoOperacion = value; }
        }

        // TOTAL DEL COMPROBANTE (Decimal)
        SqlMoney _Total;
        public SqlMoney Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        // DESCUENTO
        decimal _Descuento;
       public decimal Descuento
        {
            get { return _Descuento; }
            set { _Descuento = value; }
        }

       //DNICLIENTE
       string _dniCliente;
       public string DniCliente
       {
           get { return _dniCliente; }
           set { _dniCliente = value; }
       }

       //IDEMPLEADO
       string _usuario;
       public string Usuario
       {
           get { return _usuario; }
           set { _usuario = value; }
       }








    }
}
