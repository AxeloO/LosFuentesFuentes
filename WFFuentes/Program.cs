using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFFuentes
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // FLogin _fLogin = new FLogin();
            // _fLogin.Show();
            FMenuClientes _fPrincipal = new FMenuClientes();
           _fPrincipal.Show();

            Application.Run();
            
        }
    }
}
