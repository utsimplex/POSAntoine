using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Database;
using Entidades;


namespace UI.Desktop.Artículos
{
    public partial class frmListadoArticulos : frmBaseListado
    {
        public frmListadoArticulos()
        {
            InitializeComponent();
            ActualizarLista();
            this.dgvListado.Columns["descripcion"].Width = 280;
            this.dgvListado.Columns["codigo"].HeaderText = "Código";
            this.dgvListado.Columns["descripcion"].HeaderText = "Descripción";
            this.dgvListado.Columns["stockMin"].HeaderText = "Stock Min.";
            this.dgvListado.Columns["precio"].HeaderText = "Precio ($)";
            this.dgvListado.Columns["stock"].Width = 45;
            this.dgvListado.Columns["stockMin"].Width = 45;
            this.dgvListado.Columns["precio"].Width = 75;
            


            
        }

        public frmListadoArticulos(Usuario usr)
        {
            InitializeComponent();
            ActualizarLista();
            this.dgvListado.Columns["descripcion"].Width = 280;
            this.dgvListado.Columns["codigo"].HeaderText = "Código";
            this.dgvListado.Columns["descripcion"].HeaderText = "Descripción";
            this.dgvListado.Columns["stockMin"].HeaderText = "Stock Min.";
            this.dgvListado.Columns["precio"].HeaderText = "Precio ($)";
            this.dgvListado.Columns["stock"].Width = 45;
            this.dgvListado.Columns["stockMin"].Width = 45;
            this.dgvListado.Columns["precio"].Width = 75;
            rol = usr.Rol;



        }
        
       
        
        #region ///***///***///***/// V A R I A B L E S   L O C A L E S \\\***\\\***\\\***\\\
      
        //PROPIEDAD MODOFORM
        TipoForm _modoForm;
       public TipoForm ModoForm
          {
              get { return _modoForm; }
              set { _modoForm = value; }
          }


        //ENUMERADOR MODOFORM
        public enum TipoForm
        {
            Lista,
            SeleccionDeArticulo

        }

        //LISTA DE ARTICULOS
        public BindingList<Entidades.Articulo> ListaArticulos;

        //LISTA DE ARTICULOS Añadidos Venta Actual
        public BindingList<Entidades.Venta_Articulo> ListaArticulosVtaActual = new BindingList<Venta_Articulo>();

        // Lista de PROVEEDORES
        public AutoCompleteStringCollection listaProveedoresExistentes; 


        //ROL
        string rol;


        #endregion

        #region ///***///***///***/// M E T O D O S \\\***\\\***\\\***\\\


        // ACTUALIZAR LISTA DE ARTICULOS
        private void ActualizarLista()
        {
            ListaArticulos = DatosArticuloAdapter.GetAll();
            
            dgvListado.DataSource = ListaArticulos.Where(a => a.Habilitado == "Si").ToList();
            dgvListado.Columns["habilitado"].Visible = false;
            dgvListado.Columns["RangoEtario"].Visible = false;
            dgvListado.Columns["Familia"].Visible = false;

            this.dgvListado.Columns["RangoEtarioTexto"].HeaderText = "Rango etario";
            this.dgvListado.Columns["FamiliaTexto"].HeaderText = "Familia";
            this.dgvListado.Columns["CodigoArtiProveedor"].HeaderText = "Codigo proveedor";
            dgvListado.Size = new Size(960,429);
            
           
            
        }


        // Añadir NUEVO ARTICULO
        private void AñadirNuevoArticulo()
        {
            Artículos.frmArticuloABM frmAltaArticulo = new Artículos.frmArticuloABM();
            frmAltaArticulo.ModoForm = Artículos.frmArticuloABM.TipoForm.Alta;


            if (frmAltaArticulo.DialogResult != DialogResult.Abort)
            {
                frmAltaArticulo.ShowDialog();
            }
            

            //Completa la tabla con los datos nuevos
            ActualizarLista();
        }

        // Eliminar ARTICULO
        private void EliminarArticulo()
        {
            //    Confirmación eliminación
            Mensajes.frmConfirmar formConfirmar = new Mensajes.frmConfirmar("¿Está seguro que desea ELIMINAR el registro seleccionado?","");

            if (formConfirmar.ShowDialog() == DialogResult.Yes)
            {
                string codigo_a_Borrar = dgvListado.SelectedRows[0].Cells["codigo"].Value.ToString();
                Articulo arti_a_Ocultar = DatosArticuloAdapter.BuscarArticulo(codigo_a_Borrar);
                arti_a_Ocultar.Habilitado = "No";
                DatosArticuloAdapter.Actualizar(arti_a_Ocultar);
                
            }
            ActualizarLista();
        }

        // Modificar ARTICULO ************************ CONTINUAR ARREGLANDO MODIFICAR ARTICULO
        private void ModificarArticulo()
        { 
         
            // Artículo a modificar = artiToEdit
            Articulo artiToEdit = new Articulo();

            artiToEdit.Codigo = dgvListado.SelectedRows[0].Cells["codigo"].Value.ToString();
            artiToEdit.Descripcion = dgvListado.SelectedRows[0].Cells["descripcion"].Value.ToString();
            artiToEdit.Precio = Convert.ToDecimal(dgvListado.SelectedRows[0].Cells["precio"].Value.ToString());
            artiToEdit.StockMin = Convert.ToInt32(dgvListado.SelectedRows[0].Cells["stockMin"].Value);
            artiToEdit.Stock = Convert.ToInt32(dgvListado.SelectedRows[0].Cells["stock"].Value);
            artiToEdit.Habilitado = "Si";
            artiToEdit.Proveedor = dgvListado.SelectedRows[0].Cells["proveedor"].Value.ToString();
            artiToEdit.Familia = dgvListado.SelectedRows[0].Cells["familia"].Value!=null?Convert.ToInt32(dgvListado.SelectedRows[0].Cells["familia"].Value.ToString()):(int?)null;
            artiToEdit.Costo = Convert.ToDecimal(dgvListado.SelectedRows[0].Cells["Costo"].Value != null ? dgvListado.SelectedRows[0].Cells["Costo"].Value.ToString() : "0");
            artiToEdit.RangoEtario = dgvListado.SelectedRows[0].Cells["RangoEtario"].Value!=null? Convert.ToInt32(dgvListado.SelectedRows[0].Cells["RangoEtario"].Value.ToString()):(int?)null;
            artiToEdit.CodigoArtiProveedor = dgvListado.SelectedRows[0].Cells["CodigoArtiProveedor"].Value != null ? dgvListado.SelectedRows[0].Cells["CodigoArtiProveedor"].Value.ToString() : "";
            
            // Instanciación del formulario ABM Articulos EDICION
            frmArticuloABM formArticuloABM = new frmArticuloABM(artiToEdit);
            formArticuloABM.ModoForm = frmArticuloABM.TipoForm.Edicion;
/*
            //Carga el combo box con la lista de proveedores
            formArticuloABM.cbxProveedor.DataSource = DatosProveedorAdapter.GetAll();
            formArticuloABM.cbxProveedor.ValueMember = "nombre";
            formArticuloABM.cbxProveedor.SelectedItem = null;

            //Carga el AutoCompletar del comboBox
            formArticuloABM.cbxProveedor.AutoCompleteCustomSource = ProveedorAdapter.GetListadoNombres();


            // Carga en la grilla los Proveedores del Articulo Seleccionado.
            formArticuloABM.dgvProveedores_Articulos.DataSource = DatosProv_Art_Adapter.GetProveedoresArticulo(artiToEdit.Codigo);
            
  */           
            //ABRIR FORMULARIO            
            formArticuloABM.ShowDialog();
            ActualizarLista();

        }

        //Añadir a la lista VentaActual
        //Seleccionar artículo e Ingresar Cantidad
        private void SeleccionarArticulo()
        {
            Artículos.frmIngresarCantidad formIngreseCantidad = new frmIngresarCantidad(dgvListado.SelectedRows[0].Cells["codigo"].Value.ToString() +" - " + dgvListado.SelectedRows[0].Cells["descripcion"].Value.ToString());

            //Ingreso la cantidad a agregar
            if (formIngreseCantidad.ShowDialog() == DialogResult.OK)
            {
                Venta_Articulo vta_arti = new Venta_Articulo();

                vta_arti.Cantidad = Convert.ToInt32(formIngreseCantidad.cantidad.Value);
                vta_arti.CodigoArticulo = dgvListado.SelectedRows[0].Cells["codigo"].Value.ToString();
                vta_arti.DescripcionArticulo = dgvListado.SelectedRows[0].Cells["descripcion"].Value.ToString();
                vta_arti.Precio = Convert.ToDecimal(dgvListado.SelectedRows[0].Cells["precio"].Value.ToString());

                if (ValidarListaVtaActual(vta_arti))
                {
                    if (ValidarStock2(vta_arti.CodigoArticulo, vta_arti.Cantidad) == true)
                    {
                        
                        ListaArticulosVtaActual.Add(vta_arti);
                    }
                    
                    
                }
                tbxFiltro.ResetText();
            }
            
            
        }
       
        // VALIDAR ARTICULOS EN LA LISTA ACTUAL PARA NO REPETIR
        private bool ValidarListaVtaActual(Venta_Articulo vta_art_seleccionado)
        {
            bool añadir = true;
            

            foreach (Venta_Articulo vta_art in ListaArticulosVtaActual)
            {
                if (vta_art.CodigoArticulo == vta_art_seleccionado.CodigoArticulo)
                {
                    MessageBox.Show("El artículo " + vta_art.CodigoArticulo + " ya se encuentra en la lista de la venta actual.", "Listado de Artículos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    añadir = false;
                    break;
                }
             
                

            }

           
            return añadir;
        }

        // DEVOLVER LISTA DE ARTICULOS SELECCIONADOS
        public BindingList<Venta_Articulo> ReturnListArtVtaActual()
        {
            return ListaArticulosVtaActual;
        }

        // MODIFICAR CANTIDAD DE UN ARTÍCULO ESPECÍFICO DE LA LISTA-VENTA ACTUAL
        public void ModificarCantidadVtaActual(string codigo, int cant)
        {
            Articulo ArtBD = DatosArticuloAdapter.BuscarArticulo(codigo);
                   
            //Busco el artículo que quiero modificar en la lista.
            foreach (Entidades.Venta_Articulo vtaArtEdit in ListaArticulosVtaActual)
            {
                //Si coincide el código
                if (vtaArtEdit.CodigoArticulo == codigo)
                {
                      do{
                    // y si hay stock
                    if (ValidarStock2(codigo,cant) == false)
                    {
                        Artículos.frmIngresarCantidad formCambiarCantidad = new frmIngresarCantidad();
                        formCambiarCantidad.ShowDialog();
                        cant = Convert.ToInt32(formCambiarCantidad.cantidad.Value);                    
                    }
                    
                        } while(ArtBD.Stock < cant);

                      vtaArtEdit.Cantidad = cant;
                      MessageBox.Show("Se actualizó la cantidad de " + vtaArtEdit.CodigoArticulo);
                      break;
                    
                   
                 }
                }

            MessageBox.Show("Fin modificar venta actual (de listadoArticulos)");
            }

            
        bool ValidarStock(Venta_Articulo vta_art_seleccionado)
        {
            bool unidadesDisponibles = true;
            
                Entidades.Articulo ArtBD = DatosArticuloAdapter.BuscarArticulo(vta_art_seleccionado.CodigoArticulo);
               
                if (ArtBD.Stock < vta_art_seleccionado.Cantidad)
                {
                  MessageBox.Show("No hay stock suficiente. \nCantidad actual en stock: " + ArtBD.Stock.ToString(), "Lista de Artículos: "+ArtBD.Codigo.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  unidadesDisponibles = false;
                }
                return unidadesDisponibles;
                
            
        }

        public bool ValidarStock2(string codigo, int cantidad)
        {
            //True si hay stock
            //False si no hay stock
            
            bool unidadesDisponibles = true;
            
            Articulo ArtBD = DatosArticuloAdapter.BuscarArticulo(codigo);
            if (ArtBD.Stock < cantidad)
            {
                MessageBox.Show("No hay stock suficiente. \nCantidad actual en stock: " + ArtBD.Stock.ToString(), "Lista de Artículos: " + ArtBD.Codigo.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                unidadesDisponibles = false;
 
            }
            return unidadesDisponibles;
 
        }
        
        #endregion

        #region ///***///***///***/// E V E N T O S \\\***\\\***\\\***\\\


      
        // CLICK Añadir
        private void btnAñadirNuevo_Click(object sender, EventArgs e)
        {
            AñadirNuevoArticulo();
        }
        
        // CLICK Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (rol == "Empleado")
            {
                MessageBox.Show("El usuario no posee permisos para realizar esta tarea.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ModificarArticulo();
            }
        }


        // DOBLE CLICK Sobre un Articulo
        override public void dgvListado_DoubleClick(object sender, EventArgs e)
        {
            if (this.ModoForm == TipoForm.Lista)
            { ModificarArticulo(); }
            else if(this.ModoForm == TipoForm.SeleccionDeArticulo)
            { SeleccionarArticulo(); }
        }
        

        // CLICK ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (rol == "Empleado")
            {
                MessageBox.Show("El usuario no posee permisos para realizar esta tarea.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            } 
            else if (dgvListado.SelectedRows.Count != 0)
            {
                EliminarArticulo();
            } 
        }
        

        // MOFIFICAR EL FILTRO DE BUSQUEDA
      
       private void tbxFiltro_TextChanged_1(object sender, EventArgs e)
       {
            // Transforma el searchTerm a minúsculas para hacer búsquedas comparables independientemente de la capitalización
            string searchTermLower = tbxFiltro.Text.ToLowerInvariant();

            if (searchTermLower == "")
           {
               dgvListado.DataSource = DatosArticuloAdapter.GetAll();
           }
           else
           {
                // Filtro cada articulo en ListArticulos buscando coincidencias de código, descripción y proveedor del artículo
                var articulosEncontrados = ListaArticulos.Where(
                    a => a.Codigo.ToLowerInvariant().Contains(searchTermLower)
                      || a.Descripcion.ToLowerInvariant().Contains(searchTermLower)
                      || a.Proveedor.ToLowerInvariant().Contains(searchTermLower)
                );

                // Devuelve el listado de Articulos resultantes
                dgvListado.DataSource = articulosEncontrados.ToList();

                //dgvListado.DataSource = DatosArticuloAdapter.Busqueda(tbxFiltro.Text);
               
           }

       }

        // LOAD  -  CARGA MODO LISTA O SELECCION
       private void frmListadoArticulos_Load(object sender, EventArgs e)
       {
           if (this.ModoForm == TipoForm.SeleccionDeArticulo)
           {
               btnEliminar.Visible = false;
               btnExportar.Visible = false;
               btnImportar.Visible = false;
               btnSeleccionar.Visible = true;
               dgvListado.TabStop = true;
           }
           else
           {
               btnEliminar.Visible = true;
               btnExportar.Visible = true;
               btnImportar.Visible = true;
               btnSeleccionar.Visible = false ;
               listaProveedoresExistentes = DatosProveedorAdapter.GetListadoNombres();

            }
       }

        // CLICK Seleccionar Artículo
       private void btnSeleccionar_Click(object sender, EventArgs e)
       {
           SeleccionarArticulo();

       }

        // CLICK Salir
       public void btnSalir_Click(object sender, EventArgs e)
        {
            if (this.ModoForm == TipoForm.SeleccionDeArticulo)
            {
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

       // CLICK - Exportar Articulos a EXCEL
       private void btnExportar_Click(object sender, EventArgs e)
       {
           this.exportarArtículos();
       }

       // TECLAS ACCESO RAPIDO
       protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
       {
           switch (keyData)
           {

               case Keys.Enter:
                   if (this.ModoForm == TipoForm.SeleccionDeArticulo)
                   { SeleccionarArticulo(); }
                   
                   break;

               case Keys.Escape:
                   this.Close();
                   break;

               case Keys.Delete:
                   if (dgvListado.SelectedRows.Count != 0)
                   {
                       EliminarArticulo();
                   }
                   break;

              
               default:

                   break;
           }
           return base.ProcessCmdKey(ref msg, keyData);
       }


        #endregion

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (listaProveedoresExistentes.Count != 0)
            {
                //importarArtículos();
                //ActualizarLista();
                BindingList<Articulo> articulosExcel = importarArtículosAlt();

                foreach (Articulo articuloExcel in articulosExcel)
                {
                    Boolean estaCargado = false;

                    foreach (Articulo articuloApp in ListaArticulos)
                    {
                        if (articuloApp.Codigo == articuloExcel.Codigo)
                        {
                            estaCargado = true;
                        }
                    }
                    if (estaCargado)
                    {
                        DatosArticuloAdapter.Actualizar(articuloExcel);
                    }
                    else
                    {
                        DatosArticuloAdapter.AñadirNuevo(articuloExcel);
                    }
                }
                ActualizarLista();

            }
            else
            {
                MessageBox.Show("No es posible añadir artículos cuando no hay Proveedores cargados. Diríjase al módulo de Proveedores para ingresar al menos 1 proveedor.", "Imposible añadir Artículo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       private void btnMostrarTodos_Click(object sender, EventArgs e)
       {
           tbxFiltro.Text = "";
       }

      
        

      

     




    }
}
