using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
   public class Proveedor
    {
        
        string _Dni;
        public string Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
        }

        string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email= value; }
        }

        string _Telefono;
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        string _Direccion;
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        
    }
} 
