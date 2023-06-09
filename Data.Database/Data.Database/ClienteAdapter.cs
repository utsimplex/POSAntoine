using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ClienteAdapter: Adapter
    {

        public void AñadirNuevo(Entidades.Cliente cli)
        {
                    
          //Crear Conexion y Abrirla
          SqlConnection Con = CrearConexion();
          
          // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
          SqlCommand Comando = new SqlCommand();
          Comando.Connection = Con;
          Comando.CommandType = CommandType.Text;

          Comando.CommandText = "INSERT INTO [Clientes] ([dni], [nombre], [apellido], [direccion], [telefono], [email], [tipo],[TipoDocumento],[SituacionFiscal],[TipoComprobante]) VALUES (@DNI, @NOMBRE, @APELLIDO, @DIRECCION, @TELEFONO, @EMAIL, @TIPO,@TIPODOCUMENTO,@SITUACIONFISCAL,@TIPOCOMPROBANTE)";
          Comando.Parameters.Add(new SqlParameter("@DNI", SqlDbType.NVarChar));
          Comando.Parameters["@DNI"].Value = cli.NumeroDocumento;
          Comando.Parameters.Add(new SqlParameter("@NOMBRE", SqlDbType.NVarChar));
          Comando.Parameters["@NOMBRE"].Value = cli.Nombre;
          Comando.Parameters.Add(new SqlParameter("@APELLIDO", SqlDbType.NVarChar));
          Comando.Parameters["@APELLIDO"].Value = cli.Apellido;
          Comando.Parameters.Add(new SqlParameter("@DIRECCION", SqlDbType.NVarChar));
          Comando.Parameters["@DIRECCION"].Value = cli.Direccion;
          Comando.Parameters.Add(new SqlParameter("@TELEFONO", SqlDbType.NVarChar));
          Comando.Parameters["@TELEFONO"].Value = cli.Telefono;
          Comando.Parameters.Add(new SqlParameter("@EMAIL", SqlDbType.NVarChar));
          Comando.Parameters["@EMAIL"].Value = cli.Email;
          Comando.Parameters.Add(new SqlParameter("@TIPO", SqlDbType.NVarChar));
          Comando.Parameters["@TIPO"].Value = cli.TipoCliente;
          Comando.Parameters.Add(new SqlParameter("@TIPODOCUMENTO", SqlDbType.Int));
          Comando.Parameters["@TIPODOCUMENTO"].Value = cli.TipoDocumento;
          Comando.Parameters.Add(new SqlParameter("@SITUACIONFISCAL", SqlDbType.Int));
          Comando.Parameters["@SITUACIONFISCAL"].Value = cli.SituacionFiscal;
          Comando.Parameters.Add(new SqlParameter("@TIPOCOMPROBANTE", SqlDbType.NVarChar));
          Comando.Parameters["@TIPOCOMPROBANTE"].Value = cli.TipoComprobante;
          //Ejecuta el comando INSERT
          Comando.Connection.Open();
          Comando.ExecuteNonQuery();
          Comando.Connection.Close();

              
        }

        public void Quitar(string Dni)
        {

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = "DELETE FROM [Clientes] WHERE (([dni] = @DNI))";
            Comando.Parameters.Add(new SqlParameter("@DNI", SqlDbType.NVarChar));
            Comando.Parameters["@DNI"].Value = Dni;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public void Actualizar(Entidades.Cliente cli)
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE [Clientes] SET [nombre] = @NOMBRE, [apellido] = @APELLIDO, [direccion] = @DIRECCION, [telefono] = @TELEFONO, [email] = @EMAIL, [tipo] = @TIPO, [TipoDocumento]=@TIPODOCUMENTO,[SituacionFiscal]=@SITACIONFISCAL,[TipoComprobante]=@TIPOCOMPROBANTE WHERE (([dni] = @DNI))";
            Comando.Parameters.Add(new SqlParameter("@DNI", SqlDbType.NVarChar));
            Comando.Parameters["@DNI"].Value = cli.NumeroDocumento;
            Comando.Parameters.Add(new SqlParameter("@NOMBRE", SqlDbType.NVarChar));
            Comando.Parameters["@NOMBRE"].Value = cli.Nombre;
            Comando.Parameters.Add(new SqlParameter("@APELLIDO", SqlDbType.NVarChar));
            Comando.Parameters["@APELLIDO"].Value = cli.Apellido;
            Comando.Parameters.Add(new SqlParameter("@DIRECCION", SqlDbType.NVarChar));
            Comando.Parameters["@DIRECCION"].Value = cli.Direccion;
            Comando.Parameters.Add(new SqlParameter("@TELEFONO", SqlDbType.NVarChar));
            Comando.Parameters["@TELEFONO"].Value = cli.Telefono;
            Comando.Parameters.Add(new SqlParameter("@EMAIL", SqlDbType.NVarChar));
            Comando.Parameters["@EMAIL"].Value = cli.Email;
            Comando.Parameters.Add(new SqlParameter("@TIPO", SqlDbType.NVarChar));
            Comando.Parameters["@TIPO"].Value = cli.TipoCliente;
            Comando.Parameters.Add(new SqlParameter("@TIPODOCUMENTO", SqlDbType.Int));
            Comando.Parameters["@TIPODOCUMENTO"].Value = cli.TipoDocumento;
            Comando.Parameters.Add(new SqlParameter("@SITUACIONFISCAL", SqlDbType.Int));
            Comando.Parameters["@SITUACIONFISCAL"].Value = cli.SituacionFiscal;
            Comando.Parameters.Add(new SqlParameter("@TIPOCOMPROBANTE", SqlDbType.NVarChar));
            Comando.Parameters["@TIPOCOMPROBANTE"].Value = cli.TipoComprobante;


            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public List<Entidades.Cliente> GetAll()
        {
            List<Entidades.Cliente> ListaClientes = new List<Entidades.Cliente>();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM Clientes", Con);
            try
            {
                Comando.Connection.Open();
                SqlDataReader drClientes = Comando.ExecuteReader();

                while (drClientes.Read())
                {
                    Entidades.Cliente cli= new Entidades.Cliente();

                    cli.Apellido= (string)drClientes["apellido"];
                    cli.Nombre = (string)drClientes["nombre"];
                    cli.Direccion = (string)drClientes["direccion"];
                    cli.NumeroDocumento = (string)drClientes["dni"];
                    cli.Email = (string)drClientes["email"];
                    cli.Telefono = (string)drClientes["telefono"];
                    cli.TipoCliente = (string)drClientes["tipo"];
                    cli.TipoDocumento = drClientes["TipoDocumento"]!=DBNull.Value? Convert.ToInt32(drClientes["TipoDocumento"]):(int?)null;
                    cli.SituacionFiscal = drClientes["SituacionFiscal"] != DBNull.Value ? Convert.ToInt32(drClientes["SituacionFiscal"]) : (int?)null;
                    cli.TipoComprobante = drClientes["TipoComprobante"] != DBNull.Value ? Convert.ToInt32(drClientes["TipoComprobante"]) : (int?)null;


                    ListaClientes.Add(cli);
                }
                drClientes.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Clientes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ListaClientes;




        }

        public Entidades.Cliente GetOne(string dni)
        {
            Entidades.Cliente ClienteActual = new Entidades.Cliente();

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM Clientes WHERE Clientes.dni = @DNI", Con);
            Comando.Parameters.Add(new SqlParameter("@DNI", SqlDbType.NVarChar));
            Comando.Parameters["@DNI"].Value = dni;

            try
            {
                Comando.Connection.Open();
                SqlDataReader drClientes = Comando.ExecuteReader();

                while (drClientes.Read())
                {
                   

                    
                    ClienteActual.Apellido = (string)drClientes["apellido"];
                    ClienteActual.Nombre = (string)drClientes["nombre"];
                    ClienteActual.Direccion = (string)drClientes["direccion"];
                    ClienteActual.NumeroDocumento = (string)drClientes["dni"];
                    ClienteActual.Email = (string)drClientes["email"];
                    ClienteActual.Telefono = (string)drClientes["telefono"];
                    ClienteActual.TipoDocumento = drClientes["TipoDocumento"] != DBNull.Value ? Convert.ToInt32(drClientes["TipoDocumento"]) : (int?)null;
                    ClienteActual.SituacionFiscal = drClientes["SituacionFiscal"] != DBNull.Value ? Convert.ToInt32(drClientes["SituacionFiscal"]) : (int?)null;
                    ClienteActual.TipoComprobante = drClientes["TipoComprobante"] != DBNull.Value ? Convert.ToInt32(drClientes["TipoComprobante"]) : (int?)null;



                }
                drClientes.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Clientes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ClienteActual;




        }

        
        public  List<Entidades.Cliente> Busqueda(string texto)
        {
           
            List<Entidades.Cliente> ListaClientes = new List<Entidades.Cliente>();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM Clientes WHERE Clientes.nombre like @texto OR Clientes.dni like @texto OR Clientes.apellido like @texto", Con);
            Comando.Parameters.Add(new SqlParameter("@texto", SqlDbType.NVarChar));
            Comando.Parameters["@texto"].Value = texto+'%';
            try
            {
                Comando.Connection.Open();
                SqlDataReader drClientes = Comando.ExecuteReader();

                while (drClientes.Read())
                {
                    Entidades.Cliente cli = new Entidades.Cliente();

                    cli.Apellido = (string)drClientes["apellido"];
                    cli.Nombre = (string)drClientes["nombre"];
                    cli.Direccion = (string)drClientes["direccion"];
                    cli.NumeroDocumento = (string)drClientes["dni"];
                    cli.Email = (string)drClientes["email"];
                    cli.Telefono = (string)drClientes["telefono"];
                    cli.TipoDocumento = drClientes["TipoDocumento"] != DBNull.Value ? Convert.ToInt32(drClientes["TipoDocumento"]) : (int?)null;
                    cli.SituacionFiscal = drClientes["SituacionFiscal"] != DBNull.Value ? Convert.ToInt32(drClientes["SituacionFiscal"]) : (int?)null;
                    cli.TipoComprobante = drClientes["TipoComprobante"] != DBNull.Value ? Convert.ToInt32(drClientes["TipoComprobante"]) : (int?)null;


                    ListaClientes.Add(cli);
                }
                drClientes.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Clientes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ListaClientes;




        }

        




    }
}
