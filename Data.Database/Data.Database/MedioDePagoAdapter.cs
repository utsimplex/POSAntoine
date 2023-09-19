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
    public class MedioDePagoAdapter : Adapter
    {


        public MedioDePago medioDePago { get; set; }

        public void AñadirNuevo(MedioDePago _medioDePago)
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;
            try
            {

                Comando.CommandText = "INSERT INTO [MEDIO_PAGO](DESCRIPCION,ACTIVO,ESDEFAULT ) " +
                "VALUES (@DESCRIPCION,@ACTIVO,@ESDEFAULT) ";
                Comando.Parameters.Add(new SqlParameter("@DESCRIPCION", SqlDbType.NVarChar));
                Comando.Parameters["@CODIGO"].Value = _medioDePago.Descripcion;
                Comando.Parameters.Add(new SqlParameter("@ESDEFAULT", SqlDbType.Bit));
                Comando.Parameters["@ESDEFAULT"].Value = _medioDePago.Default;
                Comando.Parameters.Add(new SqlParameter("@ACTIVO", SqlDbType.Bit));
                Comando.Parameters["@ACTIVO"].Value = _medioDePago.Activo;

                //Ejecuta el comando INSERT
                Comando.Connection.Open();
                Comando.ExecuteNonQuery();
                Comando.Connection.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al añadir artículo", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }
        }


        public void Actualizar(MedioDePago _medioDePago)
        {
            if (_medioDePago.Default)
            {
                this.ActualizarNoDefault();
            }
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE [MEDIO_PAGO] SET DESCRIPCION=@DESCRIPCION,ACTIVO=@ACTIVO, ESDEFAULT=@ESDEFAULT" +
                    " WHERE ID=@ID";
            Comando.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int));
            Comando.Parameters["@ID"].Value = _medioDePago.id;
            Comando.Parameters.Add(new SqlParameter("@DESCRIPCION", SqlDbType.NVarChar));
            Comando.Parameters["@CODIGO"].Value = _medioDePago.Descripcion;
            Comando.Parameters.Add(new SqlParameter("@ESDEFAULT", SqlDbType.Bit));
            Comando.Parameters["@ESDEFAULT"].Value = _medioDePago.Default;
            Comando.Parameters.Add(new SqlParameter("@ACTIVO", SqlDbType.Bit));
            Comando.Parameters["@ACTIVO"].Value = _medioDePago.Activo;


            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();

        }
        public void ActualizarNoDefault()
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE [MEDIO_PAGO] SET ESDEFAULT=0" +
                    " WHERE ESDEFAULT=1";

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();

        }

        public System.ComponentModel.BindingList<MedioDePago> GetMultipleActivo(string p_Descripcion)
        {
            //Creo la conexion y la abro
            SqlConnection Con = CrearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = Con;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT ID, DESCRIPCION, ACTIVO,ESDEFAULT " +
                    " FROM MEDIO_PAGO " +
                    " WHERE DESCRIPCION LIKE @DESCRIPCION AND ACTIVO=1";

            comando.Parameters.Add(new SqlParameter("@DESCRIPCION", SqlDbType.VarChar));
            comando.Parameters["@DESCRIPCION"].Value = p_Descripcion == null ? "%" : p_Descripcion + "%";
            comando.Connection.Open();

            SqlDataReader drMedioPago = comando.ExecuteReader();

            BindingList<MedioDePago> lst_MedioPagos = new BindingList<MedioDePago>();
            MedioDePago lcl_MedioPago = null;

            while (drMedioPago.Read())
            {
                lcl_MedioPago = new MedioDePago();
                lcl_MedioPago.id = (int)drMedioPago["ID"];
                //Si algún valor esta null en Base de datos, se asigna null en el objeto
                //Caso contrario hay una string, y se asigna string
                lcl_MedioPago.Descripcion = (drMedioPago["DESCRIPCION"] != DBNull.Value) ? (string)drMedioPago["DESCRIPCION"] : null;
                lcl_MedioPago.Activo = (drMedioPago["ACTIVO"] != DBNull.Value) ? (bool)(drMedioPago["ACTIVO"]) : false; ;
                lcl_MedioPago.Default = (drMedioPago["ESDEFAULT"] != DBNull.Value) ? (bool)(drMedioPago["ESDEFAULT"]) : false;


                lst_MedioPagos.Add(lcl_MedioPago);
            }
            drMedioPago.Close();
            comando.Connection.Dispose();

            return lst_MedioPagos;
        }
        public MedioDePago getOne(int p_idMedioPago)
        {
            MedioDePago lcl_MedioPago = null;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = CrearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT ID, DESCRIPCION, ACTIVO,ESDEFAULT " +
                    " FROM MEDIO_PAGO " +
                    " WHERE ID = @ID";
            comando.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int));
            comando.Parameters["@ID"].Value = p_idMedioPago;
            comando.Connection.Open();

            SqlDataReader drMedioPago = comando.ExecuteReader();

            while (drMedioPago.Read())
            {
                lcl_MedioPago = new MedioDePago();
                lcl_MedioPago.id = (int)drMedioPago["ID"];
                //Si algún valor esta null en Base de datos, se asigna null en el objeto
                //Caso contrario hay una string, y se asigna string
                lcl_MedioPago.Descripcion = (drMedioPago["DESCRIPCION"] != DBNull.Value) ? (string)drMedioPago["DESCRIPCION"] : null;
                lcl_MedioPago.Activo = (drMedioPago["ACTIVO"] != DBNull.Value) ? (bool)(drMedioPago["ACTIVO"]) : false; ;
                lcl_MedioPago.Default = (drMedioPago["ESDEFAULT"] != DBNull.Value) ? (bool)(drMedioPago["ESDEFAULT"]) : false;
            }
            drMedioPago.Close();
            comando.Connection.Close();

            return lcl_MedioPago;
        }

    }
}
