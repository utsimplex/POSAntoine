using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Database;
using Entidades;
using UI.Desktop.Parametros.Articulos;

namespace UI.Desktop.Parametros
{
    public partial class frmParametros : Form
    {
        #region ///***///***///***/// V A R I A B L E S \\\***\\\***\\\***\\\


        ParametrosEmpresa parametrosEmpresa;
        ParametrosEmpresaController parametrosEmpresaController;

        #endregion
        public frmParametros()
        {
            InitializeComponent();
            parametrosEmpresaController = ParametrosEmpresaController.GetInstance();
            parametrosEmpresa = parametrosEmpresaController.ObtenerParametrosEmpresa();
            ParametrosAControles();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void completaImpresoras()
        {
            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                this.cbxImpresoras.Items.Add(pkInstalledPrinters);
                if (parametrosEmpresa.Impresora1 == pkInstalledPrinters)
                {
                    this.cbxImpresoras.SelectedIndex = i;
                }
            }
        }
        private void completaSituacionFiscal()
        {
            cbxSituacionFiscal.Items.Clear();

            //cbxSituacionFiscal.DataSource = Enum.GetNames(typeof(SituacionFiscal));
            //cbxSituacionFiscal.DisplayMember = "description";
            //cbxSituacionFiscal.ValueMember = "value";
            cbxSituacionFiscal.DisplayMember = "Description";
            cbxSituacionFiscal.ValueMember = "Value";
            cbxSituacionFiscal.DataSource = Enum.GetValues(typeof(FeConstantes.SituacionFiscal))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            cbxSituacionFiscal.SelectedValue =  (FeConstantes.SituacionFiscal)Convert.ToInt32(parametrosEmpresa.SituacionFiscal);
            //String pkInstalledPrinters;
            //for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            //{
            //    pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
            //    this.cbxSituacionFiscal.Items.Add(pkInstalledPrinters);
            //    if (parametrosEmpresa.Impresora1 == pkInstalledPrinters)
            //    {
            //        this.cbxSituacionFiscal.SelectedIndex = i;
            //    }
            //}
        }
        private void ParametrosAControles()
        {
            this.tbxClaveCertificado.Text = parametrosEmpresa.ClaveCertificado;
            this.tbxCuit.Text = parametrosEmpresa.CUIT;
            this.tbxDireccion.Text = parametrosEmpresa.Direccion;
            this.tbxDireccionFiscal.Text = parametrosEmpresa.DireccionFiscal;
            this.tbxImagePath.Text = parametrosEmpresa.ImagenPath;
            this.tbxIngresosBrutos.Text = parametrosEmpresa.IngresosBrutos;
            this.tbxInicioActividades.Text = parametrosEmpresa.InicioDeActividades;
            this.tbxNombre.Text = parametrosEmpresa.Nombre;
            this.tbxNombreFiscal.Text = parametrosEmpresa.NombreFiscal;
            this.tbxPathCertificado.Text = parametrosEmpresa.CertificadoDigital;
            this.tbxPuntoDeVenta.Text = parametrosEmpresa.PuntoDeVenta;
            this.tbxTelefono.Text = parametrosEmpresa.Telefono;
            this.tbxURLAfip.Text = parametrosEmpresa.UrlQrAfip;
            this.chkbxProduccion.Checked = parametrosEmpresa.EsProduccion;

            //this.cbxImpresoras.SelectedText = "";
            this.completaImpresoras();
            //this.cbxSituacionFiscal.SelectedText = "";
            this.completaSituacionFiscal();

            //Campos Personalizados Articulo
            this.txtCampoPersonalizadoArticulo1.Text = parametrosEmpresa.CampoPersonalizadoArticulo1;
            this.txtCampoPersonalizadoArticulo2.Text = parametrosEmpresa.CampoPersonalizadoArticulo2;

            //Familias artículos
            this.txtFamilia1Titulo.Text = parametrosEmpresa.FamiliaNombre1;
            this.txtFamilia2Titulo.Text = parametrosEmpresa.FamiliaNombre2;
        }
        private void ControlesAParametro()
        {
            parametrosEmpresa = new ParametrosEmpresa();
            parametrosEmpresa.ClaveCertificado = this.tbxClaveCertificado.Text;
            parametrosEmpresa.CUIT = this.tbxCuit.Text;
            parametrosEmpresa.Direccion = this.tbxDireccion.Text;
            parametrosEmpresa.DireccionFiscal = this.tbxDireccionFiscal.Text;
            parametrosEmpresa.ImagenPath = this.tbxImagePath.Text;
            parametrosEmpresa.IngresosBrutos = this.tbxIngresosBrutos.Text;
            parametrosEmpresa.InicioDeActividades = this.tbxInicioActividades.Text;
            parametrosEmpresa.Nombre = this.tbxNombre.Text;
            parametrosEmpresa.NombreFiscal = this.tbxNombreFiscal.Text;
            parametrosEmpresa.CertificadoDigital = this.tbxPathCertificado.Text;
            parametrosEmpresa.PuntoDeVenta = this.tbxPuntoDeVenta.Text;
            parametrosEmpresa.Telefono = this.tbxTelefono.Text;
            parametrosEmpresa.UrlQrAfip = this.tbxURLAfip.Text;
            parametrosEmpresa.EsProduccion = this.chkbxProduccion.Checked;
            parametrosEmpresa.Impresora1 = this.cbxImpresoras.SelectedItem.ToString();
            parametrosEmpresa.SituacionFiscal = Convert.ToInt32(cbxSituacionFiscal.SelectedValue).ToString();
            //parametrosEmpresa.SituacionFiscal = this.cbxSituacionFiscal.SelectedValue.ToString();

            //Campos Personalizados Articulo
            parametrosEmpresa.CampoPersonalizadoArticulo1 = this.txtCampoPersonalizadoArticulo1.Text.ToString();
            parametrosEmpresa.CampoPersonalizadoArticulo2 = this.txtCampoPersonalizadoArticulo2.Text.ToString();

            //Familias Artículos
            parametrosEmpresa.FamiliaNombre1 = this.txtFamilia1Titulo.Text.ToString();
            parametrosEmpresa.FamiliaNombre2 = this.txtFamilia2Titulo.Text.ToString();
            ////Campos Personalizados Cliente
            //parametrosEmpresa.CampoPersonalizadoCliente1 = this.txtCampoPersonalizadoCliente1.Text.ToString();
            //parametrosEmpresa.CampoPersonalizadoCliente2 = this.txtCampoPersonalizadoCliente2.Text.ToString();

            ////Campos Personalizados Proveedor
            //parametrosEmpresa.CampoPersonalizadoProveedor1= this.txtCampoPersonalizadoProveedor1.Text.ToString();
            //parametrosEmpresa.CampoPersonalizadoProveedor2 = this.txtCampoPersonalizadoProveedor2.Text.ToString();

        }
        private void Guardar()
        {
            this.ControlesAParametro();
            this.parametrosEmpresaController.Actualizar(parametrosEmpresa);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Guardar();
            this.Close();
        }

        private void btnBuscaImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImagenDialog = new OpenFileDialog();
            ImagenDialog.Filter = "PNG files(*.png)| *.png| JPG files(*.jpg)| *.jpg| JPEG files(*.jpeg)| *.jpeg";
            ImagenDialog.CheckFileExists = true;
            if (ImagenDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbxImagePath.Text = ImagenDialog.FileName;
            }
        }

        private void btnBuscaCertificado_Click(object sender, EventArgs e)
        {
            OpenFileDialog CertificadoDialog = new OpenFileDialog();
            CertificadoDialog.Filter = "Intercambio de información persona (*.p12)| *.p12| PFX Certificate files (*.pfx)| *.pfx";
            CertificadoDialog.CheckFileExists = true;
            if (CertificadoDialog.ShowDialog() == DialogResult.OK)
            {
                this.tbxPathCertificado.Text = CertificadoDialog.FileName;
            }
        }

        private void btnEditarFamilia1_Click(object sender, EventArgs e)
        {
            EditarFamiliaArticulos("Familia1");
        }

        private void btnEditarFamilia2_Click(object sender, EventArgs e)
        {
            EditarFamiliaArticulos("Familia2");
        }

        private void EditarFamiliaArticulos(string familiaSeleccionada)
        {
            frmListadoFamiliasABM formFamilia = new frmListadoFamiliasABM(familiaSeleccionada);
            if(formFamilia.ShowDialog() == DialogResult.OK)
            {
                if(familiaSeleccionada == "Familia1")
                {
                    this.txtFamilia1Titulo.Text = formFamilia.txtNombreFamilia.Text.Trim();
                    formFamilia.familiaListado.ForEach(familia =>
                    {
                        if (familia.IsModified)
                        {
                            // Actualizo esta familia
                            parametrosEmpresaController.ModificarFamilia(familia,"Familia1");
                        }

                        if(familia.id == null)
                        {
                            // Agrego Familia nueva
                            parametrosEmpresaController.AñadirFamilia(familia, "Familia1");
                        }

                    });
                    //LogicalToDeviceUnits para guardar familia1
                }
                if(familiaSeleccionada == "Familia2")
                {
                    this.txtFamilia2Titulo.Text = formFamilia.txtNombreFamilia.Text.Trim();
                    formFamilia.familiaListado.ForEach(familia =>
                    {
                        if (familia.IsModified)
                        {
                            // Actualizo esta familia
                            parametrosEmpresaController.ModificarFamilia(familia, "Familia2");
                        }

                        if (familia.id == null)
                        {
                            // Agrego Familia nueva
                            parametrosEmpresaController.AñadirFamilia(familia, "Familia2");
                        }

                    });
                }
                this.btnCancelar.Visible = false;
            }
        }
    }
}
