using System;
using System.Collections.Generic;

using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
  public  class InformeVentaAdapter:Adapter
    {
        public SqlConnection conexion;

        public SqlDataAdapter adaptador;
        public SqlDataAdapter adaptador1;

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
                
                SqlConnection conexion = CrearConexion();

                adaptador = new SqlDataAdapter(consulta, conexion);

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
