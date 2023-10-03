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
            this.cbxFamilia2 = new System.Windows.Forms.ComboBox();
            this.cbxFamilia1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblFamilia1Nombre = new System.Windows.Forms.Label();
            this.lblFamilia2Nombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoArtiProveedor = new System.Windows.Forms.TextBox();
            this.lblNoHayProveedores = new System.Windows.Forms.Label();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificarStock = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDescri = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbDatosArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbDatosArticulo
            // 
            this.gbDatosArticulo.Controls.Add(this.cbxFamilia2);
            this.gbDatosArticulo.Controls.Add(this.cbxFamilia1);
            this.gbDatosArticulo.Controls.Add(this.label7);
            this.gbDatosArticulo.Controls.Add(this.txtCosto);
            this.gbDatosArticulo.Controls.Add(this.lblFamilia1Nombre);
            this.gbDatosArticulo.Controls.Add(this.lblFamilia2Nombre);
            this.gbDatosArticulo.Controls.Add(this.label4);
            this.gbDatosArticulo.Controls.Add(this.txtCodigoArtiProveedor);
            this.gbDatosArticulo.Controls.Add(this.lblNoHayProveedores);
            this.gbDatosArticulo.Controls.Add(this.cbxProveedor);
            this.gbDatosArticulo.Controls.Add(this.label3);
            this.gbDatosArticulo.Controls.Add(this.btnGuardar);
            this.gbDatosArticulo.Controls.Add(this.btnModificarStock);
            this.gbDatosArticulo.Controls.Add(this.btnCancelar);
            this.gbDatosArticulo.Controls.Add(this.label2);
            this.gbDatosArticulo.Controls.Add(this.label1);
            this.gbDatosArticulo.Controls.Add(this.lblStock);
            this.gbDatosArticulo.Controls.Add(this.lblDescri);
            this.gbDatosArticulo.Controls.Add(this.lblCodigo);
            this.gbDatosArticulo.Controls.Add(this.txtPrecio);
            this.gbDatosArticulo.Controls.Add(this.txtStockMin);
            this.gbDatosArticulo.Controls.Add(this.txtStock);
            this.gbDatosArticulo.Controls.Add(this.txtCodigo);
            this.gbDatosArticulo.Controls.Add(this.txtDescripcion);
            this.gbDatosArticulo.Controls.Add(this.pictureBox1);
            this.gbDatosArticulo.Location = new System.Drawing.Point(12, 12);
            this.gbDatosArticulo.Name = "gbDatosArticulo";
            this.gbDatosArticulo.Size = new System.Drawing.Size(448, 352);
            this.gbDatosArticulo.TabIndex = 1;
            this.gbDatosArticulo.TabStop = false;
            this.gbDatosArticulo.Text = "groupBox1";
            // 
            // cbxFamilia2
            // 
            this.cbxFamilia2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFamilia2.FormattingEnabled = true;
            this.cbxFamilia2.Location = new System.Drawing.Point(238, 179);
            this.cbxFamilia2.Name = "cbxFamilia2";
            this.cbxFamilia2.Size = new System.Drawing.Size(155, 21);
            this.cbxFamilia2.TabIndex = 57;
            // 
            // cbxFamilia1
            // 
            this.cbxFamilia1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFamilia1.FormattingEnabled = true;
            this.cbxFamilia1.Location = new System.Drawing.Point(238, 152);
            this.cbxFamilia1.Name = "cbxFamilia1";
            this.cbxFamilia1.Size = new System.Drawing.Size(155, 21);
            this.cbxFamilia1.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(238, 104);
            this.txtCosto.MaxLength = 22;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(155, 20);
            this.txtCosto.TabIndex = 54;
            // 
            // lblFamilia1Nombre
            // 
            this.lblFamilia1Nombre.AutoSize = true;
            this.lblFamilia1Nombre.Location = new System.Drawing.Point(149, 160);
            this.lblFamilia1Nombre.Name = "lblFamilia1Nombre";
            this.lblFamilia1Nombre.Size = new System.Drawing.Size(82, 13);
            this.lblFamilia1Nombre.TabIndex = 53;
            this.lblFamilia1Nombre.Text = "Familia1Nombre";
            // 
            // lblFamilia2Nombre
            // 
            this.lblFamilia2Nombre.AutoSize = true;
            this.lblFamilia2Nombre.Location = new System.Drawing.Point(150, 183);
            this.lblFamilia2Nombre.Name = "lblFamilia2Nombre";
            this.lblFamilia2Nombre.Size = new System.Drawing.Size(82, 13);
            this.lblFamilia2Nombre.TabIndex = 51;
            this.lblFamilia2Nombre.Text = "Familia2Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Código proveedor";
            // 
            // txtCodigoArtiProveedor
            // 
            this.txtCodigoArtiProveedor.Location = new System.Drawing.Point(238, 78);
            this.txtCodigoArtiProveedor.MaxLength = 22;
            this.txtCodigoArtiProveedor.Name = "txtCodigoArtiProveedor";
            this.txtCodigoArtiProveedor.Size = new System.Drawing.Size(155, 20);
            this.txtCodigoArtiProveedor.TabIndex = 48;
            // 
            // lblNoHayProveedores
            // 
            this.lblNoHayProveedores.AutoSize = true;
            this.lblNoHayProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoHayProveedores.Location = new System.Drawing.Point(287, 59);
            this.lblNoHayProveedores.Name = "lblNoHayProveedores";
            this.lblNoHayProveedores.Size = new System.Drawing.Size(181, 13);
            this.lblNoHayProveedores.TabIndex = 47;
            this.lblNoHayProveedores.Text = "No hay proveedores cargados.";
            this.lblNoHayProveedores.Visible = false;
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(238, 51);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(155, 21);
            this.cbxProveedor.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Proveedor";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(94, 309);
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
            this.btnModificarStock.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarStock.Image")));
            this.btnModificarStock.Location = new System.Drawing.Point(9, 230);
            this.btnModificarStock.Name = "btnModificarStock";
            this.btnModificarStock.Size = new System.Drawing.Size(31, 28);
            this.btnModificarStock.TabIndex = 43;
            this.btnModificarStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarStock.UseVisualStyleBackColor = true;
            this.btnModificarStock.Click += new System.EventHandler(this.btnModificarStock_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(224, 309);
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
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Stock Mínimo";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(40, 238);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 39;
            this.lblStock.Text = "Stock";
            // 
            // lblDescri
            // 
            this.lblDescri.AutoSize = true;
            this.lblDescri.Location = new System.Drawing.Point(169, 210);
            this.lblDescri.Name = "lblDescri";
            this.lblDescri.Size = new System.Drawing.Size(63, 13);
            this.lblDescri.TabIndex = 38;
            this.lblDescri.Text = "Descripción";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(192, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 37;
            this.lblCodigo.Text = "Código";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(81, 209);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(57, 20);
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // txtStockMin
            // 
            this.txtStockMin.Location = new System.Drawing.Point(81, 261);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(57, 20);
            this.txtStockMin.TabIndex = 4;
            this.txtStockMin.Text = "1";
            this.txtStockMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockMin_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(81, 235);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(57, 20);
            this.txtStock.TabIndex = 3;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(238, 26);
            this.txtCodigo.MaxLength = 22;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(155, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(238, 207);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 74);
            this.txtDescripcion.TabIndex = 1;
            // 
            // frmArticuloABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 376);
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
            this.gbDatosArticulo.PerformLayout();
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
        private System.Windows.Forms.Label lblNoHayProveedores;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblFamilia1Nombre;
        private System.Windows.Forms.Label lblFamilia2Nombre;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCodigoArtiProveedor;
        private System.Windows.Forms.ComboBox cbxFamilia1;
        private System.Windows.Forms.ComboBox cbxFamilia2;
    }
}