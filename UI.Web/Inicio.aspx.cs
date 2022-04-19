using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.Database;
using Entidades;
using System.Data;

public partial class Inicio : System.Web.UI.Page
{
    protected DataTable dtSeleccionados;

    protected void ocultar()
    {
        gvArticulos.Visible = false;
        gvPedido.Visible = false;
        lblTotal.Visible = false;
        txtTotal.Visible = false;
        lblInsertar.Visible = true;
        lblCantidad.Visible = true;
        lbArticulo.Visible = true;
        txtArticulo.Visible = true;
        txtCantidad.Visible = true;
        txtCantidad.Text = "";
        btnAceptar.Visible = true;
        lblMensaje.Visible = true;
    }
    protected void mostrar()
    {
        gvArticulos.Visible = true;
        gvPedido.Visible = true;
        if (gvPedido.Rows.Count == 0)
        {
            lblTotal.Visible = false;
            txtTotal.Visible = false;
        }
        else
        {
            lblTotal.Visible = true;
            txtTotal.Visible = true;
        }
        
        lblInsertar.Visible = false;
        lblCantidad.Visible = false;
        lbArticulo.Visible = false;
        txtArticulo.Visible = false;
        txtCantidad.Visible = false;
        btnAceptar.Visible = false;
        lblMensaje.Visible = false;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        mostrar();
        dtSeleccionados = new DataTable("Articulos_Seleccionados");
        dtSeleccionados.Columns.Add("Código", typeof(string));
        dtSeleccionados.Columns.Add("Articulo", typeof(string));
        dtSeleccionados.Columns.Add("Precio unitario", typeof(double));
        dtSeleccionados.Columns.Add("Cantidad", typeof(int));
        dtSeleccionados.Columns.Add("Total", typeof(double));
        if (this.IsPostBack == false)
        {
            gvPedido.DataSource = dtSeleccionados;
            gvPedido.DataBind();
            txtTotal.Text ="0";
        }
        else
        {
            foreach (GridViewRow rw in gvPedido.Rows)
            {
                DataRow fila = dtSeleccionados.NewRow();
                fila["Código"] = rw.Cells[1].Text;
                fila["Articulo"] = rw.Cells[2].Text;
                fila["Precio unitario"] = Convert.ToDouble(rw.Cells[3].Text);
                fila["Cantidad"] = Convert.ToInt32(rw.Cells[4].Text);
                fila["Total"] = Convert.ToDouble(rw.Cells[5].Text);
                dtSeleccionados.Rows.Add(fila);
            }
        }
 
    
    }

    protected void incorporarProducto(string codigo)
    {  
        ocultar();
        txtArticulo.Text = codigo;
        if (validarArticuloEnTabla(codigo))
        {
            lblInsertar.Text = "El articulo seleccionado ya se encuentra en el presupuesto ingrese la cantidad a agregar";
        }

    }

    protected bool validarArticuloEnTabla(string codigo)
    {
        foreach (DataRow fila in dtSeleccionados.Rows)
        {
            if (fila["Código"].ToString() == codigo)
            {
                return true;
            }                      
        }
        return false;
       
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {        
        lblMensaje.Text = "";
        try
        {
            int nro;
            nro = Convert.ToInt32(txtCantidad.Text);
            ArticuloAdapter adapter = new ArticuloAdapter();
            Articulo art = adapter.BuscarArticulo(txtArticulo.Text);
            DataRow fila = dtSeleccionados.NewRow();

            if (lblInsertar.Text == "Inserte cantidad del articulo")
            {
                fila["Código"] = art.Codigo;
                fila["Articulo"] = art.Descripcion;
                fila["Precio unitario"] = Convert.ToString(art.Precio);
                fila["Cantidad"] = nro.ToString();
                fila["Total"] = nro * (art.Precio.ToDouble());
                dtSeleccionados.Rows.Add(fila);

                txtTotal.Text = (  (Convert.ToDouble(txtTotal.Text)) +  (Convert.ToDouble(fila[4].ToString()))  ).ToString();                        
                    
            }
            else
            {
                txtTotal.Text = "0";
                if (lblInsertar.Text == "Ingrese la nueva cantidad")
                {
                    foreach (DataRow fil in dtSeleccionados.Rows)
                    {
                        if (fil["Código"].ToString() == art.Codigo)
                        {
                            fil["Cantidad"] = nro;
                            fil["Total"] = (Convert.ToDouble(fil["Cantidad"]) * Convert.ToDouble(fil["Precio unitario"]));
                        }
                        txtTotal.Text = (Convert.ToInt32(txtTotal.Text) + (Convert.ToDouble(fil["Cantidad"]) * Convert.ToDouble(fil["Precio unitario"]))).ToString();                        
                    }
                }
                else
                {
                    foreach (DataRow fil in dtSeleccionados.Rows)
                    {
                        if (fil["Código"].ToString() == art.Codigo)
                        {
                            fil["Cantidad"] = (Convert.ToInt32(fil["Cantidad"]) + nro);
                            fil["Total"] = (Convert.ToDouble(fil["Cantidad"]) * Convert.ToDouble(fil["Precio unitario"]));
                        }
                        txtTotal.Text = (Convert.ToInt32(txtTotal.Text) + (Convert.ToDouble(fil["Cantidad"]) * Convert.ToDouble(fil["Precio unitario"]))).ToString();
                   }
                }
                lblInsertar.Text = "Inserte cantidad del articulo";
            }            
            gvPedido.DataSource = null;
            gvPedido.DataSource = dtSeleccionados;
            gvPedido.DataBind();
            mostrar();

       }
       catch
        {
            ocultar();
            lblMensaje.Text = "Debe ingresar un numero en el campo de cantidad";
            
        }
    }        

    protected void gvArticulos_SelectedIndexChanged(object sender, EventArgs e)
    {
        incorporarProducto(gvArticulos.SelectedRow.Cells[0].Text);

    }

    protected void gvArticulos_SelectedIndexChanged(object sender, GridViewSelectEventArgs e)
    {

    }
   
    protected void btnLimpiar_Click(object sender, EventArgs e)
    {
        this.Response.Redirect("Inicio.aspx");
    }
    
    protected void gvPedido_SelectedIndexChanged(object sender, EventArgs e)
    {
        quitar(gvPedido.SelectedRow.Cells[1].Text);
    }
    
    protected void quitar(string codigo)
    {
        for (int i = 0; i < dtSeleccionados.Rows.Count; i++)
	    {
			 if (dtSeleccionados.Rows[i]["Código"].ToString() == codigo)
            {
                txtTotal.Text = (Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(dtSeleccionados.Rows[i]["Total"].ToString())).ToString();
                dtSeleccionados.Rows[i].Delete();
            }
		}
        gvPedido.DataSource = dtSeleccionados;
        gvPedido.DataBind();

    }
    
    protected void gvPedido_Editar(object sender, GridViewEditEventArgs e)
    {
        ocultar();
        lblInsertar.Text = "Ingrese la nueva cantidad";
        gvPedido.EditIndex = e.NewEditIndex;
        txtArticulo.Text = gvPedido.Rows[gvPedido.EditIndex].Cells[1].Text;
        txtCantidad.Text = gvPedido.Rows[gvPedido.EditIndex].Cells[4].Text;
        gvPedido.EditIndex = -1;
    }
}
