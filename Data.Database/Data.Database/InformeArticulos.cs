using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;

namespace Data.Database
{
    public class InformeArticulos: Adapter
    {

        public SqlCeConnection conexion;

        public SqlCeDataAdapter adaptador;
        public SqlCeDataAdapter adaptador1;

        public DataTable tabla;

        public DataSet tablaArticulos;

        public void conectarBD()
        {

            conexion = CrearConexion();

        }

        public bool BuscarRegistrosReponer(string consulta)
        {

            try
            {

                SqlCeConnection conexion = CrearConexion();

                adaptador = new SqlCeDataAdapter(consulta, conexion);

                tablaArticulos = new DataSet("tablaArticulos");

                adaptador.Fill(tablaArticulos, "articulosReponer");
                conexion.Close();
                return true;

                // System.IO.Directory.CreateDirectory("C:\XML");
                //tring url = "C:\XML\informeTramite.xml";

                //        tablas.WriteXml(url, XmlWriteMode.WriteSchema);


            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar información para crear el INFORME de Articulos", Ex);
                return false;
                throw ExcepcionManejada;
                
            }


        }

        public bool BuscarRegistrosListaPrecios(string consulta)
        {

            try
            {

                SqlCeConnection conexion = CrearConexion();

                adaptador = new SqlCeDataAdapter(consulta, conexion);

                tablaArticulos = new DataSet("tablaArticulos");

                adaptador.Fill(tablaArticulos, "ListaPrecios");
                conexion.Close();
                return true;

                // System.IO.Directory.CreateDirectory("C:\XML");
                //tring url = "C:\XML\informeTramite.xml";

                //        tablas.WriteXml(url, XmlWriteMode.WriteSchema);


            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar información para crear el INFORME de Articulos", Ex);
                return false;
                throw ExcepcionManejada;
               
            }


        } 
    }
}
