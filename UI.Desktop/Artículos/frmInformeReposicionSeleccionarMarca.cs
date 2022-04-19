using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Database;

namespace UI.Desktop.Artículos
{
    public partial class frmInformeReposicionSeleccionarMarca : Form
    {
        public frmInformeReposicionSeleccionarMarca()
        {
            InitializeComponent();
        }

        // VARIABLES LOCALES

        ArticuloAdapter Datos_ArticulosAdapter = new ArticuloAdapter();
        InformeArticulos Datos_InformeArticulosAdapter = new InformeArticulos();
        ProveedorAdapter Datos_ProveedorAdapter = new ProveedorAdapter();

        //Informe Stock Crítico - Artículos a Reponer POR MARCA
        public void informeStockCriticoPorMarca(string marca)
        {
            string marcaSeleccionada = "";
            marcaSeleccionada = "'" + marca + "'";
            string sql = "SELECT marca, codigo, descripcion, stock, stockmin FROM  Articulos WHERE (habilitado = 'Si') AND (stock <= stockmin) AND marca = " + marcaSeleccionada ;

            if (Datos_InformeArticulosAdapter.BuscarRegistrosReponer(sql))
            {
                System.IO.Directory.CreateDirectory("C:\\XML");
                string url = "C:\\XML\\informeArticulosReponerMarca.xml";

                Datos_InformeArticulosAdapter.tablaArticulos.WriteXml(url, XmlWriteMode.WriteSchema);

            }


            Artículos.frmInformeReposicionPorMarca formInformeArtiRepoMarca = new frmInformeReposicionPorMarca(marca);
            formInformeArtiRepoMarca.ShowDialog();
            System.IO.File.Delete("C:\\XML\\informeArticulosReponerMarca.xml");

        }


        //EVENTO LOAD - Carga marcas en combobox
        private void frmInformeReposicionSeleccionarMarca_Load(object sender, EventArgs e)
        {
            cbxSeleccionarMarca.DataSource = Datos_ProveedorAdapter.GetListadoNombres();
            cbxSeleccionarMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxSeleccionarMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxSeleccionarMarca.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCrearInforme_Click(object sender, EventArgs e)
        {
            informeStockCriticoPorMarca(cbxSeleccionarMarca.SelectedValue.ToString());
        }


    }
}
