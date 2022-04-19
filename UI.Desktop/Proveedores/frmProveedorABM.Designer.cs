namespace UI.Desktop.Proveedores
{
    partial class frmProveedorABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedorABM));
            this.dgvArticulosProveedor = new System.Windows.Forms.DataGridView();
            this.gbProvArti = new System.Windows.Forms.GroupBox();
            this.btnModifCosto = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosProveedor)).BeginInit();
            this.gbProvArti.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.gbProvArti);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Size = new System.Drawing.Size(724, 197);
            this.groupBox1.Controls.SetChildIndex(this.txtDireccion, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtEmail, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtNroDoc, 0);
            this.groupBox1.Controls.SetChildIndex(this.label5, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtNombre, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtTelefono, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.Controls.SetChildIndex(this.label3, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnCancelar, 0);
            this.groupBox1.Controls.SetChildIndex(this.label6, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnGuardar, 0);
            this.groupBox1.Controls.SetChildIndex(this.pictureBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtApellido, 0);
            this.groupBox1.Controls.SetChildIndex(this.gbProvArti, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 39);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(551, 102);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(551, 76);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(273, 102);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Size = new System.Drawing.Size(218, 20);
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(273, 76);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 53);
            this.label1.Size = new System.Drawing.Size(50, 13);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Location = new System.Drawing.Point(168, 76);
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.Text = "Documento / CUIT";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(496, 76);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(273, 50);
            this.txtNombre.MaxLength = 99;
            this.txtNombre.Size = new System.Drawing.Size(218, 20);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(69, 13);
            this.txtApellido.Size = new System.Drawing.Size(93, 20);
            this.txtApellido.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.Location = new System.Drawing.Point(461, 139);
            this.btnGuardar.Size = new System.Drawing.Size(124, 41);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Location = new System.Drawing.Point(591, 139);
            this.btnCancelar.Size = new System.Drawing.Size(124, 41);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(215, 102);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Location = new System.Drawing.Point(510, 102);
            // 
            // dgvArticulosProveedor
            // 
            this.dgvArticulosProveedor.AllowUserToAddRows = false;
            this.dgvArticulosProveedor.AllowUserToDeleteRows = false;
            this.dgvArticulosProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosProveedor.Location = new System.Drawing.Point(102, 19);
            this.dgvArticulosProveedor.Name = "dgvArticulosProveedor";
            this.dgvArticulosProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulosProveedor.Size = new System.Drawing.Size(594, 141);
            this.dgvArticulosProveedor.TabIndex = 34;
            // 
            // gbProvArti
            // 
            this.gbProvArti.Controls.Add(this.btnModifCosto);
            this.gbProvArti.Controls.Add(this.btnQuitar);
            this.gbProvArti.Controls.Add(this.btnAdd);
            this.gbProvArti.Controls.Add(this.dgvArticulosProveedor);
            this.gbProvArti.Location = new System.Drawing.Point(10, 192);
            this.gbProvArti.Name = "gbProvArti";
            this.gbProvArti.Size = new System.Drawing.Size(705, 172);
            this.gbProvArti.TabIndex = 35;
            this.gbProvArti.TabStop = false;
            this.gbProvArti.Text = "Artículos del Proveedor";
            // 
            // btnModifCosto
            // 
            this.btnModifCosto.Image = ((System.Drawing.Image)(resources.GetObject("btnModifCosto.Image")));
            this.btnModifCosto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifCosto.Location = new System.Drawing.Point(6, 122);
            this.btnModifCosto.Name = "btnModifCosto";
            this.btnModifCosto.Size = new System.Drawing.Size(90, 38);
            this.btnModifCosto.TabIndex = 37;
            this.btnModifCosto.Text = "Modificar Costo";
            this.btnModifCosto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifCosto.UseVisualStyleBackColor = true;
            this.btnModifCosto.Click += new System.EventHandler(this.btnModifCosto_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(6, 54);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(90, 28);
            this.btnQuitar.TabIndex = 36;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(31, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 32);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmProveedorABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 218);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProveedorABM";
            this.Text = "frmProveedorABM";
            this.Load += new System.EventHandler(this.frmProveedorABM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosProveedor)).EndInit();
            this.gbProvArti.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProvArti;
        protected System.Windows.Forms.Button btnQuitar;
        protected System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.DataGridView dgvArticulosProveedor;
        protected System.Windows.Forms.Button btnModifCosto;

    }
}