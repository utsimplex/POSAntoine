using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Entidades
{
    public class Cliente
    {
        /*   D A T O S    D E L    C L I E N T E    */
        
        //DNI
        public string NumeroDocumento { get; set; }
        public int? TipoDocumento { get; set; }

        //NOMBRE
        public string Nombre { get; set; }

        //APELLIDO
        public string Apellido { get; set; }

        //TELEFONO
        public string Telefono { get; set; }

        //DIRECCION
        public string Direccion { get; set; }

        //EMAIL
        public string Email { get; set; }

        //TIPO
        public string TipoCliente { get; set; }
        public int? TipoComprobante { get; set; }
        public int? SituacionFiscal { get; set; }

        //READONLY
        public string tipoDocumentoLetras
        {
            get
            {
                switch (TipoDocumento)
                {
                    case (int)FeConstantes.TipoDocumento.CUIL:
                        return "CUIL";
                    case (int)FeConstantes.TipoDocumento.CDI:
                        return "CDI";
                    case (int)FeConstantes.TipoDocumento.LC:
                        return "LC";
                    case (int)FeConstantes.TipoDocumento.CI_Extranjera:
                        return "CI EXTRANJERA";
                    case (int)FeConstantes.TipoDocumento.CUIT:
                        return "CUIT";
                    case (int)FeConstantes.TipoDocumento.DNI:
                        return "DNI";
                    case (int)FeConstantes.TipoDocumento.en_tramite:
                        return "EN TRAMITE;";
                    case (int)FeConstantes.TipoDocumento.LE:
                        return "LE;";
                    case (int)FeConstantes.TipoDocumento.Pasaporte:
                        return "PASAPORTE";
                    case (int)FeConstantes.TipoDocumento.SIN_IDENTIFICAR:
                        return "SIN IDENTIFICAR";
                    default: return "";
                }
            }
        }

        public string situacionFiscalLetras
        {
            get
            {
                switch (SituacionFiscal)
                {
                    case (int)FeConstantes.SituacionFiscal.ConsumidorFinal:
                        return "CONSUMIDOR FINAL";
                    case (int)FeConstantes.SituacionFiscal.EXENTO:
                        return "EXENTO";
                    case (int)FeConstantes.SituacionFiscal.MONOTRIBUTO:
                        return "MONOTRIBUTO";
                    case (int)FeConstantes.SituacionFiscal.NOALCANZADO:
                        return "NO ALCANZADO";
                    case (int)FeConstantes.SituacionFiscal.NOCATEGORIZADO:
                        return "NO CATEGORIZADO";
                    case (int)FeConstantes.SituacionFiscal.ResponsableInscripto:
                        return "RESPONSABLE INSCRIPTO";
                    default: return "";
                }
            }
        }


    }
}
