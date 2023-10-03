using AfipWscdcServiceReference;
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
using UI.Desktop.Mensajes;

namespace UI.Desktop.Artículos
{
    public partial class frmModificarPrecios : frmBaseListado
    {

        public frmModificarPrecios(
            BindingList<Entidades.Articulo> ListaArticulos, 
            List<Entidades.Articulo> ListaArticulosFiltrados, 
            List<Familia> familias1,
            List<Familia> familias2,
            List<Proveedor> proveedores,
            int selectedProveedorIdx,
            int selectedFamilia1Idx,
            int selectedFamilia2Idx,
            ParametrosEmpresa pParametrosEmpresa)
        {
            InitializeComponent();
            this.dgvListado.CellFormatting += dgvListado_CellFormatting;
            this.familias1 = familias1;
            this.familias2 = familias2;
            this.proveedores = proveedores;
            this.ListaArticulos = ListaArticulos;
            this.ListaArticulosFiltrados = ListaArticulosFiltrados;
            this.parametrosEmpresa = pParametrosEmpresa;
            completaCombosBox();
            this.cbxFiltroFamilia1.SelectedIndex = selectedFamilia1Idx;
            this.cbxFiltroFamilia2.SelectedIndex = selectedFamilia2Idx;
            this.cbxFiltroProveedor.SelectedIndex = selectedProveedorIdx;
         


            // Radio Buttons
            actualizarPaso3();

            // GRILLA
            dgvListado.DataSource = ListaArticulosFiltrados;

            dgvListado.Columns["habilitado"].Visible = false;
            //dgvListado.Columns["RangoEtario"].Visible = false;

            // FAMILIAS
            this.dgvListado.Columns["Familia1"].Visible = !string.IsNullOrEmpty(parametrosEmpresa.FamiliaNombre1.Trim());
            this.dgvListado.Columns["Familia1"].HeaderText = parametrosEmpresa.FamiliaNombre1;

            this.dgvListado.Columns["Familia2"].Visible = !string.IsNullOrEmpty(parametrosEmpresa.FamiliaNombre2.Trim());
            this.dgvListado.Columns["Familia2"].HeaderText = parametrosEmpresa.FamiliaNombre2;

            // CAMPOS PERSONALIZADOS
            this.dgvListado.Columns["CampoPersonalizado1"].Visible = !string.IsNullOrEmpty(parametrosEmpresa.CampoPersonalizadoArticulo1.Trim());
            this.dgvListado.Columns["CampoPersonalizado1"].HeaderText = parametrosEmpresa.CampoPersonalizadoArticulo1.Trim();

            this.dgvListado.Columns["CampoPersonalizado2"].Visible = !string.IsNullOrEmpty(parametrosEmpresa.CampoPersonalizadoArticulo2.Trim());
            this.dgvListado.Columns["CampoPersonalizado2"].HeaderText = parametrosEmpresa.CampoPersonalizadoArticulo2.Trim();


            dgvListado.Columns["Costo"].Visible = false;
            dgvListado.Columns["CodigoArtiProveedor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvListado.Columns["descripcion"].Width = 280;
            dgvListado.Columns["codigo"].HeaderText = "Código";
            dgvListado.Columns["codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvListado.Columns["descripcion"].HeaderText = "Descripción";
            dgvListado.Columns["stockMin"].HeaderText = "Stock Min.";
            dgvListado.Columns["precio"].HeaderText = "Precio ($)";
            dgvListado.Columns["stock"].Width = 45;
            dgvListado.Columns["stockMin"].Width = 45;
            dgvListado.Columns["precio"].Width = 75;
            dgvListado.Size = new Size(960, 380);

            dgvListado.Location = new Point(7, 56);
            //dgvListado.DataSource = ListaArticulosFiltrados;

            // Si la columna precioActualizado no existe, añadir una columna nueva a la grilla, al lado de precio actual
            AñadirColumnaPrecioNuevo();
            
        }

        override public void dgvListado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == dgvListado.Columns["Familia1"].Index && e.Value != null) 
                || (e.ColumnIndex == dgvListado.Columns["Familia2"].Index && e.Value != null))
            {
                if (e.Value is Familia familia)
                {
                    e.Value = familia.Descripcion;
                }
            }
        }

        #region Variables Locales

        BindingList<Entidades.Articulo> ListaArticulos;
        List<Entidades.Articulo> ListaArticulosFiltrados;
        
      
        //Lista de Familias
        List<Familia> familias1 = new List<Familia>();
        List<Familia> familias2 = new List<Familia>();

        //Lista de Proveedores
        List<Proveedor> proveedores = new List<Proveedor>();
        
        //Articulo adapter
        ArticuloAdapter Datos_ArticuloAdapter = new ArticuloAdapter();

        int selectedProveedorIdx;
        int selectedFamiliaIdx;
        string mensajeConfirmacion;
        private ParametrosEmpresa parametrosEmpresa = new ParametrosEmpresa();

        // Fisica cuantica PARA PONERLE PLACEHOLDER AL CBX
        private const int CB_SETCUEBANNER = 0x1703;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);


        #endregion


        private void completaCombosBox()
        {        
            // CBX FAMILIA 1
            if (parametrosEmpresa.FamiliaNombre1.Length>0 && familias1 != null && familias1.Count != 0)
            {
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
            if (parametrosEmpresa.FamiliaNombre2.Length > 0 && familias2 != null && familias2.Count != 0)
            {
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

            if (proveedores != null)
            {
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

        // RB AUMENTO ó REDUCCION
        private string cambiaOperacion()
        {
            if (rbAumento.Checked)
            {
                actualizarMensajeConfirmacion();
                return "aumento";
            }
            else 
            {
                actualizarMensajeConfirmacion();
                return "reducción";
            };
        }

        // RB PORCENTAJE O MONTO FIJO
        private string cambiaMetodo()
        {
            if (rbPorcentaje.Checked)
            {
                actualizarMensajeConfirmacion();
                return "%" + txtMontoPorcentaje.Text.ToString();
            }
            else
            {
                actualizarMensajeConfirmacion();
                return "$" + txtMontoPorcentaje.Text.ToString();
            };
            
        }

        // MENSAJE RESUMEN
        private void actualizarPaso3()
        {
            string mensaje = "";

            if (rbAumento.Checked)
            {
                actualizarMensajeConfirmacion();
                mensaje = rbPorcentaje.Checked ? "Ingrese porcentaje de aumento" : "Ingrese el monto de aumento";
            }
            else
            {
                actualizarMensajeConfirmacion();
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
            CargarDatosPrecioNuevo();
        }

        // CLICK LIMPIAR FILTROS

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
        }

        #endregion

        // ELIMINAR ESTA PORQUERIA
        private void actualizarMensajeConfirmacion()
        {
            
            string valor = txtMontoPorcentaje.Text.ToString();

            if (txtMontoPorcentaje.Text.Length > 0)
            {
                if (rbAumento.Checked)
                {
                    mensajeConfirmacion = rbPorcentaje.Checked ? "Los precios aumentarán un %"+valor : "Se aplicará un aumento de $"+valor;
                }
                else
                {
                    mensajeConfirmacion = rbPorcentaje.Checked ? "Los precios se reducirán un -%" + valor : "Se aplicará una reducción de -$" + valor;
                }
               

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
            columnaNuevoPrecio.DefaultCellStyle.Format = "c";
            int posicionPrecioNuevo = this.dgvListado.Columns["precio"].Index + 1;
            this.dgvListado.Columns.Insert(posicionPrecioNuevo, columnaNuevoPrecio);
            dgvListado.Columns["precio"].DefaultCellStyle.BackColor = Color.IndianRed;
            dgvListado.Columns["precio"].DefaultCellStyle.Format = "c";
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
                precioActualizado = (precioActualizado % 10 >= 5) ? Math.Ceiling(precioActualizado / 10) * 10 : Math.Floor(precioActualizado / 10) * 10;
            }
            actualizarPaso3();
            return precioActualizado;

        }
    
        // Limpia los filtros y muestra todos los articulos en la grilla
        private void LimpiarFiltros()
        {
            tbxFiltro.Text = "";
            cbxFiltroFamilia1.SelectedIndex = -1;
            cbxFiltroFamilia2.SelectedIndex = -1;
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
                            .Where(articulo => articulo.Familia1.id == (int)cbxFiltroFamilia1.SelectedValue)
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

            if (cbxFiltroFamilia1.SelectedIndex != -1)
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

        private void btnActualizarPrecios_Click(object sender, EventArgs e)
        {
            frmConfirmar frmConfirmarActualizacion = new frmConfirmar( mensajeConfirmacion + ". ¿Está seguro que desea guardar estos cambios?", "");
            if( frmConfirmarActualizacion.ShowDialog() == DialogResult.Yes) 
            {
                // LOGICA PARA GUARDAR LOS PRECIOS NUEVOS
                foreach (DataGridViewRow fila in dgvListado.Rows)
                {
                    if (fila.Cells["precio"].Value != null)
                    {
                        if (fila.Cells["precioActualizado"].Value != null)
                        {
                            // Articulo y precioNuevo
                            Articulo artiToEdit = new Articulo();
                            decimal precioNuevo = Convert.ToDecimal(fila.Cells["precioActualizado"].Value.ToString());

                            // Obtengo artículo a modificar = artiToEdit desde la ListaArticulosFiltrados
                            string Codigo = fila.Cells["codigo"].Value.ToString();
                            artiToEdit = ListaArticulosFiltrados.First(articulo => articulo.Codigo == Codigo);

                            // Seteo precio nuevo
                            artiToEdit.Precio = precioNuevo;

                            Datos_ArticuloAdapter.Actualizar(artiToEdit);

                        }
                    }
                }
                this.DialogResult = DialogResult.Yes;
                this.Close();
                
            }
            
            
        }
    }
}
