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

public partial class Usuarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void mostrar()
    {
        imgUsuario.Visible = true;

        lblAdvertencia.Visible = true;
        lblApellido.Visible = true;
        lblContraseña.Visible = true;
        lblNuevaContraseña.Visible = true;
        lblDireccion.Visible = true;
        lblEmail.Visible = true;
        lblNombre.Visible = true;
        lblCuil.Visible = true;
        lblRepContraseña.Visible = true;
        lblTelefono.Visible = true;
        lblUsuario.Visible = true;
        lblRol.Visible = true;
        rbtnRol.Visible = true;

        txtContraseña.Visible = true;
        txtApellido.Visible = true;
        txtNuevaContraseña.Visible = true;
        txtDireccion.Visible = true;
        txtEmail.Visible = true;
        txtNombre.Visible = true;
        txtCuil.Visible = true;
        txtRepContraseña.Visible = true;
        txtTelefono.Visible = true;
        txtUsuario.Visible = true;

    }

    protected void ocultar()
    {
        imgUsuario.Visible = false;

        lblContraseña.Visible = false;
        lblAdvertencia.Visible = false;
        lblApellido.Visible = false;
        lblNuevaContraseña.Visible = false;
        lblDireccion.Visible = false;
        lblEmail.Visible = false;
        lblNombre.Visible = false;
        lblCuil.Visible = false;
        lblRepContraseña.Visible = false;
        lblTelefono.Visible = false;
        lblUsuario.Visible = false;
        lblRol.Visible = false;
        rbtnRol.Visible = false;

        txtContraseña.Visible = false;
        txtApellido.Visible = false;
        txtNuevaContraseña.Visible = false;
        txtDireccion.Visible = false;
        txtEmail.Visible = false;
        txtNombre.Visible = false;
        txtCuil.Visible = false;
        txtRepContraseña.Visible = false;
        txtTelefono.Visible = false;
        txtUsuario.Visible = false;

        txtContraseña.Text = "";
        txtApellido.Text = "";
        txtNuevaContraseña.Text = "";
        txtDireccion.Text = "";
        txtEmail.Text = "";
        txtNombre.Text = "";
        txtCuil.Text = "";
        txtRepContraseña.Text = "";
        txtTelefono.Text = "";
        txtUsuario.Text = "";

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

    protected void btnAñadir_Click(object sender, EventArgs e)
    {
        lblAdvertencia.Text="";
        validarRol();
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
            usr.Rol = rbtnRol.SelectedItem.Value;

            ocultar();          
            btnCancelar.Visible = false;
            btnGuardar.Visible = false;
            btnAñadir.Visible = false;
           
            txtUsuario.ReadOnly = true;

            adapter.AñadirNuevo(usr);
            gvUsuarios.DataSourceID = "odsUsuarios";
        }     
        
    }

    protected void gvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtUsuario.ReadOnly = true;
        mostrar();

        btnCancelar.Visible = true;
        btnGuardar.Visible = true;
        btnAñadir.Visible = false;
        lbtnAñadirNuevo.Visible = false;

        if (gvUsuarios.SelectedRow.Cells[1].Text == "&nbsp;")
        {txtUsuario.Text = "";}
        else {txtUsuario.Text = gvUsuarios.SelectedRow.Cells[1].Text;}

        if (gvUsuarios.SelectedRow.Cells[2].Text == "&nbsp;")
        {txtNombre.Text = "";}
        else { txtNombre.Text = gvUsuarios.SelectedRow.Cells[2].Text; }
        
        if (gvUsuarios.SelectedRow.Cells[3].Text == "&nbsp;")
        {txtApellido.Text = "";}
        else { txtApellido.Text = gvUsuarios.SelectedRow.Cells[3].Text; }

        if (gvUsuarios.SelectedRow.Cells[4].Text == "&nbsp;")
        {txtTelefono.Text = "";}
        else { txtTelefono.Text = gvUsuarios.SelectedRow.Cells[4].Text; }

        if (gvUsuarios.SelectedRow.Cells[5].Text == "&nbsp;")
        {txtEmail.Text = "";}
        else { txtEmail.Text = gvUsuarios.SelectedRow.Cells[5].Text; }


        if (gvUsuarios.SelectedRow.Cells[6].Text == "&nbsp;")
        { txtCuil.Text = "";}
        else { txtCuil.Text = gvUsuarios.SelectedRow.Cells[6].Text; }

        if (gvUsuarios.SelectedRow.Cells[7].Text == "&nbsp;")
        { txtDireccion.Text = ""; }
        else { txtDireccion.Text = gvUsuarios.SelectedRow.Cells[7].Text; }

        rbtnRol.SelectedValue = gvUsuarios.SelectedRow.Cells[8].Text;
        

    }

//  VALIDAR EDITAR CONTRASEÑA
    protected bool validarEditarContraseña()
    {
        UsuarioAdapter adapter = new UsuarioAdapter();
        lblAdvertencia.Text = "";

        if (txtContraseña.Text == "" && txtNuevaContraseña.Text != "")
        {
            lblAdvertencia.Text = lblAdvertencia.Text + " Debe confirmar la contraseña antigua para cambiarla  |";
        }
        if (txtContraseña.Text != "")
        {
            if (adapter.ValidarUsuario(txtUsuario.Text, txtContraseña.Text) == false)
            {
                lblAdvertencia.Text = lblAdvertencia.Text + " La contraseña no es correcta |";
            }
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
    
    
    protected bool validarContraseña()
    {
        if (txtContraseña.Text == txtRepContraseña.Text)
        { return true; }
        else { return false; }
    }

    protected void validarRol()
    {
        if (rbtnRol.SelectedItem == null)
        {
            lblAdvertencia.Text += "Debe seleccionar un rol para el usuario";
        }
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (txtEmail.Text != "") { validarEmail(); }
        validarRol();
        if (validarEditarContraseña() && lblAdvertencia.Text=="")
        {
            txtUsuario.ReadOnly = true;
            UsuarioAdapter adapter = new UsuarioAdapter();
            Usuario usr = new Usuario();
            Usuario antUsr = adapter.GetUsuario(txtUsuario.Text);
            usr.usuario = txtUsuario.Text;
            if (txtNuevaContraseña.Text == "")
            {
                if (txtContraseña.Text == "")
                {
                    usr.Contraseña = antUsr.Contraseña;
                }
                else
                {
                    usr.Contraseña = txtContraseña.Text;
                }
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
            usr.Rol = rbtnRol.SelectedItem.Value;

            ocultar();

            btnCancelar.Visible = false;
            btnGuardar.Visible = false;
            adapter.Actualizar(usr);
            gvUsuarios.DataSourceID = "odsUsuarios";
            lbtnAñadirNuevo.Visible = true;
        }

    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        txtUsuario.ReadOnly = true;
        ocultar();
        lbtnAñadirNuevo.Visible = true;
        btnCancelar.Visible = false;
        btnGuardar.Visible = false;
        btnAñadir.Visible = false;
    }
    
    protected void lbtnAñadirNuevo_Click(object sender, EventArgs e)
    {
        mostrar();
        txtUsuario.ReadOnly = false;
        txtNuevaContraseña.Visible = false;
        lblNuevaContraseña.Visible = false;
        btnCancelar.Visible = true;
        btnAñadir.Visible = true;
    }

    protected void validarEmail()
    {
        if (!(Regex.IsMatch(txtEmail.Text, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")))
        {           
            lblAdvertencia.Text += "El email no tiene el formato correcto | ";            
        }
    }
}
