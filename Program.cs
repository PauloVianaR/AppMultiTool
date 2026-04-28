using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppMultiTool.MainForms;
using AppMultiTool.Utils.GlobalItems;

namespace AppMultiTool
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Global.InactivityMonitor.OnInactivityTimeout += (object sender, EventArgs e) => Application.Exit();
            Global.GlobalTimer.StartTimer();

            AppDataManager.Initialize();

            Application.Run(Global.Forms.MainMenu);
        }
    }
}
