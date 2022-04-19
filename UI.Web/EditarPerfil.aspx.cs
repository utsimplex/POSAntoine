using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Entidades;
using Data.Database;
using System.Text.RegularExpressions;

public partial class EditarPerfil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string nombreUsuario = Session["Usuario"].ToString();
        if (!this.IsPostBack)
        {
            UsuarioAdapter adapter = new UsuarioAdapter();
            Usuario usrActual = adapter.GetUsuario(nombreUsuario);
            txtApellido.Text = usrActual.Apellido;
            txtNombre.Text = usrActual.Nombre;
            txtUsuario.Text = usrActual.usuario;
            txtDireccion.Text = usrActual.Direccion;
            txtEmail.Text = usrActual.Email;
            txtTelefono.Text = usrActual.Telefono;
            txtCuil.Text = usrActual.Cuil;
        }
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (txtEmail.Text != "") { validarEmail(); }
        if (validarEditarContraseña() && lblAdvertencia.Text == "")
        {
            txtUsuario.ReadOnly = true;
            UsuarioAdapter adapter = new UsuarioAdapter();
            Usuario usr = new Usuario();
            usr.usuario = txtUsuario.Text;
            if (txtNuevaContraseña.Text == "")
            {
                usr.Contraseña = txtContraseña.Text;
            }
            else
            {
                usr.Contraseña = txtNuevaContraseña.Text;
            }

            usr.Apellido = txtApellido.Text;
            usr.Nombre = txtNombre.Text;
            usr.Cuil = txtCuil.Text;
            usr.Email = txtEmail.Text;
            usr.Direccion = txtDireccion.Text;
            usr.Telefono = txtTelefono.Text;
            Usuario usrActual = adapter.GetUsuario(txtUsuario.Text);
            usr.Rol = usrActual.Rol;

            adapter.Actualizar(usr);
            Response.Redirect("Inicio.aspx");
        }

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

    protected bool validarEditarContraseña()
    {
        UsuarioAdapter adapter = new UsuarioAdapter();
        lblAdvertencia.Text = "";

        if (txtContraseña.Text == "")
        {
            lblAdvertencia.Text = lblAdvertencia.Text + " Debe confirmar la contraseña del usuario |";
        }
        else if (adapter.ValidarUsuario(txtUsuario.Text, txtContraseña.Text) == false)
        {
            lblAdvertencia.Text = lblAdvertencia.Text + " La contraseña no es correcta |";
        }
        if (txtNuevaContraseña.Text != "")
        {
            if (txtNuevaContraseña.Text.Length < 6)
            {
                lblAdvertencia.Text += "La contraseña debe tener una longitud minima de 6 caracteres | ";
            }
        }


        if (txtNuevaContraseña.Text == "" && txtRepContraseña.Text != "")
        {
            lblAdvertencia.Text = lblAdvertencia.Text + " Debe establecer una nueva contraseña |";
        }
        if (txtRepContraseña.Text == "" && txtNuevaContraseña.Text != "")
        {
            lblAdvertencia.Text = lblAdvertencia.Text + " Debe repetir la nueva contraseña |";
        }

        if (txtRepContraseña.Text != "" && txtNuevaContraseña.Text != "" && txtContraseña.Text != "")
        {
            if (txtRepContraseña.Text != txtNuevaContraseña.Text)
            {
                lblAdvertencia.Text = lblAdvertencia.Text + " Las contraseñas no coinciden |";
            }
        }

        if (lblAdvertencia.Text == "")
        { return true; }
        else { return false; }
    }
}
