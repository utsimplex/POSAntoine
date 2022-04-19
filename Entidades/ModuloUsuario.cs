using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ModuloUsuario: EntidadNegocio
    {
        int _IdUsuario;
        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        int _IdModulo;
        public int IdModulo
        {
            get { return _IdModulo; }
            set { _IdModulo= value; }
        }

        bool _PermiteAlta;
        public bool PermiteAlta
        {
            get { return _PermiteAlta; }
            set { _PermiteAlta= value; }
        }

        bool _PermiteBaja;
        public bool PermiteBaja
        {
            get { return _PermiteBaja; }
            set { _PermiteBaja= value; }
        }

        bool _PermiteModificacion;
        public bool PermiteModificacion
        {
            get { return _PermiteModificacion; }
            set { _PermiteModificacion = value; }
        }

        bool _PermiteConsulta;
        public bool PermiteConsulta
        {
            get { return _PermiteConsulta; }
            set { _PermiteConsulta= value; }
        }


    }
}
