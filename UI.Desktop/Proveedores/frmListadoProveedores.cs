using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace UI.Desktop.Proveedores
{
    public partial class frmListadoProveedores : frmBaseListado
    {
        //Constructor General
        public frmListadoProveedores()
        {
            InitializeComponent();
            ActualizarLista();

            dgvListado.Columns["Nombre"].HeaderText = "Nombre o Razón Social";
            dgvListado.Columns["Nombre"].Width = 150;
            

        }

        //LISTA DE ARTICULOS
        public List<Entidades.Proveedor> ListaProveedores;

        public frmListadoProveedores(Usuario usr)
        {
            InitializeComponent();
            ActualizarLista();

            dgvListado.Columns["Nombre"].HeaderText = "Nombre o Razón Social";
            dgvListado.Columns["Nombre"].Width = 150;
            rol = usr.Rol;

        }

        

        #region ///***///***///***/// V A R I A B L E S   L O C A L E S \\\***\\\***\\\***\\\

        //ROL
        string rol;
        //Proveedor Seleccionado
        string NombProvSeleccionado;

        //PROPIEDAD MODOFORM
        private TipoForm _modoForm;
        public TipoForm ModoForm
        {
            get { return _modoForm; }
            set { _modoForm = value; }
        }


        //ENUMERADOR MODOFORM
        public enum TipoForm
        {
            Lista,
            SeleccionDeProveedor

        }


        #endregion


        #region ///***///***///***/// M E T O D O S \\\***\\\***\\\***\\\

        // ACTUALIZAR LISTA DE PROVEEDORES
        private void ActualizarLista()
        {
            this.ListaProveedores = DatosProveedorAdapter.GetAll();
            dgvListado.DataSource = ListaProveedores;
        }


        // Añadir NUEVO PROVEEDOR
        private void AñadirNuevoProveedor()
        {
            Proveedores.frmProveedorABM formAltaProveedor = new Proveedores.frmProveedorABM();
            formAltaProveedor.ModoForm = Proveedores.frmProveedorABM.TipoForm.Alta;
            
            //  Otras modificaciones al formulario alta Proveedor
            formAltaProveedor.ShowDialog();

            //Completa la tabla con los datos nuevos
            ActualizarLista();
        }

        // Eliminar PROVEEDOR
        private void EliminarProveedor()
        {
            //    Confirmación eliminación
            Mensajes.frmConfirmar formConfirmar = new Mensajes.frmConfirmar("¿Está seguro que desea ELIMINAR el registro seleccionado?","Eliminar");

            if (formConfirmar.ShowDialog() == DialogResult.Yes)
            {
                string provToDelete = dgvListado.SelectedRows[0].Cells["nombre"].Value.ToString();

               DatosProveedorAdapter.Quitar(provToDelete);
               ActualizarLista();
            }

        }

        // Modificar PROVEEDOR
        public void ModificarProveedor()
        {
            // Proveedor a modificar = provToEdit
            Proveedor provToEdit = new Proveedor();
            
            provToEdit.Direccion = dgvListado.SelectedRows[0].Cells["direccion"].Value.ToString();
            provToEdit.Dni = dgvListado.SelectedRows[0].Cells["dni"].Value.ToString();
            provToEdit.Email = dgvListado.SelectedRows[0].Cells["email"].Value.ToString();
            provToEdit.Nombre = dgvListado.SelectedRows[0].Cells["nombre"].Value.ToString();
            provToEdit.Telefono = dgvListado.SelectedRows[0].Cells["telefono"].Value.ToString();

            // Instanciación del formulario ABM Proveedores
            Proveedores.frmProveedorABM frmModificarProveedor = new Proveedores.frmProveedorABM(provToEdit);
            frmModificarProveedor.ModoForm = Proveedores.frmProveedorABM.TipoForm.Edicion;
         
            
            //ABRIR FORMULARIO            
            frmModificarProveedor.ShowDialog();

            ActualizarLista();
           
           }    


        #endregion


        #region ///***///***///***/// E V E N T O S \\\***\\\***\\\***\\\

        // CLICK Nuevo Poveedor
        private void btnAñadirNuevo_Click(object sender, EventArgs e)
        {
            AñadirNuevoProveedor();
        }

        // CLICK Modificar Proveedor
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (rol == "Empleado")
            {
                MessageBox.Show("El usuario no posee permisos para realizar esta tarea.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ModificarProveedor();
            }
        }

        // CLICK Eliminar Proveedor
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (rol == "Empleado")
            {
                MessageBox.Show("El usuario no posee permisos para realizar esta tarea.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (dgvListado.SelectedRows.Count != 0)
            {
                EliminarProveedor();
            }
            
        }

        // DOBLE CLICK Sobre un Proveedor
        override public void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            ModificarProveedor();
        }

        // CLICK Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (this.ModoForm == TipoForm.Lista)
            {
                this.Close();
            }
            else
            {
              NombProvSeleccionado = dgvListado.SelectedRows[0].Cells["Nombre"].Value.ToString();
              this.Close();
            }
        }

        // LOAD FormListadoProveedores
        private void frmListadoProveedores_Load(object sender, EventArgs e)
        {
            // Si esta en modo seleccion, elimina elementos innecesarios.
            if (this.ModoForm == TipoForm.SeleccionDeProveedor)
            {
                this.btnEliminar.Visible = false;
                this.btnExportar.Visible = false;
                this.btnImportar.Visible = false;
                this.btnModificar.Visible = false;
                this.btnSalir.Text = "Seleccionar";
                this.btnSalir.DialogResult = DialogResult.Yes;
            }
        }


        //MODIFICAR EL FILTRO DE BUSQUEDA
        private void tbxFiltro_TextChanged_1(object sender, EventArgs e)
        {
            if (tbxFiltro.Text == "")
            {
                dgvListado.DataSource = DatosProveedorAdapter.GetAll();
            }
            else
            {
                dgvListado.DataSource = DatosProveedorAdapter.Busqueda(tbxFiltro.Text);
            }

        }



        //TECLAS ACCESO RAPIDO
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.Enter:
                    if (this.ModoForm == TipoForm.SeleccionDeProveedor)
                    { //seleccionarProveedor 
                    }

                    break;

                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.Delete:
                    if (dgvListado.SelectedRows.Count != 0)
                    {
                        EliminarProveedor();
                    }
                    break;


                default:

                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }




        // Hay que limpiar toda la logica de los import y exports


        #endregion

        private void btnExportar_Click(object sender, EventArgs e)
        {
            this.exportarProveedores();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            BindingList<Proveedor> proveedoresExcel = importarProveedoresAlt();

            foreach (Proveedor proveedorExcel in proveedoresExcel)
            {
                Boolean estaCargado = false;

                foreach (Proveedor proveedorApp in ListaProveedores)
                {
                    if (proveedorApp.Nombre == proveedorExcel.Nombre)
                    {
                        estaCargado = true;
                    }
                }
                if (estaCargado)
                {
                    DatosProveedorAdapter.Actualizar(proveedorExcel);
                }
                else
                {
                    DatosProveedorAdapter.AñadirNuevo(proveedorExcel);
                }
            }
            ActualizarLista();
        }
    }
}
