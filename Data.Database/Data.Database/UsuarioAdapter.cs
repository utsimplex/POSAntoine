using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlServerCe;

namespace Data.Database
{
    public class UsuarioAdapter : Adapter
    {
        /*
         #region DatosEnMemoria
         // Esta región solo se usa en esta etapa donde los datos se mantienen en memoria.
         // Al modificar este proyecto para que acceda a la base de datos esta será eliminada
         private static List<Usuario> _Usuarios;

         private static List<Usuario> Usuarios
         {
             get
             {
                 if (_Usuarios == null)
                 {
                     _Usuarios = new List<Entidades.Usuario>();
                     Entidades.Usuario usr;
                     usr = new Entidades.Usuario();
                     usr.ID = 1;
                     usr.State = Entidades.EntidadNegocio.States.SinModificar;
                     usr.Nombre = "Casimiro";
                     usr.Apellido = "Cegado";
                     usr.NombreUsuario = "casicegado";
                     usr.Clave = "miro";
                     usr.eMail = "casimirocegado@gmail.com";
                     usr.Habilitado = true;
                     _Usuarios.Add(usr);

                     usr = new Entidades.Usuario();
                     usr.ID = 2;
                     usr.State = Entidades.EntidadNegocio.States.SinModificar;
                     usr.Nombre = "Armando Esteban";
                     usr.Apellido = "Quito";
                     usr.NombreUsuario = "aequito";
                     usr.Clave = "carpintero";
                     usr.eMail = "armandoquito@gmail.com";
                     usr.Habilitado = true;
                     _Usuarios.Add(usr);

                     usr = new Entidades.Usuario();
                     usr.ID = 3;
                     usr.State = Entidades.EntidadNegocio.States.SinModificar;
                     usr.Nombre = "Alan";
                     usr.Apellido = "Brado";
                     usr.NombreUsuario = "alanbrado";
                     usr.Clave = "abrete sesamo";
                     usr.eMail = "alanbrado@gmail.com";
                     usr.Habilitado = true;
                     _Usuarios.Add(usr);

                 }
                 return _Usuarios;
             }
         }

         public List<Usuario> GetAll()
         {
             return new List<Usuario>(Usuarios);
         }

         public Entidades.Usuario GetOne(int ID)
         {
             return Usuarios.Find(delegate(Usuario u) { return u.ID == ID; });
         }

         public void Delete(int ID)
         {
             Usuarios.Remove(this.GetOne(ID));
         }

         public void Save(Usuario usuario)
         {
             if (usuario.State == EntidadNegocio.States.Nuevo)
             {
                 int NextID = 0;
                 foreach (Usuario usr in Usuarios)
                 {
                     if (usr.ID > NextID)
                     {
                         NextID = usr.ID;
                     }
                 }
                 usuario.ID = NextID + 1;
                 Usuarios.Add(usuario);
             }
             else if (usuario.State == EntidadNegocio.States.Eliminado)
             {
                 this.Delete(usuario.ID);
             }
             else if (usuario.State == EntidadNegocio.States.Modificado)
             {
                 Usuarios[Usuarios.FindIndex(delegate(Usuario u) { return u.ID == usuario.ID; })]=usuario;
             }
             usuario.State = EntidadNegocio.States.SinModificar;            
         }
                  #endregion
 */

        public List<Entidades.Usuario> GetAll()
        {
            List<Entidades.Usuario> ListaUsuarios = new List<Entidades.Usuario>();
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Usuarios", Con);
            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drUsuarios = Comando.ExecuteReader();

                while (drUsuarios.Read())
                {
                    Entidades.Usuario usr = new Entidades.Usuario();

                    usr.Contraseña = (string)drUsuarios["contraseña"];
                    usr.usuario = (string)drUsuarios["usuario"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Direccion = (string)drUsuarios["direccion"];
                    usr.Cuil = (string)drUsuarios["cuil"];
                    usr.Email = (string)drUsuarios["email"];
                    usr.Telefono = (string)drUsuarios["telefono"];
                    usr.Rol = (string)drUsuarios["rol"];
                    string estado = (string)drUsuarios["state"];

                    switch (estado)
                    {
                        case "Nuevo": usr.State = EntidadNegocio.States.Nuevo;
                            break;
                        case "Modificado": usr.State = EntidadNegocio.States.Modificado;
                            break;
                        case "Eliminado": usr.State = EntidadNegocio.States.Eliminado;
                            break;


                    }

                    if (usr.State != EntidadNegocio.States.Eliminado)
                    {
                        ListaUsuarios.Add(usr);
                    }
                }
                drUsuarios.Close();
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

            return ListaUsuarios;
        }

        public Boolean ValidarUsuario(string usuario, string contraseña)
        {
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();
            Entidades.Usuario UsuarioNuevo = new Entidades.Usuario();
            UsuarioNuevo.usuario = "";
            Boolean rta = false;

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Usuarios WHERE Usuarios.usuario = @usuario", Con);
            Comando.Parameters.Add(new SqlCeParameter("@usuario", SqlDbType.NVarChar));
            Comando.Parameters["@usuario"].Value = usuario;
            try
            {
                Con.Open();
                SqlCeDataReader drUsuarios = Comando.ExecuteReader();

                while (drUsuarios.Read())
                {
                    string usuarioActual = (string)drUsuarios["usuario"];
                    string contraseñaActual = (string)drUsuarios["contraseña"];
                    
                    

                    if ((usuarioActual == usuario) && (contraseñaActual == contraseña))
                    {
                        rta = true;
                    }
                    else
                    {
                        rta = false;
                    }
                }

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Usuarios", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return rta;




        }

        public Entidades.Usuario GetUsuario(string usuario)
        {
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();
            Entidades.Usuario UsuarioNuevo = new Entidades.Usuario();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Usuarios WHERE usuario = @usuario", Con);
            Comando.Parameters.Add(new SqlCeParameter("@usuario", SqlDbType.NVarChar));
            Comando.Parameters["@usuario"].Value = usuario;
            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drUsuarios = Comando.ExecuteReader();
                if (drUsuarios.Read())
                {
                    UsuarioNuevo.Rol = (string)drUsuarios["rol"];
                    UsuarioNuevo.usuario = (string)drUsuarios["usuario"];
                    UsuarioNuevo.Contraseña = (string)drUsuarios["contraseña"];
                    UsuarioNuevo.Apellido = (string)drUsuarios["apellido"];
                    UsuarioNuevo.Nombre = (string)drUsuarios["nombre"];
                    UsuarioNuevo.Cuil = (string)drUsuarios["cuil"];
                    UsuarioNuevo.Email = (string)drUsuarios["email"];
                    UsuarioNuevo.Telefono = (string)drUsuarios["telefono"];
                    UsuarioNuevo.Direccion = (string)drUsuarios["direccion"];
                    string estado = (string)drUsuarios["state"];

                    switch (estado)
                    {
                        case "Nuevo": UsuarioNuevo.State = EntidadNegocio.States.Nuevo;
                            break;
                        case "Modificado": UsuarioNuevo.State = EntidadNegocio.States.Modificado;
                            break;
                        case "Eliminado": UsuarioNuevo.State = EntidadNegocio.States.Eliminado;
                            break;

                                                
                    }
                }
                drUsuarios.Close();


            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Usuarios", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }
            return UsuarioNuevo;
        }

        public void AñadirNuevo(Entidades.Usuario usr)
        {

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO [Usuarios] ([nombre],[apellido],[telefono],[cuil],[direccion],[usuario],[contraseña],[email],[rol],[state]) VALUES (@NOMBRE, @APELLIDO, @TELEFONO, @CUIL, @DIRECCION, @USUARIO,@CONTRASEÑA, @EMAIL,@ROL,@STATE)";
            Comando.Parameters.Add(new SqlCeParameter("@NOMBRE", SqlDbType.NVarChar));
            Comando.Parameters["@NOMBRE"].Value = usr.Nombre;
            Comando.Parameters.Add(new SqlCeParameter("@APELLIDO", SqlDbType.NVarChar));
            Comando.Parameters["@APELLIDO"].Value = usr.Apellido;
            Comando.Parameters.Add(new SqlCeParameter("@DIRECCION", SqlDbType.NVarChar));
            Comando.Parameters["@DIRECCION"].Value = usr.Direccion;
            Comando.Parameters.Add(new SqlCeParameter("@TELEFONO", SqlDbType.NVarChar));
            Comando.Parameters["@TELEFONO"].Value = usr.Telefono;
            Comando.Parameters.Add(new SqlCeParameter("@CUIL", SqlDbType.NVarChar));
            Comando.Parameters["@CUIL"].Value = usr.Cuil;
            Comando.Parameters.Add(new SqlCeParameter("@EMAIL", SqlDbType.NVarChar));
            Comando.Parameters["@EMAIL"].Value = usr.Email;
            Comando.Parameters.Add(new SqlCeParameter("@USUARIO", SqlDbType.NVarChar));
            Comando.Parameters["@USUARIO"].Value = usr.usuario;
            Comando.Parameters.Add(new SqlCeParameter("@CONTRASEÑA", SqlDbType.NVarChar));
            Comando.Parameters["@CONTRASEÑA"].Value = usr.Contraseña;
            Comando.Parameters.Add(new SqlCeParameter("@ROL", SqlDbType.NVarChar));
            Comando.Parameters["@ROL"].Value = usr.Rol;
            Comando.Parameters.Add(new SqlCeParameter("@STATE", SqlDbType.NVarChar));
            Comando.Parameters["@STATE"].Value = usr.State.ToString();

         


            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();


        }

        public void Quitar(string usuario)
        {

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "DELETE FROM [Usuarios] WHERE (([usuario] = @USUARIO))";
            Comando.Parameters.Add(new SqlCeParameter("@USUARIO", SqlDbType.NVarChar));
            Comando.Parameters["@USUARIO"].Value = usuario;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public void Actualizar(Entidades.Usuario usr)
        {
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE [Usuarios] SET [nombre]=  @NOMBRE, [apellido] = @APELLIDO, [telefono] = @TELEFONO,[direccion] = @DIRECCION,[email] = @EMAIL, [rol]=@ROL,[cuil]=@CUIL,[contraseña]=@CONTRASEÑA, [state]=@STATE WHERE (([usuario]=@USUARIO))";

            Comando.Parameters.Add(new SqlCeParameter("@NOMBRE", SqlDbType.NVarChar));
            Comando.Parameters["@NOMBRE"].Value = usr.Nombre;
            Comando.Parameters.Add(new SqlCeParameter("@APELLIDO", SqlDbType.NVarChar));
            Comando.Parameters["@APELLIDO"].Value = usr.Apellido;
            Comando.Parameters.Add(new SqlCeParameter("@DIRECCION", SqlDbType.NVarChar));
            Comando.Parameters["@DIRECCION"].Value = usr.Direccion;
            Comando.Parameters.Add(new SqlCeParameter("@TELEFONO", SqlDbType.NVarChar));
            Comando.Parameters["@TELEFONO"].Value = usr.Telefono;
            Comando.Parameters.Add(new SqlCeParameter("@CUIL", SqlDbType.NVarChar));
            Comando.Parameters["@CUIL"].Value = usr.Cuil;
            Comando.Parameters.Add(new SqlCeParameter("@EMAIL", SqlDbType.NVarChar));
            Comando.Parameters["@EMAIL"].Value = usr.Email;
            Comando.Parameters.Add(new SqlCeParameter("@USUARIO", SqlDbType.NVarChar));
            Comando.Parameters["@USUARIO"].Value = usr.usuario;
            Comando.Parameters.Add(new SqlCeParameter("@CONTRASEÑA", SqlDbType.NVarChar));
            Comando.Parameters["@CONTRASEÑA"].Value = usr.Contraseña;
            Comando.Parameters.Add(new SqlCeParameter("@ROL", SqlDbType.NVarChar));
            Comando.Parameters["@ROL"].Value = usr.Rol;
            Comando.Parameters.Add(new SqlCeParameter("@STATE", SqlDbType.NVarChar));
            Comando.Parameters["@STATE"].Value = usr.State.ToString();


            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public List<Entidades.Usuario> Busqueda(string texto)
        {

            List<Entidades.Usuario> ListaUsuarios = new List<Entidades.Usuario>();
            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Usuarios WHERE Usuarios.nombre like @texto OR Usuarios.usuario like @texto OR Usuarios.apellido like @texto", Con);
            Comando.Parameters.Add(new SqlCeParameter("@texto", SqlDbType.NVarChar));
            Comando.Parameters["@texto"].Value = texto + '%';
            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drUsuarios = Comando.ExecuteReader();

                while (drUsuarios.Read())
                {
                    Entidades.Usuario usr = new Entidades.Usuario();

                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Direccion = (string)drUsuarios["direccion"];
                    usr.Cuil = (string)drUsuarios["cuil"];
                    usr.Email = (string)drUsuarios["email"];
                    usr.Telefono = (string)drUsuarios["telefono"];
                    usr.usuario = (string)drUsuarios["usuario"];
                    usr.Contraseña = (string)drUsuarios["contraseña"];
                    usr.Rol = (string)drUsuarios["rol"];
                    string estado = (string)drUsuarios["state"];

                    switch (estado)
                    {
                        case "Nuevo": usr.State = EntidadNegocio.States.Nuevo;
                            break;
                        case "Modificado": usr.State = EntidadNegocio.States.Modificado;
                            break;
                        case "Eliminado": usr.State = EntidadNegocio.States.Eliminado;
                            break;


                    }


                    ListaUsuarios.Add(usr);
                }
                drUsuarios.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Usuarios", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ListaUsuarios;




        }




    }
}
