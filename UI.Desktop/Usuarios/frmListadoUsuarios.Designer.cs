namespace UI.Desktop.Usuarios
{
    partial class frmListadoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(167, 18);
            this.tbxFiltro.Size = new System.Drawing.Size(234, 20);
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMostrarTodos);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Text = "Búsqueda";
            this.groupBox2.Controls.SetChildIndex(this.label1, 0);
            this.groupBox2.Controls.SetChildIndex(this.tbxFiltro, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnMostrarTodos, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(574, 12);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAñadirNuevo
            // 
            this.btnAñadirNuevo.Click += new System.EventHandler(this.btnAñadirNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Por Apellido, Nombre ó Usuario";
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(415, 12);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(136, 30);
            this.btnMostrarTodos.TabIndex = 31;
            this.btnMostrarTodos.Text = "Quitar Filtro";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // frmListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 495);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoUsuarios";
            this.Text = "Listado de Usuarios";
            this.Load += new System.EventHandler(this.frmListadoUsuarios_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarTodos;
    }
}