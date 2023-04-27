using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop.Mensajes
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.progressBar.Value == 20)
            {
                this.label1.Text = "Inicializando Antoine App";
                
            }
            if (this.progressBar.Value == 40)
            {
                this.label1.Text = "Conectando a la base de datos...";

            }
            if (this.progressBar.Value == 60)
            {
                this.label1.Text = "Cargando info...";

            }
            if (this.progressBar.Value == 70)
            {
                this.label1.Text = "Que tengan muchas ventas!!!!";
            }
            this.progressBar.Increment(3);
            if (progressBar.Value == 100)
            {
                this.timer.Stop();
            }
        }
    }
}
