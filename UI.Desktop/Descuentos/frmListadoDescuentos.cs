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

namespace UI.Desktop.Descuentos
{
    public partial class frmListadoDescuentos : frmBaseListado
    {
        public frmListadoDescuentos()
        {
            InitializeComponent();
            this.dgvListado.CellFormatting += dgvListado_CellFormatting;
            ActualizarLista();
            FormatearUITabla();

        }


        private void FormatearUITabla()
        {
            this.dgvListado.Columns["descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvListado.Columns["descripcion"].Width = 300;
            this.dgvListado.Columns["descripcion"].HeaderText = "Descripción";
            this.dgvListado.Columns["Activa"].HeaderText = "Activo";
            this.dgvListado.Columns["Activa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvListado.Columns["dispositivo"].HeaderText = "Dispositivo";
            this.dgvListado.Columns["dispositivo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvListado.Columns["porcentajeDescuento"].HeaderText = "Descuento (%)";
            this.dgvListado.Columns["porcentajeDescuento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvListado.Columns["AplicaFechasString"].HeaderText = "Fechas Puntuales";
            this.dgvListado.Columns["AplicaFechasString"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvListado.Columns["MedioDePago"].HeaderText = "Medio de Pago";
            this.dgvListado.Columns["MedioDePago"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvListado.Columns["AplicaLunes"].HeaderText = "Lunes";
            this.dgvListado.Columns["AplicaMartes"].HeaderText = "Martes";
            this.dgvListado.Columns["AplicaMiercoles"].HeaderText = "Miercoles";
            this.dgvListado.Columns["AplicaJueves"].HeaderText = "Jueves";
            this.dgvListado.Columns["AplicaViernes"].HeaderText = "Viernes";
            this.dgvListado.Columns["AplicaSabado"].HeaderText = "Sabado";
            this.dgvListado.Columns["AplicaDomingo"].HeaderText = "Domingo";

            this.dgvListado.Columns["AplicaLunes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //this.dgvListado.Columns["AplicaLunes"].Width = 30;
            this.dgvListado.Columns["AplicaMartes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //this.dgvListado.Columns["AplicaMartes"].Width = 30;
            this.dgvListado.Columns["AplicaMiercoles"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //this.dgvListado.Columns["AplicaMiercoles"].Width = 30;
            this.dgvListado.Columns["AplicaJueves"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //this.dgvListado.Columns["AplicaJueves"].Width = 30;
            this.dgvListado.Columns["AplicaViernes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //this.dgvListado.Columns["AplicaViernes"].Width = 30;
            this.dgvListado.Columns["AplicaSabado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //this.dgvListado.Columns["AplicaSabado"].Width = 30;
            this.dgvListado.Columns["AplicaDomingo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //this.dgvListado.Columns["AplicaDomingo"].Width = 30;
        }


        #region ///***///***///***/// V A R I A B L E S   L O C A L E S \\\***\\\***\\\***\\\

        //LISTA DE DescuentoS
        public List<Entidades.Descuento> ListaDescuentos;

        //LISTA DE DescuentoS FILTRADOS
        public List<Entidades.Descuento> ListaDescuentosFiltrados;


        //Adapters
        DescuentoAdapter Datos_DescuentoAdapter = new DescuentoAdapter();
        //ROL
        string rol;

        // Fisica cuantica PARA PONERLE PLACEHOLDER AL CBX
        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);



        #endregion

        #region ///***///***///***/// M E T O D O S \\\***\\\***\\\***\\\

        //COMPLETAR COMBOBOXS

       
        // ACTUALIZAR LISTA DE DescuentoS
        private void ActualizarLista()
        {
            ListaDescuentos = Datos_DescuentoAdapter.GetAll(false);

            dgvListado.DataSource = ListaDescuentos;

            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvListado.Size = new Size(1077, 490);
            this.dgvListado.Location = new Point(7, 56);


            dgvListado.Columns["Id"].Visible = false;

        }

       
        // Añadir NUEVO Descuento
        private void AñadirNuevoDescuento()
        {
            Descuentos.frmDescuentoABM frmAltaDescuento = new Descuentos.frmDescuentoABM();
            frmAltaDescuento.ModoForm = Descuentos.frmDescuentoABM.TipoForm.Alta;


            if (frmAltaDescuento.DialogResult != DialogResult.Abort)
            {
                frmAltaDescuento.ShowDialog();
            }


            //Completa la tabla con los datos nuevos
            ActualizarLista();
        }

        // Eliminar Descuento
        private void EliminarDescuento()
        {
            //    Confirmación eliminación
            Mensajes.frmConfirmar formConfirmar = new Mensajes.frmConfirmar("¿Está seguro que desea ELIMINAR el registro seleccionado?", "");

            if (formConfirmar.ShowDialog() == DialogResult.Yes)
            {
            int Codigo = Convert.ToInt32(dgvListado.SelectedRows[0].Cells["Id"].Value);
                Descuento arti_a_Ocultar = ListaDescuentosFiltrados.First(Descuento => Descuento.Id == Codigo);
                Datos_DescuentoAdapter.Actualizar(arti_a_Ocultar);

            }
            ActualizarLista();
        }

        // Modificar Descuento ************************ CONTINUAR ARREGLANDO MODIFICAR Descuento
        private void ModificarDescuento()
        {

            // Artículo a modificar = artiToEdit
            Descuento descuentoToEdit = new Descuento();

            int Codigo = Convert.ToInt32(dgvListado.SelectedRows[0].Cells["Id"].Value);
            descuentoToEdit = ListaDescuentos.First(Descuento => Descuento.Id == Codigo);
            
            // Instanciación del formulario ABM Descuentos EDICION
            frmDescuentoABM formDescuentoABM = new frmDescuentoABM(descuentoToEdit);
            formDescuentoABM.ModoForm = frmDescuentoABM.TipoForm.Edicion;
            
            //ABRIR FORMULARIO            
            formDescuentoABM.ShowDialog();
            ActualizarLista();

        }

        #endregion

        #region ///***///***///***/// E V E N T O S \\\***\\\***\\\***\\\



        // CLICK Añadir
        private void btnAñadirNuevo_Click(object sender, EventArgs e)
        {
            AñadirNuevoDescuento();
        }

        // CLICK Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (rol == "Empleado")
            {
                MessageBox.Show("El usuario no posee permisos para realizar esta tarea.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ModificarDescuento();
            }
        }


        // DOBLE CLICK Sobre un Descuento
        override public void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            ModificarDescuento();
        }


        // CLICK ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (rol == "Empleado")
            {
                MessageBox.Show("El usuario no posee permisos para realizar esta tarea.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (dgvListado.SelectedRows.Count != 0)
            {
                EliminarDescuento();
            }
        }



        
        // CLICK Salir
        public void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

              #endregion

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            LimpiarFiltros();
            RecargarDescuentos();
            ActualizarLista();
        }


        private void LimpiarFiltros()
        {
            tbxFiltro.Text = "";
        }

        private void AplicaFiltros()
        {
            string searchTerm = tbxFiltro.Text.ToLowerInvariant();

            if (searchTerm == "")
            {
                RecargarDescuentos();
            }
            else
            {
                if (FiltraSoloPorTexto(searchTerm))
                {
                    ListaDescuentosFiltrados = AplicarFiltroTexto(searchTerm, ListaDescuentos);
                }
                dgvListado.DataSource = ListaDescuentosFiltrados;
            }


        }

        // MOFIFICAR EL FILTRO DE BUSQUEDA
        private void tbxFiltro_TextChanged_1(object sender, EventArgs e)
        {
            AplicaFiltros();
        }

        // Carga TODOS los Descuentos en la grilla
        private void RecargarDescuentos()
        {
            dgvListado.DataSource = ListaDescuentos;
        }

        // Aplicar filtro segun el valor del search term, a la lista especificada
        private List<Descuento> AplicarFiltroTexto(string searchTerm, List<Descuento> listaAfiltrar)
        {
            return listaAfiltrar.Where(
                   a => a.Descripcion.ToLowerInvariant().Contains(searchTerm)
                     || a.Dispositivo.ToLowerInvariant().Contains(searchTerm)
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

        // Determina si se esta filtrando por texto, pero No se esta filtrando por proveedor ni familia
        private bool FiltraSoloPorTexto(string searchTerm)
        {
            if (searchTerm != "")
            {
                return true;
            }
            return false;
        }
    }
}
