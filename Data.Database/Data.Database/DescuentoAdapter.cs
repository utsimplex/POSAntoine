using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace Data.Database
{
    public class DescuentoAdapter : Adapter
    {

        public void AñadirNuevo(Entidades.Descuento descuento)
        {

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO [Descuentos] ([Descripcion],[Dispositivo],[MedioDePago],[PorcentajeDescuento],[Activa],[AplicaLunes] " +
            ",[AplicaMartes],[AplicaMiercoles],[AplicaJueves],[AplicaViernes],[AplicaSabado],[AplicaDomingo],[AplicaFechas]) VALUES " +
            "(@Descripcion,@Dispositivo,@MedioDePago,@PorcentajeDescuento,@Activa,@AplicaLunes,@AplicaMartes,@AplicaMiercoles,@AplicaJueves,@AplicaViernes,@AplicaSabado,@AplicaDomingo,@AplicaFechas)";
            Comando.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.NVarChar));
            Comando.Parameters["@Descripcion"].Value = descuento.Descripcion;
            Comando.Parameters.Add(new SqlParameter("@Dispositivo", SqlDbType.NVarChar));
            Comando.Parameters["@Dispositivo"].Value = descuento.Dispositivo;
            Comando.Parameters.Add(new SqlParameter("@MedioDePago", SqlDbType.NVarChar));
            Comando.Parameters["@MedioDePago"].Value = descuento.MedioDePago;
            Comando.Parameters.Add(new SqlParameter("@PorcentajeDescuento", SqlDbType.Decimal));
            Comando.Parameters["@PorcentajeDescuento"].Value = descuento.PorcentajeDescuento;
            Comando.Parameters.Add(new SqlParameter("@Activa", SqlDbType.Bit));
            Comando.Parameters["@Activa"].Value = descuento.Activa;
            Comando.Parameters.Add(new SqlParameter("@AplicaLunes", SqlDbType.Bit));
            Comando.Parameters["@AplicaLunes"].Value = descuento.AplicaLunes;
            Comando.Parameters.Add(new SqlParameter("@AplicaMartes", SqlDbType.Bit));
            Comando.Parameters["@AplicaMartes"].Value = descuento.AplicaMartes;
            Comando.Parameters.Add(new SqlParameter("@AplicaMiercoles", SqlDbType.Bit));
            Comando.Parameters["@AplicaMiercoles"].Value = descuento.AplicaMiercoles;
            Comando.Parameters.Add(new SqlParameter("@AplicaJueves", SqlDbType.Bit));
            Comando.Parameters["@AplicaJueves"].Value = descuento.AplicaJueves;
            Comando.Parameters.Add(new SqlParameter("@AplicaViernes", SqlDbType.Bit));
            Comando.Parameters["@AplicaViernes"].Value = descuento.AplicaViernes;
            Comando.Parameters.Add(new SqlParameter("@AplicaSabado", SqlDbType.Bit));
            Comando.Parameters["@AplicaSabado"].Value = descuento.AplicaSabado;
            Comando.Parameters.Add(new SqlParameter("@AplicaDomingo", SqlDbType.Bit));
            Comando.Parameters["@AplicaDomingo"].Value = descuento.AplicaDomingo;
            Comando.Parameters.Add(new SqlParameter("@AplicaFechas", SqlDbType.NVarChar));
            Comando.Parameters["@AplicaFechas"].Value = descuento.AplicaFechasString!=null? descuento.AplicaFechasString : "";
            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();


        }

        public void Actualizar(Entidades.Descuento descuento)
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE [Descuentos] SET Descripcion=@Descripcion,Dispositivo=@Dispositivo,MedioDePago=@MedioDePago,PorcentajeDescuento=@PorcentajeDescuento,Activa=@Activa," +
                "AplicaLunes=@AplicaLunes,AplicaMartes=@AplicaMartes,AplicaMiercoles=@AplicaMiercoles,AplicaJueves=@AplicaJueves,AplicaViernes=@AplicaViernes," +
                "AplicaSabado=@AplicaSabado,AplicaDomingo=@AplicaDomingo,AplicaFechas=@AplicaFechas WHERE ([ID] = @ID)";
            Comando.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int));
            Comando.Parameters["@ID"].Value = descuento.Id;
            Comando.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.NVarChar));
            Comando.Parameters["@Descripcion"].Value = descuento.Descripcion;
            Comando.Parameters.Add(new SqlParameter("@Dispositivo", SqlDbType.NVarChar));
            Comando.Parameters["@Dispositivo"].Value = descuento.Dispositivo;
            Comando.Parameters.Add(new SqlParameter("@MedioDePago", SqlDbType.NVarChar));
            Comando.Parameters["@MedioDePago"].Value = descuento.MedioDePago;
            Comando.Parameters.Add(new SqlParameter("@PorcentajeDescuento", SqlDbType.Decimal));
            Comando.Parameters["@PorcentajeDescuento"].Value = descuento.PorcentajeDescuento;
            Comando.Parameters.Add(new SqlParameter("@Activa", SqlDbType.Bit));
            Comando.Parameters["@Activa"].Value = descuento.Activa;
            Comando.Parameters.Add(new SqlParameter("@AplicaLunes", SqlDbType.Bit));
            Comando.Parameters["@AplicaLunes"].Value = descuento.AplicaLunes;
            Comando.Parameters.Add(new SqlParameter("@AplicaMartes", SqlDbType.Bit));
            Comando.Parameters["@AplicaMartes"].Value = descuento.AplicaMartes;
            Comando.Parameters.Add(new SqlParameter("@AplicaMiercoles", SqlDbType.Bit));
            Comando.Parameters["@AplicaMiercoles"].Value = descuento.AplicaMiercoles;
            Comando.Parameters.Add(new SqlParameter("@AplicaJueves", SqlDbType.Bit));
            Comando.Parameters["@AplicaJueves"].Value = descuento.AplicaJueves;
            Comando.Parameters.Add(new SqlParameter("@AplicaViernes", SqlDbType.Bit));
            Comando.Parameters["@AplicaViernes"].Value = descuento.AplicaViernes;
            Comando.Parameters.Add(new SqlParameter("@AplicaSabado", SqlDbType.Bit));
            Comando.Parameters["@AplicaSabado"].Value = descuento.AplicaSabado;
            Comando.Parameters.Add(new SqlParameter("@AplicaDomingo", SqlDbType.Bit));
            Comando.Parameters["@AplicaDomingo"].Value = descuento.AplicaDomingo;
            Comando.Parameters.Add(new SqlParameter("@AplicaFechas", SqlDbType.NVarChar));
            Comando.Parameters["@AplicaFechas"].Value = descuento.AplicaFechasString!=null? descuento.AplicaFechasString : "";


            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public List<Entidades.Descuento> GetAll( bool? activo)
        {
            List<Entidades.Descuento> ListaDescuentos = new List<Entidades.Descuento>();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            string whereClause = activo==true?" WHERE Activa=1":"";
            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM Descuentos"+ whereClause, Con);
            try
            {
                Comando.Connection.Open();
                SqlDataReader drDescuentos = Comando.ExecuteReader();

                while (drDescuentos.Read())
                {
                    Entidades.Descuento desc = new Entidades.Descuento();

                    desc.Id = (int)drDescuentos["Id"];
                    desc.Descripcion = (string)drDescuentos["Descripcion"];
                    desc.Dispositivo= (string)drDescuentos["dispositivo"];
                    desc.MedioDePago = (string)drDescuentos["MedioDePago"];
                    desc.PorcentajeDescuento = drDescuentos["PorcentajeDescuento"] != DBNull.Value ? Convert.ToDecimal(drDescuentos["PorcentajeDescuento"]) : 0;
                    desc.Activa = drDescuentos["Activa"] != DBNull.Value ? Convert.ToBoolean(drDescuentos["Activa"]) : false;
                    desc.AplicaLunes = drDescuentos["AplicaLunes"] != DBNull.Value ? Convert.ToBoolean(drDescuentos["AplicaLunes"]) : false;
                    desc.AplicaMartes = drDescuentos["AplicaMartes"] != DBNull.Value ? Convert.ToBoolean(drDescuentos["AplicaMartes"]) : false;
                    desc.AplicaMiercoles = drDescuentos["AplicaMiercoles"] != DBNull.Value ? Convert.ToBoolean(drDescuentos["AplicaMiercoles"]) : false;
                    desc.AplicaJueves = drDescuentos["AplicaJueves"] != DBNull.Value ? Convert.ToBoolean(drDescuentos["AplicaJueves"]) : false;
                    desc.AplicaViernes = drDescuentos["AplicaViernes"] != DBNull.Value ? Convert.ToBoolean(drDescuentos["AplicaViernes"]) : false;
                    desc.AplicaSabado = drDescuentos["AplicaSabado"] != DBNull.Value ? Convert.ToBoolean(drDescuentos["AplicaSabado"]) : false;
                    desc.AplicaDomingo = drDescuentos["AplicaDomingo"] != DBNull.Value ? Convert.ToBoolean(drDescuentos["AplicaDomingo"]) : false;
                    desc.AplicaFechas = drDescuentos["AplicaFechas"] != DBNull.Value ? this.helperDates(drDescuentos["AplicaFechas"].ToString()) : null;

                    ListaDescuentos.Add(desc);
                }
                drDescuentos.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Descuentos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ListaDescuentos;




        }

        public Entidades.Descuento GetOne(int id)
        {
            Entidades.Descuento DescuentoActual = new Entidades.Descuento();

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM Descuentos WHERE Descuentos.id = @id", Con);
            Comando.Parameters.Add(new SqlParameter("@DNI", SqlDbType.BigInt));
            Comando.Parameters["@ID"].Value = id;

            try
            {
                Comando.Connection.Open();
                SqlDataReader drDescuentos = Comando.ExecuteReader();

                while (drDescuentos.Read())
                {
                    DescuentoActual.Id = (int)drDescuentos["Id"];
                    DescuentoActual.Descripcion = (string)drDescuentos["Descripcion"];
                    DescuentoActual.Dispositivo = (string)drDescuentos["dispositivo"];
                    DescuentoActual.MedioDePago = (string)drDescuentos["MedioDePago"];
                    DescuentoActual.PorcentajeDescuento = drDescuentos["PorcentajeDescuento"] != DBNull.Value ? Convert.ToDecimal(drDescuentos["PorcentajeDescuento"]) : 0;
                    DescuentoActual.Activa = drDescuentos["Activa"] != DBNull.Value ? Convert.ToBoolean(drDescuentos["Activa"]) : false;
                    DescuentoActual.AplicaLunes = drDescuentos["AplicaLunes"] != DBNull.Value ? Convert.ToBoolean(drDescuentos["AplicaLunes"]) : false;
                    DescuentoActual.AplicaMartes = drDescuentos["AplicaMartes"] != DBNull.Value ? Convert.ToBoolean(drDescuentos["AplicaMartes"]) : false;
                    DescuentoActual.AplicaMiercoles = drDescuentos["AplicaMiercoles"] != DBNull.Value ? Convert.ToBoolean(drDescuentos["AplicaMiercoles"]) : false;
                    DescuentoActual.AplicaJueves = drDescuentos["AplicaJueves"] != DBNull.Value ? Convert.ToBoolean(drDescuentos["AplicaJueves"]) : false;
                    DescuentoActual.AplicaViernes = drDescuentos["AplicaViernes"] != DBNull.Value ? Convert.ToBoolean(drDescuentos["AplicaViernes"]) : false;
                    DescuentoActual.AplicaSabado = drDescuentos["AplicaSabado"] != DBNull.Value ? Convert.ToBoolean(drDescuentos["AplicaSabado"]) : false;
                    DescuentoActual.AplicaDomingo = drDescuentos["AplicaDomingo"] != DBNull.Value ? Convert.ToBoolean(drDescuentos["AplicaDomingo"]) : false;
                    DescuentoActual.AplicaFechas = drDescuentos["AplicaFechas"] != DBNull.Value ? this.helperDates(drDescuentos["AplicaFechas"].ToString()) : null;



                }
                drDescuentos.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Descuentos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return DescuentoActual;




        }
        private List<DateTime> helperDates(string fechas)
        {
            List<DateTime> helperDates = new List<DateTime>();
            string[] listFechas = fechas.Split('-');
            if(listFechas.Length>0)
            {

            foreach(string fechasStr in listFechas)
            {
                    if (fechasStr != "")
                    {
                        DateTime fechasDate = Convert.ToDateTime(fechasStr);
                        helperDates.Add(fechasDate);
                    }
            }

            }
            return helperDates;

        }

    }
        
}
