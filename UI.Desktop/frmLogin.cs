using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using Data.Database;
using Entidades;

namespace UI.Desktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public Entidades.Usuario usrActual;
        Data.Database.UsuarioAdapter Datos_UsuarioAdapter = new Data.Database.UsuarioAdapter();


        // BOTON INGRESAR CLICK
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = txtUsuario.Text.ToLower();
            if (txtUsuario.Text != "" && txtPass.Text != "")
            {
                //VALIDO USUARIO Y CONTRASEÑA
                if (Datos_UsuarioAdapter.ValidarUsuario(txtUsuario.Text, txtPass.Text))
                {
                    //OBTENGO EL USUARIO
                    Usuario usr = Datos_UsuarioAdapter.GetUsuario(txtUsuario.Text);
                    
                        
                            usrActual = Datos_UsuarioAdapter.GetUsuario(txtUsuario.Text);
                            DialogResult = DialogResult.OK;
                        
                    
                }
                else // MAL USER Y PASS
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("El Usuario y la Contraseña no pueden estar vacios", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // OLVIDE MI CONTRASEÑA CLICK
        private void lnkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ResetearClave("dantearrighi@gmail.com");
            MessageBox.Show("Comuníquese con servicio técnico al: \n(0341) 153-115510\n o envíe un correo a: \ninfo@utsimplex.com","Olvidé mi contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
        }


        // Método para la generación de la contraseña al azar
        private string GenerarClaveAleatoria(int caracteres, bool minusculas)
        {
            StringBuilder constructor = new StringBuilder();
            Random numeroalazar = new Random(DateTime.Now.Millisecond); // generar con el milisegundo actual como semilla
            char caracter;
            for (int i = 0; i < caracteres; i++)
            {
                caracter = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * numeroalazar.NextDouble() + 65)));
                constructor.Append(caracter);
            }
            if (minusculas)
            {
                return constructor.ToString().ToLower();
            }
            else
            {
                return constructor.ToString();
            }
        }

        // Generar una clave al azar para la creación del usuario
        public void ResetearClave( string email)
        {
            //generar una clave aleatoria
           string claveNueva = GenerarClaveAleatoria(4, false);
            //enviar la clave sin encriptar por mail

            string De = "dantearrighi@gmail.com";
            //string Password = "9789Hrqs.";
            string Para = email;
            string Mensaje = "El sistema ha generado una clave aleatoria porque el administrador de UT SIMPLEX le ha dado de alta. Su clave temporal es: " + claveNueva + ". Por favor cambie su clave la primera vez que entre al sistema.";
            string Asunto = "Ut Simplex: Usuario y Contraseña para POS";






            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 465);

            smtpClient.Credentials = new System.Net.NetworkCredential("dantearrighi@gmail.com", "9789Hrqs.");
            // smtpClient.UseDefaultCredentials = true; // uncomment if you don't want to use the network credentials
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mail = new MailMessage();
            mail.Subject = Asunto;

            //Setting From , To and CC
            mail.From = new MailAddress(De);
            mail.To.Add(new MailAddress(email));

            smtpClient.Send(mail);






            //System.Net.Mail.MailMessage Email;

            //Email = new System.Net.Mail.MailMessage(De, Para, Asunto, Mensaje);
            ///*
            //System.Net.Mail.SmtpClient smtpMail = new System.Net.Mail.SmtpClient("smtp.gmail.com"); 
            //Email.IsBodyHtml = false; 
            //smtpMail.EnableSsl = true; 
            //smtpMail.UseDefaultCredentials = false;
            //smtpMail.Host = "smtp.gmail.com";
            //smtpMail.Port = ; 
            //smtpMail.Credentials = new System.Net.NetworkCredential(De, Password); 
            //smtpMail.ClientCertificates. 
            //SmtpClient clienteSmtp = new SmtpClient("WIN02");
            // * */
            ///*
            // * Cliente SMTP
            // * Gmail:  smtp.gmail.com  puerto:587
            // * Hotmail: smtp.liva.com  puerto:25
            // */
            //SmtpClient server = new SmtpClient("smtp.gmail.com", 587);
            ///*
            //* Autenticacion en el Servidor
            //* Utilizaremos nuestra cuenta de correo
            //*
            //* Direccion de Correo (Gmail o Hotmail)
            //* y Contrasena correspondiente
            //*/
            //server.Credentials = new System.Net.NetworkCredential(De, Password);
            //server.EnableSsl = true;

            //server.Send(Email);

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
