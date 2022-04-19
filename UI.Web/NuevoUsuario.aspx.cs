using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.Database;
using Entidades;
using System.Text.RegularExpressions;

public partial class NuevoUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected Boolean validarUsuario(string usu)
    {
        //Consulta BD para no añadir dni repetido
        UsuarioAdapter UsuarioAdapter = new UsuarioAdapter();
        List<Entidades.Usuario> ListaUsuarios = UsuarioAdapter.GetAll();
        foreach (Entidades.Usuario usr in ListaUsuarios)
        {
            if (usr.usuario == usu)
            {
                return false;
            }
        }
        return true;
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        lblAdvertencia.Text="";
        if (txtUsuario.Text == "")
        {
            lblAdvertencia.Text = "El Usuario no puede estar vacio | ";
        }
        else if(validarUsuario(txtUsuario.Text)==false)
        {
            lblAdvertencia.Text = "Ya esta registrado ese nombre de usuario | ";
        }
        if (txtContraseña.Text == "")
        {
            lblAdvertencia.Text = lblAdvertencia.Text + "La contraseña no puede estar vacia | ";
        }
        else
        {
            if (txtRepContraseña.Text == "")
            {
                lblAdvertencia.Text = lblAdvertencia.Text + "Debe repetir la contraseña | ";
            }
            else
            {
                if (validarContraseña() == false)
                {
                    lblAdvertencia.Text = lblAdvertencia.Text + "Las contraseñas no coinciden | ";
                }
            }
        }

        if (txtEmail.Text != "") { validarEmail(); }
        if(lblAdvertencia.Text =="")
        {
            UsuarioAdapter adapter = new UsuarioAdapter();
            Usuario usr = new Usuario();
            usr.Apellido = txtApellido.Text;
            usr.usuario = txtUsuario.Text;
            usr.Contraseña = txtContraseña.Text;
            usr.Nombre = txtNombre.Text;
            usr.Cuil = txtCuil.Text;
            usr.Email = txtEmail.Text;
            usr.Direccion = txtDireccion.Text;
            usr.Telefono = txtTelefono.Text;
            usr.Rol = "Externo";
           
            adapter.AñadirNuevo(usr);            
            Session["Estado"] = "iniciado";
            Session["Usuario"] = txtUsuario.Text;
            Session["Rol"] = "Externo";
            Response.Redirect("Inicio.aspx");
        }     
        
    }

    protected bool validarContraseña()
    {
        if (txtContraseña.Text == txtRepContraseña.Text)
        { return true; }
        else { return false; }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Inicio.aspx");
    }

    protected void validarEmail()
    {
        if (!(Regex.IsMatch(txtEmail.Text, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")))
        {           
            lblAdvertencia.Text += "El email no tiene el formato correcto | ";            
        }
    }
    
}
