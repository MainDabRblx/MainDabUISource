using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShadowCheats;
using CheatSquadAPI;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Net;
using Microsoft.Win32;
using System.IO.Compression;
using System.Threading;
using DiscordRPC;
using DiscordRPC.Logging;
using DiscordRPC.Message;

namespace ProjectMainDab
{
	public partial class MainUI : Form
	{
		private SEX shitsquad = new SEX(); // CheatSquad API
		private Api freesex = new Api(); // EasyExploits
		private int intValue = 2; // TabControl value stuff ok
		public MainUI()
		{
			InitializeComponent();
			try
			{
				// Monaco code on startup.
				
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
			this.visualStudioTabControl1.TabPages.Add(tabPage);
			this.visualStudioTabControl1.SelectedTab = tabPage;
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
			this.client.OnReady += delegate (object sender, ReadyMessage e)
			{
			};
			this.client.OnPresenceUpdate += delegate (object sender, PresenceMessage e)
			{
			};
			this.client.Initialize();
			// this.panel6.Visible = false;
			this.client.SetPresence(new RichPresence
			{
				Details = "Using MainDab V7",
				State = "Join here : discord.io/maindab",
				Assets = new Assets
				{
					LargeImageKey = "render",
					LargeImageText = "render",
					SmallImageKey = "render"
				}
			});
			this.backgroundWorker1.RunWorkerAsync();
		}

		private void tabPage3_Click(object sender, EventArgs e)
		{

		}

		private void MainUI_Load(object sender, EventArgs e)
		{
			menuStrip2.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
		}
		public class TestColorTable : ProfessionalColorTable
		{

			public override Color MenuBorder  //added for changing the menu border
			{
				get { return Color.Black; }
			}

		}

		private void label3_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void label4_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
		// Just some monaco stuff, I won't annotate it because idc
		private string defPath = Application.StartupPath + "//Monaco//";
        private DiscordRpcClient client;

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
			TabPage selectedTab = this.visualStudioTabControl1.SelectedTab;
			bool flag = selectedTab != null;
			if (flag)
			{
				result = (selectedTab.Controls[0] as WebBrowser);
			}
			return result;
		}

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
				wc.DownloadFile(url, filename);
			}
			string sourceArchiveFileName = "bin.zip";
			string destinationDirectoryName = "bin";
			ZipFile.ExtractToDirectory(sourceArchiveFileName, destinationDirectoryName);
			File.Delete("bin.zip");
			this.listBox2.Items.Clear();
			try

			{
				Functions.PopulateListBox1(this.listBox2, "./bin/scripts", "*.txt");
			}
			catch
			{
				MessageBox.Show("Failed to open scripthub as it detects no scripts or folder, try close and rerun MainDab.");
				this.Hide();

			}
			label5.Text = ("Updating MainDab.dll...");
			if (File.Exists("MainDab.dll"))
			{
				File.Delete("MainDab.dll");
			}
			string url1 = "https://github.com/leonardssy/ProjectDab/blob/master/MainDab.dll?raw=true";
			string filename1 = "MainDab.dll";
			using (WebClient wc = new WebClient())
			{
				wc.DownloadFile(url1, filename1);
			}
			label5.Text = "Update dones!";
			Thread.Sleep(1000);
			label5.Text = "Waiting for commands...";
		}

        private void cheatSquadToolStripMenuItem_Click(object sender, EventArgs e)
        {
			label6.Text = "Selected API : CheatSquad";

		}

        private void shadowCheatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			label6.Text = "Selected API : ShadowCheats";

		}

        private void mainDabAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
			label6.Text = "Selected API : MainDabAPI";

		}

        private void pictureBox4_Click(object sender, EventArgs e)
        {
			if (label6.Text == "Selected API : CheatSquad")
            {
				new Thread(() =>
				{
					Thread.CurrentThread.IsBackground = true;
					shitsquad.Attach();
					label5.Text = "Injecting CheatSquad API...";
					Thread.Sleep(5000);
					label5.Text = "Injection complete";
					Thread.Sleep(1000);
					label5.Text = "Waiting for commands...";
				}).Start();
				
            }
			if (label6.Text == "Selected API : ShadowCheats")
			{
				new Thread(() =>
				{
					Thread.CurrentThread.IsBackground = true;
					freesex.LoadIntoRoblox();
					label5.Text = "Injecting ShadowCheats...";
					Thread.Sleep(5000);
					label5.Text = "Injection complete";
					Thread.Sleep(1000);
					label5.Text = "Waiting for commands...";
				}).Start();
			}
			if (label6.Text == "Selected API : MainDabAPI")
			{
				new Thread(() =>
				{
					Thread.CurrentThread.IsBackground = true;
					label5.Text = "Injection in progress...";
					Thread.Sleep(3000);
					label5.Text = "Waiting for commands...";
				}).Start();
				
			}
			
		}

        private void pictureBox5_Click(object sender, EventArgs e)
        {
			visualStudioTabControl1.SelectedIndex = 0;
		}

        private void scriptHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
			visualStudioTabControl1.SelectedIndex = 0;
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
			if (label6.Text == "Selected API : CheatSquad")
			{
				
					HtmlDocument document = this.MonacoEditor().Document;
					string scriptName = "GetText";
					object[] array = new string[0];
					object[] args = array;
					object obj = document.InvokeScript(scriptName, args);
					string script = obj.ToString();
					this.shitsquad.Execute(script);
				
			}
			if (label6.Text == "Selected API : ShadowCheats")
			{
					HtmlDocument document = this.MonacoEditor().Document;
					string scriptName = "GetText";
					object[] array = new string[0];
					object[] args = array;
					object obj = document.InvokeScript(scriptName, args);
					string script = obj.ToString();
					this.freesex.ExecuteFromInterpreter(script);
				
			}
			if (label6.Text == "Selected API : MainDabAPI")
			{
				
					HtmlDocument document = this.MonacoEditor().Document;
					string scriptName = "GetText";
					object[] array = new string[0];
					object[] args = array;
					object obj = document.InvokeScript(scriptName, args);
					string script = obj.ToString();
					NamedPipes.LuaPipe(script);


			}
			
		}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
			this.MonacoEditor().Document.InvokeScript("SetText", new object[]
			{
				""
			});
			Console.WriteLine("Monaco cleared");
		}

        private void pictureBox3_Click(object sender, EventArgs e)
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
		}

        private void injectToolStripMenuItem1_Click(object sender, EventArgs e)
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
		}

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

        private void injectMainDabAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
			label6.Text = "Selected API : MainDabAPI";
			new Thread(() =>
			{
				Thread.CurrentThread.IsBackground = true;
				label5.Text = "Injection in progress...";
				Thread.Sleep(3000);
				label5.Text = "Waiting for commands...";
			}).Start();
		}

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (label6.Text == "Selected API : CheatSquad")
			{
			
					HtmlDocument document = this.MonacoEditor().Document;
					string scriptName = "GetText";
					object[] array = new string[0];
					object[] args = array;
					object obj = document.InvokeScript(scriptName, args);
					string script = obj.ToString();
					this.shitsquad.Execute(script);
				
			}
			if (label6.Text == "Selected API : ShadowCheats")
			{
				
					HtmlDocument document = this.MonacoEditor().Document;
					string scriptName = "GetText";
					object[] array = new string[0];
					object[] args = array;
					object obj = document.InvokeScript(scriptName, args);
					string script = obj.ToString();
					this.freesex.ExecuteFromInterpreter(script);
				
			}
			if (label6.Text == "Selected API : MainDabAPI")
			{
			HtmlDocument document = this.MonacoEditor().Document;
					string scriptName = "GetText";
					object[] array = new string[0];
					object[] args = array;
					object obj = document.InvokeScript(scriptName, args);
					string script = obj.ToString();
					NamedPipes.LuaPipe(script);
				

			}
			
		}

        private void pluginsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.MonacoEditor().Document.InvokeScript("SetText", new object[]
		{
				""
		});
			Console.WriteLine("Monaco cleared");
		}

        private void injecToolStripMenuItem_Click(object sender, EventArgs e)
        {

			if (label6.Text == "Selected API : CheatSquad")
			{
				new Thread(() =>
				{
					Thread.CurrentThread.IsBackground = true;
					shitsquad.Attach();
					label5.Text = "Injecting CheatSquad API...";
					Thread.Sleep(5000);
					label5.Text = "Injection complete";
					Thread.Sleep(1000);
					label5.Text = "Waiting for commands...";
				}).Start();

			}
			if (label6.Text == "Selected API : ShadowCheats")
			{
				new Thread(() =>
				{
					Thread.CurrentThread.IsBackground = true;
					freesex.LoadIntoRoblox();
					label5.Text = "Injecting ShadowCheats...";
					Thread.Sleep(5000);
					label5.Text = "Injection complete";
					Thread.Sleep(1000);
					label5.Text = "Waiting for commands...";
				}).Start();
			}
			if (label6.Text == "Selected API : MainDabAPI")
			{
				new Thread(() =>
				{
					Thread.CurrentThread.IsBackground = true;
					label5.Text = "Injection in progress...";
					Thread.Sleep(3000);
					label5.Text = "Waiting for commands...";
				}).Start();

			}
			
		}

        private void serversodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
			string script = "game.JointsService.WeldRequest:FireServer(\"gui\")";
			if (label6.Text == "Selected API : CheatSquad")
			{
				new Thread(() =>
				{
					shitsquad.Execute(script);
				}).Start();

			}
			if (label6.Text == "Selected API : ShadowCheats")
			{
				new Thread(() =>
				{
					freesex.LoadIntoRoblox(script);

				}).Start();
			}
			if (label6.Text == "Selected API : MainDabAPI")
			{
				new Thread(() =>
				{
					NamedPipes.LuaPipe(script);
				}).Start();

			}
			else
			{
				
			}
		}

        private void pDXHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
			string script = "loadstring(game:HttpGet(\"https://www.codepile.net/raw/9Eye4JEb.lua\", true))()";
			if (label6.Text == "Selected API : CheatSquad")
			{
				new Thread(() =>
				{
					shitsquad.Execute(script);
				}).Start();

			}
			if (label6.Text == "Selected API : ShadowCheats")
			{
				new Thread(() =>
				{
					freesex.LoadIntoRoblox(script);

				}).Start();
			}
			if (label6.Text == "Selected API : MainDabAPI")
			{
				new Thread(() =>
				{
					NamedPipes.LuaPipe(script);
				}).Start();

			}
			else
			{
				
			}
		}

        private void fPSUnlockerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			if (File.Exists("fpsunlocker.exe"))
			{
				Process.Start("Applications\\fpsunlocker.exe");
			}
			else
			{
				MessageBox.Show("Downloading VPN. Click OK to continue.");
				WebClient sex = new WebClient();
				sex.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/fpsunlocker.exe?raw=true", "Applications\\fpsunlocker.exe");
				Process.Start("Applications\\fpsunlocker.exe");
				MessageBox.Show("FPS unlocker downloaded and started!");
			}
		}

        private void multipleRobloxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			if (File.Exists("multirblx.exe"))
			{
				Process.Start("Applications\\multirblx.exe");
			}
			else
			{
				MessageBox.Show("Downloading VPN. Click OK to continue.");
				WebClient sex = new WebClient();
				sex.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/multirblx.exe?raw=true", "Applications\\multirblx.exe");
				Process.Start("Applications\\multirblx.exe");
				MessageBox.Show("Multiple Roblox downloaded and started!");
			}
		}

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

        private void taintDetectedExploitsCheckerToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Process.Start("https://obfuscator.aztupscripts.xyz/Home");
		}

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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
			new Thread(() =>
			{
				
			
			string text = File.ReadAllText("bin\\scripts\\" + this.listBox2.SelectedItem.ToString());
			bool flag = this.listBox2.SelectedItem != null;
			bool flag2 = flag;
			if (flag2)
			{
				string text2 = text;
				this.richTextBox2.Text = text2;
				string text3 = text2.Split(new char[]
				{
					'\r',
					'\n'
				}).FirstOrDefault<string>();
				string text4 = text3.Remove(0, 2);
				this.richTextBox1.Text = text4;
				string text5 = text2.Split(new char[]
				{
					'\r',
					'\n'
				}, StringSplitOptions.RemoveEmptyEntries)[1];
				string text6 = text5;
				string text7 = text6.Remove(0, 2);
				string requestUriString = text7;
				try
				{
					WebRequest webRequest = WebRequest.Create(requestUriString);
					using (WebResponse response = webRequest.GetResponse())
					{
						using (Stream responseStream = response.GetResponseStream())
						{
							this.pictureBox6.Image = Image.FromStream(responseStream);
						}
					}
				}
				catch
				{
					MessageBox.Show("Failed to get image.");
				}
			}
			}).Start();

		}

        private void label7_Click(object sender, EventArgs e)
        {
			string script = richTextBox2.Text;
			if (label6.Text == "Selected API : CheatSquad")
			{
				new Thread(() =>
				{
					shitsquad.Execute(script);
				}).Start();

			}
			if (label6.Text == "Selected API : ShadowCheats")
			{
				new Thread(() =>
				{
					freesex.LoadIntoRoblox(script);

				}).Start();
			}
			if (label6.Text == "Selected API : MainDabAPI")
			{
				new Thread(() =>
				{
					NamedPipes.LuaPipe(script);
				}).Start();

			}
			else
			{
				
			}
		}

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
			WebBrowser webBrowser = new WebBrowser();
			WebClient webClient = new WebClient();
			TabPage tabPage = new TabPage("Tab" + this.intValue.ToString());
			int num = this.intValue + 1;
			this.intValue = num;
			tabPage.AutoScroll = true;
			tabPage.Controls.Add(webBrowser);
			webBrowser.Dock = DockStyle.Fill;
			this.visualStudioTabControl1.TabPages.Add(tabPage);
			this.visualStudioTabControl1.SelectedTab = tabPage;
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void joinOurDiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Process.Start("https://discord.gg/s9P8Ycw");
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Process.Start("https://maindab.ga");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
			WebClient webClient2 = new WebClient();
			byte[] bytes = webClient2.DownloadData("https://pastebin.com/raw/QpwkAJS4");
			string we = Encoding.UTF8.GetString(bytes);
			MessageBox.Show("MainDab Roblox Exploit\n\nMade by Main_EX#3898\nDLL by Foresaken#0254\nAnd you, the user of MainDab!\n\nRunning " + we + ".\ndiscord.gg/s9P8Ycw", "Credits and stuff");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
			if (!Directory.Exists("Chat"))
            {
				this.backgroundWorker2.RunWorkerAsync();
				
			}
			else if (Directory.Exists("Chat"))
            {
				Process.Start("Chat\\Chatg\\Chat.exe");
			}
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
			using (var client = new WebClient())
			{

			label5.Text = ("Downloading chat zip");
			client.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/Chat.zip?raw=true", "Chat.zip");
				label5.Text = ("Unzipping chat zip");
				ZipFile.ExtractToDirectory("Chat.zip", "Chat");
				label5.Text = ("Starting chat");
				Process.Start("Chat\\Chatg\\Chat.exe");
				Process.Start("Chat\\Chatg\\Chat.exe");
				File.Delete("Chat.zip");
			label5.Text = ("Waiting for commands...");
			}
		}
    }
}
