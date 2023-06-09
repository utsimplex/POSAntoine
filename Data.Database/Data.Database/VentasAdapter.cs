﻿using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data;
//using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace Data.Database
{
    public class VentasAdapter : Adapter
    {
        public void RegistrarVenta(Venta ventaNueva)
        {
            CajasAdapter DatosCajaAdapter = new CajasAdapter();
            Caja caja = DatosCajaAdapter.GetCajaAbierta();

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO [Ventas] ([numVenta], [fechaHora], [tipoPago], [total], [dniCliente],[descuento],[usuario], [tipooperacion], [caja_id],[Neto]"+
           ",[Iva],[TipoComprobante],[PuntoDeVenta],[CAE],[TICKETFISCAL],[VencimientoCAE],[TipoDocumentoCliente],[NumeroDocumentoCliente],[NombreCliente],[DireccionCliente],[SituacionFiscalCliente],[CUITEMISOR] ) " +
                "VALUES (@NUMVENTA, @FECHAHORA, @TIPOPAGO, @TOTAL, @DNICLIENTE, @DESCUENTO, @USUARIO, @TIPOOPERACION, @CAJA_ID,@IVA,@TIPOCOMPROBANTE@PUNTODEVENTA,@CAE,@TICKETFISCAL,@VENCIMIENTOCAE," +
                "@TIPODOCUMENTOCLIENTE,@NUMERODOCUMENTOCLIENTE,@NOMBRECLIENTE,@DIRECCIONCLIENTE,@SITUACIONFISCALCLIENTE,@CUITEMISOR)";
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
            Comando.Parameters.Add(new SqlParameter("@CAJA_ID", SqlDbType.Int));
            Comando.Parameters["@CAJA_ID"].Value = caja.ID;
            Comando.Parameters.Add(new SqlParameter("@IVA", SqlDbType.Decimal));
            Comando.Parameters["@IVA"].Value = ventaNueva.Iva;
            Comando.Parameters.Add(new SqlParameter("@NETO", SqlDbType.Int));
            Comando.Parameters["@NETO"].Value = ventaNueva.Neto;
            Comando.Parameters.Add(new SqlParameter("@TIPOCOMPROBANTE", SqlDbType.Int));
            Comando.Parameters["@TIPOCOMPROBANTE"].Value = ventaNueva.TipoComprobante;
            Comando.Parameters.Add(new SqlParameter("@PUNTODEVENTA", SqlDbType.Int));
            Comando.Parameters["@CAE"].Value = ventaNueva.PuntoDeVenta;
            Comando.Parameters.Add(new SqlParameter("@TICKETFISCAL", SqlDbType.VarChar));
            Comando.Parameters["@TICKETFISCAL"].Value = ventaNueva.NumeroTicketFiscal;
            Comando.Parameters.Add(new SqlParameter("@CAE", SqlDbType.NVarChar));
            Comando.Parameters["@CAE"].Value = ventaNueva.CAE;
            Comando.Parameters.Add(new SqlParameter("@VENCIMIENTOCAE", SqlDbType.DateTime));
            Comando.Parameters["@VENCIMIENTOCAE"].Value = ventaNueva.VencimientoCAE;
            Comando.Parameters.Add(new SqlParameter("@TIPODOCUMENTOCLIENTE", SqlDbType.Int));
            Comando.Parameters["@TIPODOCUMENTOCLIENTE"].Value = ventaNueva.TipoDocumentoCliente;
            Comando.Parameters.Add(new SqlParameter("@NUMERODOCUMENTOCLIENTE", SqlDbType.BigInt));
            Comando.Parameters["@NUMERODOCUMENTOCLIENTE"].Value = ventaNueva.NumeroDocumentoCliente;
            Comando.Parameters.Add(new SqlParameter("@NOMBRECLIENTE", SqlDbType.NVarChar));
            Comando.Parameters["@NOMBRECLIENTE"].Value = ventaNueva.NombreCliente;
            Comando.Parameters.Add(new SqlParameter("@CUITEMISOR", SqlDbType.BigInt));
            Comando.Parameters["@CUITEMISOR"].Value = ventaNueva.CuitEmisor;
            Comando.Parameters.Add(new SqlParameter("@DIRECCIONCLIENTE", SqlDbType.Int));
            Comando.Parameters["@DIRECCIONCLIENTE"].Value = ventaNueva.DireccionCliente;
            Comando.Parameters.Add(new SqlParameter("@SITUACIONFISCALCLIENTE", SqlDbType.Int));
            Comando.Parameters["@SITUACIONFISCALCLIENTE"].Value = ventaNueva.SituacionFiscalCliente;
            //@IVA,@TIPOCOMPROBANTE,@CAE,@VENCIMIENTOCAE,"+
            //    "@TIPODOCUMENTOCLIENTE,@NUMERODOCUMENTOCLIENTE,@NOMBRECLIENTE,@DIRECCIONCLIENTE,@SITUACIONFISCALCLIENTE,@CUITEMISOR
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
        public void ActualizarDatosFiscales(Venta VentaActual)
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE [VENTA] SET TIPOCOMPROBANTE=@TIPOCOMPROBANTE,PUNTODEVENTA=@PUNTODEVENTA,TICKETFISCAL=@TICKETFISCAL, CAE=@CAE, VENCIMIENTOCAE=@VENCIMIENTOCAE,"+
                " TIPODOCUMENTOCLIENTE=@TIPODOCUMENTOCLIENTE, NUMERODOCUMENTOCLIENTE=@NUMERODOCUMENTOCLIENTE, NOMBRECLIENTE=@NOMBRECLIENTE, DIRECCIONCLIENTE=@DIRECCIONCLIENTE, SITUACIONFISCALCLIENTE= @SITUACIONFISCALCLIENTE,CUITEMISOR=@CUITEMISOR WHERE ID=@ID";
            Comando.Parameters.Add(new SqlParameter("@TIPOCOMPROBANTE", SqlDbType.Int));
            Comando.Parameters["@TIPOCOMPROBANTE"].Value = VentaActual.TipoComprobante;
            Comando.Parameters.Add(new SqlParameter("@PUNTODEVENTA", SqlDbType.Int));
            Comando.Parameters["@CAE"].Value = VentaActual.PuntoDeVenta;
            Comando.Parameters.Add(new SqlParameter("@TICKETFISCAL", SqlDbType.VarChar));
            Comando.Parameters["@TICKETFISCAL"].Value = VentaActual.NumeroTicketFiscal;
            Comando.Parameters.Add(new SqlParameter("@CAE", SqlDbType.NVarChar));
            Comando.Parameters["@CAE"].Value = VentaActual.CAE;
            Comando.Parameters.Add(new SqlParameter("@VENCIMIENTOCAE", SqlDbType.DateTime));
            Comando.Parameters["@VENCIMIENTOCAE"].Value = VentaActual.VencimientoCAE;
            Comando.Parameters.Add(new SqlParameter("@TIPODOCUMENTOCLIENTE", SqlDbType.Int));
            Comando.Parameters["@TIPODOCUMENTOCLIENTE"].Value = VentaActual.TipoDocumentoCliente;
            Comando.Parameters.Add(new SqlParameter("@NUMERODOCUMENTOCLIENTE", SqlDbType.BigInt));
            Comando.Parameters["@NUMERODOCUMENTOCLIENTE"].Value = VentaActual.NumeroDocumentoCliente;
            Comando.Parameters.Add(new SqlParameter("@NOMBRECLIENTE", SqlDbType.NVarChar));
            Comando.Parameters["@NOMBRECLIENTE"].Value = VentaActual.NombreCliente;
            Comando.Parameters.Add(new SqlParameter("@CUITEMISOR", SqlDbType.BigInt));
            Comando.Parameters["@CUITEMISOR"].Value = VentaActual.CuitEmisor;
            Comando.Parameters.Add(new SqlParameter("@DIRECCIONCLIENTE", SqlDbType.Int));
            Comando.Parameters["@DIRECCIONCLIENTE"].Value = VentaActual.DireccionCliente;
            Comando.Parameters.Add(new SqlParameter("@SITUACIONFISCALCLIENTE", SqlDbType.Int));
            Comando.Parameters["@SITUACIONFISCALCLIENTE"].Value = VentaActual.SituacionFiscalCliente;


            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }
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
                    //FALTAN TRAER DATOS FISCALES


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
