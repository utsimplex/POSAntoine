using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.Database;
using Entidades;
using System.Text.RegularExpressions;

public partial class Proveedores : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void gvProveedores_SelectedIndexChanged(object sender, EventArgs e)
    {
        mostrar();

        btnCancelar.Visible = true;
        btnGuardar.Visible = true;
        btnAñadir.Visible = false;

        txtNombre.ReadOnly = true;

        lbtnAñadirNuevo.Visible = false;
        if (gvProveedores.SelectedRow.Cells[1].Text == "&nbsp;")
        {
            txtNroDoc.Text = "";
        }
        else
        {
            txtNroDoc.Text = gvProveedores.SelectedRow.Cells[1].Text;
        }
        if (gvProveedores.SelectedRow.Cells[2].Text == "&nbsp;")
        {
            txtNombre.Text = "";
        }
        else
        {
            txtNombre.Text = gvProveedores.SelectedRow.Cells[2].Text;
        }
        if (gvProveedores.SelectedRow.Cells[4].Text == "&nbsp;")
        {
            txtTelefono.Text = "";
        }
        else
        {
            txtTelefono.Text = gvProveedores.SelectedRow.Cells[4].Text;
        }
        if (gvProveedores.SelectedRow.Cells[5].Text == "&nbsp;")
        {
            txtDireccion.Text = "";
        }
        else
        {
            txtDireccion.Text = gvProveedores.SelectedRow.Cells[5].Text;
        }
        if (gvProveedores.SelectedRow.Cells[3].Text == "&nbsp;")
        {
            txtEmail.Text = "";
        }
        else
        {
           txtEmail.Text = gvProveedores.SelectedRow.Cells[3].Text;
        }
        

    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (txtEmail.Text != "") { validarEmail(); }
        if (lblAdvertencia.Text == "")
        {
            ProveedorAdapter adapter = new ProveedorAdapter();
            Proveedor prov = new Proveedor();
            prov.Nombre = txtNombre.Text;
            prov.Dni = txtNroDoc.Text;
            prov.Email = txtEmail.Text;
            prov.Direccion = txtDireccion.Text;
            prov.Telefono = txtTelefono.Text;

            ocultar();

            btnCancelar.Visible = false;
            btnGuardar.Visible = false;
            txtNombre.ReadOnly = true;
            adapter.Actualizar(prov);
            gvProveedores.DataSourceID = "odsProveedores";
            lbtnAñadirNuevo.Visible = true;
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        ocultar();
        
        btnCancelar.Visible = false;
        btnGuardar.Visible = false;
        btnAñadir.Visible = false;
        
        lbtnAñadirNuevo.Visible = true;
        
        txtNombre.ReadOnly = true;
    }

    protected void lbtnAñadirNuevo_Click(object sender, EventArgs e)
    {
        txtNombre.Text = "";
        txtNroDoc.Text = "";
        txtEmail.Text = "";
        txtDireccion.Text = "";
        txtTelefono.Text = "";

        mostrar();
        
        btnCancelar.Visible = true;
        btnAñadir.Visible = true;
        
        txtNombre.ReadOnly = false;     
    }

    protected Boolean validarProveedor(string dni)
    {
        //Consulta BD para no añadir dni repetido
        ProveedorAdapter adapter = new ProveedorAdapter();
        List<Entidades.Proveedor> ListaProveedores = adapter.GetAll();
        foreach (Entidades.Proveedor prov in ListaProveedores)
        {
            if (prov.Nombre.ToLower() == txtNombre.Text.ToLower())
            {
                return false;
            }
        }
        return true;
    }

    protected void btnAñadir_Click(object sender, EventArgs e)
    {
        
        lblAdvertencia.Text = "";
        if (txtNombre.Text == "")
        {
            lblAdvertencia.Text = "El nombre no puede estar vacio | ";
        }
        else if (validarProveedor(txtNroDoc.Text) == false)
        {
            lblAdvertencia.Text = "Ya hay un proveedor registrado con ese nombre | ";
        }
        if (txtEmail.Text != "") { validarEmail(); }
        if (lblAdvertencia.Text == "") 
        {
            txtNroDoc.ReadOnly = true;
            ProveedorAdapter adapter = new ProveedorAdapter();
            Proveedor prov = new Proveedor();
            prov.Nombre = txtNombre.Text;
            prov.Dni = txtNroDoc.Text;
            prov.Email = txtEmail.Text;
            prov.Direccion = txtDireccion.Text;
            prov.Telefono = txtTelefono.Text;

            ocultar();

            btnCancelar.Visible = false;
            btnGuardar.Visible = false;
            btnAñadir.Visible = false;

            txtNombre.ReadOnly = true;

            adapter.AñadirNuevo(prov);
            gvProveedores.DataSourceID = "odsProveedores";


        }
    }
    
    protected void txtTelefono_TextChanged(object sender, EventArgs e)
    {

    }
    
    protected void lbtnAñadirNuevo_Click1(object sender, EventArgs e)
    {
        txtNombre.Text = "";
        txtNroDoc.Text = "";
        txtEmail.Text = "";
        txtDireccion.Text = "";
        txtTelefono.Text = "";

        mostrar();

        btnCancelar.Visible = true;
        btnAñadir.Visible = true;
        txtNombre.ReadOnly = false;
    }

    protected void ocultar()
    {

        lblNombre.Visible = false;
        lblDireccion.Visible = false;
        lblTelefono.Visible = false;
        lblEmail.Visible = false;
        lblNumeroDoc.Visible = false;

        imgProveedor.Visible = false;

        txtNombre.Visible = false;
        txtEmail.Visible = false;
        txtNroDoc.Visible = false;
        txtTelefono.Visible = false;
        txtDireccion.Visible = false;

        lblAdvertencia.Visible = false;
    }
    
    protected void mostrar()
    {
        lblNombre.Visible = true;
        lblDireccion.Visible = true;
        lblTelefono.Visible = true;
        lblEmail.Visible = true;
        lblNumeroDoc.Visible = true;

        imgProveedor.Visible = true;

        txtNombre.Visible = true;
        txtEmail.Visible = true;
        txtNroDoc.Visible = true;
        txtTelefono.Visible = true;
        txtDireccion.Visible = true;

        lblAdvertencia.Text = "";
        lblAdvertencia.Visible = true;
    }
    
    protected void validarEmail()
    {
        if (!(Regex.IsMatch(txtEmail.Text, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")))
        {
            lblAdvertencia.Text += "El email no tiene el formato correcto | ";
            
        }
    }
       
}
