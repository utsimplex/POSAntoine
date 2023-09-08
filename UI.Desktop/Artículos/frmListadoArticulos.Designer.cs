namespace UI.Desktop.Artículos
{
    partial class frmListadoArticulos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoArticulos));
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbxFiltroProveedor = new System.Windows.Forms.ComboBox();
            this.cbxFiltroFamilia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(130, 18);
            this.tbxFiltro.Size = new System.Drawing.Size(380, 20);
            this.tbxFiltro.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbxFiltro, "Ingrese código o descripción para filtrar");
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxFiltroFamilia);
            this.groupBox2.Controls.Add(this.cbxFiltroProveedor);
            this.groupBox2.Controls.Add(this.btnMostrarTodos);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSeleccionar);
            this.groupBox2.Size = new System.Drawing.Size(1223, 46);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.Text = "Búsqueda";
            this.groupBox2.Controls.SetChildIndex(this.tbxFiltro, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnSeleccionar, 0);
            this.groupBox2.Controls.SetChildIndex(this.label1, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnMostrarTodos, 0);
            this.groupBox2.Controls.SetChildIndex(this.cbxFiltroProveedor, 0);
            this.groupBox2.Controls.SetChildIndex(this.cbxFiltroFamilia, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1045, 52);
            this.groupBox1.Size = new System.Drawing.Size(183, 477);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(16, 316);
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar el artículo seleccionado.");
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(16, 81);
            this.btnModificar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnModificar, "Modifica datos del artículo.");
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(16, 264);
            this.toolTip1.SetToolTip(this.btnImportar, "Añade artículos a la grilla, desde un archivo de Excel.");
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(16, 411);
            this.btnSalir.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSalir, "Cerrar esta ventana.");
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(16, 212);
            this.toolTip1.SetToolTip(this.btnExportar, "Crea un archivo de Excel con todos los artículos de la grilla.");
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnAñadirNuevo
            // 
            this.btnAñadirNuevo.Location = new System.Drawing.Point(16, 29);
            this.btnAñadirNuevo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnAñadirNuevo, "Añade artículo nuevo a la grilla.");
            this.btnAñadirNuevo.Click += new System.EventHandler(this.btnAñadirNuevo_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.Location = new System.Drawing.Point(516, 12);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(136, 30);
            this.btnSeleccionar.TabIndex = 28;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnSeleccionar, "Añadir artículo a la venta actual.");
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Visible = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // cbxFiltroProveedor
            // 
            this.cbxFiltroProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroProveedor.FormattingEnabled = true;
            this.cbxFiltroProveedor.Location = new System.Drawing.Point(675, 18);
            this.cbxFiltroProveedor.Name = "cbxFiltroProveedor";
            this.cbxFiltroProveedor.Size = new System.Drawing.Size(189, 21);
            this.cbxFiltroProveedor.TabIndex = 30;
            this.toolTip1.SetToolTip(this.cbxFiltroProveedor, "Proveedor a Filtrar");
            // 
            // cbxFiltroFamilia
            // 
            this.cbxFiltroFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroFamilia.FormattingEnabled = true;
            this.cbxFiltroFamilia.Location = new System.Drawing.Point(870, 18);
            this.cbxFiltroFamilia.Name = "cbxFiltroFamilia";
            this.cbxFiltroFamilia.Size = new System.Drawing.Size(194, 21);
            this.cbxFiltroFamilia.TabIndex = 31;
            this.toolTip1.SetToolTip(this.cbxFiltroFamilia, "Familia a Filtrar");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Código ó Descripción ";
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(1081, 12);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(136, 30);
            this.btnMostrarTodos.TabIndex = 2;
            this.btnMostrarTodos.Text = "Quitar Filtro";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // frmListadoArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 543);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoArticulos";
            this.Text = "Lista de Artículos";
            this.Load += new System.EventHandler(this.frmListadoArticulos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.ComboBox cbxFiltroFamilia;
        private System.Windows.Forms.ComboBox cbxFiltroProveedor;
    }
}