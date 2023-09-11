using Microsoft.VisualBasic.Logging;
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
    public partial class frmModificarPrecios : frmBaseListado
    {

        BindingList<Entidades.Articulo> ListaArticulos;
        List<Entidades.Articulo> ListaArticulosFiltrados;

        public frmModificarPrecios(BindingList<Entidades.Articulo> ListaArticulos, List<Entidades.Articulo> ListaArticulosFiltrados)
        {
            InitializeComponent();
            this.ListaArticulos = ListaArticulos;
            this.ListaArticulosFiltrados = ListaArticulosFiltrados;


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
        }

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

        private void rbPorcentaje_CheckedChanged(object sender, EventArgs e)
        {
            cambiaMetodo();
            actualizarPaso3();
        }
      

        private void rbMontoFijo_CheckedChanged(object sender, EventArgs e)
        {
            cambiaMetodo();
            actualizarPaso3();
        }

        private void rbAumento_CheckedChanged(object sender, EventArgs e)
        {
            cambiaOperacion();
            actualizarPaso3();
        }

        private void rbReduccion_CheckedChanged(object sender, EventArgs e)
        {
            cambiaOperacion();
            actualizarPaso3();
        }

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

        private void txtMontoPorcentaje_TextChanged(object sender, EventArgs e)
        {
            mostrarResumen();
        }
    }
}
