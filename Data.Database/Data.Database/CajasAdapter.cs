using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

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

                        cajaAbierta.ID = (int)reader["id"];
                        cajaAbierta.Descripcion = reader.IsDBNull(reader.GetOrdinal("descripcion")) ? string.Empty : reader.GetString(reader.GetOrdinal("descripcion"));
                        cajaAbierta.FechaCaja = (DateTime)reader["fecha_caja"];
                        cajaAbierta.FechaApertura = (DateTime)reader["fecha_apertura"];
                        cajaAbierta.FechaCierre = reader.IsDBNull(reader.GetOrdinal("fecha_cierre")) ? DateTime.MinValue : (DateTime)reader["fecha_cierre"];
                        cajaAbierta.SaldoInicial = reader.IsDBNull(reader.GetOrdinal("saldo_inicial")) ? SqlMoney.Zero : reader.GetSqlMoney(reader.GetOrdinal("saldo_inicial"));
                        cajaAbierta.SaldoFinal = reader.IsDBNull(reader.GetOrdinal("saldo_final")) ? SqlMoney.Zero : reader.GetSqlMoney(reader.GetOrdinal("saldo_final"));
                        cajaAbierta.MontoNetoMovimientos = reader.IsDBNull(reader.GetOrdinal("monto_neto_movimientos")) ? SqlMoney.Zero : reader.GetSqlMoney(reader.GetOrdinal("monto_neto_movimientos"));
                        cajaAbierta.AbreUsuario = reader.IsDBNull(reader.GetOrdinal("abre_usuario")) ? string.Empty : (string)reader["abre_usuario"];
                        cajaAbierta.CierraUsuario = reader.IsDBNull(reader.GetOrdinal("cierra_usuario")) ? string.Empty : (string)reader["cierra_usuario"];
                        cajaAbierta.MontoVentasTotal = reader.IsDBNull(reader.GetOrdinal("monto_ventas_total")) ? SqlMoney.Zero : reader.GetSqlMoney(reader.GetOrdinal("monto_ventas_total"));


                        // Agrego a la lista de cajas abiertas
                        listaCajasAbiertas.Add(cajaAbierta);
                    }
                }

                if (listaCajasAbiertas.Count > 1)
                {
                    MessageBox.Show("Hay más de 1 caja abierta. Dante le erró :'(");
                    return null;
                }
                if (listaCajasAbiertas.Count == 1)
                {
                    return listaCajasAbiertas[0];
                }
                if (listaCajasAbiertas.Count == 0)
                {
                    // NO HAY CAJAS ABIERTAS...
                    //MessageBox.Show("No hay cajas abiertas");
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

        public Entidades.Caja CrearAbrirCaja(string usrActual, DateTime fecha_caja, decimal saldo_inicial, string descripcion)
        {
            Entidades.Caja caja = null;

            // Crear conexión
            SqlConnection con = CrearConexion();

            try
            {
                // Abrir la conexión
                con.Open();

                // Crear SqlCommand
                SqlCommand cmd = new SqlCommand("CrearAbrirCaja", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros al comando
                cmd.Parameters.AddWithValue("@abre_usuario", usrActual);
                cmd.Parameters.AddWithValue("@fecha_caja", fecha_caja);
                cmd.Parameters.AddWithValue("@saldo_inicial", saldo_inicial);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);

                // Ejecutar el stored procedure y obtener el resultado en un SqlDataReader
                SqlDataReader reader = cmd.ExecuteReader();

                // Verificar si se obtuvieron filas del resultado
                if (reader.HasRows)
                {
                    // Leer el resultado y asignarlo a la variable caja
                    reader.Read();
                    caja = new Entidades.Caja
                    {
                        ID = (int)reader["id"],
                        Descripcion = reader.IsDBNull(reader.GetOrdinal("descripcion")) ? string.Empty : reader.GetString(reader.GetOrdinal("descripcion")),
                        FechaCaja = (DateTime)reader["fecha_caja"],
                        FechaApertura = (DateTime)reader["fecha_apertura"],
                        FechaCierre = reader.IsDBNull(reader.GetOrdinal("fecha_cierre")) ? DateTime.MinValue : (DateTime)reader["fecha_cierre"],
                        SaldoInicial = reader.IsDBNull(reader.GetOrdinal("saldo_inicial")) ? decimal.Zero : (decimal)reader["saldo_inicial"],
                        SaldoFinal = reader.IsDBNull(reader.GetOrdinal("saldo_final")) ? decimal.Zero : (decimal)reader["saldo_final"],
                        MontoNetoMovimientos = reader.IsDBNull(reader.GetOrdinal("monto_neto_movimientos")) ? decimal.Zero : (decimal)reader["monto_neto_movimientos"],
                        AbreUsuario = reader.IsDBNull(reader.GetOrdinal("abre_usuario")) ? string.Empty : (string)reader["abre_usuario"],
                        CierraUsuario = reader.IsDBNull(reader.GetOrdinal("cierra_usuario")) ? string.Empty : (string)reader["cierra_usuario"],
                        MontoVentasTotal = reader.IsDBNull(reader.GetOrdinal("monto_ventas_total")) ? decimal.Zero : (decimal)reader["monto_ventas_total"]

                    };
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Manejar la excepción o mostrar un mensaje de error
                MessageBox.Show("Error al crear nueva caja: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión después de usarla
                con.Close();
            }

            return caja;
        }

        public void CerrarCaja(int caja_id, SqlMoney saldo_final, string cierra_usuario)
        {
            // Crear conexión
            SqlConnection con = CrearConexion();

            try
            {
                // Abrir la conexión
                con.Open();

                // Crear SqlCommand
                SqlCommand cmd = new SqlCommand("CerrarCaja", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros al comando
                cmd.Parameters.AddWithValue("@caja_id", caja_id);
                cmd.Parameters.AddWithValue("@saldo_final", saldo_final);
                cmd.Parameters.AddWithValue("@cierra_usuario", cierra_usuario);

                // Ejecutar el stored procedure
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar la excepción o mostrar un mensaje de error
                MessageBox.Show("Error al cerrar la caja: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión después de usarla
                con.Close();
            }
        }

        //public void RegistrarVenta(Venta ventaNueva)
        //{

        //    //Crear Conexion y Abrirla
        //    SqlConnection Con = CrearConexion();

        //    // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
        //    SqlCommand Comando = new SqlCommand();
        //    Comando.Connection = Con;
        //    Comando.CommandType = CommandType.Text;

        //    Comando.CommandText = "INSERT INTO [Ventas] ([numVenta], [fechaHora], [tipoPago], [total], [dniCliente],[descuento],[usuario], [tipooperacion] ) VALUES (@NUMVENTA, @FECHAHORA, @TIPOPAGO, @TOTAL, @DNICLIENTE, @DESCUENTO, @USUARIO, @TIPOOPERACION)";
        //    Comando.Parameters.Add(new SqlParameter("@NUMVENTA", SqlDbType.Int));
        //    Comando.Parameters["@NUMVENTA"].Value = ventaNueva.NumeroVenta;
        //    Comando.Parameters.Add(new SqlParameter("@FECHAHORA", SqlDbType.DateTime));
        //    Comando.Parameters["@FECHAHORA"].Value = ventaNueva.FechaHora;
        //    Comando.Parameters.Add(new SqlParameter("@TIPOPAGO", SqlDbType.NVarChar));
        //    Comando.Parameters["@TIPOPAGO"].Value = ventaNueva.TipoPago;
        //    Comando.Parameters.Add(new SqlParameter("@TOTAL", SqlDbType.Money));
        //    Comando.Parameters["@TOTAL"].Value = ventaNueva.Total;
        //    Comando.Parameters.Add(new SqlParameter("@DNICLIENTE", SqlDbType.NVarChar));
        //    Comando.Parameters["@DNICLIENTE"].Value = ventaNueva.DniCliente;
        //    Comando.Parameters.Add(new SqlParameter("@DESCUENTO", SqlDbType.Int));
        //    Comando.Parameters["@DESCUENTO"].Value = ventaNueva.Descuento;
        //    Comando.Parameters.Add(new SqlParameter("@USUARIO", SqlDbType.NVarChar));
        //    Comando.Parameters["@USUARIO"].Value = ventaNueva.Usuario;
        //    Comando.Parameters.Add(new SqlParameter("@TIPOOPERACION", SqlDbType.NVarChar));
        //    Comando.Parameters["@TIPOOPERACION"].Value = ventaNueva.TipoOperacion;

        //    //Ejecuta el comando INSERT
        //    Comando.Connection.Open();
        //    Comando.ExecuteNonQuery();
        //    Comando.Connection.Close();


        //}

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

        //public List<Venta> GetAll()
        //{
        //    List<Venta> ListaVentas = new List<Venta>();
        //    //Crear Conexion y Abrirla
        //    SqlConnection Con = CrearConexion();

        //    // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
        //    SqlCommand Comando = new SqlCommand("SELECT * FROM Ventas ORDER BY Ventas.numVenta, Ventas.TipoOperacion DESC", Con);
        //    try
        //    {
        //        Comando.Connection.Open();
        //        SqlDataReader drVentas = Comando.ExecuteReader();

        //        while (drVentas.Read())
        //        {
        //            Venta vta = new Venta();

        //            vta.NumeroVenta = (int)drVentas["numventa"];
        //            vta.FechaHora = (DateTime)drVentas["fechahora"];
        //            vta.Descuento = (decimal)drVentas["descuento"];
        //            vta.DniCliente = (string)drVentas["dnicliente"];
        //            vta.Usuario = (string)drVentas["usuario"];
        //            vta.TipoPago = (string)drVentas["tipopago"];
        //            vta.Total = (decimal)drVentas["total"];
        //            vta.TipoOperacion = (string)drVentas["tipooperacion"];


        //            ListaVentas.Add(vta);
        //        }
        //        drVentas.Close();

        //    }
        //    catch (Exception Ex)
        //    {
        //        Exception ExcepcionManejada = new Exception("Error al recuperar lista de Ventas", Ex);
        //        throw ExcepcionManejada;
        //    }
        //    finally
        //    {
        //        Comando.Connection.Close();
        //    }



        //    return ListaVentas;




        //}

        //public int getUltNroVenta()
        //{

        //    int nroUltVta = 0;

        //    //Crear Conexion y Abrirla
        //    SqlConnection Con = CrearConexion();

        //    // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
        //    SqlCommand Comando = new SqlCommand(" select CASE WHEN MAX(numVenta) IS NULL THEN 0 ELSE MAX(numVenta) END AS NROULTIMAVENTA FROM Ventas", Con);
        //    try
        //    {
        //        Comando.Connection.Open();
        //        SqlDataReader drVentas = Comando.ExecuteReader();
               
        //        drVentas.Read();
                
        //         nroUltVta = (int)drVentas["NROULTIMAVENTA"]; 
               
               

        //        drVentas.Close();

        //    }
        //    catch (Exception Ex)
        //    {
        //        Exception ExcepcionManejada = new Exception("Error al recuperar el Ultimo número de venta.", Ex);
        //        throw ExcepcionManejada;
        //    }
        //    finally
        //    {
        //        Comando.Connection.Close();
        //    }



        //    return nroUltVta;


        //}

        //public int getStatusVenta(int nroVenta)
        //{

        //    int tieneDevolucion;

        //    //Crear Conexion y Abrirla
        //    SqlConnection Con = CrearConexion();

        //    // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
        //    SqlCommand Comando = new SqlCommand("SELECT COUNT(*) FROM Ventas WHERE TipoOperacion = 'D' AND numVenta = " + nroVenta, Con);
        //    Comando.CommandType = CommandType.Text;
        //    try
        //    {
        //        Comando.Connection.Open();
        //        tieneDevolucion = (int)Comando.ExecuteScalar();
        //        Comando.Connection.Close();

        //    }
        //    catch (Exception Ex)
        //    {
        //        Exception ExcepcionManejada = new Exception("Error al recuperar el Ultimo número de venta.", Ex);
        //        throw ExcepcionManejada;
        //    }
        //    finally
        //    {
        //        Comando.Connection.Close();
        //    }



        //    return tieneDevolucion;


        //}

        //public List<Entidades.Venta> Busqueda(string texto)
        //{

        //    List<Entidades.Venta> ListaVentas = new List<Entidades.Venta>();
        //    //Crear Conexion y Abrirla
        //    SqlConnection Con = CrearConexion();

        //    // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
        //    SqlCommand Comando = new SqlCommand("SELECT * FROM Ventas WHERE Ventas.tipoPago like @texto OR Ventas.usuario like @texto OR Ventas.dniCliente like @texto;", Con);
        //    Comando.Parameters.Add(new SqlParameter("@texto", SqlDbType.NVarChar));
        //    Comando.Parameters["@texto"].Value = texto + '%';
        //    try
        //    {
        //        Comando.Connection.Open();
        //        SqlDataReader drVentas = Comando.ExecuteReader();

        //        while (drVentas.Read())
        //        {
        //            Entidades.Venta ventaActual = new Entidades.Venta();

        //            ventaActual.Descuento = (decimal)drVentas["descuento"];
        //            ventaActual.DniCliente = (string)drVentas["dniCliente"];
        //            ventaActual.FechaHora = (DateTime)drVentas["fechaHora"];
        //            ventaActual.NumeroVenta = (int)drVentas["numVenta"];
        //            ventaActual.Total = (decimal)drVentas["total"];
        //            ventaActual.TipoPago = (string)drVentas["tipoPago"];
        //            ventaActual.Usuario = (string)drVentas["usuario"];
        //            ventaActual.TipoOperacion = (string)drVentas["tipooperacion"];

        //            ListaVentas.Add(ventaActual);
        //        }
        //        drVentas.Close();

        //    }
        //    catch (Exception Ex)
        //    {
        //        Exception ExcepcionManejada = new Exception("Error al recuperar lista de Ventas", Ex);
        //        throw ExcepcionManejada;
        //    }
        //    finally
        //    {
        //        Comando.Connection.Close();
        //    }



        //    return ListaVentas;




        //}

        //public List<Entidades.Venta> BusquedaFechaDesde(DateTime fechaDesde)
        //{
        //    DateTime fechaDsd = new DateTime(fechaDesde.Year, fechaDesde.Month, fechaDesde.Day);
        //    List<Entidades.Venta> ListaVentas = new List<Entidades.Venta>();
        //    //Crear Conexion y Abrirla
        //    SqlConnection Con = CrearConexion();

        //    // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
        //    SqlCommand Comando = new SqlCommand("SELECT * FROM Ventas WHERE Ventas.fechaHora >= @fechaDesde;", Con);
        //    Comando.Parameters.Add(new SqlParameter("@fechaDesde", SqlDbType.DateTime));
        //    Comando.Parameters["@fechaDesde"].Value = fechaDsd;
        //    try
        //    {
        //        Comando.Connection.Open();
        //        SqlDataReader drVentas = Comando.ExecuteReader();

        //        while (drVentas.Read())
        //        {
        //            Entidades.Venta ventaActual = new Entidades.Venta();

        //            ventaActual.Descuento = (decimal)drVentas["descuento"];
        //            ventaActual.DniCliente = (string)drVentas["dniCliente"];
        //            ventaActual.FechaHora = (DateTime)drVentas["fechaHora"];
        //            ventaActual.NumeroVenta = (int)drVentas["numVenta"];
        //            ventaActual.Total = (decimal)drVentas["total"];
        //            ventaActual.TipoPago = (string)drVentas["tipoPago"];
        //            ventaActual.Usuario = (string)drVentas["usuario"];

        //            ventaActual.TipoOperacion = (string)drVentas["tipooperacion"];

        //            ListaVentas.Add(ventaActual);
        //        }
        //        drVentas.Close();

        //    }
        //    catch (Exception Ex)
        //    {
        //        Exception ExcepcionManejada = new Exception("Error al recuperar lista de Ventas", Ex);
        //        throw ExcepcionManejada;
        //    }
        //    finally
        //    {
        //        Comando.Connection.Close();
        //    }



        //    return ListaVentas;




        //}
        
        //public List<Entidades.Venta> BusquedaFechaDesde(DateTime fechaDesde, DateTime fechaHasta)
        //{

        //    DateTime fDesde = new DateTime(fechaDesde.Year, fechaDesde.Month, fechaDesde.Day);
        //    DateTime fHasta = new DateTime(fechaHasta.Year, fechaHasta.Month, fechaHasta.Day);
        //    List<Entidades.Venta> ListaVentas = new List<Entidades.Venta>();
        //    //Crear Conexion y Abrirla
        //    SqlConnection Con = CrearConexion();

        //    // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
        //    SqlCommand Comando = new SqlCommand("SELECT * FROM Ventas WHERE Ventas.fechaHora BETWEEN @fechaDesde AND @fechaHasta;", Con);
        //    Comando.Parameters.Add(new SqlParameter("@fechaDesde", SqlDbType.DateTime));
        //    Comando.Parameters["@fechaDesde"].Value = fDesde;
        //    Comando.Parameters.Add(new SqlParameter("@fechaHasta", SqlDbType.DateTime));
        //    Comando.Parameters["@fechaHasta"].Value = fHasta;

        //    try
        //    {
        //        Comando.Connection.Open();
        //        SqlDataReader drVentas = Comando.ExecuteReader();

        //        while (drVentas.Read())
        //        {
        //            Entidades.Venta ventaActual = new Entidades.Venta();

        //            ventaActual.Descuento = (decimal)drVentas["descuento"];
        //            ventaActual.DniCliente = (string)drVentas["dniCliente"];
        //            ventaActual.FechaHora = (DateTime)drVentas["fechaHora"];
        //            ventaActual.NumeroVenta = (int)drVentas["numVenta"];
        //            ventaActual.Total = (decimal)drVentas["total"];
        //            ventaActual.TipoPago = (string)drVentas["tipoPago"];
        //            ventaActual.Usuario = (string)drVentas["usuario"];

        //            ventaActual.TipoOperacion = (string)drVentas["tipooperacion"];

        //            ListaVentas.Add(ventaActual);
        //        }
        //        drVentas.Close();

        //    }
        //    catch (Exception Ex)
        //    {
        //        Exception ExcepcionManejada = new Exception("Error al recuperar lista de Ventas", Ex);
        //        throw ExcepcionManejada;
        //    }
        //    finally
        //    {
        //        Comando.Connection.Close();
        //    }



        //    return ListaVentas;




        //}

    }
}
