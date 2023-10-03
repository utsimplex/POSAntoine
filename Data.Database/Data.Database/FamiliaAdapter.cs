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
    public class FamiliaAdapter : Adapter
    {
        private static FamiliaAdapter instance;

        // Método estático público para obtener la única instancia de la clase
        public static FamiliaAdapter GetInstance()
        {
            // Verificar si la propiedad estática privada es nula
            if (instance == null)
            {
                // Crear una nueva instancia de la clase y asignarla a la propiedad estática privada
                instance = new FamiliaAdapter();
            }

            // Devolver la propiedad estática privada
            return instance;
        }

        public Familia familia { get; set; }

        public void AñadirNuevaFamilia(Familia _familia, string pFamiliaSeleccionada)
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;
            try
            {
                if (pFamiliaSeleccionada == "Familia1")
                {
                    Comando.CommandText = "INSERT INTO [Familia](DESCRIPCION,ACTIVO ) " +
               "VALUES (@DESCRIPCION,@ACTIVO) ";
                }
                else if (pFamiliaSeleccionada == "Familia2")
                {
                    Comando.CommandText = "INSERT INTO [Familia_DOS](DESCRIPCION,ACTIVO ) " +
               "VALUES (@DESCRIPCION,@ACTIVO) ";
                }

               
                Comando.Parameters.Add(new SqlParameter("@DESCRIPCION", SqlDbType.NVarChar));
                Comando.Parameters["@DESCRIPCION"].Value = _familia.Descripcion;
                Comando.Parameters.Add(new SqlParameter("@ACTIVO", SqlDbType.Bit));
                Comando.Parameters["@ACTIVO"].Value = _familia.Activo;

                //Ejecuta el comando INSERT
                Comando.Connection.Open();
                Comando.ExecuteNonQuery();
                Comando.Connection.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al añadir Familia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }
        }

        public void ActualizarFamilia(Familia _familia, string pFamiliaSeleccionada)
        {
            
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            if (pFamiliaSeleccionada == "Familia1")
            {
                Comando.CommandText = "UPDATE [FAMILIA] SET DESCRIPCION=@DESCRIPCION,ACTIVO=@ACTIVO" +
                    " WHERE ID=@ID";
            }
            else if (pFamiliaSeleccionada == "Familia2")
            {
                Comando.CommandText = "UPDATE [FAMILIA_DOS] SET DESCRIPCION=@DESCRIPCION,ACTIVO=@ACTIVO" +
                    " WHERE ID=@ID";
            }
            
            Comando.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int));
            Comando.Parameters["@ID"].Value = _familia.id;
            Comando.Parameters.Add(new SqlParameter("@DESCRIPCION", SqlDbType.NVarChar));
            Comando.Parameters["@DESCRIPCION"].Value = _familia.Descripcion;
            Comando.Parameters.Add(new SqlParameter("@ACTIVO", SqlDbType.Bit));
            Comando.Parameters["@ACTIVO"].Value = _familia.Activo;


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

            Comando.CommandText = "UPDATE [FAMILIA] SET ESDEFAULT=0" +
                    " WHERE ESDEFAULT=1";

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();

        }

        public System.ComponentModel.BindingList<Familia> GetMultipleActivo(string p_Descripcion)
        {
            //Creo la conexion y la abro
            SqlConnection Con = CrearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = Con;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT ID, DESCRIPCION, ACTIVO " +
                    " FROM FAMILIA " +
                    " WHERE DESCRIPCION LIKE @DESCRIPCION AND ACTIVO=1";

            comando.Parameters.Add(new SqlParameter("@DESCRIPCION", SqlDbType.VarChar));
            comando.Parameters["@DESCRIPCION"].Value = p_Descripcion == null ? "%" : p_Descripcion + "%";
            comando.Connection.Open();

            SqlDataReader drMedioPago = comando.ExecuteReader();

            BindingList<Familia> lst_MedioPagos = new BindingList<Familia>();
            Familia lcl_MedioPago = null;

            while (drMedioPago.Read())
            {
                lcl_MedioPago = new Familia();
                lcl_MedioPago.id = (int)drMedioPago["ID"];
                //Si algún valor esta null en Base de datos, se asigna null en el objeto
                //Caso contrario hay una string, y se asigna string
                lcl_MedioPago.Descripcion = (drMedioPago["DESCRIPCION"] != DBNull.Value) ? (string)drMedioPago["DESCRIPCION"] : null;
                lcl_MedioPago.Activo = (drMedioPago["ACTIVO"] != DBNull.Value) ? (bool)(drMedioPago["ACTIVO"]) : false; ;


                lst_MedioPagos.Add(lcl_MedioPago);
            }
            drMedioPago.Close();
            comando.Connection.Dispose();

            return lst_MedioPagos;
        }


        public System.ComponentModel.BindingList<Familia> GetFamilias(string pFamiliaSeleccionada, string p_Descripcion)
        {
            //Creo la conexion y la abro
            SqlConnection Con = CrearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = Con;
            comando.CommandType = CommandType.Text;
            if(pFamiliaSeleccionada == "Familia1")
            {
            comando.CommandText =
                "SELECT ID, DESCRIPCION, ACTIVO " +
                    " FROM FAMILIA " +
                    " WHERE DESCRIPCION LIKE @DESCRIPCION";
            }else if(pFamiliaSeleccionada == "Familia2")
            {
                comando.CommandText =
                "SELECT ID, DESCRIPCION, ACTIVO " +
                    " FROM FAMILIA_DOS " +
                    " WHERE DESCRIPCION LIKE @DESCRIPCION";
            }

            comando.Parameters.Add(new SqlParameter("@DESCRIPCION", SqlDbType.VarChar));
            comando.Parameters["@DESCRIPCION"].Value = p_Descripcion == null ? "%" : p_Descripcion + "%";
            comando.Connection.Open();

            SqlDataReader drFamilia = comando.ExecuteReader();

            BindingList<Familia> lst_Familias = new BindingList<Familia>();
            Familia lcl_Familia = null;

            while (drFamilia.Read())
            {
                lcl_Familia = new Familia();
                lcl_Familia.id = (int)drFamilia["ID"];
                //Si algún valor esta null en Base de datos, se asigna null en el objeto
                //Caso contrario hay una string, y se asigna string
                lcl_Familia.Descripcion = (drFamilia["DESCRIPCION"] != DBNull.Value) ? (string)drFamilia["DESCRIPCION"] : null;
                lcl_Familia.Activo = (drFamilia["ACTIVO"] != DBNull.Value) ? (bool)(drFamilia["ACTIVO"]) : false; ;


                lst_Familias.Add(lcl_Familia);
            }
            drFamilia.Close();
            comando.Connection.Dispose();

            return lst_Familias;
        }



        public Familia getOne(int p_idMedioPago)
        {
            Familia lcl_MedioPago = null;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = CrearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT ID, DESCRIPCION, ACTIVO " +
                    " FROM FAMILIA " +
                    " WHERE ID = @ID";
            comando.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int));
            comando.Parameters["@ID"].Value = p_idMedioPago;
            comando.Connection.Open();

            SqlDataReader drMedioPago = comando.ExecuteReader();

            while (drMedioPago.Read())
            {
                lcl_MedioPago = new Familia();
                lcl_MedioPago.id = (int)drMedioPago["ID"];
                //Si algún valor esta null en Base de datos, se asigna null en el objeto
                //Caso contrario hay una string, y se asigna string
                lcl_MedioPago.Descripcion = (drMedioPago["DESCRIPCION"] != DBNull.Value) ? (string)drMedioPago["DESCRIPCION"] : null;
                lcl_MedioPago.Activo = (drMedioPago["ACTIVO"] != DBNull.Value) ? (bool)(drMedioPago["ACTIVO"]) : false; ;
            }
            drMedioPago.Close();
            comando.Connection.Close();

            return lcl_MedioPago;
        }
        
        public AutoCompleteStringCollection GetListadoFamilias()
        {

            AutoCompleteStringCollection provs = new AutoCompleteStringCollection();

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT nombre FROM Familia", Con);

            try
            {
                Comando.Connection.Open();
                SqlDataReader drProveedores = Comando.ExecuteReader();

                while (drProveedores.Read())
                {
                    Entidades.Familia familia = new Entidades.Familia();

                    familia.Descripcion = (string)drProveedores["descripcion"];

                    provs.Add(familia.Descripcion);

                }
                drProveedores.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de usuarios", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }


            return provs;

        }

    }
}
