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
    public partial class frmDescuentoABM : Form
    {
        public frmDescuentoABM()
        {
            InitializeComponent();
            cargaMediosDePago();
            BindUiDescuentoNuevo();

        }

        //Constructor 2 (modo Modificacion)
        public frmDescuentoABM(Entidades.Descuento descuentoToEdit)
        {
            InitializeComponent();
            cargaMediosDePago();
            this.descuentoToEdit = descuentoToEdit;

            if (this.descuentoToEdit != null)
            {
                BindUiEditarDescuento();
            }

        }


        #region ///***///***///***/// V A R I A B L E S \\\***\\\***\\\***\\\

        MedioDePagoAdapter Datos_MedioDePagoAdapter = new MedioDePagoAdapter();
        DescuentoAdapter Datos_DescuentoAdapter = new DescuentoAdapter();
        Entidades.Descuento descuentoToEdit = new Entidades.Descuento();
        List<Entidades.MedioDePago> mediosDePago = new List<Entidades.MedioDePago>();

        #endregion



        #region ///***///***///***/// P R O P I E D A D E S \\\***\\\***\\\***\\\

        TipoForm _modoForm;
        public TipoForm ModoForm
        {
            get { return _modoForm; }
            set { _modoForm = value; }
        }


        #endregion



        #region ///***///***///***/// E N U M E R A D O R E S \\\***\\\***\\\***\\\


        public enum TipoForm
        {
            Alta,
            Edicion

        }

        #endregion




        #region ///***///***///***/// M E T O D O S \\\***\\\***\\\***\\\
        private void cargaMediosDePago()
        {
            cbxMedioPago.Items.Clear();
            mediosDePago = Datos_MedioDePagoAdapter.GetMultipleActivo("%").Where(x => x.Activo == true).OrderBy(x => x.Default).OrderBy(x => x.Descripcion).ToList();
            if (mediosDePago != null)
            {
                cbxMedioPago.DataSource = mediosDePago;
                cbxMedioPago.DisplayMember = "descripcion";
                cbxMedioPago.ValueMember = "id";
                cbxMedioPago.SelectedIndex = mediosDePago.FindIndex(x => x.Default == true);
            }
        }

        //***********************  G U A R D A R    *********************** \\
        public void Guardar()
        {
            Entidades.Descuento Descuento = new Entidades.Descuento();

            if (ModoForm == TipoForm.Alta)
            {
                // Valido Datos
                if (ValidarDescripcionDispositivo() && ValidarAplicaciones())
                {
                    try
                    {
                        // TXT to nuevoDescuento
                        Descuento.Descripcion = txtDescripcion.Text.Trim();
                        Descuento.Dispositivo = txtDispositivo.Text.Trim();
                        Descuento.MedioDePago = ((MedioDePago)cbxMedioPago.SelectedItem).Descripcion;

                        Descuento.PorcentajeDescuento = txtDescuento.Text!=""? Convert.ToDecimal(txtDescuento.Text.Trim()) : 0;
                        Descuento.Activa = chbActivo.Checked;
                        Descuento.AplicaLunes = chkbxLunes.Checked;
                        Descuento.AplicaMartes = chkbxMartes.Checked;
                        Descuento.AplicaMiercoles= chkbxMiercoles.Checked;
                        Descuento.AplicaJueves = chkbxJueves.Checked;
                        Descuento.AplicaViernes = chkbxViernes.Checked;
                        Descuento.AplicaSabado = chkbxSabado.Checked;
                        Descuento.AplicaDomingo = chkbxDomingo.Checked;
                        if (dgvFechas.Rows.Count > 0) {
                            Descuento.AplicaFechas = new List<DateTime>();
                        }
                        foreach(DataGridViewRow row in dgvFechas.Rows)
                        {
                            DateTime date = Convert.ToDateTime(row.Cells[0].Value);
                            Descuento.AplicaFechas.Add(date);
                        }
                        // nuevoDescuento to Base de Datos (capa de datos)
                        Datos_DescuentoAdapter.AñadirNuevo(Descuento);

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        // Muestro cualquier error de la aplicacion
                        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        // Libero objetos
                        Descuento = null;
                    }
                }//Fin try
            }//Fin Alta
            else if (ModoForm == TipoForm.Edicion)
            {
                try
                {

                    descuentoToEdit.Id = Convert.ToInt32(txtId.Text);
                    descuentoToEdit.Descripcion = txtDescripcion.Text;
                    descuentoToEdit.Dispositivo = txtDispositivo.Text.Trim();
                    descuentoToEdit.MedioDePago = ((MedioDePago)cbxMedioPago.SelectedItem).Descripcion;
                    descuentoToEdit.PorcentajeDescuento = Convert.ToDecimal(txtDescuento.Text.Trim());
                    descuentoToEdit.Activa = chbActivo.Checked;
                    descuentoToEdit.AplicaLunes = chkbxLunes.Checked;
                    descuentoToEdit.AplicaMartes = chkbxMartes.Checked;
                    descuentoToEdit.AplicaMiercoles = chkbxMiercoles.Checked;
                    descuentoToEdit.AplicaJueves = chkbxJueves.Checked;
                    descuentoToEdit.AplicaViernes = chkbxViernes.Checked;
                    descuentoToEdit.AplicaSabado = chkbxSabado.Checked;
                    descuentoToEdit.AplicaDomingo = chkbxDomingo.Checked;
                    descuentoToEdit.AplicaFechas = new List<DateTime>();
                    foreach (DataGridViewRow row in dgvFechas.Rows)
                    {
                        DateTime date = Convert.ToDateTime(row.Cells[0].Value);
                        descuentoToEdit.AplicaFechas.Add(date);
                    }
                    // nuevoDescuento to Base de Datos (capa de datos)

                    Datos_DescuentoAdapter.Actualizar(descuentoToEdit);

                    this.Close();
                }
                catch (Exception ex)
                {
                    // Muestro cualquier error de la aplicacion
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }





        }

        private void BindUiDescuentoNuevo()
        {
            this.Text = "Añadir nuevo Descuento";
        }

        private void BindUiEditarDescuento()
        {
            this.Text = "Modificar datos del Descuento";
            //this.txtId.ReadOnly = true;

            // Datos descuento
            txtId.Text = descuentoToEdit.Id.ToString();
            txtDescripcion.Text = descuentoToEdit.Descripcion;
            txtDispositivo.Text = descuentoToEdit.Dispositivo;
            txtDescuento.Text = Math.Round(Convert.ToDecimal(descuentoToEdit.PorcentajeDescuento), 2).ToString();
            cbxMedioPago.SelectedValue = mediosDePago.First(medioDePago => medioDePago.Descripcion == descuentoToEdit.MedioDePago.ToUpper()).id;
            chkbxLunes.Checked = descuentoToEdit.AplicaLunes == true;
            chkbxMartes.Checked = descuentoToEdit.AplicaMartes == true;
            chkbxMiercoles.Checked = descuentoToEdit.AplicaMiercoles == true;
            chkbxJueves.Checked = descuentoToEdit.AplicaJueves == true;
            chkbxViernes.Checked = descuentoToEdit.AplicaViernes == true;
            chkbxSabado.Checked = descuentoToEdit.AplicaSabado == true;
            chkbxDomingo.Checked = descuentoToEdit.AplicaDomingo == true;
            if (descuentoToEdit.AplicaFechas!=null)
            {
                foreach (DateTime date in descuentoToEdit.AplicaFechas)
                {
                    dgvFechas.Rows.Add(date.ToString("dd/MM/yyyy"));
                }
            }

        }


        //*********************** V A L I D A C I O N E S  *********************** \\
        bool ValidarDescripcionDispositivo()
        {
            string mensaje = "";

            //Validar descripcion del descuento
            if (txtDescripcion.Text.Trim() == "")
                mensaje += " La descripción no puede estar en blanco." + "\n";
            //Validar descripcion del descuento
            if (txtDispositivo.Text.Trim() == "")
                mensaje += " El Dispositivo no puede estar en blanco." + "\n";

            // Mostrar Errors
            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;


        }
        bool ValidarAplicaciones()
        {
            string mensaje = "";

            if (chkbxLunes.Checked == false && chkbxMartes.Checked == false && chkbxMiercoles.Checked == false && chkbxJueves.Checked == false && chkbxViernes.Checked == false 
                && chkbxSabado.Checked == false && chkbxDomingo.Checked == false && dgvFechas.Rows.Count==0)
            {
                mensaje += "Debes seleccionar fechas especificas o algun dia de la semana.";
            }

            // Mostrar Errors
            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;

        }
      

        #endregion

        #region ///***///***/// E V E N T O S \\\***\\\***\\\***\\\


        // CLICK GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }


        //CLICK CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        //SOLO PERMITE INGRESAR NUMEROS
        private static void SoloNumeros(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }
        //LOAD
        private void frmDescuentoABM_Load(object sender, EventArgs e)
        {

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = datePicker.Value;
            bool sePuedeAgregar = true;
            foreach(DataGridViewRow row in dgvFechas.Rows)
            {
                if (row.Cells[0].Value.ToString() == fechaSeleccionada.ToString("dd/MM/yyyy"))
                    sePuedeAgregar = false;

            }
            if(sePuedeAgregar)
                dgvFechas.Rows.Add(fechaSeleccionada.ToString("dd/MM/yyyy"));
            else
                MessageBox.Show("No puede agregar esta fecha", "Fecha existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
