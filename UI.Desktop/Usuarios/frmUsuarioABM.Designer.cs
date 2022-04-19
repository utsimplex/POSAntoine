namespace UI.Desktop.Usuarios
{
    partial class frmUsuarioABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarioABM));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbRol = new System.Windows.Forms.GroupBox();
            this.rdioAdministrador = new System.Windows.Forms.RadioButton();
            this.rdioExterno = new System.Windows.Forms.RadioButton();
            this.rdioEmpleado = new System.Windows.Forms.RadioButton();
            this.lblRepetirContraseña = new System.Windows.Forms.Label();
            this.txtRepetirContraseña = new System.Windows.Forms.TextBox();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNuevaContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gbRol);
            this.groupBox1.Controls.Add(this.lblRepetirContraseña);
            this.groupBox1.Controls.Add(this.txtRepetirContraseña);
            this.groupBox1.Controls.Add(this.lblNuevaContraseña);
            this.groupBox1.Controls.Add(this.lblContraseña);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.txtNuevaContraseña);
            this.groupBox1.Controls.Add(this.txtContraseña);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtCuil);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblCuil);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 391);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ABM";
            // 
            // gbRol
            // 
            this.gbRol.Controls.Add(this.rdioAdministrador);
            this.gbRol.Controls.Add(this.rdioExterno);
            this.gbRol.Controls.Add(this.rdioEmpleado);
            this.gbRol.Location = new System.Drawing.Point(17, 220);
            this.gbRol.Name = "gbRol";
            this.gbRol.Size = new System.Drawing.Size(147, 110);
            this.gbRol.TabIndex = 95;
            this.gbRol.TabStop = false;
            this.gbRol.Text = "Rol de usuario";
            // 
            // rdioAdministrador
            // 
            this.rdioAdministrador.AutoSize = true;
            this.rdioAdministrador.Location = new System.Drawing.Point(17, 27);
            this.rdioAdministrador.Name = "rdioAdministrador";
            this.rdioAdministrador.Size = new System.Drawing.Size(88, 17);
            this.rdioAdministrador.TabIndex = 101;
            this.rdioAdministrador.TabStop = true;
            this.rdioAdministrador.Text = "Administrador";
            this.rdioAdministrador.UseVisualStyleBackColor = true;
            // 
            // rdioExterno
            // 
            this.rdioExterno.AutoSize = true;
            this.rdioExterno.Location = new System.Drawing.Point(17, 73);
            this.rdioExterno.Name = "rdioExterno";
            this.rdioExterno.Size = new System.Drawing.Size(61, 17);
            this.rdioExterno.TabIndex = 100;
            this.rdioExterno.TabStop = true;
            this.rdioExterno.Text = "Externo";
            this.rdioExterno.UseVisualStyleBackColor = true;
            // 
            // rdioEmpleado
            // 
            this.rdioEmpleado.AutoSize = true;
            this.rdioEmpleado.Location = new System.Drawing.Point(17, 50);
            this.rdioEmpleado.Name = "rdioEmpleado";
            this.rdioEmpleado.Size = new System.Drawing.Size(72, 17);
            this.rdioEmpleado.TabIndex = 99;
            this.rdioEmpleado.TabStop = true;
            this.rdioEmpleado.Text = "Empleado";
            this.rdioEmpleado.UseVisualStyleBackColor = true;
            // 
            // lblRepetirContraseña
            // 
            this.lblRepetirContraseña.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRepetirContraseña.AutoSize = true;
            this.lblRepetirContraseña.Location = new System.Drawing.Point(201, 300);
            this.lblRepetirContraseña.Name = "lblRepetirContraseña";
            this.lblRepetirContraseña.Size = new System.Drawing.Size(97, 13);
            this.lblRepetirContraseña.TabIndex = 94;
            this.lblRepetirContraseña.Text = "Repetir contraseña";
            this.lblRepetirContraseña.Visible = false;
            // 
            // txtRepetirContraseña
            // 
            this.txtRepetirContraseña.Location = new System.Drawing.Point(304, 295);
            this.txtRepetirContraseña.Name = "txtRepetirContraseña";
            this.txtRepetirContraseña.PasswordChar = '*';
            this.txtRepetirContraseña.Size = new System.Drawing.Size(155, 20);
            this.txtRepetirContraseña.TabIndex = 93;
            this.txtRepetirContraseña.Visible = false;
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.Location = new System.Drawing.Point(203, 274);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(95, 13);
            this.lblNuevaContraseña.TabIndex = 92;
            this.lblNuevaContraseña.Text = "Nueva contraseña";
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(237, 242);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 91;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(255, 211);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 90;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtNuevaContraseña
            // 
            this.txtNuevaContraseña.Location = new System.Drawing.Point(304, 269);
            this.txtNuevaContraseña.Name = "txtNuevaContraseña";
            this.txtNuevaContraseña.PasswordChar = '*';
            this.txtNuevaContraseña.Size = new System.Drawing.Size(155, 20);
            this.txtNuevaContraseña.TabIndex = 89;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(304, 238);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(155, 20);
            this.txtContraseña.TabIndex = 88;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(304, 207);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(155, 20);
            this.txtUsuario.TabIndex = 87;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(304, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 20);
            this.txtEmail.TabIndex = 86;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(304, 145);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(155, 20);
            this.txtTelefono.TabIndex = 85;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(304, 114);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(155, 20);
            this.txtDireccion.TabIndex = 84;
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(304, 83);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(155, 20);
            this.txtCuil.TabIndex = 83;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(254, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 75;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCuil
            // 
            this.lblCuil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuil.AutoSize = true;
            this.lblCuil.Location = new System.Drawing.Point(274, 86);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(24, 13);
            this.lblCuil.TabIndex = 79;
            this.lblCuil.Text = "Cuil";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(249, 148);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 77;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(254, 56);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 76;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(246, 114);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 78;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(263, 177);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 80;
            this.lblEmail.Text = "E-mail";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(304, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 81;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(304, 52);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(155, 20);
            this.txtApellido.TabIndex = 82;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(358, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 37);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(228, 340);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 37);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmUsuarioABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 416);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuarioABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsuarioABM";
            this.Load += new System.EventHandler(this.frmUsuarioABM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbRol.ResumeLayout(false);
            this.gbRol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbRol;
        private System.Windows.Forms.RadioButton rdioAdministrador;
        private System.Windows.Forms.RadioButton rdioExterno;
        private System.Windows.Forms.RadioButton rdioEmpleado;
        protected System.Windows.Forms.Label lblRepetirContraseña;
        public System.Windows.Forms.TextBox txtRepetirContraseña;
        protected System.Windows.Forms.Label lblNuevaContraseña;
        protected System.Windows.Forms.Label lblContraseña;
        protected System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.TextBox txtNuevaContraseña;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtCuil;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Label lblCuil;
        public System.Windows.Forms.Label lblTelefono;
        protected System.Windows.Forms.Label lblApellido;
        protected System.Windows.Forms.Label lblDireccion;
        protected System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnGuardar;

    }
}