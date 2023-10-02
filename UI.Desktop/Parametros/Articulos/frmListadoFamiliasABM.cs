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

namespace UI.Desktop.Parametros.Articulos
{
    public partial class frmListadoFamiliasABM : Form
    {

        string familiaSeleccionada;
        ParametrosEmpresa parametrosEmpresa;
        List<Familia> familiaListado;


        public frmListadoFamiliasABM(string familiaNombre)
        {
            InitializeComponent();
            this.familiaSeleccionada = familiaNombre;
            ParametrosEmpresaController.GetInstance().ObtenerListadoFamilias();
            this.parametrosEmpresa = ParametrosEmpresaController.GetInstance().parametrosEmpresaObj;

            if (this.familiaSeleccionada == "Familia1")
            {
                this.familiaListado = parametrosEmpresa.ListadoFamilia1;
                this.txtNombreFamilia.Text = parametrosEmpresa.FamiliaNombre1;
                this.dgvFamiliasListado.DataSource = familiaListado;

            }
            if(this.familiaSeleccionada == "Familia2")
            {
                this.familiaListado = parametrosEmpresa.ListadoFamilia2;
                this.txtNombreFamilia.Text = parametrosEmpresa.FamiliaNombre2;
                this.dgvFamiliasListado.DataSource = familiaListado;
            }


            ConfigurarGrilla();
          

        }

        private void ConfigurarGrilla()
        {

            // Establecer la propiedad AutoSizeMode en DataGridViewAutoSizeColumnMode.Fill
            dgvFamiliasListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Establecer el porcentaje deseado para cada columna
            //int column1WidthPercentage = 20;
            int column2WidthPercentage = 60;
            int column3WidthPercentage = 20;

            // Establecer el FillWeight de cada columna en función del porcentaje deseado
            //dgvFamiliasListado.Columns[0].FillWeight = column1WidthPercentage;
            dgvFamiliasListado.Columns[0].Visible = false;
            dgvFamiliasListado.Columns[1].FillWeight = column2WidthPercentage;
            dgvFamiliasListado.Columns[2].FillWeight = column3WidthPercentage;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
