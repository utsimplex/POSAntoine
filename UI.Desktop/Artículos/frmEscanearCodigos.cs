using Data.Database;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Artículos
{
    public partial class frmEscanearCodigos : Form
    {

        ArticuloAdapter articuloAdapter = new ArticuloAdapter();
        List<Articulo> articulosConCodigo;
        private CancellationTokenSource cts;

        public frmEscanearCodigos(List<Articulo> listaArticulos)
        {
            InitializeComponent();
            this.articulosConCodigo = listaArticulos;
            this.RealizarLecturas();
        }


        private async void RealizarLecturas()
        {
            foreach (Articulo articulo in articulosConCodigo)
            {
                // Configuro UI
                txtCodigo.Text = articulo.Codigo;
                txtDescripcion.Text = articulo.Descripcion;
                this.txtCodigoBarras.Select();

                cts = new CancellationTokenSource();

                // ESPERO LECTURA
                await EsperarLectura(cts.Token);
                // Si leyó exitosamente sin cancelar ni omitir
                if (!cts.Token.IsCancellationRequested)
                {
                    articulo.CodigoBarras = txtCodigoBarras.Text.Trim();
                    articuloAdapter.Actualizar(articulo);
                }

                // Si omitió (o salio)
                else
                {
                    articulo.CodigoBarras = null;
                }

                this.txtCodigoBarras.Clear();

                // Si salio
                if ( this.DialogResult == DialogResult.OK)
                {
                    // Corto el bucle
                    break;
                }
            }
                        
            this.Close();
        }



        private async Task EsperarLectura(CancellationToken token)
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    if (token.IsCancellationRequested) 
                    {
                        break;
                    }
                    if (txtCodigoBarras.Text.EndsWith(Environment.NewLine))
                    {
                        this.Invoke(new Action(() => txtCodigoBarras.Text = txtCodigoBarras.Text.TrimEnd(Environment.NewLine.ToCharArray())));
                        break;
                    }
                    
                }
            });
        }






        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
            this.DialogResult = DialogResult.OK;
            
        }

        private void btnOmitir_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
        }

        // ATAJOS DE TECLADO
      
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.O:
                    btnOmitir.PerformClick();
                    break;

                default:

                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}