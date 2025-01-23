namespace UI.Desktop.Descuentos
{
    partial class frmListadoDescuentos
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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(858, 46);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(874, 16);
            // 
            // btnModificar
            // 
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAñadirNuevo
            // 
            this.btnAñadirNuevo.Click += new System.EventHandler(this.btnAñadirNuevo_Click);
            // 
            // frmListadoDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 484);
            this.Name = "frmListadoDescuentos";
            this.Text = "Listado de Descuentos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}