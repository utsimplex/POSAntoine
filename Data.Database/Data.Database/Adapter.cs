using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

using System.Data.SqlServerCe;


namespace Data.Database
{
    public class Adapter
    {
        //Crea Cadena de conexion
        const string CadenaCon = "Data Source=C:\\POSDataBase\\POSDataBase.sdf";
        // static string CadenaCon = Properties.Settings.Default.ConnectionString;         

        //Crear y devuelve Conexion
        public static SqlCeConnection CrearConexion()
        {
            SqlCeConnection Conexion;
            try
            {
                //Objeto Conexion
                AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);
                Conexion = new SqlCeConnection(CadenaCon);

                //Devolvemos el objeto Conexion
                return Conexion;

            }
            finally
            {
                //No nos olvidemos de eliminar las referencias a objetos que no utilicemos
                Conexion = null;
            }


        }


    }
}
