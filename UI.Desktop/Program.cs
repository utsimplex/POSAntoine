using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI.Desktop
{
    static class Program
    {
        private static frmMain mainForm;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                mainForm = new frmMain();
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                ExitApplication();
            }
        }

        public static void ExitApplication()
        {
            if (mainForm != null && !mainForm.IsDisposed)
            {
                mainForm.Close();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
