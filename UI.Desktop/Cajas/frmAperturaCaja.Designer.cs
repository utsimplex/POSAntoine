namespace UI.Desktop.Cajas
{
    partial class frmAperturaCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAperturaCaja));
            this.btnAbrirCaja = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblSaldoInicial = new System.Windows.Forms.Label();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaCaja = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcionCaja = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCajaFecha = new System.Windows.Forms.Label();
            this.txtCajaNro = new System.Windows.Forms.TextBox();
            this.lblNroCaja = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrirCaja
            // 
            this.btnAbrirCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirCaja.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbrirCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAbrirCaja.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbrirCaja.Image = global::UI.Desktop.Properties.Resources._3387295_shopping_finance_payment_machine_credit;
            this.btnAbrirCaja.Location = new System.Drawing.Point(169, 243);
            this.btnAbrirCaja.Name = "btnAbrirCaja";
            this.btnAbrirCaja.Size = new System.Drawing.Size(138, 46);
            this.btnAbrirCaja.TabIndex = 14;
            this.btnAbrirCaja.Text = "Abrir caja";
            this.btnAbrirCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirCaja.UseVisualStyleBackColor = true;
            this.btnAbrirCaja.Click += new System.EventHandler(this.btnAbrirCaja_Click);
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.Location = new System.Drawing.Point(39, 243);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(124, 46);
            this.btnNo.TabIndex = 20;
            this.btnNo.Text = "Cancelar";
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblSaldoInicial
            // 
            this.lblSaldoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoInicial.Location = new System.Drawing.Point(12, 9);
            this.lblSaldoInicial.Name = "lblSaldoInicial";
            this.lblSaldoInicial.Size = new System.Drawing.Size(322, 23);
            this.lblSaldoInicial.TabIndex = 21;
            this.lblSaldoInicial.Text = "Saldo inicial";
            this.lblSaldoInicial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoInicial.Location = new System.Drawing.Point(100, 45);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(149, 32);
            this.txtSaldoInicial.TabIndex = 22;
            this.txtSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaCaja);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.lblDescripcionCaja);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.lblCajaFecha);
            this.groupBox1.Controls.Add(this.txtCajaNro);
            this.groupBox1.Controls.Add(this.lblNroCaja);
            this.groupBox1.Location = new System.Drawing.Point(21, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 143);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información adicional";
            // 
            // dtpFechaCaja
            // 
            this.dtpFechaCaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCaja.Location = new System.Drawing.Point(125, 77);
            this.dtpFechaCaja.Name = "dtpFechaCaja";
            this.dtpFechaCaja.Size = new System.Drawing.Size(161, 20);
            this.dtpFechaCaja.TabIndex = 24;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(125, 103);
            this.txtDescripcion.MaxLength = 999;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(161, 20);
            this.txtDescripcion.TabIndex = 24;
            // 
            // lblDescripcionCaja
            // 
            this.lblDescripcionCaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcionCaja.AutoSize = true;
            this.lblDescripcionCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDescripcionCaja.Location = new System.Drawing.Point(15, 104);
            this.lblDescripcionCaja.Name = "lblDescripcionCaja";
            this.lblDescripcionCaja.Size = new System.Drawing.Size(98, 17);
            this.lblDescripcionCaja.TabIndex = 23;
            this.lblDescripcionCaja.Text = "Descripción:";
            this.lblDescripcionCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(125, 25);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(161, 20);
            this.txtUsuario.TabIndex = 22;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.Location = new System.Drawing.Point(44, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(69, 17);
            this.lblUsuario.TabIndex = 21;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCajaFecha
            // 
            this.lblCajaFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCajaFecha.AutoSize = true;
            this.lblCajaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajaFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCajaFecha.Location = new System.Drawing.Point(56, 78);
            this.lblCajaFecha.Name = "lblCajaFecha";
            this.lblCajaFecha.Size = new System.Drawing.Size(57, 17);
            this.lblCajaFecha.TabIndex = 19;
            this.lblCajaFecha.Text = "Fecha:";
            this.lblCajaFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCajaNro
            // 
            this.txtCajaNro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCajaNro.Enabled = false;
            this.txtCajaNro.Location = new System.Drawing.Point(125, 51);
            this.txtCajaNro.Name = "txtCajaNro";
            this.txtCajaNro.Size = new System.Drawing.Size(161, 20);
            this.txtCajaNro.TabIndex = 18;
            this.txtCajaNro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNroCaja
            // 
            this.lblNroCaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNroCaja.AutoSize = true;
            this.lblNroCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNroCaja.Location = new System.Drawing.Point(33, 52);
            this.lblNroCaja.Name = "lblNroCaja";
            this.lblNroCaja.Size = new System.Drawing.Size(86, 17);
            this.lblNroCaja.TabIndex = 17;
            this.lblNroCaja.Text = "Nro. Caja: ";
            this.lblNroCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(67, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAperturaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSaldoInicial);
            this.Controls.Add(this.lblSaldoInicial);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnAbrirCaja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAperturaCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Abrir caja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirCaja;
        protected System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblSaldoInicial;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCajaFecha;
        private System.Windows.Forms.TextBox txtCajaNro;
        private System.Windows.Forms.Label lblNroCaja;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcionCaja;
        private System.Windows.Forms.DateTimePicker dtpFechaCaja;
        private System.Windows.Forms.Label label1;
    }
}