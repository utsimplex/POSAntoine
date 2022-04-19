using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Entidades
{
    public class Usuario: Entidades.EntidadNegocio
    {

        #region/*    D A T O S    D E L    U S U A R I O  ( E M P L E A D O)      */

        //NOMBRE DE USUARIO
        string _Usuario;
        public string usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
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

        //EMAIL
        string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
     
        //CUIL
        string _Cuil;
        public string Cuil
        {
            get { return _Cuil; }
            set { _Cuil = value; }
        }

        //CONTRASEÑA
        string _contraseña;
        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; }
        }

        //DIRECCION
        string _direccion;
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        //ROL
        string _rol;
        public string Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }
 
        #endregion

        

    }
}
