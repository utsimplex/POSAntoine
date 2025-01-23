namespace UI.Desktop.Ventas
{
    partial class frmBuscarPorFecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarPorFecha));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pBuscarPorCliente = new System.Windows.Forms.TabPage();
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFiltroCliente = new System.Windows.Forms.TextBox();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.pFechaEntre = new System.Windows.Forms.TabPage();
            this.btnConfirmarDesdeHasta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDHDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpDHHasta = new System.Windows.Forms.DateTimePicker();
            this.pFechaDesde = new System.Windows.Forms.TabPage();
            this.btnConfirmarFechaDesde = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.tcPestañas = new System.Windows.Forms.TabControl();
            this.tabArticulos = new System.Windows.Forms.TabPage();
            this.btnSeleccionarArticulo = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtFiltroArticulo = new System.Windows.Forms.TextBox();
            this.dgvListaArticulos = new System.Windows.Forms.DataGridView();
            this.pBuscarPorCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.pFechaEntre.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pFechaDesde.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tcPestañas.SuspendLayout();
            this.tabArticulos.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 19);
            this.dateTimePicker1.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.Image = global::UI.Desktop.Properties.Resources.close_24;
            this.btnCancelar.Location = new System.Drawing.Point(136, 215);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 36);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pBuscarPorCliente
            // 
            this.pBuscarPorCliente.BackColor = System.Drawing.SystemColors.Control;
            this.pBuscarPorCliente.Controls.Add(this.btnSeleccionarCliente);
            this.pBuscarPorCliente.Controls.Add(this.groupBox4);
            this.pBuscarPorCliente.Controls.Add(this.dgvListaClientes);
            this.pBuscarPorCliente.Location = new System.Drawing.Point(4, 22);
            this.pBuscarPorCliente.Name = "pBuscarPorCliente";
            this.pBuscarPorCliente.Padding = new System.Windows.Forms.Padding(3);
            this.pBuscarPorCliente.Size = new System.Drawing.Size(357, 175);
            this.pBuscarPorCliente.TabIndex = 2;
            this.pBuscarPorCliente.Text = "Por Cliente";
            this.pBuscarPorCliente.Enter += new System.EventHandler(this.pBuscarPorCliente_Enter);
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.AllowUserToAddRows = false;
            this.dgvListaClientes.AllowUserToDeleteRows = false;
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaClientes.Location = new System.Drawing.Point(6, 6);
            this.dgvListaClientes.MultiSelect = false;
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.ReadOnly = true;
            this.dgvListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaClientes.Size = new System.Drawing.Size(345, 114);
            this.dgvListaClientes.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFiltroCliente);
            this.groupBox4.Location = new System.Drawing.Point(6, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 43);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ingrese DNI, Apellido ó Nombre";
            // 
            // txtFiltroCliente
            // 
            this.txtFiltroCliente.Location = new System.Drawing.Point(6, 17);
            this.txtFiltroCliente.Name = "txtFiltroCliente";
            this.txtFiltroCliente.Size = new System.Drawing.Size(194, 20);
            this.txtFiltroCliente.TabIndex = 2;
            this.txtFiltroCliente.TextChanged += new System.EventHandler(this.txtFiltroCliente_TextChanged);
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSeleccionarCliente.Image = global::UI.Desktop.Properties.Resources.forward24;
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(233, 133);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(118, 36);
            this.btnSeleccionarCliente.TabIndex = 5;
            this.btnSeleccionarCliente.Text = "Seleccionar";
            this.btnSeleccionarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // pFechaEntre
            // 
            this.pFechaEntre.BackColor = System.Drawing.SystemColors.Control;
            this.pFechaEntre.Controls.Add(this.groupBox3);
            this.pFechaEntre.Controls.Add(this.groupBox2);
            this.pFechaEntre.Controls.Add(this.btnConfirmarDesdeHasta);
            this.pFechaEntre.Location = new System.Drawing.Point(4, 22);
            this.pFechaEntre.Name = "pFechaEntre";
            this.pFechaEntre.Padding = new System.Windows.Forms.Padding(3);
            this.pFechaEntre.Size = new System.Drawing.Size(357, 175);
            this.pFechaEntre.TabIndex = 1;
            this.pFechaEntre.Text = "Desde - Hasta";
            // 
            // btnConfirmarDesdeHasta
            // 
            this.btnConfirmarDesdeHasta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmarDesdeHasta.Image = global::UI.Desktop.Properties.Resources.Search_24x24;
            this.btnConfirmarDesdeHasta.Location = new System.Drawing.Point(233, 133);
            this.btnConfirmarDesdeHasta.Name = "btnConfirmarDesdeHasta";
            this.btnConfirmarDesdeHasta.Size = new System.Drawing.Size(118, 36);
            this.btnConfirmarDesdeHasta.TabIndex = 4;
            this.btnConfirmarDesdeHasta.Text = "Buscar";
            this.btnConfirmarDesdeHasta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfirmarDesdeHasta.UseVisualStyleBackColor = true;
            this.btnConfirmarDesdeHasta.Click += new System.EventHandler(this.btnConfirmarDesdeHasta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDHDesde);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 55);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desde";
            // 
            // dtpDHDesde
            // 
            this.dtpDHDesde.Location = new System.Drawing.Point(12, 19);
            this.dtpDHDesde.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtpDHDesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDHDesde.Name = "dtpDHDesde";
            this.dtpDHDesde.Size = new System.Drawing.Size(268, 20);
            this.dtpDHDesde.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpDHHasta);
            this.groupBox3.Location = new System.Drawing.Point(6, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 55);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hasta";
            // 
            // dtpDHHasta
            // 
            this.dtpDHHasta.Location = new System.Drawing.Point(12, 19);
            this.dtpDHHasta.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtpDHHasta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpDHHasta.Name = "dtpDHHasta";
            this.dtpDHHasta.Size = new System.Drawing.Size(268, 20);
            this.dtpDHHasta.TabIndex = 0;
            // 
            // pFechaDesde
            // 
            this.pFechaDesde.BackColor = System.Drawing.SystemColors.Control;
            this.pFechaDesde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pFechaDesde.Controls.Add(this.groupBox1);
            this.pFechaDesde.Controls.Add(this.btnConfirmarFechaDesde);
            this.pFechaDesde.Location = new System.Drawing.Point(4, 22);
            this.pFechaDesde.Name = "pFechaDesde";
            this.pFechaDesde.Padding = new System.Windows.Forms.Padding(3);
            this.pFechaDesde.Size = new System.Drawing.Size(357, 175);
            this.pFechaDesde.TabIndex = 0;
            this.pFechaDesde.Text = "Fecha Desde";
            // 
            // btnConfirmarFechaDesde
            // 
            this.btnConfirmarFechaDesde.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmarFechaDesde.Image = global::UI.Desktop.Properties.Resources.Search_24x24;
            this.btnConfirmarFechaDesde.Location = new System.Drawing.Point(233, 133);
            this.btnConfirmarFechaDesde.Name = "btnConfirmarFechaDesde";
            this.btnConfirmarFechaDesde.Size = new System.Drawing.Size(118, 36);
            this.btnConfirmarFechaDesde.TabIndex = 1;
            this.btnConfirmarFechaDesde.Text = "Buscar";
            this.btnConfirmarFechaDesde.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfirmarFechaDesde.UseVisualStyleBackColor = true;
            this.btnConfirmarFechaDesde.Click += new System.EventHandler(this.btnConfirmarFechaDesde_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Location = new System.Drawing.Point(32, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 55);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(12, 19);
            this.dtpFechaDesde.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtpFechaDesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(268, 20);
            this.dtpFechaDesde.TabIndex = 0;
            // 
            // tcPestañas
            // 
            this.tcPestañas.Controls.Add(this.pFechaDesde);
            this.tcPestañas.Controls.Add(this.pFechaEntre);
            this.tcPestañas.Controls.Add(this.tabArticulos);
            this.tcPestañas.Controls.Add(this.pBuscarPorCliente);
            this.tcPestañas.Location = new System.Drawing.Point(14, 12);
            this.tcPestañas.Name = "tcPestañas";
            this.tcPestañas.SelectedIndex = 0;
            this.tcPestañas.Size = new System.Drawing.Size(365, 201);
            this.tcPestañas.TabIndex = 3;
            // 
            // tabArticulos
            // 
            this.tabArticulos.BackColor = System.Drawing.SystemColors.Control;
            this.tabArticulos.Controls.Add(this.btnSeleccionarArticulo);
            this.tabArticulos.Controls.Add(this.groupBox5);
            this.tabArticulos.Controls.Add(this.dgvListaArticulos);
            this.tabArticulos.Location = new System.Drawing.Point(4, 22);
            this.tabArticulos.Name = "tabArticulos";
            this.tabArticulos.Padding = new System.Windows.Forms.Padding(3);
            this.tabArticulos.Size = new System.Drawing.Size(357, 175);
            this.tabArticulos.TabIndex = 3;
            this.tabArticulos.Text = "Por Articulo";
            this.tabArticulos.Enter += new System.EventHandler(this.tabArticulos_Enter);
            // 
            // btnSeleccionarArticulo
            // 
            this.btnSeleccionarArticulo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSeleccionarArticulo.Image = global::UI.Desktop.Properties.Resources.forward24;
            this.btnSeleccionarArticulo.Location = new System.Drawing.Point(233, 133);
            this.btnSeleccionarArticulo.Name = "btnSeleccionarArticulo";
            this.btnSeleccionarArticulo.Size = new System.Drawing.Size(118, 36);
            this.btnSeleccionarArticulo.TabIndex = 5;
            this.btnSeleccionarArticulo.Text = "Seleccionar";
            this.btnSeleccionarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSeleccionarArticulo.UseVisualStyleBackColor = true;
            this.btnSeleccionarArticulo.Click += new System.EventHandler(this.btnSeleccionarArticulo_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtFiltroArticulo);
            this.groupBox5.Location = new System.Drawing.Point(6, 126);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(219, 43);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ingrese Código ó Descripción";
            // 
            // txtFiltroArticulo
            // 
            this.txtFiltroArticulo.Location = new System.Drawing.Point(6, 17);
            this.txtFiltroArticulo.Name = "txtFiltroArticulo";
            this.txtFiltroArticulo.Size = new System.Drawing.Size(194, 20);
            this.txtFiltroArticulo.TabIndex = 2;
            this.txtFiltroArticulo.TextChanged += new System.EventHandler(this.txtFiltroArticulo_TextChanged);
            // 
            // dgvListaArticulos
            // 
            this.dgvListaArticulos.AllowUserToAddRows = false;
            this.dgvListaArticulos.AllowUserToDeleteRows = false;
            this.dgvListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaArticulos.Location = new System.Drawing.Point(6, 6);
            this.dgvListaArticulos.MultiSelect = false;
            this.dgvListaArticulos.Name = "dgvListaArticulos";
            this.dgvListaArticulos.ReadOnly = true;
            this.dgvListaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaArticulos.Size = new System.Drawing.Size(345, 114);
            this.dgvListaArticulos.TabIndex = 0;
            // 
            // frmBuscarPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(391, 258);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tcPestañas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarPorFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Ventas - Búsqueda";
            this.pBuscarPorCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pFechaEntre.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.pFechaDesde.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tcPestañas.ResumeLayout(false);
            this.tabArticulos.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TabPage pBuscarPorCliente;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtFiltroCliente;
        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.TabPage pFechaEntre;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DateTimePicker dtpDHHasta;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DateTimePicker dtpDHDesde;
        private System.Windows.Forms.Button btnConfirmarDesdeHasta;
        private System.Windows.Forms.TabPage pFechaDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnConfirmarFechaDesde;
        public System.Windows.Forms.TabControl tcPestañas;
        public System.Windows.Forms.TabPage tabArticulos;
        private System.Windows.Forms.Button btnSeleccionarArticulo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtFiltroArticulo;
        private System.Windows.Forms.DataGridView dgvListaArticulos;
    }
}