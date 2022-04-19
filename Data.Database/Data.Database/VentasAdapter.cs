using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlServerCe;

namespace Data.Database
{
    public class VentasAdapter : Adapter
    {
        public void RegistrarVenta(Venta ventaNueva)
        {

            //Crear Conexion y Abrirla
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO [Ventas] ([numVenta], [fechaHora], [tipoPago], [total], [dniCliente],[descuento],[usuario], [tipooperacion] ) VALUES (@NUMVENTA, @FECHAHORA, @TIPOPAGO, @TOTAL, @DNICLIENTE, @DESCUENTO, @USUARIO, @TIPOOPERACION)";
            Comando.Parameters.Add(new SqlCeParameter("@NUMVENTA", SqlDbType.Int));
            Comando.Parameters["@NUMVENTA"].Value = ventaNueva.NumeroVenta;
            Comando.Parameters.Add(new SqlCeParameter("@FECHAHORA", SqlDbType.DateTime));
            Comando.Parameters["@FECHAHORA"].Value = ventaNueva.FechaHora;
            Comando.Parameters.Add(new SqlCeParameter("@TIPOPAGO", SqlDbType.NVarChar));
            Comando.Parameters["@TIPOPAGO"].Value = ventaNueva.TipoPago;
            Comando.Parameters.Add(new SqlCeParameter("@TOTAL", SqlDbType.Money));
            Comando.Parameters["@TOTAL"].Value = ventaNueva.Total;
            Comando.Parameters.Add(new SqlCeParameter("@DNICLIENTE", SqlDbType.NVarChar));
            Comando.Parameters["@DNICLIENTE"].Value = ventaNueva.DniCliente;
            Comando.Parameters.Add(new SqlCeParameter("@DESCUENTO", SqlDbType.Int));
            Comando.Parameters["@DESCUENTO"].Value = ventaNueva.Descuento;
            Comando.Parameters.Add(new SqlCeParameter("@USUARIO", SqlDbType.NVarChar));
            Comando.Parameters["@USUARIO"].Value = ventaNueva.Usuario;
            Comando.Parameters.Add(new SqlCeParameter("@TIPOOPERACION", SqlDbType.NVarChar));
            Comando.Parameters["@TIPOOPERACION"].Value = ventaNueva.TipoOperacion;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();


        }

        //public void ModificarVenta(Venta ventaModificada)
        //{

        //    //Crear Conexion y Abrirla
        //    SqlCeConnection Con = CrearConexion();

        //    // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
        //    SqlCeCommand Comando = new SqlCeCommand();
        //    Comando.Connection = Con;
        //    Comando.CommandType = CommandType.Text;

        //    Comando.CommandText = "UPDATE [Ventas] SET [numVenta] = @NUMVENTA, [fechaHora] = @FECHAHORA, [tipoPago] = @TIPOPAGO, [total] = @TOTAL, [dniCliente] = @DNICLIENTE, [descuento] = @DESCUENTO, [TIPOOPERACION] = @TIPOOPERACION, [usuario] = @USUARIO WHERE [numVenta] = @NUMVENTA";
        //    Comando.Parameters.Add(new SqlCeParameter("@NUMVENTA", SqlDbType.Int));
        //    Comando.Parameters["@NUMVENTA"].Value = ventaModificada.NumeroVenta;
        //    Comando.Parameters.Add(new SqlCeParameter("@FECHAHORA", SqlDbType.DateTime));
        //    Comando.Parameters["@FECHAHORA"].Value = ventaModificada.FechaHora;
        //    Comando.Parameters.Add(new SqlCeParameter("@TIPOPAGO", SqlDbType.NVarChar));
        //    Comando.Parameters["@TIPOPAGO"].Value = ventaModificada.TipoPago;
        //    Comando.Parameters.Add(new SqlCeParameter("@TOTAL", SqlDbType.Money));
        //    Comando.Parameters["@TOTAL"].Value = ventaModificada.Total;
        //    Comando.Parameters.Add(new SqlCeParameter("@DNICLIENTE", SqlDbType.NVarChar));
        //    Comando.Parameters["@DNICLIENTE"].Value = ventaModificada.DniCliente;
        //    Comando.Parameters.Add(new SqlCeParameter("@DESCUENTO", SqlDbType.Int));
        //    Comando.Parameters["@DESCUENTO"].Value = ventaModificada.Descuento;
        //    Comando.Parameters.Add(new SqlCeParameter("@USUARIO", SqlDbType.NVarChar));
        //    Comando.Parameters["@USUARIO"].Value = ventaModificada.Usuario;
        //    Comando.Parameters.Add(new SqlCeParameter("@TIPOOPERACION", SqlDbType.NVarChar));
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
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Ventas ORDER BY Ventas.numVenta, Ventas.TipoOperacion DESC", Con);
            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drVentas = Comando.ExecuteReader();

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
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand(" select CASE WHEN MAX(numVenta) IS NULL THEN 0 ELSE MAX(numVenta) END AS NROULTIMAVENTA FROM Ventas", Con);
            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drVentas = Comando.ExecuteReader();
               
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
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT COUNT(*) FROM Ventas WHERE TipoOperacion = 'D' AND numVenta = " + nroVenta, Con);
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
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Ventas WHERE Ventas.tipoPago like @texto OR Ventas.usuario like @texto OR Ventas.dniCliente like @texto;", Con);
            Comando.Parameters.Add(new SqlCeParameter("@texto", SqlDbType.NVarChar));
            Comando.Parameters["@texto"].Value = texto + '%';
            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drVentas = Comando.ExecuteReader();

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
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Ventas WHERE Ventas.fechaHora >= @fechaDesde;", Con);
            Comando.Parameters.Add(new SqlCeParameter("@fechaDesde", SqlDbType.DateTime));
            Comando.Parameters["@fechaDesde"].Value = fechaDsd;
            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drVentas = Comando.ExecuteReader();

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
            SqlCeConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Ventas WHERE Ventas.fechaHora BETWEEN @fechaDesde AND @fechaHasta;", Con);
            Comando.Parameters.Add(new SqlCeParameter("@fechaDesde", SqlDbType.DateTime));
            Comando.Parameters["@fechaDesde"].Value = fDesde;
            Comando.Parameters.Add(new SqlCeParameter("@fechaHasta", SqlDbType.DateTime));
            Comando.Parameters["@fechaHasta"].Value = fHasta;

            try
            {
                Comando.Connection.Open();
                SqlCeDataReader drVentas = Comando.ExecuteReader();

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
