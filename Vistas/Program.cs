using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vistas {
    static class Program {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Application.Run(new FrmMain());
            
            /*
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            frmLogin.FormClosed += MainForm_Closed;

            Application.Run();
             * */
        }

        /*

        *   Método que cierra la aplicación cuando no hay ventanas

        */
        private static void MainForm_Closed(object sender, FormClosedEventArgs e) {
            ((Form)sender).FormClosed -= MainForm_Closed;
            //Pregunta si hay ventanas abiertas
            if (Application.OpenForms.Count == 0) {
                Application.ExitThread();
            } else {
                Application.OpenForms[0].FormClosed += MainForm_Closed;
            }
        }
    }
}
