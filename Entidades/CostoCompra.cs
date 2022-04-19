using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;

namespace Entidades
{
   public class CostoCompra
    {

       // FECHA DESDE 
       DateTime _fechaDesde;
       public DateTime FechaDesde
       {
           get { return _fechaDesde; }
           set { _fechaDesde = value; }
       }

       // NOMBRE CF(PROVEEDORES-ARTICULO)
       string _nombre;
       public string Nombre
       {
           get { return _nombre; }
           set { _nombre = value; }
       }

       // CODIGO CF(PROVEEDORES-ARTICULO)
       string _codigo;
       public string Codigo
       {
           get { return _codigo; }
           set { _codigo = value; }
       }

       // COSTO COMPRA PROVEEDOR (El proveedor ofrece un artículo al precio de...'costoCompraProv')
       SqlMoney _costoCompraProv;//precio que le pone el proveedor a un artículo
       public SqlMoney CostoCompraProv
       {
           get{return _costoCompraProv;}
           set { _costoCompraProv = value; }
       }


    }
}
