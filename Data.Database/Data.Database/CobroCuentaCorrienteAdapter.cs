using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.ComponentModel;
using Microsoft.Office.Interop.Excel;

namespace Data.Database
{
    public class CobroCuentaCorrienteAdapter : Adapter
    {


        public CobroCuentaCorriente CobroCuentaCorriente { get; set; }

        public void AñadirNuevo(CobroCuentaCorriente _CobroCuentaCorriente)
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;
            try
            {

                Comando.CommandText = "INSERT INTO [CobrosCuentaCorriente] (NumeroDocumentoCliente, FacturasAfectadas, FechaHora, MedioDePago, MontoRecibido) " +
                            "VALUES (@NumeroDocumentoCliente, @FacturasAfectadas, @FechaHora, @MedioDePago, @MontoRecibido)";
                Comando.Parameters.Add(new SqlParameter("@NumeroDocumentoCliente", SqlDbType.NVarChar));
                Comando.Parameters["@NumeroDocumentoCliente"].Value = _CobroCuentaCorriente.NumeroDocumentoCliente;
                Comando.Parameters.Add(new SqlParameter("@FacturasAfectadas", SqlDbType.NVarChar));
                Comando.Parameters["@FacturasAfectadas"].Value = _CobroCuentaCorriente.FacturasAfectadas;
                Comando.Parameters.Add(new SqlParameter("@FechaHora", SqlDbType.DateTime));
                Comando.Parameters["@FechaHora"].Value = _CobroCuentaCorriente.FechaHora;
                Comando.Parameters.Add(new SqlParameter("@MedioDePago", SqlDbType.NVarChar));
                Comando.Parameters["@MedioDePago"].Value = _CobroCuentaCorriente.MedioDePago;
                Comando.Parameters.Add(new SqlParameter("@MontoRecibido", SqlDbType.Decimal));
                Comando.Parameters["@MontoRecibido"].Value = _CobroCuentaCorriente.MontoRecibido;

                //Ejecuta el comando INSERT
                Comando.Connection.Open();
                Comando.ExecuteNonQuery();
                Comando.Connection.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al añadir CobroCuentaCorriente", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }
        }

        public List<CobroCuentaCorriente> GetMultipleCliente(string p_NumeroDocumentoCliente)
        {
            //Creo la conexion y la abro
            SqlConnection Con = CrearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = Con;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT id, NumeroDocumentoCliente, FacturasAfectadas, FechaHora, MedioDePago, MontoRecibido FROM CobrosCuentaCorriente WHERE NumeroDocumentoCliente=@NumeroDocumentoCliente";

            comando.Parameters.Add(new SqlParameter("@NumeroDocumentoCliente", SqlDbType.VarChar));
            comando.Parameters["@NumeroDocumentoCliente"].Value = p_NumeroDocumentoCliente == null ? "%" : p_NumeroDocumentoCliente;
            comando.Connection.Open();

            SqlDataReader drCobroCtaCte = comando.ExecuteReader();

            List<CobroCuentaCorriente> lst_Cobros = new List<CobroCuentaCorriente>();
            CobroCuentaCorriente lcl_CobrosCtasCtes = null;

            while (drCobroCtaCte.Read())
            {
                lcl_CobrosCtasCtes = new CobroCuentaCorriente();
                lcl_CobrosCtasCtes.id = (int)drCobroCtaCte["id"];
                lcl_CobrosCtasCtes.NumeroDocumentoCliente = (string)drCobroCtaCte["NumeroDocumentoCliente"];
                lcl_CobrosCtasCtes.FacturasAfectadas = (string)drCobroCtaCte["FacturasAfectadas"];
                lcl_CobrosCtasCtes.FechaHora = (DateTime)drCobroCtaCte["FechaHora"];
                lcl_CobrosCtasCtes.MedioDePago = (string)drCobroCtaCte["MedioDePago"];
                lcl_CobrosCtasCtes.MontoRecibido = (decimal)drCobroCtaCte["MontoRecibido"];

                lst_Cobros.Add(lcl_CobrosCtasCtes);
            }
            drCobroCtaCte.Close();
            comando.Connection.Dispose();

            return lst_Cobros;
        }
    }
}
