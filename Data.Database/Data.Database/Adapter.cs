using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace Data.Database
{
    public class Adapter
    {
        //Crea Cadena de conexion
        //const string CadenaCon = "Data Source=C:\\BASES\\POSDataBase.sdf";


        //Crear y devuelve Conexion

        public static SqlConnection CrearConexion()
        {
            //connectionString = ConfigurationManager.AppSettings["connectionString"];
        string connectionString = "Data Source=.\\SQLEXPRESS;Database=POSUTSimplex; Integrated Security=True";

            SqlConnection ConexionSQL;
            try
            {
                ConexionSQL = new SqlConnection(connectionString);
                return ConexionSQL;

            }
            finally
            {
                ConexionSQL = null;
            }
        }

        //public static SqlCeConnection CrearConexion()
        //{
        //    SqlCeConnection Conexion;
        //    try
        //    {
        //        //Objeto Conexion
        //        AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
        //        Conexion = new SqlCeConnection(CadenaCon);

        //        //Devolvemos el objeto Conexion
        //        return Conexion;

        //    }
        //    finally
        //    {
        //        //No nos olvidemos de eliminar las referencias a objetos que no utilicemos
        //        Conexion = null;
        //    }


        //}


    }
}
