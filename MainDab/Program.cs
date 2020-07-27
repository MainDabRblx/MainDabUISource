using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace ProjectMainDab
{
	// Token: 0x02000014 RID: 20
	internal static class Program
	{


		// Token: 0x0600015F RID: 351 RVA: 0x000188A4 File Offset: 0x00016AA4
		[STAThread]

		private static void Main()
		{
		WebClient webClient = new WebClient();
		ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
			ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			string a3 = "";
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollection.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					a3 = managementObject["ProcessorId"].ToString();
				}
			}
			string b2 = "FREESEX";
			bool flag = a3 == b2;
			if (flag)
			{
				bool flag2 = File.Exists("Bunifu_UI_v1.5.3.dll");
				if (flag2)
				{
					File.Delete("Bunifu_UI_v1.5.3.dll");
				}
				bool flag3 = File.Exists("DiscordRPC.dll");
				if (flag3)
				{
					File.Delete("DiscordRPC.dll");
				}
				bool flag4 = File.Exists("EasyExploits.dll");
				if (flag4)
				{
					File.Delete("EasyExploits.dll");
				}
				bool flag5 = File.Exists("TotallyNotEasyExploitsDLL.dll");
				if (flag5)
				{
					File.Delete("TotallyNotEasyExploitsDLL.dll");
				}
				bool flag6 = File.Exists("MetroSuite 2.0.dll");
				if (flag6)
				{
					File.Delete("MetroSuite 2.0.dll");
				}
				bool flag7 = File.Exists("Newtonsoft.Json.dll");
				if (flag7)
				{
					File.Delete("Newtonsoft.Json.dll");
				}
				MessageBox.Show("You have been blacklisted from MainDab!");
			}
			else
			{
				string path = "update.exe";
				bool flag8 = File.Exists(path);
				if (flag8)
				{
					File.Delete(path);
				}
				string path2 = "betaupdate.exe";
				bool flag9 = File.Exists(path2);
				if (flag9)
				{
					File.Delete(path2);
				}
				bool flag10 = !Directory.Exists("Applications");
				if (flag10)
				{
					MessageBox.Show("Important folder not found! Please reinstall MainDab!");
				}
				bool flag11 = !Directory.Exists("Monaco");
				if (flag11)
				{
					MessageBox.Show("Important folder not found! Please reinstall MainDab!");
				}
				bool flag12 = !Directory.Exists("Scripts");
				if (flag12)
				{
					MessageBox.Show("Important folder not found! Please reinstall MainDab!");
				}

				bool flag13 = File.Exists("MainDab Updater.exe");
				if (flag13)
				{
					File.Delete("MainDab Updater.exe");
				}
				try
				{
					

					
						Application.EnableVisualStyles();
						Application.SetCompatibleTextRenderingDefault(false);
						Application.Run(new MainEx());
					
				}
				catch
                {
					MessageBox.Show("Failed to check for updates! Do you have a internet connection? \nClick OK to continue to MainDab.", "Error occured");
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run(new MainEx());
				}
			}
		}
	}
}
