using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Aplikasi_undangan
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
            Application.Run(new Login());
        }

        public static string konek = "Dsn=Mysqlku";
        //public static string konek = "Server=(local);Database=d_undangan;Integrated Security=True";
        //public static string konek="Server=localhost;Database=d_undangan;Uid=root;Pwd=";
    }
}
