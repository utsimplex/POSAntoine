namespace UI.Desktop.Descuentos
{
    partial class frmDescuentoABM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescuentoABM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDatosArticulo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtDispositivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbxDias = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chkbxLunes = new System.Windows.Forms.CheckBox();
            this.chkbxMiercoles = new System.Windows.Forms.CheckBox();
            this.chkbxMartes = new System.Windows.Forms.CheckBox();
            this.chkbxJueves = new System.Windows.Forms.CheckBox();
            this.chkbxViernes = new System.Windows.Forms.CheckBox();
            this.chkbxSabado = new System.Windows.Forms.CheckBox();
            this.chkbxDomingo = new System.Windows.Forms.CheckBox();
            this.dgvFechas = new System.Windows.Forms.DataGridView();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.cbxMedioPago = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDatosArticulo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbxDias.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosArticulo
            // 
            this.gbDatosArticulo.Controls.Add(this.tableLayoutPanel1);
            this.gbDatosArticulo.Location = new System.Drawing.Point(12, 12);
            this.gbDatosArticulo.Name = "gbDatosArticulo";
            this.gbDatosArticulo.Size = new System.Drawing.Size(517, 471);
            this.gbDatosArticulo.TabIndex = 2;
            this.gbDatosArticulo.TabStop = false;
            this.gbDatosArticulo.Text = "Descuento";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.63399F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.36601F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.Controls.Add(this.btnGuardar, 4, 12);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCodigo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtId, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.gpbxDias, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dgvFechas, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.datePicker, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnAgregar, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDispositivo, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDescuento, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbxMedioPago, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.chbActivo, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 444);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtId.Location = new System.Drawing.Point(211, 6);
            this.txtId.MaxLength = 22;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(155, 20);
            this.txtId.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(165, 10);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 37;
            this.lblCodigo.Text = "Código";
            // 
            // txtDispositivo
            // 
            this.txtDispositivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDispositivo.Location = new System.Drawing.Point(211, 105);
            this.txtDispositivo.MaxLength = 22;
            this.txtDispositivo.Name = "txtDispositivo";
            this.txtDispositivo.Size = new System.Drawing.Size(155, 20);
            this.txtDispositivo.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Dispositivo";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescripcion, 2);
            this.txtDescripcion.Location = new System.Drawing.Point(211, 39);
            this.txtDescripcion.MaxLength = 22;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(289, 20);
            this.txtDescripcion.TabIndex = 63;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(384, 401);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 37);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.SetColumnSpan(this.btnCancelar, 2);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(3, 401);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 37);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chbActivo
            // 
            this.chbActivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chbActivo.AutoSize = true;
            this.chbActivo.Checked = true;
            this.chbActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel1.SetColumnSpan(this.chbActivo, 2);
            this.chbActivo.Location = new System.Drawing.Point(3, 107);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(56, 17);
            this.chbActivo.TabIndex = 65;
            this.chbActivo.Text = "Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Image = global::UI.Desktop.Properties.Resources.percent48;
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gpbxDias
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gpbxDias, 4);
            this.gpbxDias.Controls.Add(this.tableLayoutPanel2);
            this.gpbxDias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbxDias.Location = new System.Drawing.Point(56, 168);
            this.gpbxDias.Name = "gpbxDias";
            this.tableLayoutPanel1.SetRowSpan(this.gpbxDias, 3);
            this.gpbxDias.Size = new System.Drawing.Size(444, 93);
            this.gpbxDias.TabIndex = 66;
            this.gpbxDias.TabStop = false;
            this.gpbxDias.Text = "Dias de la Semana";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.Controls.Add(this.chkbxDomingo, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkbxSabado, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkbxViernes, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkbxJueves, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkbxMiercoles, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkbxMartes, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkbxLunes, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(438, 74);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // chkbxLunes
            // 
            this.chkbxLunes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbxLunes.AutoSize = true;
            this.chkbxLunes.Location = new System.Drawing.Point(13, 12);
            this.chkbxLunes.Name = "chkbxLunes";
            this.chkbxLunes.Size = new System.Drawing.Size(98, 17);
            this.chkbxLunes.TabIndex = 0;
            this.chkbxLunes.Text = "Lunes";
            this.chkbxLunes.UseVisualStyleBackColor = true;
            // 
            // chkbxMiercoles
            // 
            this.chkbxMiercoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbxMiercoles.AutoSize = true;
            this.chkbxMiercoles.Location = new System.Drawing.Point(221, 12);
            this.chkbxMiercoles.Name = "chkbxMiercoles";
            this.chkbxMiercoles.Size = new System.Drawing.Size(98, 17);
            this.chkbxMiercoles.TabIndex = 1;
            this.chkbxMiercoles.Text = "Miercoles";
            this.chkbxMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkbxMartes
            // 
            this.chkbxMartes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbxMartes.AutoSize = true;
            this.chkbxMartes.Location = new System.Drawing.Point(117, 12);
            this.chkbxMartes.Name = "chkbxMartes";
            this.chkbxMartes.Size = new System.Drawing.Size(98, 17);
            this.chkbxMartes.TabIndex = 2;
            this.chkbxMartes.Text = "Martes";
            this.chkbxMartes.UseVisualStyleBackColor = true;
            // 
            // chkbxJueves
            // 
            this.chkbxJueves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbxJueves.AutoSize = true;
            this.chkbxJueves.Location = new System.Drawing.Point(325, 12);
            this.chkbxJueves.Name = "chkbxJueves";
            this.chkbxJueves.Size = new System.Drawing.Size(98, 17);
            this.chkbxJueves.TabIndex = 3;
            this.chkbxJueves.Text = "Jueves";
            this.chkbxJueves.UseVisualStyleBackColor = true;
            // 
            // chkbxViernes
            // 
            this.chkbxViernes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbxViernes.AutoSize = true;
            this.chkbxViernes.Location = new System.Drawing.Point(13, 44);
            this.chkbxViernes.Name = "chkbxViernes";
            this.chkbxViernes.Size = new System.Drawing.Size(98, 17);
            this.chkbxViernes.TabIndex = 4;
            this.chkbxViernes.Text = "Viernes";
            this.chkbxViernes.UseVisualStyleBackColor = true;
            // 
            // chkbxSabado
            // 
            this.chkbxSabado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbxSabado.AutoSize = true;
            this.chkbxSabado.Location = new System.Drawing.Point(117, 44);
            this.chkbxSabado.Name = "chkbxSabado";
            this.chkbxSabado.Size = new System.Drawing.Size(98, 17);
            this.chkbxSabado.TabIndex = 5;
            this.chkbxSabado.Text = "Sabado";
            this.chkbxSabado.UseVisualStyleBackColor = true;
            // 
            // chkbxDomingo
            // 
            this.chkbxDomingo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbxDomingo.AutoSize = true;
            this.chkbxDomingo.Location = new System.Drawing.Point(221, 44);
            this.chkbxDomingo.Name = "chkbxDomingo";
            this.chkbxDomingo.Size = new System.Drawing.Size(98, 17);
            this.chkbxDomingo.TabIndex = 6;
            this.chkbxDomingo.Text = "Domingo";
            this.chkbxDomingo.UseVisualStyleBackColor = true;
            // 
            // dgvFechas
            // 
            this.dgvFechas.AllowUserToAddRows = false;
            this.dgvFechas.AllowUserToDeleteRows = false;
            this.dgvFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFechas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvFechas, 2);
            this.dgvFechas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFechas.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvFechas.Location = new System.Drawing.Point(211, 267);
            this.dgvFechas.Name = "dgvFechas";
            this.dgvFechas.ReadOnly = true;
            this.dgvFechas.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dgvFechas, 4);
            this.dgvFechas.Size = new System.Drawing.Size(289, 126);
            this.dgvFechas.TabIndex = 67;
            // 
            // datePicker
            // 
            this.datePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.datePicker, 2);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(56, 303);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(149, 20);
            this.datePicker.TabIndex = 68;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Location = new System.Drawing.Point(108, 335);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 23);
            this.btnAgregar.TabIndex = 69;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Fecha
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Descuento (%)";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescuento.Location = new System.Drawing.Point(211, 72);
            this.txtDescuento.MaxLength = 22;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(155, 20);
            this.txtDescuento.TabIndex = 71;
            // 
            // cbxMedioPago
            // 
            this.cbxMedioPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedioPago.FormattingEnabled = true;
            this.cbxMedioPago.Location = new System.Drawing.Point(211, 138);
            this.cbxMedioPago.Name = "cbxMedioPago";
            this.cbxMedioPago.Size = new System.Drawing.Size(167, 21);
            this.cbxMedioPago.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Medio de Pago";
            // 
            // frmDescuentoABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 487);
            this.Controls.Add(this.gbDatosArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDescuentoABM";
            this.Text = "ABM Descuentos";
            this.gbDatosArticulo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbxDias.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFechas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosArticulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.TextBox txtDispositivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDescripcion;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbxDias;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox chkbxDomingo;
        private System.Windows.Forms.CheckBox chkbxSabado;
        private System.Windows.Forms.CheckBox chkbxViernes;
        private System.Windows.Forms.CheckBox chkbxJueves;
        private System.Windows.Forms.CheckBox chkbxMiercoles;
        private System.Windows.Forms.CheckBox chkbxMartes;
        private System.Windows.Forms.CheckBox chkbxLunes;
        private System.Windows.Forms.DataGridView dgvFechas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.ComboBox cbxMedioPago;
        private System.Windows.Forms.Label label2;
    }
}