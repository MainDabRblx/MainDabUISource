using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Update
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
			if (File.Exists("TotallyNotEasyExploits.dll"))
			{
				File.Delete("TotallyNotEasyExploits.dll");
				Console.WriteLine("Replacing EasyExploits API with new one...");
			}
			if (File.Exists("TotallyNotEasyExploitsDLL.dll"))
			{
				File.Delete("TotallyNotEasyExploitsDLL.dll");
				Console.WriteLine("Deleting old API");
			}
			if (File.Exists("EasyExploits.dll"))
			{
				File.Delete("TotallyNotEasyExploits.dll");
			}
			else
			{
				Console.WriteLine("Downloading new EasyExploits API...");
				WebClient webClient2 = new WebClient();
				webClient2.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/EasyExploits.dll?raw=true", "EasyExploits.dll");
			}
			if (!File.Exists("MoonSharp.Interpreter.dll"))
			{
				Console.WriteLine("Downloading MoonSharp.Interpreter...");
				WebClient webClient3 = new WebClient();
				webClient3.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MoonSharp.Interpreter.dll?raw=true", "MoonSharp.Interpreter.dll");
			}
			if (File.Exists("Plugins.exe"))
			{
			}
			if (File.Exists("Plugins.exe"))
			{
			}
			if (File.Exists("Applications\\vpn.exe"))
			{
				Console.WriteLine("Deleting VPN...");
				File.Delete("Applications\\vpn.exe");
			}
			else
			{
				
			}
			if (!File.Exists("MetroFramework.dll"))
			{
				Console.WriteLine("Downloading MetroFramework...");
				webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MetroFramework.dll?raw=true", "MetroFramework.dll");
			}
			if (!File.Exists("WeAreDevs_API.cpp.dll"))
			{
				Console.WriteLine("Downloading WeAreDevs_API.cpp.dll");
				webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/WeAreDevs_API.cpp.dll?raw=true", "WeAreDevs_API.cpp.dll");
			}
			if (!File.Exists("CheatSquadAPI.dll"))
			{
				Console.WriteLine("Downloading CheatSquadAPI.dll");
				webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/CheatSquadAPI.dll?raw=true", "CheatSquadAPI.dll");
			}
			if (!File.Exists("VisualStudioTabControl.dll"))
			{
				Console.WriteLine("Downloading VisualStudioTabControl");
				webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/VisualStudioTabControl.dll?raw=true", "VisualStudioTabControl.dll");
			}

			if (!Directory.Exists("autoexec"))
			{
				Console.WriteLine("Creating autoexec folder...");
				Directory.CreateDirectory("autoexec");
			}
			if (!Directory.Exists("workspace"))
			{
				Console.WriteLine("Creating workspace folder...");
				Directory.CreateDirectory("workspace");
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
