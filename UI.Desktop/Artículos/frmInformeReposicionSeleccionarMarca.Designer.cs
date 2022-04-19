namespace UI.Desktop.Artículos
{
    partial class frmInformeReposicionSeleccionarMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformeReposicionSeleccionarMarca));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxSeleccionarMarca = new System.Windows.Forms.ComboBox();
            this.btnCrearInforme = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxSeleccionarMarca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una Marca";
            // 
            // cbxSeleccionarMarca
            // 
            this.cbxSeleccionarMarca.FormattingEnabled = true;
            this.cbxSeleccionarMarca.Location = new System.Drawing.Point(18, 19);
            this.cbxSeleccionarMarca.Name = "cbxSeleccionarMarca";
            this.cbxSeleccionarMarca.Size = new System.Drawing.Size(222, 21);
            this.cbxSeleccionarMarca.TabIndex = 0;
            // 
            // btnCrearInforme
            // 
            this.btnCrearInforme.Image = global::UI.Desktop.Properties.Resources.document_24;
            this.btnCrearInforme.Location = new System.Drawing.Point(16, 74);
            this.btnCrearInforme.Name = "btnCrearInforme";
            this.btnCrearInforme.Size = new System.Drawing.Size(124, 37);
            this.btnCrearInforme.TabIndex = 1;
            this.btnCrearInforme.Text = "Crear Informe";
            this.btnCrearInforme.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCrearInforme.UseVisualStyleBackColor = true;
            this.btnCrearInforme.Click += new System.EventHandler(this.btnCrearInforme_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::UI.Desktop.Properties.Resources.close_24;
            this.btnCancelar.Location = new System.Drawing.Point(146, 74);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 37);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmInformeReposicionSeleccionarMarca
            // 
            this.AcceptButton = this.btnCrearInforme;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(286, 123);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrearInforme);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInformeReposicionSeleccionarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe de reposición";
            this.Load += new System.EventHandler(this.frmInformeReposicionSeleccionarMarca_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxSeleccionarMarca;
        private System.Windows.Forms.Button btnCrearInforme;
        private System.Windows.Forms.Button btnCancelar;
    }
}