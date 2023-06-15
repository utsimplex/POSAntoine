using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;
using System.ComponentModel;
using static Entidades.FeConstantes;

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

        public int? RangoEtario { get; set; }

        public int? Familia { get; set; }

        public string CodigoArtiProveedor { get; set; }

        public decimal? Costo { get; set; }



        public string FamiliaTexto
        {
            get
            {
                switch (Familia)
                {
                    case (int)ArticuloConstantes.TipoFamilia.BUZOS:
                        return "BUZOS";
                    case (int)ArticuloConstantes.TipoFamilia.CAMPERAS:
                        return "CAMPERAS";
                    case (int)ArticuloConstantes.TipoFamilia.PANTALONES:
                        return "PANTALONES";
                    case (int)ArticuloConstantes.TipoFamilia.MEDIAS:
                        return "MEDIAS";
                    default: return "";
                }
            }
        }

        public string RangoEtarioTexto
        {
            get
            {
                switch (RangoEtario)
                {
                    case (int)ArticuloConstantes.RangoEtario.TresToCincoAños:
                        return "3 a 5 año";
                    case (int)ArticuloConstantes.RangoEtario.DosAños:
                        return "2 años";
                    case (int)ArticuloConstantes.RangoEtario.UnAñoYmedio:
                        return "1 año y medio";
                    case (int)ArticuloConstantes.RangoEtario.UnAño:
                        return "1 año";
                    case (int)ArticuloConstantes.RangoEtario.TresMeses:
                        return "Tres meses";
                    case (int)ArticuloConstantes.RangoEtario.SeisMeses:
                        return "Seis meses";
                    case (int)ArticuloConstantes.RangoEtario.NueveMeses:
                        return "Nueve meses";
                    default: return "";
                }
            }
        }

    }
    public class ArticuloConstantes
    {
        public enum TipoFamilia
        {
            [Description("BUZOS")]
            BUZOS,
            [Description("CAMPERAS")]
            CAMPERAS,
            [Description("MEDIAS")]
            MEDIAS,
            [Description("PANTALONES")]
            PANTALONES

        }

        public enum RangoEtario
        {
            [Description("Tres meses")]
            TresMeses,
            [Description("Seis meses")]
            SeisMeses,
            [Description("Nueve meses")]
            NueveMeses,
            [Description("1 año")]
            UnAño,
            [Description("1 año y medio")]
            UnAñoYmedio,
            [Description("2 años")]
            DosAños,
            [Description("3 a 5 años")]
            TresToCincoAños
        }

    }
}
