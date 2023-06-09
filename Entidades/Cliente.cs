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





    }
}
