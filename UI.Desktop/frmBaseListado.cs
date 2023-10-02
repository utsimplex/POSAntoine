using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Database;
using Entidades;
using System.Data.OleDb;
using Microsoft.Office.Interop;

namespace UI.Desktop
{
    public partial class frmBaseListado : Form
    {
        public frmBaseListado()
        {
            InitializeComponent();
        }


        // LOAD
        private void frmBaseListado_Load(object sender, EventArgs e)
        {
            ClienteAdapter ClienteAdapter = new ClienteAdapter();
            ArticuloAdapter ArticuloAdapter = new ArticuloAdapter();
            ProveedorAdapter ProveedorAdapter = new ProveedorAdapter();
            #region
            /*
            switch (ModoForm)
            {
                case TipoForm.Cliente: this.dgvListado.DataSource = ClienteAdapter.GetAll();
                                         
                    break;
                case TipoForm.Articulo: this.dgvListado.DataSource = ArticuloAdapter.GetAll();
                                        
                    break;
                case TipoForm.Proveedor: this.dgvListado.DataSource = ProveedorAdapter.GetAll();
                    break;

                case TipoForm.SeleccionArticulo: this.dgvListado.DataSource = ArticuloAdapter.GetAll();
                    this.btnExportar.Hide();
                    this.btnImportar.Hide();
                    this.btnEliminar.Hide();
                    this.btnSeleccionarArti.Visible = true;
                    
                                              
                    break;

                    
            }*/
#endregion
        }



        // ADAPTER CapaDatos
        //*****************************************************************
        //
        protected UsuarioAdapter DatosUsuarioAdapter = new UsuarioAdapter();
        protected ArticuloAdapter DatosArticuloAdapter = new ArticuloAdapter();
        protected ClienteAdapter DatosClienteAdapter = new ClienteAdapter();
        protected ProveedorAdapter DatosProveedorAdapter = new ProveedorAdapter();
        protected Proveedores_Articulos_Adapter DatosProv_Art_Adapter = new Proveedores_Articulos_Adapter();
        //
        //*****************************************************************



        public List<Entidades.Proveedor_Articulo> ListaArticulosProveedor = new List<Entidades.Proveedor_Articulo>();
        Entidades.Proveedor prov = new Entidades.Proveedor();




        #region ///***///***///***/// M E T O D O S \\\***\\\***\\\***\\\

        // ------------------------------------ EXPORTAR ------------------------------------

        // Articulos
        public void exportarArtículos()
        {

            Artículos.frmListadoArticulos frmListaArticulos = new UI.Desktop.Artículos.frmListadoArticulos();
            frmListaArticulos.ModoForm = UI.Desktop.Artículos.frmListadoArticulos.TipoForm.Lista;
            frmListaArticulos.Show();
            frmListaArticulos.Hide();


            Microsoft.Office.Interop.Excel.Application ExcelAppArt = new Microsoft.Office.Interop.Excel.Application();
            ExcelAppArt.Application.Workbooks.Add(Type.Missing);

            SaveFileDialog drArt = new SaveFileDialog();
            drArt.FileName = "Artículos " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            drArt.Filter = "Excel files (*.xls)|*.xls";
            drArt.Title = "ARTICULOS";


            if (drArt.ShowDialog() == DialogResult.OK)
            {
                for (int i = 1; i < frmListaArticulos.dgvListado.Columns.Count + 1; i++)
                {
                    ExcelAppArt.Cells[1, i] = frmListaArticulos.dgvListado.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < frmListaArticulos.dgvListado.Rows.Count; i++)
                {
                    for (int j = 0; j < frmListaArticulos.dgvListado.Columns.Count; j++)
                    {
                        ExcelAppArt.Cells[i + 2, j + 1] = frmListaArticulos.dgvListado.Rows[i].Cells[j].Value.ToString();
                    }
                }


                ExcelAppArt.ActiveWorkbook.SaveCopyAs(drArt.FileName);
                ExcelAppArt.ActiveWorkbook.Saved = true;
                ExcelAppArt.Quit();
            }

            int cantArti = frmListaArticulos.dgvListado.Rows.Count;

        }

        // Clientes
        public void exportarClientes()
        {
            Clientes.frmListadoClientes frmListaClientes = new UI.Desktop.Clientes.frmListadoClientes();
            frmListaClientes.ModoForm = UI.Desktop.Clientes.frmListadoClientes.TipoForm.Lista;

            frmListaClientes.Show();
            frmListaClientes.Hide();

            Microsoft.Office.Interop.Excel.Application ExcelAppCli = new Microsoft.Office.Interop.Excel.Application();
            ExcelAppCli.Application.Workbooks.Add(Type.Missing);

            SaveFileDialog drCli = new SaveFileDialog();
            drCli.FileName = "Clientes " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            drCli.Filter = "Excel files (*.xls)|*.xls";
            drCli.Title = "CLIENTES";


            if (drCli.ShowDialog() == DialogResult.OK)
            {
                for (int i = 1; i < frmListaClientes.dgvListado.Columns.Count + 1; i++)
                {
                    ExcelAppCli.Cells[1, i] = frmListaClientes.dgvListado.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < frmListaClientes.dgvListado.Rows.Count; i++)
                {
                    for (int j = 0; j < frmListaClientes.dgvListado.Columns.Count; j++)
                    {
                        ExcelAppCli.Cells[i + 2, j + 1] = frmListaClientes.dgvListado.Rows[i].Cells[j].Value.ToString();
                    }
                }


                ExcelAppCli.ActiveWorkbook.SaveCopyAs(drCli.FileName);
                ExcelAppCli.ActiveWorkbook.Saved = true;
                ExcelAppCli.Quit();
            }
            int cantCli = frmListaClientes.dgvListado.Rows.Count;
        }

        // Proveedores
        public void exportarProveedores()
        {
            // ACA VA EL CODIGO PARA EXPORTAR PROVEEDORES. DEBO AGREGAR TAMBIEN LOS ARTÍCULOS Q VENDE 

            Proveedores.frmListadoProveedores formListaProveedores = new UI.Desktop.Proveedores.frmListadoProveedores();

            formListaProveedores.Show();
            formListaProveedores.Hide();

            Microsoft.Office.Interop.Excel.Application ExcelAppProveedores = new Microsoft.Office.Interop.Excel.Application();
            ExcelAppProveedores.Application.Workbooks.Add(Type.Missing);

            SaveFileDialog drProveedores = new SaveFileDialog();
            drProveedores.FileName = "Proveedores " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            drProveedores.Filter = "Excel files (*.xls)|*.xls";
            drProveedores.Title = "PROVEEDORES";


            if (drProveedores.ShowDialog() == DialogResult.OK)
            {
                for (int i = 1; i < formListaProveedores.dgvListado.Columns.Count + 1; i++)
                {
                    ExcelAppProveedores.Cells[1, i] = formListaProveedores.dgvListado.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < formListaProveedores.dgvListado.Rows.Count; i++)
                {
                    for (int j = 0; j < formListaProveedores.dgvListado.Columns.Count; j++)
                    {
                        ExcelAppProveedores.Cells[i + 2, j + 1] = formListaProveedores.dgvListado.Rows[i].Cells[j].Value.ToString();
                    }
                }


                ExcelAppProveedores.ActiveWorkbook.SaveCopyAs(drProveedores.FileName);
                ExcelAppProveedores.ActiveWorkbook.Saved = true;
                ExcelAppProveedores.Quit();
            }
            int cantProv = formListaProveedores.dgvListado.Rows.Count;

        }


        // ------------------------------------IMPORTAR ------------------------------------

        // Clientes
        public void importarClientes()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)        
            {
                string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", openFileDialog1.FileName);

                string sqlExcel = String.Format("select * from [{0}$]", "Hoja1");

                DataSet ExDataSet = new DataSet();
                //
                OleDbConnection ExConexion = new OleDbConnection(connectionString);
                OleDbCommand OleDbCommand = new OleDbCommand(sqlExcel, ExConexion);
                OleDbDataAdapter ExDataAdapter = new OleDbDataAdapter(OleDbCommand);
                //
                ExDataAdapter.Fill(ExDataSet);
                            
                    for (int i = 0; i < ExDataSet.Tables[0].Rows.Count; i++)
                    {
                        Entidades.Cliente clienteExcel = new Entidades.Cliente();

                        clienteExcel.NumeroDocumento = ExDataSet.Tables[0].Rows[i].Field<String>(0).ToString();
                        clienteExcel.Nombre = ExDataSet.Tables[0].Rows[i].Field<String>(1).ToString();
                        clienteExcel.Apellido = ExDataSet.Tables[0].Rows[i].Field<String>(2).ToString();
                        clienteExcel.Telefono = ExDataSet.Tables[0].Rows[i].Field<String>(3).ToString();
                        clienteExcel.Direccion = ExDataSet.Tables[0].Rows[i].Field<String>(4).ToString();
                        clienteExcel.Email = ExDataSet.Tables[0].Rows[i].Field<String>(5).ToString();
                    clienteExcel.TipoCliente = ExDataSet.Tables[0].Rows[i].Field<String>(6).ToString();

                    DatosClienteAdapter.AñadirNuevo(clienteExcel);

                    }
                

            }
        }

        public BindingList<Cliente> importarClientesAlt()
        {

            BindingList<Cliente> clientesExcel = new BindingList<Cliente>();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", openFileDialog1.FileName);

                string sqlExcel = String.Format("select * from [{0}$]", "Hoja1");

                DataSet ExDataSet = new DataSet();
                //
                OleDbConnection ExConexion = new OleDbConnection(connectionString);
                OleDbCommand OleDbCommand = new OleDbCommand(sqlExcel, ExConexion);
                OleDbDataAdapter ExDataAdapter = new OleDbDataAdapter(OleDbCommand);
                //
                ExDataAdapter.Fill(ExDataSet);

                for (int i = 0; i < ExDataSet.Tables[0].Rows.Count; i++)
                {
                    Entidades.Cliente clienteExcel = new Entidades.Cliente();

                    clienteExcel.NumeroDocumento = ExDataSet.Tables[0].Rows[i].Field<String>(0).ToString();
                    clienteExcel.Nombre = ExDataSet.Tables[0].Rows[i].Field<String>(1).ToString();
                    clienteExcel.Apellido = ExDataSet.Tables[0].Rows[i].Field<String>(2).ToString();
                    clienteExcel.Telefono = ExDataSet.Tables[0].Rows[i].Field<String>(3).ToString();
                    clienteExcel.Direccion = ExDataSet.Tables[0].Rows[i].Field<String>(4).ToString();
                    clienteExcel.Email = ExDataSet.Tables[0].Rows[i].Field<String>(5).ToString();
                    clienteExcel.TipoCliente = ExDataSet.Tables[0].Rows[i].Field<String>(6).ToString();

                    //DatosClienteAdapter.AñadirNuevo(clienteExcel);
                    clientesExcel.Add(clienteExcel);

                }


            }
            return clientesExcel;
        }

        // Articulos
        public void importarArtículos()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", openFileDialog1.FileName);
                string sqlExcel = String.Format("select * from [{0}$]", "Hoja1");

                DataSet ExDataSet = new DataSet();
                //
                OleDbConnection ExConexion = new OleDbConnection(connectionString);
                OleDbCommand OleDbCommand = new OleDbCommand(sqlExcel, ExConexion);
                OleDbDataAdapter ExDataAdapter = new OleDbDataAdapter(OleDbCommand);
                //
                ExDataAdapter.Fill(ExDataSet);



                for (int i = 0; i < ExDataSet.Tables[0].Rows.Count; i++)
                {
                    Entidades.Articulo articuloExcel = new Articulo();



                    articuloExcel.Codigo = ExDataSet.Tables[0].Rows[i].Field<String>(0);
                    articuloExcel.Descripcion = ExDataSet.Tables[0].Rows[i].Field<String>(1);
                    articuloExcel.Stock= Convert.ToInt32(ExDataSet.Tables[0].Rows[i].Field<Double>(2).ToString());
                    articuloExcel.StockMin = Convert.ToInt32(ExDataSet.Tables[0].Rows[i].Field<Double>(3).ToString());
                    //articuloExcel.Precio = Convert.ToDecimal(ExDataSet.Tables[0].Rows[i].Field<Double>(4));
                    if(ExDataSet.Tables[0].Rows[i].ItemArray[4].ToString() == "")
                    {
                        articuloExcel.Precio = Convert.ToDecimal(0);
                    }
                    else
                    {
                    articuloExcel.Precio = Convert.ToDecimal(ExDataSet.Tables[0].Rows[i].Field<Double>(4));
                    }
                    articuloExcel.Proveedor = ExDataSet.Tables[0].Rows[i].Field<String>(5);

                    DatosArticuloAdapter.AñadirNuevo(articuloExcel);




                }
              

        }}

        public BindingList<Articulo> importarArtículosAlt()
        {
            BindingList<Articulo> articulosExcel = new BindingList<Articulo>();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", openFileDialog1.FileName);
                string sqlExcel = String.Format("select * from [{0}$]", "Hoja1");

                DataSet ExDataSet = new DataSet();
                //
                OleDbConnection ExConexion = new OleDbConnection(connectionString);
                OleDbCommand OleDbCommand = new OleDbCommand(sqlExcel, ExConexion);
                OleDbDataAdapter ExDataAdapter = new OleDbDataAdapter(OleDbCommand);
                //
                ExDataAdapter.Fill(ExDataSet);



                for (int i = 0; i < ExDataSet.Tables[0].Rows.Count; i++)
                {
                    Entidades.Articulo articuloExcel = new Articulo();



                    articuloExcel.Codigo = ExDataSet.Tables[0].Rows[i].Field<String>(0);
                    articuloExcel.Descripcion = ExDataSet.Tables[0].Rows[i].Field<String>(1);
                    articuloExcel.Stock = Convert.ToInt32(ExDataSet.Tables[0].Rows[i].Field<Double>(2).ToString());
                    articuloExcel.StockMin = Convert.ToInt32(ExDataSet.Tables[0].Rows[i].Field<Double>(3).ToString());
                    //articuloExcel.Precio = Convert.ToDecimal(ExDataSet.Tables[0].Rows[i].Field<Double>(4));
                    if (ExDataSet.Tables[0].Rows[i].ItemArray[4].ToString() == "")
                    {
                        articuloExcel.Precio = Convert.ToDecimal(0);
                    }
                    else
                    {
                        articuloExcel.Precio = Convert.ToDecimal(ExDataSet.Tables[0].Rows[i].Field<Double>(4));
                    }
                    articuloExcel.Proveedor = ExDataSet.Tables[0].Rows[i].Field<String>(5);
                    articuloExcel.Habilitado = ExDataSet.Tables[0].Rows[i].Field<String>(6);

                    articulosExcel.Add(articuloExcel);
                   // DatosArticuloAdapter.AñadirNuevo(articuloExcel);




                }


            }
            return articulosExcel;
        }

        // Proveedores
        public BindingList<Proveedor> importarProveedoresAlt()
        {
            BindingList<Proveedor> proveedoresExcel = new BindingList<Proveedor>();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", openFileDialog1.FileName);
                string sqlExcel = String.Format("select * from [{0}$]", "Hoja1");

                DataSet ExDataSet = new DataSet();
                //
                OleDbConnection ExConexion = new OleDbConnection(connectionString);
                OleDbCommand OleDbCommand = new OleDbCommand(sqlExcel, ExConexion);
                OleDbDataAdapter ExDataAdapter = new OleDbDataAdapter(OleDbCommand);
                //
                ExDataAdapter.Fill(ExDataSet);



                for (int i = 0; i < ExDataSet.Tables[0].Rows.Count; i++)
                {
                    Entidades.Proveedor proveedorExcel = new Proveedor();



                    
                    proveedorExcel.Nombre = ExDataSet.Tables[0].Rows[i].Field<String>(1);
                    
                    
                    
                    if (ExDataSet.Tables[0].Rows[i].ItemArray[0].ToString() == "")
                    {
                        proveedorExcel.Dni = "NO REGISTRADO";
                    }
                    else
                    {
                        proveedorExcel.Dni = ExDataSet.Tables[0].Rows[i].Field<Double>(0).ToString();
                    }

                    if (ExDataSet.Tables[0].Rows[i].ItemArray[2].ToString() == "")
                    {
                        proveedorExcel.Email = "NO REGISTRADO";
                    }
                    else
                    {
                        proveedorExcel.Email = ExDataSet.Tables[0].Rows[i].Field<String>(2);
                    }

                    if (ExDataSet.Tables[0].Rows[i].ItemArray[3].ToString() == "")
                    {
                        proveedorExcel.Telefono = "NO REGISTRADO";
                    }
                    else
                    {
                        proveedorExcel.Telefono = ExDataSet.Tables[0].Rows[i].Field<String>(3);
                    }

                    if (ExDataSet.Tables[0].Rows[i].ItemArray[4].ToString() == "")
                    {
                        proveedorExcel.Direccion = "NO REGISTRADO";
                    }
                    else
                    {
                        proveedorExcel.Direccion = ExDataSet.Tables[0].Rows[i].Field<String>(4);
                    }

                    proveedoresExcel.Add(proveedorExcel);
                }


            }
            return proveedoresExcel;
        }


        virtual public void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            
        }

      
           
                  

        // VALIDAR STOCK
      

        #region ========A Ñ A D I R=========

        // Añadir NUEVO CLIENTE
      //  private void AñadirNuevoCliente()
     //   {
     //       Clientes.frmClienteABM frmAltaCliente = new Clientes.frmClienteABM();
     //       frmAltaCliente.ModoForm = Clientes.frmClienteABM.TipoForm.Alta;
     //       frmAltaCliente.ShowDialog();

            //Completa la tabla con los datos nuevos
            // dgvListado.DataSource = ClienteAdapter.GetAll();
     //   }

        // Añadir NUEVO ARTICULO ****************************YA ESTA
       // private void AñadirNuevoArticulo()
       // {
      /*      Artículos.frmArticuloABM frmAltaArticulo = new Artículos.frmArticuloABM();
            frmAltaArticulo.ModoForm = Artículos.frmArticuloABM.TipoForm.Alta;

            //Carga el combo box con la lista de proveedores

            // frmAltaArticulo.cbxProveedor.DataSource = ProveedorAdapter.GetAll(); 
            frmAltaArticulo.cbxProveedor.ValueMember = "nombre";
            frmAltaArticulo.cbxProveedor.SelectedItem = null;

            //Carga el AutoCompletar del comboBox
            frmAltaArticulo.cbxProveedor.AutoCompleteCustomSource = ProveedorAdapter.GetListadoNombres();

            frmAltaArticulo.ShowDialog();
            //Completa la tabla con los datos nuevos
            ActualizarListado();
       // }
        */

       
       

        #endregion

        #region ========= E L I M I N A R ==========

        

        // Eliminar ARTICULO
    /*    private void EliminarArticulo()
        {
            //    Confirmación eliminación
            //    frmEstaSeguro seguro = new frmEstaSeguro();
            //    seguro.ShowDialog();

            //    if (seguro.elim == true)
            //    {
            string artiToDelete = dgvListado.SelectedRows[0].Cells["codigo"].Value.ToString();

            //   ArticuloAdapter.Quitar(artiToDelete);
            ActualizarListado();

        }
        */ 

       

        #endregion

        #region ======== M O D I F I C A R=========




        // Modificar PROVEEDOR

        /*       public void ModificarProveedor()
         //     {
                   // Instanciación del formulario ABM Proveedores
                   Proveedores.frmProveedorABM frmModificarProveedor = new Proveedores.frmProveedorABM();
                   frmModificarProveedor.ModoForm = Proveedores.frmProveedorABM.TipoForm.Edicion;

                   // Capa datos PROVEEDOR-ARTICULOS ADAPTER
                   Proveedores_Articulos_Adapter prov_art_adapter = new Proveedores_Articulos_Adapter();

            
            
                   //Modo Edicion y Datos de la GRILLA al PROVEEDOR
                   frmModificarProveedor.txtNombre.ReadOnly = true;
            
                   prov.Direccion = dgvListado.SelectedRows[0].Cells["direccion"].Value.ToString();
                   prov.Dni = dgvListado.SelectedRows[0].Cells["dni"].Value.ToString();
                   prov.Email = dgvListado.SelectedRows[0].Cells["email"].Value.ToString();
                   prov.Nombre = dgvListado.SelectedRows[0].Cells["nombre"].Value.ToString();
                   prov.Telefono = dgvListado.SelectedRows[0].Cells["telefono"].Value.ToString();

            

                   //Actualización de los datos en la Grilla
                   frmModificarProveedor.dgvArticulosProveedor.DataSource = prov_art_adapter.GetArticulosProveedor(prov.Nombre);
            

            
                   //Carga datos del PROVEEDOR en el FORMULARIO
                   frmModificarProveedor.txtNombre.Text = prov.Nombre;
                   frmModificarProveedor.txtNroDoc.Text = prov.Dni;
                   frmModificarProveedor.txtTelefono.Text = prov.Telefono;
                   frmModificarProveedor.txtEmail.Text = prov.Email;
                   frmModificarProveedor.txtDireccion.Text = prov.Direccion;
          
                        
                   //ABRIR FORMULARIO            
                   frmModificarProveedor.ShowDialog();
    
           
             //  }    */


        #endregion




        #endregion


        #region ///***///***///***/// E V E N T O S \\\***\\\***\\\***\\\

        virtual public void tbxFiltro_TextChanged(object sender, EventArgs e)
        {

        }












        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void dgvListado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}

