using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ArticuloAdapter : Adapter
    {
        public void AñadirNuevo(Entidades.Articulo arti)
        {
                //Crear Conexion y Abrirla
                SqlConnection Con = CrearConexion();

                // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Con;
                Comando.CommandType = CommandType.Text;
            try
            {

                Comando.CommandText = "INSERT INTO [Articulos] ([codigo], [descripcion], [stock], [stockmin], [precio], [marca], [habilitado], [familia], [familia2], [codigo_barras], [codigo_arti_proveedor], [campopersonalizado1], [campopersonalizado2], [costo]) VALUES (@CODIGO, @DESCRIPCION, @STOCK, @STOCKMIN, @PRECIO, @MARCA, @HABILITADO, @FAMILIA, @FAMILIA2, @CODIGO_BARRAS, @CODIGO_ARTI_PROVEEDOR, @CAMPOPERSONALIZADO1, @CAMPOPERSONALIZADO2, @COSTO)";
                Comando.Parameters.Add(new SqlParameter("@CODIGO", SqlDbType.NVarChar));
                Comando.Parameters["@CODIGO"].Value = arti.Codigo;
                Comando.Parameters.Add(new SqlParameter("@DESCRIPCION", SqlDbType.NVarChar));
                Comando.Parameters["@DESCRIPCION"].Value = arti.Descripcion;
                Comando.Parameters.Add(new SqlParameter("@STOCK", SqlDbType.Int));
                Comando.Parameters["@STOCK"].Value = arti.Stock;
                Comando.Parameters.Add(new SqlParameter("@STOCKMIN", SqlDbType.Int));
                Comando.Parameters["@STOCKMIN"].Value = arti.StockMin;
                Comando.Parameters.Add(new SqlParameter("@PRECIO", SqlDbType.Money));
                Comando.Parameters["@PRECIO"].Value = arti.Precio;
                Comando.Parameters.Add(new SqlParameter("@MARCA", SqlDbType.NVarChar));
                Comando.Parameters["@MARCA"].Value = arti.Proveedor;
                Comando.Parameters.Add(new SqlParameter("@HABILITADO", SqlDbType.NVarChar));
                Comando.Parameters["@HABILITADO"].Value = "Si";
                Comando.Parameters.Add(new SqlParameter("@FAMILIA", SqlDbType.Int));
                Comando.Parameters["@FAMILIA"].Value = arti.Familia1.id;
                Comando.Parameters.Add(new SqlParameter("@FAMILIA2", SqlDbType.Int));
                Comando.Parameters["@FAMILIA2"].Value = arti.Familia2.id;
                Comando.Parameters.Add(new SqlParameter("@CODIGO_BARRAS", SqlDbType.NVarChar));
                Comando.Parameters["@CODIGO_BARRAS"].Value = String.IsNullOrEmpty(arti.CodigoBarras) ? string.Empty : arti.CodigoBarras;
                Comando.Parameters.Add(new SqlParameter("@CODIGO_ARTI_PROVEEDOR", SqlDbType.NVarChar));
                Comando.Parameters["@CODIGO_ARTI_PROVEEDOR"].Value = arti.CodigoArtiProveedor;
                Comando.Parameters.Add(new SqlParameter("@CAMPOPERSONALIZADO1", SqlDbType.NVarChar));
                Comando.Parameters["@CAMPOPERSONALIZADO1"].Value = arti.CampoPersonalizado1;
                Comando.Parameters.Add(new SqlParameter("@CAMPOPERSONALIZADO2", SqlDbType.NVarChar));
                Comando.Parameters["@CAMPOPERSONALIZADO2"].Value = arti.CampoPersonalizado2;
                Comando.Parameters.Add(new SqlParameter("@COSTO", SqlDbType.Decimal));
                Comando.Parameters["@COSTO"].Value = arti.Costo;

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
         SqlConnection Con = CrearConexion();

         // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
         SqlCommand Comando = new SqlCommand();
         Comando.Connection = Con;
         Comando.CommandType = CommandType.Text;
         Comando.CommandText = "DELETE FROM [Articulos] WHERE (([codigo] = @CODIGO))";
         Comando.Parameters.Add(new SqlParameter("@CODIGO", SqlDbType.NVarChar));
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
               SqlConnection Con = CrearConexion();
          
               // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
               SqlCommand Comando = new SqlCommand();
               Comando.Connection = Con;
               Comando.CommandType = CommandType.Text;
                 
               Comando.CommandText = "UPDATE [Articulos] SET [descripcion] = @DESCRIPCION, [stock] = @STOCK, [stockmin] = @STOCKMIN, [precio] = @PRECIO, [marca] = @MARCA, [habilitado]=@HABILITADO, [familia]=@FAMILIA, [familia2]=@FAMILIA2, [codigo_barras]=@CODIGO_BARRAS, [codigo_arti_proveedor]=@CODIGO_ARTI_PROVEEDOR, [CampoPersonalizado1]=@CAMPOPERSONALIZADO1, [campopersonalizado2]=@CAMPOPERSONALIZADO2, [costo]=@COSTO WHERE (([codigo] = @CODIGO))";
               Comando.Parameters.Add(new SqlParameter("@CODIGO", SqlDbType.NVarChar));
               Comando.Parameters["@CODIGO"].Value = arti.Codigo;
               Comando.Parameters.Add(new SqlParameter("@DESCRIPCION", SqlDbType.NVarChar));
               Comando.Parameters["@DESCRIPCION"].Value = arti.Descripcion;
               Comando.Parameters.Add(new SqlParameter("@STOCK", SqlDbType.Int));
               Comando.Parameters["@STOCK"].Value = arti.Stock;
               Comando.Parameters.Add(new SqlParameter("@STOCKMIN", SqlDbType.Int));
               Comando.Parameters["@STOCKMIN"].Value = arti.StockMin;
               Comando.Parameters.Add(new SqlParameter("@PRECIO", SqlDbType.Decimal));
               Comando.Parameters["@PRECIO"].Value = arti.Precio;
               Comando.Parameters.Add(new SqlParameter("@MARCA", SqlDbType.NVarChar));
               Comando.Parameters["@MARCA"].Value = arti.Proveedor;
               Comando.Parameters.Add(new SqlParameter("@HABILITADO", SqlDbType.NVarChar));
               Comando.Parameters["@HABILITADO"].Value = arti.Habilitado;
               Comando.Parameters.Add(new SqlParameter("@FAMILIA", SqlDbType.Int));
               Comando.Parameters["@FAMILIA"].Value = arti.Familia1.id;
               Comando.Parameters.Add(new SqlParameter("@FAMILIA2", SqlDbType.Int));
               Comando.Parameters["@FAMILIA2"].Value = arti.Familia2?.id!=null? arti.Familia2.id:0;
               Comando.Parameters.Add(new SqlParameter("@CODIGO_BARRAS", SqlDbType.NVarChar));
               Comando.Parameters["@CODIGO_BARRAS"].Value = String.IsNullOrEmpty(arti.CodigoBarras) ? string.Empty : arti.CodigoBarras;
               Comando.Parameters.Add(new SqlParameter("@CODIGO_ARTI_PROVEEDOR", SqlDbType.NVarChar));
               Comando.Parameters["@CODIGO_ARTI_PROVEEDOR"].Value = arti.CodigoArtiProveedor;
               Comando.Parameters.Add(new SqlParameter("@CAMPOPERSONALIZADO1", SqlDbType.NVarChar));
               Comando.Parameters["@CAMPOPERSONALIZADO1"].Value = String.IsNullOrEmpty(arti.CampoPersonalizado1) ? string.Empty : arti.CampoPersonalizado1;
               Comando.Parameters.Add(new SqlParameter("@CAMPOPERSONALIZADO2", SqlDbType.NVarChar));
               Comando.Parameters["@CAMPOPERSONALIZADO2"].Value = String.IsNullOrEmpty(arti.CampoPersonalizado2) ? string.Empty : arti.CampoPersonalizado2;
               Comando.Parameters.Add(new SqlParameter("@COSTO", SqlDbType.Decimal));
               Comando.Parameters["@COSTO"].Value = arti.Costo;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
               Comando.ExecuteNonQuery();
               Comando.Connection.Close();
             
             }

        public void ActualizarPrecio(List<Entidades.Articulo> listadoArticulos)
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE Articulos SET precio = @PRECIO WHERE codigo = @CODIGO";
            Comando.Parameters.Add(new SqlParameter("@CODIGO", SqlDbType.NVarChar));
            //Comando.Parameters["@CODIGO"].Value = arti.Codigo;
            //Comando.Parameters.Add(new SqlParameter("@DESCRIPCION", SqlDbType.NVarChar));
            //Comando.Parameters["@DESCRIPCION"].Value = arti.Descripcion;
            //Comando.Parameters.Add(new SqlParameter("@STOCK", SqlDbType.Int));
            //Comando.Parameters["@STOCK"].Value = arti.Stock;
            //Comando.Parameters.Add(new SqlParameter("@STOCKMIN", SqlDbType.Int));
            //Comando.Parameters["@STOCKMIN"].Value = arti.StockMin;
            //Comando.Parameters.Add(new SqlParameter("@PRECIO", SqlDbType.Money));
            //Comando.Parameters["@PRECIO"].Value = arti.Precio;
            //Comando.Parameters.Add(new SqlParameter("@MARCA", SqlDbType.NVarChar));
            //Comando.Parameters["@MARCA"].Value = arti.Proveedor;
            //Comando.Parameters.Add(new SqlParameter("@HABILITADO", SqlDbType.NVarChar));
            //Comando.Parameters["@HABILITADO"].Value = arti.Habilitado;
            //Comando.Parameters.Add(new SqlParameter("@FAMILIA", SqlDbType.Int));
            //Comando.Parameters["@FAMILIA"].Value = arti.Familia;
            //Comando.Parameters.Add(new SqlParameter("@RANGO_ETARIO", SqlDbType.Int));
            //Comando.Parameters["@RANGO_ETARIO"].Value = arti.RangoEtario;
            //Comando.Parameters.Add(new SqlParameter("@CODIGO_ARTI_PROVEEDOR", SqlDbType.NVarChar));
            //Comando.Parameters["@CODIGO_ARTI_PROVEEDOR"].Value = arti.CodigoArtiProveedor;
            //Comando.Parameters.Add(new SqlParameter("@COSTO", SqlDbType.Decimal));
            //Comando.Parameters["@COSTO"].Value = arti.Costo;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();

        }
       
        public System.ComponentModel.BindingList<Entidades.Articulo> GetAll()
             {
                 System.ComponentModel.BindingList<Entidades.Articulo> ListaArticulos = new System.ComponentModel.BindingList<Entidades.Articulo>();
                 //Crear Conexion y Abrirla
                 SqlConnection Con = CrearConexion();

                 // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                 SqlCommand Comando = new SqlCommand("SELECT codigo, articulos.descripcion, stock, stockmin, precio, marca, habilitado, Familia as 'familia1ID', familia.DESCRIPCION as 'familia1Texto', Familia2 as'familia2ID', famdos.DESCRIPCION as 'familia2Texto', codigo_barras, CODIGO_ARTI_PROVEEDOR, Costo, CampoPersonalizado1, CampoPersonalizado2 FROM Articulos LEFT JOIN FAMILIA ON familia.id = articulos.Familia LEFT JOIN FAMILIA_DOS famdos ON famdos.ID = articulos.Familia2 ORDER BY articulos.descripcion", Con);
                 try
                 {
                     Comando.Connection.Open();
                     SqlDataReader drArticulos = Comando.ExecuteReader();

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
                        arti.Familia1.id = drArticulos["familia1ID"] != DBNull.Value ? Convert.ToInt32(drArticulos["familia1ID"]) : (int?)null;
                        arti.Familia1.Descripcion = drArticulos["familia1Texto"] != DBNull.Value ? Convert.ToString(drArticulos["familia1Texto"]) : (string)null;
                        arti.Familia2.id = drArticulos["familia2ID"] != DBNull.Value ? Convert.ToInt32(drArticulos["familia2ID"]) : (int?)null;
                        arti.Familia2.Descripcion = drArticulos["familia2Texto"] != DBNull.Value ? Convert.ToString(drArticulos["familia2Texto"]) : (string)null;
                        arti.Costo = drArticulos["costo"] != DBNull.Value ? Convert.ToDecimal(drArticulos["costo"]) : (decimal?)null;
                        arti.CodigoArtiProveedor = drArticulos["codigo_arti_proveedor"] != DBNull.Value ? Convert.ToString(drArticulos["codigo_arti_proveedor"]) : (string)null;
                        arti.CampoPersonalizado1 = drArticulos["CampoPersonalizado1"] != DBNull.Value ? Convert.ToString(drArticulos["CampoPersonalizado1"]) : (string)null;
                        arti.CampoPersonalizado2 = drArticulos["CampoPersonalizado2"] != DBNull.Value ? Convert.ToString(drArticulos["CampoPersonalizado2"]) : (string)null;
                        arti.CodigoBarras = drArticulos["codigo_barras"] != DBNull.Value ? Convert.ToString(drArticulos["codigo_barras"]) : (string)null;

                    //if (arti.Habilitado == "Si")
                    //{
                    ListaArticulos.Add(arti);
                             //}
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
                 SqlConnection Con = CrearConexion();

                 // Crear SQLCeCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                 SqlCommand Comando = new SqlCommand("SELECT * FROM Articulos WHERE Articulos.codigo like @texto or Articulos.descripcion like @texto OR Articulos.marca like @texto", Con);
                 Comando.Parameters.Add(new SqlParameter("@texto", SqlDbType.NVarChar));
                 Comando.Parameters["@texto"].Value = '%' + texto + '%';
                 try
                 {
                     Comando.Connection.Open();
                     SqlDataReader drArticulos = Comando.ExecuteReader();

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
                 SqlConnection Con = CrearConexion();

                 // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                 SqlCommand Comando = new SqlCommand("SELECT * FROM Articulos WHERE Articulos.stock <= Articulos.stockmin", Con);
                 try
                 {
                     Comando.Connection.Open();
                     SqlDataReader drArticulos = Comando.ExecuteReader();

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
                 Entidades.Articulo arti = new Entidades.Articulo();
                 //Crear Conexion y Abrirla
                 SqlConnection Con = CrearConexion();

                 // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                 SqlCommand Comando = new SqlCommand("SELECT * FROM Articulos WHERE Articulos.codigo = @texto or Articulos.descripcion = @texto", Con);
                 Comando.Parameters.Add(new SqlParameter("@texto", SqlDbType.NVarChar));
                 Comando.Parameters["@texto"].Value = texto;
                 try
                 {
                     Comando.Connection.Open();
                     SqlDataReader drArticulos = Comando.ExecuteReader();

                     while (drArticulos.Read())
                     {
                         arti.Codigo = (string)drArticulos["codigo"];
                         arti.Descripcion = (string)drArticulos["descripcion"];
                         arti.Precio = (decimal)drArticulos["precio"];
                         arti.Stock = (int)drArticulos["stock"];
                         arti.StockMin = (int)drArticulos["stockmin"];
                         arti.Proveedor = (string)drArticulos["marca"];
                         arti.Habilitado = (string)drArticulos["habilitado"];
                         arti.Familia1.id = drArticulos["familia"] != DBNull.Value ? Convert.ToInt32(drArticulos["familia"]) : (int?)null;
                         arti.Familia2.id = drArticulos["familia2"] != DBNull.Value ? Convert.ToInt32(drArticulos["familia2"]) : (int?)null;
                         arti.Costo = drArticulos["costo"] != DBNull.Value ? Convert.ToDecimal(drArticulos["costo"]) : (decimal?)null;
                         arti.CodigoArtiProveedor = drArticulos["codigo_arti_proveedor"] != DBNull.Value ? Convert.ToString(drArticulos["codigo_arti_proveedor"]) : (string)null;
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


                 return arti;




             }

        //Contar Cantidad de Artículos
        public int ContarArticulos()
             {
                 int canti;
                 
                 //Crear Conexion y Abrirla
                 SqlConnection Con = CrearConexion();

                 // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                 SqlCommand Comando = new SqlCommand("SELECT COUNT(*) Cantidad FROM Articulos", Con);
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
                 SqlConnection Con = CrearConexion();

                 // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                 SqlCommand Comando = new SqlCommand("SELECT SUM(articulos.stock) as ArticuloStock from articulos", Con);
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
                 SqlConnection Con = CrearConexion();

                 // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
                 SqlCommand Comando = new SqlCommand("SELECT DISTINCT marca FROM Articulos WHERE (habilitado = 'Si')", Con);
                 try
                 {
                     Comando.Connection.Open();
                     SqlDataReader drMarcas = Comando.ExecuteReader();

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
