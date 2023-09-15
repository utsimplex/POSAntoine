using Data.Database;
using Entidades;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Artículos
{
    public partial class frmModificarPrecios : frmBaseListado
    {

        public frmModificarPrecios(
            BindingList<Entidades.Articulo> ListaArticulos, 
            List<Entidades.Articulo> ListaArticulosFiltrados, 
            List<Familia> familias,
            List<Proveedor> proveedores,
            int selectedProveedorIdx,
            int selectedFamiliaIdx)
        {
            InitializeComponent();
            this.familias = familias;
            this.proveedores = proveedores;
            this.ListaArticulos = ListaArticulos;
            this.ListaArticulosFiltrados = ListaArticulosFiltrados;
            completaCombosBox();
            this.cbxFiltroFamilia.SelectedIndex = selectedFamiliaIdx;
            this.cbxFiltroProveedor.SelectedIndex = selectedProveedorIdx;
         


            // Radio Buttons
            actualizarPaso3();

            // GRILLA
            dgvListado.DataSource = ListaArticulosFiltrados;
            dgvListado.Columns["habilitado"].Visible = false;
            dgvListado.Columns["RangoEtario"].Visible = false;
            dgvListado.Columns["Familia"].Visible = false;
            dgvListado.Columns["Costo"].Visible = false;
            dgvListado.Columns["RangoEtarioTexto"].HeaderText = "Rango etario";
            dgvListado.Columns["FamiliaTexto"].HeaderText = "Familia";
            dgvListado.Columns["CodigoArtiProveedor"].HeaderText = "Codigo proveedor";
            dgvListado.Columns["descripcion"].Width = 280;
            dgvListado.Columns["codigo"].HeaderText = "Código";
            dgvListado.Columns["descripcion"].HeaderText = "Descripción";
            dgvListado.Columns["stockMin"].HeaderText = "Stock Min.";
            dgvListado.Columns["precio"].HeaderText = "Precio ($)";
            dgvListado.Columns["stock"].Width = 45;
            dgvListado.Columns["stockMin"].Width = 45;
            dgvListado.Columns["precio"].Width = 75;
            dgvListado.Size = new Size(960, 380);

            dgvListado.Location = new Point(7, 56);
            dgvListado.DataSource = ListaArticulosFiltrados;

            // Si la columna precioActualizado no existe, añadir una columna nueva a la grilla, al lado de precio actual
            AñadirColumnaPrecioNuevo();
            
        }


        #region Variables Locales

        BindingList<Entidades.Articulo> ListaArticulos;
        List<Entidades.Articulo> ListaArticulosFiltrados;
        
      
        //Lista de Familias
        List<Familia> familias = new List<Familia>();
        //Lista de Proveedores
        List<Proveedor> proveedores = new List<Proveedor>();

        int selectedProveedorIdx;
        int selectedFamiliaIdx;

        // Fisica cuantica PARA PONERLE PLACEHOLDER AL CBX
        private const int CB_SETCUEBANNER = 0x1703;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);


        #endregion


        private void completaCombosBox()
        {            
            if (familias != null)
            {
                cbxFiltroFamilia.DataSource = familias;
                cbxFiltroFamilia.DisplayMember = "descripcion";
                cbxFiltroFamilia.ValueMember = "id";
                cbxFiltroFamilia.SelectedIndex = -1;
                cbxFiltroFamilia.SelectedValueChanged += cbxFiltroFamilia_SelectedValueChanged;

            }

            if (proveedores != null)
            {
                cbxFiltroProveedor.DataSource = proveedores;
                cbxFiltroProveedor.DisplayMember = "Nombre";
                cbxFiltroProveedor.ValueMember = "Nombre";
                cbxFiltroProveedor.SelectedIndex = -1;
                cbxFiltroProveedor.SelectedValueChanged += cbxFiltroProveedor_SelectedValueChanged;
            }
            SendMessage(this.cbxFiltroProveedor.Handle, CB_SETCUEBANNER, 0, "Filtrar por proveedor...");
            SendMessage(this.cbxFiltroFamilia.Handle, CB_SETCUEBANNER, 0, "Filtrar por familia...");

        }

        // RB AUMENTO ó REDUCCION
        private string cambiaOperacion()
        {
            if (rbAumento.Checked)
            {
                mostrarResumen();
                return "aumento";
            }
            else 
            {
                mostrarResumen();
                return "reducción";
            };
        }

        // RB PORCENTAJE O MONTO FIJO
        private string cambiaMetodo()
        {
            if (rbPorcentaje.Checked)
            {
                mostrarResumen();
                return "%" + txtMontoPorcentaje.Text.ToString();
            }
            else
            {
                mostrarResumen();
                return "$" + txtMontoPorcentaje.Text.ToString();
            };
            
        }

        // MENSAJE RESUMEN
        private void actualizarPaso3()
        {
            string mensaje = "";

            if (rbAumento.Checked)
            {
                mostrarResumen();
                mensaje = rbPorcentaje.Checked ? "Ingrese porcentaje de aumento" : "Ingrese el monto de aumento";
            }
            else
            {
                mostrarResumen();
                mensaje = rbPorcentaje.Checked ? "Ingrese porcentaje a reducir" : "Ingrese monto a reducir";
            }

            lblPaso3.Text = mensaje;
        }



        #region EVENTOS DE CONTROLES DE UI

        // RB OPCION PORCENTAJE CHECKED CHANGE
        private void rbPorcentaje_CheckedChanged(object sender, EventArgs e)
        {
            cambiaMetodo();
            actualizarPaso3();
            CargarDatosPrecioNuevo();
        }
      
        // RB OPCION MONTO FIJO CHECKED CHANGE
        private void rbMontoFijo_CheckedChanged(object sender, EventArgs e)
        {
            cambiaMetodo();
            actualizarPaso3();
            CargarDatosPrecioNuevo();
        }

        // RB AUMENTAR CHECKED CHANGE
        private void rbAumento_CheckedChanged(object sender, EventArgs e)
        {
            cambiaOperacion();
            actualizarPaso3();
            CargarDatosPrecioNuevo();
        }

        // RB REDUCIR CHECKED CHANGE
        private void rbReduccion_CheckedChanged(object sender, EventArgs e)
        {
            cambiaOperacion();
            actualizarPaso3();
            CargarDatosPrecioNuevo();
        }
       
        // CAMBIO VALOR
        private void txtMontoPorcentaje_TextChanged(object sender, EventArgs e)
        {
            CargarDatosPrecioNuevo();
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

        // MOFIFICAR EL FILTRO DE BUSQUEDA 
        private void tbxFiltro_TextChanged_2(object sender, EventArgs e)
        {
            AplicaFiltros();
        }

        // MARCAR REDONDEAR PRECIO ACTUALIZADO
        private void cbRedondear_CheckedChanged(object sender, EventArgs e)
        {

        }

        // CLICK LIMPIAR FILTROS

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        #endregion

        // ELIMINAR ESTA PORQUERIA
        private void mostrarResumen()
        {
            string resumen = "";
            string valor = txtMontoPorcentaje.Text.ToString();

            if (txtMontoPorcentaje.Text.Length > 0)
            {
                if (rbAumento.Checked)
                {
                    resumen = rbPorcentaje.Checked ? "Los precios aumentarán un %"+valor : "Se aplicará un aumento de $"+valor;
                }
                else
                {
                    resumen = rbPorcentaje.Checked ? "Los precios se reducirán un -%" + valor : "Se aplicará una reducción de -$" + valor;
                }
                lblResumen.Text = resumen;
                lblResumen.Visible = true;

            }
        }
       
        // Calcular los precios nuevos en funcion de las opciones seleccionadas
        private void CargarDatosPrecioNuevo()
        {
            foreach (DataGridViewRow fila in dgvListado.Rows)
            {
                if (fila.Cells["precio"].Value != null)
                {
                    if (this.txtMontoPorcentaje.Text != "")
                    {
                        double precioActual = Convert.ToDouble(fila.Cells["precio"].Value.ToString());
                        double valor = Convert.ToInt32(this.txtMontoPorcentaje.Text);
                        double precioActualizado = CalcularPrecioActualizado(precioActual, rbAumento.Checked, rbPorcentaje.Checked, valor);
                        fila.Cells["precioActualizado"].Value = precioActualizado;
                    }
                }
            }
        }

        // Añade la columna PRECIO NUEVO
        private void AñadirColumnaPrecioNuevo()
        {
            DataGridViewColumn columnaNuevoPrecio = new DataGridViewColumn();
            columnaNuevoPrecio.Name = "precioActualizado";
            columnaNuevoPrecio.HeaderText = "Precio Actualizado";
            columnaNuevoPrecio.Width = 75;
            columnaNuevoPrecio.CellTemplate = new DataGridViewTextBoxCell();
            columnaNuevoPrecio.DefaultCellStyle.BackColor = Color.LightGreen;
            int posicionPrecioNuevo = this.dgvListado.Columns["precio"].Index + 1;
            this.dgvListado.Columns.Insert(posicionPrecioNuevo, columnaNuevoPrecio);
            dgvListado.Columns["precio"].DefaultCellStyle.BackColor = Color.IndianRed;
        }


        // Dado el precio actual, y las opciones seleccionadas en el formulario, calcula y devuelve el precio actualizado
        private Double CalcularPrecioActualizado(Double precioActual, Boolean aumenta, Boolean porcentaje, Double valor)
        {
            Double precioActualizado = 0;

            if (aumenta)
            {
                precioActualizado = porcentaje ? precioActual + (precioActual * valor / 100) : precioActual + valor;
            }
            else
            {
                precioActualizado = porcentaje ? precioActual - (precioActual * valor / 100) : precioActual - valor;
            }

            if(cbRedondear.Checked)
            {
                precioActualizado = Math.Ceiling(precioActualizado / 10) * 10;
            }

            return precioActualizado;

        }
    
        // Limpia los filtros y muestra todos los articulos en la grilla
        private void LimpiarFiltros()
        {
            tbxFiltro.Text = "";
            cbxFiltroFamilia.SelectedIndex = -1;
            cbxFiltroProveedor.SelectedIndex = -1;
        }

        // Actualiza dgvDataSource en funcion de los filtros aplicados
        private void AplicaFiltros()
        {
            string searchTerm = tbxFiltro.Text.ToLowerInvariant();

            if (searchTerm == "" && !FiltrandoPorProveedor() && !FiltrandoPorFamilia())
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

                    if (FiltrandoPorFamilia())
                    {
                        ListaArticulosFiltrados = ListaArticulosFiltrados
                            .Where(articulo => articulo.Familia == (int)cbxFiltroFamilia.SelectedValue)
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

        // Determina si actualmente se esta filtrando por familia
        private bool FiltrandoPorFamilia()
        {

            if (cbxFiltroFamilia.SelectedIndex != -1)
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
            if (searchTerm != "" && !FiltrandoPorProveedor() && !FiltrandoPorFamilia())
            {
                return true;
            }
            return false;
        }

        // Carga TODOS los articulos en la grilla
        private void RecargarArticulos()
        {
            dgvListado.DataSource = ListaArticulos;
        }

    }
}
