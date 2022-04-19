using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Entidades
{
    public class EntidadNegocio
    {
        public EntidadNegocio()
        {
            this.State = States.Nuevo;   
        }


        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private States _State;
        public States State
        {
            get { return _State; }
            set { _State = value; }
        }

        public enum States
        {
            Eliminado,
            Nuevo,
            Modificado,
            SinModificar
        }
    }
}
