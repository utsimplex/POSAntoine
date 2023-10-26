using Data.Database;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Artículos
{
    public partial class frmActualizarCodigosDeBarra : frmBASEListaArticulos
    {
        ArticuloAdapter articulosData = new ArticuloAdapter();

        public frmActualizarCodigosDeBarra()
        {
            InitializeComponent();
            this.OrdenarColumnas("codigo", "descripcion", "codigobarras");
        }

        private void btnCargarCodigos_Click(object sender, EventArgs e)
        {
            frmEscanearCodigos frmEscanearCodigos = new frmEscanearCodigos(this.ListaArticulosFiltrados);
            if(frmEscanearCodigos.ShowDialog() == DialogResult.OK)
            {
             

                try
                {
                    List<Articulo> articulosConCodigo = frmEscanearCodigos.Tag as List<Articulo>;
                    articulosConCodigo.ForEach(articulo =>
                    {
                        articulosData.Actualizar(articulo);
                    });
                }catch(Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al intentar guardar los artículos", ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se han guardado los códigos");
            }
            AplicaFiltros();
        }
    }
}
