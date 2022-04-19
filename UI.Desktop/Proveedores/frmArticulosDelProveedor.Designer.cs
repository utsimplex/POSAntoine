namespace UI.Desktop.Proveedores
{
    partial class frmArticulosDelProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulosDelProveedor));
            this.dgvTodosArti = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQuitarFiltro1 = new System.Windows.Forms.Button();
            this.txtFiltroArticulos = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvArticulosProveedor = new System.Windows.Forms.DataGridView();
            this.btnAñadirArtiAlProv = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosArti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTodosArti
            // 
            this.dgvTodosArti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodosArti.Location = new System.Drawing.Point(15, 70);
            this.dgvTodosArti.Name = "dgvTodosArti";
            this.dgvTodosArti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodosArti.Size = new System.Drawing.Size(384, 361);
            this.dgvTodosArti.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dgvTodosArti);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 447);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Todos los artículos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQuitarFiltro1);
            this.groupBox3.Controls.Add(this.txtFiltroArticulos);
            this.groupBox3.Location = new System.Drawing.Point(15, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 45);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Búsqueda";
            // 
            // btnQuitarFiltro1
            // 
            this.btnQuitarFiltro1.Location = new System.Drawing.Point(247, 14);
            this.btnQuitarFiltro1.Name = "btnQuitarFiltro1";
            this.btnQuitarFiltro1.Size = new System.Drawing.Size(130, 26);
            this.btnQuitarFiltro1.TabIndex = 1;
            this.btnQuitarFiltro1.Text = "Quitar Filtro";
            this.btnQuitarFiltro1.UseVisualStyleBackColor = true;
            this.btnQuitarFiltro1.Click += new System.EventHandler(this.btnQuitarFiltro1_Click);
            // 
            // txtFiltroArticulos
            // 
            this.txtFiltroArticulos.Location = new System.Drawing.Point(9, 18);
            this.txtFiltroArticulos.Name = "txtFiltroArticulos";
            this.txtFiltroArticulos.Size = new System.Drawing.Size(232, 20);
            this.txtFiltroArticulos.TabIndex = 0;
            this.txtFiltroArticulos.TextChanged += new System.EventHandler(this.txtFiltroArticulos_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvArticulosProveedor);
            this.groupBox2.Location = new System.Drawing.Point(484, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 369);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artículo del Proveedor";
            // 
            // dgvArticulosProveedor
            // 
            this.dgvArticulosProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosProveedor.Location = new System.Drawing.Point(27, 19);
            this.dgvArticulosProveedor.Name = "dgvArticulosProveedor";
            this.dgvArticulosProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulosProveedor.Size = new System.Drawing.Size(445, 349);
            this.dgvArticulosProveedor.TabIndex = 1;
            // 
            // btnAñadirArtiAlProv
            // 
            this.btnAñadirArtiAlProv.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadirArtiAlProv.Image")));
            this.btnAñadirArtiAlProv.Location = new System.Drawing.Point(433, 163);
            this.btnAñadirArtiAlProv.Name = "btnAñadirArtiAlProv";
            this.btnAñadirArtiAlProv.Size = new System.Drawing.Size(45, 58);
            this.btnAñadirArtiAlProv.TabIndex = 3;
            this.btnAñadirArtiAlProv.Text = "Añadir";
            this.btnAñadirArtiAlProv.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAñadirArtiAlProv.UseVisualStyleBackColor = true;
            this.btnAñadirArtiAlProv.Click += new System.EventHandler(this.btnAñadirArtiAlProv_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(433, 250);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(45, 58);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(759, 406);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 37);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(629, 406);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 37);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmArticulosDelProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 471);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAñadirArtiAlProv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArticulosDelProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículos  del Proveedor";
            this.Load += new System.EventHandler(this.frmArticulosDelProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosArti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTodosArti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAñadirArtiAlProv;
        private System.Windows.Forms.Button btnQuitar;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.DataGridView dgvArticulosProveedor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFiltroArticulos;
        private System.Windows.Forms.Button btnQuitarFiltro1;
    }
}