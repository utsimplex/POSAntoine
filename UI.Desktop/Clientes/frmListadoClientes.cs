using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace UI.Desktop.Clientes
{
    public partial class frmListadoClientes : frmBaseListado
    {
        public frmListadoClientes()
        {
            InitializeComponent();
            ActualizarLista();
            
        }

        public frmListadoClientes(Usuario usr)
        {
            InitializeComponent();
            ActualizarLista();
            rol = usr.Rol;
        }


        #region ///***///***///***/// V A R I A B L E S   L O C A L E S \\\***\\\***\\\***\\\


        string rol;
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
            SeleccionDeCliente

        }

        //CLIENTE ACTUAL/SELECCIONADO
        public string dniClienteSelecccionado;

        //LISTA DE ARTICULOS
        public List<Entidades.Cliente> ListaClientes;

        #endregion


        #region ///***///***///***/// M E T O D O S \\\***\\\***\\\***\\\

        // ACTUALIZAR LISTA DE CLIENTES
        private void ActualizarLista()
        {
            ListaClientes = DatosClienteAdapter.GetAll();
            dgvListado.DataSource = ListaClientes;
            dgvListado.Width = 810;
            dgvListado.Columns["email"].Width = 160;
            dgvListado.Columns["numeroDocumento"].HeaderText = "D.N.I";
            dgvListado.Columns["telefono"].HeaderText = "Teléfono";
            dgvListado.Columns["direccion"].HeaderText = "Dirección";
            dgvListado.Columns["situacionFiscalLetras"].HeaderText = "Situacion Fiscal";
            //dgvListado.Columns["tipoCliente"].Width = 145;
            dgvListado.Columns["tipoDocumento"].Visible = false;
            dgvListado.Columns["tipoCliente"].Visible = false;
            dgvListado.Columns["TipoComprobante"].Visible = false;
            dgvListado.Columns["SituacionFiscal"].Visible = false;
            dgvListado.Columns["tipoDocumentoLetras"].HeaderText = "Tipo Documento";
        }


        // Añadir NUEVO CLIENTE
        private void AñadirNuevoCliente()
        {
            Clientes.frmClienteABM frmAltaCliente = new Clientes.frmClienteABM();
            frmAltaCliente.ModoForm = Clientes.frmClienteABM.TipoForm.Alta;
            frmAltaCliente.ShowDialog();

            ActualizarLista();
        }
        
        // Eliminar CLIENTE
        private void EliminarCliente()
        {
            Mensajes.frmConfirmar formConfirmar = new Mensajes.frmConfirmar("¿Está seguro que desea ELIMINAR el registro seleccionado?","Eliminar");

            if (formConfirmar.ShowDialog() == DialogResult.Yes)
            {
                string clienteToDelete = dgvListado.SelectedRows[0].Cells["dni"].Value.ToString();
                DatosClienteAdapter.Quitar(clienteToDelete);
            }

            ActualizarLista();
        }

        // Modificar CLIENTE
        private void ModificarCliente()
        {
            // Cliente a modificar = CliToEdit
            Cliente CliToEdit = new Cliente();

            CliToEdit = ListaClientes.FirstOrDefault(x => x.NumeroDocumento == dgvListado.SelectedRows[0].Cells["numeroDocumento"].Value.ToString());
            //CliToEdit.Apellido= dgvListado.SelectedRows[0].Cells["apellido"].Value.ToString();
            //CliToEdit.Nombre = dgvListado.SelectedRows[0].Cells["nombre"].Value.ToString();
            //CliToEdit.Direccion = dgvListado.SelectedRows[0].Cells["direccion"].Value.ToString();
            //CliToEdit.Email= dgvListado.SelectedRows[0].Cells["email"].Value.ToString();
            //CliToEdit.Telefono = dgvListado.SelectedRows[0].Cells["telefono"].Value.ToString();
            //CliToEdit.NumeroDocumento = dgvListado.SelectedRows[0].Cells["numeroDocumento"].Value.ToString();

            // Instanciación del formulario ABM Articulos EDICION
            Clientes.frmClienteABM formClienteABM = new Clientes.frmClienteABM(CliToEdit);
            formClienteABM.ModoForm = frmClienteABM.TipoForm.Edicion;

            formClienteABM.ShowDialog();

            ActualizarLista();
        }

        #endregion


        #region ///***///***///***/// E V E N T O S \\\***\\\***\\\***\\\


        //CLICK Añadir
        private void btnAñadirNuevo_Click(object sender, EventArgs e)
        {
            
            AñadirNuevoCliente();
        }

        //CLICK Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (rol == "Empleado")
            {
                MessageBox.Show("El usuario no posee permisos para realizar esta tarea.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ModificarCliente();
            }
        }

        //CLICK Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (rol == "Empleado")
            {
                MessageBox.Show("El usuario no posee permisos para realizar esta tarea.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dgvListado.SelectedRows.Count != 0)
            {
                EliminarCliente();
            }
        }

        // DOBLE CLICK Sobre un Cliente
        override public void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            if (this.ModoForm == TipoForm.Lista)
            {
                ModificarCliente();
            }
            else if(ModoForm == TipoForm.SeleccionDeCliente)
            {
                dniClienteSelecccionado = this.dgvListado.SelectedRows[0].Cells["numeroDocumento"].Value.ToString();
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        // CLICK - Exportar CLIENTES a EXCEL
        private void btnExportar_Click(object sender, EventArgs e)
        {
            this.exportarClientes();
        }

        // CLICK Seleccionar Cliente ***NUEVO!!!***
        private void btnSeleccionarCli_Click(object sender, EventArgs e)
        {
            SeleccionarCliente();
        }

        private void SeleccionarCliente()
        {
            dniClienteSelecccionado = this.dgvListado.SelectedRows[0].Cells["dni"].Value.ToString();
            this.Close();
        }
        
        // CLICK - SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        // LOAD Form
        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            if (ModoForm == TipoForm.SeleccionDeCliente)
            {
                this.btnImportar.Visible = false;
                this.btnExportar.Visible = false;
                this.btnEliminar.Visible = false;
                this.btnSeleccionarCli.Visible = true;
               

            }

           

        }

        //MODIFICAR EL FILTRO DE BUSQUEDA
        override public void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            if (tbxFiltro.Text == "")
            {
                dgvListado.DataSource = DatosClienteAdapter.GetAll();

            }
            else
            {
                dgvListado.DataSource = DatosClienteAdapter.Busqueda(tbxFiltro.Text);
            }
        }

        //IMPORTAR CLIENTES CLICK
        private void btnImportar_Click(object sender, EventArgs e)
        {
            //this.importarClientes();
            //ActualizarLista();
            BindingList<Cliente> clientesExcel = importarClientesAlt();

            foreach (Cliente clienteExcel in clientesExcel)
            {
                Boolean estaCargado = false;

                foreach (Cliente clienteApp in ListaClientes)
                {
                    if (clienteApp.Nombre == clienteExcel.Nombre)
                    {
                        estaCargado = true;
                    }
                }
                if (estaCargado)
                {
                    DatosClienteAdapter.Actualizar(clienteExcel);
                }
                else
                {
                    DatosClienteAdapter.AñadirNuevo(clienteExcel);
                }
            }
            ActualizarLista();
        }
    


        //TECLAS ACCESO RAPIDO
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.Enter:
                    dniClienteSelecccionado = this.dgvListado.SelectedRows[0].Cells["dni"].Value.ToString();
                    this.DialogResult = DialogResult.Yes;
                    this.Close();

                    break;

                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.Delete:
                    if (dgvListado.SelectedRows.Count != 0)
                    {
                        EliminarCliente();
                    }
                    break;


                default:

                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }





        #endregion

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            tbxFiltro.Text = "";
        }
       
       
       
        

      
      

        
        
    }
}
