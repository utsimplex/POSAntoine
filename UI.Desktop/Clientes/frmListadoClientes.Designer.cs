namespace UI.Desktop.Clientes
{
    partial class frmListadoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoClientes));
            this.btnSeleccionarCli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnCtaCte = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(168, 18);
            this.tbxFiltro.Size = new System.Drawing.Size(387, 20);
            this.tbxFiltro.TabIndex = 1;
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMostrarTodos);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 2);
            this.groupBox2.Size = new System.Drawing.Size(809, 46);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.Text = "Búsqueda";
            this.groupBox2.Controls.SetChildIndex(this.tbxFiltro, 0);
            this.groupBox2.Controls.SetChildIndex(this.label1, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnMostrarTodos, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCtaCte);
            this.groupBox1.Controls.Add(this.btnSeleccionarCli);
            this.groupBox1.Location = new System.Drawing.Point(822, 12);
            this.groupBox1.Size = new System.Drawing.Size(184, 469);
            this.groupBox1.Controls.SetChildIndex(this.btnSalir, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnExportar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnSeleccionarCli, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnImportar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnAñadirNuevo, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnEliminar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnModificar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnCtaCte, 0);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.Location = new System.Drawing.Point(11, 312);
            this.btnEliminar.Size = new System.Drawing.Size(162, 46);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.Location = new System.Drawing.Point(11, 77);
            this.btnModificar.Size = new System.Drawing.Size(162, 46);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImportar.Location = new System.Drawing.Point(11, 260);
            this.btnImportar.Size = new System.Drawing.Size(162, 46);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(11, 417);
            this.btnSalir.Size = new System.Drawing.Size(162, 46);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportar.Location = new System.Drawing.Point(11, 208);
            this.btnExportar.Size = new System.Drawing.Size(162, 46);
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnAñadirNuevo
            // 
            this.btnAñadirNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAñadirNuevo.Location = new System.Drawing.Point(11, 25);
            this.btnAñadirNuevo.Size = new System.Drawing.Size(162, 46);
            this.btnAñadirNuevo.TabIndex = 0;
            this.btnAñadirNuevo.Click += new System.EventHandler(this.btnAñadirNuevo_Click);
            // 
            // btnSeleccionarCli
            // 
            this.btnSeleccionarCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeleccionarCli.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSeleccionarCli.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarCli.Image")));
            this.btnSeleccionarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionarCli.Location = new System.Drawing.Point(11, 211);
            this.btnSeleccionarCli.Name = "btnSeleccionarCli";
            this.btnSeleccionarCli.Size = new System.Drawing.Size(162, 46);
            this.btnSeleccionarCli.TabIndex = 2;
            this.btnSeleccionarCli.Text = "Seleccionar";
            this.btnSeleccionarCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSeleccionarCli.UseVisualStyleBackColor = true;
            this.btnSeleccionarCli.Visible = false;
            this.btnSeleccionarCli.Click += new System.EventHandler(this.btnSeleccionarCli_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese DNI, Apellido ó Nombre";
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(561, 10);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(136, 30);
            this.btnMostrarTodos.TabIndex = 2;
            this.btnMostrarTodos.Text = "Quitar Filtro";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnCtaCte
            // 
            this.btnCtaCte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCtaCte.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnCtaCte.Image = global::UI.Desktop.Properties.Resources._3319635_income_payment_finance_money_profit;
            this.btnCtaCte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCtaCte.Location = new System.Drawing.Point(11, 129);
            this.btnCtaCte.Name = "btnCtaCte";
            this.btnCtaCte.Size = new System.Drawing.Size(162, 46);
            this.btnCtaCte.TabIndex = 27;
            this.btnCtaCte.Text = "Cuenta Corriente";
            this.btnCtaCte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCtaCte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCtaCte.UseVisualStyleBackColor = true;
            this.btnCtaCte.Click += new System.EventHandler(this.btnCtaCte_Click);
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.ClientSize = new System.Drawing.Size(1018, 495);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoClientes";
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnSeleccionarCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarTodos;
        public System.Windows.Forms.Button btnCtaCte;
    }
}