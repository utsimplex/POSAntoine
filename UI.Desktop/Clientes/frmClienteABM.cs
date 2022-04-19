using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Database;
using System.Text.RegularExpressions;

namespace UI.Desktop.Clientes
{
    public partial class frmClienteABM : frmBaseABM

    {
        // Constructor 1
        public frmClienteABM()
        {
            InitializeComponent();

            this.Text = "Añadir nuevo Cliente";
            this.groupBox1.Text = "Ingreso de datos";

        }

        // Constructor 2 (Modo Modificacion)
        public frmClienteABM(Entidades.Cliente cli)
        {
            InitializeComponent();

            this.Text = "Modificar datos del Cliente";
            this.groupBox1.Text = "Edición de datos";
            this.txtNroDoc.ReadOnly = true;
            txtNroDoc.Text = cli.Dni;
            txtNombre.Text = cli.Nombre;
            txtApellido.Text = cli.Apellido;
            txtDireccion.Text = cli.Direccion;
            txtTelefono.Text = cli.Telefono;
            txtEmail.Text = cli.Email;
            
            // BUSCAR SI EL CLIENTE TIENE DEUDA
            // 
            // ClienteAdapter DatosClienteAdapter = new ClienteAdapter();
            // txtDeuda.Text = DatosClienteAdapter.GetDeuda();
            // if(txtDeuda.Text != "")
            // {
            //   gbDeuda.Visible = true;
            // }
        }


        #region ///***///***///***/// V A R I A B L E S \\\***\\\***\\\***\\\

        ClienteAdapter Datos_ClienteAdapter = new ClienteAdapter();
        Entidades.Cliente cliToEdit = new Entidades.Cliente();

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
            Edicion

        }


        #endregion



        #region ///***///***///***/// M E T O D O S \\\***\\\***\\\***\\\


        //***********************  G U A R D A R    *********************** \\
        public void Guardar()
        {
            if (ModoForm == TipoForm.Alta)
            {

                // Genero una nueva instancia de la entidad
                Entidades.Cliente newCliente = new Entidades.Cliente();

                // Valido Datos
                if (Validar())
                {
                    try
                    {
                        // TXT to nuevoCliente
                        newCliente.Nombre = txtNombre.Text.Trim();
                        newCliente.Apellido = txtApellido.Text.Trim();
                        newCliente.Dni = txtNroDoc.Text.Trim();
                        newCliente.Direccion = txtDireccion.Text.Trim();
                        newCliente.Telefono = txtTelefono.Text.Trim();
                        newCliente.Email = txtEmail.Text.Trim();
                        newCliente.TipoCliente = cbxCondicionCli.SelectedItem.ToString();
                        
                        // nuevoCliente to Base de Datos (capa de datos)
                        ClienteAdapter CapaDatos = new ClienteAdapter();
                        CapaDatos.AñadirNuevo(newCliente);
                                     

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
                        newCliente = null;
                    }
                }//Fin try
            }//Fin Alta
            else if(ModoForm == TipoForm.Edicion)
            {
                if (Validar())
                {
                    try
                    {
                    cliToEdit.Dni = txtNroDoc.Text;
                    cliToEdit.Nombre = txtNombre.Text;
                    cliToEdit.Apellido = txtApellido.Text;
                    cliToEdit.Direccion = txtDireccion.Text;
                    cliToEdit.Telefono = txtTelefono.Text;
                    cliToEdit.Email = txtEmail.Text;
                    cliToEdit.TipoCliente = cbxCondicionCli.SelectedItem.ToString();

                    //Si el cliente tiene deuda
                    //
                    // if (this.gbDeuda.Visible == true)
                    // {
                    //    Actualizar la Deuda
                    //
                    // }
                    Datos_ClienteAdapter.Actualizar(cliToEdit);
                    this.Close();
                    }
                    catch (Exception ex)
                    {
                        // Muestro cualquier error de la aplicacion
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

               
            }
            
        }



        //*********************** V A L I D A R Cliente  *********************** \\
        bool Validar()
        {
            string mensaje = "";
            txtNroDoc.Text = txtNroDoc.Text.Trim();
            //Valido numero de documento
            if (txtNroDoc.Text.Trim() == "")
                mensaje += "- El DNI no puede estar en blanco." + "\n";
            if (txtEmail.Text != "")
            {
                if (!(Regex.IsMatch(txtEmail.Text, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$")))
                {
                    mensaje += "- El email no tiene el formato correcto." + "\n";
                }
            }
            //Consulta BD para no añadir dni repetido

            ClienteAdapter ClienteAdapter = new ClienteAdapter();

            List<Entidades.Cliente> ListaClientes = ClienteAdapter.GetAll();

            if (ModoForm == TipoForm.Alta)
            {
                foreach (Entidades.Cliente cli in ListaClientes)
                {
                    if (cli.Dni == txtNroDoc.Text)
                    {
                        mensaje += "Ya existe un cliente registrado con ese DNI." + "\n";
                    }
                }
            } 

            // Mostrar Errors
            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;


        }
        //************************Fin Validar Cliente

        #endregion



        #region ///***///***///***/// E V E N T O S \\\***\\\***\\\***\\\


        //*********************** B O T O N   G U A R D A R   C L I C K  *********************** 
        override protected void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Guardar();
        }

        
        //*********************** LEAVE txt.NroDoc (Valida dni mientras se completan los datos  *********************** \\
        override protected void txtNroDoc_Leave(object sender, EventArgs e)
        {
            try
            {
                Validar();
            }
            catch (Exception ex)
            {
                // Muestro cualquier error de validación
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        

          //LOAD
        private void frmClienteABM_Load(object sender, EventArgs e)
        {
            // CARGA ITEMS DEL COMBOBOX CONDICION DEL CLIENTE
            cbxCondicionCli.Items.Add("CONSUMIDOR FINAL");
            cbxCondicionCli.Items.Add("EXENTO");
            cbxCondicionCli.Items.Add("MONOTRIBUTISTA");
            cbxCondicionCli.Items.Add("NO CATEGORIZADO");
            cbxCondicionCli.Items.Add("NO RESPONSABLE");
            cbxCondicionCli.Items.Add("RESPONSABLE INSCRIPTO");
            cbxCondicionCli.Items.Add("RESPONSABLE NO INSCRIPTO");
            cbxCondicionCli.SelectedIndex = 0;
            
            cbxCondicionCli.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxCondicionCli.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxCondicionCli.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #endregion


     
      

     


   }//Cierra clase



        


     
    }//Cierra NameSpace




        

    

