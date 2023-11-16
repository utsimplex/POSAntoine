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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarCodigosDeBarra));
            this.btnCargarCodigos = new System.Windows.Forms.Button();
            this.cbxSinCodigoOnly = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnCargarCodigos
            // 
            this.btnCargarCodigos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarCodigos.Image = global::UI.Desktop.Properties.Resources.barcodescannersmall;
            this.btnCargarCodigos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarCodigos.Location = new System.Drawing.Point(931, 59);
            this.btnCargarCodigos.Name = "btnCargarCodigos";
            this.btnCargarCodigos.Size = new System.Drawing.Size(150, 44);
            this.btnCargarCodigos.TabIndex = 31;
            this.btnCargarCodigos.Text = "Escanear códigos";
            this.btnCargarCodigos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarCodigos.UseVisualStyleBackColor = true;
            this.btnCargarCodigos.Click += new System.EventHandler(this.btnCargarCodigos_Click);
            // 
            // cbxSinCodigoOnly
            // 
            this.cbxSinCodigoOnly.AutoSize = true;
            this.cbxSinCodigoOnly.Checked = true;
            this.cbxSinCodigoOnly.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbxSinCodigoOnly.Location = new System.Drawing.Point(921, 24);
            this.cbxSinCodigoOnly.Name = "cbxSinCodigoOnly";
            this.cbxSinCodigoOnly.Size = new System.Drawing.Size(178, 17);
            this.cbxSinCodigoOnly.TabIndex = 32;
            this.cbxSinCodigoOnly.Text = "Mostrar sólo artículos sin código";
            this.toolTip1.SetToolTip(this.cbxSinCodigoOnly, resources.GetString("cbxSinCodigoOnly.ToolTip"));
            this.cbxSinCodigoOnly.UseVisualStyleBackColor = true;
            this.cbxSinCodigoOnly.CheckedChanged += new System.EventHandler(this.cbxSinCodigoOnly_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Información";
            // 
            // frmActualizarCodigosDeBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 460);
            this.Controls.Add(this.cbxSinCodigoOnly);
            this.Controls.Add(this.btnCargarCodigos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActualizarCodigosDeBarra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Artículos: TODOS";
            this.Controls.SetChildIndex(this.btnCargarCodigos, 0);
            this.Controls.SetChildIndex(this.cbxSinCodigoOnly, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarCodigos;
        private System.Windows.Forms.CheckBox cbxSinCodigoOnly;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}