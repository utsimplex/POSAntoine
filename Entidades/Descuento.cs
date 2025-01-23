using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Descuento
    {
        //ID
        public int Id { get; set; }
        //Descripcion
        public string Descripcion { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public string Dispositivo { get; set; }
        public string MedioDePago { get; set; }

        public bool Activa { get; set; }
        public bool AplicaLunes { get; set; }
        public bool AplicaMartes { get; set; }
        public bool AplicaMiercoles { get; set; }
        public bool AplicaJueves { get; set; }
        public bool AplicaViernes { get; set; }
        public bool AplicaSabado { get; set; }
        public bool AplicaDomingo { get; set; }
        public List<DateTime> AplicaFechas { get; set; }
        public string AplicaFechasString
        {
            get
            {
                string Fechas = null;
                if(this.AplicaFechas !=null)
                {
                        foreach (DateTime fecha in this.AplicaFechas)
                        {
                            Fechas = Fechas == null ? fecha.ToString("dd/MM/yyyy") : Fechas + "-" + fecha.ToString("dd/MM/yyyy");

                        };
                }
                return Fechas;
            }
        }
    }
}
