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
                return GetEnumDescription((ArticuloConstantes.TipoFamilia)Familia);
            }
        }
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
            return attribute == null ? value.ToString() : attribute.Description;
        }
        public string RangoEtarioTexto
        {
            get
            {
                return GetEnumDescription((ArticuloConstantes.RangoEtario)RangoEtario);
            }
        }

    }
    public class ArticuloConstantes
    {
        public enum TipoFamilia
        {
            //[Description("BUZOS")]
            //BUZOS,
            //[Description("CAMPERAS")]
            //CAMPERAS,
            //[Description("MEDIAS")]
            //MEDIAS,
            //[Description("PANTALONES")]
            //PANTALONES
            [Description("Remera Manga Corta")]
            RemeraMC = 1,
            [Description("Remera Manga Larga")]
            RemeraML,
            [Description("Pantalon Corto")]
            PantalonC,
            [Description("Pantalon Largo")]
            PantalonL,
            [Description("Buzo")]
            Buzo,
            [Description("Sweater")]
            Sweater,
            [Description("Campera")]
            Campera,
            [Description("Vestido Corto Manga Larga")]
            VestidoCortoML,
            [Description("Vestido Largo Manga Larga")]
            VestidoLargoML,
            [Description("Vestido Corto Manga Corta")]
            VestidoCortoMC,
            [Description("Vestido Largo Manga Corta")]
            VestidoLargoMC,
            [Description("Camisa Manga Larga")]
            CamisaML,
            [Description("Camisa Manga Corta")]
            CamisaMC,
            [Description("Polainas")]
            Polainas,
            [Description("Mantas")]
            Mantas,
            [Description("Frazada")]
            Frazada,
            [Description("Gorros")]
            Gorros,
            [Description("Bufanda")]
            Bufanda,
            [Description("Guantes")]
            Guantes,
            [Description("Cuellera")]
            Cuellera,
            [Description("Jumper")]
            Jumper,
            [Description("Calza")]
            Calza,
            [Description("Enterito")]
            Enterito,
            [Description("Accesorios")]
            Accesorios,
            [Description("Body Manga Larga")]
            BodyML,
            [Description("Pollera")]
            Pollera,
            [Description("Ropa Interior")]
            RopaInterior,
            [Description("Ranitas")]
            Ranitas,
            [Description("Ajuares")]
            Ajuares,
            [Description("Chaleco")]
            Chaleco,
            [Description("Zapatillas")]
            Zapatillas,
            [Description("Panchas")]
            Panchas,
            [Description("Gorros")]
            Botita,
            [Description("Borcegos")]
            Borcegos,
            [Description("Sandalia")]
            Sandalia,
            [Description("Cochecitos")]
            Cochecitos,
            [Description("Accesorios Carestino")]
            AccesoriosCarestino,
            [Description("Butaca")]
            Butaca,
            [Description("Silla de Comer")]
            SillaComer,
            [Description("Conjuntos")]
            Conjuntos
        }

        public enum RangoEtario
        {
            [Description("Baby")]
            Baby=1,
            [Description("Junior")]
            Junior,
            [Description("Teens")]
            Teens,
            [Description("No Caminante")]
            NoCaminante,
            [Description("Sin Rango")]
            SinRango

        }

    }
}
