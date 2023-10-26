namespace UI.Desktop.Artículos
{
    partial class frmArticuloABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticuloABM));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbDatosArticulo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbxFamilia1 = new System.Windows.Forms.ComboBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtCodigoArtiProveedor = new System.Windows.Forms.TextBox();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFamilia1Nombre = new System.Windows.Forms.Label();
            this.lblFamilia2Nombre = new System.Windows.Forms.Label();
            this.lblDescri = new System.Windows.Forms.Label();
            this.cbxFamilia2 = new System.Windows.Forms.ComboBox();
            this.txtCampoPersonalizado2 = new System.Windows.Forms.TextBox();
            this.txtCampoPersonalizado1 = new System.Windows.Forms.TextBox();
            this.lblCampoPersonalizado1 = new System.Windows.Forms.Label();
            this.lblCampoPersonalizado2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificarStock = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbDatosArticulo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 4);
            this.pictureBox1.Size = new System.Drawing.Size(125, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbDatosArticulo
            // 
            this.gbDatosArticulo.Controls.Add(this.tableLayoutPanel1);
            this.gbDatosArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatosArticulo.Location = new System.Drawing.Point(0, 0);
            this.gbDatosArticulo.Name = "gbDatosArticulo";
            this.gbDatosArticulo.Size = new System.Drawing.Size(517, 443);
            this.gbDatosArticulo.TabIndex = 1;
            this.gbDatosArticulo.TabStop = false;
            this.gbDatosArticulo.Text = "groupBox1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.63399F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.36601F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigo, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCodigo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxFamilia2, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblFamilia2Nombre, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbxFamilia1, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFamilia1Nombre, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtCosto, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigoArtiProveedor, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxProveedor, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigoBarras, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCampoPersonalizado2, 4, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblCampoPersonalizado2, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtCampoPersonalizado1, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblCampoPersonalizado1, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblDescri, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPrecio, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblStock, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtStock, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnModificarStock, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtStockMin, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnGuardar, 4, 11);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 0, 11);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 418);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescripcion.Location = new System.Drawing.Point(331, 234);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.tableLayoutPanel1.SetRowSpan(this.txtDescripcion, 2);
            this.txtDescripcion.Size = new System.Drawing.Size(155, 60);
            this.txtDescripcion.TabIndex = 1;
            // 
            // cbxFamilia1
            // 
            this.cbxFamilia1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxFamilia1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFamilia1.FormattingEnabled = true;
            this.cbxFamilia1.Location = new System.Drawing.Point(331, 171);
            this.cbxFamilia1.Name = "cbxFamilia1";
            this.cbxFamilia1.Size = new System.Drawing.Size(155, 21);
            this.cbxFamilia1.TabIndex = 56;
            // 
            // txtCosto
            // 
            this.txtCosto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCosto.Location = new System.Drawing.Point(331, 138);
            this.txtCosto.MaxLength = 22;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(155, 20);
            this.txtCosto.TabIndex = 54;
            // 
            // txtCodigoArtiProveedor
            // 
            this.txtCodigoArtiProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigoArtiProveedor.Location = new System.Drawing.Point(331, 105);
            this.txtCodigoArtiProveedor.MaxLength = 22;
            this.txtCodigoArtiProveedor.Name = "txtCodigoArtiProveedor";
            this.txtCodigoArtiProveedor.Size = new System.Drawing.Size(155, 20);
            this.txtCodigoArtiProveedor.TabIndex = 48;
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(331, 72);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(155, 21);
            this.cbxProveedor.TabIndex = 46;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigo.Location = new System.Drawing.Point(331, 6);
            this.txtCodigo.MaxLength = 22;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(155, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(285, 10);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 37;
            this.lblCodigo.Text = "Código";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Proveedor";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Código proveedor";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Costo";
            // 
            // lblFamilia1Nombre
            // 
            this.lblFamilia1Nombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFamilia1Nombre.Location = new System.Drawing.Point(206, 175);
            this.lblFamilia1Nombre.Name = "lblFamilia1Nombre";
            this.lblFamilia1Nombre.Size = new System.Drawing.Size(119, 13);
            this.lblFamilia1Nombre.TabIndex = 53;
            this.lblFamilia1Nombre.Text = "Familia1Nombre";
            this.lblFamilia1Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFamilia2Nombre
            // 
            this.lblFamilia2Nombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFamilia2Nombre.Location = new System.Drawing.Point(206, 208);
            this.lblFamilia2Nombre.Name = "lblFamilia2Nombre";
            this.lblFamilia2Nombre.Size = new System.Drawing.Size(119, 13);
            this.lblFamilia2Nombre.TabIndex = 51;
            this.lblFamilia2Nombre.Text = "Familia2Nombre";
            this.lblFamilia2Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescri
            // 
            this.lblDescri.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescri.AutoSize = true;
            this.lblDescri.Location = new System.Drawing.Point(262, 241);
            this.lblDescri.Name = "lblDescri";
            this.lblDescri.Size = new System.Drawing.Size(63, 13);
            this.lblDescri.TabIndex = 38;
            this.lblDescri.Text = "Descripción";
            // 
            // cbxFamilia2
            // 
            this.cbxFamilia2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxFamilia2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFamilia2.FormattingEnabled = true;
            this.cbxFamilia2.Location = new System.Drawing.Point(331, 204);
            this.cbxFamilia2.Name = "cbxFamilia2";
            this.cbxFamilia2.Size = new System.Drawing.Size(155, 21);
            this.cbxFamilia2.TabIndex = 57;
            // 
            // txtCampoPersonalizado2
            // 
            this.txtCampoPersonalizado2.Location = new System.Drawing.Point(331, 333);
            this.txtCampoPersonalizado2.MaxLength = 22;
            this.txtCampoPersonalizado2.Name = "txtCampoPersonalizado2";
            this.txtCampoPersonalizado2.Size = new System.Drawing.Size(155, 20);
            this.txtCampoPersonalizado2.TabIndex = 61;
            // 
            // txtCampoPersonalizado1
            // 
            this.txtCampoPersonalizado1.Location = new System.Drawing.Point(331, 300);
            this.txtCampoPersonalizado1.MaxLength = 22;
            this.txtCampoPersonalizado1.Name = "txtCampoPersonalizado1";
            this.txtCampoPersonalizado1.Size = new System.Drawing.Size(155, 20);
            this.txtCampoPersonalizado1.TabIndex = 60;
            // 
            // lblCampoPersonalizado1
            // 
            this.lblCampoPersonalizado1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCampoPersonalizado1.Location = new System.Drawing.Point(204, 307);
            this.lblCampoPersonalizado1.Name = "lblCampoPersonalizado1";
            this.lblCampoPersonalizado1.Size = new System.Drawing.Size(121, 13);
            this.lblCampoPersonalizado1.TabIndex = 59;
            this.lblCampoPersonalizado1.Text = "Campo Personalizado 1";
            this.lblCampoPersonalizado1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCampoPersonalizado2
            // 
            this.lblCampoPersonalizado2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCampoPersonalizado2.Location = new System.Drawing.Point(204, 340);
            this.lblCampoPersonalizado2.Name = "lblCampoPersonalizado2";
            this.lblCampoPersonalizado2.Size = new System.Drawing.Size(121, 13);
            this.lblCampoPersonalizado2.TabIndex = 58;
            this.lblCampoPersonalizado2.Text = "Campo Personalizado 2";
            this.lblCampoPersonalizado2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(376, 372);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 37);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificarStock
            // 
            this.btnModificarStock.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificarStock.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarStock.Image")));
            this.btnModificarStock.Location = new System.Drawing.Point(144, 168);
            this.btnModificarStock.Name = "btnModificarStock";
            this.btnModificarStock.Size = new System.Drawing.Size(31, 27);
            this.btnModificarStock.TabIndex = 43;
            this.btnModificarStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarStock.UseVisualStyleBackColor = true;
            this.btnModificarStock.Click += new System.EventHandler(this.btnModificarStock_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.SetColumnSpan(this.btnCancelar, 2);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(14, 372);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 37);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 26);
            this.label1.TabIndex = 40;
            this.label1.Text = "Stock Mínimo";
            // 
            // lblStock
            // 
            this.lblStock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(35, 175);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 39;
            this.lblStock.Text = "Stock";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPrecio.Location = new System.Drawing.Point(76, 138);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(62, 20);
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // txtStockMin
            // 
            this.txtStockMin.Location = new System.Drawing.Point(76, 201);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(62, 20);
            this.txtStockMin.TabIndex = 4;
            this.txtStockMin.Text = "1";
            this.txtStockMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockMin_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(76, 168);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(62, 20);
            this.txtStock.TabIndex = 3;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Código de barras";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigoBarras.Location = new System.Drawing.Point(331, 39);
            this.txtCodigoBarras.MaxLength = 22;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(155, 20);
            this.txtCodigoBarras.TabIndex = 63;
            // 
            // frmArticuloABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 443);
            this.Controls.Add(this.gbDatosArticulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArticuloABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArticuloABM";
            this.Load += new System.EventHandler(this.frmArticuloABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbDatosArticulo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbDatosArticulo;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtStockMin;
        public System.Windows.Forms.TextBox txtStock;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificarStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblFamilia1Nombre;
        private System.Windows.Forms.Label lblFamilia2Nombre;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCodigoArtiProveedor;
        private System.Windows.Forms.ComboBox cbxFamilia1;
        private System.Windows.Forms.ComboBox cbxFamilia2;
        public System.Windows.Forms.TextBox txtCampoPersonalizado2;
        public System.Windows.Forms.TextBox txtCampoPersonalizado1;
        private System.Windows.Forms.Label lblCampoPersonalizado1;
        private System.Windows.Forms.Label lblCampoPersonalizado2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCodigoBarras;
    }
}