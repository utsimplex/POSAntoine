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
            this.cbxSituacionFiscal = new System.Windows.Forms.ComboBox();
            this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxTipoComprobante = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbxTipoComprobante);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxTipoDocumento);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.cbxSituacionFiscal);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Size = new System.Drawing.Size(521, 309);
            this.groupBox1.Controls.SetChildIndex(this.cbxSituacionFiscal, 0);
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
            this.groupBox1.Controls.SetChildIndex(this.cbxTipoDocumento, 0);
            this.groupBox1.Controls.SetChildIndex(this.label7, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbxTipoComprobante, 0);
            this.groupBox1.Controls.SetChildIndex(this.label8, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(291, 127);
            this.txtEmail.Size = new System.Drawing.Size(224, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(291, 96);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(291, 65);
            this.txtDireccion.Size = new System.Drawing.Size(224, 20);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(291, 175);
            this.txtNroDoc.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(241, 14);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(168, 178);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(233, 99);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(291, 11);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(291, 37);
            this.txtApellido.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(244, 266);
            this.btnGuardar.TabIndex = 9;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(374, 266);
            this.btnCancelar.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(238, 40);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(233, 68);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(250, 130);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(204, 204);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(81, 13);
            this.lblTipo.TabIndex = 34;
            this.lblTipo.Text = "Situacion Fiscal";
            // 
            // cbxSituacionFiscal
            // 
            this.cbxSituacionFiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSituacionFiscal.FormattingEnabled = true;
            this.cbxSituacionFiscal.Location = new System.Drawing.Point(291, 201);
            this.cbxSituacionFiscal.Name = "cbxSituacionFiscal";
            this.cbxSituacionFiscal.Size = new System.Drawing.Size(224, 21);
            this.cbxSituacionFiscal.TabIndex = 7;
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoDocumento.FormattingEnabled = true;
            this.cbxTipoDocumento.Location = new System.Drawing.Point(291, 151);
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.Size = new System.Drawing.Size(155, 21);
            this.cbxTipoDocumento.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Tipo de Documento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Tipo de Comprobante";
            // 
            // cbxTipoComprobante
            // 
            this.cbxTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoComprobante.FormattingEnabled = true;
            this.cbxTipoComprobante.Location = new System.Drawing.Point(291, 228);
            this.cbxTipoComprobante.Name = "cbxTipoComprobante";
            this.cbxTipoComprobante.Size = new System.Drawing.Size(224, 21);
            this.cbxTipoComprobante.TabIndex = 8;
            // 
            // frmClienteABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 324);
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
        private System.Windows.Forms.ComboBox cbxSituacionFiscal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxTipoDocumento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxTipoComprobante;
    }
}