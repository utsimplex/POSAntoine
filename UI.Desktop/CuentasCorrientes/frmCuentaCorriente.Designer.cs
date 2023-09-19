namespace UI.Desktop.CuentasCorrientes
{
    partial class frmCuentaCorriente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuentaCorriente));
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkbxVencidas = new System.Windows.Forms.CheckBox();
            this.chkbxPendientes = new System.Windows.Forms.CheckBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.tbxCliente = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRecibirPago = new System.Windows.Forms.Button();
            this.btnPagarSeleccion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPendiente = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabCuentaCorriente = new System.Windows.Forms.TabPage();
            this.tabCobros = new System.Windows.Forms.TabPage();
            this.dgvCobros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabCuentaCorriente.SuspendLayout();
            this.tabCobros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacturas.Location = new System.Drawing.Point(3, 3);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersVisible = false;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(785, 481);
            this.dgvFacturas.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabGeneral, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1045, 639);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkbxVencidas);
            this.groupBox1.Controls.Add(this.chkbxPendientes);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.tbxCliente);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::UI.Desktop.Properties.Resources.User_24x24;
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = " ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chkbxVencidas
            // 
            this.chkbxVencidas.AutoSize = true;
            this.chkbxVencidas.Location = new System.Drawing.Point(591, 26);
            this.chkbxVencidas.Name = "chkbxVencidas";
            this.chkbxVencidas.Size = new System.Drawing.Size(122, 17);
            this.chkbxVencidas.TabIndex = 4;
            this.chkbxVencidas.Text = "Pendientes +30 dias";
            this.chkbxVencidas.UseVisualStyleBackColor = true;
            this.chkbxVencidas.CheckedChanged += new System.EventHandler(this.chkbxVencidas_CheckedChanged);
            // 
            // chkbxPendientes
            // 
            this.chkbxPendientes.AutoSize = true;
            this.chkbxPendientes.Location = new System.Drawing.Point(467, 27);
            this.chkbxPendientes.Name = "chkbxPendientes";
            this.chkbxPendientes.Size = new System.Drawing.Size(103, 17);
            this.chkbxPendientes.TabIndex = 3;
            this.chkbxPendientes.Text = "Solo Pendientes";
            this.chkbxPendientes.UseVisualStyleBackColor = true;
            this.chkbxPendientes.CheckedChanged += new System.EventHandler(this.chkbxPendientes_CheckedChanged);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(380, 19);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(69, 29);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // tbxCliente
            // 
            this.tbxCliente.Enabled = false;
            this.tbxCliente.Location = new System.Drawing.Point(32, 24);
            this.tbxCliente.Name = "tbxCliente";
            this.tbxCliente.Size = new System.Drawing.Size(342, 20);
            this.tbxCliente.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnRecibirPago, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnPagarSeleccion, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbxPendiente, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(808, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 513);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // btnRecibirPago
            // 
            this.btnRecibirPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRecibirPago.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRecibirPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRecibirPago.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecibirPago.Image = global::UI.Desktop.Properties.Resources._3387295_shopping_finance_payment_machine_credit;
            this.btnRecibirPago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecibirPago.Location = new System.Drawing.Point(3, 203);
            this.btnRecibirPago.Name = "btnRecibirPago";
            this.btnRecibirPago.Size = new System.Drawing.Size(228, 44);
            this.btnRecibirPago.TabIndex = 29;
            this.btnRecibirPago.Text = "Recibir Pago";
            this.btnRecibirPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecibirPago.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRecibirPago.UseVisualStyleBackColor = true;
            this.btnRecibirPago.Click += new System.EventHandler(this.btnRecibirPago_Click);
            // 
            // btnPagarSeleccion
            // 
            this.btnPagarSeleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagarSeleccion.Image = ((System.Drawing.Image)(resources.GetObject("btnPagarSeleccion.Image")));
            this.btnPagarSeleccion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagarSeleccion.Location = new System.Drawing.Point(3, 353);
            this.btnPagarSeleccion.Name = "btnPagarSeleccion";
            this.btnPagarSeleccion.Size = new System.Drawing.Size(228, 44);
            this.btnPagarSeleccion.TabIndex = 26;
            this.btnPagarSeleccion.Text = "Pagar Seleccionadas";
            this.btnPagarSeleccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagarSeleccion.UseVisualStyleBackColor = true;
            this.btnPagarSeleccion.Click += new System.EventHandler(this.btnPagarSeleccion_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(64, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Pendiente";
            // 
            // tbxPendiente
            // 
            this.tbxPendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPendiente.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbxPendiente.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPendiente.ForeColor = System.Drawing.Color.Firebrick;
            this.tbxPendiente.Location = new System.Drawing.Point(3, 59);
            this.tbxPendiente.Name = "tbxPendiente";
            this.tbxPendiente.Size = new System.Drawing.Size(228, 32);
            this.tbxPendiente.TabIndex = 28;
            this.tbxPendiente.TabStop = false;
            this.tbxPendiente.Text = "0";
            this.tbxPendiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(808, 586);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(234, 46);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabCuentaCorriente);
            this.tabGeneral.Controls.Add(this.tabCobros);
            this.tabGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGeneral.Location = new System.Drawing.Point(3, 63);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(799, 513);
            this.tabGeneral.TabIndex = 29;
            this.tabGeneral.SelectedIndexChanged += new System.EventHandler(this.tabGeneral_SelectedIndexChanged);
            this.tabGeneral.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCobros_Selected);
            // 
            // tabCuentaCorriente
            // 
            this.tabCuentaCorriente.Controls.Add(this.dgvFacturas);
            this.tabCuentaCorriente.Location = new System.Drawing.Point(4, 22);
            this.tabCuentaCorriente.Name = "tabCuentaCorriente";
            this.tabCuentaCorriente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCuentaCorriente.Size = new System.Drawing.Size(791, 487);
            this.tabCuentaCorriente.TabIndex = 0;
            this.tabCuentaCorriente.Text = "Cuenta Corriente";
            this.tabCuentaCorriente.UseVisualStyleBackColor = true;
            // 
            // tabCobros
            // 
            this.tabCobros.Controls.Add(this.dgvCobros);
            this.tabCobros.Location = new System.Drawing.Point(4, 22);
            this.tabCobros.Name = "tabCobros";
            this.tabCobros.Padding = new System.Windows.Forms.Padding(3);
            this.tabCobros.Size = new System.Drawing.Size(791, 487);
            this.tabCobros.TabIndex = 1;
            this.tabCobros.Text = "Cobros Recibidos";
            this.tabCobros.UseVisualStyleBackColor = true;
            // 
            // dgvCobros
            // 
            this.dgvCobros.AllowUserToAddRows = false;
            this.dgvCobros.AllowUserToDeleteRows = false;
            this.dgvCobros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCobros.Location = new System.Drawing.Point(3, 3);
            this.dgvCobros.Name = "dgvCobros";
            this.dgvCobros.ReadOnly = true;
            this.dgvCobros.RowHeadersVisible = false;
            this.dgvCobros.Size = new System.Drawing.Size(785, 481);
            this.dgvCobros.TabIndex = 0;
            // 
            // frmCuentaCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 639);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCuentaCorriente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta Corriente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.tabCuentaCorriente.ResumeLayout(false);
            this.tabCobros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxCliente;
        private System.Windows.Forms.CheckBox chkbxVencidas;
        private System.Windows.Forms.CheckBox chkbxPendientes;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Button btnPagarSeleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPendiente;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRecibirPago;
        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabCuentaCorriente;
        private System.Windows.Forms.TabPage tabCobros;
        private System.Windows.Forms.DataGridView dgvCobros;
    }
}