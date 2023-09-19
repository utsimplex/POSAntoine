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
    public class CajasAdapter : Adapter
    {


        public Entidades.Caja caja { get; set; }

        /// <summary>
        /// Obtiene la caja abierta desde la base de datos.
        /// </summary>
        /// <returns>
        /// Una instancia de la entidad Caja con los datos de la caja abierta.
        /// </returns>
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
                        cajaAbierta.FechaCierre = reader.IsDBNull(reader.GetOrdinal("fecha_cierre")) ? null : (DateTime?)reader["fecha_cierre"];
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
                    caja = listaCajasAbiertas[0];
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


        /// <summary>
        /// Obtiene TODAS las cajas desde la base de datos.
        /// </summary>
        /// <returns>
        /// Una instancia de la entidad Caja con los datos de la caja abierta.
        /// </returns>
        public BindingList<Entidades.Caja> GetCajas()
        {
            BindingList<Entidades.Caja> listaCajasAbiertas = new BindingList<Entidades.Caja>();

            // Crear conexión
            SqlConnection con = CrearConexion();

            try
            {
                // Abrir la conexión
                con.Open();

                // Crear SqlCommand
                // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                SqlCommand cmd = new SqlCommand("SELECT * FROM Cajas", con);
                cmd.CommandType = CommandType.Text;

                // Ejecutar el stored procedure y obtener el resultado en un SqlDataReader
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Crear una instancia de la entidad Caja y asignar los valores del resultado
                        Entidades.Caja cajaAbierta = new Entidades.Caja();

                        cajaAbierta.ID = (int)reader["id"];
                        cajaAbierta.Descripcion = reader.IsDBNull(reader.GetOrdinal("descripcion")) ? string.Empty : reader.GetString(reader.GetOrdinal("descripcion"));
                        cajaAbierta.FechaCaja = ((DateTime)reader["fecha_caja"]).Date;
                        cajaAbierta.FechaApertura = (DateTime)reader["fecha_apertura"];
                        cajaAbierta.FechaCierre = reader.IsDBNull(reader.GetOrdinal("fecha_cierre")) ? null : (DateTime?)reader["fecha_cierre"];
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

                return listaCajasAbiertas;
            }
            catch (Exception ex)
            {
                // Manejar la excepción o mostrar un mensaje de error
                MessageBox.Show("Error al obtener cajas: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión después de usarla
                con.Close();
            }

            return null;
        }


        /// <summary>
        /// Crea y abre una nueva caja con los parámetros especificados.
        /// </summary>
        /// <param name="usrActual">Usuario actual</param>
        /// <param name="fecha_caja">Fecha de la caja</param>
        /// <param name="saldo_inicial">Saldo inicial de la caja</param>
        /// <param name="descripcion">Descripción de la caja</param>
        /// <returns>Objeto Caja creado</returns>
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
                        FechaCierre = reader.IsDBNull(reader.GetOrdinal("fecha_cierre")) ? null : (DateTime?)reader["fecha_cierre"],
                        FechaModificacion = reader.IsDBNull(reader.GetOrdinal("fecha_modificacion")) ? null : (DateTime?)reader["fecha_modificacion"],
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
        
        /// <summary>
        /// Cierra una caja con el ID especificado, el saldo final y el usuario que la cierra.
        /// </summary>
        public void CerrarCaja(int caja_id, string cierra_usuario)
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
               cmd.Parameters.AddWithValue("@cierra_usuario", cierra_usuario);

                //// Agregar los parámetros de salida
                //SqlParameter pNetoMovimientos = new SqlParameter("@monto_neto_movimientos", SqlDbType.Money);
                //pNetoMovimientos.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(pNetoMovimientos);

                //SqlParameter pNetoVentas = new SqlParameter("@monto_total_ventas", SqlDbType.Money);
                //pNetoVentas.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(pNetoVentas);

                //SqlParameter pSaldoFinal = new SqlParameter("@saldo_final", SqlDbType.Money);
                //pSaldoFinal.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(pSaldoFinal);
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


        /// <summary>
        ///// Dado un ID de caja, obtiene el neto de los movimientos realizados
        ///// </summary>
        //public Decimal GetMovimientosNeto(int caja_id)
        //{
        //    // Crear conexión
        //    SqlConnection con = CrearConexion();

        //    try
        //    {
        //        // Abrir la conexión
        //        con.Open();

        //        // Crear SqlCommand
        //        SqlCommand cmd = new SqlCommand("GetNetoMovimientosCaja", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        // Agregar los parámetros al comando
        //        cmd.Parameters.AddWithValue("@pCaja_id", caja_id);

        //        // Ejecutar el stored procedure y almacenar el resultado en una variable decimal
        //        Decimal netoMovimientos = (Decimal)cmd.ExecuteScalar();

        //        // Devolver el resultado
        //        return netoMovimientos;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Manejar la excepción o mostrar un mensaje de error
        //        MessageBox.Show("Error al obtener valor neto de movimientos " + ex.Message);
        //        return 0; 
        //    }
        //    finally
        //    {
        //        // Cerrar la conexión después de usarla
        //        con.Close();
        //    }
        //}

         
        ///// <summary>
        ///// Dado un ID de caja, obtiene el neto de las ventas realizadas
        ///// </summary>
        //public Decimal GetVentasNeto(int caja_id)
        //{
        //    // Crear conexión
        //    SqlConnection con = CrearConexion();

        //    try
        //    {
        //        // Abrir la conexión
        //        con.Open();

        //        // Crear SqlCommand
        //        SqlCommand cmd = new SqlCommand("GetNetoVentasCaja", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        // Agregar los parámetros al comando
        //        cmd.Parameters.AddWithValue("@pCaja_id", caja_id);

        //        // Ejecutar el stored procedure y almacenar el resultado en una variable decimal
        //        Decimal netoVentas = (Decimal)cmd.ExecuteScalar();

        //        // Devolver el resultado
        //        return netoVentas;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Manejar la excepción o mostrar un mensaje de error
        //        MessageBox.Show("Error al obtener valor neto de ventas " + ex.Message);
        //        return 0;
        //    }
        //    finally
        //    {
        //        // Cerrar la conexión después de usarla
        //        con.Close();
        //    }
        //}

       
        /// <summary>
        /// Dado un ID de caja, obtiene el saldo final
        /// </summary>
        /// 
        public decimal GetSaldoFinal(int caja_id)
        {
            // Crear conexión
            using (SqlConnection con = CrearConexion())
            {
                try
                {
                    // Abrir la conexión
                    con.Open();

                    // Crear SqlCommand
                    using (SqlCommand cmd = new SqlCommand("GetSaldoFinalCaja", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros al comando
                        cmd.Parameters.AddWithValue("@pCaja_id", caja_id);

                        // Agregar parámetro de salida para el saldo final
                        SqlParameter saldoFinalParam = new SqlParameter("@saldo_final", SqlDbType.Money);
                        saldoFinalParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(saldoFinalParam);

                        // Ejecutar el stored procedure
                        cmd.ExecuteNonQuery();

                        // Obtener el saldo final del parámetro de salida
                        decimal saldoFinal = (decimal)saldoFinalParam.Value;

                        // Devolver el resultado
                        return saldoFinal;
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción o mostrar un mensaje de error
                    MessageBox.Show("Error al obtener saldo final: " + ex.Message);
                    return 0;
                }
            }
        }

      
        /// <summary>
        /// Dado un ID de caja, obtiene el efectivo a rendir
        /// </summary>

        public decimal GetRendirEfectivo(int caja_id)
        {
            // Crear conexión
            using (SqlConnection con = CrearConexion())
            {
                try
                {
                    // Abrir la conexión
                    con.Open();

                    // Crear SqlCommand
                    using (SqlCommand cmd = new SqlCommand("GetRendirEfectivo", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros al comando
                        cmd.Parameters.AddWithValue("@pCaja_id", caja_id);

                        // Agregar parámetro de salida para el efectivo a rendir
                        SqlParameter rendirEfectivoParam = new SqlParameter("@efectivo_a_rendir", SqlDbType.Money);
                        rendirEfectivoParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(rendirEfectivoParam);

                        // Ejecutar el stored procedure
                        cmd.ExecuteNonQuery();

                        // Obtener el efectivo a rendir del parámetro de salida
                        decimal rendirEfectivo = (decimal)rendirEfectivoParam.Value;

                        // Devolver el resultado
                        return rendirEfectivo;
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción o mostrar un mensaje de error
                    MessageBox.Show("Error al obtener efectivo a rendir: " + ex.Message);
                    return 0;
                }
            }
        }

        public decimal GetVentas(int caja_id)
        {
            // Crear conexión
            using (SqlConnection con = CrearConexion())
            {
                try
                {
                    // Abrir la conexión
                    con.Open();

                    // Crear SqlCommand
                    using (SqlCommand cmd = new SqlCommand("GetNetoVentasCaja", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros al comando
                        cmd.Parameters.AddWithValue("@pCaja_id", caja_id);

                        // Agregar parámetro de salida para el efectivo a rendir
                        SqlParameter ventas = new SqlParameter("@pNetoVentas", SqlDbType.Money);
                        ventas.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(ventas);

                        // Ejecutar el stored procedure
                        cmd.ExecuteNonQuery();

                        // Obtener el efectivo a rendir del parámetro de salida
                        decimal ventasPorCaja = (decimal)ventas.Value;

                        // Devolver el resultado
                        return ventasPorCaja;
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción o mostrar un mensaje de error
                    MessageBox.Show("Error al obtener efectivo a rendir: " + ex.Message);
                    return 0;
                }
            }
        }

        public bool GetEstadoCajaAbierta(int caja_id)
        {
            // Crear conexión
            using (SqlConnection con = CrearConexion())
            {
                try
                {
                    // Abrir la conexión
                    con.Open();

                    // Crear SqlCommand
                    using (SqlCommand cmd = new SqlCommand("GetCajaAbierta", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros al comando
                        cmd.Parameters.AddWithValue("@pCaja_id", caja_id);

                        // Agregar parámetro de salida para el efectivo a rendir
                        SqlParameter cajaAbierta = new SqlParameter("@cajaAbierta", SqlDbType.Bit);
                        cajaAbierta.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(cajaAbierta);

                        // Ejecutar el stored procedure
                        cmd.ExecuteNonQuery();

                        // Obtener el efectivo a rendir del parámetro de salida
                        bool CajaAbierta = (bool)cajaAbierta.Value;

                        // Devolver el resultado
                        return CajaAbierta;
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción o mostrar un mensaje de error
                    MessageBox.Show("Error al obtener el estado de la caja: " + ex.Message);
                    return false;
                }
            }
        }
        public bool CajaTieneMovimientos(int caja_id)
        {
            //Este metodo devuelve true si la caja tiene al menos una venta Y/O un movimiento
            // Crear conexión
            using (SqlConnection con = CrearConexion())
            {
                try
                {
                    // Abrir la conexión
                    con.Open();

                    // Crear SqlCommand
                    using (SqlCommand cmd = new SqlCommand("GetCajaTieneMovimientosVentas", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar los parámetros al comando
                        cmd.Parameters.AddWithValue("@pCaja_id", caja_id);

                        // Agregar parámetro de salida para el efectivo a rendir
                        SqlParameter cajaAbierta = new SqlParameter("@cajaConMovimientos", SqlDbType.Bit);
                        cajaAbierta.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(cajaAbierta);

                        // Ejecutar el stored procedure
                        cmd.ExecuteNonQuery();

                        // Obtener el efectivo a rendir del parámetro de salida
                        bool CajaAbierta = (bool)cajaAbierta.Value;

                        // Devolver el resultado
                        return CajaAbierta;
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción o mostrar un mensaje de error
                    MessageBox.Show("Error al obtener los movimientos de la caja: " + ex.Message);
                    return false;
                }
            }
        }

        public Caja ActualizaCaja(string usrActual, DateTime fecha_caja, decimal saldo_inicial, string descripcion,int idCaja)
        {
            Entidades.Caja caja = null;

            // Crear conexión
            SqlConnection con = CrearConexion();

            try
            {
                // Abrir la conexión
                con.Open();

                // Crear SqlCommand
                SqlCommand cmd = new SqlCommand("ModificarCaja", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros al comando
                cmd.Parameters.AddWithValue("@id_caja", idCaja);
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
                        FechaCierre = reader.IsDBNull(reader.GetOrdinal("fecha_cierre")) ? null : (DateTime?)reader["fecha_cierre"],
                        FechaModificacion = reader.IsDBNull(reader.GetOrdinal("fecha_modificacion")) ? null : (DateTime?)reader["fecha_modificacion"],
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
                MessageBox.Show("Error al modificar la caja "+idCaja.ToString()+". " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión después de usarla
                con.Close();
            }

            return caja;
        }
    }
}
