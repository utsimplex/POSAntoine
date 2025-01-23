namespace UI.Desktop.Seña
{
    partial class frmListadoSeña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoSeña));
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(554, 46);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Location = new System.Drawing.Point(570, 16);
            this.groupBox1.Size = new System.Drawing.Size(183, 452);
            this.groupBox1.Controls.SetChildIndex(this.btnSalir, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnAñadirNuevo, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnEliminar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnModificar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnSeleccionar, 0);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(16, 133);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(16, 68);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(16, 185);
            // 
            // btnAñadirNuevo
            // 
            this.btnAñadirNuevo.Location = new System.Drawing.Point(16, 16);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.Location = new System.Drawing.Point(16, 16);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(150, 46);
            this.btnSeleccionar.TabIndex = 29;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Visible = false;
            // 
            // frmListadoSeña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 260);
            this.Name = "frmListadoSeña";
            this.Text = "Lista de Señas";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
    }
}