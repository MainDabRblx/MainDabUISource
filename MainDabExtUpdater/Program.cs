using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading.Tasks;

using System.Diagnostics;
namespace MainDabExtUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient fuckmypussy = new WebClient();
            Console.WriteLine("Updating extensions...");
            if (File.Exists("MainDabExtensions.exe")) { File.Delete("MainDabExtensions.exe"); }
            fuckmypussy.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/MainDabExtensions.exe?raw=true", "MainDabExtensions.exe");
            Process.Start("MainDabExtensions.exe");
            Environment.Exit(0);
        }
    }
}
