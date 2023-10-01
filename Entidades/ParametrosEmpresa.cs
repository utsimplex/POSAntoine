using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ParametrosEmpresa
    {
        //public int id { get; set; }

        //Datos Generales
        public string Nombre { get; set; } //Propiedad que se va a mostrar en la UI(ej.Ventas) y en la cabecera de la comanda
        public string Direccion { get; set; }//Propiedad que se va a mostrar en la UI(ej.Ventas) y en la cabecera de la comanda
        public string Telefono { get; set; }//Propiedad que se va a mostrar en la UI(ej.Ventas) y en la cabecera de la comanda
        public string ImagenPath { get; set; }//Imagen que se va a imprimir en comandas, facturas y en UI
        public string Impresora1 { get; set; }//Path Impresora 1

        //Datos Fiscales
        public string CUIT { get; set; }
        public string NombreFiscal { get; set; }
        public string DireccionFiscal { get; set; }
        public string SituacionFiscal { get; set; }
        public string CertificadoDigital { get; set; }
        public string ClaveCertificado { get; set; }
        public string PuntoDeVenta { get; set; }
        public string InicioDeActividades { get; set; }
        public string IngresosBrutos { get; set; }
        public bool EsProduccion {get; set; }
        public string UrlQrAfip { get; set; }

        //Campos personalizados Artículos
        public string CampoPersonalizadoArticulo1 { get; set; }
        public string CampoPersonalizadoArticulo2 { get; set; }

        // Familias de artículos
        public string FamiliaNombre1 { get; set; }
        public string FamiliaNombre2 { get; set; }

        public List<Familia> ListadoFamilia1 { get; set; }
        
        public List<Familia> ListadoFamilia2 { get; set; }

        ////Campos personalizados Clientes
        //public string CampoPersonalizadoCliente1 { get; set; }
        //public string CampoPersonalizadoCliente2 { get; set; }

        ////Campos personalizados Proveedores
        //public string CampoPersonalizadoProveedor1 { get; set; }
        //public string CampoPersonalizadoProveedor2 { get; set; }

    }
}
