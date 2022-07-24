using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cerebrum
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ro");

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            Application.Run(new CapitoleTeorie());

        }
    }

}
