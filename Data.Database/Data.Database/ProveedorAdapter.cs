using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ProveedorAdapter: Adapter
    {
        public void AñadirNuevo(Entidades.Proveedor prov)
        {

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO [Proveedores] ([dni], [nombre], [telefono], [email], [direccion]) VALUES (@DNI, @NOMBRE, @TELEFONO, @EMAIL, @DIRECCION)";
            Comando.Parameters.Add(new SqlParameter("@DNI", SqlDbType.NVarChar));
            Comando.Parameters["@DNI"].Value = prov.Dni;
            Comando.Parameters.Add(new SqlParameter("@NOMBRE", SqlDbType.NVarChar));
            Comando.Parameters["@NOMBRE"].Value = prov.Nombre;
            Comando.Parameters.Add(new SqlParameter("@TELEFONO", SqlDbType.NVarChar));
            Comando.Parameters["@TELEFONO"].Value = prov.Telefono;
            Comando.Parameters.Add(new SqlParameter("@EMAIL", SqlDbType.NVarChar));
            Comando.Parameters["@EMAIL"].Value = prov.Email;
            Comando.Parameters.Add(new SqlParameter("@DIRECCION", SqlDbType.NVarChar));
            Comando.Parameters["@DIRECCION"].Value = prov.Direccion;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();


        }

        public void Quitar(string nombreProv)
        {

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "DELETE FROM [Proveedores] WHERE (([nombre] = @NOMBRE))";
            Comando.Parameters.Add(new SqlParameter("@NOMBRE", SqlDbType.NVarChar));
            Comando.Parameters["@NOMBRE"].Value = nombreProv;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public void Actualizar(Entidades.Proveedor prov)
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE [Proveedores] SET [dni]=@DNI, [direccion] = @DIRECCION, [telefono] = @TELEFONO, [email] = @EMAIL WHERE (([nombre] = @NOMBRE))";
            Comando.Parameters.Add(new SqlParameter("@DNI", SqlDbType.NVarChar));
            Comando.Parameters["@DNI"].Value = prov.Dni;
            Comando.Parameters.Add(new SqlParameter("@NOMBRE", SqlDbType.NVarChar));
            Comando.Parameters["@NOMBRE"].Value = prov.Nombre;
            Comando.Parameters.Add(new SqlParameter("@TELEFONO", SqlDbType.NVarChar));
            Comando.Parameters["@TELEFONO"].Value = prov.Telefono;
            Comando.Parameters.Add(new SqlParameter("@EMAIL", SqlDbType.NVarChar));
            Comando.Parameters["@EMAIL"].Value = prov.Email;
            Comando.Parameters.Add(new SqlParameter("@DIRECCION", SqlDbType.NVarChar));
            Comando.Parameters["@DIRECCION"].Value = prov.Direccion == null ? "NO REGISTRADO" : prov.Direccion;


            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public List<Entidades.Proveedor> GetAll()
        {
            List<Entidades.Proveedor> ListaProveedores = new List<Entidades.Proveedor>();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM Proveedores", Con);
            try
            {      
                Comando.Connection.Open();
                SqlDataReader drProveedores = Comando.ExecuteReader();

                while (drProveedores.Read())
                {
                    Entidades.Proveedor prov = new Entidades.Proveedor();

                    prov.Nombre = (string)drProveedores["nombre"];

                    prov.Direccion = (string)drProveedores["direccion"];
                    prov.Dni = (string)drProveedores["dni"];
                    prov.Email = (string)drProveedores["email"];
                    prov.Telefono = (string)drProveedores["telefono"];


                    ListaProveedores.Add(prov);
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
           
            

            return ListaProveedores;



 
        }

        public AutoCompleteStringCollection GetListadoNombres()
        {

            AutoCompleteStringCollection provs = new AutoCompleteStringCollection();

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT nombre FROM Proveedores", Con);

            try
            {
                Comando.Connection.Open();
                SqlDataReader drProveedores = Comando.ExecuteReader();
            
                while (drProveedores.Read())
                {
                    Entidades.Proveedor prov = new Entidades.Proveedor();

                    prov.Nombre = (string)drProveedores["nombre"];
                    
                    provs.Add(prov.Nombre);
                                        
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

        public  List<Entidades.Proveedor> Busqueda(string texto)
        {
            List<Entidades.Proveedor> ListaProveedores = new List<Entidades.Proveedor>();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM Proveedores WHERE Proveedores.dni like @texto or Proveedores.nombre like @texto", Con);
            Comando.Parameters.Add(new SqlParameter("@texto", SqlDbType.NVarChar));
            Comando.Parameters["@texto"].Value =texto + '%';
            try
            {
                Comando.Connection.Open();
                SqlDataReader drProveedores = Comando.ExecuteReader();

                while (drProveedores.Read())
                {
                    Entidades.Proveedor prov = new Entidades.Proveedor();

                    prov.Nombre = (string)drProveedores["nombre"];

                    prov.Direccion = (string)drProveedores["direccion"];
                    prov.Dni = (string)drProveedores["dni"];
                    prov.Email = (string)drProveedores["email"];
                    prov.Telefono = (string)drProveedores["telefono"];


                    ListaProveedores.Add(prov);
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



            return ListaProveedores;




        }
    }
}
