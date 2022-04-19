using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    class Modulo: EntidadNegocio
    {
        string _Descripcion;
        public string Descripción
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }


    }
}
