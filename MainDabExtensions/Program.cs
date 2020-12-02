using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Net;
using System.Text;
using System.IO;

namespace MainDabExtensions
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WebClient webClient2 = new WebClient();
            byte[] bytes = webClient2.DownloadData("https://pastebin.com/raw/h2vWbQKg");
            string we = Encoding.UTF8.GetString(bytes);
            string currentver = "Ext 1";

            if (currentver == we)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                if (File.Exists("MainDabExtUpdater.exe")){ File.Delete("MainDabExtUpdater.exe"); } // when your enter key breaks
                webClient2.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/MainDabExtUpdater.exe?raw=true", "MainDabExtUpdater.exe");
                Process.Start("MainDabExtUpdater.exe");
            }
        }
    }
}
