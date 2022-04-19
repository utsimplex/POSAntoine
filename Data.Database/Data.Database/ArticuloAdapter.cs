using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;

namespace Data.Database
{
    public class ArticuloAdapter : Adapter
    {
        public void AñadirNuevo(Entidades.Articulo arti)
        {
                //Crear Conexion y Abrirla
                SqlCeConnection Con = CrearConexion();

                // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                SqlCeCommand Comando = new SqlCeCommand();
                Comando.Connection = Con;
                Comando.CommandType = CommandType.Text;
            try
            {

                Comando.CommandText = "INSERT INTO [Articulos] ([codigo], [descripcion], [stock], [stockmin], [precio], [marca], [habilitado]) VALUES (@CODIGO, @DESCRIPCION, @STOCK, @STOCKMIN, @PRECIO, @MARCA, @HABILITADO)";
                Comando.Parameters.Add(new SqlCeParameter("@CODIGO", SqlDbType.NVarChar));
                Comando.Parameters["@CODIGO"].Value = arti.Codigo;
                Comando.Parameters.Add(new SqlCeParameter("@DESCRIPCION", SqlDbType.NVarChar));
                Comando.Parameters["@DESCRIPCION"].Value = arti.Descripcion;
                Comando.Parameters.Add(new SqlCeParameter("@STOCK", SqlDbType.Int));
                Comando.Parameters["@STOCK"].Value = arti.Stock;
                Comando.Parameters.Add(new SqlCeParameter("@STOCKMIN", SqlDbType.Int));
                Comando.Parameters["@STOCKMIN"].Value = arti.StockMin;
                Comando.Parameters.Add(new SqlCeParameter("@PRECIO", SqlDbType.Money));
                Comando.Parameters["@PRECIO"].Value = arti.Precio;
                Comando.Parameters.Add(new SqlCeParameter("@MARCA", SqlDbType.NVarChar));
                Comando.Parameters["@MARCA"].Value = arti.Proveedor;
                Comando.Parameters.Add(new SqlCeParameter("@HABILITADO", SqlDbType.NVarChar));
                Comando.Parameters["@HABILITADO"].Value = "Si";

                //Ejecuta el comando INSERT
                Comando.Connection.Open();
                Comando.ExecuteNonQuery();
                Comando.Connection.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al añadir artículo", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }
        }

/* //ESTO ELIMINA DE LA BASE DE DATOS
     public void Quitar(string Codigo)
     {

         //Crear Conexion y Abrirla
         SqlCeConnection Con = CrearConexion();

         // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
         SqlCeCommand Comando = new SqlCeCommand();
         Comando.Connection = Con;
         Comando.CommandType = CommandType.Text;
         Comando.CommandText = "DELETE FROM [Articulos] WHERE (([codigo] = @CODIGO))";
         Comando.Parameters.Add(new SqlCeParameter("@CODIGO", SqlDbType.NVarChar));
         Comando.Parameters["@CODIGO"].Value = Codigo;

         //Ejecuta el comando INSERT
         Comando.Connection.Open();
         Comando.ExecuteNonQuery();
         Comando.Connection.Close();
     }
*/ //ESTO ELIMINA DE LA BASE DE DATOS

public void Actualizar(Entidades.Articulo arti)
             {
               //Crear Conexion y Abrirla
               SqlCeConnection Con = CrearConexion();
          
               // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
               SqlCeCommand Comando = new SqlCeCommand();
               Comando.Connection = Con;
               Comando.CommandType = CommandType.Text;
                 
               Comando.CommandText = "UPDATE [Articulos] SET [descripcion] = @DESCRIPCION, [stock] = @STOCK, [stockmin] = @STOCKMIN, [precio] = @PRECIO, [marca] = @MARCA, [habilitado]=@HABILITADO WHERE (([codigo] = @CODIGO))";
               Comando.Parameters.Add(new SqlCeParameter("@CODIGO", SqlDbType.NVarChar));
               Comando.Parameters["@CODIGO"].Value = arti.Codigo;
               Comando.Parameters.Add(new SqlCeParameter("@DESCRIPCION", SqlDbType.NVarChar));
               Comando.Parameters["@DESCRIPCION"].Value = arti.Descripcion;
               Comando.Parameters.Add(new SqlCeParameter("@STOCK", SqlDbType.Int));
               Comando.Parameters["@STOCK"].Value = arti.Stock;
               Comando.Parameters.Add(new SqlCeParameter("@STOCKMIN", SqlDbType.Int));
               Comando.Parameters["@STOCKMIN"].Value = arti.StockMin;
               Comando.Parameters.Add(new SqlCeParameter("@PRECIO", SqlDbType.Money));
               Comando.Parameters["@PRECIO"].Value = arti.Precio;
               Comando.Parameters.Add(new SqlCeParameter("@MARCA", SqlDbType.NVarChar));
               Comando.Parameters["@MARCA"].Value = arti.Proveedor;
               Comando.Parameters.Add(new SqlCeParameter("@HABILITADO", SqlDbType.NVarChar));
               Comando.Parameters["@HABILITADO"].Value = arti.Habilitado;

               //Ejecuta el comando INSERT
               Comando.Connection.Open();
               Comando.ExecuteNonQuery();
               Comando.Connection.Close();
             
             }
        
             public System.ComponentModel.BindingList<Entidades.Articulo> GetAll()
             {
                 System.ComponentModel.BindingList<Entidades.Articulo> ListaArticulos = new System.ComponentModel.BindingList<Entidades.Articulo>();
                 //Crear Conexion y Abrirla
                 SqlCeConnection Con = CrearConexion();

                 // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                 SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Articulos ORDER BY Articulos.descripcion", Con);
                 try
                 {
                     Comando.Connection.Open();
                     SqlCeDataReader drArticulos = Comando.ExecuteReader();

                     while (drArticulos.Read())
                     {
                         Entidades.Articulo arti = new Entidades.Articulo();

                         arti.Codigo = (string)drArticulos["codigo"];
                         arti.Descripcion = (string)drArticulos["descripcion"];
                         arti.Precio = (decimal)drArticulos["precio"];
                         arti.Stock = (int)drArticulos["stock"];
                         arti.StockMin = (int)drArticulos["stockmin"];
                         arti.Proveedor = (string)drArticulos["marca"];
                         arti.Habilitado = (string)drArticulos["habilitado"];

                         if (arti.Habilitado == "Si")
                         {
                             ListaArticulos.Add(arti);
                         }
                     }
                     drArticulos.Close();

                 }
                 catch (Exception Ex)
                 {
                     Exception ExcepcionManejada = new Exception("Error al recuperar lista de Artículos", Ex);
                     throw ExcepcionManejada;
                 }
                 finally
                 {
                     Comando.Connection.Close();
                 }



                 return ListaArticulos;




             }

             public List<Entidades.Articulo> Busqueda(string texto)
             {
                 List<Entidades.Articulo> ListaArticulos = new List<Entidades.Articulo>();
                 //Crear Conexion y Abrirla
                 SqlCeConnection Con = CrearConexion();

                 // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                 SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Articulos WHERE Articulos.codigo like @texto or Articulos.descripcion like @texto OR Articulos.marca like @texto", Con);
                 Comando.Parameters.Add(new SqlCeParameter("@texto", SqlDbType.NVarChar));
                 Comando.Parameters["@texto"].Value = '%' + texto + '%';
                 try
                 {
                     Comando.Connection.Open();
                     SqlCeDataReader drArticulos = Comando.ExecuteReader();

                     while (drArticulos.Read())
                     {
                         Entidades.Articulo arti = new Entidades.Articulo();

                         arti.Codigo = (string)drArticulos["codigo"];
                         arti.Descripcion = (string)drArticulos["descripcion"];
                         arti.Precio = (decimal)drArticulos["precio"];
                         arti.Stock = (int)drArticulos["stock"];
                         arti.StockMin = (int)drArticulos["stockmin"];
                         arti.Proveedor = (string)drArticulos["marca"];
                         arti.Habilitado = (string)drArticulos["habilitado"];

                         if (arti.Habilitado == "Si")
                         {
                             ListaArticulos.Add(arti);
                         }
                     }
                     drArticulos.Close();

                 }
                 catch (Exception Ex)
                 {
                     Exception ExcepcionManejada = new Exception("Error al recuperar lista de Artículos", Ex);
                     throw ExcepcionManejada;
                 }
                 finally
                 {
                     Comando.Connection.Close();
                 }



                 return ListaArticulos;




             }
        
             public List<Entidades.Articulo> GetStockBajoMinimo()
             {
                 List<Entidades.Articulo> ListaArticulosReponer = new List<Entidades.Articulo>();
                 //Crear Conexion y Abrirla
                 SqlCeConnection Con = CrearConexion();

                 // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                 SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Articulos WHERE Articulos.stock <= Articulos.stockmin", Con);
                 try
                 {
                     Comando.Connection.Open();
                     SqlCeDataReader drArticulos = Comando.ExecuteReader();

                     while (drArticulos.Read())
                     {
                         Entidades.Articulo arti = new Entidades.Articulo();

                         arti.Codigo = (string)drArticulos["codigo"];
                         arti.Descripcion = (string)drArticulos["descripcion"];
                         arti.Precio = (decimal)drArticulos["precio"];
                         arti.Stock = (int)drArticulos["stock"];
                         arti.StockMin = (int)drArticulos["stockmin"];
                         arti.Proveedor = (string)drArticulos["marca"];
                         arti.Habilitado = (string)drArticulos["marca"];

                         if (arti.Habilitado == "Si")
                         {
                             ListaArticulosReponer.Add(arti);
                         }
                     }
                     drArticulos.Close();

                 }
                 catch (Exception Ex)
                 {
                     Exception ExcepcionManejada = new Exception("Error al recuperar lista de Artículos", Ex);
                     throw ExcepcionManejada;
                 }
                 finally
                 {
                     Comando.Connection.Close();
                 }



                 return ListaArticulosReponer;




             }
             //GetOne
                 
             public Entidades.Articulo BuscarArticulo(string texto)
             {
                 Entidades.Articulo ListaArticulos = new Entidades.Articulo();
                 //Crear Conexion y Abrirla
                 SqlCeConnection Con = CrearConexion();

                 // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                 SqlCeCommand Comando = new SqlCeCommand("SELECT * FROM Articulos WHERE Articulos.codigo = @texto or Articulos.descripcion = @texto", Con);
                 Comando.Parameters.Add(new SqlCeParameter("@texto", SqlDbType.NVarChar));
                 Comando.Parameters["@texto"].Value = texto;
                 try
                 {
                     Comando.Connection.Open();
                     SqlCeDataReader drArticulos = Comando.ExecuteReader();

                     while (drArticulos.Read())
                     {
                         ListaArticulos.Codigo = (string)drArticulos["codigo"];
                         ListaArticulos.Descripcion = (string)drArticulos["descripcion"];
                         ListaArticulos.Precio = (decimal)drArticulos["precio"];
                         ListaArticulos.Stock = (int)drArticulos["stock"];
                         ListaArticulos.StockMin = (int)drArticulos["stockmin"];
                         ListaArticulos.Proveedor = (string)drArticulos["marca"];
                         ListaArticulos.Habilitado = (string)drArticulos["habilitado"];
                     }
                     drArticulos.Close();

                 }
                 catch (Exception Ex)
                 {
                     Exception ExcepcionManejada = new Exception("Error al recuperar lista de Artículos", Ex);
                     throw ExcepcionManejada;
                 }
                 finally
                 {
                     Comando.Connection.Close();
                 }


                 return ListaArticulos;




             }

             //Contar Cantidad de Artículos
             public int ContarArticulos()
             {
                 int canti;
                 
                 //Crear Conexion y Abrirla
                 SqlCeConnection Con = CrearConexion();

                 // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                 SqlCeCommand Comando = new SqlCeCommand("SELECT COUNT(*) Cantidad FROM Articulos", Con);
                 try
                 {
                     Comando.Connection.Open();
                     canti = Convert.ToInt32(Comando.ExecuteScalar());


                 }
                 catch (Exception Ex)
                 {
                     Exception ExcepcionManejada = new Exception("Error al recuperar lista de Artículos", Ex);
                     throw ExcepcionManejada;
                 }
                 finally
                 {
                     Comando.Connection.Close();
                 }



                 return canti;


             }

             //Contar cantidad de Artículos en Stock
             public int ContarArticulosStock()
             {
                 int canti;

                 //Crear Conexion y Abrirla
                 SqlCeConnection Con = CrearConexion();

                 // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                 SqlCeCommand Comando = new SqlCeCommand("SELECT SUM(articulos.stock) as ArticuloStock from articulos", Con);
                 try
                 {
                     Comando.Connection.Open();
                     canti = Convert.ToInt32(Comando.ExecuteScalar());


                 }
                 catch (Exception Ex)
                 {
                     Exception ExcepcionManejada = new Exception("Error al recuperar lista de Artículos", Ex);
                     throw ExcepcionManejada;
                 }
                 finally
                 {
                     Comando.Connection.Close();
                 }



                 return canti;


             }
        
             // GET LISTADO MARCAS
             public List<string> GetListadoMarcas()
             {
                 
                 List<string> ListaMarcas = new List<string>();

                 //Crear Conexion y Abrirla
                 SqlCeConnection Con = CrearConexion();

                 // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                 SqlCeCommand Comando = new SqlCeCommand("SELECT DISTINCT marca FROM Articulos WHERE (habilitado = 'Si')", Con);
                 try
                 {
                     Comando.Connection.Open();
                     SqlCeDataReader drMarcas = Comando.ExecuteReader();

                     while (drMarcas.Read())
                     {
                         string marca = "";

                         
                         marca = (string)drMarcas["marca"];


                         ListaMarcas.Add(marca);
                         
                     }
                     drMarcas.Close();

                 }
                 catch (Exception Ex)
                 {
                     Exception ExcepcionManejada = new Exception("Error al recuperar lista de Marcas", Ex);
                     throw ExcepcionManejada;
                 }
                 finally
                 {
                     Comando.Connection.Close();
                 }



                 return ListaMarcas;

 
             }
    }

}
