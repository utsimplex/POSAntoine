using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Data.Database;
using Entidades;
using System.Web.UI.WebControls;


public partial class Mater : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string estado = (string)(Session["Estado"]);
        if (estado == "iniciado")
        {
            lblIniciar.Visible = false;
            txtContraseña.Visible = false;
            txtUsuario.Visible = false;
            lblArvertencias.Visible = false;
            btnIniciarSesion.Visible = false;
            lblUsuario.Visible = false;
            lblContraseña.Visible = false;
            lbtnCerrarSesion.Visible = true;
            lbtnEditarUsuario.Visible = true;
            lbtnNuevoUsuario.Visible = false;
            lblUsr.Visible = true;
            string usuario = (string)(Session["Usuario"]);
            lblUsrActual.Text = usuario + " | "; 
        }
        else
        {
            lblIniciar.Visible = true;
            txtContraseña.Visible = true;
            txtUsuario.Visible = true;
            lbtnEditarUsuario.Visible = false;
            lblArvertencias.Visible = true;
            btnIniciarSesion.Visible = true;
            lbtnNuevoUsuario.Visible = true;
            lblUsuario.Visible = true;
            lblContraseña.Visible = true;
            lbtnCerrarSesion.Visible = false;
            lbtnEditarUsuario.Visible = false;
            lblUsr.Visible = false;
            MenuEmpleados.Visible = false;
            
        }
        string rol = (string)(Session["Rol"]);
        if (rol == "Administrador")
        {
            MenuEmpleados.Visible = true;
            MenuUsuarios.Visible = true;            
        }
        else if (rol == "Empleado")
        {
            MenuEmpleados.Visible = true;
            MenuUsuarios.Visible = false;
        }
        else if (rol == "Externo")
        {
            MenuEmpleados.Visible = false;
            MenuUsuarios.Visible = false;
        }
        
    }
    
    protected void btnIniciarSesion_Click(object sender, EventArgs e)
    {
        lblArvertencias.Text = "";
        UsuarioAdapter adapter = new UsuarioAdapter();
        if (txtUsuario.Text == "" && txtContraseña.Text == "")
        {
            lblArvertencias.Text = "Es necesario completar el usuario y la contraseña";
        }
        else if (txtContraseña.Text == "")
        {
            lblArvertencias.Text = "Es necesario completar la contraseña";
        }
        else if (txtUsuario.Text == "")
        {
            lblArvertencias.Text = "Es necesario completar el usuario";
        }
        else
        {
            if (adapter.ValidarUsuario(txtUsuario.Text, txtContraseña.Text))
            {
                string estado = "iniciado";
                Session["Estado"] = estado;
                Session["Usuario"] = txtUsuario.Text;
                Usuario usr = adapter.GetUsuario(txtUsuario.Text);
                Session["Rol"] = usr.Rol;
                lblIniciar.Visible = false;
                txtContraseña.Visible = false;
                txtUsuario.Visible = false;
                lblArvertencias.Visible = false;
                btnIniciarSesion.Visible = false;
                lblUsuario.Visible = false;
                lblContraseña.Visible = false;
                lbtnCerrarSesion.Visible = true;
                lbtnEditarUsuario.Visible = true;
                lblUsr.Visible = true;
                lblUsrActual.Text = txtUsuario.Text + " | ";

                string rol = (string)(Session["Rol"]);
                if (rol == "Administrador")
                {
                    MenuEmpleados.Visible = true;
                    MenuUsuarios.Visible = true;
                }
                else if (rol == "Empleado")
                {
                    MenuEmpleados.Visible = true;
                    MenuUsuarios.Visible = false;
                }
                else if (rol == "Externo")
                {
                    MenuEmpleados.Visible = false;
                    MenuUsuarios.Visible = false;
                }
                lbtnNuevoUsuario.Visible = false;
            }
            else
            {
                lblArvertencias.Text = "Usuario y/o contraseña incorrectos!";
            }
        }
    }
    
    protected void txtUsuario_TextChanged(object sender, EventArgs e)
    {
        lblArvertencias.Text = "";  

    }
    
    protected void lbtnCerrarSesion_Click(object sender, EventArgs e)
    {
        string estado = "cerrado";
        Session["Estado"] = estado;
        Session["Usuario"] = "";
        lblIniciar.Visible = true;
        txtContraseña.Visible = true;
        txtUsuario.Visible = true;
        lblArvertencias.Visible = true;
        btnIniciarSesion.Visible = true;
        lblUsuario.Visible = true;
        lblContraseña.Visible = true;
        lbtnCerrarSesion.Visible = false;
        lblUsr.Visible = false;
        lblUsrActual.Text = "";
        MenuEmpleados.Visible = false;
        MenuUsuarios.Visible = false;
        lbtnEditarUsuario.Visible = false;
        Response.Redirect("Inicio.aspx");
        lbtnNuevoUsuario.Visible = false;
    }

    protected void lbtnEditarUsuario_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditarPerfil.aspx");    
    }
    protected void lbtnNuevoUsuario_Click(object sender, EventArgs e)
    {
        Response.Redirect("NuevoUsuario.aspx");
    }
}
