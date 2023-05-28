using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlServerCe;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Data.Database
{
    public class Ventas_Articulos:Adapter
    {
        //Registro linea de venta una por una
        public void RegistrarLineaVta(Venta_Articulo vtaArticulo)
        {

            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Con;
            Comando.CommandType = CommandType.Text;

            Comando.CommandText = "INSERT INTO [Ventas_Articulos] ([CFVenNumVenta], [CFArtCodigo], [cantidad], [precio], [TipoOperacion]) VALUES (@CFVENNUMVENTA, @CFARTCODIGO, @CANTIDAD, @PRECIO, @TIPOOPERACION)";
            Comando.Parameters.Add(new SqlParameter("@CFVENNUMVENTA", SqlDbType.Int));
            Comando.Parameters["@CFVENNUMVENTA"].Value = vtaArticulo.NumeroVenta;
            Comando.Parameters.Add(new SqlParameter("@CFARTCODIGO", SqlDbType.NVarChar));
            Comando.Parameters["@CFARTCODIGO"].Value = vtaArticulo.CodigoArticulo;
            Comando.Parameters.Add(new SqlParameter("@CANTIDAD", SqlDbType.Int));
            Comando.Parameters["@CANTIDAD"].Value = vtaArticulo.Cantidad;
            Comando.Parameters.Add(new SqlParameter("@PRECIO", SqlDbType.Money));
            Comando.Parameters["@PRECIO"].Value = vtaArticulo.Precio;
            Comando.Parameters.Add(new SqlParameter("@TIPOOPERACION", SqlDbType.NVarChar));
            Comando.Parameters["@TIPOOPERACION"].Value = vtaArticulo.TipoOperacion;


            //Ejecuta el comando INSERT
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();


        }

        ////Modifico linea de venta una por una
        //public void ModificarLineaVta(Venta_Articulo vtaArticulo)
        //{

        //    //Crear Conexion y Abrirla
        //    SqlConnection Con = CrearConexion();

        //    // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
        //    SqlCommand Comando = new SqlCommand();
        //    Comando.Connection = Con;
        //    Comando.CommandType = CommandType.Text;
        //    Comando.CommandText = "UPDATE [Ventas_Articulos] SET [CFVenNumVenta] = @CFVENNUMVENTA, [CFArtCodigo] = @CFARTCODIGO, [cantidad] = @CANTIDAD, [precio] = @PRECIO WHERE [CFVenNumVenta] = @CFVENNUMVENTA";
        //    Comando.Parameters.Add(new SqlParameter("@CFVENNUMVENTA", SqlDbType.Int));
        //    Comando.Parameters["@CFVENNUMVENTA"].Value = vtaArticulo.NumeroVenta;
        //    Comando.Parameters.Add(new SqlParameter("@CFARTCODIGO", SqlDbType.NVarChar));
        //    Comando.Parameters["@CFARTCODIGO"].Value = vtaArticulo.CodigoArticulo;
        //    Comando.Parameters.Add(new SqlParameter("@CANTIDAD", SqlDbType.Int));
        //    Comando.Parameters["@CANTIDAD"].Value = vtaArticulo.Cantidad;
        //    Comando.Parameters.Add(new SqlParameter("@PRECIO", SqlDbType.Money));
        //    Comando.Parameters["@PRECIO"].Value = vtaArticulo.Precio;


        //    //Ejecuta el comando INSERT
        //    Comando.Connection.Open();
        //    Comando.ExecuteNonQuery();
        //    Comando.Connection.Close();


        //}

        //Busca detalles (filas de la factura) 
        public BindingList<Venta_Articulo> GetAll(int numVenta, string tipoOp)
        {
            BindingList<Venta_Articulo> ListaLineaVenta = new BindingList<Venta_Articulo>();
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT Ventas_Articulos.CFVenNumVenta, Ventas_Articulos.CFArtCodigo,Ventas_Articulos.cantidad,Ventas_Articulos.precio, Ventas_Articulos.TipoOperacion, Articulos.descripcion  FROM Ventas_Articulos INNER JOIN Articulos ON Ventas_Articulos.CFArtCodigo = Articulos.codigo WHERE Ventas_Articulos.CFVenNumVenta =" + numVenta + " AND Ventas_Articulos.TipoOperacion = '" + tipoOp +"'", Con);
            try
            {
                Comando.Connection.Open();
                SqlDataReader drLineaVenta = Comando.ExecuteReader();

                while (drLineaVenta.Read())
                {
                    Venta_Articulo vtaArticulo = new Venta_Articulo();

                    vtaArticulo.NumeroVenta = (int)drLineaVenta["cfvennumventa"];
                    vtaArticulo.CodigoArticulo = (string)drLineaVenta["cfartcodigo"];
                    vtaArticulo.DescripcionArticulo = (string)drLineaVenta["descripcion"];
                    vtaArticulo.Cantidad = (int)drLineaVenta["cantidad"];
                    vtaArticulo.Precio = (decimal)drLineaVenta["precio"];
                    vtaArticulo.Subtotal = (decimal)( vtaArticulo.Cantidad * vtaArticulo.Precio);
                    vtaArticulo.TipoOperacion = (string)drLineaVenta["tipooperacion"];

                    ListaLineaVenta.Add(vtaArticulo);
                }
                drLineaVenta.Close();

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



            return ListaLineaVenta;




        }

        //Para backUP de detalles.
        public List<Venta_Articulo> GetAll()
        {
            List<Venta_Articulo> ListaLineaVenta = new List<Venta_Articulo>();
            
            //Crear Conexion y Abrirla
            SqlConnection Con = CrearConexion();

            // Crear SqlCommand - Asignarle la conexion - Asignarle la instruccion SQL (consulta)
            SqlCommand Comando = new SqlCommand("SELECT Ventas_Articulos.CFVenNumVenta, Ventas_Articulos.CFArtCodigo, Ventas_Articulos.cantidad, Ventas_Articulos.precio, Ventas_Articulos.TipoOperacion FROM Ventas_Articulos", Con);
            
            try
            {
                Comando.Connection.Open();
                SqlDataReader drLineaVenta = Comando.ExecuteReader();

                while (drLineaVenta.Read())
                {
                    Venta_Articulo vtaArticulo = new Venta_Articulo();

                    vtaArticulo.NumeroVenta = (int)drLineaVenta["cfvennumventa"];
                    vtaArticulo.CodigoArticulo = (string)drLineaVenta["cfartcodigo"];
                    vtaArticulo.Cantidad = (int)drLineaVenta["cantidad"];
                    vtaArticulo.Precio = (decimal)drLineaVenta["precio"];
                    vtaArticulo.TipoOperacion = (string)drLineaVenta["tipooperacion"];
                    


                    ListaLineaVenta.Add(vtaArticulo);
                }
                drLineaVenta.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el detalle de la lista de Ventas", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                Comando.Connection.Close();
            }



            return ListaLineaVenta;




        }
    }
}
