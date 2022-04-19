using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.Database;
using Entidades;
using System.Text.RegularExpressions;

public partial class Clientes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void gvClientes_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtNroDoc.ReadOnly = true;

        mostrar();
        
        btnCancelar.Visible = true;
        btnGuardar.Visible = true;
        btnAñadir.Visible = false;
        lbtnAñadirNuevo.Visible = false;        

        if (gvClientes.SelectedRow.Cells[1].Text == "&nbsp;")
        {
            txtNroDoc.Text = "";
        }
        else
        {
            txtNroDoc.Text = gvClientes.SelectedRow.Cells[1].Text;
        }
        
         if (gvClientes.SelectedRow.Cells[2].Text == "&nbsp;")
        {
            txtNombre.Text = "";
        }
        else
        {
            txtNombre.Text = gvClientes.SelectedRow.Cells[2].Text;
        }

        
         if (gvClientes.SelectedRow.Cells[3].Text == "&nbsp;")
        {
            txtApellido.Text = "";
        }
        else
        {
            txtApellido.Text = gvClientes.SelectedRow.Cells[3].Text;
        }
        
        if (gvClientes.SelectedRow.Cells[4].Text == "&nbsp;")
        {
            txtTelefono.Text = "";
        }
        else
        {
            txtTelefono.Text = gvClientes.SelectedRow.Cells[4].Text;
        }
        
        if (gvClientes.SelectedRow.Cells[5].Text == "&nbsp;")
        {
            txtDireccion.Text = "";
        }
        else
        {
            txtDireccion.Text = gvClientes.SelectedRow.Cells[5].Text;
        }
        if (gvClientes.SelectedRow.Cells[6].Text == "&nbsp;")
        {
            txtEmail.Text = "";
        }
        else
        {
            txtEmail.Text = gvClientes.SelectedRow.Cells[6].Text;
        }
        

    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (txtEmail.Text != "") { validarEmail(); }
        if (lblAdvertencia.Text == "")
        {
            txtNroDoc.ReadOnly = true;
            ClienteAdapter adapter = new ClienteAdapter();
            Cliente cli = new Cliente();
            cli.Apellido = txtApellido.Text;
            cli.Nombre = txtNombre.Text;
            cli.Dni = txtNroDoc.Text;
            cli.Email = txtEmail.Text;
            cli.Direccion = txtDireccion.Text;
            cli.Telefono = txtTelefono.Text;

            ocultar();

            btnCancelar.Visible = false;
            btnGuardar.Visible = false;
            adapter.Actualizar(cli);
            gvClientes.DataSourceID = "odsClientes";
            lbtnAñadirNuevo.Visible = true;
        }

    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        txtNroDoc.ReadOnly = true;

        ocultar();

        lbtnAñadirNuevo.Visible = true;
        
        btnCancelar.Visible = false;
        btnGuardar.Visible = false;
        btnAñadir.Visible = false;
    }

    protected void lbtnAñadirNuevo_Click(object sender, EventArgs e)
    {
        txtApellido.Text = "";
        txtNombre.Text = "";
        txtNroDoc.Text = "";
        txtEmail.Text = "";
        txtDireccion.Text = "";
        txtTelefono.Text = "";

        mostrar();
        
        txtNroDoc.ReadOnly = false;
        btnCancelar.Visible = true;
        btnAñadir.Visible = true;
    }

    protected Boolean validarCliente(string dni)
    {
        //Consulta BD para no añadir dni repetido
        ClienteAdapter ClienteAdapter = new ClienteAdapter();
        List<Entidades.Cliente> ListaClientes = ClienteAdapter.GetAll();
        foreach (Entidades.Cliente cli in ListaClientes)
        {
            if (cli.Dni == dni)
            {
                return false;
            }
        }
        return true;
    }

    protected void btnAñadir_Click(object sender, EventArgs e)
    {
        lblAdvertencia.Text="";
        if (txtNroDoc.Text == "")
        {
            lblAdvertencia.Text = "El número de documento no puede estar vacio | ";
        }
        else if(validarCliente(txtNroDoc.Text)==false)
        {
            lblAdvertencia.Text = "Ya hay un cliente registrado con ese número de documento | ";
        }

        if (txtEmail.Text != "") { validarEmail(); }

        if(lblAdvertencia.Text =="")
        {
            ClienteAdapter adapter = new ClienteAdapter();
            Cliente cli = new Cliente();
            cli.Apellido = txtApellido.Text;
            cli.Nombre = txtNombre.Text;
            cli.Dni = txtNroDoc.Text;
            cli.Email = txtEmail.Text;
            cli.Direccion = txtDireccion.Text;
            cli.Telefono = txtTelefono.Text;

            ocultar();          
            txtNroDoc.ReadOnly = true;
            btnCancelar.Visible = false;
            btnGuardar.Visible = false;
            btnAñadir.Visible = false;
           
            txtNroDoc.ReadOnly = true;

            adapter.AñadirNuevo(cli);
            gvClientes.DataSourceID = "odsClientes";


        }
    }

    protected void mostrar()
    {
        lblNombre.Visible = true;
        lblApellido.Visible = true;
        lblDireccion.Visible = true;
        lblTelefono.Visible = true;
        lblEmail.Visible = true;
        lblNumeroDoc.Visible = true;

        imgCliente.Visible = true;

        txtApellido.Visible = true;
        txtNombre.Visible = true;
        txtEmail.Visible = true;
        txtNroDoc.Visible = true;
        txtTelefono.Visible = true;
        txtDireccion.Visible = true;

        lblAdvertencia.Text = "";
        lblAdvertencia.Visible = true;
    }

    protected void ocultar()
    {
        lblNombre.Visible = false;
        lblApellido.Visible = false;
        lblDireccion.Visible = false;
        lblTelefono.Visible = false;
        lblEmail.Visible = false;
        lblNumeroDoc.Visible = false;

        imgCliente.Visible = false;

        txtApellido.Visible = false;
        txtNombre.Visible = false;
        txtEmail.Visible = false;
        txtNroDoc.Visible = false;
        txtTelefono.Visible = false;
        txtDireccion.Visible = false;
        
        lblAdvertencia.Visible = false;
    }

    protected void validarEmail()
    {        
        if (!(Regex.IsMatch(txtEmail.Text, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")))
        {
            lblAdvertencia.Text += "El email no tiene el formato correcto | ";
           
        }

    }
}
