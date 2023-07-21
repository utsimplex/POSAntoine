using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class CuentaCorrienteAdapter : Adapter
    {
             public System.ComponentModel.BindingList<Entidades.CuentaCorriente> GetAllPendientes()
             {
                 System.ComponentModel.BindingList<Entidades.CuentaCorriente> ListaCuentaCorriente = new System.ComponentModel.BindingList<Entidades.CuentaCorriente>();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM dbo.Cuentacorriente WHERE Pagado>0", Con);
            try
            {
                Comando.Connection.Open();
                SqlDataReader drCuentaCorriente = Comando.ExecuteReader();

                while (drCuentaCorriente.Read())
                {
                    Entidades.CuentaCorriente CC = new Entidades.CuentaCorriente();

                    CC.Cliente = (string)drCuentaCorriente["Cliente"];
                    CC.Documento = (string)drCuentaCorriente["Documento"];
                    CC.Venta = (int)drCuentaCorriente["Venta"];
                    CC.Fecha = Convert.ToDateTime(drCuentaCorriente["Fecha"]);
                    CC.Total = (decimal)drCuentaCorriente["Total"];
                    CC.Pagado = (decimal)drCuentaCorriente["Pagado"];
                    CC.Pendiente = (decimal)drCuentaCorriente["Pendiente"];
                    CC.Facturado = (string)drCuentaCorriente["Facturado"];


                    ListaCuentaCorriente.Add(CC);
                }
                drCuentaCorriente.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la Cuenta Corriente", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ListaCuentaCorriente;






        }

        public List<Entidades.CuentaCorriente> GetPendientesCliente(long documento)
             {
                 List<Entidades.CuentaCorriente> ListaCuentaCorriente = new List<Entidades.CuentaCorriente>();
                 //Crear Conexion y Abrirla
                 SqlConnection Con = CrearConexion();

                 // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                 SqlCommand Comando = new SqlCommand("SELECT * FROM Cuenta_corriente WHERE Documento= @documento", Con);
                 Comando.Parameters.Add(new SqlParameter("@documento", SqlDbType.BigInt));
                 Comando.Parameters["@documento"].Value = documento;
                 try
                 {
                     Comando.Connection.Open();
                     SqlDataReader drCuentaCorriente = Comando.ExecuteReader();

                     while (drCuentaCorriente.Read())
                     {
                         Entidades.CuentaCorriente CC = new Entidades.CuentaCorriente();

                         CC.Cliente = (string)drCuentaCorriente["Cliente"];
                         CC.Documento = (string)drCuentaCorriente["Documento"];
                         CC.Venta = (int)drCuentaCorriente["Venta"];
                         CC.Fecha = Convert.ToDateTime(drCuentaCorriente["Fecha"]);
                         CC.Total = (decimal)drCuentaCorriente["Total"];
                         CC.Pagado = (decimal)drCuentaCorriente["Pagado"];
                         CC.Pendiente = (decimal)drCuentaCorriente["Pendiente"];
                         CC.Facturado = (string)drCuentaCorriente["Facturado"];

                         
                             ListaCuentaCorriente.Add(CC);
                     }
                     drCuentaCorriente.Close();

                 }
                 catch (Exception Ex)
                 {
                     Exception ExcepcionManejada = new Exception("Error al recuperar la Cuenta Corriente", Ex);
                     throw ExcepcionManejada;
                 }
                 finally
                 {
                     Comando.Connection.Close();
                 }



                 return ListaCuentaCorriente;




             }
        
    }

}
