namespace UI.Desktop.Cajas
{
    partial class frmCierreCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCierreCaja));
            this.lblSaldoInicial = new System.Windows.Forms.Label();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaApertura = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaCaja = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcionCaja = new System.Windows.Forms.Label();
            this.txtAbiertaPorUsr = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCajaFecha = new System.Windows.Forms.Label();
            this.txtCajaNro = new System.Windows.Forms.TextBox();
            this.lblNroCaja = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMovimientos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVentas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEfectivoRendir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCerradaPorUsr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSaldoInicial
            // 
            this.lblSaldoInicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoInicial.Location = new System.Drawing.Point(23, 172);
            this.lblSaldoInicial.Name = "lblSaldoInicial";
            this.lblSaldoInicial.Size = new System.Drawing.Size(186, 23);
            this.lblSaldoInicial.TabIndex = 21;
            this.lblSaldoInicial.Text = "Saldo inicial";
            this.lblSaldoInicial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSaldoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoInicial.Location = new System.Drawing.Point(215, 172);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(187, 32);
            this.txtSaldoInicial.TabIndex = 22;
            this.txtSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtpFechaApertura);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaCaja);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtSaldoInicial);
            this.groupBox1.Controls.Add(this.lblDescripcionCaja);
            this.groupBox1.Controls.Add(this.lblSaldoInicial);
            this.groupBox1.Controls.Add(this.txtAbiertaPorUsr);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.lblCajaFecha);
            this.groupBox1.Controls.Add(this.txtCajaNro);
            this.groupBox1.Controls.Add(this.lblNroCaja);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 216);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la caja";
            // 
            // dtpFechaApertura
            // 
            this.dtpFechaApertura.Enabled = false;
            this.dtpFechaApertura.Location = new System.Drawing.Point(146, 129);
            this.dtpFechaApertura.Name = "dtpFechaApertura";
            this.dtpFechaApertura.Size = new System.Drawing.Size(256, 20);
            this.dtpFechaApertura.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fecha apertura:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(182, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaCaja
            // 
            this.dtpFechaCaja.Enabled = false;
            this.dtpFechaCaja.Location = new System.Drawing.Point(146, 77);
            this.dtpFechaCaja.Name = "dtpFechaCaja";
            this.dtpFechaCaja.Size = new System.Drawing.Size(256, 20);
            this.dtpFechaCaja.TabIndex = 24;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(146, 103);
            this.txtDescripcion.MaxLength = 999;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(370, 20);
            this.txtDescripcion.TabIndex = 24;
            // 
            // lblDescripcionCaja
            // 
            this.lblDescripcionCaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcionCaja.AutoSize = true;
            this.lblDescripcionCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDescripcionCaja.Location = new System.Drawing.Point(36, 104);
            this.lblDescripcionCaja.Name = "lblDescripcionCaja";
            this.lblDescripcionCaja.Size = new System.Drawing.Size(98, 17);
            this.lblDescripcionCaja.TabIndex = 23;
            this.lblDescripcionCaja.Text = "Descripción:";
            this.lblDescripcionCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAbiertaPorUsr
            // 
            this.txtAbiertaPorUsr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAbiertaPorUsr.Enabled = false;
            this.txtAbiertaPorUsr.Location = new System.Drawing.Point(146, 25);
            this.txtAbiertaPorUsr.Name = "txtAbiertaPorUsr";
            this.txtAbiertaPorUsr.Size = new System.Drawing.Size(370, 20);
            this.txtAbiertaPorUsr.TabIndex = 22;
            this.txtAbiertaPorUsr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.Location = new System.Drawing.Point(40, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(94, 17);
            this.lblUsuario.TabIndex = 21;
            this.lblUsuario.Text = "Abierta por:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCajaFecha
            // 
            this.lblCajaFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCajaFecha.AutoSize = true;
            this.lblCajaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajaFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCajaFecha.Location = new System.Drawing.Point(77, 78);
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
            this.txtCajaNro.Location = new System.Drawing.Point(146, 51);
            this.txtCajaNro.Name = "txtCajaNro";
            this.txtCajaNro.Size = new System.Drawing.Size(256, 20);
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
            this.lblNroCaja.Location = new System.Drawing.Point(54, 52);
            this.lblNroCaja.Name = "lblNroCaja";
            this.lblNroCaja.Size = new System.Drawing.Size(86, 17);
            this.lblNroCaja.TabIndex = 17;
            this.lblNroCaja.Text = "Nro. Caja: ";
            this.lblNroCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNo
            // 
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.Location = new System.Drawing.Point(143, 418);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(124, 46);
            this.btnNo.TabIndex = 20;
            this.btnNo.Text = "Cancelar";
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrarCaja.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCerrarCaja.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarCaja.Image = global::UI.Desktop.Properties.Resources._3319640_money_coin_dollar_save_lock;
            this.btnCerrarCaja.Location = new System.Drawing.Point(273, 418);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(138, 46);
            this.btnCerrarCaja.TabIndex = 14;
            this.btnCerrarCaja.Text = "Cerrar caja";
            this.btnCerrarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarCaja.UseVisualStyleBackColor = true;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnAbrirCaja_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMovimientos);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtVentas);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtEfectivoRendir);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCerradaPorUsr);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(21, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 174);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cierre de caja";
            // 
            // lblMovimientos
            // 
            this.lblMovimientos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMovimientos.AutoSize = true;
            this.lblMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMovimientos.Location = new System.Drawing.Point(143, 48);
            this.lblMovimientos.Name = "lblMovimientos";
            this.lblMovimientos.Size = new System.Drawing.Size(17, 17);
            this.lblMovimientos.TabIndex = 36;
            this.lblMovimientos.Text = "0";
            this.lblMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(32, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Movimientos:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(182, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 29);
            this.label8.TabIndex = 34;
            this.label8.Text = "$";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(182, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 29);
            this.label7.TabIndex = 33;
            this.label7.Text = "$";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVentas
            // 
            this.txtVentas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVentas.Enabled = false;
            this.txtVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentas.Location = new System.Drawing.Point(215, 82);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(187, 32);
            this.txtVentas.TabIndex = 32;
            this.txtVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Total Ventas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEfectivoRendir
            // 
            this.txtEfectivoRendir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEfectivoRendir.Enabled = false;
            this.txtEfectivoRendir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivoRendir.Location = new System.Drawing.Point(215, 129);
            this.txtEfectivoRendir.Name = "txtEfectivoRendir";
            this.txtEfectivoRendir.Size = new System.Drawing.Size(187, 32);
            this.txtEfectivoRendir.TabIndex = 30;
            this.txtEfectivoRendir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-19, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Efectivo a rendir";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCerradaPorUsr
            // 
            this.txtCerradaPorUsr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCerradaPorUsr.Enabled = false;
            this.txtCerradaPorUsr.Location = new System.Drawing.Point(146, 25);
            this.txtCerradaPorUsr.Name = "txtCerradaPorUsr";
            this.txtCerradaPorUsr.Size = new System.Drawing.Size(370, 20);
            this.txtCerradaPorUsr.TabIndex = 27;
            this.txtCerradaPorUsr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(34, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cerrada por:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 476);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnCerrarCaja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCierreCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cerrar caja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarCaja;
        protected System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblSaldoInicial;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAbiertaPorUsr;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCajaFecha;
        private System.Windows.Forms.TextBox txtCajaNro;
        private System.Windows.Forms.Label lblNroCaja;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcionCaja;
        private System.Windows.Forms.DateTimePicker dtpFechaCaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCerradaPorUsr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaApertura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEfectivoRendir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVentas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMovimientos;
        private System.Windows.Forms.Label label9;
    }
}