using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Data.Database;
using System.Text.RegularExpressions;

namespace UI.Desktop.Usuarios
{
    public partial class frmUsuarioABM : Form
    {
        // Constructor 1
        public frmUsuarioABM()
        {
            InitializeComponent();

            this.Text = "Añadir nuevo Usuario";
            this.groupBox1.Text = "Ingreso de datos";
            txtRepetirContraseña.Visible = false;
            lblRepetirContraseña.Visible = false;
            lblNuevaContraseña.Text = "Repetir contraseña";
            this.rdioEmpleado.Checked = true;
        }

        // Constructor 2 (Modo Modificacion)
        public frmUsuarioABM(Entidades.Usuario usr)
        {
            InitializeComponent();

            this.Text = "Modificar datos del Usuario";
            this.groupBox1.Text = "Edición de datos";
            this.txtUsuario.ReadOnly = true;
            txtCuil.Text = usr.Cuil;
            txtNombre.Text = usr.Nombre;
            txtApellido.Text = usr.Apellido;
            txtDireccion.Text = usr.Direccion;
            txtTelefono.Text = usr.Telefono;
            txtEmail.Text = usr.Email;
            txtUsuario.Text = usr.usuario;
            txtNuevaContraseña.Visible = true;
            lblNuevaContraseña.Visible = true;
            txtRepetirContraseña.Visible = true;
            lblRepetirContraseña.Visible = true;
            lblNuevaContraseña.Text = "Nueva contraseña";

            if (usr.Rol == "Administrador")
            { rdioAdministrador.Checked = true; }
            if (usr.Rol == "Empleado")
            { rdioEmpleado.Checked = true; }
            if (usr.Rol == "Externo")
            { rdioExterno.Checked = true; }


        }

        #region ///***///***///***/// V A R I A B L E S \\\***\\\***\\\***\\\

        UsuarioAdapter Datos_UsuarioAdapter = new UsuarioAdapter();
        Entidades.Usuario usrToEdit = new Entidades.Usuario();

        #endregion
        
        #region ///***///***///***/// PROPIEDADES Y ENUMERADORES \\\***\\\***\\\***\\\

        TipoForm _modoForm;
        public TipoForm ModoForm
        {
            get { return _modoForm; }
            set { _modoForm = value; }
        }

        public enum TipoForm
        {
            Alta,
            Edicion,
            EdicionPropia

        }


        #endregion

        #region ///***///***///***/// M E T O D O S \\\***\\\***\\\***\\\


        //***********************  G U A R D A R    *********************** \\
        public void Guardar()
        {
            if (ModoForm == TipoForm.Alta)
            {

                // Genero una nueva instancia de la entidad
                Entidades.Usuario newUsuario = new Entidades.Usuario();

                // Valido Datos
                if (ValidarTodo())
                {
                    try
                    {
                        // TXT to nuevoCliente
                        newUsuario.Nombre = txtNombre.Text.Trim();
                        newUsuario.Apellido = txtApellido.Text.Trim();
                        newUsuario.Cuil = txtCuil.Text.Trim();
                        newUsuario.Direccion = txtDireccion.Text.Trim();
                        newUsuario.Telefono = txtTelefono.Text.Trim();
                        newUsuario.Email = txtEmail.Text.Trim();
                        newUsuario.Contraseña = txtContraseña.Text.Trim();
                        newUsuario.usuario = txtUsuario.Text.Trim().ToLower();
                        newUsuario.State = EntidadNegocio.States.Nuevo;

                        if (rdioAdministrador.Checked == true)
                        { newUsuario.Rol = "Administrador"; }
                        if (rdioEmpleado.Checked == true)
                        { newUsuario.Rol = "Empleado"; }
                        if (rdioExterno.Checked == true)
                        { newUsuario.Rol = "Externo"; }

                        //NO REGISTRADO A CAMPOS VACIOS
                        if (txtNombre.Text == "")
                        { newUsuario.Nombre = "NO REGISTRADO"; }
                        if (txtApellido.Text == "")
                        { newUsuario.Apellido= "NO REGISTRADO"; }
                        if (txtCuil.Text == "")
                        { newUsuario.Cuil = "NO REGISTRADO"; }
                        if (txtDireccion.Text == "")
                        { newUsuario.Direccion = "NO REGISTRADO"; }
                        if (txtEmail.Text == "")
                        { newUsuario.Email = "NO REGISTRADO"; }
                        if (txtTelefono.Text == "")
                        { newUsuario.Telefono = "NO REGISTRADO"; }
                        

                        // nuevoCliente to Base de Datos (capa de datos)
                        UsuarioAdapter CapaDatos = new UsuarioAdapter();
                        CapaDatos.AñadirNuevo(newUsuario);
                        
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        // Muestro cualquier error de la aplicacion
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        // Libero objetos
                        newUsuario = null;
                    }
                }//Fin try
            }//Fin Alta
            else if (ModoForm == TipoForm.Edicion || ModoForm == TipoForm.EdicionPropia)
            {
                string mensaje = "";
                if (txtContraseña.Text == "")
                { mensaje += "Debe ingresar la contraseña actual para guardar los cambios " + "\n"; }
                else
                {
                    UsuarioAdapter adapter = new UsuarioAdapter();
                    if (adapter.ValidarUsuario(txtUsuario.Text, txtContraseña.Text))
                    {
                        if (txtNuevaContraseña.Text != "")
                        {
                            if (txtRepetirContraseña.Text == "")
                            {
                                mensaje += "Debe repetir la nueva contraseña" + "\n";
                            }
                            else
                            {
                                if (txtRepetirContraseña.Text != txtNuevaContraseña.Text)
                                {
                                    mensaje += "La contraseña nueva no coincide. Por favor, vuelva a ingresarla." + "\n";
                                }
                                else
                                {
                                    usrToEdit.Cuil = txtCuil.Text;
                                    usrToEdit.Nombre = txtNombre.Text;
                                    usrToEdit.Apellido = txtApellido.Text;
                                    usrToEdit.Direccion = txtDireccion.Text;
                                    usrToEdit.Telefono = txtTelefono.Text;
                                    usrToEdit.Email = txtEmail.Text;
                                    usrToEdit.Contraseña = txtNuevaContraseña.Text;
                                    usrToEdit.usuario = txtUsuario.Text.ToUpper();
                                    usrToEdit.State = EntidadNegocio.States.Modificado;

                                    if (rdioAdministrador.Checked == true)
                                    { usrToEdit.Rol = "Administrador"; }
                                    if (rdioEmpleado.Checked == true)
                                    { usrToEdit.Rol = "Empleado"; }
                                    if (rdioExterno.Checked == true)
                                    { usrToEdit.Rol = "Externo"; }

                                    //NO REGISTRADO A CAMPOS VACIOS
                                    if (txtNombre.Text == "")
                                    { usrToEdit.Nombre = "NO REGISTRADO"; }
                                    if (txtApellido.Text == "")
                                    { usrToEdit.Apellido = "NO REGISTRADO"; }
                                    if (txtCuil.Text == "")
                                    { usrToEdit.Cuil = "NO REGISTRADO"; }
                                    if (txtDireccion.Text == "")
                                    { usrToEdit.Direccion = "NO REGISTRADO"; }
                                    if (txtEmail.Text == "")
                                    { usrToEdit.Email = "NO REGISTRADO"; }
                                    if (txtTelefono.Text == "")
                                    { usrToEdit.Telefono = "NO REGISTRADO"; }

                                    Datos_UsuarioAdapter.Actualizar(usrToEdit);
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            usrToEdit.Cuil = txtCuil.Text;
                            usrToEdit.Nombre = txtNombre.Text;
                            usrToEdit.Apellido = txtApellido.Text;
                            usrToEdit.Direccion = txtDireccion.Text;
                            usrToEdit.Telefono = txtTelefono.Text;
                            usrToEdit.Email = txtEmail.Text;
                            usrToEdit.Contraseña = txtContraseña.Text;
                            usrToEdit.usuario = txtUsuario.Text.ToUpper();
                            usrToEdit.State = EntidadNegocio.States.Modificado;

                            if (rdioAdministrador.Checked == true)
                            { usrToEdit.Rol = "Administrador"; }
                            if (rdioEmpleado.Checked == true)
                            { usrToEdit.Rol = "Empleado"; }
                            if (rdioExterno.Checked == true)
                            { usrToEdit.Rol = "Externo"; }

                            Datos_UsuarioAdapter.Actualizar(usrToEdit);
                            this.Close();
                        }

                    }
                    else
                    {
                        mensaje += "La contraseña es incorrecta" + "\n";
                    }
                }
                if (!String.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                }
            }
           
        }



        //*********************** V A L I D A R Usuario  *********************** \\
        bool ValidarTodo()
        {
            string mensaje = "";

            mensaje = ValidarUserName();

            mensaje = ValidarEmail();

            //Consulta BD para no añadir dni repetido
            mensaje += valUsrExist();

            UsuarioAdapter UsuarioAdapter = new UsuarioAdapter();

            Usuario usr = UsuarioAdapter.GetUsuario(txtUsuario.Text);

            mensaje = ValidarContraseña();

            // Mostrar Errors
            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }


        // VALIDAR CONTRASEÑA
        private string ValidarContraseña()
        {
            string mensaje = "";
            if (txtContraseña.Text == "")
            {
                mensaje += "- La contraseña no puede estar vacia" + "\n";
            }
            else
            {
                if (txtNuevaContraseña.Text == "")
                {
                    mensaje += "- Debe repetir la contraseña" + "\n";
                }
                else
                {
                    if (txtContraseña.Text != txtNuevaContraseña.Text)
                    {
                        mensaje += "- Las contraseñas no coinciden" + "\n";
                    }
                }
            }
            return mensaje;
        }

        // VALIDAR EMAIL    
        private string ValidarEmail()
        {
            string mensaje = "";
            if (txtEmail.Text != "")
            {
                if (!(Regex.IsMatch(txtEmail.Text, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")))
                {
                    mensaje += "- El email no tiene el formato correcto." + "\n";
                }
            }
            return mensaje;
        }

        // VALIDAR Nombre de Usuario
        private string ValidarUserName()
        {
            string mensaje = ""; 
            txtUsuario.Text = txtUsuario.Text.Trim();
            //Valido nombre de usuario
            if (txtUsuario.Text.Trim() == "")
                mensaje += "- El Usuario no puede estar en blanco." + "\n";
            return mensaje;
        }

        // VALIDAR Usuario Existente
        private string valUsrExist()
        {
            string mensaje = "";
            if (ModoForm == TipoForm.Alta)
            {
                UsuarioAdapter UsuarioAdapter = new UsuarioAdapter();
                Usuario usr = UsuarioAdapter.GetUsuario(txtUsuario.Text);
                if (usr.usuario != null)
                {
                    mensaje += "Ya existe un usuario registrado con ese nombre de usuario." + "\n";
                }
            }
            return mensaje;
        }

        


        
        #endregion

        #region ///***///***///***/// E V E N T O S \\\***\\\***\\\***\\\


        //*********************** B O T O N   G U A R D A R   C L I C K  *********************** 
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Guardar();
        }

       

        private void frmUsuarioABM_Load(object sender, EventArgs e)
        {
            if (this.ModoForm == frmUsuarioABM.TipoForm.EdicionPropia && usrToEdit.Rol != "Administrador")
            {
                gbRol.Visible = false;
            }
        }
        
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        #endregion

        
    }
}

