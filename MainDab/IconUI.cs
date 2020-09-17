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
using System.Linq.Expressions;

// annotated some parts for myself usually as notes, use them as you like

namespace ProjectMainDab
{
    public partial class IconUI : Form
    {
		// Code to run on Startup
		string injectscript = "loadstring(game:HttpGet(\"https://pastebin.com/raw/CqYKJzcv\", true))()";
        public IconUI()
        {
            InitializeComponent();
			try
			{
				// Monaco code on startup.
                #region MonacoOnStartup
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
			#endregion

			// Hide stuff I don't need yet
			panel2.Hide();
			listBox2.Hide();
			panel3.Hide();
			// listbox
			Functions.PopulateListBox(this.listBox2, "./scripts", "*.txt");
			Functions.PopulateListBox(this.listBox2, "./scripts", "*.lua");
			this.backgroundWorker1.RunWorkerAsync();

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
				Details = "Using MainDab Roblox Exploit V6",
				State = "Join here : discord.gg/78WJqX8",
				Assets = new Assets
				{
					LargeImageKey = "render",
					LargeImageText = "render",
					SmallImageKey = "render"
				}
			});
			if (File.Exists("Startup.txt"))
            {
				File.Delete("Startup.txt");
            }
			string fileName = "Startup.txt";
			using (FileStream fs = File.Create(fileName))
			{
				// Add some text to file    
				Byte[] title = new UTF8Encoding(true).GetBytes("[* Starting MainDab]\n[* Checking ifisuptodate]\n[* ifisuptodate return true, open ui]\n[* Connecting to Github]\n[* Updating script hub]\n[* Script hub done, close stream]\n[* Check for missing folder]\n[* All done]\n");
				fs.Write(title, 0, title.Length);
				byte[] author = new UTF8Encoding(true).GetBytes("Startup complete");
				fs.Write(author, 0, author.Length);
			}

			// Open the stream and read it back.    
			using (StreamReader sr = File.OpenText(fileName))
			{
				string s = "";
				while ((s = sr.ReadLine()) != null)
				{
					Console.WriteLine(s);
				}
			}

		}


		public DiscordRpcClient client;
		// Refrencing EasyExploits, CheatSquad API and WeAreDevs (Api V2)
		private SEX shitsquad = new SEX(); // CheatSquad API
        private Api freesex = new Api(); // EasyExploits
        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)] 
        public static extern bool LaunchExploit();
        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLimitedLuaScript(string script);
		private string defPath = Application.StartupPath + "//Monaco//";
		private int intValue = 2; // TabControl value stuff ok
		private int scripthubopen = 0; // Scripthub value is open
		private int listboxopen = 0; // listbox stuffok


		#region MonacoEditArea
		// Just some monaco stuff, I won't annotate it because idc
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
        #endregion

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
			WebBrowser webBrowser = new WebBrowser();
			WebClient webClient = new WebClient();
			TabPage tabPage = new TabPage("Help");

			tabPage.AutoScroll = true;
			tabPage.Controls.Add(webBrowser);
			webBrowser.Dock = DockStyle.Fill;
			this.visualStudioTabControl1.TabPages.Add(tabPage);
			this.visualStudioTabControl1.SelectedTab = tabPage;
			webBrowser.Navigate("https://grizzly-capricious-notebook.glitch.me/");
		}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
			Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
			bool flag = processesByName.Length == 0;
			if (flag)
			{
				MessageBox.Show("Please click Inject before executing!");
			}
			else
			{

				if (label6.Text == "Easy")
				{
					HtmlDocument document = this.MonacoEditor().Document;
					string scriptName = "GetText";
					object[] array = new string[0];
					object[] args = array;
					object obj = document.InvokeScript(scriptName, args);
					string script = obj.ToString();
					this.freesex.ExecuteFromInterpreter(script);
				}
				if (label6.Text == "Squad")
				{
					HtmlDocument document = this.MonacoEditor().Document;
					string scriptName = "GetText";
					object[] array = new string[0];
					object[] args = array;
					object obj = document.InvokeScript(scriptName, args);
					string script = obj.ToString();
					this.shitsquad.Execute(script);
				}
				if (label6.Text == "MainDab")
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
		}

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
			
			backgroundWorker3.RunWorkerAsync();
		}

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            // Add new tab
            #region stuff
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
            #endregion
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
			this.MonacoEditor().Document.InvokeScript("SetText", new object[]
			{
				""
			});
			Console.WriteLine("Monaco cleared");
		}

        private void pictureBox4_Click(object sender, EventArgs e)
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
			Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
			bool flag = processesByName.Length == 0;
			if (flag)
			{
				MessageBox.Show("Please open Roblox before injecting!");
			}
			else
			{
				panel3.Show();
			}
        }

        private void pictureBox6_Click(object sender, EventArgs e)
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
			if (listboxopen == 0)
			{
				listboxopen = 1;
				listBox2.Show();
			}
			else
			{
				listBox2.Hide();
				listboxopen = 0;
			}
		}

        private void pictureBox7_Click(object sender, EventArgs e)
        {
			if (scripthubopen == 0)
			{
				scripthubopen = 1;
				panel2.Show();
			}
			else
            {
				panel2.Hide();
				scripthubopen = 0;
			}
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
			Process.Start("https://discord.gg/qtvuyuG");
        }

        private void visualStudioTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
		int sex = 13;
		int sexpart = 6;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
			#region updateshit
			this.Size = new Size(1, 1);
			for (int i = 0; i < 20; i++)
			{
				this.Size = new Size(sex, 1);
				sex = sex + 28;

				System.Threading.Thread.Sleep(1);
			}
			for (int i = 0; i < 32; i++)
			{
				this.Size = new Size(sex, sexpart);
				sexpart = sexpart + 10;
				System.Threading.Thread.Sleep(1);
			}
			label1.Text = "MainDab | Updating script hub...";
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
			this.listBox1.Items.Clear();
			try

			{
				Functions.PopulateListBox1(this.listBox1, "./bin/scripts", "*.txt");
			}
			catch
			{
				MessageBox.Show("Failed to open scripthub as it detects no scripts or folder, try close and rerun MainDab.");
				this.Hide();

			}
			label1.Text = "MainDab | Updating MainDab.dll";
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
			label1.Text = "MainDab | Updates done!";
			Thread.Sleep(1000);
			label1.Text = "MainDab";

				
			#endregion
		}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


				string text = File.ReadAllText("bin\\scripts\\" + this.listBox1.SelectedItem.ToString());
				bool flag = this.listBox1.SelectedItem != null;
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
							this.pictureBox10.Image = Image.FromStream(responseStream);
						}
					}
				}
				catch
                {
					MessageBox.Show("Failed getting preview of script.");
                }
			}
            
			
		}

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
			try
			{
				this.MonacoEditor().Document.InvokeScript("SetText", new object[]
				{
					""
				});
				Console.WriteLine("Monaco cleared");
				string text = File.ReadAllText("Scripts\\" + this.listBox2.SelectedItem.ToString());
				bool flag = this.listBox2.SelectedItem != null;
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

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
			
			backgroundWorker2.RunWorkerAsync();
		}

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {

			backgroundWorker4.RunWorkerAsync();
		}

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
			panel3.Hide();
        }

        private void X_Click(object sender, EventArgs e)
        {
			Environment.Exit(0);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
			base.WindowState = FormWindowState.Minimized;
		}

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
			WebClient webClient2 = new WebClient();
			byte[] bytes = webClient2.DownloadData("https://pastebin.com/raw/CqYKJzcv");
			string we = Encoding.UTF8.GetString(bytes);
			panel3.Hide();
			label6.Text = "Easy";
			freesex.LoadIntoRoblox();
			label1.Text = "MainDab | Injecting...";
			Thread.Sleep(5000);
			label1.Text = "MainDab";
			Thread.Sleep(3000);
			freesex.ExecuteFromInterpreter(we);
		}

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
			panel3.Hide();
			label6.Text = "Squad";
			shitsquad.Attach();
			label1.Text = "MainDab | Injecting...";
			Thread.Sleep(6000);
			label1.Text = "MainDab";
			Thread.Sleep(3000);
			shitsquad.Execute(injectscript);
		}

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
			panel3.Hide();
			label3.Text = "WRD";
			LaunchExploit();
		}

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
			panel2.Hide();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
			if (label6.Text == "Easy")
            {
				freesex.ExecuteFromInterpreter(richTextBox2.Text);
            }
			else if (label6.Text == "Squad")
            {
				shitsquad.Execute(richTextBox2.Text);
            }
			else if (label6.Text == "MainDab")
            {
				NamedPipes.LuaPipe(richTextBox2.Text);

            }
			else
            {
				MessageBox.Show("Please inject");
            }

		}

        private void pictureBox11_Click(object sender, EventArgs e)
        {
			string script = "game.JointsService.WeldRequest:FireServer(\"gui\")";
			if (label6.Text == "Easy")
			{
				freesex.ExecuteFromInterpreter(script);
			}
			else if (label6.Text == "Squad")
			{
				shitsquad.Execute(script);
			}
			else if (label6.Text == "MainDab")
			{
				NamedPipes.LuaPipe(script);
			}
			
		}

        private void pictureBox12_Click(object sender, EventArgs e)
        {
			Tools Form = new Tools();
			Form.Show();
		}

        private void IconUI_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
			MessageBox.Show("-- MainDab --\nMade by Main_EX#3898\nDLL by Foresaken#0254\n\ndiscord.io/maindab", "Credits");
        }

		private void pictureBox13_Click(object sender, EventArgs e)
        {
			this.backgroundWorker5.RunWorkerAsync();
		}

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
			label1.Text = "MainDab | Updating script hub...";
			listBox1.Items.Clear();
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
			this.listBox1.Items.Clear();
			try

			{
				Functions.PopulateListBox1(this.listBox1, "./bin/scripts", "*.txt");
			}
			catch
			{
				MessageBox.Show("Failed to open scripthub as it detects no scripts or folder, try close and rerun MainDab.");
				this.Hide();

			}
			label1.Text = "MainDab | Script hub update done!";
			Thread.Sleep(1000);
			label1.Text = "MainDab";
		}

        private void bunifuFlatButton9_Click_1(object sender, EventArgs e)
        {
			label6.Text = "MainDab";
			backgroundWorker6.RunWorkerAsync();
			panel3.Hide();


		}

        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
			Functions.Inject();
			label1.Text = "MainDab | Injecting MainDab DLL";
			Thread.Sleep(4000);
			label1.Text = "MainDab";
			Thread.Sleep(2000);
			WebClient webClient2 = new WebClient();
			byte[] bytes = webClient2.DownloadData("https://pastebin.com/raw/CqYKJzcv");
			string we = Encoding.UTF8.GetString(bytes);
			NamedPipes.LuaPipe(we);
		}

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {
			string script = "loadstring(game:HttpGet(\"https://www.codepile.net/raw/9Eye4JEb.lua\", true))()";

			if (label6.Text == "Easy")
			{
				freesex.ExecuteFromInterpreter(script);
				Process.Start("https://discord.gg/Z7HpAZv");
			}
			else if (label6.Text == "Squad")
			{
				shitsquad.Execute(script);
				Process.Start("https://discord.gg/Z7HpAZv");
			}
			else if (label6.Text == "MainDab")
			{
				NamedPipes.LuaPipe(script);
				Process.Start("https://discord.gg/Z7HpAZv");
			}
			else
            {
				MessageBox.Show("Please inject first!");
            }
		}
    }
}
