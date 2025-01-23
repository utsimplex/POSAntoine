using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Reportes
    {
        CashFlow,
        VentasComisiones
    }
    public class ReporteCashflow
    {
        //Reporte-Compraventa
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public string TipoMovimiento { get; set; }
        public string Subclasificacion { get; set; }
        public decimal Monto { get; set; }
    }
    public class ReporteVentasComisiones
    {
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public decimal MontoCarestino { get; set; }
        public decimal ComisionCarestino { get; set; }
        public decimal MontoIndumentaria { get; set; }
        public decimal ComisionIndumentaria { get; set; }
        public decimal Basico { get; set; }
        public decimal MontoTotal { get; set; }
    }
}
