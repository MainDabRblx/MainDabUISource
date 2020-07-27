using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.Lib;
using Bunifu;
using BunifuAnimatorNS;
using DiscordRPC;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using EasyExploits;

using Microsoft.Win32;
using ProjectMainDab.Properties;
using SirHurtAPI;
using System.Collections.Generic;
using System.Security.Policy;

namespace ProjectMainDab
{
	// Token: 0x02000004 RID: 4
	public partial class MainEx : Form
	{
		// Token: 0x0600000E RID: 14 RVA: 0x0000227C File Offset: 0x0000047C
		public MainEx()
		{
			this.InitializeComponent();
			this.listBox1.Visible = false;
			this.listisopen = 0;
			this.backgroundWorker6.RunWorkerAsync();
			this.backgroundWorker1.RunWorkerAsync();


			this.panel5.Hide();
			Functions.PopulateListBox(this.listBox1, "./scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./scripts", "*.lua");
			WebClient webClient = new WebClient();
			this.client = new DiscordRpcClient("714648958265327737")
			{
				Logger = new ConsoleLogger
				{
					Level = LogLevel.Warning
				}
			};
			this.client.OnReady += delegate(object sender, ReadyMessage e)
			{
			};
			this.client.OnPresenceUpdate += delegate(object sender, PresenceMessage e)
			{
			};
			this.client.Initialize();

			// this.panel6.Visible = false;
			this.client.SetPresence(new RichPresence
			{
				Details = "Using MainDab Roblox Exploit",
				State = "Join here : discord.gg/N4EuuV8",
				Assets = new Assets
				{
					LargeImageKey = "render",
					LargeImageText = "render",
					SmallImageKey = "render"
				}
			});
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
				string friendlyName = AppDomain.CurrentDomain.FriendlyName;
				bool flag = registryKey.GetValue(friendlyName) == null;
				bool flag2 = flag;
				if (flag2)
				{
					registryKey.SetValue(friendlyName, 11001, RegistryValueKind.DWord);
				}
			}
			catch (Exception)
			{
			}
			WebBrowser webBrowser = new WebBrowser();
			WebClient webClient2 = new WebClient();
			webClient2.Proxy = null;
			TabPage tabPage = new TabPage("Tab 1");
			tabPage.Controls.Add(webBrowser);
			webBrowser.Dock = DockStyle.Fill;
			this.tabControl1.TabPages.Add(tabPage);
			this.tabControl1.SelectedTab = tabPage;
			webBrowser.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
			HtmlDocument document = webBrowser.Document;
			string scriptName = "SetTheme";
			object[] args = new string[]
			{
				"Dark"
			};
			document.InvokeScript(scriptName, args);
			this.addBase();
			this.addMath();
			this.addGlobalNS();
			this.addGlobalV();
			this.addGlobalF();

		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000254C File Offset: 0x0000074C
		private void addIntel(string label, string kind, string detail, string insertText)
		{
			string text = "\"" + label + "\"";
			string text2 = "\"" + kind + "\"";
			string text3 = "\"" + detail + "\"";
			string text4 = "\"" + insertText + "\"";
			this.MonacoEditor().Document.InvokeScript("AddIntellisense", new object[]
			{
				label,
				kind,
				detail,
				insertText
			});
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000025CC File Offset: 0x000007CC
		private void addGlobalF()
		{
			string[] array = File.ReadAllLines(this.defPath + "//globalf.txt");
			foreach (string text in array)
			{
				bool flag = text.Contains(':');
				bool flag2 = flag;
				if (flag2)
				{
					this.addIntel(text, "Function", text, text.Substring(1));
				}
				else
				{
					this.addIntel(text, "Function", text, text);
				}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002644 File Offset: 0x00000844
		private void addGlobalV()
		{
			foreach (string text in File.ReadLines(this.defPath + "//globalv.txt"))
			{
				this.addIntel(text, "Variable", text, text);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000026B0 File Offset: 0x000008B0
		private void addGlobalNS()
		{
			foreach (string text in File.ReadLines(this.defPath + "//globalns.txt"))
			{
				this.addIntel(text, "Class", text, text);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000271C File Offset: 0x0000091C
		private void addMath()
		{
			foreach (string text in File.ReadLines(this.defPath + "//classfunc.txt"))
			{
				this.addIntel(text, "Method", text, text);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002788 File Offset: 0x00000988
		private void addBase()
		{
			foreach (string text in File.ReadLines(this.defPath + "//base.txt"))
			{
				this.addIntel(text, "Keyword", text, text);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000027F4 File Offset: 0x000009F4
		private WebBrowser MonacoEditor()
		{
			WebBrowser result = null;
			TabPage selectedTab = this.tabControl1.SelectedTab;
			bool flag = selectedTab != null;
			if (flag)
			{
				result = (selectedTab.Controls[0] as WebBrowser);
			}
			return result;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002834 File Offset: 0x00000A34
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			bool flag = this.listisopen == 0;
			if (flag)
			{
				this.listisopen = 1;
				this.tabControl1.Size = new Size(492, 237);
				this.tabControl1.Location = new Point(150, 26);
				this.listBox1.Visible = true;
			}
			else
			{
				this.listisopen = 0;
				this.tabControl1.Size = new Size(563, 237);
				this.tabControl1.Location = new Point(50, 26);
				this.listBox1.Visible = false;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000028E0 File Offset: 0x00000AE0
		private void bunifuFlatButton10_Click(object sender, EventArgs e)
		{
			this.panel5.Hide();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000028EF File Offset: 0x00000AEF
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000028F4 File Offset: 0x00000AF4
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{

				bool flag = File.Exists("bin.zip");
				if (flag)
				{
					File.Delete("bin.zip");
				}
				string path = "bin";
				bool flag2 = Directory.Exists(path);
				if (flag2)
				{
					string path2 = "bin";
					Directory.Delete(path2, true);
				}

				string url = "https://github.com/leonardssy/ProjectDab/blob/master/scripts.zip?raw=true";
				string filename = "bin.zip";
				using (WebClient wc = new WebClient())
				{
					wc.DownloadFileCompleted += wc_completed;
					wc.DownloadProgressChanged += wc_DownloadProgressChanged;
					wc.DownloadFileAsync(new Uri(url), filename);
				}

				
				string sourceArchiveFileName = "bin.zip";
				string destinationDirectoryName = "bin";
				ZipFile.ExtractToDirectory(sourceArchiveFileName, destinationDirectoryName);
				File.Delete("bin.zip");
				
				this.label9.Text = "Updating Axon (MainDab's DLL)";
				if (File.Exists("Axon.dll"))
				{
					File.Delete("Axon.dll");
				}
				if (File.Exists("MainDab.dll"))
				{
					File.Delete("MainDab.dll");
				}
				
				// Functions.PopulateListBox1(this.listBox2, "./bin/scripts", "*.txt");

		}

		// Token: 0x0600001A RID: 26 RVA: 0x000029A3 File Offset: 0x00000BA3
		private void bunifuFlatButton5_Click(object sender, EventArgs e)
		{
			this.panel5.Show();
			this.panel5.BringToFront();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000029B4 File Offset: 0x00000BB4
		private void bunifuFlatButton3_Click(object sender, EventArgs e)
		{
            WebClient webClient = new WebClient();
			byte[] bytes = webClient.DownloadData("https://pastebin.com/raw/eKHr5sij");
			string @string = Encoding.UTF8.GetString(bytes);
			Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
			bool flag = processesByName.Length == 0;
			if (flag)
			{
				this.backgroundWorker2.RunWorkerAsync();
			}
			else
			{
				bool flag2 = this.label3.Text.Contains("easy");
				if (flag2)
				{
					HtmlDocument document = this.MonacoEditor().Document;
					string scriptName = "GetText";
					object[] array = new string[0];
					object[] args = array;
					object obj = document.InvokeScript(scriptName, args);
					string script = obj.ToString();
					this.m.ExecuteScript(script);
				}
				else
				{
					bool flag3 = this.label3.Text.Contains("123");
					if (flag3)
					{
						HtmlDocument document2 = this.MonacoEditor().Document;
						string scriptName2 = "GetText";
						object[] array = new string[0];
						object[] args2 = array;
						object obj2 = document2.InvokeScript(scriptName2, args2);
						string text = obj2.ToString();
						NamedPipes.LuaPipe(text);
					}
					else
					{
						bool flag4 = this.label3.Text.Contains("hurt");
						if (flag4)
						{
							HtmlDocument document3 = this.MonacoEditor().Document;
							string scriptName3 = "GetText";
							object[] array = new string[0];
							object[] args3 = array;
							object obj3 = document3.InvokeScript(scriptName3, args3);
							string text2 = obj3.ToString();
						}
					}
				}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002B19 File Offset: 0x00000D19
		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			this.label9.Text = "Please inject before attempting to execute!";
			Thread.Sleep(1000);
			this.label9.Text = "MainDab, made by Main_EX#3898";
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002B4C File Offset: 0x00000D4C
		private void bunifuFlatButton11_Click(object sender, EventArgs e)
		{
			this.label3.Text = "easy";
			Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
			bool flag = processesByName.Length == 0;
			if (flag)
			{
				this.backgroundWorker2.RunWorkerAsync();
			}
			else
			{
				this.backgroundWorker3.RunWorkerAsync();
			}
			this.panel5.Hide();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000028EF File Offset: 0x00000AEF
		private void bunifuFlatButton12_Click(object sender, EventArgs e)
		{
			this.panel5.Hide();
			SirHurtAPI.SirHurtAPI.LaunchExploit();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002BAC File Offset: 0x00000DAC
		private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
		{
			string script = "if workspace:FindFirstChild(\"MainDab Anti Exploit\") then\r\n    game.StarterGui:SetCore('SendNotification', { Title = 'MainDab'; Text = 'MainDab Serverside found in this game! Press the serverside button in MainDab in order to run the serverside!'; Duration = 25; Button1 = 'Lets rekt some kids'; })\r\nend";
			this.panel5.Hide();
			this.m.LaunchExploit();
			this.label9.Text = "MainDab (Injecting...)";
			metroProgressBar1.Show();
			metroProgressBar1.Value = 0;
			Thread.Sleep(1000);
			metroProgressBar1.Value = 20;
			Thread.Sleep(1000);
			metroProgressBar1.Value = 40;
			Thread.Sleep(1000);
			metroProgressBar1.Value = 60;
			Thread.Sleep(1000);
			metroProgressBar1.Value = 80;
			Thread.Sleep(1000);
			metroProgressBar1.Value = 100;
			this.label9.Text = "MainDab, made by Main_EX#3898";
			Thread.Sleep(5000);
			metroProgressBar1.Value = 0;
			metroProgressBar1.Hide();
			this.m.ExecuteScript(script);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002C1D File Offset: 0x00000E1D
		private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
		{
			//SirHurtAPI.LaunchExploit();
			this.panel5.Hide();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002C32 File Offset: 0x00000E32
		private void bunifuFlatButton4_Click(object sender, EventArgs e)
		{
			this.MonacoEditor().Document.InvokeScript("SetText", new object[]
			{
				""
			});
			Console.WriteLine("Monaco cleared");
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002C64 File Offset: 0x00000E64
		private void bunifuFlatButton6_Click(object sender, EventArgs e)
		{
			bool flag = Functions.openfiledialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				try
				{
					string text = File.ReadAllText(Functions.openfiledialog.FileName);
					this.MonacoEditor().Document.InvokeScript("SetText", new object[]
					{
						text
					});
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
					Console.WriteLine("File can't be opened");
				}
			}
			GC.Collect();
			GC.WaitForPendingFinalizers();
			GC.Collect();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002D04 File Offset: 0x00000F04
		private void bunifuFlatButton7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Coming soon");
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002D14 File Offset: 0x00000F14
		private void bunifuFlatButton8_Click(object sender, EventArgs e)
		{
			bool flag = Process.GetProcessesByName("RobloxPlayerBeta").Length == 0;
			if (!flag)
			{
				try
				{
					Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
					processesByName[0].Kill();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message.ToString());
				}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002D78 File Offset: 0x00000F78
		private void bunifuFlatButton9_Click(object sender, EventArgs e)
		{
			WebBrowser webBrowser = new WebBrowser();
			WebClient webClient = new WebClient();
			TabPage tabPage = new TabPage("Tab" + this.intValue.ToString());
			int num = this.intValue + 1;
			this.intValue = num;
			tabPage.AutoScroll = true;
			tabPage.Controls.Add(webBrowser);
			webBrowser.Dock = DockStyle.Fill;
			this.tabControl1.TabPages.Add(tabPage);
			this.tabControl1.SelectedTab = tabPage;
			webBrowser.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
			HtmlDocument document = webBrowser.Document;
			string scriptName = "SetTheme";
			object[] args = new string[]
			{
				"Dark"
			};
			document.InvokeScript(scriptName, args);
			this.addBase();
			this.addMath();
			this.addGlobalNS();
			this.addGlobalV();
			this.addGlobalF();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002E5A File Offset: 0x0000105A
		private void bunifuFlatButton1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002E64 File Offset: 0x00001064
		private void bunifuFlatButton2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002E70 File Offset: 0x00001070
		private void scriptHubToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			Hub1 hub = new Hub1();
			try
			{
				
				hub.Show();
			}
			catch
            {
				MessageBox.Show("Failed to open scripthub as it detects no scripts or folder, try close and rerun MainDab.");
            }
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002E8B File Offset: 0x0000108B
		private void sirhurtScriptHubToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Scripts.OpenScriptHub();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002E94 File Offset: 0x00001094
		private void ezHubToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string script = "loadstring(game:HttpGet(('https://pastebin.com/raw/SsG8y3HA'),true))()";
			bool flag = this.label3.Text.Contains("easy");
			if (flag)
			{
				this.m.ExecuteScript(script);
			}
			else
			{
				bool flag2 = this.label3.Text.Contains("123");
				if (flag2)
				{
					NamedPipes.LuaPipe(script);
				}
				else
				{
					bool flag3 = this.label3.Text.Contains("hurt");
					if (flag3)
					{
						//SirHurtAPI.Execute(script, true);
					}
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002F19 File Offset: 0x00001119
		private void fPSUnlockerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Process.Start("Applications\\fpsunlocker.exe");
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002F27 File Offset: 0x00001127
		private void multipleRobloxToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Process.Start("Applications\\multirblx.exe");
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002F38 File Offset: 0x00001138
		private void reinstallRobloxToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Reinstalling Roblox, MainDab may freeze for a while.", "MainDab", MessageBoxButtons.OK);
			try
			{
				foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
				{
					process.Kill();
				}
			}
			catch (Exception value)
			{
				MessageBox.Show(Convert.ToString(value), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			try
			{
				Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
				bool flag = Directory.Exists("Roblox");
				bool flag2 = flag;
				if (flag2)
				{
					Directory.Delete("Roblox", true);
				}
			}
			catch
			{
			}
			try
			{
				Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
				bool flag3 = Directory.Exists("Roblox");
				bool flag4 = flag3;
				if (flag4)
				{
					Directory.Delete("Roblox", true);
				}
				bool flag5 = File.Exists("Installer.exe");
				bool flag6 = flag5;
				if (flag6)
				{
					File.Delete("Installer.exe");
				}
			}
			catch
			{
			}
			new WebClient().DownloadFile("http://setup.roblox.com/RobloxPlayerLauncher.exe", "Installer.exe");
			Process.Start("Installer.exe");
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003078 File Offset: 0x00001278
		private void ironbrwObfuscatorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Ironbrew Obfuscator cracked will now download.");
			Console.WriteLine("Starting checks");
			WebClient webClient = new WebClient();
			bool flag = Directory.Exists("Ironbrew");
			if (flag)
			{
				Console.WriteLine("Ironbrew found downloaded");
				MessageBox.Show("Ironbrew is already downloaded!");
			}
			else
			{
				Console.WriteLine("Deleting ironbrew files if found");
				bool flag2 = File.Exists("ironbrew.zip");
				if (flag2)
				{
					File.Delete("ironbrew.zip");
				}
				bool flag3 = File.Exists("c:\\luac.exe");
				if (flag3)
				{
					File.Delete("c:\\luac.exe");
				}
				bool flag4 = File.Exists("c:\\luajit.exe");
				if (flag4)
				{
					File.Delete("c:\\luajit.exe");
				}
				Console.WriteLine("Downloading luac.exe");
				webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/luac.exe?raw=true", "c:\\luac.exe");
				Console.WriteLine("Downloading luajit.exe");
				webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/luajit.exe?raw=true", "c:\\luajit.exe");
				Console.WriteLine("Downloading ironbrew.zip");
				webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/ironbrew.zip?raw=true", "ironbrew.zip");
				Console.WriteLine("Ironbrew.zip downloaded");
				Console.WriteLine("Unzipping Ironbrew.zip");
				ZipFile.ExtractToDirectory("ironbrew.zip", "ironbrew");
				Console.WriteLine("Unziped ironbrew to directory ironbrew");
				bool flag5 = File.Exists("ironbrew.zip");
				if (flag5)
				{
					File.Delete("ironbrew.zip");
					Console.WriteLine("Deleted ironbrew.zip");
				}
				Console.WriteLine("Download complete");
				MessageBox.Show("Ironbrew is downloaded!");
				Console.WriteLine("This console window will now close.");
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000031FC File Offset: 0x000013FC
		private void taintDetectedExploitsCheckerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TaintCheck taintCheck = new TaintCheck();
			taintCheck.Show();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000028EF File Offset: 0x00000AEF
		private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003218 File Offset: 0x00001418
		private void injectToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Functions.openfiledialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					try
					{
						string text = File.ReadAllText(Functions.openfiledialog.FileName);
						this.MonacoEditor().Document.InvokeScript("SetText", new object[]
						{
						text
						});
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
						Console.WriteLine("File can't be opened");
					}
				}
				GC.Collect();
				GC.WaitForPendingFinalizers();
				GC.Collect();
			}
			catch
            {
				MessageBox.Show("Error while opening file!");
            }
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000032B8 File Offset: 0x000014B8
		private void killRobloxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = Process.GetProcessesByName("RobloxPlayerBeta").Length == 0;
			if (!flag)
			{
				try
				{
					Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
					processesByName[0].Kill();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message.ToString());
				}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000331C File Offset: 0x0000151C
		private void executeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.backgroundWorker5.RunWorkerAsync();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000029A3 File Offset: 0x00000BA3
		private void injecToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel5.Show();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003484 File Offset: 0x00001684
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000349F File Offset: 0x0000169F
		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/N4EuuV8");
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000034B0 File Offset: 0x000016B0
		private void serversodeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string script = "game.JointsService.WeldRequest:FireServer(\"gui\")";
			bool flag = this.label3.Text.Contains("easy");
			if (flag)
			{
				this.m.ExecuteScript(script);
				MessageBox.Show("Serverside ran! If the GUI dosen't show up, make sure that you are in a serversided game! Check our discord in #serversided-games for a list of serversided games! Also note that this functions is still in beta...", "Notice");
			}
			else
			{
				bool flag2 = this.label3.Text.Contains("123");
				if (flag2)
				{
					NamedPipes.LuaPipe(script);
					MessageBox.Show("Serverside ran! If the GUI dosen't show up, make sure that you are in a serversided game! Check our discord in #serversided-games for a list of serversided games! Also note that this functions is still in beta...", "Notice");
				}
				else
				{
					MessageBox.Show("Please inject before running the serverside!");
				}
			}
		}

		// Token: 0x04000008 RID: 8
		private WebClient wc = new WebClient();

		// Token: 0x04000009 RID: 9
		private string defPath = Application.StartupPath + "//Monaco//";

		// Token: 0x0400000A RID: 10
		private Module m = new Module();

		// Token: 0x0400000B RID: 11
		public DiscordRpcClient client;

		// Token: 0x0400000C RID: 12
		public string oldtext = "";

		// Token: 0x0400000D RID: 13
		private WebClient webClient = new WebClient();

		// Token: 0x0400000E RID: 14
		private int listisopen = 0;
		private int listisopen1 = 0;
		// Token: 0x0400000F RID: 15
		private int intValue = 2;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			try
			{
				this.MonacoEditor().Document.InvokeScript("SetText", new object[]
				{
					""
				});
				Console.WriteLine("Monaco cleared");
				string text = File.ReadAllText("Scripts\\" + this.listBox1.SelectedItem.ToString());
				bool flag = this.listBox1.SelectedItem != null;
				bool flag2 = flag;
				if (flag2)
				{
					this.MonacoEditor().Document.InvokeScript("SetText", new object[]
					{
						text
					});
				}
			}
			catch
			{
			}
		}

        private void Execute_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
			Functions.Inject();
			this.label3.Text = ("123");
			panel5.Hide();

		}

		private void bunifuFlatButton14_Click(object sender, EventArgs e)
		{
			HtmlDocument document = this.MonacoEditor().Document;
			string scriptName = "GetText";
			object[] array = new string[0];
			object[] args = array;
			object obj = document.InvokeScript(scriptName, args);
			string script = obj.ToString();
			NamedPipes.LuaPipe(script);
		}

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
			WebClient webClient = new WebClient();
			byte[] bytes = webClient.DownloadData("https://pastebin.com/raw/eKHr5sij");
			string @string = Encoding.UTF8.GetString(bytes);
			Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
			bool flag = processesByName.Length == 0;
			if (flag)
			{
				this.backgroundWorker2.RunWorkerAsync();
			}
			else
			{
				bool flag2 = this.label3.Text.Contains("easy");
				if (flag2)
				{
					HtmlDocument document = this.MonacoEditor().Document;
					string scriptName = "GetText";
					object[] array = new string[0];
					object[] args = array;
					object obj = document.InvokeScript(scriptName, args);
					string script = obj.ToString();
					this.m.ExecuteScript(script);
				}
				else
				{
					bool flag3 = this.label3.Text.Contains("123");
					if (flag3)
					{
						HtmlDocument document2 = this.MonacoEditor().Document;
						string scriptName2 = "GetText";
						object[] array = new string[0];
						object[] args2 = array;
						object obj2 = document2.InvokeScript(scriptName2, args2);
						string text = obj2.ToString();
					}
					else
					{
						bool flag4 = this.label3.Text.Contains("hurt");
						if (flag4)
						{
							HtmlDocument document3 = this.MonacoEditor().Document;
							string scriptName3 = "GetText";
							object[] array = new string[0];
							object[] args3 = array;
							object obj3 = document3.InvokeScript(scriptName3, args3);
							string text2 = obj3.ToString();
						}
					}
				}
			}
		}

        private void injectMainDabAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Functions.Inject();
        }

		List<string> items = new List<string>();
		private void textBox1_TextChanged(object sender, EventArgs e)
        {
			
		}

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
			Process.Start("ScriptHub.exe");
        }

        private void label6_Click(object sender, EventArgs e)
        {
			WebBrowser webBrowser = new WebBrowser();
			WebClient webClient = new WebClient();
			TabPage tabPage = new TabPage("Tab" + this.intValue.ToString());
			int num = this.intValue + 1;
			this.intValue = num;
			tabPage.AutoScroll = true;
			tabPage.Controls.Add(webBrowser);
			webBrowser.Dock = DockStyle.Fill;
			this.tabControl1.TabPages.Add(tabPage);
			this.tabControl1.SelectedTab = tabPage;
			webBrowser.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
			HtmlDocument document = webBrowser.Document;
			string scriptName = "SetTheme";
			object[] args = new string[]
			{
				"Dark"
			};
			document.InvokeScript(scriptName, args);
			this.addBase();
			this.addMath();
			this.addGlobalNS();
			this.addGlobalV();
			this.addGlobalF();
		}

        private void label7_Click(object sender, EventArgs e)
        {
			Process.Start("https://discord.gg/N4EuuV8");
		}

        private void pictureBox5_Click(object sender, EventArgs e)
        {
			this.tabControl1.SelectedIndex = 0;
		}

        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {

			WebClient webClient2 = new WebClient();


			byte[] bytes1 = webClient2.DownloadData("https://pastebin.com/raw/6pVUMAGi");
			string we1 = Encoding.UTF8.GetString(bytes1);
			richTextBox1.Text = we1;


			byte[] bytes = webClient2.DownloadData("https://pastebin.com/raw/QpwkAJS4");
			string we = Encoding.UTF8.GetString(bytes);
			string a2 = "Project MainDab V.5.2";
			if (we == a2)
            {
				panel7.BackColor = Color.Green;
				label10.Text = "Updated!";
            }
			else
            {
				MessageBox.Show("MainDab Update found! Click OK to update.");
				panel7.BackColor = Color.Orange;
				label10.Text = "Updating...";
				webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDab%20Updater.exe?raw=true", "update.exe");
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				panel7.BackColor = Color.Green;
				label10.Text = "Update";
				MessageBox.Show("Updater finished downloading, Click OK to continue.");
				Process.Start("update.exe");
				Environment.Exit(0);

			}
		}

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }

		private void wc_completed(object sender, AsyncCompletedEventArgs e)
		{
			string sourceArchiveFileName = "bin.zip";
			string destinationDirectoryName = "bin";
			ZipFile.ExtractToDirectory(sourceArchiveFileName, destinationDirectoryName);
			File.Delete("bin.zip");

			this.label9.Text = "Updating Axon (MainDab's DLL)";
			if (File.Exists("Axon.dll"))
			{
				File.Delete("Axon.dll");
			}
			if (File.Exists("MainDab.dll"))
			{
				File.Delete("MainDab.dll");
			}
			this.backgroundWorker7.RunWorkerAsync();
		}

		void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			metroProgressBar1.Value = e.ProgressPercentage;
			
		}

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker7_DoWork(object sender, DoWorkEventArgs e)
        {
			webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDab.dll?raw=true", "MainDab.dll");
			this.label9.Text = "Done!";
			Thread.Sleep(1000);
			this.label9.Text = "MainDab, made by Main_EX#3898";
			metroProgressBar1.Hide();
		}

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
