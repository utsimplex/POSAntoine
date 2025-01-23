namespace UI.Desktop.Ventas
{
    partial class frmSeña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeña));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtDniCuit = new System.Windows.Forms.TextBox();
            this.txtNombRazCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreCli = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.txtFechaHoraVta = new System.Windows.Forms.TextBox();
            this.txtNumeroVenta = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.gbArticulosVenta = new System.Windows.Forms.GroupBox();
            this.dgvArticulosVtaActual = new System.Windows.Forms.DataGridView();
            this.btnAgregarArt = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReimprimir = new System.Windows.Forms.Button();
            this.gbTipoPago = new System.Windows.Forms.GroupBox();
            this.lblDispositivo = new System.Windows.Forms.Label();
            this.cbxMedioDePago = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbArticulosVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosVtaActual)).BeginInit();
            this.gbTotal.SuspendLayout();
            this.gbTipoPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.txtDniCuit);
            this.groupBox2.Controls.Add(this.txtNombRazCli);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblNombreCli);
            this.groupBox2.Location = new System.Drawing.Point(328, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(385, 9);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(69, 29);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtDniCuit
            // 
            this.txtDniCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDniCuit.Location = new System.Drawing.Point(142, 41);
            this.txtDniCuit.Name = "txtDniCuit";
            this.txtDniCuit.ReadOnly = true;
            this.txtDniCuit.Size = new System.Drawing.Size(156, 20);
            this.txtDniCuit.TabIndex = 7;
            this.txtDniCuit.TabStop = false;
            this.txtDniCuit.Text = "NO REGISTRADO";
            // 
            // txtNombRazCli
            // 
            this.txtNombRazCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombRazCli.Location = new System.Drawing.Point(142, 15);
            this.txtNombRazCli.Name = "txtNombRazCli";
            this.txtNombRazCli.ReadOnly = true;
            this.txtNombRazCli.Size = new System.Drawing.Size(237, 20);
            this.txtNombRazCli.TabIndex = 5;
            this.txtNombRazCli.TabStop = false;
            this.txtNombRazCli.Text = "NO REGISTRADO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DNI - CUIT:";
            // 
            // lblNombreCli
            // 
            this.lblNombreCli.AutoSize = true;
            this.lblNombreCli.Location = new System.Drawing.Point(14, 17);
            this.lblNombreCli.Name = "lblNombreCli";
            this.lblNombreCli.Size = new System.Drawing.Size(122, 13);
            this.lblNombreCli.TabIndex = 5;
            this.lblNombreCli.Text = "Nombre o Razón Social:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNroFactura);
            this.groupBox1.Controls.Add(this.txtFechaHoraVta);
            this.groupBox1.Controls.Add(this.txtNumeroVenta);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 79);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seña";
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Location = new System.Drawing.Point(18, 22);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(90, 13);
            this.lblNroFactura.TabIndex = 0;
            this.lblNroFactura.Text = "Número de Seña:";
            // 
            // txtFechaHoraVta
            // 
            this.txtFechaHoraVta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaHoraVta.Location = new System.Drawing.Point(117, 48);
            this.txtFechaHoraVta.Name = "txtFechaHoraVta";
            this.txtFechaHoraVta.ReadOnly = true;
            this.txtFechaHoraVta.Size = new System.Drawing.Size(138, 20);
            this.txtFechaHoraVta.TabIndex = 3;
            this.txtFechaHoraVta.TabStop = false;
            this.txtFechaHoraVta.Text = "17 de Julio, 2013";
            this.txtFechaHoraVta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumeroVenta
            // 
            this.txtNumeroVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroVenta.Location = new System.Drawing.Point(117, 22);
            this.txtNumeroVenta.Name = "txtNumeroVenta";
            this.txtNumeroVenta.ReadOnly = true;
            this.txtNumeroVenta.Size = new System.Drawing.Size(138, 20);
            this.txtNumeroVenta.TabIndex = 2;
            this.txtNumeroVenta.TabStop = false;
            this.txtNumeroVenta.Text = "0002";
            this.txtNumeroVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(71, 47);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // gbArticulosVenta
            // 
            this.gbArticulosVenta.Controls.Add(this.dgvArticulosVtaActual);
            this.gbArticulosVenta.Controls.Add(this.btnAgregarArt);
            this.gbArticulosVenta.Controls.Add(this.btnQuitar);
            this.gbArticulosVenta.Controls.Add(this.gbTotal);
            this.gbArticulosVenta.Location = new System.Drawing.Point(0, 149);
            this.gbArticulosVenta.Name = "gbArticulosVenta";
            this.gbArticulosVenta.Size = new System.Drawing.Size(788, 194);
            this.gbArticulosVenta.TabIndex = 12;
            this.gbArticulosVenta.TabStop = false;
            this.gbArticulosVenta.Text = "Detalle";
            // 
            // dgvArticulosVtaActual
            // 
            this.dgvArticulosVtaActual.AllowUserToAddRows = false;
            this.dgvArticulosVtaActual.AllowUserToDeleteRows = false;
            this.dgvArticulosVtaActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosVtaActual.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulosVtaActual.Location = new System.Drawing.Point(6, 19);
            this.dgvArticulosVtaActual.MultiSelect = false;
            this.dgvArticulosVtaActual.Name = "dgvArticulosVtaActual";
            this.dgvArticulosVtaActual.RowHeadersVisible = false;
            this.dgvArticulosVtaActual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulosVtaActual.Size = new System.Drawing.Size(753, 108);
            this.dgvArticulosVtaActual.TabIndex = 0;
            // 
            // btnAgregarArt
            // 
            this.btnAgregarArt.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarArt.Image")));
            this.btnAgregarArt.Location = new System.Drawing.Point(7, 146);
            this.btnAgregarArt.Name = "btnAgregarArt";
            this.btnAgregarArt.Size = new System.Drawing.Size(93, 33);
            this.btnAgregarArt.TabIndex = 0;
            this.btnAgregarArt.Text = "Añadir";
            this.btnAgregarArt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarArt.UseVisualStyleBackColor = true;
            this.btnAgregarArt.Click += new System.EventHandler(this.btnAgregarArt_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitar.Image")));
            this.btnQuitar.Location = new System.Drawing.Point(106, 146);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(93, 33);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // gbTotal
            // 
            this.gbTotal.Controls.Add(this.txtTotal);
            this.gbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotal.Location = new System.Drawing.Point(581, 129);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(188, 59);
            this.gbTotal.TabIndex = 9;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Monto Seña";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtTotal.Location = new System.Drawing.Point(6, 18);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(174, 32);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::UI.Desktop.Properties.Resources.Print_32x32;
            this.btnConfirmar.Location = new System.Drawing.Point(546, 352);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(119, 34);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::UI.Desktop.Properties.Resources.close_24;
            this.btnCancelar.Location = new System.Drawing.Point(669, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 34);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.Image = global::UI.Desktop.Properties.Resources.Print_32x32;
            this.btnReimprimir.Location = new System.Drawing.Point(6, 352);
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new System.Drawing.Size(119, 34);
            this.btnReimprimir.TabIndex = 16;
            this.btnReimprimir.Text = "Reimprimir";
            this.btnReimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReimprimir.UseVisualStyleBackColor = true;
            this.btnReimprimir.Visible = false;
            // 
            // gbTipoPago
            // 
            this.gbTipoPago.Controls.Add(this.lblDispositivo);
            this.gbTipoPago.Controls.Add(this.cbxMedioDePago);
            this.gbTipoPago.Location = new System.Drawing.Point(6, 100);
            this.gbTipoPago.Name = "gbTipoPago";
            this.gbTipoPago.Size = new System.Drawing.Size(193, 43);
            this.gbTipoPago.TabIndex = 10;
            this.gbTipoPago.TabStop = false;
            this.gbTipoPago.Text = "Medio de Pago";
            // 
            // lblDispositivo
            // 
            this.lblDispositivo.AutoSize = true;
            this.lblDispositivo.Location = new System.Drawing.Point(676, 38);
            this.lblDispositivo.Name = "lblDispositivo";
            this.lblDispositivo.Size = new System.Drawing.Size(10, 13);
            this.lblDispositivo.TabIndex = 4;
            this.lblDispositivo.Text = " ";
            // 
            // cbxMedioDePago
            // 
            this.cbxMedioDePago.BackColor = System.Drawing.SystemColors.Control;
            this.cbxMedioDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedioDePago.FormattingEnabled = true;
            this.cbxMedioDePago.Location = new System.Drawing.Point(6, 16);
            this.cbxMedioDePago.Name = "cbxMedioDePago";
            this.cbxMedioDePago.Size = new System.Drawing.Size(168, 21);
            this.cbxMedioDePago.TabIndex = 3;
            // 
            // frmSeña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.gbTipoPago);
            this.Controls.Add(this.btnReimprimir);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbArticulosVenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmSeña";
            this.Text = "frmSeña";
            this.Load += new System.EventHandler(this.frmSeña_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbArticulosVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosVtaActual)).EndInit();
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            this.gbTipoPago.ResumeLayout(false);
            this.gbTipoPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtDniCuit;
        private System.Windows.Forms.TextBox txtNombRazCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreCli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.TextBox txtFechaHoraVta;
        private System.Windows.Forms.TextBox txtNumeroVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox gbArticulosVenta;
        private System.Windows.Forms.DataGridView dgvArticulosVtaActual;
        private System.Windows.Forms.Button btnAgregarArt;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnReimprimir;
        private System.Windows.Forms.GroupBox gbTipoPago;
        private System.Windows.Forms.Label lblDispositivo;
        private System.Windows.Forms.ComboBox cbxMedioDePago;
    }
}