namespace UI.Desktop.Clientes
{
    partial class frmClienteABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteABM));
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbxCondicionCli = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.cbxCondicionCli);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Size = new System.Drawing.Size(521, 290);
            this.groupBox1.Controls.SetChildIndex(this.cbxCondicionCli, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblTipo, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnGuardar, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnCancelar, 0);
            this.groupBox1.Controls.SetChildIndex(this.pictureBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtApellido, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtNombre, 0);
            this.groupBox1.Controls.SetChildIndex(this.label6, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.label3, 0);
            this.groupBox1.Controls.SetChildIndex(this.label5, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtNroDoc, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtDireccion, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtTelefono, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtEmail, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(291, 175);
            this.txtEmail.Size = new System.Drawing.Size(224, 20);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(291, 144);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(291, 113);
            this.txtDireccion.Size = new System.Drawing.Size(224, 20);
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(291, 82);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(241, 23);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(168, 85);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(236, 147);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(291, 20);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(291, 51);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(246, 235);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(376, 235);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(241, 54);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(233, 116);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(250, 178);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(207, 205);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(78, 13);
            this.lblTipo.TabIndex = 34;
            this.lblTipo.Text = "Tipo de Cliente";
            // 
            // cbxCondicionCli
            // 
            this.cbxCondicionCli.FormattingEnabled = true;
            this.cbxCondicionCli.Location = new System.Drawing.Point(291, 201);
            this.cbxCondicionCli.Name = "cbxCondicionCli";
            this.cbxCondicionCli.Size = new System.Drawing.Size(224, 21);
            this.cbxCondicionCli.TabIndex = 36;
            // 
            // frmClienteABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 313);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClienteABM";
            this.Text = "frmClienteABM";
            this.Load += new System.EventHandler(this.frmClienteABM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbxCondicionCli;
      
    }
}