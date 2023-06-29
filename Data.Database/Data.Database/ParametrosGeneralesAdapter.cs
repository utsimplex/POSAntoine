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
    public class ParametrosGeneralesAdapter : Adapter
    {


        public ParametrosEmpresa parametrosEmpresa { get; set; }

        //public void AñadirNuevo(MedioDePago _medioDePago)
        //{
        //    //Crear Conexion y Abrirla
        //    SqlConnection Con = CrearConexion();

        //    // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
        //    SqlCommand Comando = new SqlCommand();
        //    Comando.Connection = Con;
        //    Comando.CommandType = CommandType.Text;
        //    try
        //    {

        //        Comando.CommandText = "INSERT INTO [MEDIO_PAGO](DESCRIPCION,ACTIVO,ESDEFAULT ) " +
        //        "VALUES (@DESCRIPCION,@ACTIVO,@ESDEFAULT) ";
        //        Comando.Parameters.Add(new SqlParameter("@DESCRIPCION", SqlDbType.NVarChar));
        //        Comando.Parameters["@CODIGO"].Value = _medioDePago.Descripcion;
        //        Comando.Parameters.Add(new SqlParameter("@ESDEFAULT", SqlDbType.Bit));
        //        Comando.Parameters["@ESDEFAULT"].Value = _medioDePago.Default;
        //        Comando.Parameters.Add(new SqlParameter("@ACTIVO", SqlDbType.Bit));
        //        Comando.Parameters["@ACTIVO"].Value = _medioDePago.Activo;

        //        //Ejecuta el comando INSERT
        //        Comando.Connection.Open();
        //        Comando.ExecuteNonQuery();
        //        Comando.Connection.Close();
        //    }
        //    catch (Exception Ex)
        //    {
        //        Exception ExcepcionManejada = new Exception("Error al añadir artículo", Ex);
        //        throw ExcepcionManejada;
        //    }
        //    finally
        //    {
        //        Comando.Connection.Close();
        //    }
        //}


        public void Actualizar(ParametrosEmpresa _parametrosEmpresa)
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE [PARAMETROS_EMPRESA] SET NOMBRE_EMPRESA=@NOMBRE,DIRECCION=@DIRECCION, TELEFONO=@TELEFONO";
            Comando.Parameters.Add(new SqlParameter("@NOMBRE", SqlDbType.NVarChar));
            Comando.Parameters["@NOMBRE"].Value = _parametrosEmpresa.Nombre;
            Comando.Parameters.Add(new SqlParameter("@DIRECCION", SqlDbType.NVarChar));
            Comando.Parameters["@DIRECCION"].Value = _parametrosEmpresa.Direccion;
            Comando.Parameters.Add(new SqlParameter("@TELEFONO", SqlDbType.NVarChar));
            Comando.Parameters["@TELEFONO"].Value = _parametrosEmpresa.Telefono;


            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();

        }
        public ParametrosEmpresa getOne()
        {
            ParametrosEmpresa lcl_parametrosEmpresa = null;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = CrearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT NOMBRE_EMPRESA, TELEFONO, DIRECCION " +
                    " FROM PARAMETROS_EMPRESA ";
            comando.Connection.Open();

            SqlDataReader drMedioPago = comando.ExecuteReader();

            while (drMedioPago.Read())
            {
                lcl_parametrosEmpresa = new ParametrosEmpresa();
                lcl_parametrosEmpresa.Nombre = (drMedioPago["NOMBRE_EMPRESA"] != DBNull.Value) ? (string)drMedioPago["NOMBRE_EMPRESA"] : null;
                lcl_parametrosEmpresa.Telefono = (drMedioPago["TELEFONO"] != DBNull.Value) ? (string)drMedioPago["TELEFONO"] : null;
                lcl_parametrosEmpresa.Direccion = (drMedioPago["DIRECCION"] != DBNull.Value) ? (string)drMedioPago["DIRECCION"] : null;
            }
            drMedioPago.Close();
            comando.Connection.Close();

            return lcl_parametrosEmpresa;
        }

    }
}
