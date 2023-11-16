namespace UI.Desktop.Artículos
{
    partial class frmBASEListaArticulos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxFiltroProveedor = new System.Windows.Forms.ComboBox();
            this.cbxFiltroFamilia1 = new System.Windows.Forms.ComboBox();
            this.cbxFiltroFamilia2 = new System.Windows.Forms.ComboBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.81673F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.18327F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Controls.Add(this.tbxFiltro, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxFiltroProveedor, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxFiltroFamilia1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxFiltroFamilia2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMostrarTodos, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvListado, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 446);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxFiltro.Location = new System.Drawing.Point(133, 15);
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(130, 20);
            this.tbxFiltro.TabIndex = 31;
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Código ó Descripción ";
            // 
            // cbxFiltroProveedor
            // 
            this.cbxFiltroProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxFiltroProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroProveedor.FormattingEnabled = true;
            this.cbxFiltroProveedor.Location = new System.Drawing.Point(286, 15);
            this.cbxFiltroProveedor.Name = "cbxFiltroProveedor";
            this.cbxFiltroProveedor.Size = new System.Drawing.Size(155, 21);
            this.cbxFiltroProveedor.TabIndex = 32;
            // 
            // cbxFiltroFamilia1
            // 
            this.cbxFiltroFamilia1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxFiltroFamilia1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroFamilia1.FormattingEnabled = true;
            this.cbxFiltroFamilia1.Location = new System.Drawing.Point(450, 15);
            this.cbxFiltroFamilia1.Name = "cbxFiltroFamilia1";
            this.cbxFiltroFamilia1.Size = new System.Drawing.Size(168, 21);
            this.cbxFiltroFamilia1.TabIndex = 33;
            // 
            // cbxFiltroFamilia2
            // 
            this.cbxFiltroFamilia2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxFiltroFamilia2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltroFamilia2.FormattingEnabled = true;
            this.cbxFiltroFamilia2.Location = new System.Drawing.Point(625, 15);
            this.cbxFiltroFamilia2.Name = "cbxFiltroFamilia2";
            this.cbxFiltroFamilia2.Size = new System.Drawing.Size(168, 21);
            this.cbxFiltroFamilia2.TabIndex = 34;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMostrarTodos.Location = new System.Drawing.Point(799, 10);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(105, 30);
            this.btnMostrarTodos.TabIndex = 35;
            this.btnMostrarTodos.Text = "Quitar Filtros";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click_1);
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvListado, 6);
            this.dgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListado.Location = new System.Drawing.Point(3, 54);
            this.dgvListado.Name = "dgvListado";
            this.tableLayoutPanel1.SetRowSpan(this.dgvListado, 2);
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(903, 389);
            this.dgvListado.TabIndex = 36;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Image = global::UI.Desktop.Properties.Resources.back32;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(926, 403);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 44);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(915, 452);
            this.tableLayoutPanel2.TabIndex = 30;
            // 
            // frmBASEListaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 459);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmBASEListaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LISTA DE ARTICULOS CON FILTROS";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbxFiltro;
        private System.Windows.Forms.ComboBox cbxFiltroProveedor;
        private System.Windows.Forms.ComboBox cbxFiltroFamilia1;
        private System.Windows.Forms.ComboBox cbxFiltroFamilia2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.DataGridView dgvListado;
        public System.Windows.Forms.Button btnMostrarTodos;
    }
}