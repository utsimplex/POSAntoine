using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.Windows.Forms;
using Entidades;

namespace Data.Database
{
    public class InformeAdapter : Adapter
    {
        public List<ReporteCashflow> getCashFlow(DateTime pFechaDesde, DateTime pFechaHasta)
        {
            List<ReporteCashflow> ListaCashFlow = new List<ReporteCashflow>();
            // Crear conexión
            SqlConnection con = CrearConexion();

            try
            {
                // Abrir la conexión
                con.Open();

                // Crear SqlCommand
                SqlCommand cmd = new SqlCommand("ReporteCashflow", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros al comando
                cmd.Parameters.AddWithValue("@pFechaDesde", pFechaDesde.ToString("yyyyMMdd"));
                cmd.Parameters.AddWithValue("@pFechaHasta", pFechaHasta.ToString("yyyyMMdd"));

                // Ejecutar el stored procedure
                SqlDataReader drLineaCashFlow = cmd.ExecuteReader();

                while (drLineaCashFlow.Read())
                {
                    Entidades.ReporteCashflow lineaCashFlow = new Entidades.ReporteCashflow();

                    lineaCashFlow.ID = (int)drLineaCashFlow["Id"];
                    lineaCashFlow.Descripcion = (string)drLineaCashFlow["Descripcion"];
                    lineaCashFlow.FechaMovimiento = Convert.ToDateTime(drLineaCashFlow["Fecha_Movimiento"]);
                    lineaCashFlow.TipoMovimiento = (string)drLineaCashFlow["Tipo_Movimiento"];
                    lineaCashFlow.Subclasificacion = (string)drLineaCashFlow["Subclasificacion"];
                    lineaCashFlow.Monto = drLineaCashFlow["Monto"] != DBNull.Value ? Convert.ToDecimal(drLineaCashFlow["Monto"]) : 0;

                    ListaCashFlow.Add(lineaCashFlow);
                }
                drLineaCashFlow.Close();
            }
            catch (Exception ex)
            {
                // Manejar la excepción o mostrar un mensaje de error
                MessageBox.Show("Error al registrar un gasto: " + ex.Message);
                // Puedes lanzar una excepción personalizada si lo deseas
                // throw new Exception("Error al registrar movimiento de caja", ex);
            }
            finally
            {
                // Cerrar la conexión después de usarla
                con.Close();
            }
         return ListaCashFlow;
        }

        public ReporteVentasComisiones getVentaComisiones(DateTime pFechaDesde, DateTime pFechaHasta)
        {
            ReporteVentasComisiones VentaComisiones = new ReporteVentasComisiones();
            // Crear conexión
            SqlConnection con = CrearConexion();

            try
            {
                // Abrir la conexión
                con.Open();

                // Crear SqlCommand
                SqlCommand cmd = new SqlCommand("ReporteVentasComisiones", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros al comando
                cmd.Parameters.AddWithValue("@pFechaDesde", pFechaDesde.ToString("yyyyMMdd"));
                cmd.Parameters.AddWithValue("@pFechaHasta", pFechaHasta.ToString("yyyyMMdd"));

                // Ejecutar el stored procedure
                SqlDataReader drLineaCashFlow = cmd.ExecuteReader();

                while (drLineaCashFlow.Read())
                {
                    ReporteVentasComisiones ventaComisiones = new ReporteVentasComisiones();

                    ventaComisiones.FechaDesde = Convert.ToDateTime(drLineaCashFlow["Fecha_Desde"]);
                    ventaComisiones.FechaHasta = Convert.ToDateTime(drLineaCashFlow["Fecha_Hasta"]);
                    ventaComisiones.MontoCarestino = drLineaCashFlow["MontoCarestino"] != DBNull.Value ? Convert.ToDecimal(drLineaCashFlow["MontoCarestino"]) : 0;
                    ventaComisiones.ComisionCarestino = drLineaCashFlow["ComisionCarestino"] != DBNull.Value ? Convert.ToDecimal(drLineaCashFlow["ComisionCarestino"]) : 0;
                    ventaComisiones.MontoIndumentaria = drLineaCashFlow["MontoIndumentaria"] != DBNull.Value ? Convert.ToDecimal(drLineaCashFlow["MontoIndumentaria"]) : 0;
                    ventaComisiones.ComisionIndumentaria = drLineaCashFlow["ComisionIndumentaria"] != DBNull.Value ? Convert.ToDecimal(drLineaCashFlow["ComisionIndumentaria"]) : 0;
                    ventaComisiones.MontoTotal = drLineaCashFlow["MontoTotal"] != DBNull.Value ? Convert.ToDecimal(drLineaCashFlow["MontoTotal"]) : 0;

                    VentaComisiones=ventaComisiones;
                }
                drLineaCashFlow.Close();
            }
            catch (Exception ex)
            {
                // Manejar la excepción o mostrar un mensaje de error
                MessageBox.Show("Error al obtener el reporte: " + ex.Message);
                // Puedes lanzar una excepción personalizada si lo deseas
                // throw new Exception("Error al registrar movimiento de caja", ex);
            }
            finally
            {
                // Cerrar la conexión después de usarla
                con.Close();
            }
            return VentaComisiones;
        }


    }

}
