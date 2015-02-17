using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NetworkUtil
{
    static class Program
    {

        // Muhammad Asghar: m.muhammad.asghar@gmail.com
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
