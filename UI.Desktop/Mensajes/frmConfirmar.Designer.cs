namespace UI.Desktop.Mensajes
{
    partial class frmConfirmar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAtencion = new MaterialSkin.Controls.MaterialLabel();
            this.btnSi = new MaterialSkin.Controls.MaterialButton();
            this.btnNo = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(88, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAtencion
            // 
            this.lblAtencion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.lblAtencion, 2);
            this.lblAtencion.Depth = 0;
            this.lblAtencion.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblAtencion.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblAtencion.Location = new System.Drawing.Point(103, 0);
            this.lblAtencion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAtencion.Name = "lblAtencion";
            this.lblAtencion.Size = new System.Drawing.Size(315, 76);
            this.lblAtencion.TabIndex = 1;
            this.lblAtencion.Text = "¿Está seguro que desea ELIMINAR el registro seleccionado?";
            this.lblAtencion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSi
            // 
            this.btnSi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSi.Depth = 0;
            this.btnSi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSi.HighEmphasis = true;
            this.btnSi.Icon = null;
            this.btnSi.Image = ((System.Drawing.Image)(resources.GetObject("btnSi.Image")));
            this.btnSi.Location = new System.Drawing.Point(254, 96);
            this.btnSi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSi.Name = "btnSi";
            this.btnSi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSi.Size = new System.Drawing.Size(163, 36);
            this.btnSi.TabIndex = 18;
            this.btnSi.Text = "Si, Eliminar";
            this.btnSi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSi.UseAccentColor = true;
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNo.Depth = 0;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.HighEmphasis = true;
            this.btnNo.Icon = null;
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.Location = new System.Drawing.Point(104, 96);
            this.btnNo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNo.Name = "btnNo";
            this.btnNo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNo.Size = new System.Drawing.Size(142, 36);
            this.btnNo.TabIndex = 19;
            this.btnNo.Text = "No, Cancelar";
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNo.UseAccentColor = false;
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAtencion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSi, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 152);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // frmConfirmar
            // 
            this.AcceptButton = this.btnSi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnNo;
            this.ClientSize = new System.Drawing.Size(427, 219);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfirmar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATENCION";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblAtencion;
        protected MaterialSkin.Controls.MaterialButton btnSi;
        protected private MaterialSkin.Controls.MaterialButton btnNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}