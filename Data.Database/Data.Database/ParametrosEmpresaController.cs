using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class ParametrosEmpresaController
    {
        private static ParametrosEmpresaController instance;
        private ParametrosAdapter parametrosAdapter = ParametrosAdapter.GetInstance();
        private FamiliaAdapter familiaAdapter = FamiliaAdapter.GetInstance();
        
        public ParametrosEmpresa parametrosEmpresaObj { get; set; }

        private ParametrosEmpresaController()
        {
            // Obtener los parámetros de la empresa de la base de datos
            parametrosEmpresaObj = parametrosAdapter.obtenerParametrosEmpresa();
        }

        // Método estático público para obtener la única instancia de la clase
        public static ParametrosEmpresaController GetInstance()
        {
            // Verificar si la propiedad estática privada es nula
            if (instance == null)
            {
                // Crear una nueva instancia de la clase y asignarla a la propiedad estática privada
                instance = new ParametrosEmpresaController();
            }

            // Devolver la propiedad estática privada
            return instance;
        }

        #region ============== Parametros Empresa ============== 
        public ParametrosEmpresa ObtenerParametrosEmpresa()
        {
            this.parametrosEmpresaObj = parametrosAdapter.obtenerParametrosEmpresa();
            return this.parametrosEmpresaObj;
        }

        public void Actualizar(ParametrosEmpresa _parametrosEmpresa)
        {
            parametrosAdapter.Actualizar(_parametrosEmpresa);

        }

        #endregion

        #region ============== FAMILIA ============== 


        public void ObtenerListadoFamilias()
        {
            this.parametrosEmpresaObj.ListadoFamilia1 = familiaAdapter
                .GetFamilias("Familia1", "%")
                .OrderBy(x => x.Descripcion).ToList();

            this.parametrosEmpresaObj.ListadoFamilia2 = familiaAdapter
               .GetFamilias("Familia2", "%")
               .OrderBy(x => x.Descripcion).ToList();
        }

        public void AñadirFamilia(Familia pFamilia, string pFamiliaSeleccionada)
        {
            familiaAdapter.AñadirNuevaFamilia(pFamilia, pFamiliaSeleccionada);
        }

        public void ModificarFamilia(Familia pFamilia, string pFamiliaSeleccionada)
        {
            familiaAdapter.ActualizarFamilia(pFamilia, pFamiliaSeleccionada);
        }

        public string ObtenerFondoPantalla()
        {
            return parametrosEmpresaObj.FondoPantalla;
        }
        #endregion
    }
}
