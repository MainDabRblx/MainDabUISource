using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace ProjectMainDab
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			ManagementObjectCollection managementObjectCollections = (new ManagementObjectSearcher("Select ProcessorId From Win32_processor")).Get();
			string str = "";
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollections.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					str = ((ManagementObject)enumerator.Current)["ProcessorId"].ToString();
				}
			}
			if (str != "FREESEX")
			{
				string str1 = "update.exe";
				if (File.Exists(str1))
				{
					File.Delete(str1);
				}
				string str2 = "betaupdate.exe";
				if (File.Exists(str2))
				{
					File.Delete(str2);
				}
				if (!Directory.Exists("Applications"))
				{
					MessageBox.Show("Important folder not found! Please reinstall MainDab!");
				}
				if (!Directory.Exists("Monaco"))
				{
					MessageBox.Show("Important folder not found! Please reinstall MainDab!");
				}
				if (!Directory.Exists("Scripts"))
				{
					MessageBox.Show("Important folder not found! Please reinstall MainDab!");
				}
				WebClient webClient = new WebClient();
				if (File.Exists("MainDab Updater.exe"))
				{
					File.Delete("MainDab Updater.exe");
				}
				byte[] numArray = (new WebClient()).DownloadData("https://pastebin.com/raw/QpwkAJS4");
				string str3 = Encoding.UTF8.GetString(numArray);
				if ("Project MainDab V.4.9" != str3)
				{
					WebClient webClient1 = new WebClient();
					if (File.Exists(str1))
					{
						File.Delete(str1);
					}
					MessageBox.Show(string.Concat("Update found to ", str3, ". Click OK to update."));
					webClient1.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDab%20Updater.exe?raw=true", "update.exe");
					ServicePointManager.ServerCertificateValidationCallback = (object a, X509Certificate b, X509Chain c, SslPolicyErrors d) => true;
					ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
					Process.Start("update.exe");
					Environment.Exit(0);
				}
				else
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run(new MainEx());
				}
			}
			else
			{
				if (File.Exists("Bunifu_UI_v1.5.3.dll"))
				{
					File.Delete("Bunifu_UI_v1.5.3.dll");
				}
				if (File.Exists("DiscordRPC.dll"))
				{
					File.Delete("DiscordRPC.dll");
				}
				if (File.Exists("EasyExploits.dll"))
				{
					File.Delete("EasyExploits.dll");
				}
				if (File.Exists("TotallyNotEasyExploitsDLL.dll"))
				{
					File.Delete("TotallyNotEasyExploitsDLL.dll");
				}
				if (File.Exists("MetroSuite 2.0.dll"))
				{
					File.Delete("MetroSuite 2.0.dll");
				}
				if (File.Exists("Newtonsoft.Json.dll"))
				{
					File.Delete("Newtonsoft.Json.dll");
				}
				MessageBox.Show("You have been blacklisted from MainDab!");
			}
		}
	}
}