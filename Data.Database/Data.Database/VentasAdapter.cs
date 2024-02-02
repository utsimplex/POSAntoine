using System;
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

            Comando.CommandText = "INSERT INTO [Ventas] ([numVenta], [fechaHora], [tipoPago], [total], [descuento],[usuario], [tipooperacion], [caja_id],[Neto]"+
           ",[Iva]," +
           "[TipoDocumentoCliente],[NumeroDocumentoCliente],[NombreCliente],[DireccionCliente],[SituacionFiscalCliente],[Pagado],[Monto_pagado],TipoComprobante" +
           ") " +
                "VALUES (@NUMVENTA, @FECHAHORA, @TIPOPAGO, @TOTAL, @DESCUENTO, @USUARIO, @TIPOOPERACION, @CAJA_ID,@NETO,@IVA," +
                "@TIPODOCUMENTOCLIENTE,@NUMERODOCUMENTOCLIENTE,@NOMBRECLIENTE,@DIRECCIONCLIENTE,@SITUACIONFISCALCLIENTE,@pagado,@monto_pagado,@tipoComprobante"+
                ")";
            Comando.Parameters.Add(new SqlParameter("@NUMVENTA", SqlDbType.Int));
            Comando.Parameters["@NUMVENTA"].Value = ventaNueva.NumeroVenta;
            Comando.Parameters.Add(new SqlParameter("@FECHAHORA", SqlDbType.DateTime));
            Comando.Parameters["@FECHAHORA"].Value = ventaNueva.FechaHora;
            Comando.Parameters.Add(new SqlParameter("@TIPOPAGO", SqlDbType.NVarChar));
            Comando.Parameters["@TIPOPAGO"].Value = ventaNueva.TipoPago;
            Comando.Parameters.Add(new SqlParameter("@TOTAL", SqlDbType.Decimal));
            Comando.Parameters["@TOTAL"].Value = ventaNueva.Total;
            //Comando.Parameters.Add(new SqlParameter("@DNICLIENTE", SqlDbType.NVarChar));
            //Comando.Parameters["@DNICLIENTE"].Value = ventaNueva.DniCliente;
            Comando.Parameters.Add(new SqlParameter("@DESCUENTO", SqlDbType.Decimal));
            Comando.Parameters["@DESCUENTO"].Value = ventaNueva.Descuento;
            Comando.Parameters.Add(new SqlParameter("@USUARIO", SqlDbType.NVarChar));
            Comando.Parameters["@USUARIO"].Value = ventaNueva.Usuario;
            Comando.Parameters.Add(new SqlParameter("@TIPOOPERACION", SqlDbType.NVarChar));
            Comando.Parameters["@TIPOOPERACION"].Value = ventaNueva.TipoOperacion;
            Comando.Parameters.Add(new SqlParameter("@CAJA_ID", SqlDbType.Int));
            Comando.Parameters["@CAJA_ID"].Value = caja.ID;
            Comando.Parameters.Add(new SqlParameter("@NETO", SqlDbType.Decimal));
            Comando.Parameters["@NETO"].Value = ventaNueva.Neto;
            Comando.Parameters.Add(new SqlParameter("@IVA", SqlDbType.Decimal));
            Comando.Parameters["@IVA"].Value = ventaNueva.Iva;
            Comando.Parameters.Add(new SqlParameter("@TIPODOCUMENTOCLIENTE", SqlDbType.Int));
            Comando.Parameters["@TIPODOCUMENTOCLIENTE"].Value = ventaNueva.TipoDocumentoCliente;
            Comando.Parameters.Add(new SqlParameter("@NUMERODOCUMENTOCLIENTE", SqlDbType.BigInt));
            Comando.Parameters["@NUMERODOCUMENTOCLIENTE"].Value = ventaNueva.NumeroDocumentoCliente;
            Comando.Parameters.Add(new SqlParameter("@NOMBRECLIENTE", SqlDbType.NVarChar));
            Comando.Parameters["@NOMBRECLIENTE"].Value = ventaNueva.NombreCliente;
            Comando.Parameters.Add(new SqlParameter("@DIRECCIONCLIENTE", SqlDbType.NVarChar));
            Comando.Parameters["@DIRECCIONCLIENTE"].Value = ventaNueva.DireccionCliente;
            Comando.Parameters.Add(new SqlParameter("@SITUACIONFISCALCLIENTE", SqlDbType.Int));
            Comando.Parameters["@SITUACIONFISCALCLIENTE"].Value = ventaNueva.SituacionFiscalCliente;
            Comando.Parameters.Add(new SqlParameter("@Pagado", SqlDbType.Bit));
            Comando.Parameters["@Pagado"].Value = ventaNueva.Pagado;
            Comando.Parameters.Add(new SqlParameter("@monto_pagado", SqlDbType.Decimal));
            Comando.Parameters["@monto_pagado"].Value = ventaNueva.MontoPagado;
            Comando.Parameters.Add(new SqlParameter("@Tipocomprobante", SqlDbType.Int));
            Comando.Parameters["@Tipocomprobante"].Value = ventaNueva.TipoComprobante;
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

            Comando.CommandText = "UPDATE [VENTAs] SET TIPOCOMPROBANTE=@TIPOCOMPROBANTE,PUNTODEVENTA=@PUNTODEVENTA,TICKETFISCAL=@TICKETFISCAL, CAE=@CAE, VENCIMIENTOCAE=@VENCIMIENTOCAE,"+
                " TIPODOCUMENTOCLIENTE=@TIPODOCUMENTOCLIENTE, NUMERODOCUMENTOCLIENTE=@NUMERODOCUMENTOCLIENTE, NOMBRECLIENTE=@NOMBRECLIENTE, DIRECCIONCLIENTE=@DIRECCIONCLIENTE, SITUACIONFISCALCLIENTE= @SITUACIONFISCALCLIENTE,CUITEMISOR=@CUITEMISOR WHERE numVenta=@numVenta";
            Comando.Parameters.Add(new SqlParameter("@TIPOCOMPROBANTE", SqlDbType.Int));
            Comando.Parameters["@TIPOCOMPROBANTE"].Value = VentaActual.TipoComprobante;
            Comando.Parameters.Add(new SqlParameter("@PUNTODEVENTA", SqlDbType.Int));
            Comando.Parameters["@PUNTODEVENTA"].Value = VentaActual.PuntoDeVenta;
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
            Comando.Parameters.Add(new SqlParameter("@DIRECCIONCLIENTE", SqlDbType.NVarChar));
            Comando.Parameters["@DIRECCIONCLIENTE"].Value = VentaActual.DireccionCliente;
            Comando.Parameters.Add(new SqlParameter("@SITUACIONFISCALCLIENTE", SqlDbType.Int));
            Comando.Parameters["@SITUACIONFISCALCLIENTE"].Value = VentaActual.SituacionFiscalCliente;
            Comando.Parameters.Add(new SqlParameter("@numVenta", SqlDbType.Int));
            Comando.Parameters["@numVenta"].Value = VentaActual.NumeroVenta;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }
        public void ActualizarMedioDePago(Venta VentaActual)
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE [VENTAs] SET tipoPago=@TipoPago WHERE numVenta=@numVenta";
            Comando.Parameters.Add(new SqlParameter("@TIPOPAGO", SqlDbType.NVarChar));
            Comando.Parameters["@TIPOPAGO"].Value = VentaActual.TipoPago;
            Comando.Parameters.Add(new SqlParameter("@numVenta", SqlDbType.Int));
            Comando.Parameters["@numVenta"].Value = VentaActual.NumeroVenta;


            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public void ActualizarPago(int NumVenta, decimal Monto, bool Pagado)
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE [VENTAs] SET pagado=@pagado,monto_pagado=monto_pagado+@monto_pagado WHERE numVenta=@numVenta";
            Comando.Parameters.Add(new SqlParameter("@pagado", SqlDbType.Bit));
            Comando.Parameters["@pagado"].Value = Pagado;
            Comando.Parameters.Add(new SqlParameter("@monto_pagado", SqlDbType.Decimal));
            Comando.Parameters["@monto_pagado"].Value = Monto;
            Comando.Parameters.Add(new SqlParameter("@numVenta", SqlDbType.Int));
            Comando.Parameters["@numVenta"].Value = NumVenta;


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
            SqlCommand Comando = new SqlCommand("SELECT * FROM Ventas ORDER BY Ventas.numVenta DESC, Ventas.TipoOperacion DESC", Con);
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
                    //vta.DniCliente = (string)drVentas["dnicliente"];
                    vta.CajaId = (drVentas["caja_id"] != DBNull.Value) ? (int)drVentas["caja_id"] : (int?)null;
                    vta.Usuario = (string)drVentas["usuario"];
                    vta.TipoPago = (string)drVentas["tipopago"];
                    vta.Total = (decimal)drVentas["total"];
                    vta.TipoOperacion = (string)drVentas["tipooperacion"];
                    vta.Pagado = (bool)drVentas["pagado"];
                    vta.MontoPagado = drVentas["monto_pagado"] != DBNull.Value ? (decimal)drVentas["monto_pagado"] : (decimal)drVentas["total"];
                    //FALTAN TRAER DATOS FISCALES
                    vta.TipoComprobante = (drVentas["TIPOCOMPROBANTE"]!=DBNull.Value)?(int)drVentas["TIPOCOMPROBANTE"]:(int?)null;
                    vta.PuntoDeVenta = drVentas["PUNTODEVENTA"]!= DBNull.Value? (int)drVentas["PUNTODEVENTA"]:(int?)null;
                    vta.NumeroTicketFiscal = drVentas["TICKETFISCAL"]!= DBNull.Value? (string)drVentas["TICKETFISCAL"]:null;
                    vta.CAE = drVentas["CAE"] != DBNull.Value ? (string)drVentas["CAE"] : null; 
                    vta.VencimientoCAE = drVentas["VENCIMIENTOCAE"]!=DBNull.Value? (DateTime)drVentas["VENCIMIENTOCAE"]:(DateTime?)null;
                    vta.TipoDocumentoCliente = drVentas["TIPODOCUMENTOCLIENTE"]!=DBNull.Value?(int)drVentas["TIPODOCUMENTOCLIENTE"]:(int?)null;
                    vta.NumeroDocumentoCliente = drVentas["NUMERODOCUMENTOCLIENTE"] !=DBNull.Value?(long?)drVentas["NUMERODOCUMENTOCLIENTE"]:(long?)null;
                    vta.NombreCliente = drVentas["NOMBRECLIENTE"]!=DBNull.Value? (string)drVentas["NOMBRECLIENTE"]:null;
                    vta.CuitEmisor = drVentas["CUITEMISOR"] != DBNull.Value ? (long?)drVentas["CUITEMISOR"] : (long?)null;
                    vta.DireccionCliente = drVentas["DIRECCIONCLIENTE"] != DBNull.Value ? (string)drVentas["DIRECCIONCLIENTE"] : null;
                    vta.SituacionFiscalCliente = drVentas["SITUACIONFISCALCLIENTE"]!=DBNull.Value?(int)drVentas["SITUACIONFISCALCLIENTE"]:(int?)null;


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

        public Venta GetOne(int pNumeroVenta)
        {
            Venta VentaBuscada = new Venta();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM Ventas WHERE numVenta=@numVenta ORDER BY Ventas.numVenta, Ventas.TipoOperacion DESC", Con);

            Comando.Parameters.Add(new SqlParameter("@numVenta", SqlDbType.Int));
            Comando.Parameters["@numVenta"].Value = pNumeroVenta;
            try
            {
                Comando.Connection.Open();
                SqlDataReader drVentas = Comando.ExecuteReader();

                while (drVentas.Read())
                {
                    VentaBuscada.NumeroVenta = (int)drVentas["numventa"];
                    VentaBuscada.FechaHora = (DateTime)drVentas["fechahora"];
                    VentaBuscada.Descuento = (decimal)drVentas["descuento"];
                    VentaBuscada.CajaId = (drVentas["caja_id"] != DBNull.Value) ? (int)drVentas["caja_id"] : (int?)null;
                    //vta.DniCliente = (string)drVentas["dnicliente"];
                    VentaBuscada.Usuario = (string)drVentas["usuario"];
                    VentaBuscada.TipoPago = (string)drVentas["tipopago"];
                    VentaBuscada.Total = (decimal)drVentas["total"];
                    VentaBuscada.TipoOperacion = (string)drVentas["tipooperacion"];
                    VentaBuscada.Pagado = (bool)drVentas["pagado"];
                    VentaBuscada.MontoPagado = drVentas["monto_pagado"] != DBNull.Value ? (decimal)drVentas["monto_pagado"] : (decimal)drVentas["total"];
                    VentaBuscada.Neto = drVentas["Neto"] != DBNull.Value ? Math.Round(Convert.ToDouble((decimal)drVentas["Neto"]),2) : Math.Round(Convert.ToDouble((decimal)drVentas["total"]),2);
                    //VentaBuscada.Neto = Math.Round(Convert.ToDouble(drVentas["Neto"]),2);
                    VentaBuscada.Iva = drVentas["Iva"] != DBNull.Value ? Math.Round(Convert.ToDouble((decimal)drVentas["Iva"]), 2) : Math.Round(Convert.ToDouble(0), 2);
                    //VentaBuscada.Iva = Math.Round(Convert.ToDouble(drVentas["Iva"]),2);
                    //FALTAN TRAER DATOS FISCALES
                    VentaBuscada.TipoComprobante = (drVentas["TIPOCOMPROBANTE"] != DBNull.Value) ? (int)drVentas["TIPOCOMPROBANTE"] : (int?)null;
                    VentaBuscada.PuntoDeVenta = drVentas["PUNTODEVENTA"] != DBNull.Value ? (int)drVentas["PUNTODEVENTA"] : (int?)null;
                    VentaBuscada.NumeroTicketFiscal = drVentas["TICKETFISCAL"] != DBNull.Value ? (string)drVentas["TICKETFISCAL"] : null;
                    VentaBuscada.CAE = drVentas["CAE"] != DBNull.Value ? (string)drVentas["CAE"] : null;
                    VentaBuscada.VencimientoCAE = drVentas["VENCIMIENTOCAE"] != DBNull.Value ? (DateTime)drVentas["VENCIMIENTOCAE"] : (DateTime?)null;
                    VentaBuscada.TipoDocumentoCliente = drVentas["TIPODOCUMENTOCLIENTE"] != DBNull.Value ? (int)drVentas["TIPODOCUMENTOCLIENTE"] : (int?)null;
                    VentaBuscada.NumeroDocumentoCliente = drVentas["NUMERODOCUMENTOCLIENTE"] != DBNull.Value ? (long?)drVentas["NUMERODOCUMENTOCLIENTE"] : (long?)null;
                    VentaBuscada.NombreCliente = drVentas["NOMBRECLIENTE"] != DBNull.Value ? (string)drVentas["NOMBRECLIENTE"] : null;
                    VentaBuscada.CuitEmisor = drVentas["CUITEMISOR"] != DBNull.Value ? (long?)drVentas["CUITEMISOR"] : (long?)null;
                    VentaBuscada.DireccionCliente = drVentas["DIRECCIONCLIENTE"] != DBNull.Value ? (string)drVentas["DIRECCIONCLIENTE"] : null;
                    VentaBuscada.SituacionFiscalCliente = drVentas["SITUACIONFISCALCLIENTE"] != DBNull.Value ? (int)drVentas["SITUACIONFISCALCLIENTE"] : (int?)null;

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



            return VentaBuscada;




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

        public List<Venta> GetVentasCliente(long documentoCliente)
        {

            List<Entidades.Venta> ListaVentas = new List<Entidades.Venta>();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM Ventas WHERE Ventas.NumeroDocumentoCliente = @documentoCliente", Con);
            Comando.Parameters.Add(new SqlParameter("@documentoCliente", SqlDbType.BigInt));
            Comando.Parameters["@documentoCliente"].Value = documentoCliente;
            try
            {
                Comando.Connection.Open();
                SqlDataReader drVentas = Comando.ExecuteReader();

                while (drVentas.Read())
                {
                    Entidades.Venta ventaActual = new Entidades.Venta();

                    ventaActual.Descuento = (decimal)drVentas["descuento"];
                    ventaActual.NumeroDocumentoCliente = (long)drVentas["NumeroDocumentoCliente"];
                    ventaActual.FechaHora = (DateTime)drVentas["fechaHora"];
                    ventaActual.NumeroVenta = (int)drVentas["numVenta"];
                    ventaActual.CajaId = (drVentas["caja_id"] != DBNull.Value) ? (int)drVentas["caja_id"] : (int?)null;
                    ventaActual.Total = (decimal)drVentas["total"];
                    ventaActual.TipoPago = (string)drVentas["tipoPago"];
                    ventaActual.Usuario = (string)drVentas["usuario"];
                    ventaActual.TipoOperacion = (string)drVentas["tipooperacion"];
                    ventaActual.Pagado = drVentas["pagado"] != DBNull.Value ? (bool)drVentas["PAGADO"] : false;
                    ventaActual.MontoPagado = drVentas["monto_pagado"] != DBNull.Value ? (decimal)drVentas["monto_pagado"] : 0;  
                    ventaActual.NumeroDocumentoCliente = drVentas["numeroDocumentoCliente"] != DBNull.Value ? (long)Convert.ToDecimal(drVentas["numeroDocumentoCliente"]) : (long?)null;
                    ventaActual.TipoComprobante = (drVentas["TIPOCOMPROBANTE"] != DBNull.Value) ? (int)drVentas["TIPOCOMPROBANTE"] : (int?)null;
                    ventaActual.PuntoDeVenta = drVentas["PUNTODEVENTA"] != DBNull.Value ? (int)drVentas["PUNTODEVENTA"] : (int?)null;
                    ventaActual.NumeroTicketFiscal = drVentas["TICKETFISCAL"] != DBNull.Value ? (string)drVentas["TICKETFISCAL"] : null;
                    ventaActual.CAE = drVentas["CAE"] != DBNull.Value ? (string)drVentas["CAE"] : null;
                    ventaActual.VencimientoCAE = drVentas["VENCIMIENTOCAE"] != DBNull.Value ? (DateTime)drVentas["VENCIMIENTOCAE"] : (DateTime?)null;
                    ventaActual.TipoDocumentoCliente = drVentas["TIPODOCUMENTOCLIENTE"] != DBNull.Value ? (int)drVentas["TIPODOCUMENTOCLIENTE"] : (int?)null;
                    ventaActual.NumeroDocumentoCliente = drVentas["NUMERODOCUMENTOCLIENTE"] != DBNull.Value ? (long?)drVentas["NUMERODOCUMENTOCLIENTE"] : (long?)null;
                    ventaActual.NombreCliente = drVentas["NOMBRECLIENTE"] != DBNull.Value ? (string)drVentas["NOMBRECLIENTE"] : null;
                    ventaActual.CuitEmisor = drVentas["CUITEMISOR"] != DBNull.Value ? (long?)drVentas["CUITEMISOR"] : (long?)null;
                    ventaActual.DireccionCliente = drVentas["DIRECCIONCLIENTE"] != DBNull.Value ? (string)drVentas["DIRECCIONCLIENTE"] : null;
                    ventaActual.SituacionFiscalCliente = drVentas["SITUACIONFISCALCLIENTE"] != DBNull.Value ? (int)drVentas["SITUACIONFISCALCLIENTE"] : (int?)null;

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
        public List<Venta> GetAllPendientes()
        {

            List<Entidades.Venta> ListaVentas = new List<Entidades.Venta>();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM Ventas WHERE Ventas.Pagado = 0", Con);
            try
            {
                Comando.Connection.Open();
                SqlDataReader drVentas = Comando.ExecuteReader();

                while (drVentas.Read())
                {
                    Entidades.Venta ventaActual = new Entidades.Venta();

                    ventaActual.Descuento = (decimal)drVentas["descuento"];
                    ventaActual.NumeroDocumentoCliente = (long)drVentas["NumeroDocumentoCliente"];
                    ventaActual.FechaHora = (DateTime)drVentas["fechaHora"];
                    ventaActual.NumeroVenta = (int)drVentas["numVenta"];
                    ventaActual.CajaId = (drVentas["caja_id"] != DBNull.Value) ? (int)drVentas["caja_id"] : (int?)null;
                    ventaActual.Total = (decimal)drVentas["total"];
                    ventaActual.TipoPago = (string)drVentas["tipoPago"];
                    ventaActual.Usuario = (string)drVentas["usuario"];
                    ventaActual.TipoOperacion = (string)drVentas["tipooperacion"];
                    ventaActual.Pagado = drVentas["pagado"] != DBNull.Value ? (bool)drVentas["PAGADO"] : false;
                    ventaActual.MontoPagado = drVentas["monto_pagado"] != DBNull.Value ? (decimal)drVentas["monto_pagado"] : 0;
                    ventaActual.NumeroDocumentoCliente = drVentas["numeroDocumentoCliente"] != DBNull.Value ? (long)Convert.ToDecimal(drVentas["numeroDocumentoCliente"]) : (long?)null;
                    ventaActual.TipoComprobante = (drVentas["TIPOCOMPROBANTE"] != DBNull.Value) ? (int)drVentas["TIPOCOMPROBANTE"] : (int?)null;
                    ventaActual.PuntoDeVenta = drVentas["PUNTODEVENTA"] != DBNull.Value ? (int)drVentas["PUNTODEVENTA"] : (int?)null;
                    ventaActual.NumeroTicketFiscal = drVentas["TICKETFISCAL"] != DBNull.Value ? (string)drVentas["TICKETFISCAL"] : null;
                    ventaActual.CAE = drVentas["CAE"] != DBNull.Value ? (string)drVentas["CAE"] : null;
                    ventaActual.VencimientoCAE = drVentas["VENCIMIENTOCAE"] != DBNull.Value ? (DateTime)drVentas["VENCIMIENTOCAE"] : (DateTime?)null;
                    ventaActual.TipoDocumentoCliente = drVentas["TIPODOCUMENTOCLIENTE"] != DBNull.Value ? (int)drVentas["TIPODOCUMENTOCLIENTE"] : (int?)null;
                    ventaActual.NumeroDocumentoCliente = drVentas["NUMERODOCUMENTOCLIENTE"] != DBNull.Value ? (long?)drVentas["NUMERODOCUMENTOCLIENTE"] : (long?)null;
                    ventaActual.NombreCliente = drVentas["NOMBRECLIENTE"] != DBNull.Value ? (string)drVentas["NOMBRECLIENTE"] : null;
                    ventaActual.CuitEmisor = drVentas["CUITEMISOR"] != DBNull.Value ? (long?)drVentas["CUITEMISOR"] : (long?)null;
                    ventaActual.DireccionCliente = drVentas["DIRECCIONCLIENTE"] != DBNull.Value ? (string)drVentas["DIRECCIONCLIENTE"] : null;
                    ventaActual.SituacionFiscalCliente = drVentas["SITUACIONFISCALCLIENTE"] != DBNull.Value ? (int)drVentas["SITUACIONFISCALCLIENTE"] : (int?)null;

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
        public List<Entidades.Venta> Busqueda(string texto)
        {

            List<Entidades.Venta> ListaVentas = new List<Entidades.Venta>();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM Ventas WHERE Ventas.tipoPago like @texto OR Ventas.usuario like @texto OR Ventas.NumeroDocumentoCliente like @texto OR Ventas.numVenta like @texto", Con);
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
                    ventaActual.FechaHora = (DateTime)drVentas["fechaHora"];
                    ventaActual.NumeroVenta = (int)drVentas["numVenta"];
                    ventaActual.CajaId = (drVentas["caja_id"] != DBNull.Value) ? (int)drVentas["caja_id"] : (int?)null;
                    ventaActual.Total = (decimal)drVentas["total"];
                    ventaActual.TipoPago = (string)drVentas["tipoPago"];
                    ventaActual.Usuario = (string)drVentas["usuario"]; 
                    ventaActual.Pagado = drVentas["pagado"] != DBNull.Value ? (bool)drVentas["PAGADO"] : false;
                    ventaActual.MontoPagado = drVentas["monto_pagado"] != DBNull.Value ? (decimal)drVentas["monto_pagado"] : 0;
                    ventaActual.TipoOperacion = (string)drVentas["tipooperacion"];
                    ventaActual.NumeroDocumentoCliente = drVentas["numeroDocumentoCliente"] != DBNull.Value ? (long)Convert.ToDecimal(drVentas["numeroDocumentoCliente"]) : (long?)null;

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

                    //ventaActual.Descuento = (decimal)drVentas["descuento"];
                    //ventaActual.DniCliente = (string)drVentas["dniCliente"];
                    //ventaActual.CajaId = (int)drVentas["caja_id"];
                    //ventaActual.FechaHora = (DateTime)drVentas["fechaHora"];
                    //ventaActual.NumeroVenta = (int)drVentas["numVenta"];
                    //ventaActual.Total = (decimal)drVentas["total"];
                    //ventaActual.TipoPago = (string)drVentas["tipoPago"];
                    //ventaActual.Usuario = (string)drVentas["usuario"];

                    //ventaActual.TipoOperacion = (string)drVentas["tipooperacion"];

                    ventaActual.NumeroVenta = (int)drVentas["numventa"];
                    ventaActual.FechaHora = (DateTime)drVentas["fechahora"];
                    ventaActual.Descuento = (decimal)drVentas["descuento"];
                    ventaActual.CajaId = (drVentas["caja_id"] != DBNull.Value) ? (int)drVentas["caja_id"] : (int?)null;
                    //vta.DniCliente = (string)drVentas["dnicliente"];
                    ventaActual.Usuario = (string)drVentas["usuario"];
                    ventaActual.TipoPago = (string)drVentas["tipopago"];
                    ventaActual.Total = (decimal)drVentas["total"];
                    ventaActual.TipoOperacion = (string)drVentas["tipooperacion"];
                    ventaActual.Pagado = drVentas["pagado"] != DBNull.Value ? (bool)drVentas["PAGADO"] : false;
                    ventaActual.MontoPagado = drVentas["monto_pagado"] != DBNull.Value ? (decimal)drVentas["monto_pagado"] : 0;
                    //FALTAN TRAER DATOS FISCALES
                    ventaActual.TipoComprobante = (drVentas["TIPOCOMPROBANTE"] != DBNull.Value) ? (int)drVentas["TIPOCOMPROBANTE"] : (int?)null;
                    ventaActual.PuntoDeVenta = drVentas["PUNTODEVENTA"] != DBNull.Value ? (int)drVentas["PUNTODEVENTA"] : (int?)null;
                    ventaActual.NumeroTicketFiscal = drVentas["TICKETFISCAL"] != DBNull.Value ? (string)drVentas["TICKETFISCAL"] : null;
                    ventaActual.CAE = drVentas["CAE"] != DBNull.Value ? (string)drVentas["CAE"] : null;
                    ventaActual.VencimientoCAE = drVentas["VENCIMIENTOCAE"] != DBNull.Value ? (DateTime)drVentas["VENCIMIENTOCAE"] : (DateTime?)null;
                    ventaActual.TipoDocumentoCliente = drVentas["TIPODOCUMENTOCLIENTE"] != DBNull.Value ? (int)drVentas["TIPODOCUMENTOCLIENTE"] : (int?)null;
                    ventaActual.NumeroDocumentoCliente = drVentas["NUMERODOCUMENTOCLIENTE"] != DBNull.Value ? (long?)drVentas["NUMERODOCUMENTOCLIENTE"] : (long?)null;
                    ventaActual.NombreCliente = drVentas["NOMBRECLIENTE"] != DBNull.Value ? (string)drVentas["NOMBRECLIENTE"] : null;
                    ventaActual.CuitEmisor = drVentas["CUITEMISOR"] != DBNull.Value ? (long?)drVentas["CUITEMISOR"] : (long?)null;
                    ventaActual.DireccionCliente = drVentas["DIRECCIONCLIENTE"] != DBNull.Value ? (string)drVentas["DIRECCIONCLIENTE"] : null;
                    ventaActual.SituacionFiscalCliente = drVentas["SITUACIONFISCALCLIENTE"] != DBNull.Value ? (int)drVentas["SITUACIONFISCALCLIENTE"] : (int?)null;
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
            SqlCommand Comando = new SqlCommand("SELECT * FROM Ventas WHERE CAST(Ventas.fechaHora AS DATE) BETWEEN @fechaDesde AND @fechaHasta;", Con);
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
                    ventaActual.CajaId = (drVentas["caja_id"] != DBNull.Value) ? (int)drVentas["caja_id"] : (int?)null;
                    ventaActual.FechaHora = (DateTime)drVentas["fechaHora"];
                    ventaActual.NumeroVenta = (int)drVentas["numVenta"];
                    ventaActual.Total = (decimal)drVentas["total"];
                    ventaActual.TipoPago = (string)drVentas["tipoPago"];
                    ventaActual.Usuario = (string)drVentas["usuario"];

                    ventaActual.TipoOperacion = (string)drVentas["tipooperacion"];
                    ventaActual.Pagado = drVentas["pagado"] != DBNull.Value ? (bool)drVentas["PAGADO"] : false;
                    ventaActual.MontoPagado = drVentas["monto_pagado"] != DBNull.Value ? (decimal)drVentas["monto_pagado"] : 0;

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
