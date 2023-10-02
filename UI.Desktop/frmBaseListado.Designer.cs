namespace UI.Desktop
{
    partial class frmBaseListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseListado));
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnAñadirNuevo = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToOrderColumns = true;
            this.dgvListado.AllowUserToResizeRows = false;
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListado.Location = new System.Drawing.Point(7, 52);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowHeadersVisible = false;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(555, 429);
            this.dgvListado.TabIndex = 0;
            this.dgvListado.TabStop = false;
            this.dgvListado.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListado_CellFormatting);
            this.dgvListado.DoubleClick += new System.EventHandler(this.dgvListado_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.btnAñadirNuevo);
            this.groupBox1.Controls.Add(this.btnImportar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Location = new System.Drawing.Point(573, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 457);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(16, 71);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 46);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(16, 306);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 46);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.Location = new System.Drawing.Point(16, 202);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(150, 46);
            this.btnExportar.TabIndex = 26;
            this.btnExportar.Text = "Exportar a Excel";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnAñadirNuevo
            // 
            this.btnAñadirNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAñadirNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadirNuevo.Image")));
            this.btnAñadirNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirNuevo.Location = new System.Drawing.Point(16, 19);
            this.btnAñadirNuevo.Name = "btnAñadirNuevo";
            this.btnAñadirNuevo.Size = new System.Drawing.Size(150, 46);
            this.btnAñadirNuevo.TabIndex = 19;
            this.btnAñadirNuevo.Text = "Añadir Nuevo";
            this.btnAñadirNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirNuevo.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportar.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.Image")));
            this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportar.Location = new System.Drawing.Point(16, 254);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(150, 46);
            this.btnImportar.TabIndex = 25;
            this.btnImportar.Text = "Importar desde Excel";
            this.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(16, 401);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 46);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tbxFiltro);
            this.groupBox2.Location = new System.Drawing.Point(5, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 46);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILTRAR";
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(8, 18);
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(524, 20);
            this.tbxFiltro.TabIndex = 0;
            // 
            // frmBaseListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(764, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaseListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaseListado";
            this.Load += new System.EventHandler(this.frmBaseListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

      
        public System.Windows.Forms.TextBox tbxFiltro;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnImportar;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnExportar;
        public System.Windows.Forms.Button btnAñadirNuevo;
        public System.Windows.Forms.DataGridView dgvListado;
    }
}