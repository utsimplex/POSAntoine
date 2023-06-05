using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Data.Database
{
    public class CajasAdapter : Adapter
    {

        public Entidades.Caja GetCajaAbierta()
        {
            List<Entidades.Caja> listaCajasAbiertas = new List<Entidades.Caja>();

            // Crear conexión
            SqlConnection con = CrearConexion();

            try
            {
                // Abrir la conexión
                con.Open();

                // Crear SqlCommand
                SqlCommand cmd = new SqlCommand("GetCajasAbiertas", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Ejecutar el stored procedure y obtener el resultado en un SqlDataReader
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Crear una instancia de la entidad Caja y asignar los valores del resultado
                        Entidades.Caja cajaAbierta = new Entidades.Caja();

                        cajaAbierta.ID = Convert.ToInt32(reader["id"]);
                        cajaAbierta.Descripcion = reader["descripcion"].ToString();
                        cajaAbierta.FechaCaja = Convert.ToDateTime(reader["fecha_caja"]);
                        cajaAbierta.FechaApertura = Convert.ToDateTime(reader["fecha_apertura"]);
                        cajaAbierta.FechaCierre = Convert.ToDateTime(reader["fecha_cierre"]);
                        cajaAbierta.SaldoInicial = reader.GetSqlMoney(reader.GetOrdinal("saldo_inicial"));
                        cajaAbierta.SaldoFinal = reader.GetSqlMoney(reader.GetOrdinal("saldo_final"));
                        cajaAbierta.MontoNetoMovimientos = reader.GetSqlMoney(reader.GetOrdinal("monto_neto_movimientos"));
                        cajaAbierta.Usuario = reader["usuario"].ToString();
                        cajaAbierta.MontoVentasTotal = reader.GetSqlMoney(reader.GetOrdinal("monto_ventas_total"));

                        // Agrego a la lista de cajas abiertas
                        listaCajasAbiertas.Add(cajaAbierta);
                    }
                }

                if (listaCajasAbiertas.Count > 1)
                {
                    MessageBox.Show("Hay más de 1 caja");
                    return null;
                }
                if (listaCajasAbiertas.Count == 1)
                {
                    MessageBox.Show("Hay 1 sola caja abierta");
                    return listaCajasAbiertas[0];
                }
                if (listaCajasAbiertas.Count == 0)
                {
                    MessageBox.Show("No hay cajas");
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción o mostrar un mensaje de error
                MessageBox.Show("Error al obtener la caja abierta: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión después de usarla
                con.Close();
            }

            return null;
        }



        public void RegistrarVenta(Venta ventaNueva)
        {

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO [Ventas] ([numVenta], [fechaHora], [tipoPago], [total], [dniCliente],[descuento],[usuario], [tipooperacion] ) VALUES (@NUMVENTA, @FECHAHORA, @TIPOPAGO, @TOTAL, @DNICLIENTE, @DESCUENTO, @USUARIO, @TIPOOPERACION)";
            Comando.Parameters.Add(new SqlParameter("@NUMVENTA", SqlDbType.Int));
            Comando.Parameters["@NUMVENTA"].Value = ventaNueva.NumeroVenta;
            Comando.Parameters.Add(new SqlParameter("@FECHAHORA", SqlDbType.DateTime));
            Comando.Parameters["@FECHAHORA"].Value = ventaNueva.FechaHora;
            Comando.Parameters.Add(new SqlParameter("@TIPOPAGO", SqlDbType.NVarChar));
            Comando.Parameters["@TIPOPAGO"].Value = ventaNueva.TipoPago;
            Comando.Parameters.Add(new SqlParameter("@TOTAL", SqlDbType.Money));
            Comando.Parameters["@TOTAL"].Value = ventaNueva.Total;
            Comando.Parameters.Add(new SqlParameter("@DNICLIENTE", SqlDbType.NVarChar));
            Comando.Parameters["@DNICLIENTE"].Value = ventaNueva.DniCliente;
            Comando.Parameters.Add(new SqlParameter("@DESCUENTO", SqlDbType.Int));
            Comando.Parameters["@DESCUENTO"].Value = ventaNueva.Descuento;
            Comando.Parameters.Add(new SqlParameter("@USUARIO", SqlDbType.NVarChar));
            Comando.Parameters["@USUARIO"].Value = ventaNueva.Usuario;
            Comando.Parameters.Add(new SqlParameter("@TIPOOPERACION", SqlDbType.NVarChar));
            Comando.Parameters["@TIPOOPERACION"].Value = ventaNueva.TipoOperacion;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();


        }

        //public void ModificarVenta(Venta ventaModificada)
        //{

        //    //Crear Conexion y Abrirla
        //    SqlConnection Con = CrearConexion();

        //    // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
        //    SqlCommand Comando = new SqlCommand();
        //    Comando.Connection = Con;
        //    Comando.CommandType = CommandType.Text;

        //    Comando.CommandText = "UPDATE [Ventas] SET [numVenta] = @NUMVENTA, [fechaHora] = @FECHAHORA, [tipoPago] = @TIPOPAGO, [total] = @TOTAL, [dniCliente] = @DNICLIENTE, [descuento] = @DESCUENTO, [TIPOOPERACION] = @TIPOOPERACION, [usuario] = @USUARIO WHERE [numVenta] = @NUMVENTA";
        //    Comando.Parameters.Add(new SqlParameter("@NUMVENTA", SqlDbType.Int));
        //    Comando.Parameters["@NUMVENTA"].Value = ventaModificada.NumeroVenta;
        //    Comando.Parameters.Add(new SqlParameter("@FECHAHORA", SqlDbType.DateTime));
        //    Comando.Parameters["@FECHAHORA"].Value = ventaModificada.FechaHora;
        //    Comando.Parameters.Add(new SqlParameter("@TIPOPAGO", SqlDbType.NVarChar));
        //    Comando.Parameters["@TIPOPAGO"].Value = ventaModificada.TipoPago;
        //    Comando.Parameters.Add(new SqlParameter("@TOTAL", SqlDbType.Money));
        //    Comando.Parameters["@TOTAL"].Value = ventaModificada.Total;
        //    Comando.Parameters.Add(new SqlParameter("@DNICLIENTE", SqlDbType.NVarChar));
        //    Comando.Parameters["@DNICLIENTE"].Value = ventaModificada.DniCliente;
        //    Comando.Parameters.Add(new SqlParameter("@DESCUENTO", SqlDbType.Int));
        //    Comando.Parameters["@DESCUENTO"].Value = ventaModificada.Descuento;
        //    Comando.Parameters.Add(new SqlParameter("@USUARIO", SqlDbType.NVarChar));
        //    Comando.Parameters["@USUARIO"].Value = ventaModificada.Usuario;
        //    Comando.Parameters.Add(new SqlParameter("@TIPOOPERACION", SqlDbType.NVarChar));
        //    Comando.Parameters["@USUARIO"].Value = ventaModificada.TipoOperacion;

        //    //Ejecuta el comando INSERT
        //    Comando.Connection.Open();
        //    Comando.ExecuteNonQuery();
        //    Comando.Connection.Close();


        //}

        public List<Venta> GetAll()
        {
            List<Venta> ListaVentas = new List<Venta>();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM Ventas ORDER BY Ventas.numVenta, Ventas.TipoOperacion DESC", Con);
            try
            {
                Comando.Connection.Open();
                SqlDataReader drVentas = Comando.ExecuteReader();

                while (drVentas.Read())
                {
                    Venta vta = new Venta();

                    vta.NumeroVenta = (int)drVentas["numventa"];
                    vta.FechaHora = (DateTime)drVentas["fechahora"];
                    vta.Descuento = (decimal)drVentas["descuento"];
                    vta.DniCliente = (string)drVentas["dnicliente"];
                    vta.Usuario = (string)drVentas["usuario"];
                    vta.TipoPago = (string)drVentas["tipopago"];
                    vta.Total = (decimal)drVentas["total"];
                    vta.TipoOperacion = (string)drVentas["tipooperacion"];


                    ListaVentas.Add(vta);
                }
                drVentas.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Ventas", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ListaVentas;




        }

        public int getUltNroVenta()
        {

            int nroUltVta = 0;

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand(" select CASE WHEN MAX(numVenta) IS NULL THEN 0 ELSE MAX(numVenta) END AS NROULTIMAVENTA FROM Ventas", Con);
            try
            {
                Comando.Connection.Open();
                SqlDataReader drVentas = Comando.ExecuteReader();
               
                drVentas.Read();
                
                 nroUltVta = (int)drVentas["NROULTIMAVENTA"]; 
               
               

                drVentas.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el Ultimo número de venta.", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return nroUltVta;


        }

        public int getStatusVenta(int nroVenta)
        {

            int tieneDevolucion;

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT COUNT(*) FROM Ventas WHERE TipoOperacion = 'D' AND numVenta = " + nroVenta, Con);
            Comando.CommandType = CommandType.Text;
            try
            {
                Comando.Connection.Open();
                tieneDevolucion = (int)Comando.ExecuteScalar();
                Comando.Connection.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el Ultimo número de venta.", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return tieneDevolucion;


        }

        public List<Entidades.Venta> Busqueda(string texto)
        {

            List<Entidades.Venta> ListaVentas = new List<Entidades.Venta>();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM Ventas WHERE Ventas.tipoPago like @texto OR Ventas.usuario like @texto OR Ventas.dniCliente like @texto;", Con);
            Comando.Parameters.Add(new SqlParameter("@texto", SqlDbType.NVarChar));
            Comando.Parameters["@texto"].Value = texto + '%';
            try
            {
                Comando.Connection.Open();
                SqlDataReader drVentas = Comando.ExecuteReader();

                while (drVentas.Read())
                {
                    Entidades.Venta ventaActual = new Entidades.Venta();

                    ventaActual.Descuento = (decimal)drVentas["descuento"];
                    ventaActual.DniCliente = (string)drVentas["dniCliente"];
                    ventaActual.FechaHora = (DateTime)drVentas["fechaHora"];
                    ventaActual.NumeroVenta = (int)drVentas["numVenta"];
                    ventaActual.Total = (decimal)drVentas["total"];
                    ventaActual.TipoPago = (string)drVentas["tipoPago"];
                    ventaActual.Usuario = (string)drVentas["usuario"];
                    ventaActual.TipoOperacion = (string)drVentas["tipooperacion"];

                    ListaVentas.Add(ventaActual);
                }
                drVentas.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Ventas", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ListaVentas;




        }

        public List<Entidades.Venta> BusquedaFechaDesde(DateTime fechaDesde)
        {
            DateTime fechaDsd = new DateTime(fechaDesde.Year, fechaDesde.Month, fechaDesde.Day);
            List<Entidades.Venta> ListaVentas = new List<Entidades.Venta>();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM Ventas WHERE Ventas.fechaHora >= @fechaDesde;", Con);
            Comando.Parameters.Add(new SqlParameter("@fechaDesde", SqlDbType.DateTime));
            Comando.Parameters["@fechaDesde"].Value = fechaDsd;
            try
            {
                Comando.Connection.Open();
                SqlDataReader drVentas = Comando.ExecuteReader();

                while (drVentas.Read())
                {
                    Entidades.Venta ventaActual = new Entidades.Venta();

                    ventaActual.Descuento = (decimal)drVentas["descuento"];
                    ventaActual.DniCliente = (string)drVentas["dniCliente"];
                    ventaActual.FechaHora = (DateTime)drVentas["fechaHora"];
                    ventaActual.NumeroVenta = (int)drVentas["numVenta"];
                    ventaActual.Total = (decimal)drVentas["total"];
                    ventaActual.TipoPago = (string)drVentas["tipoPago"];
                    ventaActual.Usuario = (string)drVentas["usuario"];

                    ventaActual.TipoOperacion = (string)drVentas["tipooperacion"];

                    ListaVentas.Add(ventaActual);
                }
                drVentas.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Ventas", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ListaVentas;




        }
        
        public List<Entidades.Venta> BusquedaFechaDesde(DateTime fechaDesde, DateTime fechaHasta)
        {

            DateTime fDesde = new DateTime(fechaDesde.Year, fechaDesde.Month, fechaDesde.Day);
            DateTime fHasta = new DateTime(fechaHasta.Year, fechaHasta.Month, fechaHasta.Day);
            List<Entidades.Venta> ListaVentas = new List<Entidades.Venta>();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM Ventas WHERE Ventas.fechaHora BETWEEN @fechaDesde AND @fechaHasta;", Con);
            Comando.Parameters.Add(new SqlParameter("@fechaDesde", SqlDbType.DateTime));
            Comando.Parameters["@fechaDesde"].Value = fDesde;
            Comando.Parameters.Add(new SqlParameter("@fechaHasta", SqlDbType.DateTime));
            Comando.Parameters["@fechaHasta"].Value = fHasta;

            try
            {
                Comando.Connection.Open();
                SqlDataReader drVentas = Comando.ExecuteReader();

                while (drVentas.Read())
                {
                    Entidades.Venta ventaActual = new Entidades.Venta();

                    ventaActual.Descuento = (decimal)drVentas["descuento"];
                    ventaActual.DniCliente = (string)drVentas["dniCliente"];
                    ventaActual.FechaHora = (DateTime)drVentas["fechaHora"];
                    ventaActual.NumeroVenta = (int)drVentas["numVenta"];
                    ventaActual.Total = (decimal)drVentas["total"];
                    ventaActual.TipoPago = (string)drVentas["tipoPago"];
                    ventaActual.Usuario = (string)drVentas["usuario"];

                    ventaActual.TipoOperacion = (string)drVentas["tipooperacion"];

                    ListaVentas.Add(ventaActual);
                }
                drVentas.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Ventas", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ListaVentas;




        }

    }
}
