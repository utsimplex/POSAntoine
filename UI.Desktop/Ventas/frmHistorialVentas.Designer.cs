namespace UI.Desktop.Ventas
{
    partial class frmHistorialVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialVentas));
            this.btnVerComprobante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltroFecha = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnModificarComprobante = new System.Windows.Forms.Button();
            this.btnBuscarPorCliente = new System.Windows.Forms.Button();
            this.chbxSoloCajaAbierta = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(208, 19);
            this.tbxFiltro.Size = new System.Drawing.Size(207, 20);
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbxSoloCajaAbierta);
            this.groupBox2.Controls.Add(this.btnMostrarTodos);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Size = new System.Drawing.Size(835, 46);
            this.groupBox2.Text = "Búsqueda";
            this.groupBox2.Controls.SetChildIndex(this.tbxFiltro, 0);
            this.groupBox2.Controls.SetChildIndex(this.label1, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnMostrarTodos, 0);
            this.groupBox2.Controls.SetChildIndex(this.chbxSoloCajaAbierta, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarPorCliente);
            this.groupBox1.Controls.Add(this.btnModificarComprobante);
            this.groupBox1.Controls.Add(this.btnFiltroFecha);
            this.groupBox1.Controls.Add(this.btnVerComprobante);
            this.groupBox1.Location = new System.Drawing.Point(846, 12);
            this.groupBox1.Controls.SetChildIndex(this.btnAñadirNuevo, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnVerComprobante, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnModificar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnSalir, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnImportar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnExportar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnEliminar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnFiltroFecha, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnModificarComprobante, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnBuscarPorCliente, 0);
            // 
            // btnSalir
            // 
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVerComprobante
            // 
            this.btnVerComprobante.Image = global::UI.Desktop.Properties.Resources.document_32;
            this.btnVerComprobante.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerComprobante.Location = new System.Drawing.Point(16, 19);
            this.btnVerComprobante.Name = "btnVerComprobante";
            this.btnVerComprobante.Size = new System.Drawing.Size(150, 46);
            this.btnVerComprobante.TabIndex = 28;
            this.btnVerComprobante.Text = "Ver Comprobante";
            this.btnVerComprobante.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVerComprobante.UseVisualStyleBackColor = true;
            this.btnVerComprobante.Click += new System.EventHandler(this.btnVerComprobante_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Por Cliente, Vendedor ó NRO. de Venta";
            // 
            // btnFiltroFecha
            // 
            this.btnFiltroFecha.Image = global::UI.Desktop.Properties.Resources.Search_32x32;
            this.btnFiltroFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltroFecha.Location = new System.Drawing.Point(16, 123);
            this.btnFiltroFecha.Name = "btnFiltroFecha";
            this.btnFiltroFecha.Size = new System.Drawing.Size(150, 46);
            this.btnFiltroFecha.TabIndex = 29;
            this.btnFiltroFecha.Text = "Buscar por Fecha";
            this.btnFiltroFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFiltroFecha.UseVisualStyleBackColor = true;
            this.btnFiltroFecha.Click += new System.EventHandler(this.btnFiltroFechaDesde_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(425, 12);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(136, 30);
            this.btnMostrarTodos.TabIndex = 31;
            this.btnMostrarTodos.Text = "Quitar Filtro";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnModificarComprobante
            // 
            this.btnModificarComprobante.Image = global::UI.Desktop.Properties.Resources.Refresh_32x32;
            this.btnModificarComprobante.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarComprobante.Location = new System.Drawing.Point(16, 71);
            this.btnModificarComprobante.Name = "btnModificarComprobante";
            this.btnModificarComprobante.Size = new System.Drawing.Size(150, 46);
            this.btnModificarComprobante.TabIndex = 30;
            this.btnModificarComprobante.Text = "Realizar devolución";
            this.btnModificarComprobante.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnModificarComprobante.UseVisualStyleBackColor = true;
            this.btnModificarComprobante.Visible = false;
            this.btnModificarComprobante.Click += new System.EventHandler(this.btnModificarComprobante_Click);
            // 
            // btnBuscarPorCliente
            // 
            this.btnBuscarPorCliente.Image = global::UI.Desktop.Properties.Resources.User_24x24;
            this.btnBuscarPorCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPorCliente.Location = new System.Drawing.Point(16, 175);
            this.btnBuscarPorCliente.Name = "btnBuscarPorCliente";
            this.btnBuscarPorCliente.Size = new System.Drawing.Size(150, 46);
            this.btnBuscarPorCliente.TabIndex = 31;
            this.btnBuscarPorCliente.Text = "Buscar por Cliente";
            this.btnBuscarPorCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarPorCliente.UseVisualStyleBackColor = true;
            this.btnBuscarPorCliente.Click += new System.EventHandler(this.btnBuscarPorCliente_Click);
            // 
            // chbxSoloCajaAbierta
            // 
            this.chbxSoloCajaAbierta.AutoSize = true;
            this.chbxSoloCajaAbierta.Checked = true;
            this.chbxSoloCajaAbierta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxSoloCajaAbierta.Location = new System.Drawing.Point(728, 21);
            this.chbxSoloCajaAbierta.Name = "chbxSoloCajaAbierta";
            this.chbxSoloCajaAbierta.Size = new System.Drawing.Size(101, 17);
            this.chbxSoloCajaAbierta.TabIndex = 32;
            this.chbxSoloCajaAbierta.Text = "Sólo ultima Caja";
            this.chbxSoloCajaAbierta.UseVisualStyleBackColor = true;
            this.chbxSoloCajaAbierta.CheckedChanged += new System.EventHandler(this.chbxSoloCajaAbierta_CheckedChanged);
            // 
            // frmHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 495);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorialVentas";
            this.Text = "Historial de Ventas";
            this.Load += new System.EventHandler(this.frmHistorialVentas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerComprobante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltroFecha;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnModificarComprobante;
        private System.Windows.Forms.Button btnBuscarPorCliente;
        private System.Windows.Forms.CheckBox chbxSoloCajaAbierta;
    }
}