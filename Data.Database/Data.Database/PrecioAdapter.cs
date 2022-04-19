using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using System.Data.SqlTypes;


namespace Data.Database
{
    public class PrecioAdapter: Adapter
    {

        public void AñadirNuevoPrecio(string codArti, System.Data.SqlTypes.SqlMoney valorPrecio, DateTime fechaDesde )
        {

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO [Precios] ([codigoArti], [fechaDesde], [valorPrecio]) VALUES (@CODARTI, @FECHADESDE, @VALORPRECIO)";
            Comando.Parameters.Add(new SqlCeParameter("@CODARTI", SqlDbType.NVarChar));
            Comando.Parameters["@CODARTI"].Value = codArti;
            Comando.Parameters.Add(new SqlCeParameter("@FECHADESDE", SqlDbType.DateTime));
            Comando.Parameters["@FECHADESDE"].Value = fechaDesde;
            Comando.Parameters.Add(new SqlCeParameter("@VALORPRECIO", SqlDbType.Money));
            Comando.Parameters["@VALORPRECIO"].Value = valorPrecio;
       


            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        
        // El precio del articulo no debe estar en la tabla Articulos, 
        // sino que deberia existir el metodo GETPRECIO
        // el cual se compone de GetFechaUltimoPrecio + getUltimoPrecio (devolviendo este ultimo)

        public DateTime GetFechaUltimoPrecio(string codArti)
        {

            DateTime fechaMax;
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT MAX(fechaDesde) AS Fecha FROM Precios WHERE(codigoArti = @CODIGOARTI)", Con);
            Comando.Parameters.Add(new SqlCeParameter("@CODIGOARTI", SqlDbType.NVarChar));
            Comando.Parameters["@CODIGOARTI"].Value = codArti;
            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drPrecios = Comando.ExecuteReader();

                drPrecios.Read();
                
               fechaMax= (DateTime)drPrecios["Fecha"];

                drPrecios.Close();
                

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la fecha maxima", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return fechaMax;




        }

        public decimal GetUltimoPrecio(string codArti, DateTime fechaMax)
        {

            decimal ultimoPrecio;
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT valorPrecio FROM Precios WHERE (codigoArti = @CODIGOARTI) AND (fechaDesde = @FECHAMAX)", Con);
            Comando.Parameters.Add(new SqlCeParameter("@CODIGOARTI", SqlDbType.NVarChar));
            Comando.Parameters["@CODIGOARTI"].Value = codArti;
            Comando.Parameters.Add(new SqlCeParameter("@FECHAMAX", SqlDbType.DateTime));
            Comando.Parameters["@FECHAMAX"].Value = fechaMax;

            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drPrecios = Comando.ExecuteReader();

                drPrecios.Read();
                
               ultimoPrecio = (decimal)drPrecios["valorPrecio"];

                drPrecios.Close();
                

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el precio", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ultimoPrecio;




        }

    }
}
