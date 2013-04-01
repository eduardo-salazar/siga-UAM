using Control_Aulas_UAM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Aulas_UAM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Usuario e = new Usuario(1, "Eduardo", true);
            //e.Admin = true;
            //Entorno entorno = new Entorno(e);
            LoginForm entorno=new LoginForm();
            Application.Run(entorno);

            //Application.Run(new LoginForm());
        }
    }
}
