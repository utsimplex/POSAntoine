namespace UI.Desktop.Ventas
{
    partial class frmConfirmarVta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmarVta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.txtTipoPago = new System.Windows.Forms.TextBox();
            this.lblAbonaCon = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCtaCte = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.lblTipoPago);
            this.groupBox1.Controls.Add(this.txtTipoPago);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(59, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(77, 24);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtTotal.Location = new System.Drawing.Point(142, 18);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(290, 29);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPago.Location = new System.Drawing.Point(7, 56);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(129, 24);
            this.lblTipoPago.TabIndex = 1;
            this.lblTipoPago.Text = "Tipo de Pago:";
            // 
            // txtTipoPago
            // 
            this.txtTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoPago.Location = new System.Drawing.Point(142, 53);
            this.txtTipoPago.Name = "txtTipoPago";
            this.txtTipoPago.ReadOnly = true;
            this.txtTipoPago.Size = new System.Drawing.Size(290, 29);
            this.txtTipoPago.TabIndex = 0;
            this.txtTipoPago.TabStop = false;
            this.txtTipoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAbonaCon
            // 
            this.lblAbonaCon.AutoSize = true;
            this.lblAbonaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbonaCon.Location = new System.Drawing.Point(37, 22);
            this.lblAbonaCon.Name = "lblAbonaCon";
            this.lblAbonaCon.Size = new System.Drawing.Size(99, 24);
            this.lblAbonaCon.TabIndex = 4;
            this.lblAbonaCon.Text = "SU PAGO:";
            // 
            // txtPago
            // 
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(142, 19);
            this.txtPago.MaxLength = 15;
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(290, 29);
            this.txtPago.TabIndex = 1;
            this.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblVuelto);
            this.groupBox2.Controls.Add(this.lblAbonaCon);
            this.groupBox2.Controls.Add(this.txtVuelto);
            this.groupBox2.Controls.Add(this.txtPago);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 102);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelto.Location = new System.Drawing.Point(18, 59);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(118, 24);
            this.lblVuelto.TabIndex = 4;
            this.lblVuelto.Text = "VUELTO ($):";
            // 
            // txtVuelto
            // 
            this.txtVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVuelto.Location = new System.Drawing.Point(142, 54);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.Size = new System.Drawing.Size(290, 29);
            this.txtVuelto.TabIndex = 5;
            this.txtVuelto.Text = "0";
            this.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnImprimir
            // 
            this.btnImprimir.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(457, 22);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(119, 34);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(457, 187);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 34);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(457, 60);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 34);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Solo Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCtaCte
            // 
            this.btnCtaCte.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCtaCte.Image = global::UI.Desktop.Properties.Resources.User_24x24;
            this.btnCtaCte.Location = new System.Drawing.Point(457, 100);
            this.btnCtaCte.Name = "btnCtaCte";
            this.btnCtaCte.Size = new System.Drawing.Size(119, 34);
            this.btnCtaCte.TabIndex = 10;
            this.btnCtaCte.Text = "Cuenta Corriente";
            this.btnCtaCte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCtaCte.UseVisualStyleBackColor = true;
            this.btnCtaCte.Click += new System.EventHandler(this.btnCtaCte_Click);
            // 
            // frmConfirmarVta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 227);
            this.Controls.Add(this.btnCtaCte);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfirmarVta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva venta - Confirmar";
            this.Load += new System.EventHandler(this.frmConfirmarVta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Label lblAbonaCon;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.TextBox txtVuelto;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtTipoPago;
        private System.Windows.Forms.Button btnCtaCte;
    }
}