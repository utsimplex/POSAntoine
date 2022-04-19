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
            this.lblAtencion = new System.Windows.Forms.Label();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAtencion
            // 
            this.lblAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtencion.Location = new System.Drawing.Point(135, 27);
            this.lblAtencion.Name = "lblAtencion";
            this.lblAtencion.Size = new System.Drawing.Size(247, 63);
            this.lblAtencion.TabIndex = 1;
            this.lblAtencion.Text = "¿Está seguro que desea ELIMINAR el registro seleccionado?";
            this.lblAtencion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSi
            // 
            this.btnSi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSi.Image = ((System.Drawing.Image)(resources.GetObject("btnSi.Image")));
            this.btnSi.Location = new System.Drawing.Point(128, 116);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(124, 37);
            this.btnSi.TabIndex = 18;
            this.btnSi.Text = "Si, Eliminar";
            this.btnSi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNo
            // 
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.Location = new System.Drawing.Point(258, 116);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(124, 37);
            this.btnNo.TabIndex = 19;
            this.btnNo.Text = "No, Cancelar";
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // frmConfirmar
            // 
            this.AcceptButton = this.btnSi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnNo;
            this.ClientSize = new System.Drawing.Size(416, 165);
            this.ControlBox = false;
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.lblAtencion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmConfirmar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATENCION";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAtencion;
        protected System.Windows.Forms.Button btnSi;
        protected System.Windows.Forms.Button btnNo;
    }
}