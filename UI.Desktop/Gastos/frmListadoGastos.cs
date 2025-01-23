using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Gastos
{
    public partial class frmListadoGastos : frmBaseListado
    {
        public frmListadoGastos()
        {
            InitializeComponent();
            ActualizarLista();

            //dgvListado.Columns["Nombre"].HeaderText = "Nombre o Razón Social";
            //dgvListado.Columns["Nombre"].Width = 150;
            //this.btnImportar.Visible = false;
            this.btnEliminar.Visible = //this.btnAñadirNuevo.Visible = 
                this.btnModificar.Enabled= false;

        }


        #region ///***///***///***/// V A R I A B L E S   L O C A L E S \\\***\\\***\\\***\\\
        //LISTA DE GASTOS
        public List<Entidades.Gasto> ListaGastos;

        #endregion


        #region ///***///***///***/// M E T O D O S \\\***\\\***\\\***\\\

        // ACTUALIZAR LISTA DE PROVEEDORES
        private void ActualizarLista()
        {
            this.ListaGastos = DatosGastosAdapter.GetAll();
            dgvListado.DataSource = ListaGastos;
        }


        // Añadir NUEVO PROVEEDOR
        private void AñadirNuevoGasto()
        {
            frmIngresoGasto formNuevoGasto = new frmIngresoGasto();
            //  Otras modificaciones al formulario alta Proveedor
            formNuevoGasto.ShowDialog();

            //Completa la tabla con los datos nuevos
            ActualizarLista();
        }

        // Eliminar PROVEEDOR
        private void EliminarProveedor()
        {
            //    Confirmación eliminación
            Mensajes.frmConfirmar formConfirmar = new Mensajes.frmConfirmar("¿Está seguro que desea ELIMINAR el registro seleccionado?", "Eliminar");

            if (formConfirmar.ShowDialog() == DialogResult.Yes)
            {
                string provToDelete = dgvListado.SelectedRows[0].Cells["nombre"].Value.ToString();

                DatosProveedorAdapter.Quitar(provToDelete);
                ActualizarLista();
            }

        }

        #endregion


        #region ///***///***///***/// E V E N T O S \\\***\\\***\\\***\\\

        // CLICK Nuevo Poveedor
        private void btnAñadirNuevo_Click(object sender, EventArgs e)
        {
            AñadirNuevoGasto();
        }

        //MODIFICAR EL FILTRO DE BUSQUEDA
        private void tbxFiltro_TextChanged_1(object sender, EventArgs e)
        {
            if (tbxFiltro.Text == "")
            {
                dgvListado.DataSource = DatosGastosAdapter.GetAll();
            }
            else
            {
                dgvListado.DataSource = DatosGastosAdapter.GetAllFiltro(tbxFiltro.Text);
            }

        }

        #endregion
    }
}
