using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace Data.Database
{
    public class FacturaElectronicaAdapter : Adapter
    {
        public void RegistroFacturaElectronica(FacturaElectronica FacturaElectronica)
        {

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO [Ventas] ([VENTA_ID],[REQUEST],[REQUEST_DETALLE],[RESPONSE],[OBSERVACIONES],[RESULTADO]) VALUES (@VENTA_ID,@REQUEST,@REQUEST_DETALLE,@RESPONSE,@OBSERVACIONES,@RESULTADO)";
            Comando.Parameters.Add(new SqlParameter("@VENTA_ID", SqlDbType.Int));
            Comando.Parameters["@VENTA_ID"].Value = FacturaElectronica.IdVenta;
            Comando.Parameters.Add(new SqlParameter("@REQUEST", SqlDbType.NVarChar));
            Comando.Parameters["@REQUEST"].Value = FacturaElectronica.Request;
            Comando.Parameters.Add(new SqlParameter("@REQUEST_DETALLE", SqlDbType.NVarChar));
            Comando.Parameters["@REQUEST_DET"].Value = FacturaElectronica.RequestDetalle;
            Comando.Parameters.Add(new SqlParameter("@RESPONSE", SqlDbType.NVarChar));
            Comando.Parameters["@RESPONSE"].Value = FacturaElectronica.Response;
            Comando.Parameters.Add(new SqlParameter("@OBSERVACIONES", SqlDbType.NVarChar));
            Comando.Parameters["@OBSERVACIONES"].Value = FacturaElectronica.Observaciones;
            Comando.Parameters.Add(new SqlParameter("@RESULTADO", SqlDbType.NVarChar));
            Comando.Parameters["@RESULTADO"].Value = FacturaElectronica.Resultado;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();


        }

        public List<FacturaElectronica> GetAll()
        {
            List<FacturaElectronica> ListaFacturaElectronica = new List<FacturaElectronica>();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM FacturaElectronica ORDER BY ID DESC", Con);
            try
            {
                Comando.Connection.Open();
                SqlDataReader drFacturaElectronica = Comando.ExecuteReader();

                while (drFacturaElectronica.Read())
                {
                    FacturaElectronica FE = new FacturaElectronica();
                    FE.id = (int)drFacturaElectronica["ID"];
                    FE.IdVenta = (long)drFacturaElectronica["VENTA_ID"];
                    FE.Request = (string)drFacturaElectronica["REQUEST"];
                    FE.RequestDetalle = (string)drFacturaElectronica["REQUEST_DETALLE"];
                    FE.Response= (string)drFacturaElectronica["RESPONSE"];
                    FE.Observaciones = (string)drFacturaElectronica["OBSERVACIONES"];
                    FE.Resultado = (string)drFacturaElectronica["RESULTADO"];


                    ListaFacturaElectronica.Add(FE);
                }
                drFacturaElectronica.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de envios de Factura Electronica", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ListaFacturaElectronica;




        }

        public FacturaElectronica GetOne(int id)
        {
            FacturaElectronica ClienteActual = new FacturaElectronica();

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM FacturaElectronica WHERE ID = @ID", Con);
            Comando.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int));
            Comando.Parameters["@ID"].Value = id;

            try
            {
                Comando.Connection.Open();
                SqlDataReader drFacturaElectronica = Comando.ExecuteReader();

                while (drFacturaElectronica.Read())
                {


                    FacturaElectronica FE = new FacturaElectronica();
                    FE.id = (int)drFacturaElectronica["ID"];
                    FE.IdVenta = (long)drFacturaElectronica["VENTA_ID"];
                    FE.Request = (string)drFacturaElectronica["REQUEST"];
                    FE.RequestDetalle = (string)drFacturaElectronica["REQUEST_DETALLE"];
                    FE.Response = (string)drFacturaElectronica["RESPONSE"];
                    FE.Observaciones = (string)drFacturaElectronica["OBSERVACIONES"];
                    FE.Resultado = (string)drFacturaElectronica["RESULTADO"];


                }
                drFacturaElectronica.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Registros de Factura Electronica", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ClienteActual;




        }
        public FacturaElectronica GetOnePorVenta(int id)
        {
            FacturaElectronica ClienteActual = new FacturaElectronica();

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT TOP 1 * FROM FacturaElectronica WHERE VENTA_ID = @VENTA_ID", Con);
            Comando.Parameters.Add(new SqlParameter("@VENTA_ID", SqlDbType.Int));
            Comando.Parameters["@VENTA_ID"].Value = id;

            try
            {
                Comando.Connection.Open();
                SqlDataReader drFacturaElectronica = Comando.ExecuteReader();

                while (drFacturaElectronica.Read())
                {


                    FacturaElectronica FE = new FacturaElectronica();
                    FE.id = (int)drFacturaElectronica["ID"];
                    FE.IdVenta = (long)drFacturaElectronica["VENTA_ID"];
                    FE.Request = (string)drFacturaElectronica["REQUEST"];
                    FE.RequestDetalle = (string)drFacturaElectronica["REQUEST_DETALLE"];
                    FE.Response = (string)drFacturaElectronica["RESPONSE"];
                    FE.Observaciones = (string)drFacturaElectronica["OBSERVACIONES"];
                    FE.Resultado = (string)drFacturaElectronica["RESULTADO"];


                }
                drFacturaElectronica.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Registros de Factura Electronica", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ClienteActual;




        }

    }
}
