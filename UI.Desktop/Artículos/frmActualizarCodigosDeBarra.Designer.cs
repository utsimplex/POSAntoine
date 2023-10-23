namespace UI.Desktop.Artículos
{
    partial class frmActualizarCodigosDeBarra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarCodigosDeBarra));
            this.btnCargarCodigos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarCodigos
            // 
            this.btnCargarCodigos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarCodigos.Image = global::UI.Desktop.Properties.Resources.barcodescannersmall;
            this.btnCargarCodigos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarCodigos.Location = new System.Drawing.Point(931, 8);
            this.btnCargarCodigos.Name = "btnCargarCodigos";
            this.btnCargarCodigos.Size = new System.Drawing.Size(150, 44);
            this.btnCargarCodigos.TabIndex = 31;
            this.btnCargarCodigos.Text = "Escanear códigos";
            this.btnCargarCodigos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarCodigos.UseVisualStyleBackColor = true;
            this.btnCargarCodigos.Click += new System.EventHandler(this.btnCargarCodigos_Click);
            // 
            // frmActualizarCodigosDeBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 460);
            this.Controls.Add(this.btnCargarCodigos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActualizarCodigosDeBarra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.SetChildIndex(this.btnCargarCodigos, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarCodigos;
    }
}