using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data;
//using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace Data.Database
{
    public class SeñaArticuloAdapter : Adapter
    {
        public void RegistrarSeñaArticulo(Seña_Articulo articulo)
        {
            SqlConnection Con = CrearConexion();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO [SeñasArticulos] ([NumeroSeña], [CodigoArticulo], [DescripcionArticulo], [Cantidad]) " +
                                  "VALUES (@NumeroSeña, @CodigoArticulo, @DescripcionArticulo, @Cantidad)";
            Comando.Parameters.AddWithValue("@NumeroSeña", articulo.numeroSeña);
            Comando.Parameters.AddWithValue("@CodigoArticulo", articulo.codigoArticulo);
            Comando.Parameters.AddWithValue("@DescripcionArticulo", articulo.descripcionArticulo);
            Comando.Parameters.AddWithValue("@Cantidad", articulo.cantidad);

            try
            {
                Con.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar el artículo de la seña: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        public List<Seña_Articulo> GetArticulosPorSeña(int numeroSeña)
        {
            List<Seña_Articulo> articulos = new List<Seña_Articulo>();
            SqlConnection Con = CrearConexion();
            SqlCommand Comando = new SqlCommand("SELECT * FROM [SeñasArticulos] WHERE NumeroSeña = @NumeroSeña", Con);
            Comando.Parameters.AddWithValue("@NumeroSeña", numeroSeña);

            try
            {
                Con.Open();
                SqlDataReader drArticulos = Comando.ExecuteReader();
                while (drArticulos.Read())
                {
                    Seña_Articulo articulo = new Seña_Articulo
                    {
                        numeroSeña = (int)drArticulos["NumeroSeña"],
                        codigoArticulo = (string)drArticulos["CodigoArticulo"],
                        descripcionArticulo = (string)drArticulos["DescripcionArticulo"],
                        cantidad = (int)drArticulos["Cantidad"]
                    };
                    articulos.Add(articulo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los artículos de la seña: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }

            return articulos;
        }

        public void ActualizarCantidadArticulo(int numeroSeña, string codigoArticulo, int nuevaCantidad)
        {
            SqlConnection Con = CrearConexion();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE [SeñasArticulos] SET Cantidad = @Cantidad WHERE NumeroSeña = @NumeroSeña AND CodigoArticulo = @CodigoArticulo";
            Comando.Parameters.AddWithValue("@Cantidad", nuevaCantidad);
            Comando.Parameters.AddWithValue("@NumeroSeña", numeroSeña);
            Comando.Parameters.AddWithValue("@CodigoArticulo", codigoArticulo);

            try
            {
                Con.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la cantidad del artículo: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        public void EliminarArticuloDeSeña(int numeroSeña, string codigoArticulo)
        {
            SqlConnection Con = CrearConexion();
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "DELETE FROM [SeñasArticulos] WHERE NumeroSeña = @NumeroSeña AND CodigoArticulo = @CodigoArticulo";
            Comando.Parameters.AddWithValue("@NumeroSeña", numeroSeña);
            Comando.Parameters.AddWithValue("@CodigoArticulo", codigoArticulo);

            try
            {
                Con.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el artículo de la seña: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
    }
}
