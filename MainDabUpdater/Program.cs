using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace MainDabUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            Console.WriteLine("Starting update...");
            Console.Title = "MainDab | Updating MainDab...";
            Thread.Sleep(1000);
            Console.WriteLine("Deleting MainDab...");
            string path = "MainDab.exe";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            string path2 = "MainDabBeta.exe";
            if (File.Exists(path2))
            {
                File.Delete(path2);
            }
            Console.WriteLine("Downloading new CheatSquadAPI...");
            if (File.Exists("CheatSquadAPI.dll"))
            {
                File.Delete("CheatSquadAPI.dll");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/CheatSquadAPI.dll?raw=true", "CheatSquadAPI.dll");
            }

            if (!File.Exists("CheatSquadAPI.dll"))
            {
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/CheatSquadAPI.dll?raw=true", "CheatSquadAPI.dll");
            }


            if (File.Exists("OxygenU_API.dll"))
            {
                File.Delete("OxygenU_API.dll");
            }
            if (File.Exists("WeAreDevs_API.cpp.dll"))
            {
                File.Delete("WeAreDevs_API.cpp.dll");
            }
            if (File.Exists("OxygenBytecode.dll"))
            {
                File.Delete("OxygenBytecode.dll");
            }
            if (File.Exists("MoonSharp.Interpreter.dll"))
            {
                File.Delete("MoonSharp.Interpreter.dll");
            }
            if (File.Exists("Plugins.exe"))
            {
                File.Delete("Plugins.exe");
            }
            if (File.Exists("EasyExploitsDLL.dll"))
            {
                File.Delete("EasyExploitsDLL.dll");
            }
            if (File.Exists("EasyExploits.dll"))
            {
                File.Delete("EasyExploits.dll");
            }
            if (!File.Exists("SirHurtAPI.dll"))
            {
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/SirHurtAPI.dll?raw=true", "SirHurtAPI.dll");
            }
            if (File.Exists("WeAreDevs_API.cpp.dll"))
            {
                File.Delete("WeAreDevs_API.cpp.dll");
            }

            if (File.Exists("MainDab.dll"))
            {
                File.Delete("MainDab.dll");
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
            if (!File.Exists("FastColoredTextBox.dll"))
            {
                Console.WriteLine("FastColoredTextBox.dll");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/FastColoredTextBox.dll?raw=true", "FastColoredTextBox.dll");
            }



            ServicePointManager.ServerCertificateValidationCallback = ((object a, X509Certificate b, X509Chain c, SslPolicyErrors d) => true);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            Console.WriteLine("Downloading new MainDab EXE...");
            webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDab.exe?raw=true", "MainDab.exe");
            Console.WriteLine("MainDab downloaded.");
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
