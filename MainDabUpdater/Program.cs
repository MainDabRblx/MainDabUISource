using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MainDabUpdater
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient webClient = new WebClient();
            Console.WriteLine("UPDATER : Starting update...");
            Console.Title = "MainDab | Updating MainDab...";
            Thread.Sleep(1000);
            Console.WriteLine("UPDATER : Deleting MainDab...");
            string path = "MainDab.exe";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            Console.WriteLine("UPDATER : Downloading new CheatSquadAPI...");
            if (File.Exists("CheatSquadAPI.dll"))
            {
                File.Delete("CheatSquadAPI.dll");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/CheatSquadAPI.dll?raw=true", "CheatSquadAPI.dll");
            }

            if (!File.Exists("CheatSquadAPI.dll"))
            {
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/CheatSquadAPI.dll?raw=true", "CheatSquadAPI.dll");
            }
            Console.WriteLine("UPDATER : Downloading EasyExploits API...");
            if (File.Exists("EasyExploits.dll"))
            {
                File.Delete("EasyExploits.dll");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/EasyExploits.dll?raw=true", "EasyExploits.dll");
            }

            if (!File.Exists("EasyExploits.dll"))
            {
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/EasyExploits.dll?raw=true", "EasyExploits.dll");
            }
            if (!File.Exists("MetroFramework.dll"))
            {
                Console.WriteLine("Downloading MetroFramework...");
                webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MetroFramework.dll?raw=true", "MetroFramework.dll");
            }

            if (!File.Exists("ICSharpCode.AvalonEdit.dll"))
            {
                Console.WriteLine("Downloading ICSharpCode.AvalonEdit.dll");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/ICSharpCode.AvalonEdit.dll?raw=true", "ICSharpCode.AvalonEdit.dll");
            
            }
            if (!File.Exists("CheatSquadAPI.dll"))
            {
                Console.WriteLine("Downloading SAPI.dll");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/CheatSquadAPI.dll?raw=true", "CheatSquadAPI.dll");
            }
            if (!File.Exists("VisualStudioTabControl.dll"))
            {
                Console.WriteLine("Downloading VisualStudioTabControl");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/VisualStudioTabControl.dll?raw=true", "VisualStudioTabControl.dll");
            }
            if (File.Exists("FastColoredTextBox.dll"))
            {
                File.Delete("FastColoredTextBox.dll");
            }



            ServicePointManager.ServerCertificateValidationCallback = ((object a, X509Certificate b, X509Chain c, SslPolicyErrors d) => true);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            Console.WriteLine("UPDATER : Downloading new version of MainDab...");
            webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDab.exe?raw=true", "MainDab.exe");
            Console.WriteLine("UPDATER : New MainDab downloaded.");
            Console.Title = "MainDab | Starting MainDab in 5 seconds";
            WebClient webClient4 = new WebClient();
            byte[] bytes = webClient4.DownloadData("https://pastebin.com/raw/6pVUMAGi");
            string @string = Encoding.UTF8.GetString(bytes);
            Console.WriteLine("\n" + @string + "\n");
            Thread.Sleep(1000);
            Console.Title = "MainDab | Starting MainDab in 4 seconds";
            Thread.Sleep(1000);
            Console.Title = "MainDab | Starting MainDab in 3 seconds";
            Thread.Sleep(1000);
            Console.Title = "MainDab | Starting MainDab in 2 seconds";
            Thread.Sleep(1000);
            Console.Title = "MainDab | Starting MainDab in 1 seconds";
            Thread.Sleep(1000);
            Console.Title = "MainDab | Starting MainDab...";
            Thread.Sleep(500);
            Process.Start("MainDab.exe");
            Environment.Exit(0);
        }
    }
}
