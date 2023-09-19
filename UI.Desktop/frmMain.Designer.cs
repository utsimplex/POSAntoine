namespace UI.Desktop
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msnPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesGeneralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditarMiUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprobantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpCOMPETOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirListasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockCríticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aReponerPorMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprobantesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCompletaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porArtículoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorizaciónDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaRápidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListaClientes = new System.Windows.Forms.Button();
            this.btnListaArticulos = new System.Windows.Forms.Button();
            this.btnListaProveedores = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.btnHistorialVentas = new System.Windows.Forms.Button();
            this.btnCerrarSistema = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblRolDeUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.NI = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCajas = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.scntCaja = new System.Windows.Forms.SplitContainer();
            this.txtCajaFecha = new System.Windows.Forms.TextBox();
            this.lblCajaFecha = new System.Windows.Forms.Label();
            this.txtCajaNro = new System.Windows.Forms.TextBox();
            this.lblNroCaja = new System.Windows.Forms.Label();
            this.lblCajaAbierta = new System.Windows.Forms.Label();
            this.lblCajaCerrada = new System.Windows.Forms.Label();
            this.btnAbrirCaja = new System.Windows.Forms.Button();
            this.btnCajaExtraer = new System.Windows.Forms.Button();
            this.btnCajaIngresar = new System.Windows.Forms.Button();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.configuracionesDeEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosDeLaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msnPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scntCaja)).BeginInit();
            this.scntCaja.Panel1.SuspendLayout();
            this.scntCaja.Panel2.SuspendLayout();
            this.scntCaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // msnPrincipal
            // 
            this.msnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.seguridadToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.ayudaToolStripMenuItem1,
            this.toolStripMenuItem1});
            this.msnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msnPrincipal.Name = "msnPrincipal";
            this.msnPrincipal.Size = new System.Drawing.Size(1107, 24);
            this.msnPrincipal.TabIndex = 0;
            this.msnPrincipal.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir,
            this.configuracionesGeneralesToolStripMenuItem,
            this.configuracionesDeEmpresaToolStripMenuItem});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(50, 20);
            this.mnuArchivo.Text = "Menu";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(225, 22);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // configuracionesGeneralesToolStripMenuItem
            // 
            this.configuracionesGeneralesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUsuarios,
            this.mnuEditarMiUsuario});
            this.configuracionesGeneralesToolStripMenuItem.Name = "configuracionesGeneralesToolStripMenuItem";
            this.configuracionesGeneralesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.configuracionesGeneralesToolStripMenuItem.Text = "Configuraciones generales";
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(163, 22);
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // mnuEditarMiUsuario
            // 
            this.mnuEditarMiUsuario.Name = "mnuEditarMiUsuario";
            this.mnuEditarMiUsuario.Size = new System.Drawing.Size(163, 22);
            this.mnuEditarMiUsuario.Text = "Editar mi usuario";
            this.mnuEditarMiUsuario.Click += new System.EventHandler(this.mnuEditarMiUsuario_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiaDeSeguridadToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // copiaDeSeguridadToolStripMenuItem
            // 
            this.copiaDeSeguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.comprobantesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.backUpCOMPETOToolStripMenuItem});
            this.copiaDeSeguridadToolStripMenuItem.Name = "copiaDeSeguridadToolStripMenuItem";
            this.copiaDeSeguridadToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.copiaDeSeguridadToolStripMenuItem.Text = "Crear Copia de Seguridad";
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.artículosToolStripMenuItem.Text = "Artículos";
            this.artículosToolStripMenuItem.Click += new System.EventHandler(this.artículosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // comprobantesToolStripMenuItem
            // 
            this.comprobantesToolStripMenuItem.Name = "comprobantesToolStripMenuItem";
            this.comprobantesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.comprobantesToolStripMenuItem.Text = "Comprobantes";
            this.comprobantesToolStripMenuItem.Click += new System.EventHandler(this.comprobantesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // backUpCOMPETOToolStripMenuItem
            // 
            this.backUpCOMPETOToolStripMenuItem.Name = "backUpCOMPETOToolStripMenuItem";
            this.backUpCOMPETOToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.backUpCOMPETOToolStripMenuItem.Text = "Back up COMPETO";
            this.backUpCOMPETOToolStripMenuItem.Click += new System.EventHandler(this.backUpCOMPETOToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emitirListasToolStripMenuItem,
            this.valorizaciónDeInventarioToolStripMenuItem,
            this.consultaRápidaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ayudaToolStripMenuItem.Text = "Informes";
            // 
            // emitirListasToolStripMenuItem
            // 
            this.emitirListasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículosToolStripMenuItem1,
            this.comprobantesToolStripMenuItem2});
            this.emitirListasToolStripMenuItem.Name = "emitirListasToolStripMenuItem";
            this.emitirListasToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.emitirListasToolStripMenuItem.Text = "Emitir listas";
            // 
            // artículosToolStripMenuItem1
            // 
            this.artículosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDePreciosToolStripMenuItem,
            this.stockCríticoToolStripMenuItem,
            this.aReponerPorMarcaToolStripMenuItem});
            this.artículosToolStripMenuItem1.Name = "artículosToolStripMenuItem1";
            this.artículosToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.artículosToolStripMenuItem1.Text = "Artículos";
            // 
            // listaDePreciosToolStripMenuItem
            // 
            this.listaDePreciosToolStripMenuItem.Name = "listaDePreciosToolStripMenuItem";
            this.listaDePreciosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.listaDePreciosToolStripMenuItem.Text = "Lista de Precios";
            this.listaDePreciosToolStripMenuItem.Click += new System.EventHandler(this.listaDePreciosToolStripMenuItem_Click);
            // 
            // stockCríticoToolStripMenuItem
            // 
            this.stockCríticoToolStripMenuItem.Name = "stockCríticoToolStripMenuItem";
            this.stockCríticoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.stockCríticoToolStripMenuItem.Text = "A reponer";
            this.stockCríticoToolStripMenuItem.Click += new System.EventHandler(this.stockCríticoToolStripMenuItem_Click);
            // 
            // aReponerPorMarcaToolStripMenuItem
            // 
            this.aReponerPorMarcaToolStripMenuItem.Name = "aReponerPorMarcaToolStripMenuItem";
            this.aReponerPorMarcaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.aReponerPorMarcaToolStripMenuItem.Text = "A reponer por Proveedor";
            this.aReponerPorMarcaToolStripMenuItem.Click += new System.EventHandler(this.aReponerPorMarcaToolStripMenuItem_Click);
            // 
            // comprobantesToolStripMenuItem2
            // 
            this.comprobantesToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaCompletaToolStripMenuItem1,
            this.porClienteToolStripMenuItem,
            this.porArtículoToolStripMenuItem1,
            this.porFechaToolStripMenuItem});
            this.comprobantesToolStripMenuItem2.Name = "comprobantesToolStripMenuItem2";
            this.comprobantesToolStripMenuItem2.Size = new System.Drawing.Size(153, 22);
            this.comprobantesToolStripMenuItem2.Text = "Comprobantes";
            // 
            // listaCompletaToolStripMenuItem1
            // 
            this.listaCompletaToolStripMenuItem1.Name = "listaCompletaToolStripMenuItem1";
            this.listaCompletaToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.listaCompletaToolStripMenuItem1.Text = "Lista Completa";
            this.listaCompletaToolStripMenuItem1.Click += new System.EventHandler(this.listaCompletaToolStripMenuItem1_Click);
            // 
            // porClienteToolStripMenuItem
            // 
            this.porClienteToolStripMenuItem.Name = "porClienteToolStripMenuItem";
            this.porClienteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.porClienteToolStripMenuItem.Text = "Por Artículo";
            this.porClienteToolStripMenuItem.Click += new System.EventHandler(this.porClienteToolStripMenuItem_Click);
            // 
            // porArtículoToolStripMenuItem1
            // 
            this.porArtículoToolStripMenuItem1.Name = "porArtículoToolStripMenuItem1";
            this.porArtículoToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.porArtículoToolStripMenuItem1.Text = "Por Cliente";
            this.porArtículoToolStripMenuItem1.Click += new System.EventHandler(this.porArtículoToolStripMenuItem1_Click);
            // 
            // porFechaToolStripMenuItem
            // 
            this.porFechaToolStripMenuItem.Name = "porFechaToolStripMenuItem";
            this.porFechaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.porFechaToolStripMenuItem.Text = "Por Fecha";
            this.porFechaToolStripMenuItem.Click += new System.EventHandler(this.porFechaToolStripMenuItem_Click);
            // 
            // valorizaciónDeInventarioToolStripMenuItem
            // 
            this.valorizaciónDeInventarioToolStripMenuItem.Name = "valorizaciónDeInventarioToolStripMenuItem";
            this.valorizaciónDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.valorizaciónDeInventarioToolStripMenuItem.Text = "Valorización de Inventario";
            this.valorizaciónDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.valorizaciónDeInventarioToolStripMenuItem_Click);
            // 
            // consultaRápidaToolStripMenuItem
            // 
            this.consultaRápidaToolStripMenuItem.Name = "consultaRápidaToolStripMenuItem";
            this.consultaRápidaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.consultaRápidaToolStripMenuItem.Text = "Consulta rápida";
            this.consultaRápidaToolStripMenuItem.Click += new System.EventHandler(this.consultaRápidaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.acercaDeToolStripMenuItem.Text = "Información del Software";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // btnListaClientes
            // 
            this.btnListaClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnListaClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnListaClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnListaClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnListaClientes.Image")));
            this.btnListaClientes.Location = new System.Drawing.Point(15, 344);
            this.btnListaClientes.Name = "btnListaClientes";
            this.btnListaClientes.Size = new System.Drawing.Size(124, 59);
            this.btnListaClientes.TabIndex = 2;
            this.btnListaClientes.Text = "Clientes";
            this.btnListaClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaClientes.UseVisualStyleBackColor = true;
            this.btnListaClientes.Click += new System.EventHandler(this.btnListaClientes_Click);
            // 
            // btnListaArticulos
            // 
            this.btnListaArticulos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnListaArticulos.Image = ((System.Drawing.Image)(resources.GetObject("btnListaArticulos.Image")));
            this.btnListaArticulos.Location = new System.Drawing.Point(15, 149);
            this.btnListaArticulos.Name = "btnListaArticulos";
            this.btnListaArticulos.Size = new System.Drawing.Size(124, 59);
            this.btnListaArticulos.TabIndex = 4;
            this.btnListaArticulos.Text = "Artículos";
            this.btnListaArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaArticulos.UseVisualStyleBackColor = true;
            this.btnListaArticulos.Click += new System.EventHandler(this.btnListaArticulos_Click);
            // 
            // btnListaProveedores
            // 
            this.btnListaProveedores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnListaProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnListaProveedores.Image")));
            this.btnListaProveedores.Location = new System.Drawing.Point(15, 279);
            this.btnListaProveedores.Name = "btnListaProveedores";
            this.btnListaProveedores.Size = new System.Drawing.Size(124, 59);
            this.btnListaProveedores.TabIndex = 6;
            this.btnListaProveedores.Text = "Proveedores";
            this.btnListaProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaProveedores.UseVisualStyleBackColor = true;
            this.btnListaProveedores.Click += new System.EventHandler(this.btnListaProveedores_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevaVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaVenta.Image")));
            this.btnNuevaVenta.Location = new System.Drawing.Point(15, 19);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(124, 59);
            this.btnNuevaVenta.TabIndex = 7;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // btnHistorialVentas
            // 
            this.btnHistorialVentas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHistorialVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorialVentas.Image")));
            this.btnHistorialVentas.Location = new System.Drawing.Point(15, 214);
            this.btnHistorialVentas.Name = "btnHistorialVentas";
            this.btnHistorialVentas.Size = new System.Drawing.Size(124, 59);
            this.btnHistorialVentas.TabIndex = 8;
            this.btnHistorialVentas.Text = "Historial de Ventas";
            this.btnHistorialVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorialVentas.UseVisualStyleBackColor = true;
            this.btnHistorialVentas.Click += new System.EventHandler(this.btnHistorialVentas_Click);
            // 
            // btnCerrarSistema
            // 
            this.btnCerrarSistema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSistema.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarSistema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCerrarSistema.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarSistema.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSistema.Image")));
            this.btnCerrarSistema.Location = new System.Drawing.Point(944, 602);
            this.btnCerrarSistema.Name = "btnCerrarSistema";
            this.btnCerrarSistema.Size = new System.Drawing.Size(151, 59);
            this.btnCerrarSistema.TabIndex = 9;
            this.btnCerrarSistema.Text = "Cerrar el sistema";
            this.btnCerrarSistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSistema.UseVisualStyleBackColor = true;
            this.btnCerrarSistema.Click += new System.EventHandler(this.btnCerrarSistema_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblRol);
            this.panel1.Controls.Add(this.lblRolDeUsuario);
            this.panel1.Controls.Add(this.lblNombreUsuario);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Location = new System.Drawing.Point(12, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 118);
            this.panel1.TabIndex = 11;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(118, 79);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(102, 36);
            this.btnCerrarSesion.TabIndex = 14;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(135, 63);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(70, 13);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Administrador";
            // 
            // lblRolDeUsuario
            // 
            this.lblRolDeUsuario.AutoSize = true;
            this.lblRolDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolDeUsuario.Location = new System.Drawing.Point(118, 44);
            this.lblRolDeUsuario.Name = "lblRolDeUsuario";
            this.lblRolDeUsuario.Size = new System.Drawing.Size(66, 17);
            this.lblRolDeUsuario.TabIndex = 2;
            this.lblRolDeUsuario.Text = "Permisos";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(135, 28);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(94, 13);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "NombreDeUsuario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(118, 8);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // NI
            // 
            this.NI.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NI.Icon = ((System.Drawing.Icon)(resources.GetObject("NI.Icon")));
            this.NI.Text = "POS - Ut Simplex ";
            this.NI.Visible = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevaVenta);
            this.groupBox1.Controls.Add(this.btnListaClientes);
            this.groupBox1.Controls.Add(this.btnListaArticulos);
            this.groupBox1.Controls.Add(this.btnCajas);
            this.groupBox1.Controls.Add(this.btnHistorialVentas);
            this.groupBox1.Controls.Add(this.btnListaProveedores);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 414);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú de Opciones";
            // 
            // btnCajas
            // 
            this.btnCajas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCajas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCajas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCajas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCajas.Image = global::UI.Desktop.Properties.Resources._3319627_coin_money_banking_transfer_dollar;
            this.btnCajas.Location = new System.Drawing.Point(15, 84);
            this.btnCajas.Name = "btnCajas";
            this.btnCajas.Size = new System.Drawing.Size(124, 59);
            this.btnCajas.TabIndex = 9;
            this.btnCajas.Text = "Cajas";
            this.btnCajas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCajas.UseVisualStyleBackColor = true;
            this.btnCajas.Click += new System.EventHandler(this.btnCajas_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.monthCalendar1.Location = new System.Drawing.Point(859, 383);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            // 
            // scntCaja
            // 
            this.scntCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scntCaja.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.scntCaja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scntCaja.Location = new System.Drawing.Point(873, 39);
            this.scntCaja.Name = "scntCaja";
            this.scntCaja.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scntCaja.Panel1
            // 
            this.scntCaja.Panel1.Controls.Add(this.txtCajaFecha);
            this.scntCaja.Panel1.Controls.Add(this.lblCajaFecha);
            this.scntCaja.Panel1.Controls.Add(this.txtCajaNro);
            this.scntCaja.Panel1.Controls.Add(this.lblNroCaja);
            this.scntCaja.Panel1.Controls.Add(this.lblCajaAbierta);
            this.scntCaja.Panel1.Controls.Add(this.lblCajaCerrada);
            // 
            // scntCaja.Panel2
            // 
            this.scntCaja.Panel2.Controls.Add(this.btnAbrirCaja);
            this.scntCaja.Panel2.Controls.Add(this.btnCajaExtraer);
            this.scntCaja.Panel2.Controls.Add(this.btnCajaIngresar);
            this.scntCaja.Panel2.Controls.Add(this.btnCerrarCaja);
            this.scntCaja.Size = new System.Drawing.Size(222, 273);
            this.scntCaja.SplitterDistance = 93;
            this.scntCaja.TabIndex = 4;
            // 
            // txtCajaFecha
            // 
            this.txtCajaFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCajaFecha.Enabled = false;
            this.txtCajaFecha.Location = new System.Drawing.Point(89, 69);
            this.txtCajaFecha.Name = "txtCajaFecha";
            this.txtCajaFecha.Size = new System.Drawing.Size(130, 20);
            this.txtCajaFecha.TabIndex = 16;
            this.txtCajaFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCajaFecha
            // 
            this.lblCajaFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCajaFecha.AutoSize = true;
            this.lblCajaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajaFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCajaFecha.Location = new System.Drawing.Point(26, 70);
            this.lblCajaFecha.Name = "lblCajaFecha";
            this.lblCajaFecha.Size = new System.Drawing.Size(57, 17);
            this.lblCajaFecha.TabIndex = 15;
            this.lblCajaFecha.Text = "Fecha:";
            this.lblCajaFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCajaNro
            // 
            this.txtCajaNro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCajaNro.Enabled = false;
            this.txtCajaNro.Location = new System.Drawing.Point(89, 43);
            this.txtCajaNro.Name = "txtCajaNro";
            this.txtCajaNro.Size = new System.Drawing.Size(130, 20);
            this.txtCajaNro.TabIndex = 14;
            this.txtCajaNro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNroCaja
            // 
            this.lblNroCaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNroCaja.AutoSize = true;
            this.lblNroCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNroCaja.Location = new System.Drawing.Point(3, 44);
            this.lblNroCaja.Name = "lblNroCaja";
            this.lblNroCaja.Size = new System.Drawing.Size(86, 17);
            this.lblNroCaja.TabIndex = 11;
            this.lblNroCaja.Text = "Nro. Caja: ";
            this.lblNroCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCajaAbierta
            // 
            this.lblCajaAbierta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCajaAbierta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajaAbierta.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblCajaAbierta.Location = new System.Drawing.Point(3, 2);
            this.lblCajaAbierta.Name = "lblCajaAbierta";
            this.lblCajaAbierta.Size = new System.Drawing.Size(216, 36);
            this.lblCajaAbierta.TabIndex = 1;
            this.lblCajaAbierta.Text = "Caja abierta";
            this.lblCajaAbierta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCajaAbierta.Visible = false;
            // 
            // lblCajaCerrada
            // 
            this.lblCajaCerrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCajaCerrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajaCerrada.ForeColor = System.Drawing.Color.Tomato;
            this.lblCajaCerrada.Location = new System.Drawing.Point(3, 2);
            this.lblCajaCerrada.Name = "lblCajaCerrada";
            this.lblCajaCerrada.Size = new System.Drawing.Size(216, 36);
            this.lblCajaCerrada.TabIndex = 0;
            this.lblCajaCerrada.Text = "Caja cerrada";
            this.lblCajaCerrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAbrirCaja
            // 
            this.btnAbrirCaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirCaja.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbrirCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAbrirCaja.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbrirCaja.Image = global::UI.Desktop.Properties.Resources._3387295_shopping_finance_payment_machine_credit;
            this.btnAbrirCaja.Location = new System.Drawing.Point(3, 3);
            this.btnAbrirCaja.Name = "btnAbrirCaja";
            this.btnAbrirCaja.Size = new System.Drawing.Size(216, 47);
            this.btnAbrirCaja.TabIndex = 13;
            this.btnAbrirCaja.Text = "Abrir caja";
            this.btnAbrirCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirCaja.UseVisualStyleBackColor = true;
            this.btnAbrirCaja.Click += new System.EventHandler(this.btnAbrirCaja_Click);
            // 
            // btnCajaExtraer
            // 
            this.btnCajaExtraer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCajaExtraer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCajaExtraer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCajaExtraer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCajaExtraer.Image = global::UI.Desktop.Properties.Resources.back32;
            this.btnCajaExtraer.Location = new System.Drawing.Point(3, 64);
            this.btnCajaExtraer.Name = "btnCajaExtraer";
            this.btnCajaExtraer.Size = new System.Drawing.Size(216, 47);
            this.btnCajaExtraer.TabIndex = 15;
            this.btnCajaExtraer.Text = "Extraer $";
            this.btnCajaExtraer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCajaExtraer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCajaExtraer.UseVisualStyleBackColor = true;
            this.btnCajaExtraer.Click += new System.EventHandler(this.btnCajaExtraer_Click);
            // 
            // btnCajaIngresar
            // 
            this.btnCajaIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCajaIngresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCajaIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCajaIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCajaIngresar.Image = global::UI.Desktop.Properties.Resources.forward32;
            this.btnCajaIngresar.Location = new System.Drawing.Point(3, 11);
            this.btnCajaIngresar.Name = "btnCajaIngresar";
            this.btnCajaIngresar.Size = new System.Drawing.Size(216, 47);
            this.btnCajaIngresar.TabIndex = 14;
            this.btnCajaIngresar.Text = "Ingresar $";
            this.btnCajaIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCajaIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCajaIngresar.UseVisualStyleBackColor = true;
            this.btnCajaIngresar.Click += new System.EventHandler(this.btnCajaIngresar_Click);
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarCaja.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCerrarCaja.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarCaja.Image = global::UI.Desktop.Properties.Resources.close_24;
            this.btnCerrarCaja.Location = new System.Drawing.Point(3, 117);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(216, 47);
            this.btnCerrarCaja.TabIndex = 10;
            this.btnCerrarCaja.Text = "Cerrar caja";
            this.btnCerrarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarCaja.UseVisualStyleBackColor = true;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
         
            // 
            // configuracionesDeEmpresaToolStripMenuItem
            // 
            this.configuracionesDeEmpresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrosDeLaEmpresaToolStripMenuItem});
            this.configuracionesDeEmpresaToolStripMenuItem.Name = "configuracionesDeEmpresaToolStripMenuItem";
            this.configuracionesDeEmpresaToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.configuracionesDeEmpresaToolStripMenuItem.Text = "Configuraciones de Empresa";
            // 
            // parametrosDeLaEmpresaToolStripMenuItem
            // 
            this.parametrosDeLaEmpresaToolStripMenuItem.Name = "parametrosDeLaEmpresaToolStripMenuItem";
            this.parametrosDeLaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.parametrosDeLaEmpresaToolStripMenuItem.Text = "Parametros de la Empresa";
            this.parametrosDeLaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.parametrosDeLaEmpresaToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::UI.Desktop.Properties.Resources.fondoAntoineBlack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1107, 673);
           
            this.Controls.Add(this.scntCaja);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrarSistema);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.msnPrincipal);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msnPrincipal;
            this.Name = "frmMain";
            this.Text = "utsimplex - Antoine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msnPrincipal.ResumeLayout(false);
            this.msnPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.scntCaja.Panel1.ResumeLayout(false);
            this.scntCaja.Panel1.PerformLayout();
            this.scntCaja.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scntCaja)).EndInit();
            this.scntCaja.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiaDeSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprobantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirListasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listaDePreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpCOMPETOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockCríticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprobantesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listaCompletaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porArtículoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btnListaClientes;
        private System.Windows.Forms.Button btnListaArticulos;
        private System.Windows.Forms.Button btnListaProveedores;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Button btnHistorialVentas;
        private System.Windows.Forms.Button btnCerrarSistema;
        private System.Windows.Forms.ToolStripMenuItem configuracionesGeneralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblRolDeUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuEditarMiUsuario;
        private System.Windows.Forms.ToolStripMenuItem valorizaciónDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aReponerPorMarcaToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon NI;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaRápidaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnCajas;
        private System.Windows.Forms.Label lblCajaCerrada;
        private System.Windows.Forms.SplitContainer scntCaja;
        private System.Windows.Forms.Label lblCajaAbierta;
        private System.Windows.Forms.Label lblNroCaja;
        private System.Windows.Forms.Button btnCerrarCaja;
        private System.Windows.Forms.Button btnAbrirCaja;
        private System.Windows.Forms.Label lblCajaFecha;
        private System.Windows.Forms.TextBox txtCajaNro;
        private System.Windows.Forms.Button btnCajaExtraer;
        private System.Windows.Forms.Button btnCajaIngresar;
        private System.Windows.Forms.TextBox txtCajaFecha;
        private System.Windows.Forms.ToolStripMenuItem configuracionesDeEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosDeLaEmpresaToolStripMenuItem;
    }
}

