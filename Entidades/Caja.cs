﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;

namespace Entidades
{
   public class Caja
    {
        //ID DE CAJA
        int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        

        //DESCRIPCION
        string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        //FECHA CAJA
        DateTime _FechaCaja;
        public DateTime FechaCaja
        {
            get { return _FechaCaja; }
            set { _FechaCaja= value; }
        }

        //FECHA DE APERTURA
        DateTime _FechaApertura;
        public DateTime FechaApertura
        {
            get { return _FechaApertura; }
            set { _FechaApertura = value; }
        }

        //FECHA DE CIERRE
        DateTime? _FechaCierre;
        public DateTime? FechaCierre
        {
            get { return _FechaCierre; }
            set { _FechaCierre = value; }
        }

        DateTime? _FechaModificacion;
        public DateTime? FechaModificacion
        {
            get { return _FechaModificacion; }
            set { _FechaModificacion = value; }
        }
        // SALDO INICIAL
        SqlMoney _SaldoInicial;
        public SqlMoney SaldoInicial
        {
            get { return _SaldoInicial; }
            set { _SaldoInicial = value; }
        }

        // SALDO FINAL
        SqlMoney _SaldoFinal;
        public SqlMoney SaldoFinal
        {
            get { return _SaldoFinal; }
            set { _SaldoFinal = value; }
        }


        // MONTO NETO MOVIMIENTOS (Ingresos y Egresos)
        SqlMoney _MontoNetoMovimientos;
        public SqlMoney MontoNetoMovimientos
        {
            get { return _MontoNetoMovimientos; }
            set { _MontoNetoMovimientos = value; }
        }

        // USUARIO
        string _Abre_Usuario;
        public string AbreUsuario
        {
            get { return _Abre_Usuario; }
            set { _Abre_Usuario = value; }
        }

        // USUARIO
        string _Cierra_Usuario;
        public string CierraUsuario
        {
            get { return _Cierra_Usuario; }
            set { _Cierra_Usuario = value; }
        }

        // MONTO VENTAS TOTAL
        SqlMoney _MontoVentasTotal;
        public SqlMoney MontoVentasTotal
        {
            get { return _MontoVentasTotal; }
            set { _MontoVentasTotal = value; }
        }


















    }
}
