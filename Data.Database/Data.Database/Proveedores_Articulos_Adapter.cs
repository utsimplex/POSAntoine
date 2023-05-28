using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Data.Database
{
   public class Proveedores_Articulos_Adapter: Adapter
    {
       public void AñadirNuevo(Entidades.Proveedor_Articulo prov_arti)
        {

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO [Proveedores_Articulos] ([nombreProv], [codigoArt], [costoCompraProv]) VALUES (@NOMBREPROV, @CODIGOART, @COSTOCOMPRAPROV)";
            Comando.Parameters.Add(new SqlParameter("@NOMBREPROV", SqlDbType.NVarChar));
            Comando.Parameters["@NOMBREPROV"].Value = prov_arti.Nombre;
            Comando.Parameters.Add(new SqlParameter("@CODIGOART", SqlDbType.NVarChar));
            Comando.Parameters["@CODIGOART"].Value = prov_arti.CodigoArticulo;
            Comando.Parameters.Add(new SqlParameter("@COSTOCOMPRAPROV", SqlDbType.Money));
            Comando.Parameters["@COSTOCOMPRAPROV"].Value = prov_arti.CostoCompraProveedor;
           

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public List<Entidades.Proveedor_Articulo> GetAll()
        {
            List<Entidades.Proveedor_Articulo> ListaProveedoresArticulos = new List<Entidades.Proveedor_Articulo>();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT * FROM Proveedores_Articulos", Con);
            try
            {
                Comando.Connection.Open();
                SqlDataReader drProveedoresArticulos = Comando.ExecuteReader();

                while (drProveedoresArticulos.Read())
                {
                    Entidades.Proveedor_Articulo prov_arti = new Entidades.Proveedor_Articulo();

                    prov_arti.Nombre = (string)drProveedoresArticulos["nombreProv"];

                    prov_arti.CodigoArticulo = (string)drProveedoresArticulos["codigoArt"];
                    prov_arti.CostoCompraProveedor = (decimal)drProveedoresArticulos["costoCompraProv"];



                    ListaProveedoresArticulos.Add(prov_arti);
                }
                drProveedoresArticulos.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de usuarios", Ex);
                throw ExcepcionManejada;
            }
            finally
           {
               Comando.Connection.Close();
           }



            return ListaProveedoresArticulos;




        }

        public DataTable GetArticulosProveedor(string nombreProveedor)
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT Articulos.codigo, Articulos.descripcion, Proveedores_Articulos.costoCompraProv FROM [Articulos] INNER JOIN [Proveedores_Articulos] on Proveedores_Articulos.codigoArt = (Articulos.codigo)  WHERE (Proveedores_Articulos.nombreProv = @nombreProveedor)", Con);
            Comando.Parameters.Add(new SqlParameter("@nombreProveedor", SqlDbType.NVarChar));
            Comando.Parameters["@nombreProveedor"].Value = nombreProveedor;
            
            //Crea DataTable para ser Origen de la Grilla
            DataTable dataTableArticulosProveedor = new DataTable();
            
            //Creacion de Columnas
            
            DataColumn codigoArtCol = new DataColumn("codigo");
            DataColumn descripcionCol = new DataColumn("descripcion");
            DataColumn costoCompraProvCol = new DataColumn("costoCompraProv");


            //Agrego columnas a DataTable de ArticulosProveedor
           
            dataTableArticulosProveedor.Columns.Add(codigoArtCol);
            dataTableArticulosProveedor.Columns.Add(descripcionCol);
            dataTableArticulosProveedor.Columns.Add(costoCompraProvCol);
            
            try
            {
                Comando.Connection.Open();
                SqlDataReader drCatalogoPorProveedor = Comando.ExecuteReader();
               
                while (drCatalogoPorProveedor.Read())
               
                {
                    DataRow rowArtisProv = dataTableArticulosProveedor.NewRow();
                    
                    rowArtisProv[codigoArtCol] = (string)drCatalogoPorProveedor["codigo"];
                    rowArtisProv[descripcionCol] = (string)drCatalogoPorProveedor["descripcion"];
                    rowArtisProv[costoCompraProvCol] = (decimal)drCatalogoPorProveedor["costoCompraProv"];
                    
                    dataTableArticulosProveedor.Rows.Add(rowArtisProv);
                }
                drCatalogoPorProveedor.Close();

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



            return dataTableArticulosProveedor;
            
        
        }

        public DataTable GetProveedoresArticulo(string codigoArticulo)
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT Proveedores.nombre, Proveedores.telefono, Proveedores_Articulos.costoCompraProv FROM [Proveedores] INNER JOIN [Proveedores_Articulos] on Proveedores_Articulos.nombreProv = (Proveedores.nombre) INNER JOIN [Articulos] on Proveedores_Articulos.codigoArt = Articulos.codigo  WHERE (Articulos.codigo= @codigoArticulo)", Con);
            Comando.Parameters.Add(new SqlParameter("@codigoArticulo", SqlDbType.NVarChar));
            Comando.Parameters["@codigoArticulo"].Value = codigoArticulo;

            //Crea DataTable para ser Origen de la Grilla
            DataTable dataTableProveedoresArticulo = new DataTable();

            //Creacion de Columnas
            DataColumn nombreProvCol = new DataColumn("nombre");
            DataColumn telefonoProvCol = new DataColumn("telefono");
            DataColumn costoCompraProvCol = new DataColumn("costoCompraProv");


            //Agrego columnas a DataTable de ProveedoresArticulo
            dataTableProveedoresArticulo.Columns.Add(nombreProvCol);
            dataTableProveedoresArticulo.Columns.Add(telefonoProvCol);
            dataTableProveedoresArticulo.Columns.Add(costoCompraProvCol);

            try
            {
                Comando.Connection.Open();
                SqlDataReader drCatalogoProvPorArticulo = Comando.ExecuteReader();

                while (drCatalogoProvPorArticulo.Read())
                {
                    DataRow rowProvsArti = dataTableProveedoresArticulo.NewRow();

                    rowProvsArti[nombreProvCol] = (string)drCatalogoProvPorArticulo["nombre"];
                    rowProvsArti[telefonoProvCol] = (string)drCatalogoProvPorArticulo["telefono"];
                    rowProvsArti[costoCompraProvCol] = (decimal)drCatalogoProvPorArticulo["costoCompraProv"];

                    dataTableProveedoresArticulo.Rows.Add(rowProvsArti);
                }
                drCatalogoProvPorArticulo.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Proveedores", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return dataTableProveedoresArticulo;


        }

        public void ModificarCosto(Entidades.Proveedor_Articulo prov_arti_modif)
        {
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "UPDATE [Proveedores_Articulos] SET [nombreProv]=@NOMBREPROV, [codigoArt]=@CODIGOART, [costoCompraProv]=@COSTOCOMPRAPROV WHERE (([codigoArt] = @CODIGOART AND [nombreProv]=@NOMBREPROV))";
            Comando.Parameters.Add(new SqlParameter("@NOMBREPROV", SqlDbType.NVarChar));
            Comando.Parameters["@NOMBREPROV"].Value = prov_arti_modif.Nombre;
            Comando.Parameters.Add(new SqlParameter("@CODIGOART", SqlDbType.NVarChar));
            Comando.Parameters["@CODIGOART"].Value = prov_arti_modif.CodigoArticulo;
            Comando.Parameters.Add(new SqlParameter("@COSTOCOMPRAPROV", SqlDbType.Money));
            Comando.Parameters["@COSTOCOMPRAPROV"].Value = prov_arti_modif.CostoCompraProveedor;

            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
            
        }
       // Quitar (prov_arti) 
    }
}
