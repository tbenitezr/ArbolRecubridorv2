using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolRecubridorv2._0
{
    static class Program
    {
        public static FrmMain INICIO;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            INICIO = new FrmMain();
            Application.Run(INICIO);

        }
    }
}
