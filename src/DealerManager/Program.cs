using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerManager
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
            
            //Properties.Settings.Default.app_buildString = Properties.Settings.Default.app_version + Properties.Settings.Default.app_build + Properties.Settings.Default.app_buildDate + Properties.Settings.Default.app_milestone; 
        }


    }


}
