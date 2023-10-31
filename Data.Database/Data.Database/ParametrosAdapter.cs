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
    public class ParametrosAdapter : Adapter
    {
        private static ParametrosAdapter instance;

        private ParametrosAdapter()
        {
            // Obtener los parámetros de la empresa de la base de datos
            parametrosEmpresa = obtenerParametrosEmpresa();
        }

        // Método estático público para obtener la única instancia de la clase
        public static ParametrosAdapter GetInstance()
        {
            // Verificar si la propiedad estática privada es nula
            if (instance == null)
            {
                // Crear una nueva instancia de la clase y asignarla a la propiedad estática privada
                instance = new ParametrosAdapter();
            }

            // Devolver la propiedad estática privada
            return instance;
        }


        public ParametrosEmpresa obtenerParametrosEmpresa()
        {
            ParametrosEmpresa lcl_parametrosEmpresa = null;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = CrearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT NOMBRE, DIRECCION, TELEFONO, IMAGENPATH, IMPRESORA1, CUIT, NOMBREFISCAL, DIRECCIONFISCAL, SITUACIONFISCAL, "
                + "CERTIFICADODIGITAL, CLAVECERTIFICADO, PUNTODEVENTA, INICIODEACTIVIDADES, INGRESOSBRUTOS, ESPRODUCCION, URLQRAFIP, "
                + "CAMPOPERSONALIZADOARTICULO1, CAMPOPERSONALIZADOARTICULO2, FAMILIANOMBRE1, FAMILIANOMBRE2, FONDOPANTALLA "
                + "FROM [PARAMETROS_EMPRESA] ";
            comando.Connection.Open();

            SqlDataReader drMedioPago = comando.ExecuteReader();

            while (drMedioPago.Read())
            {
                lcl_parametrosEmpresa = new ParametrosEmpresa();
                lcl_parametrosEmpresa.Nombre = (drMedioPago["NOMBRE"] != DBNull.Value) ? (string)drMedioPago["NOMBRE"] : null;
                lcl_parametrosEmpresa.Direccion = (drMedioPago["DIRECCION"] != DBNull.Value) ? (string)drMedioPago["DIRECCION"] : null;
                lcl_parametrosEmpresa.Telefono = (drMedioPago["TELEFONO"] != DBNull.Value) ? (string)drMedioPago["TELEFONO"] : null;
                lcl_parametrosEmpresa.ImagenPath = (drMedioPago["IMAGENPATH"] != DBNull.Value) ? (string)drMedioPago["IMAGENPATH"] : null;
                lcl_parametrosEmpresa.Impresora1 = (drMedioPago["IMPRESORA1"] != DBNull.Value) ? (string)drMedioPago["IMPRESORA1"] : null;
                lcl_parametrosEmpresa.CUIT = (drMedioPago["CUIT"] != DBNull.Value) ? (string)drMedioPago["CUIT"] : null;
                lcl_parametrosEmpresa.NombreFiscal = (drMedioPago["NOMBREFISCAL"] != DBNull.Value) ? (string)drMedioPago["NOMBREFISCAL"] : null;
                lcl_parametrosEmpresa.DireccionFiscal = (drMedioPago["DIRECCIONFISCAL"] != DBNull.Value) ? (string)drMedioPago["DIRECCIONFISCAL"] : null;
                lcl_parametrosEmpresa.SituacionFiscal = (drMedioPago["SITUACIONFISCAL"] != DBNull.Value) ? (string)drMedioPago["SITUACIONFISCAL"] : null;
                lcl_parametrosEmpresa.CertificadoDigital = (drMedioPago["CERTIFICADODIGITAL"] != DBNull.Value) ? (string)drMedioPago["CERTIFICADODIGITAL"] : null;
                lcl_parametrosEmpresa.ClaveCertificado = (drMedioPago["CLAVECERTIFICADO"] != DBNull.Value) ? (string)drMedioPago["CLAVECERTIFICADO"] : null;
                lcl_parametrosEmpresa.PuntoDeVenta = (drMedioPago["PUNTODEVENTA"] != DBNull.Value) ? (string)drMedioPago["PUNTODEVENTA"] : null;
                lcl_parametrosEmpresa.InicioDeActividades = (drMedioPago["INICIODEACTIVIDADES"] != DBNull.Value) ? (string)drMedioPago["INICIODEACTIVIDADES"] : null;
                lcl_parametrosEmpresa.IngresosBrutos = (drMedioPago["INGRESOSBRUTOS"] != DBNull.Value) ? (string)drMedioPago["INGRESOSBRUTOS"] : null;
                lcl_parametrosEmpresa.EsProduccion = (drMedioPago["ESPRODUCCION"] != DBNull.Value) ? (bool)drMedioPago["ESPRODUCCION"] : false;
                lcl_parametrosEmpresa.UrlQrAfip = (drMedioPago["URLQRAFIP"] != DBNull.Value) ? (string)drMedioPago["URLQRAFIP"] : null;
                lcl_parametrosEmpresa.CampoPersonalizadoArticulo1 = (drMedioPago["CAMPOPERSONALIZADOARTICULO1"] != DBNull.Value) ? (string)drMedioPago["CAMPOPERSONALIZADOARTICULO1"] : null;
                lcl_parametrosEmpresa.CampoPersonalizadoArticulo2 = (drMedioPago["CAMPOPERSONALIZADOARTICULO2"] != DBNull.Value) ? (string)drMedioPago["CAMPOPERSONALIZADOARTICULO2"] : null;
                lcl_parametrosEmpresa.FamiliaNombre1 = (drMedioPago["FAMILIANOMBRE1"] != DBNull.Value) ? (string)drMedioPago["FAMILIANOMBRE1"] : null;
                lcl_parametrosEmpresa.FamiliaNombre2 = (drMedioPago["FAMILIANOMBRE2"] != DBNull.Value) ? (string)drMedioPago["FAMILIANOMBRE2"] : null;
                lcl_parametrosEmpresa.FondoPantalla = (drMedioPago["FONDOPANTALLA"] != DBNull.Value) ? (string)drMedioPago["FONDOPANTALLA"] : null;

            }
            drMedioPago.Close();
            comando.Connection.Close();

            return lcl_parametrosEmpresa;
        }


        public ParametrosEmpresa parametrosEmpresa { get; set; }

        public void Actualizar(ParametrosEmpresa _parametrosEmpresa)
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;


            Comando.CommandText = "UPDATE [PARAMETROS_EMPRESA] SET NOMBRE=@NOMBRE, DIRECCION=@DIRECCION, TELEFONO=@TELEFONO, IMAGENPATH=@IMAGENPATH, "
                +"IMPRESORA1=@IMPRESORA1, CUIT=@CUIT, NOMBREFISCAL=@NOMBREFISCAL, DIRECCIONFISCAL=@DIRECCIONFISCAL, SITUACIONFISCAL=@SITUACIONFISCAL, "
                +"CERTIFICADODIGITAL=@CERTIFICADODIGITAL, CLAVECERTIFICADO=@CLAVECERTIFICADO, PUNTODEVENTA=@PUNTODEVENTA, INICIODEACTIVIDADES=@INICIODEACTIVIDADES, "
                +"INGRESOSBRUTOS=@INGRESOSBRUTOS, ESPRODUCCION=@ESPRODUCCION, URLQRAFIP=@URLQRAFIP, "
                +"CampoPersonalizadoArticulo1=@CAMPO_PERSONALIZADO_ARTICULO1, CampoPersonalizadoArticulo2=@CAMPO_PERSONALIZADO_ARTICULO2, FamiliaNombre1=@FAMILIANOMBRE1, FamiliaNombre2=@FAMILIANOMBRE2, FONDOPANTALLA=@FONDOPANTALLA";
            Comando.Parameters.Add(new SqlParameter("@NOMBRE", SqlDbType.NVarChar));
            Comando.Parameters["@NOMBRE"].Value = _parametrosEmpresa.Nombre ?? String.Empty;
            Comando.Parameters.Add(new SqlParameter("@DIRECCION", SqlDbType.NVarChar));
            Comando.Parameters["@DIRECCION"].Value = _parametrosEmpresa.Direccion ?? string.Empty;
            Comando.Parameters.Add(new SqlParameter("@TELEFONO", SqlDbType.NVarChar));
            Comando.Parameters["@TELEFONO"].Value = _parametrosEmpresa.Telefono ?? string.Empty;
            Comando.Parameters.Add(new SqlParameter("@IMAGENPATH", SqlDbType.NVarChar));
            Comando.Parameters["@IMAGENPATH"].Value = _parametrosEmpresa.ImagenPath ?? string.Empty;
            Comando.Parameters.Add(new SqlParameter("@FONDOPANTALLA", SqlDbType.NVarChar));
            Comando.Parameters["@FONDOPANTALLA"].Value = _parametrosEmpresa.FondoPantalla ?? string.Empty;
            Comando.Parameters.Add(new SqlParameter("@IMPRESORA1", SqlDbType.NVarChar));
            Comando.Parameters["@IMPRESORA1"].Value = _parametrosEmpresa.Impresora1 ?? string.Empty;
            //FISCAL
            Comando.Parameters.Add(new SqlParameter("@CUIT", SqlDbType.NVarChar));
            Comando.Parameters["@CUIT"].Value = _parametrosEmpresa.CUIT ?? string.Empty;
            Comando.Parameters.Add(new SqlParameter("@NOMBREFISCAL", SqlDbType.NVarChar));
            Comando.Parameters["@NOMBREFISCAL"].Value = _parametrosEmpresa.NombreFiscal ?? string.Empty;
            Comando.Parameters.Add(new SqlParameter("@DIRECCIONFISCAL", SqlDbType.NVarChar));
            Comando.Parameters["@DIRECCIONFISCAL"].Value = _parametrosEmpresa.DireccionFiscal ?? string.Empty;
            Comando.Parameters.Add(new SqlParameter("@SITUACIONFISCAL", SqlDbType.NVarChar));
            Comando.Parameters["@SITUACIONFISCAL"].Value = _parametrosEmpresa.SituacionFiscal ?? string.Empty;
            Comando.Parameters.Add(new SqlParameter("@CERTIFICADODIGITAL", SqlDbType.NVarChar));
            Comando.Parameters["@CERTIFICADODIGITAL"].Value = _parametrosEmpresa.CertificadoDigital ?? string.Empty;
            Comando.Parameters.Add(new SqlParameter("@CLAVECERTIFICADO", SqlDbType.NVarChar));
            Comando.Parameters["@CLAVECERTIFICADO"].Value = _parametrosEmpresa.ClaveCertificado ?? string.Empty;
            Comando.Parameters.Add(new SqlParameter("@PUNTODEVENTA", SqlDbType.NVarChar));
            Comando.Parameters["@PUNTODEVENTA"].Value = _parametrosEmpresa.PuntoDeVenta ?? string.Empty;
            Comando.Parameters.Add(new SqlParameter("@INICIODEACTIVIDADES", SqlDbType.NVarChar));
            Comando.Parameters["@INICIODEACTIVIDADES"].Value = _parametrosEmpresa.InicioDeActividades ?? string.Empty;
            Comando.Parameters.Add(new SqlParameter("@INGRESOSBRUTOS", SqlDbType.NVarChar));
            Comando.Parameters["@INGRESOSBRUTOS"].Value = _parametrosEmpresa.IngresosBrutos ?? string.Empty;
            Comando.Parameters.Add(new SqlParameter("@ESPRODUCCION", SqlDbType.Bit));
            Comando.Parameters["@ESPRODUCCION"].Value = _parametrosEmpresa.EsProduccion;
            Comando.Parameters.Add(new SqlParameter("@URLQRAFIP", SqlDbType.NVarChar));
            Comando.Parameters["@URLQRAFIP"].Value = _parametrosEmpresa.UrlQrAfip ?? string.Empty;
            //CAMPOS PERSONALIZADOS ARTICULO
            Comando.Parameters.Add(new SqlParameter("@CAMPO_PERSONALIZADO_ARTICULO1", SqlDbType.NVarChar));
            Comando.Parameters["@CAMPO_PERSONALIZADO_ARTICULO1"].Value = _parametrosEmpresa.CampoPersonalizadoArticulo1 ?? string.Empty;
            Comando.Parameters.Add(new SqlParameter("@CAMPO_PERSONALIZADO_ARTICULO2", SqlDbType.NVarChar));
            Comando.Parameters["@CAMPO_PERSONALIZADO_ARTICULO2"].Value = _parametrosEmpresa.CampoPersonalizadoArticulo2 ?? string.Empty;
            //FAMILIAS ARTICULOS
            Comando.Parameters.Add(new SqlParameter("@FAMILIANOMBRE1", SqlDbType.NVarChar));
            Comando.Parameters["@FAMILIANOMBRE1"].Value = _parametrosEmpresa.FamiliaNombre1 ?? string.Empty;
            Comando.Parameters.Add(new SqlParameter("@FAMILIANOMBRE2", SqlDbType.NVarChar));
            Comando.Parameters["@FAMILIANOMBRE2"].Value = _parametrosEmpresa.FamiliaNombre2 ?? string.Empty;


            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();

        }
       
    }
}
