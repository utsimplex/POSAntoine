using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Database; // para poder utilizar el adapter
using Entidades;

namespace UI.Desktop.Artículos
{
    public partial class frmBASEListaArticulos : Form
    {
        //LISTA DE ARTICULOS
        public BindingList<Entidades.Articulo> ListaArticulos;

        //LISTA DE ARTICULOS FILTRADOS
        public List<Entidades.Articulo> ListaArticulosFiltrados;

        // Lista de PROVEEDORES
        public AutoCompleteStringCollection listaProveedoresExistentes;

        //Lista de Familias
        List<Familia> familias1 = new List<Familia>();

        List<Familia> familias2 = new List<Familia>();
        //Lista de Proveedores
        List<Proveedor> proveedores = new List<Proveedor>();

        //PARAMETROS DE LA EMPRESA
        ParametrosEmpresa parametrosEmpresa = new ParametrosEmpresa();

        //Adapters
        FamiliaAdapter Datos_FamiliaAdapter = new FamiliaAdapter();
        ProveedorAdapter Datos_ProveedorAdapter = new ProveedorAdapter();
        ArticuloAdapter DatosArticuloAdapter = new ArticuloAdapter();
        // Fisica cuantica PARA PONERLE PLACEHOLDER AL CBX
        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);


        public frmBASEListaArticulos()
        {
            InitializeComponent();
            this.dgvListado.CellFormatting += dgvListado_CellFormatting;
            parametrosEmpresa = ParametrosEmpresaController.GetInstance().ObtenerParametrosEmpresa();
            ActualizarLista();
            completaCombosBox();
            this.dgvListado.Columns["descripcion"].Width = 280;
            this.dgvListado.Columns["codigo"].HeaderText = "Código";
            this.dgvListado.Columns["descripcion"].HeaderText = "Descripción";
            this.dgvListado.Columns["stockMin"].HeaderText = "Stock Min.";
            this.dgvListado.Columns["precio"].HeaderText = "Precio ($)";
            this.dgvListado.Columns["stock"].Width = 45;
            this.dgvListado.Columns["stockMin"].Width = 45;
            this.dgvListado.Columns["precio"].Width = 75;
            this.dgvListado.Columns["precio"].DefaultCellStyle.Format = "c";
            

        }

        protected internal void OrdenarColumnas(string columna1, string columna2, string columna3)
        {
            dgvListado.Columns[columna1].DisplayIndex = 0;
            dgvListado.Columns[columna2].DisplayIndex = 1;
            dgvListado.Columns[columna3].DisplayIndex = 2;
        }

        public void dgvListado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == dgvListado.Columns["Familia1"].Index && e.Value != null) || (e.ColumnIndex == dgvListado.Columns["Familia2"].Index && e.Value != null))
            {
                if (e.Value is Familia familia)
                {
                    e.Value = familia.Descripcion;
                }

            }
        }

        //COMPLETAR COMBOBOXS

        private void completaCombosBox()
        {
            // CBX FAMILIA 1
            familias1 = Datos_FamiliaAdapter.GetFamilias("Familia1", "%").Where(x => x.Activo == true).OrderBy(x => x.Descripcion).ToList();
            if (parametrosEmpresa.FamiliaNombre1.Length > 0 && familias1 != null && familias1.Count != 0)
            {
                //familias.Add(new Familia { Activo = true,Descripcion= "Seleccione Familia", id=0 });
                cbxFiltroFamilia1.DataSource = familias1;
                cbxFiltroFamilia1.DisplayMember = "descripcion";
                cbxFiltroFamilia1.ValueMember = "id";
                cbxFiltroFamilia1.SelectedIndex = -1;
                cbxFiltroFamilia1.SelectedValueChanged += cbxFiltroFamilia_SelectedValueChanged;

            }
            else
            {
                this.cbxFiltroFamilia1.Visible = false;
            }

            // CBX FAMILIA 2
            familias2 = Datos_FamiliaAdapter.GetFamilias("Familia2", "%").Where(x => x.Activo == true).OrderBy(x => x.Descripcion).ToList();
            if (parametrosEmpresa.FamiliaNombre2.Length > 0 & familias2 != null && familias2.Count != 0)
            {
                //familias.Add(new Familia { Activo = true,Descripcion= "Seleccione Familia", id=0 });
                cbxFiltroFamilia2.DataSource = familias2;
                cbxFiltroFamilia2.DisplayMember = "descripcion";
                cbxFiltroFamilia2.ValueMember = "id";
                cbxFiltroFamilia2.SelectedIndex = -1;
                cbxFiltroFamilia2.SelectedValueChanged += cbxFiltroFamilia_SelectedValueChanged;

            }
            else
            {
                this.cbxFiltroFamilia2.Visible = false;
            }

            // cbxFiltroProveedor
            proveedores = Datos_ProveedorAdapter.GetAll().OrderBy(x => x.Nombre).ToList();
            if (familias1 != null)
            {
                //proveedores.Add(new Proveedor {Nombre= "Seleccione Proveedor" });
                cbxFiltroProveedor.DataSource = proveedores;
                cbxFiltroProveedor.DisplayMember = "Nombre";
                cbxFiltroProveedor.ValueMember = "Nombre";
                cbxFiltroProveedor.SelectedIndex = -1;
                cbxFiltroProveedor.SelectedValueChanged += cbxFiltroProveedor_SelectedValueChanged;
            }

            string placeholderFamilia1 = "Filtrar por " + parametrosEmpresa.FamiliaNombre1 + "...";
            string placeholderFamilia2 = "Filtrar por " + parametrosEmpresa.FamiliaNombre2 + "...";

            SendMessage(this.cbxFiltroProveedor.Handle, CB_SETCUEBANNER, 0, "Filtrar por proveedor...");
            SendMessage(this.cbxFiltroFamilia1.Handle, CB_SETCUEBANNER, 0, placeholderFamilia1);
            SendMessage(this.cbxFiltroFamilia2.Handle, CB_SETCUEBANNER, 0, placeholderFamilia2);

        }


        private void ActualizarLista()
        {
            ListaArticulos = DatosArticuloAdapter.GetAll();
            ListaArticulosFiltrados = ListaArticulos.Where(a => a.Habilitado == "Si").ToList();

            dgvListado.DataSource = ListaArticulosFiltrados;
            dgvListado.Columns["habilitado"].Visible = false;
            dgvListado.Columns["CodigoArtiProveedor"].Visible = false;
            //this.dgvListado.Columns["RangoEtarioTexto"].HeaderText = "Rango etario";

            this.dgvListado.Columns["Familia1"].Visible = !string.IsNullOrEmpty(parametrosEmpresa.FamiliaNombre1.Trim());
            this.dgvListado.Columns["Familia1"].HeaderText = parametrosEmpresa.FamiliaNombre1;

            this.dgvListado.Columns["Familia2"].Visible = !string.IsNullOrEmpty(parametrosEmpresa.FamiliaNombre2.Trim());
            this.dgvListado.Columns["Familia2"].HeaderText = parametrosEmpresa.FamiliaNombre2;

            this.dgvListado.Columns["CodigoArtiProveedor"].HeaderText = "Codigo proveedor";
            dgvListado.Size = new Size(968, 490);
            this.dgvListado.Location = new Point(7, 56);

            this.dgvListado.Columns["CampoPersonalizado1"].Visible = !string.IsNullOrEmpty(parametrosEmpresa.CampoPersonalizadoArticulo1.Trim());
            this.dgvListado.Columns["CampoPersonalizado1"].HeaderText = parametrosEmpresa.CampoPersonalizadoArticulo1.Trim();

            this.dgvListado.Columns["CampoPersonalizado2"].Visible = !string.IsNullOrEmpty(parametrosEmpresa.CampoPersonalizadoArticulo2.Trim());
            this.dgvListado.Columns["CampoPersonalizado2"].HeaderText = parametrosEmpresa.CampoPersonalizadoArticulo2.Trim();

        }


        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
            RecargarArticulos();
        }


        private void LimpiarFiltros()
        {
            tbxFiltro.Text = "";
            cbxFiltroFamilia1.SelectedIndex = -1;
            cbxFiltroFamilia2.SelectedIndex = -1;
            cbxFiltroProveedor.SelectedIndex = -1;
        }

        private void AplicaFiltros()
        {
            string searchTerm = tbxFiltro.Text.ToLowerInvariant();

            if (searchTerm == "" && !FiltrandoPorProveedor() && !FiltrandoPorFamilia1() && !FiltrandoPorFamilia2())
            {
                RecargarArticulos();
            }
            else
            {
                if (FiltraSoloPorTexto(searchTerm))
                {
                    ListaArticulosFiltrados = AplicarFiltroTexto(searchTerm, ListaArticulos);
                }
                else
                {

                    ListaArticulosFiltrados = ListaArticulos.ToList();

                    if (FiltrandoPorProveedor())
                    {
                        ListaArticulosFiltrados = ListaArticulosFiltrados
                            .Where(articulo => articulo.Proveedor == cbxFiltroProveedor.SelectedValue.ToString())
                            .ToList();
                    }

                    if (FiltrandoPorFamilia1())
                    {
                        ListaArticulosFiltrados = ListaArticulosFiltrados
                            .Where(articulo => articulo.Familia1.id == (int)cbxFiltroFamilia1.SelectedValue)
                            .ToList();
                    }

                    if (FiltrandoPorFamilia2())
                    {
                        ListaArticulosFiltrados = ListaArticulosFiltrados
                            .Where(articulo => articulo.Familia2.id == (int)cbxFiltroFamilia2.SelectedValue)
                            .ToList();
                    }

                    if (searchTerm != "")
                    {
                        ListaArticulosFiltrados = AplicarFiltroTexto(searchTerm, new BindingList<Articulo>(ListaArticulosFiltrados));
                    }
                }
                dgvListado.DataSource = ListaArticulosFiltrados;
            }


        }

        // MOFIFICAR EL FILTRO DE BUSQUEDA
        private void tbxFiltro_TextChanged_1(object sender, EventArgs e)
        {
            AplicaFiltros();
        }

        // Carga TODOS los articulos en la grilla
        private void RecargarArticulos()
        {
            dgvListado.DataSource = ListaArticulos;
        }

        // Aplicar filtro segun el valor del search term, a la lista especificada
        private List<Articulo> AplicarFiltroTexto(string searchTerm, BindingList<Articulo> listaAfiltrar)
        {
            return listaAfiltrar.Where(
                   a => a.Codigo.ToLowerInvariant().Contains(searchTerm)
                     || a.Descripcion.ToLowerInvariant().Contains(searchTerm)
                     || a.Proveedor.ToLowerInvariant().Contains(searchTerm)
                     || a.CodigoArtiProveedor.ToLowerInvariant().Contains(searchTerm)
               ).ToList();
        }

        // CAMBIO EL PROVEEDOR DESDE el combo box
        private void cbxFiltroProveedor_SelectedValueChanged(object sender, EventArgs e)
        {
            AplicaFiltros();
        }

        // CAMBIO LA FAMILIA DESDE el combo box
        private void cbxFiltroFamilia_SelectedValueChanged(object sender, EventArgs e)
        {
            AplicaFiltros();
        }

        // Determina si actualmente se esta filtrando por proveedor
        private bool FiltrandoPorProveedor()
        {

            if (cbxFiltroProveedor.SelectedIndex != -1)
            {
                return true;
            }
            else
            {
                return false;
            };

        }

        // Determina si actualmente se esta filtrando por familia1
        private bool FiltrandoPorFamilia1()
        {

            if (cbxFiltroFamilia1.SelectedIndex != -1)
            {
                return true;
            }
            else
            {
                return false;
            };

        }

        // Determina si actualmente se esta filtrando por familia2
        private bool FiltrandoPorFamilia2()
        {

            if (cbxFiltroFamilia2.SelectedIndex != -1)
            {
                return true;
            }
            else
            {
                return false;
            };

        }


        // Determina si se esta filtrando por texto, pero No se esta filtrando por proveedor ni familia
        private bool FiltraSoloPorTexto(string searchTerm)
        {
            if (searchTerm != "" && !FiltrandoPorProveedor() && !FiltrandoPorFamilia1() && !FiltrandoPorFamilia2())
            {
                return true;
            }
            return false;
        }

        private void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            AplicaFiltros();
        }

        private void btnMostrarTodos_Click_1(object sender, EventArgs e)
        {
            LimpiarFiltros();
            RecargarArticulos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
