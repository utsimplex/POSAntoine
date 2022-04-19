using System;
using System.Collections.Generic;

using System.Text;
using System.Data.SqlServerCe;
using System.Data;

namespace Data.Database
{
  public  class InformeVentaAdapter:Adapter
    {
        public SqlCeConnection conexion;

        public SqlCeDataAdapter adaptador;
        public SqlCeDataAdapter adaptador1;

        public DataTable tabla;

        public DataSet tablas;

        public void conectarBD()
        {

            conexion = CrearConexion();

        }

        public bool BuscarRegistros(string consulta)
        {
           
            try
            {
                
                SqlCeConnection conexion = CrearConexion();

                adaptador = new SqlCeDataAdapter(consulta, conexion);

                tablas = new DataSet("tablas1");

                adaptador.Fill(tablas, "ventas");
                conexion.Close();
                return true;

                // System.IO.Directory.CreateDirectory("C:\XML");
                //tring url = "C:\XML\informeTramite.xml";

                //        tablas.WriteXml(url, XmlWriteMode.WriteSchema);


            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar información para crear el INFORME", Ex);
                return false;
                throw ExcepcionManejada;
               
            }

            
        } 
    }
}
