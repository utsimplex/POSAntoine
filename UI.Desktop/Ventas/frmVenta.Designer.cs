namespace UI.Desktop.Ventas
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFechaHoraVta = new System.Windows.Forms.TextBox();
            this.txtNumeroVenta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtDniCuit = new System.Windows.Forms.TextBox();
            this.txtNombRazCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreCli = new System.Windows.Forms.Label();
            this.gbTipoPago = new System.Windows.Forms.GroupBox();
            this.rbMP = new System.Windows.Forms.RadioButton();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.gbArticulosVenta = new System.Windows.Forms.GroupBox();
            this.dgvArticulosVtaActual = new System.Windows.Forms.DataGridView();
            this.btnAgregarArt = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDcto = new System.Windows.Forms.TextBox();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.lblSignoPeso = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombreNegocio = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbTipoPago.SuspendLayout();
            this.gbArticulosVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosVtaActual)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbTotal.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Location = new System.Drawing.Point(43, 23);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(93, 13);
            this.lblNroFactura.TabIndex = 0;
            this.lblNroFactura.Text = "Número de Venta:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(96, 49);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNroFactura);
            this.groupBox1.Controls.Add(this.txtFechaHoraVta);
            this.groupBox1.Controls.Add(this.txtNumeroVenta);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comprobante";
            // 
            // txtFechaHoraVta
            // 
            this.txtFechaHoraVta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaHoraVta.Location = new System.Drawing.Point(142, 46);
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
            this.txtNumeroVenta.Location = new System.Drawing.Point(142, 21);
            this.txtNumeroVenta.Name = "txtNumeroVenta";
            this.txtNumeroVenta.ReadOnly = true;
            this.txtNumeroVenta.Size = new System.Drawing.Size(138, 20);
            this.txtNumeroVenta.TabIndex = 2;
            this.txtNumeroVenta.TabStop = false;
            this.txtNumeroVenta.Text = "0002";
            this.txtNumeroVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.txtDniCuit);
            this.groupBox2.Controls.Add(this.txtNombRazCli);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblNombreCli);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 87);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(252, 46);
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
            this.txtDniCuit.Location = new System.Drawing.Point(142, 50);
            this.txtDniCuit.Name = "txtDniCuit";
            this.txtDniCuit.ReadOnly = true;
            this.txtDniCuit.Size = new System.Drawing.Size(104, 20);
            this.txtDniCuit.TabIndex = 7;
            this.txtDniCuit.TabStop = false;
            this.txtDniCuit.Text = "NO REGISTRADO";
            // 
            // txtNombRazCli
            // 
            this.txtNombRazCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombRazCli.Location = new System.Drawing.Point(142, 20);
            this.txtNombRazCli.Name = "txtNombRazCli";
            this.txtNombRazCli.ReadOnly = true;
            this.txtNombRazCli.Size = new System.Drawing.Size(144, 20);
            this.txtNombRazCli.TabIndex = 5;
            this.txtNombRazCli.TabStop = false;
            this.txtNombRazCli.Text = "NO REGISTRADO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DNI - CUIT:";
            // 
            // lblNombreCli
            // 
            this.lblNombreCli.AutoSize = true;
            this.lblNombreCli.Location = new System.Drawing.Point(14, 22);
            this.lblNombreCli.Name = "lblNombreCli";
            this.lblNombreCli.Size = new System.Drawing.Size(122, 13);
            this.lblNombreCli.TabIndex = 5;
            this.lblNombreCli.Text = "Nombre o Razón Social:";
            // 
            // gbTipoPago
            // 
            this.gbTipoPago.Controls.Add(this.rbMP);
            this.gbTipoPago.Controls.Add(this.rbTarjeta);
            this.gbTipoPago.Controls.Add(this.rbEfectivo);
            this.gbTipoPago.Location = new System.Drawing.Point(350, 121);
            this.gbTipoPago.Name = "gbTipoPago";
            this.gbTipoPago.Size = new System.Drawing.Size(288, 56);
            this.gbTipoPago.TabIndex = 1;
            this.gbTipoPago.TabStop = false;
            this.gbTipoPago.Text = "Tipo de Pago";
            // 
            // rbMP
            // 
            this.rbMP.AutoSize = true;
            this.rbMP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbMP.Location = new System.Drawing.Point(102, 33);
            this.rbMP.Name = "rbMP";
            this.rbMP.Size = new System.Drawing.Size(95, 17);
            this.rbMP.TabIndex = 2;
            this.rbMP.TabStop = true;
            this.rbMP.Text = "Mercado Pago";
            this.rbMP.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbTarjeta.Location = new System.Drawing.Point(99, 15);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(98, 17);
            this.rbTarjeta.TabIndex = 1;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "Crédito - Débito";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbEfectivo.Checked = true;
            this.rbEfectivo.Location = new System.Drawing.Point(7, 25);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rbEfectivo.TabIndex = 0;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // gbArticulosVenta
            // 
            this.gbArticulosVenta.Controls.Add(this.dgvArticulosVtaActual);
            this.gbArticulosVenta.Controls.Add(this.btnAgregarArt);
            this.gbArticulosVenta.Controls.Add(this.btnQuitar);
            this.gbArticulosVenta.Controls.Add(this.groupBox3);
            this.gbArticulosVenta.Controls.Add(this.gbTotal);
            this.gbArticulosVenta.Location = new System.Drawing.Point(14, 180);
            this.gbArticulosVenta.Name = "gbArticulosVenta";
            this.gbArticulosVenta.Size = new System.Drawing.Size(624, 303);
            this.gbArticulosVenta.TabIndex = 2;
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
            this.dgvArticulosVtaActual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulosVtaActual.Size = new System.Drawing.Size(612, 212);
            this.dgvArticulosVtaActual.TabIndex = 0;
            this.dgvArticulosVtaActual.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulosVtaActual_CellEndEdit);
            this.dgvArticulosVtaActual.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvArticulosVtaActual_CellMouseDoubleClick);
            // 
            // btnAgregarArt
            // 
            this.btnAgregarArt.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarArt.Image")));
            this.btnAgregarArt.Location = new System.Drawing.Point(16, 249);
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
            this.btnQuitar.Location = new System.Drawing.Point(115, 249);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(93, 33);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDcto);
            this.groupBox3.Location = new System.Drawing.Point(344, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 58);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aplicar Descuento %";
            // 
            // txtDcto
            // 
            this.txtDcto.Location = new System.Drawing.Point(25, 24);
            this.txtDcto.Name = "txtDcto";
            this.txtDcto.Size = new System.Drawing.Size(66, 20);
            this.txtDcto.TabIndex = 0;
            this.txtDcto.Text = "0";
            this.txtDcto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDcto.Leave += new System.EventHandler(this.txtDcto_Leave);
            // 
            // gbTotal
            // 
            this.gbTotal.Controls.Add(this.lblSignoPeso);
            this.gbTotal.Controls.Add(this.txtTotal);
            this.gbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotal.Location = new System.Drawing.Point(470, 237);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(148, 59);
            this.gbTotal.TabIndex = 9;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Total";
            // 
            // lblSignoPeso
            // 
            this.lblSignoPeso.AutoSize = true;
            this.lblSignoPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignoPeso.Location = new System.Drawing.Point(6, 20);
            this.lblSignoPeso.Name = "lblSignoPeso";
            this.lblSignoPeso.Size = new System.Drawing.Size(25, 25);
            this.lblSignoPeso.TabIndex = 4;
            this.lblSignoPeso.Text = "$";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtTotal.Location = new System.Drawing.Point(36, 18);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(106, 32);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::UI.Desktop.Properties.Resources.close_24;
            this.btnCancelar.Location = new System.Drawing.Point(518, 489);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 34);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.lblTelefono);
            this.groupBox4.Controls.Add(this.lblDireccion);
            this.groupBox4.Controls.Add(this.lblNombreNegocio);
            this.groupBox4.Location = new System.Drawing.Point(350, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 103);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Desktop.Properties.Resources.inhalabar;
            this.pictureBox1.Location = new System.Drawing.Point(16, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(137, 78);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(91, 13);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Tel.: 3416041858";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(124, 59);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(113, 13);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Houssay 1670 - Funes";
            // 
            // lblNombreNegocio
            // 
            this.lblNombreNegocio.Location = new System.Drawing.Point(110, 21);
            this.lblNombreNegocio.Name = "lblNombreNegocio";
            this.lblNombreNegocio.Size = new System.Drawing.Size(170, 38);
            this.lblNombreNegocio.TabIndex = 0;
            this.lblNombreNegocio.Text = "Mercado y autoservicio de comida saludable. Local or take away !";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Image = global::UI.Desktop.Properties.Resources.Print_32x32;
            this.btnConfirmar.Location = new System.Drawing.Point(396, 489);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(119, 34);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmVenta
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 529);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbArticulosVenta);
            this.Controls.Add(this.gbTipoPago);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva venta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbTipoPago.ResumeLayout(false);
            this.gbTipoPago.PerformLayout();
            this.gbArticulosVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosVtaActual)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFechaHoraVta;
        private System.Windows.Forms.TextBox txtNumeroVenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombRazCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreCli;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtDniCuit;
        private System.Windows.Forms.GroupBox gbTipoPago;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.GroupBox gbArticulosVenta;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregarArt;
        private System.Windows.Forms.DataGridView dgvArticulosVtaActual;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDcto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombreNegocio;
        private System.Windows.Forms.Label lblSignoPeso;
        private System.Windows.Forms.RadioButton rbMP;
    }
}