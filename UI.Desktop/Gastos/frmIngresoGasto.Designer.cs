namespace UI.Desktop.Gastos
{
    partial class frmIngresoGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoGasto));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxTipoGasto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkbxEgreso = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Descripcion:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescripcion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescripcion, 2);
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(161, 148);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.tableLayoutPanel1.SetRowSpan(this.txtDescripcion, 2);
            this.txtDescripcion.Size = new System.Drawing.Size(310, 84);
            this.txtDescripcion.TabIndex = 30;
            // 
            // lblLabel
            // 
            this.lblLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.Location = new System.Drawing.Point(3, 108);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(152, 29);
            this.lblLabel.TabIndex = 29;
            this.lblLabel.Text = "Monto:";
            this.lblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMonto
            // 
            this.txtMonto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(161, 107);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(152, 31);
            this.txtMonto.TabIndex = 28;
            // 
            // btnNo
            // 
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.Location = new System.Drawing.Point(161, 260);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(152, 34);
            this.btnNo.TabIndex = 27;
            this.btnNo.Text = "Cancelar";
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // btnSi
            // 
            this.btnSi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSi.Image = ((System.Drawing.Image)(resources.GetObject("btnSi.Image")));
            this.btnSi.Location = new System.Drawing.Point(319, 260);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(152, 34);
            this.btnSi.TabIndex = 26;
            this.btnSi.Text = "Confirmar";
            this.btnSi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.btnSi, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNo, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtMonto, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpFecha, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxTipoGasto, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chkbxEgreso, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18215F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18033F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18215F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18215F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18215F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091075F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 308);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fecha:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(161, 19);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(152, 26);
            this.dtpFecha.TabIndex = 33;
            // 
            // cbxTipoGasto
            // 
            this.cbxTipoGasto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.cbxTipoGasto, 2);
            this.cbxTipoGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoGasto.FormattingEnabled = true;
            this.cbxTipoGasto.Location = new System.Drawing.Point(161, 63);
            this.cbxTipoGasto.Name = "cbxTipoGasto";
            this.cbxTipoGasto.Size = new System.Drawing.Size(192, 28);
            this.cbxTipoGasto.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Clasificacion:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkbxEgreso
            // 
            this.chkbxEgreso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkbxEgreso.AutoSize = true;
            this.chkbxEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxEgreso.Location = new System.Drawing.Point(319, 111);
            this.chkbxEgreso.Name = "chkbxEgreso";
            this.chkbxEgreso.Size = new System.Drawing.Size(129, 22);
            this.chkbxEgreso.TabIndex = 36;
            this.chkbxEgreso.Text = "Egreso de Caja";
            this.chkbxEgreso.UseVisualStyleBackColor = true;
            // 
            // frmIngresoGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 308);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIngresoGasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de Gasto";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.TextBox txtMonto;
        protected System.Windows.Forms.Button btnNo;
        protected System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbxTipoGasto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkbxEgreso;
    }
}