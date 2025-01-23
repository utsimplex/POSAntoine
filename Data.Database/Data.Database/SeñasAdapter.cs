using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data;
//using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace Data.Database
{
    public class SeñasAdapter : Adapter
    {
        private CajasAdapter DatosCajaAdapter = new CajasAdapter();
        private SeñaArticuloAdapter SeñaArticuloAdapter = new SeñaArticuloAdapter();
        public void RegistrarSeña(Seña señaNueva,List<Seña_Articulo> lineas)
        {
            SqlConnection Con = CrearConexion();
            Caja caja = DatosCajaAdapter.GetCajaAbierta();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO [Senas] ([FechaHora], [TipoPago], [Total], [DniCliente], [Pagado], [MontoPagado], [Usuario], [CajaId], [NumVentaAplicada]) " +
                                    " OUTPUT INSERTED.NumeroSeña " +
                                      "VALUES (@FechaHora, @TipoPago, @Total, @DniCliente, @Pagado, @MontoPagado, @Usuario, @CajaId, @NumVentaAplicada)";

            //Comando.Parameters.AddWithValue("@NumeroSeña", señaNueva.NumeroSeña);
            Comando.Parameters.AddWithValue("@FechaHora", señaNueva.FechaHora);
            Comando.Parameters.AddWithValue("@TipoPago", señaNueva.TipoPago);
            Comando.Parameters.AddWithValue("@Total", señaNueva.Total);
            Comando.Parameters.AddWithValue("@DniCliente", señaNueva.DniCliente ?? (object)DBNull.Value);
            Comando.Parameters.AddWithValue("@Pagado", señaNueva.Pagado);
            Comando.Parameters.AddWithValue("@MontoPagado", señaNueva.MontoPagado);
            Comando.Parameters.AddWithValue("@Usuario", señaNueva.Usuario);
            Comando.Parameters.AddWithValue("@CajaId", caja.ID);
            Comando.Parameters.AddWithValue("@NumVentaAplicada", señaNueva.NumVentaAplicada ?? (object)DBNull.Value);
            

            try
            {
                Con.Open();
                int? idSeña= (int?)Comando.ExecuteScalar();
                Comando.ExecuteNonQuery();
                if(idSeña==null)
                {
                throw new Exception("Error al registrar la seña");
                }

                foreach (Seña_Articulo linea in lineas)
                {
                    linea.numeroSeña = (int)idSeña;
                    SeñaArticuloAdapter.RegistrarSeñaArticulo(linea);
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar la seña: " + ex.Message);
            }
            finally
            {
                Con.Close();
                
            }
        }

        public List<Seña> GetAllSeñas()
        {
            List<Seña> listaSeñas = new List<Seña>();
            SqlConnection Con = CrearConexion();

            SqlCommand Comando = new SqlCommand("SELECT * FROM [Senas]", Con);

            try
            {
                Con.Open();
                SqlDataReader drSeñas = Comando.ExecuteReader();

                while (drSeñas.Read())
                {
                    Seña seña = new Seña
                    {
                        NumeroSeña = (int)drSeñas["NumeroSeña"],
                        FechaHora = (DateTime)drSeñas["FechaHora"],
                        TipoPago = (string)drSeñas["TipoPago"],
                        Total = (decimal)drSeñas["Total"],
                        DniCliente = drSeñas["DniCliente"] != DBNull.Value ? (string)drSeñas["DniCliente"] : null,
                        Pagado = (bool)drSeñas["Pagado"],
                        MontoPagado = (decimal)drSeñas["MontoPagado"],
                        Usuario = (string)drSeñas["Usuario"],
                        CajaId = drSeñas["CajaId"] != DBNull.Value ? (int?)drSeñas["CajaId"] : null,
                        NumVentaAplicada = drSeñas["NumVentaAplicada"] != DBNull.Value ? (int?)drSeñas["NumVentaAplicada"] : null,
                    };

                    listaSeñas.Add(seña);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de señas: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }

            return listaSeñas;
        }

        public List<Seña> GetAllSeñas(string DNICliente)
        {
            List<Seña> listaSeñas = new List<Seña>();
            SqlConnection Con = CrearConexion();

            SqlCommand Comando = new SqlCommand("SELECT * FROM [Senas] Where DNICliente=@DniCliente", Con);
            Comando.Parameters.AddWithValue("@DniCliente", DNICliente);

            try
            {
                Con.Open();
                SqlDataReader drSeñas = Comando.ExecuteReader();

                while (drSeñas.Read())
                {
                    Seña seña = new Seña
                    {
                        NumeroSeña = (int)drSeñas["NumeroSeña"],
                        FechaHora = (DateTime)drSeñas["FechaHora"],
                        TipoPago = (string)drSeñas["TipoPago"],
                        Total = (decimal)drSeñas["Total"],
                        DniCliente = drSeñas["DniCliente"] != DBNull.Value ? (string)drSeñas["DniCliente"] : null,
                        Pagado = (bool)drSeñas["Pagado"],
                        MontoPagado = (decimal)drSeñas["MontoPagado"],
                        Usuario = (string)drSeñas["Usuario"],
                        CajaId = drSeñas["CajaId"] != DBNull.Value ? (int?)drSeñas["CajaId"] : null,
                        NumVentaAplicada = drSeñas["NumVentaAplicada"] != DBNull.Value ? (int?)drSeñas["NumVentaAplicada"] : null,
                    };

                    listaSeñas.Add(seña);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la lista de señas: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }

            return listaSeñas;
        }
        public Seña GetOneSeña(int numeroSeña)
        {
            Seña seña = null;
            SqlConnection Con = CrearConexion();

            SqlCommand Comando = new SqlCommand("SELECT * FROM [Senas] WHERE NumeroSeña = @NumeroSeña", Con);
            Comando.Parameters.AddWithValue("@NumeroSeña", numeroSeña);

            try
            {
                Con.Open();
                SqlDataReader drSeña = Comando.ExecuteReader();

                if (drSeña.Read())
                {
                    seña = new Seña
                    {
                        NumeroSeña = (int)drSeña["NumeroSeña"],
                        FechaHora = (DateTime)drSeña["FechaHora"],
                        TipoPago = (string)drSeña["TipoPago"],
                        Total = (decimal)drSeña["Total"],
                        DniCliente = drSeña["DniCliente"] != DBNull.Value ? (string)drSeña["DniCliente"] : null,
                        Pagado = (bool)drSeña["Pagado"],
                        MontoPagado = (decimal)drSeña["MontoPagado"],
                        Usuario = (string)drSeña["Usuario"],
                        CajaId = drSeña["CajaId"] != DBNull.Value ? (int?)drSeña["CajaId"] : null,
                        NumVentaAplicada = drSeña["NumVentaAplicada"] != DBNull.Value ? (int?)drSeña["NumVentaAplicada"] : null,
                        };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la seña: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }

            return seña;
        }

        public List<Seña> GetSeñasPorCliente(long numeroDocumentoCliente)
        {
            List<Seña> listaSeñas = new List<Seña>();
            SqlConnection Con = CrearConexion();

            SqlCommand Comando = new SqlCommand("SELECT * FROM [Senas] WHERE NumeroDocumentoCliente = @NumeroDocumentoCliente", Con);
            Comando.Parameters.AddWithValue("@NumeroDocumentoCliente", numeroDocumentoCliente);

            try
            {
                Con.Open();
                SqlDataReader drSeñas = Comando.ExecuteReader();

                while (drSeñas.Read())
                {
                    Seña seña = new Seña
                    {
                        NumeroSeña = (int)drSeñas["NumeroSeña"],
                        FechaHora = (DateTime)drSeñas["FechaHora"],
                        TipoPago = (string)drSeñas["TipoPago"],
                        Total = (decimal)drSeñas["Total"],
                        DniCliente = drSeñas["DniCliente"] != DBNull.Value ? (string)drSeñas["DniCliente"] : null,
                        Pagado = (bool)drSeñas["Pagado"],
                        MontoPagado = (decimal)drSeñas["MontoPagado"],
                        Usuario = (string)drSeñas["Usuario"],
                        CajaId = drSeñas["CajaId"] != DBNull.Value ? (int?)drSeñas["CajaId"] : null,
                        NumVentaAplicada = drSeñas["NumVentaAplicada"] != DBNull.Value ? (int?)drSeñas["NumVentaAplicada"] : null,
                    };

                    listaSeñas.Add(seña);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las señas del cliente: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }

            return listaSeñas;
        }

        public int GetUltimoNumeroSeña()
        {
            int ultimoNumeroSeña = 0;
            SqlConnection Con = CrearConexion();

            SqlCommand Comando = new SqlCommand("SELECT ISNULL(MAX(NumeroSeña), 0) AS UltimoNumeroSeña FROM [Senas]", Con);

            try
            {
                Con.Open();
                object result = Comando.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    ultimoNumeroSeña = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el último número de descuento: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }

            return ultimoNumeroSeña;
        }
        
        public void ActualizarNumVentaAplicada(int numeroSeña, int numVentaAplicada)
        {
            SqlConnection Con = CrearConexion();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE [Senas] SET NumVentaAplicada = @NumVentaAplicada WHERE NumeroSeña = @NumeroSeña";
            Comando.Parameters.AddWithValue("@NumVentaAplicada", numVentaAplicada);
            Comando.Parameters.AddWithValue("@NumeroSeña", numeroSeña);

            try
            {
                Con.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el número de venta aplicada: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        public void ActualizarMedioDePago(Seña señaActual)
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE [Senas] SET tipoPago=@TipoPago WHERE NumeroSeña=@NumeroSeña";
            Comando.Parameters.Add(new SqlParameter("@TIPOPAGO", SqlDbType.NVarChar));
            Comando.Parameters["@TIPOPAGO"].Value = señaActual.TipoPago;
            Comando.Parameters.Add(new SqlParameter("@NumeroSeña", SqlDbType.Int));
            Comando.Parameters["@NumeroSeña"].Value = señaActual.NumeroSeña;


            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }


    }
}

