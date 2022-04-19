using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.Database;
using Entidades;

public partial class Articulos : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void gvProveedores_SelectedIndexChanged(object sender, EventArgs e)
    {
        mostrar();

        lbtnAñadirNuevo.Visible = false;
        btnCancelar.Visible = true;
        btnGuardar.Visible = true;
        btnAñadir.Visible = false;

        txtCodigo.ReadOnly = true;

        if (gvArticulos.SelectedRow.Cells[1].Text == "&nbsp;")
        {
            txtCodigo.Text = "";
        }
        else
        {
            txtCodigo.Text = gvArticulos.SelectedRow.Cells[1].Text;
        }
        if (gvArticulos.SelectedRow.Cells[2].Text == "&nbsp;")
        {
            txtDescripcion.Text = "";
        }
        else
        {
            txtDescripcion.Text = gvArticulos.SelectedRow.Cells[2].Text;
        }
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        ArticuloAdapter adapter = new ArticuloAdapter();
        Articulo arti = new Articulo();
        arti.Codigo = txtCodigo.Text;
        arti.Descripcion = txtDescripcion.Text;
        arti.Stock = Convert.ToInt32(txtStock.Text);
        arti.StockMin = Convert.ToInt32(txtStockMin.Text);
        arti.Precio = Convert.ToInt32(txtPrecio.Text);

        ocultar();
        btnCancelar.Visible = false;
        btnGuardar.Visible = false;
                
        txtCodigo.ReadOnly = true;
        adapter.Actualizar(arti);
        gvArticulos.DataSourceID = "odsArticulos";
        lbtnAñadirNuevo.Visible = true;

    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        ocultar();

        txtCodigo.ReadOnly = true;
        
        btnCancelar.Visible = false;
        btnGuardar.Visible = false;
        btnAñadir.Visible = false;
                
        lbtnAñadirNuevo.Visible = true;
    }

    protected void lbtnAñadirNuevo_Click(object sender, EventArgs e)
    {
        txtCodigo.Text = "";
        txtDescripcion.Text = "";
        txtStock.Text = "";
        txtStockMin.Text = "";
        txtPrecio.Text = "";

        mostrar();
                
        btnCancelar.Visible = true;
        btnAñadir.Visible = true;
        
        txtCodigo.ReadOnly = false;

    }

    protected Boolean validarArticulo(string dni)
    {
        //Consulta BD para no añadir dni repetido
        ArticuloAdapter adapter = new ArticuloAdapter();
        List<Entidades.Articulo> ListaArticulos = adapter.GetAll();
        foreach (Entidades.Articulo art in ListaArticulos)
        {
            if (art.Codigo == txtCodigo.Text)
            {
                return false;
            }
        }
        return true;
    }

    protected void btnAñadir_Click(object sender, EventArgs e)
    {
        
        lblAdvertencia.Text = "";
        if (txtCodigo.Text == "")
        {
            lblAdvertencia.Text = lblAdvertencia.Text + "El codigo no puede estar vacio /";
        }
        if (validarArticulo(txtCodigo.Text) == false)
        {
            lblAdvertencia.Text = lblAdvertencia.Text + " Ya hay un articulo registrado con ese codigo /";
        }
        if (txtStock.Text == "")
        {
            lblAdvertencia.Text = lblAdvertencia.Text + " El stock no puede estar vacio /";
        }
        if (txtStockMin.Text == "")
        {
            lblAdvertencia.Text = lblAdvertencia.Text + " El stock minimo no puede estar vacio /";
        }
        if (txtPrecio.Text == "")
        {
            lblAdvertencia.Text = lblAdvertencia.Text + "El precio no puede estar vacio / ";
        }
        if ((txtCodigo.Text != "") && (validarArticulo(txtCodigo.Text) != false) && (txtStock.Text != "") && (txtStockMin.Text != "") && (txtPrecio.Text != "")) 
        {
            txtCodigo.ReadOnly = true;
            ArticuloAdapter adapter = new ArticuloAdapter();
            Articulo arti = new Articulo();
            arti.Codigo = txtCodigo.Text;
            arti.Descripcion = txtDescripcion.Text;
            arti.Stock = Convert.ToInt32(txtStock.Text);
            arti.StockMin = Convert.ToInt32(txtStockMin.Text);
            arti.Precio = Convert.ToInt32(txtPrecio.Text);

            ocultar();

            btnCancelar.Visible = false;
            btnGuardar.Visible = false;
            btnAñadir.Visible = false;

            txtCodigo.ReadOnly = true;

            adapter.AñadirNuevo(arti);
            gvArticulos.DataSourceID = "odsArticulos";


        }
    }

    protected void txtTelefono_TextChanged(object sender, EventArgs e)
    {

    }

    protected void mostrar()
    {
        lblCodigo.Visible = true;
        lblDescripcion.Visible = true;
        lblStock.Visible = true;
        lblStockMin.Visible = true;
        lblPrecio.Visible = true;
        
        imgArticulo.Visible = true;
    
        txtCodigo.Visible = true;
        txtDescripcion.Visible = true;
        txtStock.Visible = true;
        txtStockMin.Visible = true;
        txtPrecio.Visible = true;

        lblAdvertencia.Text = "";
        lblAdvertencia.Visible = true;
    }

    protected void ocultar()
    {
        lblCodigo.Visible = false;
        lblDescripcion.Visible = false;
        lblStock.Visible = false;
        lblStockMin.Visible = false;
        lblPrecio.Visible = false;

        imgArticulo.Visible = false;

        txtCodigo.Visible = false;
        txtDescripcion.Visible = false;
        txtStock.Visible = false;
        txtStockMin.Visible = false;
        txtPrecio.Visible = false;

        lblAdvertencia.Visible = false;
    }
}

