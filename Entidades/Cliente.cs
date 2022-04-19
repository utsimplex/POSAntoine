using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Entidades
{
    public class Cliente
    {
        /*   D A T O S    D E L    C L I E N T E    */
        
        //DNI
        string _Dni;
        public string Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
        }

        //NOMBRE
        string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        //APELLIDO
        string _Apellido;
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        //TELEFONO
        string _Telefono;
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        //DIRECCION
        string _Direccion;
        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        //EMAIL
        string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        //TIPO
        string _tipo;
        public string TipoCliente
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        
        
      

    }
}
