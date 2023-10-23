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

namespace UI.Desktop.Artículos
{
    public partial class frmArticuloABM : Form
    {
        //Constructor 1
        public frmArticuloABM( ParametrosEmpresa pParametrosEmpresa )
        {
            InitializeComponent();
            parametrosEmpresa = pParametrosEmpresa;

            ConfigurarPersonalizados();
            ItemsFamilia1();
            ItemsFamilia2();
            BindUiArticuloNuevo();

        }

        //Constructor 2 (modo Modificacion)
        public frmArticuloABM(Entidades.Articulo artiToEdit, ParametrosEmpresa pParametrosEmpresa)
        {
            InitializeComponent();
            parametrosEmpresa = pParametrosEmpresa;
            ConfigurarPersonalizados();
            ItemsFamilia1();
            ItemsFamilia2();
            this.artiToEdit = artiToEdit;

           if(this.artiToEdit != null)
           {
                BindUiEditarArticulo();
           }
          
        }


        #region ///***///***///***/// V A R I A B L E S \\\***\\\***\\\***\\\

        ArticuloAdapter Datos_ArticuloAdapter = new ArticuloAdapter();
        PrecioAdapter Datos_PrecioAdapter = new PrecioAdapter();
        ProveedorAdapter Datos_ProveedorAdapter = new ProveedorAdapter();
        Entidades.Articulo artiToEdit = new Entidades.Articulo();
        List<Familia> listFamilias1 = new List<Familia>();
        List<Familia> listFamilias2 = new List<Familia>();
        FamiliaAdapter Datos_FamiliaAdapter = new FamiliaAdapter();
        //PARAMETROS DE LA EMPRESA
        ParametrosEmpresa parametrosEmpresa = new ParametrosEmpresa();


        #endregion



        #region ///***///***///***/// P R O P I E D A D E S \\\***\\\***\\\***\\\

        TipoForm _modoForm;
        public TipoForm ModoForm
        {
            get { return _modoForm; }
            set { _modoForm = value; }
        }


        #endregion



        #region ///***///***///***/// E N U M E R A D O R E S \\\***\\\***\\\***\\\


        public enum TipoForm
        {
            Alta,
            Edicion

        }

        private void ConfigurarPersonalizados()
        {
            if( !String.IsNullOrEmpty(parametrosEmpresa.CampoPersonalizadoArticulo1))
            {
                txtCampoPersonalizado1.Visible = true;
                lblCampoPersonalizado1.Text = parametrosEmpresa.CampoPersonalizadoArticulo1;
                lblCampoPersonalizado1.Visible =true;
            }
            else 
            { 
                txtCampoPersonalizado1.Visible=false;
                lblCampoPersonalizado1.Visible = false;
            }

            if (!String.IsNullOrEmpty(parametrosEmpresa.CampoPersonalizadoArticulo2))
            {
                lblCampoPersonalizado2.Text = parametrosEmpresa.CampoPersonalizadoArticulo2.Trim();
                txtCampoPersonalizado2.Visible = true;
                lblCampoPersonalizado2.Visible = true;
            }
            else
            {
                txtCampoPersonalizado2.Visible = false;
                lblCampoPersonalizado2.Visible = false;
            }

        }
        private void ItemsFamilia1()
        {

            cbxFamilia1.Items.Clear();
            listFamilias1 = Datos_FamiliaAdapter.GetFamilias("Familia1", "%").Where(x => x.Activo == true).OrderBy(x => x.Descripcion).ToList();
            this.lblFamilia1Nombre.Text = parametrosEmpresa.FamiliaNombre1;
            if(parametrosEmpresa.FamiliaNombre1.Length > 0)
            {
                cbxFamilia1.Visible = true;
                if (parametrosEmpresa.FamiliaNombre1.Length > 0 && listFamilias1 != null && listFamilias1.Count != 0)
                {
                    cbxFamilia1.DataSource = listFamilias1;
                    cbxFamilia1.DisplayMember = "descripcion";
                    cbxFamilia1.ValueMember = "id";
                }
            }
            else { cbxFamilia1.Visible=false;}
            

        }

        private void ItemsFamilia2()
        {
            cbxFamilia2.Items.Clear();
            listFamilias2 = Datos_FamiliaAdapter.GetFamilias("Familia2", "%").Where(x => x.Activo == true).OrderBy(x => x.Descripcion).ToList();
            this.lblFamilia2Nombre.Text = parametrosEmpresa.FamiliaNombre2;
            if(parametrosEmpresa.FamiliaNombre2?.Length > 0)
            {
                cbxFamilia2.Visible = true;
                if (parametrosEmpresa.FamiliaNombre2.Length > 0 && listFamilias2 != null && listFamilias2.Count != 0)
                {
                    cbxFamilia2.DataSource = listFamilias2;
                    cbxFamilia2.DisplayMember = "descripcion";
                    cbxFamilia2.ValueMember = "id";
                }
            }
            else { cbxFamilia2.Visible=false;}



        }



        #endregion




        #region ///***///***///***/// M E T O D O S \\\***\\\***\\\***\\\


        //***********************  G U A R D A R    *********************** \\
        public void Guardar()
        {
            Entidades.Articulo Articulo = new Entidades.Articulo();
            
            if (ModoForm == TipoForm.Alta)
            { 
                // Valido Datos
                if (ValidarCodigo() && ValidarPrecio() && ValidarStocks() && ValidarMarca())
                {
                    try
                    {
                        // TXT to nuevoArticulo
                        Articulo.Codigo= txtCodigo.Text.Trim();
                        Articulo.Descripcion = txtDescripcion.Text.Trim();
                        Articulo.Stock = Convert.ToInt32(txtStock.Text.Trim());
                        Articulo.StockMin = Convert.ToInt32(txtStockMin.Text.Trim());
                        Articulo.Precio = String.IsNullOrEmpty(txtPrecio.Text.Trim())?0:Convert.ToDecimal(txtPrecio.Text.Trim());
                        Articulo.Proveedor = cbxProveedor.SelectedItem.ToString();
                        Articulo.Familia1.id = (int)cbxFamilia1.SelectedValue;
                        Articulo.Costo = Convert.ToDecimal(txtCosto.Text.Trim());
                        Articulo.Familia2.id = (int)cbxFamilia2.SelectedValue;
                        Articulo.CodigoArtiProveedor = txtCodigoArtiProveedor.Text.Trim();
                        Articulo.CampoPersonalizado1 = txtCampoPersonalizado1.Text.Trim();
                        Articulo.CampoPersonalizado2 = txtCampoPersonalizado2.Text.Trim();
                        /* NO UTILIZADO, REVISAR //////////////////////////////////////////////
                        // Si tiene proveedor genero nueva instancia y la agrego a datos
                        if (cbxProveedor.SelectedText != "")
                        {
                            Entidades.Proveedor_Articulo prov_arti = new Entidades.Proveedor_Articulo();

                            prov_arti.Nombre = cbxProveedor.SelectedText.ToString();
                            prov_arti.CodigoArticulo = txtCodigo.Text.ToString();
                            prov_arti.CostoCompraProveedor = Convert.ToDecimal(txtCostoCompra.Text);

                            Proveedores_Articulos_Adapter CapaDatosProvArti = new Proveedores_Articulos_Adapter();
                            CapaDatosProvArti.AñadirNuevo(prov_arti);

                        }
                         * 
                         * *//////////////////////////////////////////////////////////////////////
                        if (Articulo.Descripcion == "")
                        {
                            Articulo.Descripcion = "NO REGISTRADO";
                        }
                        // nuevoArticulo to Base de Datos (capa de datos)
                        Datos_ArticuloAdapter.AñadirNuevo(Articulo);
                        
                        // Nuevo precio a tabla de precios del articulo.
                        ActualizarListaPrecios(Articulo);

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
                        Articulo = null;
                    }
                }//Fin try
            }//Fin Alta
            else if (ModoForm == TipoForm.Edicion)
            {
                try
                {

                artiToEdit.Codigo = txtCodigo.Text;
                artiToEdit.Descripcion = txtDescripcion.Text;
                    artiToEdit.Precio = Math.Round(Convert.ToDecimal(txtPrecio.Text), 2);
                artiToEdit.StockMin = Convert.ToInt32(txtStockMin.Text);
                artiToEdit.Stock = Convert.ToInt32(txtStock.Text);
                artiToEdit.Familia1.id = (int)cbxFamilia1.SelectedValue;
                artiToEdit.Costo = Convert.ToDecimal(txtCosto.Text.Trim());
                    if(cbxFamilia2.Visible)
                artiToEdit.Familia2.id = (int)cbxFamilia2.SelectedValue;
                artiToEdit.CodigoArtiProveedor = txtCodigoArtiProveedor.Text.Trim();
                    artiToEdit.CampoPersonalizado1 = txtCampoPersonalizado1.Text.Trim();
                    artiToEdit.CampoPersonalizado2 = txtCampoPersonalizado2.Text.Trim();

                    if (cbxProveedor.SelectedItem != null)
                {
                artiToEdit.Proveedor = cbxProveedor.SelectedItem.ToString();
                }
                artiToEdit.Habilitado = "Si";
                if (artiToEdit.Descripcion == "")
                {
                    artiToEdit.Descripcion = "NO REGISTRADO";
                }
                Datos_ArticuloAdapter.Actualizar(artiToEdit);

               
                ActualizarListaPrecios(artiToEdit);
                this.Close();        
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error de la aplicacion
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            


            
        }

        private void BindUiArticuloNuevo()
        {
            this.Text = "Añadir nuevo Artículo";
            this.gbDatosArticulo.Text = "Ingreso de datos";
            this.btnModificarStock.Hide();

            // Proveedor
            this.cbxProveedor.DataSource = Datos_ProveedorAdapter.GetListadoNombres();
            if (cbxProveedor.Items.Count == 0)
            {
                lblNoHayProveedores.Visible = true;
                cbxProveedor.Visible = false;
                MessageBox.Show("No es posible añadir artículos cuando no hay Proveedores cargados. Diríjase al módulo de Proveedores para ingresar al menos 1 proveedor.", "Imposible añadir Artículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
            }
            else
            {
                lblNoHayProveedores.Visible = false;
            }
            this.cbxProveedor.SelectedIndex = -1;

        }

        private void BindUiEditarArticulo()
        {
            this.Text = "Modificar datos del Artículo";
            this.gbDatosArticulo.Text = "Edición de datos";
            this.txtCodigo.ReadOnly = true;
            this.txtStock.ReadOnly = true;

            // Proveedor
            this.cbxProveedor.DataSource = Datos_ProveedorAdapter.GetListadoNombres();
            for (int i = 0; i < cbxProveedor.Items.Count - 1; i++)
            {
                if (cbxProveedor.Items[i].ToString() == artiToEdit.Proveedor)
                {
                    cbxProveedor.SelectedIndex = i;
                    break;
                }
            }

            if (cbxProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("No hay Proveedores cargados. Se recomienda añadirlos al módulo de Proveedores antes de dar de alta o modificar un artículo", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxProveedor.Visible = false;
                lblNoHayProveedores.Visible = true;

            }

            // Datos artículo
            txtCodigo.Text = artiToEdit.Codigo;
            txtDescripcion.Text = artiToEdit.Descripcion;
            txtPrecio.Text = Math.Round(Convert.ToDecimal(artiToEdit.Precio),2).ToString();

            txtStock.Text = artiToEdit.Stock.ToString();
            txtStockMin.Text = artiToEdit.StockMin.ToString();
            txtCodigoArtiProveedor.Text = artiToEdit.CodigoArtiProveedor;

            cbxFamilia1.SelectedValue = (int)artiToEdit.Familia1.id;
            //cbxFamilia.SelectedValue = listFamilias.First(familia => familia.id == artiToEdit.Familia).id;
            if(artiToEdit.Familia2.id !=null)
            cbxFamilia2.SelectedValue = (int)artiToEdit.Familia2.id;
                //!= null ? (ArticuloConstantes.RangoEtario)artiToEdit.RangoEtario : ArticuloConstantes.RangoEtario.Baby;
            
            txtCosto.Text = artiToEdit.Costo.ToString();

            txtCampoPersonalizado1.Text = artiToEdit.CampoPersonalizado1;
            txtCampoPersonalizado2.Text = artiToEdit.CampoPersonalizado2;
            
                      
        }


        //*********************** V A L I D A C I O N E S  *********************** \\
        bool ValidarCodigo()
        {
            string mensaje = "";
            
           
            //VALIDAR CODIGO
            txtCodigo.Text = txtCodigo.Text.Trim();
            
            //Valido Codigo del artículo
            if (txtCodigo.Text.Trim() == "")
                mensaje += "- El código no puede estar en blanco." + "\n";

            //Consulta BD para no añadir codigo repetido
            BindingList<Entidades.Articulo> ListaArticulos = Datos_ArticuloAdapter.GetAll();

            if (ModoForm == TipoForm.Alta)
            {
                foreach (Entidades.Articulo arti in ListaArticulos)
                {
                    if (arti.Codigo == txtCodigo.Text)
                    {
                        mensaje += "Ya existe un artículo registrado con el código ingresado. \nPor favor, utilize uno distinto." + "\n";
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
        bool ValidarPrecio()
        {
            string mensaje = "";
            decimal precio = 0;

            //Formato del precio con decimales
            if (txtPrecio.Text != "")
            {
                txtPrecio.Text = txtPrecio.Text.Replace(".", ",");
                precio = Convert.ToDecimal(txtPrecio.Text);
                precio = Decimal.Round(precio, 2);
                txtPrecio.Text = precio.ToString();
            }
            else
            {
                mensaje += "El precio del artículo no puede estar en blanco.";
            }

            // Mostrar Errors
            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;

        }
        bool ValidarMarca()
        {
            string mensaje = "";


            //VALIDAR CODIGO
            

            //Valido Codigo del artículo
            if (cbxProveedor.SelectedItem == null)
                mensaje += "- Debe seleccionar un Proveedor." + "\n";

           
            // Mostrar Errors
            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
        bool ValidarStocks()
        {
            string mensaje = "";
            

            //Formato del precio con decimales
            if (txtStock.Text == "")
            {
                mensaje = "Debe ingresar la cantidad de unidades que posee en Stock actualmente.";
            }
            else if (txtStockMin.Text == "")
            {
                mensaje += "Debe ingresar un valor en el Stock Mínimo.";
            }

            // Mostrar Errors
            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;

        }
       



        //********* PRECIO DEL ARTICULO **********

        private void ActualizarListaPrecios(Entidades.Articulo arti)
        {
            
            // Nuevo precio a tabla de precios del articulo.
            DateTime fechaHoy = DateTime.Now;

            System.Data.SqlTypes.SqlMoney precio = arti.Precio;
            Datos_PrecioAdapter.AñadirNuevoPrecio(arti.Codigo, arti.Precio, fechaHoy);
        }

        //**************************************


        #endregion

        #region ///***///***/// E V E N T O S \\\***\\\***\\\***\\\


        // CLICK GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

       
        //CLICK CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* AñadirProveedorArti
        private void btnAñadirProveedorArti_Click(object sender, EventArgs e)
        {
            Entidades.Proveedor_Articulo pro_art = new Entidades.Proveedor_Articulo();
           
            try
            {
                pro_art.CodigoArticulo = txtCodigo.Text;
                pro_art.CostoCompraProveedor = Convert.ToDecimal(txtCostoCompra.Text.Trim());
                pro_art.Nombre = cbxProveedor.Text;
                // Continuar ACAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
                // Cargar la lista de Proveedores Articulos, luego el boton guardar añade el articulo a Articulos y la Lista a Proveedores Articulos.

                
                dgvProveedores_Articulos.Rows.Add(pro_art.Nombre, pro_art.CostoCompraProveedor);
              
                
            }
            catch (Exception ex)
            {
                // Muestro cualquier error de la aplicacion
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                pro_art = null;
            }

            
            
        }
        */ 

        // CODIGO A MAYUSCULAS
        private void txtCodigo_Leave(object sender, EventArgs e)
        {
           
           txtCodigo.Text = txtCodigo.Text.ToUpper();
           
        }

       


        //CLICK Modificar Stock
        private void btnModificarStock_Click(object sender, EventArgs e)
        {
            if (txtStock.ReadOnly == false)
            {
                this.txtStock.ReadOnly = true;
            }
            else
            {
                this.txtStock.ReadOnly = false;
            }
        }

        //LEAVE txtPRECIO
        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text != "") // y si no contiene letras o simbolos
            {
                decimal precio = 0;

                txtPrecio.Text = txtPrecio.Text.Replace(".", ",");
                precio = Convert.ToDecimal(txtPrecio.Text);
                precio = Decimal.Round(precio, 2);
                txtPrecio.Text = precio.ToString();
            }
        }

       

        

        #endregion

        //PRECIO SOLO NUMEROS
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        //SOLO PERMITE INGRESAR NUMEROS
        private static void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        //STOCK SOLO NUMEROS
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        //STOCK MINIMO SOLO NUMEROS
        private void txtStockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        //LOAD
        private void frmArticuloABM_Load(object sender, EventArgs e)
        {
           
            this.cbxProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cbxProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cbxProveedor.DropDownStyle = ComboBoxStyle.DropDownList;

            
        }

       
    }
}
