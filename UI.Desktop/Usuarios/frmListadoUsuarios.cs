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

namespace UI.Desktop.Usuarios
{
    public partial class frmListadoUsuarios : frmBaseListado
    {
        public frmListadoUsuarios()
        {
            InitializeComponent();
            ActualizarLista();
            dgvListado.Columns["Contraseña"].Visible = false;
            dgvListado.Columns["State"].Visible = false;
            dgvListado.Columns["ID"].Visible = false;
            dgvListado.Columns["usuario"].HeaderText = "Usuario";
            
        }

        #region ///***///***///***/// V A R I A B L E S   L O C A L E S \\\***\\\***\\\***\\\

        //PROPIEDAD MODOFORM
        TipoForm _modoForm;
        public TipoForm ModoForm
        {
            get { return _modoForm; }
            set { _modoForm = value; }
        }


        //ENUMERADOR MODOFORM
        public enum TipoForm
        {
            Lista,
            SeleccionDeUsuario

        }

        //CLIENTE ACTUAL/SELECCIONADO
        public string usuarioSeleccionado;

        #endregion


        #region ///***///***///***/// M E T O D O S \\\***\\\***\\\***\\\

        // ACTUALIZAR LISTA DE USUARIOS
        private void ActualizarLista()
        {
            dgvListado.DataSource = DatosUsuarioAdapter.GetAll();
        }


        // Añadir NUEVO CLIENTE
        private void AñadirNuevoUsuario()
        {
            Usuarios.frmUsuarioABM frmAltaUsuario = new Usuarios.frmUsuarioABM();
            frmAltaUsuario.ModoForm = Usuarios.frmUsuarioABM.TipoForm.Alta;
            frmAltaUsuario.ShowDialog();

            ActualizarLista();
        }

        // Eliminar CLIENTE
        private void EliminarUsuario()
        {
            Mensajes.frmConfirmar formConfirmar = new Mensajes.frmConfirmar("¿Está seguro que desea ELIMINAR el registro seleccionado?","Eliminar");

            if (formConfirmar.ShowDialog() == DialogResult.Yes)
            {
                string usuarioToDelete = dgvListado.SelectedRows[0].Cells["usuario"].Value.ToString();
                Usuario usrToDelete = DatosUsuarioAdapter.GetUsuario(usuarioToDelete);

                usrToDelete.State = EntidadNegocio.States.Eliminado;

                DatosUsuarioAdapter.Actualizar(usrToDelete);

                // ELIMINAR DE LA BASE DE DATOS
                //DatosUsuarioAdapter.Quitar(usuarioToDelete);
            }

            ActualizarLista();
        }

        // Modificar CLIENTE
        private void ModificarUsuario()
        {
            // Cliente a modificar = CliToEdit
            Usuario UsrToEdit = new Usuario();

            UsrToEdit.Apellido = dgvListado.SelectedRows[0].Cells["apellido"].Value.ToString();
            UsrToEdit.Nombre = dgvListado.SelectedRows[0].Cells["nombre"].Value.ToString();
            UsrToEdit.Direccion = dgvListado.SelectedRows[0].Cells["direccion"].Value.ToString();
            UsrToEdit.Email = dgvListado.SelectedRows[0].Cells["email"].Value.ToString();
            UsrToEdit.Telefono = dgvListado.SelectedRows[0].Cells["telefono"].Value.ToString();
            UsrToEdit.Cuil = dgvListado.SelectedRows[0].Cells["cuil"].Value.ToString();
            UsrToEdit.Contraseña = dgvListado.SelectedRows[0].Cells["contraseña"].Value.ToString();
            UsrToEdit.usuario = dgvListado.SelectedRows[0].Cells["usuario"].Value.ToString();
            UsrToEdit.Rol = dgvListado.SelectedRows[0].Cells["rol"].Value.ToString();

            // Instanciación del formulario ABM Articulos EDICION
            Usuarios.frmUsuarioABM formUsuarioABM = new Usuarios.frmUsuarioABM(UsrToEdit);
            formUsuarioABM.ModoForm = frmUsuarioABM.TipoForm.Edicion;

            formUsuarioABM.ShowDialog();

            ActualizarLista();
        }

        #endregion


        #region ///***///***///***/// E V E N T O S \\\***\\\***\\\***\\\


        //CLICK Añadir
        private void btnAñadirNuevo_Click(object sender, EventArgs e)
        {

            AñadirNuevoUsuario();
        }

        //CLICK Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarUsuario();

        }

        //CLICK Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
        }

        // DOBLE CLICK Sobre un Cliente
        override public void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            if (this.ModoForm == TipoForm.Lista)
            {
                ModificarUsuario();
            }
            else if (ModoForm == TipoForm.SeleccionDeUsuario)
            {
                usuarioSeleccionado = this.dgvListado.SelectedRows[0].Cells["usuario"].Value.ToString();
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        // LOAD Form
        private void frmListadoUsuarios_Load(object sender, EventArgs e)
        {
            if (ModoForm == TipoForm.SeleccionDeUsuario)
            {
                this.btnImportar.Visible = false;
                this.btnExportar.Visible = false;
                this.btnEliminar.Visible = false;
            }

        }

        // CLICK Seleccionar Cliente ***NUEVO!!!***
        private void btnSeleccionarCli_Click(object sender, EventArgs e)
        {
            usuarioSeleccionado = this.dgvListado.SelectedRows[0].Cells["usuario"].Value.ToString();
            this.Close();
        }


        //MODIFICAR EL FILTRO DE BUSQUEDA
        override public void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            if (tbxFiltro.Text == "")
            {
                dgvListado.DataSource = DatosUsuarioAdapter.GetAll();

            }
            else
            {
                dgvListado.DataSource = DatosUsuarioAdapter.Busqueda(tbxFiltro.Text);
            }
        }


        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.ActualizarLista();
        }
               
   














    }
}
