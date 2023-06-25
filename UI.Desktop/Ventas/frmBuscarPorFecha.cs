using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Database;

namespace UI.Desktop.Ventas
{
    public partial class frmBuscarPorFecha : Form
    {
        public frmBuscarPorFecha()
        {
            InitializeComponent();
        }

        public string TipoBusqueda = "";
        VentasAdapter Datos_VentasAdapter = new VentasAdapter();
        ClienteAdapter DatosClienteAdapter = new ClienteAdapter();
        public string dniClienteSeleccionado;


        private void btnConfirmarFechaDesde_Click(object sender, EventArgs e)
        {
            TipoBusqueda = "Fecha Desde";
            this.Close();

        }

        private void btnConfirmarDesdeHasta_Click(object sender, EventArgs e)
        {
            TipoBusqueda = "Desde-Hasta";
            this.Close();
        }

        //TXT CLIENTE TEXT CHANGE
        private void txtFiltroCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltroCliente.Text == "")
            {
               dgvListaClientes.DataSource = DatosClienteAdapter.GetAll();
               OcultarColumnas();
            }
            else
            {
               dgvListaClientes.DataSource = DatosClienteAdapter.Busqueda(txtFiltroCliente.Text);

               OcultarColumnas();
            }
        }

        //METODO OCULTAR COLUMNAS
        private void OcultarColumnas()
        {
            foreach (DataGridViewColumn col in dgvListaClientes.Columns)
            {
                if (col.Name == "Nombre" || col.Name == "Apellido" || col.Name == "Dni")
                {//SI COLUMNAME ES DNI APELLIDO O NOMBRE --> Visible=true; else =false; Las otras las oculto
                    col.Visible = true;
                    if (col.Name == "Dni")
                    {
                        col.Width = 85;
                    }
                }
                else { col.Visible = false; }
            }
        }

        //SELECCIONAR PESTAÑA POR CLIENTE
        private void pBuscarPorCliente_Enter(object sender, EventArgs e)
        {
            ActualizarListaClientes();
        }

        //Actualizar lista de clientes y reacomodar columnas
        private void ActualizarListaClientes()
        {

            dgvListaClientes.DataSource = DatosClienteAdapter.GetAll();
            OcultarColumnas();
        }

        //CLICK CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //CLICK SELECCIONAR CLIENTE
        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            dniClienteSeleccionado = dgvListaClientes.SelectedRows[0].Cells["NumeroDocumento"].Value.ToString();
        }

     

     

        
    }
}
