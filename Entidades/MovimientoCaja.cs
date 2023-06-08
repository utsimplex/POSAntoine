using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;
using System.Data;

namespace Entidades
{
    public class MovimientoCaja
    {

        public MovimientoCaja(int caja_id, string motivo, Boolean ingreso, decimal monto, string usuario)
        {
            Caja_id = caja_id;
            Motivo = motivo;
            Tipo = ingreso ? TipoMovimiento.Ingreso : TipoMovimiento.Retiro;
            Monto = monto;
            Usuario = usuario;

        }
        public int ID { get; set; }

        public int Caja_id { get; set; }

        public string Motivo { get; set; }

        public TipoMovimiento Tipo { get; set; }

        public decimal Monto { get; set; }

        public string Usuario { get; set; }


        public enum TipoMovimiento
        {
            Ingreso,
            Retiro
        }
    }
}
