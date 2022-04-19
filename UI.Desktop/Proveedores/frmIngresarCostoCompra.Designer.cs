namespace UI.Desktop.Proveedores
{
    partial class frmIngresarCostoCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresarCostoCompra));
            this.gbDatosArti = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescri = new System.Windows.Forms.TextBox();
            this.gbProveedor = new System.Windows.Forms.GroupBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtCostoCompra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbDatosArti.SuspendLayout();
            this.gbProveedor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosArti
            // 
            this.gbDatosArti.Controls.Add(this.label1);
            this.gbDatosArti.Controls.Add(this.txtCodigo);
            this.gbDatosArti.Controls.Add(this.txtDescri);
            this.gbDatosArti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosArti.Location = new System.Drawing.Point(12, 80);
            this.gbDatosArti.Name = "gbDatosArti";
            this.gbDatosArti.Size = new System.Drawing.Size(417, 94);
            this.gbDatosArti.TabIndex = 0;
            this.gbDatosArti.TabStop = false;
            this.gbDatosArti.Text = "Datos del Artículo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCodigo.Location = new System.Drawing.Point(156, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(168, 26);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescri
            // 
            this.txtDescri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescri.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDescri.Location = new System.Drawing.Point(6, 58);
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.ReadOnly = true;
            this.txtDescri.Size = new System.Drawing.Size(405, 26);
            this.txtDescri.TabIndex = 0;
            this.txtDescri.TabStop = false;
            this.txtDescri.Text = "Descripcion del artículo ";
            // 
            // gbProveedor
            // 
            this.gbProveedor.Controls.Add(this.txtProveedor);
            this.gbProveedor.Location = new System.Drawing.Point(12, 12);
            this.gbProveedor.Name = "gbProveedor";
            this.gbProveedor.Size = new System.Drawing.Size(417, 62);
            this.gbProveedor.TabIndex = 1;
            this.gbProveedor.TabStop = false;
            this.gbProveedor.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtProveedor.Location = new System.Drawing.Point(6, 19);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(405, 31);
            this.txtProveedor.TabIndex = 0;
            this.txtProveedor.TabStop = false;
            this.txtProveedor.Text = "Frank Sinatra";
            this.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCostoCompra
            // 
            this.txtCostoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoCompra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCostoCompra.Location = new System.Drawing.Point(38, 16);
            this.txtCostoCompra.MaxLength = 6;
            this.txtCostoCompra.Name = "txtCostoCompra";
            this.txtCostoCompra.Size = new System.Drawing.Size(72, 21);
            this.txtCostoCompra.TabIndex = 0;
            this.txtCostoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCostoCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoCompra_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCostoCompra);
            this.groupBox1.Location = new System.Drawing.Point(150, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Costo de Compra";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(118, 244);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 36);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(224, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 36);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmIngresarCostoCompra
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 292);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbProveedor);
            this.Controls.Add(this.gbDatosArti);
            this.Name = "frmIngresarCostoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese costo de compra";
            this.gbDatosArti.ResumeLayout(false);
            this.gbDatosArti.PerformLayout();
            this.gbProveedor.ResumeLayout(false);
            this.gbProveedor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosArti;
        private System.Windows.Forms.GroupBox gbProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtDescri;
        public System.Windows.Forms.TextBox txtProveedor;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtCostoCompra;
    }
}