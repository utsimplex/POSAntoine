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
                txtCodigo.Text = articulo.Codigo;
                txtDescripcion.Text = articulo.Descripcion;
                this.txtCodigoBarras.Select();
                cts = new CancellationTokenSource();
                await EsperarLectura(cts.Token);
                if (!cts.Token.IsCancellationRequested)
                {
                    articulo.CodigoBarras = txtCodigoBarras.Text.Trim();
                }
                else
                {
                    articulo.CodigoBarras = null;
                }
                this.txtCodigoBarras.Clear();
                if (this.DialogResult == DialogResult.Cancel)
                {
                    break;
                }
            }

            if (this.DialogResult != DialogResult.Cancel)
            {
                MessageBox.Show("Se han leído todos los códigos de barras", "Lectura finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Tag = articulosConCodigo.Where(a => !string.IsNullOrEmpty(a.CodigoBarras)).ToList();
            }
            else
            {
                this.Tag = null;
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





        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
            this.DialogResult = DialogResult.Cancel;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Tag = this.articulosConCodigo;
            this.Close();
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