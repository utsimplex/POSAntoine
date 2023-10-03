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
        public List<Familia> familiaListado;


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
            dgvFamiliasListado.Columns[3].Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarFamilias())
            {
                this.DialogResult= DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }

            //List<Familia> familias = new List<Familia>();

            //foreach (DataGridViewRow row in this.dgvFamiliasListado.Rows)
            //{
            //    if (row.IsNewRow) continue; // Ignora la fila nueva

            //    string descripcion = row.Cells["Descripcion"].Value?.ToString();
            //    bool activo = (bool)row.Cells["Activo"].Value;

            //    Familia familia = new Familia
            //    {
            //        Descripcion = descripcion,
            //        Activo = activo
            //    };
                
            //    familias.Add(familia);
            //}
        }

        private void btnAgregarFila_Click(object sender, EventArgs e)
        {
            Familia nuevaFamilia = new Familia();
            familiaListado.Add(nuevaFamilia); // Agrega un nuevo objeto Familia a la lista de objetos Familia
            dgvFamiliasListado.DataSource = null; // Establece el origen de datos del DataGridView a null
            dgvFamiliasListado.DataSource = familiaListado;
            ConfigurarGrilla();

            // Setear FOCO en la fila nueva recien añadida
            int nuevaFilaIndex = dgvFamiliasListado.Rows.Count - 1; // Obtiene el índice de la nueva fila
            if (nuevaFilaIndex >= 0)
            {
                dgvFamiliasListado.CurrentCell = dgvFamiliasListado.Rows[nuevaFilaIndex].Cells[1]; // Selecciona la celda correspondiente a la primera columna de la nueva fila
                dgvFamiliasListado.BeginEdit(true); // Comienza la edición de la nueva fila
            }
        }

        private bool ValidarFamilias()
        {
            foreach (DataGridViewRow row in dgvFamiliasListado.Rows)
            {
                

                string descripcion = row.Cells[1].Value?.ToString();

                if (string.IsNullOrEmpty(descripcion))
                {
                    MessageBox.Show("La descripción de la familia no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void dgvFamiliasListado_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 )
            {
                Familia familia = dgvFamiliasListado.Rows[e.RowIndex].DataBoundItem as Familia;
                if (familia != null && familia.id != null)
                {
                    familia.IsModified = true; // Establece la propiedad IsModified en true para la fila correspondiente
                }
            }
        }
    }
}
