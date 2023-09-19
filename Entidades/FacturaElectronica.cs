using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FacturaElectronica
    {
        public int id { get; set; }
        public long IdVenta { get; set; }
        public string Request { get; set; }
        public string RequestDetalle { get; set; }
        public string Response { get; set; }
        public string Resultado { get; set; }
        public string Observaciones { get; set; }

    }
    public class FeConstantes
    {
        public enum TipoComprobante
        {
            [Description("Factura A")]
            FacturaA = 1,
            [Description("Nota de Debito A")]
            NDA = 2,
            [Description("Nota de Credito A")]
            NCA = 3,
            [Description("Factura B")]
            FacturaB = 6,
            [Description("Nota de Debito B")]
            NDB = 7,
            [Description("Nota de Credito B")]
            NCB = 8,
            [Description("Factura C")]
            FacturaC = 11,
            [Description("Nota de Debito C")]
            NDC = 12,
            [Description("Nota de Credito C")]
            NCC = 13,

        }
        public enum TipoDocumento
        {
            [Description("SIN IDENTIFICAR")]
            SIN_IDENTIFICAR = 99,
            [Description("DNI")]
            DNI = 96,
            [Description("CUIT")]
            CUIT = 80,
            [Description("CUIL")]
            CUIL = 86,
            [Description("CDI")]
            CDI = 87,
            [Description("LE")]
            LE = 89,
            [Description("LC")]
            LC = 90,
            [Description("CI Extranjera")]
            CI_Extranjera = 91,
            [Description("En trámite")]
            en_tramite = 92,
            [Description("PASAPORTE")]
            Pasaporte = 94

        }
        public enum SituacionFiscal
        {
            [Description("Consumidor Final")]
            ConsumidorFinal = 5,
            [Description("IVA Responsable Inscripto")]
            ResponsableInscripto = 1,
            [Description("IVA Sujeto Exento")]
            EXENTO = 4,
            [Description("Responsable Monotributo")]
            MONOTRIBUTO = 6,
            [Description("Sujeto No Categorizado")]
            NOCATEGORIZADO = 7,
            [Description("IVA No Alcanzado")]
            NOALCANZADO = 15,
            //[Description("Monotributista Social")]
            //MTS = 13,
            //[Description("Monotributista Trabajador Independiente Promovido")]
            //MTIP = 16,

        }
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }
    }
}
