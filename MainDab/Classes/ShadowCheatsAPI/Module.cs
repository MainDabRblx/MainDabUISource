using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDab.Classes.ShadowCheatsAPI
{
    class Module
    {
		private bool DownloadFiles()
		{
			bool result;
			try
			{
				if (!global::System.IO.Directory.Exists("ShadowCheats"))
				{
					global::System.IO.Directory.CreateDirectory("ShadowCheats");
					if (!global::System.IO.Directory.Exists("ShadowCheats\\Bin"))
					{
						global::System.IO.Directory.CreateDirectory("ShadowCheats\\Bin");
					}
					if (!global::System.IO.Directory.Exists("ShadowCheats\\Workspace"))
					{
						global::System.IO.Directory.CreateDirectory("ShadowCheats\\Workspace");
					}
				}
				else
				{
					if (!global::System.IO.Directory.Exists("ShadowCheats\\Bin"))
					{
						global::System.IO.Directory.CreateDirectory("ShadowCheats\\Bin");
					}
					if (!global::System.IO.Directory.Exists("ShadowCheats\\Workspace"))
					{
						global::System.IO.Directory.CreateDirectory("ShadowCheats\\Workspace");
					}
				}
				if (global::System.IO.Directory.Exists("ShadowCheats\\Bin"))
				{
					if (!global::System.IO.File.Exists("ShadowCheats\\Bin\\ShadowCheats-Module.dll"))
					{
						global::System.Net.ServicePointManager.SecurityProtocol = global::System.Net.SecurityProtocolType.Tls12;
						global::System.Net.WebClient webClient = new global::System.Net.WebClient();
						webClient.DownloadFile("https://github.com/Shadow-Developer/ShadowApplicationProgrammingInterface/blob/master/Data/ShadowCheats-Exploit.dll?raw=true", "ShadowCheats\\Bin\\ShadowCheats-Module.dll");
						webClient.Dispose();
						if (!global::System.IO.File.Exists("ShadowCheats\\Bin\\Injector.exe"))
						{
							global::System.Net.ServicePointManager.SecurityProtocol = global::System.Net.SecurityProtocolType.Tls12;
							global::System.Net.WebClient webClient2 = new global::System.Net.WebClient();
							webClient2.DownloadFile("https://github.com/Shadow-Developer/ShadowApplicationProgrammingInterface/blob/master/Data/Injector.exe?raw=true", "ShadowCheats\\Bin\\Injector.exe");
							webClient2.Dispose();
						}
						else
						{
							global::System.IO.File.Delete("ShadowCheats\\Bin\\Injector.exe");
							global::System.Net.ServicePointManager.SecurityProtocol = global::System.Net.SecurityProtocolType.Tls12;
							global::System.Net.WebClient webClient3 = new global::System.Net.WebClient();
							webClient3.DownloadFile("https://github.com/Shadow-Developer/ShadowApplicationProgrammingInterface/blob/master/Data/Injector.exe?raw=true", "ShadowCheats\\Bin\\Injector.exe");
							webClient3.Dispose();
						}
					}
					else
					{
						global::System.IO.File.Delete("ShadowCheats\\Bin\\ShadowCheats-Module.dll");
						global::System.Net.ServicePointManager.SecurityProtocol = global::System.Net.SecurityProtocolType.Tls12;
						global::System.Net.WebClient webClient4 = new global::System.Net.WebClient();
						webClient4.DownloadFile("https://github.com/Shadow-Developer/ShadowApplicationProgrammingInterface/blob/master/Data/ShadowCheats-Exploit.dll?raw=true", "ShadowCheats\\Bin\\ShadowCheats-Module.dll");
						webClient4.Dispose();
						if (!global::System.IO.File.Exists("ShadowCheats\\Bin\\Injector.exe"))
						{
							global::System.Net.ServicePointManager.SecurityProtocol = global::System.Net.SecurityProtocolType.Tls12;
							global::System.Net.WebClient webClient5 = new global::System.Net.WebClient();
							webClient5.DownloadFile("https://github.com/Shadow-Developer/ShadowApplicationProgrammingInterface/blob/master/Data/Injector.exe?raw=true", "ShadowCheats\\Bin\\Injector.exe");
							webClient5.Dispose();
						}
						else
						{
							global::System.IO.File.Delete("ShadowCheats\\Bin\\Injector.exe");
							global::System.Net.ServicePointManager.SecurityProtocol = global::System.Net.SecurityProtocolType.Tls12;
							global::System.Net.WebClient webClient6 = new global::System.Net.WebClient();
							webClient6.DownloadFile("https://github.com/Shadow-Developer/ShadowApplicationProgrammingInterface/blob/master/Data/Injector.exe?raw=true", "ShadowCheats\\Bin\\Injector.exe");
							webClient6.Dispose();
						}
					}
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.Console.WriteLine("[{0}] [Shadow Cheats] -> Unexpected Error: {1}", global::System.DateTime.Now.ToLongTimeString(), ex.Message);
				global::System.Windows.Forms.MessageBox.Show("Uh oh. Shadow Cheats has reached a roadblock. You can find a detailed error in the console.", "Shadow Cheats", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Exclamation);
				result = false;
			}
			return result;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002264 File Offset: 0x00000464
		private bool CompareVersion()
		{
			bool result;
			try
			{
				global::System.Net.ServicePointManager.SecurityProtocol = global::System.Net.SecurityProtocolType.Tls12;
				global::System.Net.WebClient webClient = new global::System.Net.WebClient();
				string text = webClient.DownloadString("https://raw.githubusercontent.com/Shadow-Developer/ShadowApplicationProgrammingInterface/master/Data/Status.bin");
				webClient.Dispose();
				global::System.Net.ServicePointManager.SecurityProtocol = global::System.Net.SecurityProtocolType.Tls12;
				global::System.ComponentModel.Component component = new global::System.Net.WebClient();
				string value = webClient.DownloadString("http://setup.roblox.com/version");
				component.Dispose();
				if (text.Contains(value))
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.Console.WriteLine("[{0}] [Shadow Cheats] -> Unexpected Error: {1}", global::System.DateTime.Now.ToLongTimeString(), ex.Message);
				global::System.Windows.Forms.MessageBox.Show("Uh oh. Shadow Cheats has reached a roadblock. You can find a detailed error in the console.", "Shadow Cheats", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Exclamation);
				result = false;
			}
			return result;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002310 File Offset: 0x00000510
		private void UpdateModule()
		{
			try
			{
				global::Microsoft.Win32.RegistryKey registryKey = global::Microsoft.Win32.Registry.CurrentUser.OpenSubKey("ShadowCheats", true);
				global::System.Net.ServicePointManager.SecurityProtocol = global::System.Net.SecurityProtocolType.Tls12;
				global::System.Net.WebClient webClient = new global::System.Net.WebClient();
				string value = webClient.DownloadString("https://raw.githubusercontent.com/Shadow-Developer/ShadowApplicationProgrammingInterface/master/Data/Version.ini");
				webClient.Dispose();
				if (registryKey == null)
				{
					registryKey = global::Microsoft.Win32.Registry.CurrentUser.CreateSubKey("ShadowCheats");
					registryKey.SetValue("Version", value);
					if (!this.DownloadFiles())
					{
						global::System.Windows.Forms.MessageBox.Show("Uh oh. Shadow Cheats has reached a roadblock. We tried creating the necessary folders and downloading the necessary files for Shadow Cheats, but it failed. You can try adding an exception for this exploit in your antivirus.", "Shadow Cheats", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Exclamation);
					}
				}
				else if (!registryKey.GetValue("Version").ToString().Contains(value) && !this.DownloadFiles())
				{
					global::System.Windows.Forms.MessageBox.Show("Uh oh. Shadow Cheats has reached a roadblock. We tried creating the necessary folders and downloading the necessary files for Shadow Cheats, but it failed. You can try adding an exception for this exploit in your antivirus.", "Shadow Cheats", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Exclamation);
				}
				if ((!global::System.IO.File.Exists("ShadowCheats\\Bin\\ShadowCheats-Module.dll") || !global::System.IO.File.Exists("ShadowCheats\\Bin\\Injector.exe")) && !this.DownloadFiles())
				{
					global::System.Windows.Forms.MessageBox.Show("Uh oh. Shadow Cheats has reached a roadblock. We tried creating the necessary folders and downloading the necessary files for Shadow Cheats, but it failed. You can try adding an exception for this exploit in your antivirus.", "Shadow Cheats", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Exclamation);
				}
				registryKey.SetValue("Version", value);
				registryKey.Close();
			}
			catch (global::System.Exception ex)
			{
				global::System.Console.WriteLine("[{0}] [Shadow Cheats] -> Unexpected Error: {1}", global::System.DateTime.Now.ToLongTimeString(), ex.Message);
				global::System.Windows.Forms.MessageBox.Show("Uh oh. Shadow Cheats has reached a roadblock. You can find a detailed error in the console.", "Shadow Cheats", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002448 File Offset: 0x00000648
		public void ExecuteScript(string Script)
		{
			try
			{
				if (global::MainDab.Classes.ShadowCheatsAPI.Pipes.DoesNamedPipeExist(global::MainDab.Classes.ShadowCheatsAPI.Pipes.ShadowCheats))
				{
					using (global::System.IO.Pipes.NamedPipeClientStream namedPipeClientStream = new global::System.IO.Pipes.NamedPipeClientStream(".", MainDab.Classes.ShadowCheatsAPI.Pipes.ShadowCheats, global::System.IO.Pipes.PipeDirection.Out))
					{
						namedPipeClientStream.Connect();
						using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(namedPipeClientStream))
						{
							streamWriter.Write(Script);
							streamWriter.Dispose();
						}
						namedPipeClientStream.Dispose();
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.Console.WriteLine("[{0}] [Shadow Cheats] -> Unexpected Error: {1}", global::System.DateTime.Now.ToLongTimeString(), ex.Message);
				global::System.Windows.Forms.MessageBox.Show("Uh oh. Shadow Cheats has reached a roadblock. You can find a detailed error in the console.", "Shadow Cheats", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002508 File Offset: 0x00000708
		public void Attach()
		{
			try
			{
				if (global::System.Diagnostics.Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
				{
					global::System.Windows.Forms.MessageBox.Show("Uh oh. Shadow Cheats has reached a roadblock. You need to join a game before attaching/injecting this exploit.", "Shadow Cheats", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Exclamation);
				}
				else if (global::MainDab.Classes.ShadowCheatsAPI.Pipes.DoesNamedPipeExist(global::MainDab.Classes.ShadowCheatsAPI.Pipes.ShadowCheats))
				{
					global::System.Windows.Forms.MessageBox.Show("Uh oh. Shadow Cheats has reached a roadblock. You've already attached/injected this exploit.", "Shadow Cheats", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Exclamation);
				}
				else if (this.CompareVersion())
				{
					this.UpdateModule();
					if (global::System.IO.File.Exists("ShadowCheats\\Bin\\ShadowCheats-Module.dll"))
					{
                        _ = global::System.Windows.Forms.Application.StartupPath + "\\ShadowCheats\\Bin\\ShadowCheats-Module.dll";
						global::System.Diagnostics.Process.Start(global::System.Windows.Forms.Application.StartupPath + "\\ShadowCheats\\Bin\\Injector.exe");
					}
					else
					{
						global::System.Windows.Forms.MessageBox.Show("Uh oh. Shadow Cheats has reached a roadblock. We were unable to locate Shadow Cheats. You can try adding an exception for this exploit in your antivirus.", "Shadow Cheats", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Exclamation);
					}
				}
				else
				{
					global::System.Windows.Forms.MessageBox.Show("Uh oh. Shadow Cheats has reached a roadblock. Please wait for Shadow Cheats to update.", "Shadow Cheats", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Exclamation);
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.Console.WriteLine("[{0}] [Shadow Cheats] -> Unexpected Error: {1}", global::System.DateTime.Now.ToLongTimeString(), ex.Message);
				global::System.Windows.Forms.MessageBox.Show("Uh oh. Shadow Cheats has reached a roadblock. You can find a detailed error in the console.", "Shadow Cheats", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000260C File Offset: 0x0000080C
		public bool ValidateVersion()
		{
			bool result;
			try
			{
				global::System.Net.ServicePointManager.SecurityProtocol = global::System.Net.SecurityProtocolType.Tls12;
				global::System.Net.WebClient webClient = new global::System.Net.WebClient();
				string text = webClient.DownloadString("https://raw.githubusercontent.com/Shadow-Developer/ShadowApplicationProgrammingInterface/master/Data/Status.bin");
				webClient.Dispose();
				global::System.Net.ServicePointManager.SecurityProtocol = global::System.Net.SecurityProtocolType.Tls12;
				global::System.ComponentModel.Component component = new global::System.Net.WebClient();
				string value = webClient.DownloadString("http://setup.roblox.com/version");
				component.Dispose();
				if (text.Contains(value))
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.Console.WriteLine("[{0}] [Shadow Cheats] -> Unexpected Error: {1}", global::System.DateTime.Now.ToLongTimeString(), ex.Message);
				global::System.Windows.Forms.MessageBox.Show("Uh oh. Shadow Cheats has reached a roadblock. You can find a detailed error in the console.", "Shadow Cheats", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Exclamation);
				result = false;
			}
			return result;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000026B8 File Offset: 0x000008B8
		public bool ValidateAttachment()
		{
			bool result;
			try
			{
				if (global::MainDab.Classes.ShadowCheatsAPI.Pipes.DoesNamedPipeExist(global::MainDab.Classes.ShadowCheatsAPI.Pipes.ShadowCheats))
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.Console.WriteLine("[{0}] [Shadow Cheats] -> Unexpected Error: {1}", global::System.DateTime.Now.ToLongTimeString(), ex.Message);
				global::System.Windows.Forms.MessageBox.Show("Uh oh. Shadow Cheats has reached a roadblock. You can find a detailed error in the console.", "Shadow Cheats", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Exclamation);
				result = false;
			}
			return result;
		}

		// Token: 0x06000008 RID: 8
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		private static extern bool AllocConsole();

		// Token: 0x06000009 RID: 9 RVA: 0x00002720 File Offset: 0x00000920
		public void CreateConsole()
		{
			global::MainDab.Classes.ShadowCheatsAPI.Module.AllocConsole();
			global::System.Console.Title = "Shadow Cheats (Do Not Close)";
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002734 File Offset: 0x00000934
		public void CloseRobloxProcesses()
		{
			global::System.Diagnostics.Process[] processesByName = global::System.Diagnostics.Process.GetProcessesByName("RobloxPlayerBeta");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002762 File Offset: 0x00000962
		public Module()
		{
		}
	}
}
