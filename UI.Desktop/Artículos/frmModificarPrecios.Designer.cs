namespace UI.Desktop.Artículos
{
    partial class frmModificarPrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarPrecios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxFiltroFamilia = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxFiltroProveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.rbMontoFijo = new System.Windows.Forms.RadioButton();
            this.rbPorcentaje = new System.Windows.Forms.RadioButton();
            this.lblResumen = new System.Windows.Forms.Label();
            this.rbReduccion = new System.Windows.Forms.RadioButton();
            this.rbAumento = new System.Windows.Forms.RadioButton();
            this.lblPaso3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtMontoPorcentaje = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActualizarPrecios = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(120, 15);
            this.tbxFiltro.Size = new System.Drawing.Size(187, 20);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnMostrarTodos);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(5, 2);
            this.groupBox2.Size = new System.Drawing.Size(885, 46);
            this.groupBox2.Text = "Búsqueda";
            this.groupBox2.Controls.SetChildIndex(this.panel1, 0);
            this.groupBox2.Controls.SetChildIndex(this.tbxFiltro, 0);
            this.groupBox2.Controls.SetChildIndex(this.label1, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnMostrarTodos, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.btnActualizarPrecios);
            this.groupBox1.Location = new System.Drawing.Point(978, 2);
            this.groupBox1.Size = new System.Drawing.Size(264, 470);
            this.groupBox1.Text = "Modificación de precios";
            this.groupBox1.Controls.SetChildIndex(this.btnSalir, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnImportar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnAñadirNuevo, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnExportar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnEliminar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnModificar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnActualizarPrecios, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel4, 0);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(16, 312);
            this.btnEliminar.Size = new System.Drawing.Size(23, 28);
            this.btnEliminar.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(16, 312);
            this.btnModificar.Size = new System.Drawing.Size(23, 25);
            this.btnModificar.Visible = false;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(16, 312);
            this.btnImportar.Size = new System.Drawing.Size(23, 28);
            this.btnImportar.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(6, 418);
            this.btnSalir.Size = new System.Drawing.Size(120, 46);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(16, 311);
            this.btnExportar.Size = new System.Drawing.Size(23, 29);
            this.btnExportar.Visible = false;
            // 
            // btnAñadirNuevo
            // 
            this.btnAñadirNuevo.Location = new System.Drawing.Point(16, 311);
            this.btnAñadirNuevo.Size = new System.Drawing.Size(23, 29);
            this.btnAñadirNuevo.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(312, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 30);
            this.panel1.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbxFiltroFamilia);
            this.panel3.Location = new System.Drawing.Point(210, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 27);
            this.panel3.TabIndex = 35;
            // 
            // cbxFiltroFamilia
            // 
            this.cbxFiltroFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroFamilia.FormattingEnabled = true;
            this.cbxFiltroFamilia.Location = new System.Drawing.Point(3, 3);
            this.cbxFiltroFamilia.Name = "cbxFiltroFamilia";
            this.cbxFiltroFamilia.Size = new System.Drawing.Size(194, 21);
            this.cbxFiltroFamilia.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxFiltroProveedor);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 27);
            this.panel2.TabIndex = 33;
            // 
            // cbxFiltroProveedor
            // 
            this.cbxFiltroProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroProveedor.FormattingEnabled = true;
            this.cbxFiltroProveedor.Location = new System.Drawing.Point(4, 3);
            this.cbxFiltroProveedor.Name = "cbxFiltroProveedor";
            this.cbxFiltroProveedor.Size = new System.Drawing.Size(189, 21);
            this.cbxFiltroProveedor.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Código ó Descripción ";
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarTodos.Location = new System.Drawing.Point(734, 9);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(136, 30);
            this.btnMostrarTodos.TabIndex = 35;
            this.btnMostrarTodos.Text = "Quitar Filtros";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // rbMontoFijo
            // 
            this.rbMontoFijo.AutoSize = true;
            this.rbMontoFijo.Location = new System.Drawing.Point(18, 47);
            this.rbMontoFijo.Name = "rbMontoFijo";
            this.rbMontoFijo.Size = new System.Drawing.Size(140, 17);
            this.rbMontoFijo.TabIndex = 25;
            this.rbMontoFijo.TabStop = true;
            this.rbMontoFijo.Text = "Actualizar con monto fijo";
            this.rbMontoFijo.UseVisualStyleBackColor = true;
            this.rbMontoFijo.CheckedChanged += new System.EventHandler(this.rbMontoFijo_CheckedChanged);
            // 
            // rbPorcentaje
            // 
            this.rbPorcentaje.AutoSize = true;
            this.rbPorcentaje.Checked = true;
            this.rbPorcentaje.Location = new System.Drawing.Point(18, 24);
            this.rbPorcentaje.Name = "rbPorcentaje";
            this.rbPorcentaje.Size = new System.Drawing.Size(145, 17);
            this.rbPorcentaje.TabIndex = 9;
            this.rbPorcentaje.TabStop = true;
            this.rbPorcentaje.Text = "Actualizar con porcentaje";
            this.rbPorcentaje.UseVisualStyleBackColor = true;
            this.rbPorcentaje.CheckedChanged += new System.EventHandler(this.rbPorcentaje_CheckedChanged);
            // 
            // lblResumen
            // 
            this.lblResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblResumen.Location = new System.Drawing.Point(11, 8);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(203, 60);
            this.lblResumen.TabIndex = 5;
            this.lblResumen.Text = "Debe seleccionar un método de actualización";
            this.lblResumen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResumen.Visible = false;
            // 
            // rbReduccion
            // 
            this.rbReduccion.AutoSize = true;
            this.rbReduccion.Location = new System.Drawing.Point(18, 47);
            this.rbReduccion.Name = "rbReduccion";
            this.rbReduccion.Size = new System.Drawing.Size(99, 17);
            this.rbReduccion.TabIndex = 28;
            this.rbReduccion.TabStop = true;
            this.rbReduccion.Text = "Reducir precios";
            this.rbReduccion.UseVisualStyleBackColor = true;
            this.rbReduccion.CheckedChanged += new System.EventHandler(this.rbReduccion_CheckedChanged);
            // 
            // rbAumento
            // 
            this.rbAumento.AutoSize = true;
            this.rbAumento.Checked = true;
            this.rbAumento.Location = new System.Drawing.Point(18, 24);
            this.rbAumento.Name = "rbAumento";
            this.rbAumento.Size = new System.Drawing.Size(107, 17);
            this.rbAumento.TabIndex = 27;
            this.rbAumento.TabStop = true;
            this.rbAumento.Text = "Aumentar precios";
            this.rbAumento.UseVisualStyleBackColor = true;
            this.rbAumento.CheckedChanged += new System.EventHandler(this.rbAumento_CheckedChanged);
            // 
            // lblPaso3
            // 
            this.lblPaso3.Location = new System.Drawing.Point(3, 7);
            this.lblPaso3.Name = "lblPaso3";
            this.lblPaso3.Size = new System.Drawing.Size(219, 13);
            this.lblPaso3.TabIndex = 29;
            this.lblPaso3.Text = "3. Ingrese ................... que desea ......................";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(12, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 331);
            this.panel4.TabIndex = 30;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.lblResumen);
            this.panel13.Location = new System.Drawing.Point(3, 252);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(225, 73);
            this.panel13.TabIndex = 39;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txtMontoPorcentaje);
            this.panel12.Location = new System.Drawing.Point(4, 210);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(225, 39);
            this.panel12.TabIndex = 38;
            // 
            // txtMontoPorcentaje
            // 
            this.txtMontoPorcentaje.BackColor = System.Drawing.SystemColors.Control;
            this.txtMontoPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtMontoPorcentaje.Location = new System.Drawing.Point(6, 4);
            this.txtMontoPorcentaje.Name = "txtMontoPorcentaje";
            this.txtMontoPorcentaje.Size = new System.Drawing.Size(207, 32);
            this.txtMontoPorcentaje.TabIndex = 5;
            this.txtMontoPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMontoPorcentaje.TextChanged += new System.EventHandler(this.txtMontoPorcentaje_TextChanged);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lblPaso3);
            this.panel11.Location = new System.Drawing.Point(4, 182);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(225, 24);
            this.panel11.TabIndex = 37;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.groupBox4);
            this.panel8.Location = new System.Drawing.Point(4, 92);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(225, 83);
            this.panel8.TabIndex = 34;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbReduccion);
            this.groupBox4.Controls.Add(this.rbAumento);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(211, 77);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleccione tipo de operación";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Location = new System.Drawing.Point(4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 83);
            this.panel5.TabIndex = 33;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbMontoFijo);
            this.groupBox3.Controls.Add(this.rbPorcentaje);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 77);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccione método de actualización";
            // 
            // btnActualizarPrecios
            // 
            this.btnActualizarPrecios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarPrecios.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarPrecios.Image")));
            this.btnActualizarPrecios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarPrecios.Location = new System.Drawing.Point(129, 418);
            this.btnActualizarPrecios.Name = "btnActualizarPrecios";
            this.btnActualizarPrecios.Size = new System.Drawing.Size(120, 46);
            this.btnActualizarPrecios.TabIndex = 29;
            this.btnActualizarPrecios.Text = "Guardar cambios";
            this.btnActualizarPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarPrecios.UseVisualStyleBackColor = true;
            // 
            // frmModificarPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 484);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarPrecios";
            this.Text = "Actualizar precios";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbxFiltroFamilia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxFiltroProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.RadioButton rbMontoFijo;
        private System.Windows.Forms.RadioButton rbPorcentaje;
        private System.Windows.Forms.RadioButton rbReduccion;
        private System.Windows.Forms.RadioButton rbAumento;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblPaso3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtMontoPorcentaje;
        public System.Windows.Forms.Button btnActualizarPrecios;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}