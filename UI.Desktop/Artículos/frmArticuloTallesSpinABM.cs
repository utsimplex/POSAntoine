using Data.Database;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Artículos
{
    public partial class frmArticuloTallesSpinABM : Form
    {
        public frmArticuloTallesSpinABM(ParametrosEmpresa pParametrosEmpresa)
        {
            InitializeComponent();
            parametrosEmpresa = pParametrosEmpresa;

            ConfigurarPersonalizados();
            ItemsFamilia1();
            BindUiArticuloNuevo();
            //bring Familia 2 para referenciar
            listFamilias2 = Datos_FamiliaAdapter.GetFamilias("Familia2", "%").Where(x => x.Activo == true).OrderBy(x => x.Descripcion).ToList();
            lstArticulosenBD = Datos_ArticuloAdapter.GetAll().ToList();
        }

        #region ///***///***///***/// V A R I A B L E S \\\***\\\***\\\***\\\

        ArticuloAdapter Datos_ArticuloAdapter = new ArticuloAdapter();
        PrecioAdapter Datos_PrecioAdapter = new PrecioAdapter();
        ProveedorAdapter Datos_ProveedorAdapter = new ProveedorAdapter();
        Entidades.Articulo artiToEdit = new Entidades.Articulo();
        List<Familia> listFamilias1 = new List<Familia>();
        List<Familia> listFamilias2 = new List<Familia>();
        List<Articulo> lstArticulosenBD = new List<Articulo>();
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
            if (!String.IsNullOrEmpty(parametrosEmpresa.CampoPersonalizadoArticulo1))
            {
                txtCampoPersonalizado1.Visible = true;
                lblCampoPersonalizado1.Text = parametrosEmpresa.CampoPersonalizadoArticulo1;
                lblCampoPersonalizado1.Visible = true;
            }
            else
            {
                txtCampoPersonalizado1.Visible = false;
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
            if (parametrosEmpresa.FamiliaNombre1.Length > 0)
            {
                cbxFamilia1.Visible = true;
                if (parametrosEmpresa.FamiliaNombre1.Length > 0 && listFamilias1 != null && listFamilias1.Count != 0)
                {
                    cbxFamilia1.DataSource = listFamilias1;
                    cbxFamilia1.DisplayMember = "descripcion";
                    cbxFamilia1.ValueMember = "id";
                }
            }
            else { cbxFamilia1.Visible = false; }


        }

        #endregion




        #region ///***///***///***/// M E T O D O S \\\***\\\***\\\***\\\


        //***********************  G U A R D A R    *********************** \\
        public void Guardar(bool seguir)
        {
            List<Articulo> Articulos = new List<Articulo>();
            Entidades.Articulo Articulo;
            string error = "";
            // Valido Datos
            if (ValidarPrecio() && ValidarStocks() && ValidarMarca())
            {
                try
                {
                    foreach (Control con in tblTalles.Controls)
                    {
                        if (con.GetType() == typeof(NumericUpDown))
                        {
                            if ((con as NumericUpDown).Value > 0)
                            {
                                Articulo = new Articulo();
                                // TXT to nuevoArticulo
                                Articulo.Codigo = txtCodigo.Text.Trim() + "." + (con as NumericUpDown).Name.Substring(1);
                                if (this.ValidarCodigo(Articulo.Codigo))
                                {

                                    Articulo.Descripcion = txtDescripcion.Text.Trim();
                                    Articulo.Stock = Convert.ToInt32((con as NumericUpDown).Value);
                                    Articulo.StockMin = 0;
                                    Articulo.Precio = String.IsNullOrEmpty(txtPrecio.Text.Trim()) ? 0 : Convert.ToDecimal(txtPrecio.Text.Trim());
                                    Articulo.Proveedor = cbxProveedor.SelectedItem.ToString();
                                    if (lblFamilia1Nombre.Text != "")
                                    {
                                        Articulo.Familia1.id = (int)cbxFamilia1.SelectedValue;
                                    }
                                    Articulo.Familia2.id = this.getFamiliaFromTalle((con as NumericUpDown).Name.Substring(1));
                                    if (txtCosto.Text != "")
                                    {
                                        Articulo.Costo = Convert.ToDecimal(txtCosto.Text.Trim());
                                    }
                                    else
                                    {
                                        Articulo.Costo = 0;
                                    }
                                    Articulo.CodigoArtiProveedor = txtCodigoArtiProveedor.Text.Trim();
                                    Articulo.CampoPersonalizado1 = txtCampoPersonalizado1.Text.Trim();
                                    Articulo.CampoPersonalizado2 = txtCampoPersonalizado2.Text.Trim();

                                    if (Articulo.Descripcion == "")
                                    {
                                        Articulo.Descripcion = "NO REGISTRADO";
                                    }
                                    // nuevoArticulo to Base de Datos (capa de datos)
                                    Datos_ArticuloAdapter.AñadirNuevo(Articulo);

                                    // Nuevo precio a tabla de precios del articulo.
                                    ActualizarListaPrecios(Articulo);

                                }
                                else
                                {
                                    if(MessageBox.Show("Desea Actualizar el stock del articulo" + Articulo.Codigo, "Advertencia", MessageBoxButtons.YesNo) ==DialogResult.Yes)
                                    Datos_ArticuloAdapter.ActualizarStock(Articulo.Codigo, Convert.ToInt32((con as NumericUpDown).Value));
                                }
                            }
                        }
                    }
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
                    if (seguir)
                        cleanForm();
                    else
                        this.Close();
                }
            }//Fin try
        }
        private void cleanForm()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                    control.Text = "";

            }
            foreach (Control con in tblTalles.Controls)
            {
                if (con.GetType() == typeof(NumericUpDown))
                    (con as NumericUpDown).Value= 0 ; 
            }
        }
        private void BindUiArticuloNuevo()
        {
            this.Text = "Añadir nuevo Artículo";
            this.gbDatosArticulo.Text = "Ingreso de datos";

            // Proveedor
            this.cbxProveedor.DataSource = Datos_ProveedorAdapter.GetListadoNombres();
            if (cbxProveedor.Items.Count == 0)
            {
                cbxProveedor.Visible = false;
                MessageBox.Show("No es posible añadir artículos cuando no hay Proveedores cargados. Diríjase al módulo de Proveedores para ingresar al menos 1 proveedor.", "Imposible añadir Artículo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
            }

            this.cbxProveedor.SelectedIndex = -1;

        }
        private int getFamiliaFromTalle(string talle)
        {
            int id = 0;
            switch (talle)
            {
                case "RN":
                case "3m":
                case "6m":
                case "9m":
                case "12m":
                case "18m":
                    id = (int)this.listFamilias2.Find(familia => familia.Descripcion == "Baby").id;
                    break;
                case "TU":
                    id = (int)this.listFamilias2.Find(familia => familia.Descripcion == "Sin Rango").id;
                    break;
                case "16":
                case "18":
                    id = (int)this.listFamilias2.Find(familia => familia.Descripcion == "Teens").id;
                    break;
                default:
                    id = (int)this.listFamilias2.Find(familia => familia.Descripcion == "Junior").id;
                    break;
            }
            return id;
        }


        //*********************** V A L I D A C I O N E S  *********************** \\
        bool ValidarCodigo(string codigoAValidar)
        {
            string mensaje = "";

            //Valido Codigo del artículo
            if (codigoAValidar.Trim() == "")
                mensaje += "- El código no puede estar en blanco." + "\n";

            //Consulta BD para no añadir codigo repetido

            if (this.lstArticulosenBD.Find(articulo => articulo.Codigo == codigoAValidar) != null)
            {
                mensaje += "Ya existe un artículo registrado con el código" + codigoAValidar + " ingresado. \n Se actualizará el stock." + "\n";

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
            string mensaje = "Debe indicar al menos un stock por talle.";

            foreach (Control num in tblTalles.Controls)
            {
                if (num.GetType()== typeof(NumericUpDown))
                {
                    if ((num as NumericUpDown).Value > 0)
                    {
                        mensaje = "";
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
        bool ValidarTalles()
        {
            string mensaje = "";
            bool oneOrMore = false;

            foreach (CheckBox chk in tblTalles.Controls)
            {
                if (chk.Checked)
                    oneOrMore = true;
            }

            if (!oneOrMore)
            {
                mensaje = "Debe seleccionar al menos un talle";
            }

            // Mostrar Errors
            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return oneOrMore;

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
            Guardar(false);
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
        private void frmArticuloTallesABM_Load(object sender, EventArgs e)
        {
            this.cbxProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cbxProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cbxProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        //PROXIMO NUMERO
        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (cbxProveedor.Text == "")
                MessageBox.Show("Debes seleccionar un proveedor");
            else
                this.txtCodigo.Text = this.Datos_ArticuloAdapter.getProximoNumeradorProveedor(this.cbxProveedor.Text);
        }

        private void btnGuardaryotro_Click(object sender, EventArgs e)
        {
            this.Guardar(true);
        }

        private void btnBuscarCodProv_Click(object sender, EventArgs e)
        {
            if (cbxProveedor.Text == "" || txtCodigoArtiProveedor.Text=="")
                MessageBox.Show("Debes seleccionar un proveedor y poner el codigo de Proveedor");
            else
                this.txtCodigo.Text = this.Datos_ArticuloAdapter.getNumeradorCodigoProveedor(this.cbxProveedor.Text, txtCodigoArtiProveedor.Text);
        }
    }
}

