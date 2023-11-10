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
            this.cargarCódigosDeBarraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesDeEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosDeLaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lblPerfil = new MaterialSkin.Controls.MaterialLabel();
            this.lblUserRole = new MaterialSkin.Controls.MaterialLabel();
            this.btnCerrarSesion = new MaterialSkin.Controls.MaterialButton();
            this.NI = new System.Windows.Forms.NotifyIcon(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtCajaFecha = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCajaNro = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCajaExtraer = new MaterialSkin.Controls.MaterialButton();
            this.btnCajaIngresar = new MaterialSkin.Controls.MaterialButton();
            this.panelTabla = new System.Windows.Forms.TableLayoutPanel();
            this.btnCerrarSistema = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnListaClientes = new MaterialSkin.Controls.MaterialButton();
            this.btnListaProveedores = new MaterialSkin.Controls.MaterialButton();
            this.btnHistorialVentas = new MaterialSkin.Controls.MaterialButton();
            this.btnListaArticulos = new MaterialSkin.Controls.MaterialButton();
            this.btnCajas = new MaterialSkin.Controls.MaterialButton();
            this.btnVentaNueva = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtxtNombreUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lblNroCaja = new MaterialSkin.Controls.MaterialLabel();
            this.swAbrirCerrarCaja = new MaterialSkin.Controls.MaterialSwitch();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.msnPrincipal.SuspendLayout();
            this.panelTabla.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.msnPrincipal.Location = new System.Drawing.Point(3, 64);
            this.msnPrincipal.Name = "msnPrincipal";
            this.msnPrincipal.Size = new System.Drawing.Size(1195, 24);
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
            this.mnuEditarMiUsuario,
            this.cargarCódigosDeBarraToolStripMenuItem});
            this.configuracionesGeneralesToolStripMenuItem.Name = "configuracionesGeneralesToolStripMenuItem";
            this.configuracionesGeneralesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.configuracionesGeneralesToolStripMenuItem.Text = "Configuraciones generales";
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(200, 22);
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // mnuEditarMiUsuario
            // 
            this.mnuEditarMiUsuario.Name = "mnuEditarMiUsuario";
            this.mnuEditarMiUsuario.Size = new System.Drawing.Size(200, 22);
            this.mnuEditarMiUsuario.Text = "Editar mi usuario";
            this.mnuEditarMiUsuario.Click += new System.EventHandler(this.mnuEditarMiUsuario_Click);
            // 
            // cargarCódigosDeBarraToolStripMenuItem
            // 
            this.cargarCódigosDeBarraToolStripMenuItem.Name = "cargarCódigosDeBarraToolStripMenuItem";
            this.cargarCódigosDeBarraToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cargarCódigosDeBarraToolStripMenuItem.Text = "Cargar códigos de barra";
            this.cargarCódigosDeBarraToolStripMenuItem.Click += new System.EventHandler(this.cargarCódigosDeBarraToolStripMenuItem_Click);
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
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiaDeSeguridadToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            this.seguridadToolStripMenuItem.Visible = false;
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
            this.copiaDeSeguridadToolStripMenuItem.Visible = false;
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
            // lblPerfil
            // 
            this.lblPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Depth = 0;
            this.lblPerfil.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPerfil.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.lblPerfil.Location = new System.Drawing.Point(4, 240);
            this.lblPerfil.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(24, 13);
            this.lblPerfil.TabIndex = 17;
            this.lblPerfil.Text = "Perfil:";
            this.lblPerfil.UseAccent = true;
            // 
            // lblUserRole
            // 
            this.lblUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Depth = 0;
            this.lblUserRole.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserRole.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.lblUserRole.Location = new System.Drawing.Point(34, 239);
            this.lblUserRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(64, 13);
            this.lblUserRole.TabIndex = 16;
            this.lblUserRole.Text = "Administrador";
            this.lblUserRole.UseAccent = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.AutoSize = false;
            this.btnCerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.HighEmphasis = true;
            this.btnCerrarSesion.Icon = null;
            this.btnCerrarSesion.Location = new System.Drawing.Point(5, 151);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCerrarSesion.Size = new System.Drawing.Size(165, 41);
            this.btnCerrarSesion.TabIndex = 15;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrarSesion.UseAccentColor = true;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // NI
            // 
            this.NI.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NI.Icon = ((System.Drawing.Icon)(resources.GetObject("NI.Icon")));
            this.NI.Text = "POS - Ut Simplex ";
            this.NI.Visible = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(940, 433);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            // 
            // txtCajaFecha
            // 
            this.txtCajaFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCajaFecha.AnimateReadOnly = false;
            this.txtCajaFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCajaFecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCajaFecha.Depth = 0;
            this.txtCajaFecha.Enabled = false;
            this.txtCajaFecha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCajaFecha.Hint = "Fecha";
            this.txtCajaFecha.LeadingIcon = null;
            this.txtCajaFecha.Location = new System.Drawing.Point(8, 91);
            this.txtCajaFecha.MaxLength = 50;
            this.txtCajaFecha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCajaFecha.Multiline = false;
            this.txtCajaFecha.Name = "txtCajaFecha";
            this.txtCajaFecha.Size = new System.Drawing.Size(212, 36);
            this.txtCajaFecha.TabIndex = 16;
            this.txtCajaFecha.Text = "";
            this.txtCajaFecha.TrailingIcon = null;
            this.txtCajaFecha.UseTallSize = false;
            // 
            // txtCajaNro
            // 
            this.txtCajaNro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCajaNro.AnimateReadOnly = false;
            this.txtCajaNro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCajaNro.Depth = 0;
            this.txtCajaNro.Enabled = false;
            this.txtCajaNro.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCajaNro.Hint = "01234";
            this.txtCajaNro.LeadingIcon = null;
            this.txtCajaNro.Location = new System.Drawing.Point(80, 49);
            this.txtCajaNro.MaxLength = 50;
            this.txtCajaNro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCajaNro.Multiline = false;
            this.txtCajaNro.Name = "txtCajaNro";
            this.txtCajaNro.Size = new System.Drawing.Size(140, 36);
            this.txtCajaNro.TabIndex = 14;
            this.txtCajaNro.Text = "";
            this.txtCajaNro.TrailingIcon = null;
            this.txtCajaNro.UseTallSize = false;
            // 
            // btnCajaExtraer
            // 
            this.btnCajaExtraer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCajaExtraer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCajaExtraer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCajaExtraer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCajaExtraer.Depth = 0;
            this.btnCajaExtraer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCajaExtraer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCajaExtraer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCajaExtraer.HighEmphasis = true;
            this.btnCajaExtraer.Icon = global::UI.Desktop.Properties.Resources.back32;
            this.btnCajaExtraer.Location = new System.Drawing.Point(4, 51);
            this.btnCajaExtraer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCajaExtraer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCajaExtraer.Name = "btnCajaExtraer";
            this.btnCajaExtraer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCajaExtraer.Size = new System.Drawing.Size(204, 36);
            this.btnCajaExtraer.TabIndex = 15;
            this.btnCajaExtraer.Text = "Extraer $";
            this.btnCajaExtraer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCajaExtraer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCajaExtraer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCajaExtraer.UseAccentColor = false;
            this.btnCajaExtraer.UseVisualStyleBackColor = true;
            this.btnCajaExtraer.Click += new System.EventHandler(this.btnCajaExtraer_Click);
            // 
            // btnCajaIngresar
            // 
            this.btnCajaIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCajaIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCajaIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCajaIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCajaIngresar.Depth = 0;
            this.btnCajaIngresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCajaIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCajaIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCajaIngresar.HighEmphasis = true;
            this.btnCajaIngresar.Icon = global::UI.Desktop.Properties.Resources.forward32;
            this.btnCajaIngresar.Location = new System.Drawing.Point(4, 6);
            this.btnCajaIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCajaIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCajaIngresar.Name = "btnCajaIngresar";
            this.btnCajaIngresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCajaIngresar.Size = new System.Drawing.Size(204, 33);
            this.btnCajaIngresar.TabIndex = 14;
            this.btnCajaIngresar.Text = "Ingresar $";
            this.btnCajaIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCajaIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCajaIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCajaIngresar.UseAccentColor = false;
            this.btnCajaIngresar.UseVisualStyleBackColor = true;
            this.btnCajaIngresar.Click += new System.EventHandler(this.btnCajaIngresar_Click);
            // 
            // panelTabla
            // 
            this.panelTabla.BackColor = System.Drawing.Color.Transparent;
            this.panelTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelTabla.ColumnCount = 8;
            this.panelTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.panelTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.panelTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.panelTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.panelTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.panelTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.panelTabla.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.panelTabla.Controls.Add(this.btnCerrarSistema, 7, 26);
            this.panelTabla.Controls.Add(this.monthCalendar1, 6, 17);
            this.panelTabla.Controls.Add(this.materialCard1, 0, 0);
            this.panelTabla.Controls.Add(this.materialCard2, 6, 0);
            this.panelTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabla.Location = new System.Drawing.Point(3, 88);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.RowCount = 29;
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.81395F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.18605F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTabla.Size = new System.Drawing.Size(1195, 665);
            this.panelTabla.TabIndex = 14;
            // 
            // btnCerrarSistema
            // 
            this.btnCerrarSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSistema.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSistema.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrarSistema.Depth = 0;
            this.btnCerrarSistema.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrarSistema.HighEmphasis = true;
            this.btnCerrarSistema.Icon = null;
            this.btnCerrarSistema.Location = new System.Drawing.Point(1045, 611);
            this.btnCerrarSistema.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrarSistema.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSistema.Name = "btnCerrarSistema";
            this.btnCerrarSistema.NoAccentTextColor = System.Drawing.Color.Empty;
            this.panelTabla.SetRowSpan(this.btnCerrarSistema, 2);
            this.btnCerrarSistema.Size = new System.Drawing.Size(146, 36);
            this.btnCerrarSistema.TabIndex = 16;
            this.btnCerrarSistema.Text = "Cerrar el sistema";
            this.btnCerrarSistema.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrarSistema.UseAccentColor = true;
            this.btnCerrarSistema.UseVisualStyleBackColor = true;
            this.btnCerrarSistema.Click += new System.EventHandler(this.btnCerrarSistema_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelTabla.SetColumnSpan(this.materialCard1, 2);
            this.materialCard1.Controls.Add(this.tableLayoutPanel2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.panelTabla.SetRowSpan(this.materialCard1, 28);
            this.materialCard1.Size = new System.Drawing.Size(207, 626);
            this.materialCard1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnListaClientes, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnListaProveedores, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnHistorialVentas, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnListaArticulos, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnCajas, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnVentaNueva, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 7);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(179, 595);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(3, 7);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(119, 17);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Menú de Opciones";
            // 
            // btnListaClientes
            // 
            this.btnListaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListaClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListaClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaClientes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnListaClientes.Depth = 0;
            this.btnListaClientes.HighEmphasis = true;
            this.btnListaClientes.Icon = null;
            this.btnListaClientes.Location = new System.Drawing.Point(4, 287);
            this.btnListaClientes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListaClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListaClientes.Name = "btnListaClientes";
            this.btnListaClientes.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnListaClientes.Size = new System.Drawing.Size(171, 36);
            this.btnListaClientes.TabIndex = 5;
            this.btnListaClientes.Text = "Clientes";
            this.btnListaClientes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnListaClientes.UseAccentColor = false;
            this.btnListaClientes.UseVisualStyleBackColor = true;
            this.btnListaClientes.Click += new System.EventHandler(this.btnListaClientes_Click);
            // 
            // btnListaProveedores
            // 
            this.btnListaProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListaProveedores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListaProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaProveedores.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnListaProveedores.Depth = 0;
            this.btnListaProveedores.HighEmphasis = true;
            this.btnListaProveedores.Icon = null;
            this.btnListaProveedores.Location = new System.Drawing.Point(4, 237);
            this.btnListaProveedores.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListaProveedores.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListaProveedores.Name = "btnListaProveedores";
            this.btnListaProveedores.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnListaProveedores.Size = new System.Drawing.Size(171, 36);
            this.btnListaProveedores.TabIndex = 4;
            this.btnListaProveedores.Text = "Proveedores";
            this.btnListaProveedores.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnListaProveedores.UseAccentColor = false;
            this.btnListaProveedores.UseVisualStyleBackColor = true;
            this.btnListaProveedores.Click += new System.EventHandler(this.btnListaProveedores_Click);
            // 
            // btnHistorialVentas
            // 
            this.btnHistorialVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistorialVentas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHistorialVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialVentas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHistorialVentas.Depth = 0;
            this.btnHistorialVentas.HighEmphasis = true;
            this.btnHistorialVentas.Icon = null;
            this.btnHistorialVentas.Location = new System.Drawing.Point(4, 187);
            this.btnHistorialVentas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHistorialVentas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHistorialVentas.Name = "btnHistorialVentas";
            this.btnHistorialVentas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHistorialVentas.Size = new System.Drawing.Size(171, 36);
            this.btnHistorialVentas.TabIndex = 3;
            this.btnHistorialVentas.Text = "Historial de Ventas";
            this.btnHistorialVentas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHistorialVentas.UseAccentColor = false;
            this.btnHistorialVentas.UseVisualStyleBackColor = true;
            this.btnHistorialVentas.Click += new System.EventHandler(this.btnHistorialVentas_Click);
            // 
            // btnListaArticulos
            // 
            this.btnListaArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListaArticulos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListaArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListaArticulos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnListaArticulos.Depth = 0;
            this.btnListaArticulos.HighEmphasis = true;
            this.btnListaArticulos.Icon = null;
            this.btnListaArticulos.Location = new System.Drawing.Point(4, 137);
            this.btnListaArticulos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListaArticulos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListaArticulos.Name = "btnListaArticulos";
            this.btnListaArticulos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnListaArticulos.Size = new System.Drawing.Size(171, 36);
            this.btnListaArticulos.TabIndex = 2;
            this.btnListaArticulos.Text = "Articulos";
            this.btnListaArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaArticulos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnListaArticulos.UseAccentColor = false;
            this.btnListaArticulos.UseVisualStyleBackColor = true;
            this.btnListaArticulos.Click += new System.EventHandler(this.btnListaArticulos_Click);
            // 
            // btnCajas
            // 
            this.btnCajas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCajas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCajas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCajas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCajas.Depth = 0;
            this.btnCajas.HighEmphasis = true;
            this.btnCajas.Icon = null;
            this.btnCajas.Location = new System.Drawing.Point(4, 87);
            this.btnCajas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCajas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCajas.Name = "btnCajas";
            this.btnCajas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCajas.Size = new System.Drawing.Size(171, 36);
            this.btnCajas.TabIndex = 1;
            this.btnCajas.Text = "Cajas";
            this.btnCajas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCajas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCajas.UseAccentColor = false;
            this.btnCajas.UseVisualStyleBackColor = true;
            this.btnCajas.Click += new System.EventHandler(this.btnCajas_Click);
            // 
            // btnVentaNueva
            // 
            this.btnVentaNueva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVentaNueva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVentaNueva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentaNueva.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVentaNueva.Depth = 0;
            this.btnVentaNueva.HighEmphasis = true;
            this.btnVentaNueva.Icon = global::UI.Desktop.Properties.Resources.Add_32x32;
            this.btnVentaNueva.Location = new System.Drawing.Point(4, 37);
            this.btnVentaNueva.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVentaNueva.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVentaNueva.Name = "btnVentaNueva";
            this.btnVentaNueva.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVentaNueva.Size = new System.Drawing.Size(171, 36);
            this.btnVentaNueva.TabIndex = 0;
            this.btnVentaNueva.Text = "Nueva Venta";
            this.btnVentaNueva.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVentaNueva.UseAccentColor = false;
            this.btnVentaNueva.UseVisualStyleBackColor = true;
            this.btnVentaNueva.Click += new System.EventHandler(this.btnVentaNueva_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.lblUserRole);
            this.panel1.Controls.Add(this.mtxtNombreUsuario);
            this.panel1.Controls.Add(this.lblPerfil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 258);
            this.panel1.TabIndex = 16;
            // 
            // mtxtNombreUsuario
            // 
            this.mtxtNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtNombreUsuario.AnimateReadOnly = false;
            this.mtxtNombreUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtxtNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mtxtNombreUsuario.Cursor = System.Windows.Forms.Cursors.Help;
            this.mtxtNombreUsuario.Depth = 0;
            this.mtxtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtNombreUsuario.HelperText = "Usuario";
            this.mtxtNombreUsuario.HideSelection = true;
            this.mtxtNombreUsuario.LeadingIcon = global::UI.Desktop.Properties.Resources.User_32x32;
            this.mtxtNombreUsuario.Location = new System.Drawing.Point(5, 201);
            this.mtxtNombreUsuario.MaxLength = 32767;
            this.mtxtNombreUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.mtxtNombreUsuario.Name = "mtxtNombreUsuario";
            this.mtxtNombreUsuario.PasswordChar = '\0';
            this.mtxtNombreUsuario.PrefixSuffixText = null;
            this.mtxtNombreUsuario.ReadOnly = true;
            this.mtxtNombreUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtNombreUsuario.SelectedText = "";
            this.mtxtNombreUsuario.SelectionLength = 0;
            this.mtxtNombreUsuario.SelectionStart = 0;
            this.mtxtNombreUsuario.ShortcutsEnabled = true;
            this.mtxtNombreUsuario.Size = new System.Drawing.Size(165, 36);
            this.mtxtNombreUsuario.TabIndex = 18;
            this.mtxtNombreUsuario.TabStop = false;
            this.mtxtNombreUsuario.Text = "username";
            this.mtxtNombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtNombreUsuario.TrailingIcon = null;
            this.mtxtNombreUsuario.UseSystemPasswordChar = false;
            this.mtxtNombreUsuario.UseTallSize = false;
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelTabla.SetColumnSpan(this.materialCard2, 2);
            this.materialCard2.Controls.Add(this.lblNroCaja);
            this.materialCard2.Controls.Add(this.swAbrirCerrarCaja);
            this.materialCard2.Controls.Add(this.txtCajaFecha);
            this.materialCard2.Controls.Add(this.tableLayoutPanel3);
            this.materialCard2.Controls.Add(this.txtCajaNro);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(953, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.panelTabla.SetRowSpan(this.materialCard2, 15);
            this.materialCard2.Size = new System.Drawing.Size(228, 249);
            this.materialCard2.TabIndex = 15;
            // 
            // lblNroCaja
            // 
            this.lblNroCaja.AutoSize = true;
            this.lblNroCaja.Depth = 0;
            this.lblNroCaja.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNroCaja.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblNroCaja.Location = new System.Drawing.Point(10, 61);
            this.lblNroCaja.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNroCaja.Name = "lblNroCaja";
            this.lblNroCaja.Size = new System.Drawing.Size(64, 17);
            this.lblNroCaja.TabIndex = 18;
            this.lblNroCaja.Text = "Nro. Caja:";
            // 
            // swAbrirCerrarCaja
            // 
            this.swAbrirCerrarCaja.Appearance = System.Windows.Forms.Appearance.Button;
            this.swAbrirCerrarCaja.AutoSize = true;
            this.swAbrirCerrarCaja.BackColor = System.Drawing.Color.Transparent;
            this.swAbrirCerrarCaja.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.swAbrirCerrarCaja.Checked = true;
            this.swAbrirCerrarCaja.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.swAbrirCerrarCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swAbrirCerrarCaja.Depth = 0;
            this.swAbrirCerrarCaja.Location = new System.Drawing.Point(8, 12);
            this.swAbrirCerrarCaja.Margin = new System.Windows.Forms.Padding(0);
            this.swAbrirCerrarCaja.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swAbrirCerrarCaja.MouseState = MaterialSkin.MouseState.HOVER;
            this.swAbrirCerrarCaja.Name = "swAbrirCerrarCaja";
            this.swAbrirCerrarCaja.Ripple = true;
            this.swAbrirCerrarCaja.Size = new System.Drawing.Size(127, 37);
            this.swAbrirCerrarCaja.TabIndex = 17;
            this.swAbrirCerrarCaja.Text = "Abrir Caja";
            this.swAbrirCerrarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.swAbrirCerrarCaja.UseVisualStyleBackColor = false;
            this.swAbrirCerrarCaja.Click += new System.EventHandler(this.swAbrirCerrarCaja_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnCajaIngresar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnCajaExtraer, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 135);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(212, 97);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::UI.Desktop.Properties.Resources.fondoAntoineBlack2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1201, 756);
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.msnPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msnPrincipal;
            this.Name = "frmMain";
            this.Text = "utsimplex - POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msnPrincipal.ResumeLayout(false);
            this.msnPrincipal.PerformLayout();
            this.panelTabla.ResumeLayout(false);
            this.panelTabla.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem configuracionesGeneralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuEditarMiUsuario;
        private System.Windows.Forms.ToolStripMenuItem valorizaciónDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aReponerPorMarcaToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon NI;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaRápidaToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MaterialSkin.Controls.MaterialTextBox txtCajaNro;
        private MaterialSkin.Controls.MaterialTextBox txtCajaFecha;
        private System.Windows.Forms.ToolStripMenuItem configuracionesDeEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosDeLaEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarCódigosDeBarraToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel panelTabla;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton btnVentaNueva;
        private MaterialSkin.Controls.MaterialButton btnCajas;
        private MaterialSkin.Controls.MaterialButton btnListaArticulos;
        private MaterialSkin.Controls.MaterialButton btnHistorialVentas;
        private MaterialSkin.Controls.MaterialButton btnListaProveedores;
        private MaterialSkin.Controls.MaterialButton btnListaClientes;
        private MaterialSkin.Controls.MaterialButton btnCerrarSesion;
        private MaterialSkin.Controls.MaterialLabel lblUserRole;
        private MaterialSkin.Controls.MaterialLabel lblPerfil;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnCerrarSistema;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialSwitch swAbrirCerrarCaja;
        private MaterialSkin.Controls.MaterialLabel lblNroCaja;
        private MaterialSkin.Controls.MaterialButton btnCajaExtraer;
        private MaterialSkin.Controls.MaterialButton btnCajaIngresar;
        private MaterialSkin.Controls.MaterialTextBox2 mtxtNombreUsuario;
        private System.Windows.Forms.Panel panel1;
    }
}

