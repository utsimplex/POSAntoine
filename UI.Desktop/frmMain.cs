using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop;
using System.Threading;
using UI.Desktop.Cajas;
using UI.Desktop.Artículos;
using Entidades;
using Data.Database;
using System.Reflection;
using MaterialSkin.Controls;
using MaterialSkin;

namespace UI.Desktop
{
    public partial class frmMain : MaterialForm
    {
        #region PROPIEDADES Y ENUMERADORES

        TipoForm _modoForm;

        public TipoForm ModoForm
        {
            get { return _modoForm; }
            set { _modoForm = value; }
        }

        public enum TipoForm
        {
            Alta,
            Edicion

        }
        
        #endregion

        public frmMain()
        {
            //Thread tardar = new Thread(new ThreadStart(pantalla));
            //tardar.Start();
            //Thread.Sleep(3500);

            InitializeComponent();
            //tardar.Abort();
            AplicarMaterialTheme();
            parametrosEmpresaController = ParametrosEmpresaController.GetInstance();
            parametrosEmpresa = parametrosEmpresaController.ObtenerParametrosEmpresa();
        }


        private void AplicarMaterialTheme()
        {

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            //Lila y Naranja (BASIC DARK)
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.DeepOrange400, TextShade.WHITE);

            // Lila y Rojenta
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Red400, TextShade.WHITE);

            //Verde y Salmón (INHALA)
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal300, Primary.Teal600, Primary.Teal100, Accent.Green700, TextShade.WHITE);

            // Lila y Verde
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple500, Primary.DeepPurple700, Primary.DeepPurple100, Accent.Green400, TextShade.WHITE);

            //Lila y Amarillo Oscuro/Naranja
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple500, Primary.DeepPurple700, Primary.DeepPurple100, Accent.Amber700, TextShade.WHITE);

            // Rosa y Turquesa
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple500, Primary.Purple700, Primary.Purple100, Accent.Teal700, TextShade.WHITE);

            // UtSimplex Theme 1
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.LightBlue200, TextShade.WHITE);


        }

        public void pantalla()
        {
            // SPLASH SCREEN
            Application.Run(new UI.Desktop.Mensajes.splashScreen());
        }

        // VARIABLES
        public Entidades.Usuario usrActual = null;
        public Entidades.Caja cajaActual = null;
        Data.Database.ClienteAdapter Datos_ClienteAdapter = new Data.Database.ClienteAdapter();
        Data.Database.UsuarioAdapter Datos_UsuarioAdapter = new Data.Database.UsuarioAdapter();
        Data.Database.InformeArticulos Datos_InformeArticulosAdapter = new Data.Database.InformeArticulos();
        Data.Database.ArticuloAdapter Datos_ArticulosAdapter = new Data.Database.ArticuloAdapter();
        Data.Database.CajasAdapter Datos_CajasAdapter = new Data.Database.CajasAdapter();


        ParametrosEmpresaController parametrosEmpresaController;
        ParametrosEmpresa parametrosEmpresa;

        // EVENTO LOAD
        private void frmMain_Load(object sender, EventArgs e)
        {
            bindUINoUser();

            this.Visible = false;
            if(this.parametrosEmpresa.FondoPantalla != null && this.parametrosEmpresa.FondoPantalla != "")
            {
                this.panelTabla.BackgroundImage = Image.FromFile(this.parametrosEmpresa.FondoPantalla);
                //this.BackgroundImage = Image.FromFile(this.parametrosEmpresa.FondoPantalla);
            }
            IniciarSesion();

            if (usrActual != null)
            {
                 //bindUIUsuario();
                
            }
            else
            {
                this.Close();
            }


            

            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
         

            this.Text = "utsimplex - POS - Version: "+ version;
        }

        // INICIAR SESION
        private Entidades.Usuario IniciarSesion()
        {
            
            frmLogin appLogin = new frmLogin();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                bindUINoUser();
                this.Dispose();
                return null;
            }
            else
            {
                usrActual = appLogin.usrActual;
                InicializarCaja();
                bindUIUsuario();
                this.Visible = true;
                return appLogin.usrActual;
                
            }


        }

        // Bind UI No User
        private void bindUINoUser()
        {
            NI.BalloonTipIcon = ToolTipIcon.Info;
            NI.BalloonTipText = "- PUNTO DE VENTA -";
            NI.BalloonTipTitle = "Ut Simplex";
            NI.Visible = true;
            NI.ContextMenu = this.ContextMenu;

            NI.ShowBalloonTip(100);
            mtxtNombreUsuario.Text = "";
            lblUserRole.Text = "";
        }
        
        // Bind UI Usuario
        private void bindUIUsuario()
        {

            mtxtNombreUsuario.Text = usrActual.usuario;
            lblUserRole.Text = usrActual.Rol;
            if (usrActual.Rol == "Empleado")
            { mnuUsuarios.Visible = false; }

            NI.BalloonTipIcon = ToolTipIcon.Info;
            NI.BalloonTipText = "Bienvenido " + this.usrActual.Nombre;
            NI.BalloonTipTitle = "Ut Simplex";
            NI.Visible = true;
            NI.ContextMenu = this.ContextMenu;
            NI.ShowBalloonTip(100);
        }

        // Bind UI Caja
        private void bindUICaja()
        {
            Boolean isAbierta = cajaActual != null? true : false;

            swAbrirCerrarCaja.Text = isAbierta ? "Cerrar Caja" : "Abrir Caja";
            swAbrirCerrarCaja.Checked = isAbierta;
          
            lblNroCaja.Visible = isAbierta;

            txtCajaFecha.Visible = isAbierta;
            txtCajaNro.Visible = isAbierta;
            txtCajaNro.Text = isAbierta ? cajaActual.ID.ToString() : "";
            txtCajaFecha.Text =  isAbierta ? cajaActual.FechaCaja.ToString() : "";

            btnCajaExtraer.Visible = isAbierta;
            btnCajaIngresar.Visible = isAbierta;
            

        }

        // CLICK MENU>>Salir
        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // CLICK BTN Lista Clientes
        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            Clientes.frmListadoClientes frmClientes = new Clientes.frmListadoClientes(usrActual);
            frmClientes.ShowDialog();
        }

        // CLICK BTN Cajas

        private void btnCajas_Click(object sender, EventArgs e)
        {
            Cajas.frmCajas frmCajas = new Cajas.frmCajas(usrActual);
            frmCajas.ShowDialog();
        }


        // CLICK BTN Lista Articulos
        private void btnListaArticulos_Click(object sender, EventArgs e)
        {
            Artículos.frmListadoArticulos frmArticulos = new Artículos.frmListadoArticulos(usrActual);
            frmArticulos.ShowDialog();


        }

        // CLICK BTN Lista Proveedores
       

        // CLICK BTN Nueva Venta
        private void btnVentaNueva_Click(object sender, EventArgs e)
        {
            if (cajaActual != null)
            {
                Ventas.frmVenta formNuevaVenta = new Ventas.frmVenta(usrActual);
                formNuevaVenta.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe abrir una caja antes de realizar ventas.", "Caja CERRADA - Ventas no permitidas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // CLICK BTN Cerrar SISTEMA
        private void btnCerrarSistema_Click(object sender, EventArgs e)
        {
            Mensajes.frmConfirmar formConfirmar = new Mensajes.frmConfirmar("¿Está seguro que desea cerrar el sistema?", "");

            if (formConfirmar.ShowDialog() == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // CLICK BTN Historial de ventas
        private void btnHistorialVentas_Click(object sender, EventArgs e)
        {
            Ventas.frmHistorialVentas formListaVentas = new UI.Desktop.Ventas.frmHistorialVentas(usrActual);
            formListaVentas.ShowDialog();

        }



        //TECLAS ACCESO RAPIDO
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.F12:
                    this.ConsultaRapida();
                    break;



                default:

                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //CLICK ABRIR CAJA
        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            AbrirCajaNueva();
        }

        //CLICK CERRAR CAJA
        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            CerrarCaja();
        }



        #region /*/* M E T O D O S *\*\


        #region METODOS PARA EXPORTAR e IMPORTAR

        // EXPORTAR =================================

        public void exportarArtículos()
        {

            Artículos.frmListadoArticulos frmListaArticulos = new UI.Desktop.Artículos.frmListadoArticulos();
            frmListaArticulos.ModoForm = UI.Desktop.Artículos.frmListadoArticulos.TipoForm.Lista;
            frmListaArticulos.Show();
            frmListaArticulos.Hide();


            Microsoft.Office.Interop.Excel.Application ExcelAppArt = new Microsoft.Office.Interop.Excel.Application();
            ExcelAppArt.Application.Workbooks.Add(Type.Missing);

            SaveFileDialog drArt = new SaveFileDialog();
            drArt.FileName = "Artículos " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            drArt.Filter = "Excel files (*.xls)|*.xls";
            drArt.Title = "ARTICULOS";



            if (drArt.ShowDialog() == DialogResult.OK)
            {
                for (int i = 1; i < frmListaArticulos.dgvListado.Columns.Count + 1; i++)
                {
                    ExcelAppArt.Cells[1, i] = frmListaArticulos.dgvListado.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < frmListaArticulos.dgvListado.Rows.Count; i++)
                {
                    for (int j = 0; j < frmListaArticulos.dgvListado.Columns.Count; j++)
                    {
                        ExcelAppArt.Cells[i + 2, j + 1] = frmListaArticulos.dgvListado.Rows[i].Cells[j].Value.ToString();
                    }
                }


                ExcelAppArt.ActiveWorkbook.SaveCopyAs(drArt.FileName);
                ExcelAppArt.ActiveWorkbook.Saved = true;
                ExcelAppArt.Quit();
            }

            int cantArti = frmListaArticulos.dgvListado.Rows.Count;

        }

        //EXP>ARTICULOS>EXPTODOS
        public int exportarArtículos(string drBackUpCompleto)
        {

            Artículos.frmListadoArticulos frmListaArticulos = new UI.Desktop.Artículos.frmListadoArticulos();
            frmListaArticulos.ModoForm = UI.Desktop.Artículos.frmListadoArticulos.TipoForm.Lista;
            frmListaArticulos.Show();
            frmListaArticulos.Hide();


            Microsoft.Office.Interop.Excel.Application ExcelAppArt = new Microsoft.Office.Interop.Excel.Application();
            ExcelAppArt.Application.Workbooks.Add(Type.Missing);

            SaveFileDialog drFileDialog = new SaveFileDialog();
            drFileDialog.FileName = "Artículos " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + ".xls";
            drFileDialog.Filter = "Excel files (*.xls)|*.xls";
            drFileDialog.Title = "ARTICULOS";


            drFileDialog.FileName = drBackUpCompleto + "\\" + drFileDialog.FileName;


            for (int i = 1; i < frmListaArticulos.dgvListado.Columns.Count + 1; i++)
            {
                ExcelAppArt.Cells[1, i] = frmListaArticulos.dgvListado.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < frmListaArticulos.dgvListado.Rows.Count; i++)
            {
                for (int j = 0; j < frmListaArticulos.dgvListado.Columns.Count; j++)
                {
                    ExcelAppArt.Cells[i + 2, j + 1] = frmListaArticulos.dgvListado.Rows[i].Cells[j].Value.ToString();
                }
            }


            ExcelAppArt.ActiveWorkbook.SaveCopyAs(drFileDialog.FileName);
            ExcelAppArt.ActiveWorkbook.Saved = true;
            ExcelAppArt.Quit();


            int cantArti = frmListaArticulos.dgvListado.Rows.Count;
            return cantArti;

        }


        public void exportarClientes()
        {
            Clientes.frmListadoClientes frmListaClientes = new UI.Desktop.Clientes.frmListadoClientes();
            frmListaClientes.ModoForm = UI.Desktop.Clientes.frmListadoClientes.TipoForm.Lista;

            frmListaClientes.Show();
            frmListaClientes.Hide();

            Microsoft.Office.Interop.Excel.Application ExcelAppCli = new Microsoft.Office.Interop.Excel.Application();
            ExcelAppCli.Application.Workbooks.Add(Type.Missing);

            SaveFileDialog drCli = new SaveFileDialog();
            drCli.FileName = "Clientes " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            drCli.Filter = "Excel files (*.xls)|*.xls";
            drCli.Title = "CLIENTES";


            if (drCli.ShowDialog() == DialogResult.OK)
            {
                for (int i = 1; i < frmListaClientes.dgvListado.Columns.Count + 1; i++)
                {
                    ExcelAppCli.Cells[1, i] = frmListaClientes.dgvListado.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < frmListaClientes.dgvListado.Rows.Count; i++)
                {
                    for (int j = 0; j < frmListaClientes.dgvListado.Columns.Count; j++)
                    {
                        ExcelAppCli.Cells[i + 2, j + 1] = frmListaClientes.dgvListado.Rows[i].Cells[j].Value.ToString();
                    }
                }


                ExcelAppCli.ActiveWorkbook.SaveCopyAs(drCli.FileName);
                ExcelAppCli.ActiveWorkbook.Saved = true;
                ExcelAppCli.Quit();
            }
            int cantCli = frmListaClientes.dgvListado.Rows.Count;
        }

        //EXP>CLIENTES>EXPTODOS
        public int exportarClientes(string drBackUpCompleto)
        {
            Clientes.frmListadoClientes frmListaClientes = new UI.Desktop.Clientes.frmListadoClientes();
            frmListaClientes.ModoForm = UI.Desktop.Clientes.frmListadoClientes.TipoForm.Lista;

            frmListaClientes.Show();
            frmListaClientes.Hide();

            Microsoft.Office.Interop.Excel.Application ExcelAppCli = new Microsoft.Office.Interop.Excel.Application();
            ExcelAppCli.Application.Workbooks.Add(Type.Missing);

            SaveFileDialog drFileDialog = new SaveFileDialog();
            drFileDialog.FileName = "Clientes " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + ".xls";
            drFileDialog.Filter = "Excel files (*.xls)|*.xls";
            drFileDialog.Title = "CLIENTES";

            drFileDialog.FileName = drBackUpCompleto + "\\" + drFileDialog.FileName;

            for (int i = 1; i < frmListaClientes.dgvListado.Columns.Count + 1; i++)
            {
                ExcelAppCli.Cells[1, i] = frmListaClientes.dgvListado.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < frmListaClientes.dgvListado.Rows.Count; i++)
            {
                for (int j = 0; j < frmListaClientes.dgvListado.Columns.Count; j++)
                {
                    ExcelAppCli.Cells[i + 2, j + 1] = frmListaClientes.dgvListado.Rows[i].Cells[j].Value.ToString();
                }
            }


            ExcelAppCli.ActiveWorkbook.SaveCopyAs(drFileDialog.FileName);
            ExcelAppCli.ActiveWorkbook.Saved = true;
            ExcelAppCli.Quit();

            int cantCli = frmListaClientes.dgvListado.Rows.Count;
            return cantCli;
        }



        public void exportarComprobantes()
        {
            Ventas.frmHistorialVentas formHistorialVentas = new UI.Desktop.Ventas.frmHistorialVentas(usrActual);

            formHistorialVentas.Show();
            formHistorialVentas.Hide();

            Microsoft.Office.Interop.Excel.Application ExcelAppComprobantes = new Microsoft.Office.Interop.Excel.Application();
            ExcelAppComprobantes.Application.Workbooks.Add(Type.Missing);

            SaveFileDialog drComprobantes = new SaveFileDialog();
            drComprobantes.FileName = "Comprobantes " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            drComprobantes.Filter = "Excel files (*.xls)|*.xls";
            drComprobantes.Title = "COMPROBANTES";


            if (drComprobantes.ShowDialog() == DialogResult.OK)
            {
                for (int i = 1; i < formHistorialVentas.dgvListado.Columns.Count + 1; i++)
                {
                    ExcelAppComprobantes.Cells[1, i] = formHistorialVentas.dgvListado.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < formHistorialVentas.dgvListado.Rows.Count; i++)
                {
                    for (int j = 0; j < formHistorialVentas.dgvListado.Columns.Count; j++)
                    {
                        ExcelAppComprobantes.Cells[i + 2, j + 1] = formHistorialVentas.dgvListado.Rows[i].Cells[j].Value.ToString();
                    }
                }


                ExcelAppComprobantes.ActiveWorkbook.SaveCopyAs(drComprobantes.FileName);
                ExcelAppComprobantes.ActiveWorkbook.Saved = true;
                ExcelAppComprobantes.Quit();
            }
            int cantCli = formHistorialVentas.dgvListado.Rows.Count;

            exportarDetallesComprobantes();
        }

        //EXP>CBTES>EXPTODOS
        public int exportarComprobantes(string drBackUpCompleto)
        {
            Ventas.frmHistorialVentas formHistorialVentas = new UI.Desktop.Ventas.frmHistorialVentas(usrActual);

            formHistorialVentas.Show();
            formHistorialVentas.Hide();

            Microsoft.Office.Interop.Excel.Application ExcelAppComprobantes = new Microsoft.Office.Interop.Excel.Application();
            ExcelAppComprobantes.Application.Workbooks.Add(Type.Missing);

            SaveFileDialog drFileDialog = new SaveFileDialog();
            drFileDialog.FileName = "Comprobantes " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + ".xls";
            drFileDialog.Filter = "Excel files (*.xls)|*.xls";
            drFileDialog.Title = "COMPROBANTES";

            drFileDialog.FileName = drBackUpCompleto + "\\" + drFileDialog.FileName;

            for (int i = 1; i < formHistorialVentas.dgvListado.Columns.Count + 1; i++)
            {
                ExcelAppComprobantes.Cells[1, i] = formHistorialVentas.dgvListado.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < formHistorialVentas.dgvListado.Rows.Count; i++)
            {
                for (int j = 0; j < formHistorialVentas.dgvListado.Columns.Count; j++)
                {
                    ExcelAppComprobantes.Cells[i + 2, j + 1] = formHistorialVentas.dgvListado.Rows[i].Cells[j].Value.ToString();
                }
            }


            ExcelAppComprobantes.ActiveWorkbook.SaveCopyAs(drFileDialog.FileName);
            ExcelAppComprobantes.ActiveWorkbook.Saved = true;
            ExcelAppComprobantes.Quit();

            int cantComp = formHistorialVentas.dgvListado.Rows.Count;
            exportarDetallesComprobantes(drBackUpCompleto);
            return cantComp;

        }

        public void exportarDetallesComprobantes()
        {

            Ventas.frmDetallesVentas formDetalles = new UI.Desktop.Ventas.frmDetallesVentas();
            formDetalles.Show();
            formDetalles.Hide();

            Microsoft.Office.Interop.Excel.Application ExcelAppDetallesComp = new Microsoft.Office.Interop.Excel.Application();
            ExcelAppDetallesComp.Application.Workbooks.Add(Type.Missing);

            SaveFileDialog drComprobantes = new SaveFileDialog();
            drComprobantes.FileName = "Comprobantes_Detalles" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            drComprobantes.Filter = "Excel files (*.xls)|*.xls";
            drComprobantes.Title = "DETALLES DE COMPROBANTES";


            if (drComprobantes.ShowDialog() == DialogResult.OK)
            {
                for (int i = 1; i < formDetalles.dgvListado.Columns.Count + 1; i++)
                {
                    if (formDetalles.dgvListado.Columns[i - 1].Visible == true)
                    {
                        if (i == 5)
                        {
                            ExcelAppDetallesComp.Cells[1, i - 1] = formDetalles.dgvListado.Columns[i - 1].HeaderText;
                        }

                        if (i == 4)
                        { ExcelAppDetallesComp.Cells[1, i - 1] = formDetalles.dgvListado.Columns[i - 1].HeaderText; }

                        if (i != 5 && i != 4)
                        { ExcelAppDetallesComp.Cells[1, i] = formDetalles.dgvListado.Columns[i - 1].HeaderText; }

                    }
                }

                for (int i = 0; i < formDetalles.dgvListado.Rows.Count; i++)
                {
                    for (int j = 0; j < formDetalles.dgvListado.Columns.Count; j++)
                    {
                        if (formDetalles.dgvListado.Columns[j].Visible == true)
                        {

                            if (formDetalles.dgvListado.Rows[i].Cells[j].Value == null)
                            {
                                ExcelAppDetallesComp.Cells[i + 2, j + 1] = "Vacio";
                            }
                            else
                            {
                                if (j == 3)
                                { ExcelAppDetallesComp.Cells[i + 2, j] = formDetalles.dgvListado.Rows[i].Cells[j].Value.ToString(); }
                                else if (j == 4)
                                { ExcelAppDetallesComp.Cells[i + 2, j] = formDetalles.dgvListado.Rows[i].Cells[j].Value.ToString(); }

                                if (j != 3 && j != 4)
                                { ExcelAppDetallesComp.Cells[i + 2, j + 1] = formDetalles.dgvListado.Rows[i].Cells[j].Value.ToString(); }
                            }
                        }
                    }
                }


                ExcelAppDetallesComp.ActiveWorkbook.SaveCopyAs(drComprobantes.FileName);
                ExcelAppDetallesComp.ActiveWorkbook.Saved = true;
                ExcelAppDetallesComp.Quit();
            }
            int cantDetalles = formDetalles.dgvListado.Rows.Count;

        }

        public void exportarDetallesComprobantes(string drBackUpCompleto)
        {

            Ventas.frmDetallesVentas formDetalles = new UI.Desktop.Ventas.frmDetallesVentas();
            formDetalles.Show();
            formDetalles.Hide();

            Microsoft.Office.Interop.Excel.Application ExcelAppDetallesComp = new Microsoft.Office.Interop.Excel.Application();
            ExcelAppDetallesComp.Application.Workbooks.Add(Type.Missing);

            SaveFileDialog drFileDialog = new SaveFileDialog();
            drFileDialog.FileName = "Comprobantes_Detalles" + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + ".xls";
            drFileDialog.Filter = "Excel files (*.xls)|*.xls";
            drFileDialog.Title = "DETALLES DE COMPROBANTES";

            drFileDialog.FileName = drBackUpCompleto + "\\" + drFileDialog.FileName;


            for (int i = 1; i < formDetalles.dgvListado.Columns.Count + 1; i++)
            {
                if (formDetalles.dgvListado.Columns[i - 1].Visible == true)
                {
                    if (i == 5)
                    {
                        ExcelAppDetallesComp.Cells[1, i - 1] = formDetalles.dgvListado.Columns[i - 1].HeaderText;
                    }

                    if (i == 4)
                    { ExcelAppDetallesComp.Cells[1, i - 1] = formDetalles.dgvListado.Columns[i - 1].HeaderText; }

                    if (i != 5 && i != 4)
                    { ExcelAppDetallesComp.Cells[1, i] = formDetalles.dgvListado.Columns[i - 1].HeaderText; }

                }
            }

            for (int i = 0; i < formDetalles.dgvListado.Rows.Count; i++)
            {
                for (int j = 0; j < formDetalles.dgvListado.Columns.Count; j++)
                {
                    if (formDetalles.dgvListado.Columns[j].Visible == true)
                    {

                        if (formDetalles.dgvListado.Rows[i].Cells[j].Value == null)
                        {
                            ExcelAppDetallesComp.Cells[i + 2, j + 1] = "Vacio";
                        }
                        else
                        {
                            if (j == 3)
                            { ExcelAppDetallesComp.Cells[i + 2, j] = formDetalles.dgvListado.Rows[i].Cells[j].Value.ToString(); }
                            else if (j == 4)
                            { ExcelAppDetallesComp.Cells[i + 2, j] = formDetalles.dgvListado.Rows[i].Cells[j].Value.ToString(); }

                            if (j != 3 && j != 4)
                            { ExcelAppDetallesComp.Cells[i + 2, j + 1] = formDetalles.dgvListado.Rows[i].Cells[j].Value.ToString(); }
                        }
                    }
                }
            }


            ExcelAppDetallesComp.ActiveWorkbook.SaveCopyAs(drFileDialog.FileName);
            ExcelAppDetallesComp.ActiveWorkbook.Saved = true;
            ExcelAppDetallesComp.Quit();

            int cantDetalles = formDetalles.dgvListado.Rows.Count;

        }

        private static void exportarProveedores()
        {
            // ACA VA EL CODIGO PARA EXPORTAR PROVEEDORES. DEBO AGREGAR TAMBIEN LOS ARTÍCULOS Q VENDE 

            Proveedores.frmListadoProveedores formListaProveedores = new UI.Desktop.Proveedores.frmListadoProveedores();

            formListaProveedores.Show();
            formListaProveedores.Hide();

            Microsoft.Office.Interop.Excel.Application ExcelAppProveedores = new Microsoft.Office.Interop.Excel.Application();
            ExcelAppProveedores.Application.Workbooks.Add(Type.Missing);

            SaveFileDialog drProveedores = new SaveFileDialog();
            drProveedores.FileName = "Proveedores " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            drProveedores.Filter = "Excel files (*.xls)|*.xls";
            drProveedores.Title = "PROVEEDORES";


            if (drProveedores.ShowDialog() == DialogResult.OK)
            {
                for (int i = 1; i < formListaProveedores.dgvListado.Columns.Count + 1; i++)
                {
                    ExcelAppProveedores.Cells[1, i] = formListaProveedores.dgvListado.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < formListaProveedores.dgvListado.Rows.Count; i++)
                {
                    for (int j = 0; j < formListaProveedores.dgvListado.Columns.Count; j++)
                    {
                        ExcelAppProveedores.Cells[i + 2, j + 1] = formListaProveedores.dgvListado.Rows[i].Cells[j].Value.ToString();
                    }
                }


                ExcelAppProveedores.ActiveWorkbook.SaveCopyAs(drProveedores.FileName);
                ExcelAppProveedores.ActiveWorkbook.Saved = true;
                ExcelAppProveedores.Quit();
            }
            int cantProv = formListaProveedores.dgvListado.Rows.Count;

        }

        private static int exportarProveedores(string drBackUpCompleto)
        {
            // ACA VA EL CODIGO PARA EXPORTAR PROVEEDORES. DEBO AGREGAR TAMBIEN LOS ARTÍCULOS Q VENDE 

            Proveedores.frmListadoProveedores formListaProveedores = new UI.Desktop.Proveedores.frmListadoProveedores();

            formListaProveedores.Show();
            formListaProveedores.Hide();

            Microsoft.Office.Interop.Excel.Application ExcelAppProveedores = new Microsoft.Office.Interop.Excel.Application();
            ExcelAppProveedores.Application.Workbooks.Add(Type.Missing);

            SaveFileDialog drFileDialog = new SaveFileDialog();
            drFileDialog.FileName = "Proveedores " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString() + ".xls";
            drFileDialog.Filter = "Excel files (*.xls)|*.xls";
            drFileDialog.Title = "PROVEEDORES";

            drFileDialog.FileName = drBackUpCompleto + "\\" + drFileDialog.FileName;


            for (int i = 1; i < formListaProveedores.dgvListado.Columns.Count + 1; i++)
            {
                ExcelAppProveedores.Cells[1, i] = formListaProveedores.dgvListado.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < formListaProveedores.dgvListado.Rows.Count; i++)
            {
                for (int j = 0; j < formListaProveedores.dgvListado.Columns.Count; j++)
                {
                    ExcelAppProveedores.Cells[i + 2, j + 1] = formListaProveedores.dgvListado.Rows[i].Cells[j].Value.ToString();
                }
            }


            ExcelAppProveedores.ActiveWorkbook.SaveCopyAs(drFileDialog.FileName);
            ExcelAppProveedores.ActiveWorkbook.Saved = true;
            ExcelAppProveedores.Quit();

            int cantProv = formListaProveedores.dgvListado.Rows.Count;
            return cantProv;

        }


        // IMPORTAR =================================     
        public void importarClientes()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string connectionString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", openFileDialog1.FileName);
                string sqlExcel = String.Format("select * from [{0}$]", "Hoja1");

                DataSet ExDataSet = new DataSet();
                //
                OleDbConnection ExConexion = new OleDbConnection(connectionString);
                OleDbCommand OleDbCommand = new OleDbCommand(sqlExcel, ExConexion);
                OleDbDataAdapter ExDataAdapter = new OleDbDataAdapter(OleDbCommand);
                //
                ExDataAdapter.Fill(ExDataSet);



                for (int i = 0; i < ExDataSet.Tables[0].Rows.Count; i++)
                {
                    Entidades.Cliente clienteExcel = new Entidades.Cliente();


                    clienteExcel.NumeroDocumento = ExDataSet.Tables[0].Rows[i].Field<String>(0);
                    clienteExcel.Nombre = ExDataSet.Tables[0].Rows[i].Field<String>(1);
                    clienteExcel.Apellido = ExDataSet.Tables[0].Rows[i].Field<String>(3);
                    clienteExcel.Telefono = ExDataSet.Tables[0].Rows[i].Field<String>(2);
                    clienteExcel.Direccion = ExDataSet.Tables[0].Rows[i].Field<String>(3);
                    clienteExcel.Email = ExDataSet.Tables[0].Rows[i].Field<String>(4);

                    Datos_ClienteAdapter.AñadirNuevo(clienteExcel);

                }


            }
        }






        #endregion


        #region //////////////////////INFORMES////////////////////

        //Informe STOCK CRITICO


        private void informeStockCritico()
        {
            string sql = "SELECT * FROM Articulos WHERE Articulos.stock <= Articulos.stockmin AND Articulos.habilitado = 'Si'";

            if (Datos_InformeArticulosAdapter.BuscarRegistrosReponer(sql))
            {
                System.IO.Directory.CreateDirectory("C:\\XML");
                string url = "C:\\XML\\informeArticulosReponer.xml";

                Datos_InformeArticulosAdapter.tablaArticulos.WriteXml(url, XmlWriteMode.WriteSchema);

            }


            Artículos.frmInformeArticulosReponer formInformeArtiRepo = new UI.Desktop.Artículos.frmInformeArticulosReponer();
            formInformeArtiRepo.ShowDialog();
            System.IO.File.Delete("C:\\XML\\informeArticulosReponer.xml");

        }

        //Informe Lista de Precios
        private void informeListaDePrecios()
        {

            string sql = "SELECT * FROM Articulos WHERE Articulos.habilitado = 'Si'";

            if (Datos_InformeArticulosAdapter.BuscarRegistrosListaPrecios(sql))
            {
                System.IO.Directory.CreateDirectory("C:\\XML");
                string url = "C:\\XML\\informeListaDePrecios.xml";

                Datos_InformeArticulosAdapter.tablaArticulos.WriteXml(url, XmlWriteMode.WriteSchema);

            }


            Artículos.frmInformeListadePrecios formListaDePrecios = new UI.Desktop.Artículos.frmInformeListadePrecios();
            formListaDePrecios.ShowDialog();
            System.IO.File.Delete("C:\\XML\\informeListaDePrecios.xml");

        }


        //Valorizar Inventario
        private void ValorizarInventario()
        {
            BindingList<Entidades.Articulo> ListaArticulos = Datos_ArticulosAdapter.GetAll();
            decimal valorización = 0;
            decimal valorFila = 0;

            foreach (Entidades.Articulo artEnLista in ListaArticulos)
            {
                valorFila = artEnLista.Stock * (decimal)artEnLista.Precio;
                valorización = valorización + valorFila;
            }
            int artOfrecidos = Datos_ArticulosAdapter.ContarArticulos();
            int artStock = Datos_ArticulosAdapter.ContarArticulosStock();

            valorización = decimal.Round(valorización, 2);



            Artículos.frmValorizacionDeInventario formValorización = new UI.Desktop.Artículos.frmValorizacionDeInventario(artOfrecidos, artStock, valorización);
            formValorización.ShowDialog();
        }

        #endregion

        //CONSULTA RÁPIDA STOCK Y PRECIO
        private void ConsultaRapida()
        {
            Artículos.frmConsultaRapidaStockPrecio formConsultaRapida = new UI.Desktop.Artículos.frmConsultaRapidaStockPrecio();
            formConsultaRapida.ShowDialog();
        }

        //INICIALIZAR CAJA
        private void InicializarCaja()
        {
            Entidades.Caja cajaAbierta = Datos_CajasAdapter.GetCajaAbierta();

            if(cajaAbierta != null)
            {
                this.cajaActual = cajaAbierta;
            }
            else
            {
                this.cajaActual = null;
            }
            
            bindUICaja();

        }

        //CERRAR CAJA
        private void CerrarCaja()
        {
            if (cajaActual != null)
            {
                Cajas.frmCierreCaja frmAperturaCaja = new Cajas.frmCierreCaja(usrActual, cajaActual);

                if (frmAperturaCaja.ShowDialog() == DialogResult.OK)
                {
                    cajaActual = null;

                }
            }
            else
            {
                MessageBox.Show("No existe una caja abierta. Debe abrirla antes de intentar cerrarla.", "Cerrar caja no permitido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                    bindUICaja();
        }
       
        //ABRIR CAJA NUEVA
        private void AbrirCajaNueva()
        {
            if(cajaActual == null)
            {
                Cajas.frmAperturaCaja frmAperturaCaja = new Cajas.frmAperturaCaja(usrActual);
                
                if (frmAperturaCaja.ShowDialog() == DialogResult.OK)
                {
                    cajaActual = frmAperturaCaja.caja;

                }
               
            }
            else
            {
                MessageBox.Show("Ya existe una caja abierta. Debe cerrarla antes de abrir una nueva.", "Abrir caja no permitido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                    bindUICaja();
        }

        #endregion




        // BARRA DE MENU 
        #region BARRA DE MENU
        // MENU > BACKUP 

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exportarArtículos();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exportarClientes();
        }

        private void comprobantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportarComprobantes();
        }
        

        //    MENU > USUARIOS
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usrActual.Rol == "Administrador")
            {
                Usuarios.frmListadoUsuarios frmUsuarios = new Usuarios.frmListadoUsuarios();
                frmUsuarios.ShowDialog();
            }
        }
       
        private void mnuEditarMiUsuario_Click(object sender, EventArgs e)
        {
            usrActual = Datos_UsuarioAdapter.GetUsuario(usrActual.usuario);
            Usuarios.frmUsuarioABM frmUsuarios = new Usuarios.frmUsuarioABM(usrActual);
            frmUsuarios.ModoForm = Usuarios.frmUsuarioABM.TipoForm.EdicionPropia;
            frmUsuarios.ShowDialog();
        }

        private void stockCríticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informeStockCritico();

        }

      

        private void listaDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informeListaDePrecios();
        }

        private void valorizaciónDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValorizarInventario();

        }

        private void aReponerPorMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Artículos.frmInformeReposicionSeleccionarMarca formInformePorMarca = new UI.Desktop.Artículos.frmInformeReposicionSeleccionarMarca();

            formInformePorMarca.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Mensajes.frmConfirmar formConfirmar = new Mensajes.frmConfirmar("¿Está seguro que desea cerrar la sesión iniciada?", "");

            if (formConfirmar.ShowDialog() == DialogResult.Yes)
            {
               bindUINoUser();
                this.Visible = false;
               usrActual= IniciarSesion();
            }
        }

        private void consultaRápidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ConsultaRapida();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mensajes.frmInformaciónDelSoftware frminfo = new UI.Desktop.Mensajes.frmInformaciónDelSoftware();
            frminfo.ShowDialog();
        }

        //CLICK PROVEEDORES
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportarProveedores();

        }

        private void backUpCOMPETOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog backUpCompletoFD = new FolderBrowserDialog();

            if (backUpCompletoFD.ShowDialog() == DialogResult.OK)
            {
                string path = backUpCompletoFD.SelectedPath;
                int cantArticulos =  exportarArtículos(path);
               int cantClientes = exportarClientes(path);

               int cantComprobantes = exportarComprobantes(path);//Incluye exportar detalles de comprobantes.
               int cantProveedores = exportarProveedores(path);

              string mensaje = "Se han exportado la siguiente cantidad de registros:\n Articulos: " + cantArticulos.ToString() + "\nClientes: " + cantClientes.ToString() + "\nComprobantes: " + cantComprobantes.ToString() + "\nProveedores: " + cantProveedores.ToString();
             MessageBox.Show(mensaje);
                
            }
        }

        private void mensajeNoDisponible()
        {
            MessageBox.Show("Función no disponible.", "Apologies", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void listaCompletaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mensajeNoDisponible();
        }

        private void porClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mensajeNoDisponible();
        }

        private void porArtículoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mensajeNoDisponible();
        }

        private void porFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mensajeNoDisponible();
        }

        #endregion

        private void btnCajaExtraer_Click(object sender, EventArgs e)
        {
            frmMovimientoCaja frmMovCaja = new frmMovimientoCaja(false, cajaActual, usrActual.usuario);
            frmMovCaja.ShowDialog();
        }

        private void btnCajaIngresar_Click(object sender, EventArgs e)
        {
            frmMovimientoCaja frmMovCaja = new frmMovimientoCaja(true, cajaActual, usrActual.usuario);
            frmMovCaja.ShowDialog();
        }

        private void parametrosDeLaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parametros.frmParametros frmParametros =   new Parametros.frmParametros();
            frmParametros.ShowDialog();

            if (frmParametros.DialogResult == DialogResult.OK)
            {
                if(this.parametrosEmpresa.FondoPantalla != null && this.parametrosEmpresa.FondoPantalla != "")
                {

                    parametrosEmpresa = parametrosEmpresaController.ObtenerParametrosEmpresa();
                    this.panelTabla.BackgroundImage = Image.FromFile(this.parametrosEmpresa.FondoPantalla);
                    
                }
            }
        }


        private void cargarCódigosDeBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abrir formulario de carga de codigos de barra
            Artículos.frmActualizarCodigosDeBarra frmCargaCodigosBarra = new UI.Desktop.Artículos.frmActualizarCodigosDeBarra();
            frmCargaCodigosBarra.ShowDialog();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Mensajes.frmConfirmar formConfirmar = new Mensajes.frmConfirmar("¿Está seguro que desea cerrar la sesión iniciada?", "");

            if (formConfirmar.ShowDialog() == DialogResult.Yes)
            {
                bindUINoUser();
                this.Visible = false;
                usrActual = IniciarSesion();
            }
        }

        private void btnListaProveedores_Click(object sender, EventArgs e)
        {

            Proveedores.frmListadoProveedores frmProveedores = new Proveedores.frmListadoProveedores(usrActual);
            frmProveedores.ShowDialog();
        }

       
        private void swAbrirCerrarCaja_Click(object sender, EventArgs e)
        {
            if(swAbrirCerrarCaja.Checked == true)
            {
                AbrirCajaNueva();
                swAbrirCerrarCaja.ForeColor = Color.Green;
            }
            else
            {
                CerrarCaja();
            }
        }

        private void f12ConsultaRápidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ConsultaRapida();
        }
    }
}
