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
                //VALIDATE USERNAME AND PASSWORD
                if (Datos_UsuarioAdapter.ValidarUsuario(txtUsuario.Text, txtPass.Text))
                {
                    //GET USER
                    Usuario usr = Datos_UsuarioAdapter.GetUsuario(txtUsuario.Text);


                    usrActual = Datos_UsuarioAdapter.GetUsuario(txtUsuario.Text);
                    DialogResult = DialogResult.OK;

                }
                else // WRONG USER AND PASS
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("El Usuario y la Contraseña no pueden estar vacios", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // FORGOT MY PASSWORD CLICK
        private void lnkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ResetearClave("dantearrighi@gmail.com");
            MessageBox.Show("Comuníquese con servicio técnico al: \n(0341) 153-115510\n o envíe un correo a: \ninfo@utsimplex.com", "Olvidé mi contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Method for generating a random password
        private string GenerarClaveAleatoria(int caracteres, bool minusculas)
        {
            StringBuilder constructor = new StringBuilder();
            Random numeroalazar = new Random(DateTime.Now.Millisecond); // generate with the current millisecond as seed
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

        // Generate a random password for user creation
        public void ResetearClave(string email)
        {
            //generate a random password
            string claveNueva = GenerarClaveAleatoria(4, false);
            //send the unencrypted password by mail

            string De = "dev@utsimplex.com";
            //string Password = ".";
            string Para = email;
            string Mensaje = "El sistema ha generado una clave aleatoria. Su clave temporal es: " + claveNueva + ". Por favor, cambie su clave la primera vez que entre al sistema.";
            string Asunto = "Ut Simplex: Usuario y Contraseña para POS";

            SmtpClient smtpClient = new SmtpClient("smtp.hostinger.com", 465);

            smtpClient.Credentials = new System.Net.NetworkCredential("dev@utsimplex.com", ".");
            // smtpClient.UseDefaultCredentials = true; // uncomment if you don't want to use the network credentials
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;
            MailMessage mail = new MailMessage();
            mail.Subject = Asunto;

            //Setting From , To and CC
            mail.From = new MailAddress(De);
            mail.To.Add(new MailAddress(email));
            mail.Body = Mensaje;

            try
            {
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                // NO FUNCIONA ROMPE ACA
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
