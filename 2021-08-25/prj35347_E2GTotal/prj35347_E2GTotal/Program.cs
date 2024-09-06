using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace prj35347_E2GTotal
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
            Application.Run(new prj35347_IMC.frm35347_E2G());
        }
    }
}
