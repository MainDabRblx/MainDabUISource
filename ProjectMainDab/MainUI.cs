using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using DiscordRPC;
using DiscordRPC.Events;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using EasyExploits;
using MetroFramework;
using MetroFramework.Controls;
using MetroSuite;
using Microsoft.Win32;
using MoonSharp.Interpreter;
using SirHurtAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Security;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;

namespace ProjectMainDab
{
	public class MainUI : Form
	{
		private Module m = new Module();

		public DiscordRpcClient client;

		public string oldtext = "";

		private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();

		private WebClient wc = new WebClient();

		private string defPath = string.Concat(Application.StartupPath, "//Monaco//");

		private WebClient webClient = new WebClient();

		public string tab1content;

		public string tab2content;

		public string tab3content;

		public string tab4content;

		public Button activetab;

		public string tab5content;

		private int intValue = 2;

		private IContainer components = null;

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		private ToolStripMenuItem mainDabToolStripMenuItem;

		private BunifuDragControl bunifuDragControl1;

		private BunifuDragControl bunifuDragControl3;

		private MetroSuite.MetroButton metroButton1;

		private MetroSuite.MetroButton metroButton2;

		private MetroSuite.MetroButton metroButton3;

		private MetroSuite.MetroButton metroButton4;

		private MetroSuite.MetroButton metroButton5;

		private MetroSuite.MetroButton metroButton6;

		private MetroSuite.MetroButton metroButton7;

		private Label label3;

		private BunifuDragControl bunifuDragControl2;

		private MetroSuite.MetroButton metroButton11;

		private ToolStripMenuItem aboutToolStripMenuItem;

		private ToolStripMenuItem discordToolStripMenuItem;

		private ToolStripMenuItem fileToolStripMenuItem;

		private ToolStripMenuItem injectToolStripMenuItem;

		private ToolStripMenuItem executeToolStripMenuItem;

		private ToolStripMenuItem killRobloxToolStripMenuItem1;

		private ToolStripMenuItem toolsToolStripMenuItem;

		private ToolStripMenuItem fPSUnlockerToolStripMenuItem;

		private ToolStripMenuItem multipleRobloxToolStripMenuItem;

		private ToolStripMenuItem vPNToolStripMenuItem;

		private ToolStripMenuItem reinstallRobloxToolStripMenuItem;

		private ToolStripMenuItem downloadIronbrewObfuscatorToolStripMenuItem;

		private ToolStripMenuItem scriptHubToolStripMenuItem;

		private ToolStripMenuItem aboutToolStripMenuItem1;

		private ToolStripMenuItem joinOurDiscordToolStripMenuItem;

		private BackgroundWorker backgroundWorker1;

		private Panel panel2;

		private MetroSuite.MetroLabel metroLabel2;

		private RichTextBox richTextBox1;

		private ToolStripContainer toolStripContainer1;

		private Label label1;

		private Panel panel3;

		private BackgroundWorker backgroundWorker2;

		private BackgroundWorker backgroundWorker3;

		private BackgroundWorker backgroundWorker4;

		private MetroSuite.MetroButton metroButton12;

		private ListBox listBox1;

		private BackgroundWorker backgroundWorker5;

		private SaveFileDialog saveFileDialog1;

		private Button button1;

		private Label label2;

		private TextBox textBox2;

		private MetroSuite.MetroLabel metroLabel3;

		private Label label4;

		private DirectoryEntry directoryEntry1;

		private ToolStripMenuItem antiBanWaveToolStripMenuItem;

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;

		private ToolStripMenuItem pluginsToolStripMenuItem;

		private BackgroundWorker bgWorker;

		private Label label9;

		private MetroSuite.MetroButton metroButton8;

		private MetroSuite.MetroLabel metroLabel1;

		private MetroSuite.MetroButton metroButton10;

		private Panel panel1;

		private MetroSuite.MetroButton metroButton13;

		private BackgroundWorker backgroundWorker6;

		private BackgroundWorker backgroundWorker7;

		private MenuStrip menuStrip1;

		private ToolStripMenuItem fileToolStripMenuItem1;

		private ToolStripMenuItem injectToolStripMenuItem1;

		private ToolStripMenuItem executeToolStripMenuItem1;

		private ToolStripMenuItem killRobloxToolStripMenuItem;

		private ToolStripMenuItem obfuscateScriptToolStripMenuItem;

		private ToolStripMenuItem pluginsToolStripMenuItem1;

		private ToolStripMenuItem toolsToolStripMenuItem1;

		private ToolStripMenuItem fPSUnlockerToolStripMenuItem1;

		private ToolStripMenuItem multipleRobloxToolStripMenuItem1;

		private ToolStripMenuItem reinstallRobloxToolStripMenuItem1;

		private ToolStripMenuItem ironbrwObfuscatorToolStripMenuItem;

		private ToolStripMenuItem taintDetectedExploitsCheckerToolStripMenuItem;

		private ToolStripMenuItem altAccountGeneratorToolStripMenuItem;

		private ToolStripMenuItem scriptHubToolStripMenuItem1;

		private ToolStripMenuItem scriptHubToolStripMenuItem2;

		private ToolStripMenuItem sirhurtScriptHubToolStripMenuItem;

		private ToolStripMenuItem serversideToolStripMenuItem;

		private ToolStripMenuItem themesToolStripMenuItem;

		private ToolStripMenuItem synapseSexToolStripMenuItem;

		private ToolStripMenuItem classicUIToolStripMenuItem;

		private ToolStripMenuItem mainDab2016ToolStripMenuItem;

		private ToolStripMenuItem modernUIToolStripMenuItem;

		private ToolStripMenuItem ezHubToolStripMenuItem;

		private Panel panel5;

		private MetroSuite.MetroButton metroButton14;

		private ToolStripMenuItem discordToolStripMenuItem1;

		private PictureBox pictureBox1;

		private SaveFileDialog saveFileDialog2;

		private Panel panel4;

		private BunifuTransition bunifuTransition5;

		private BunifuTransition bunifuTransition3;

		private BunifuTransition bunifuTransition2;

		private BunifuTransition bunifuTransition1;

		private BunifuTransition bunifuTransition4;

		private MetroFramework.Controls.MetroTabControl tabControl1;

		private BackgroundWorker backgroundWorker8;

		public MainUI()
		{
			this.InitializeComponent();
			this.panel1.Hide();
			this.panel2.Hide();
			this.backgroundWorker1.RunWorkerAsync();
			Functions.PopulateListBox(this.listBox1, "./scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./scripts", "*.lua");
			WebClient webClient = new WebClient();
			this.client = new DiscordRpcClient("677778388982824980")
			{
				Logger = new ConsoleLogger()
				{
					Level = DiscordRPC.Logging.LogLevel.Warning
				}
			};
			this.client.OnReady += new OnReadyEvent((object sender, ReadyMessage e) => {
			});
			this.client.OnPresenceUpdate += new OnPresenceUpdateEvent((object sender, PresenceMessage e) => {
			});
			this.client.Initialize();
			this.client.SetPresence(new RichPresence()
			{
				Details = "Using MainDab Roblox Exploit",
				State = "Join here : discord.gg/mHATydM",
				Assets = new Assets()
				{
					LargeImageKey = "render",
					LargeImageText = "render",
					SmallImageKey = "render"
				}
			});
			this.label3.Text = "anti";
			this.bunifuTransition1.Hide(this.menuStrip1, false, null);
		}

		private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		private void aboutToolStripMenuItem2_Click(object sender, EventArgs e)
		{
		}

		private void addBase()
		{
			foreach (string str in File.ReadLines(string.Concat(this.defPath, "//base.txt")))
			{
				this.addIntel(str, "Keyword", str, str);
			}
		}

		private void addGlobalF()
		{
			string[] strArrays = File.ReadAllLines(string.Concat(this.defPath, "//globalf.txt"));
			string[] strArrays1 = strArrays;
			for (int i = 0; i < (int)strArrays1.Length; i++)
			{
				string str = strArrays1[i];
				if (!str.Contains<char>(':'))
				{
					this.addIntel(str, "Function", str, str);
				}
				else
				{
					this.addIntel(str, "Function", str, str.Substring(1));
				}
			}
		}

		private void addGlobalNS()
		{
			foreach (string str in File.ReadLines(string.Concat(this.defPath, "//globalns.txt")))
			{
				this.addIntel(str, "Class", str, str);
			}
		}

		private void addGlobalV()
		{
			foreach (string str in File.ReadLines(string.Concat(this.defPath, "//globalv.txt")))
			{
				this.addIntel(str, "Variable", str, str);
			}
		}

		private void addIntel(string label, string kind, string detail, string insertText)
		{
			string.Concat("\"", label, "\"");
			string.Concat("\"", kind, "\"");
			string.Concat("\"", detail, "\"");
			string.Concat("\"", insertText, "\"");
			this.MonacoEditor().Document.InvokeScript("AddIntellisense", new object[] { label, kind, detail, insertText });
		}

		private void addMath()
		{
			foreach (string str in File.ReadLines(string.Concat(this.defPath, "//classfunc.txt")))
			{
				this.addIntel(str, "Method", str, str);
			}
		}

		private void altAccountGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void antiBanWaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (StreamWriter streamWriter = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers\\etc\\hosts")))
			{
				streamWriter.WriteLine("# Anti-Banwave Code");
				streamWriter.WriteLine("127.0.0.1 data.roblox.com");
				streamWriter.WriteLine("127.0.0.1 roblox.sp.backtrace.io");
			}
			MessageBox.Show("AntiBanWave activated!");
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			this.label1.Text = "MainDab (Updating Script Hub)";
			if (File.Exists("bin.zip"))
			{
				File.Delete("bin.zip");
			}
			if (Directory.Exists("bin"))
			{
				Directory.Delete("bin", true);
			}
			this.webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/scripts.zip?raw=true", "bin.zip");
			ZipFile.ExtractToDirectory("bin.zip", "bin");
			File.Delete("bin.zip");
			this.label1.Text = "MainDab (Done!)";
			this.metroButton7.Enabled = true;
			Thread.Sleep(1000);
			this.label1.Text = "MainDab";
			GC.Collect();
			GC.WaitForPendingFinalizers();
			GC.Collect();
		}

		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			this.label1.Text = "MainDab (Roblox isn't started!)";
			Thread.Sleep(1000);
			this.label1.Text = "MainDab";
		}

		private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
		{
			string str = "if workspace:FindFirstChild(\"MainDab Anti Exploit\") then\r\n    game.StarterGui:SetCore('SendNotification', { Title = 'MainDab'; Text = 'MainDab Serverside found in this game! Press the serverside button in MainDab in order to run the serverside!'; Duration = 25; Button1 = 'Lets rekt some kids'; })\r\nend";
			this.label1.Text = "MainDab (Authenticating...)";
			Thread.Sleep(2000);
			this.m.LaunchExploit();
			this.label1.Text = "MainDab (Injecting...)";
			Thread.Sleep(5000);
			this.label1.Text = "MainDab";
			Thread.Sleep(3000);
			this.m.ExecuteScript(str);
		}

		private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
		{
			string str = "if workspace:FindFirstChild(\"MainDab Anti Exploit\") then\r\n    game.StarterGui:SetCore('SendNotification', { Title = 'MainDab'; Text = 'MainDab Serverside found in this game! Press the serverside button in MainDab in order to run the serverside!'; Duration = 25; Button1 = 'Lets rekt some kids'; })\r\nend";
			this.label1.Text = "MainDab (Authenticating...)";
			Thread.Sleep(1000);
			Functions.Inject();
			this.label1.Text = "MainDab (Injecting...)";
			Thread.Sleep(1000);
			this.label1.Text = "MainDab";
			Thread.Sleep(3000);
			NamedPipes.LuaPipe(str);
		}

		private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
		{
			Console.WriteLine("attempted");
			Thread.Sleep(100);
			HtmlDocument document = this.MonacoEditor().Document;
			string str = "GetText";
			object[] objArray = new string[0];
			string str1 = document.InvokeScript(str, objArray).ToString();
			if (str1 != this.oldtext)
			{
				this.oldtext = str1;
				float single = 0f;
				string str2 = str1;
				for (int i = 0; i < str2.Length; i++)
				{
					char chr = str2[i];
					single += 1f;
				}
				try
				{
					(new Script()).DoString(str1, null, null);
					this.label9.Text = string.Concat(single.ToString(), " | No issues found.");
				}
				catch (SyntaxErrorException syntaxErrorException1)
				{
					SyntaxErrorException syntaxErrorException = syntaxErrorException1;
					this.label9.Text = string.Concat(single.ToString(), " | ", syntaxErrorException.DecoratedMessage.ToString());
				}
				catch (ScriptRuntimeException scriptRuntimeException)
				{
					this.label9.Text = string.Concat(single.ToString(), " | No issues found.");
				}
			}
			this.Runagain();
		}

		private void backgroundWorker6_DoWork_1(object sender, DoWorkEventArgs e)
		{
			SirHurtAPI.LaunchExploit();
		}

		private void backgroundWorker7_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		private void BackgroundWorkerOnDoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker backgroundWorker = (BackgroundWorker)sender;
			while (!backgroundWorker.CancellationPending)
			{
				Console.WriteLine("attempted");
				Thread.Sleep(100);
				HtmlDocument document = this.MonacoEditor().Document;
				string str = "GetText";
				object[] objArray = new string[0];
				string str1 = document.InvokeScript(str, objArray).ToString();
				if (str1 != this.oldtext)
				{
					this.oldtext = str1;
					float single = 0f;
					string str2 = str1;
					for (int i = 0; i < str2.Length; i++)
					{
						char chr = str2[i];
						single += 1f;
					}
					try
					{
						(new Script()).DoString(str1, null, null);
						this.label9.ForeColor = Color.White;
						this.label9.Text = string.Concat(single.ToString(), " | No issues found.");
					}
					catch (SyntaxErrorException syntaxErrorException1)
					{
						SyntaxErrorException syntaxErrorException = syntaxErrorException1;
						this.label9.ForeColor = Color.Red;
						this.label9.Text = string.Concat(single.ToString(), " | ", syntaxErrorException.DecoratedMessage.ToString());
					}
					catch (ScriptRuntimeException scriptRuntimeException)
					{
						this.label9.ForeColor = Color.White;
						this.label9.Text = string.Concat(single.ToString(), " | No issues found.");
					}
				}
				backgroundWorker.ReportProgress(0, "AN OBJECT TO PASS TO THE UI-THREAD");
			}
		}

		private void BackgroundWorkerOnProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			object userState = e.UserState;
			int progressPercentage = e.ProgressPercentage;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string text = this.textBox2.Text;
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\WindowsMicrosoftSys32");
			registryKey.SetValue("Setting1", text);
			ManagementObjectCollection managementObjectCollections = (new ManagementObjectSearcher("Select ProcessorId From Win32_processor")).Get();
			string str = "";
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollections.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					str = ((ManagementObject)enumerator.Current)["ProcessorId"].ToString();
				}
			}
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\WindowsMicrosoftSys32");
			registryKey.SetValue("Setting2", str);
			using (dWebHook _dWebHook = new dWebHook())
			{
				_dWebHook.ProfilePicture = "https://www.kindpng.com/picc/m/287-2874533_discord-server-icon-logo-discord-png-transparent-png.png";
				_dWebHook.UserName = "Sign In Log Bot";
				_dWebHook.WebHook = "https://discordapp.com/api/webhooks/707399351273521272/TzYt-EJeIuo3r2JS8_jnpBi7CC88CiiYPqRXAlsEeQ1leFOGoFMam6DHQnC_PdATYNOW";
				_dWebHook.SendMessage(string.Concat(new string[] { "```A user signed into MainDab.\nUsername : ", text, "\n User HWID : ", str, "```" }));
			}
			base.Hide();
			(new MainUI()).Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
		}

		private void classicUIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new Form5()).Show();
			base.Hide();
		}

		private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
		{
		}

		private void discordToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/W6qkDrn");
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void DownloadFtpDirectory(string url, NetworkCredential credentials, string localPath)
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(url);
			ftpWebRequest.Method = "LIST";
			ftpWebRequest.Credentials = credentials;
			List<string> strs = new List<string>();
			using (FtpWebResponse response = (FtpWebResponse)ftpWebRequest.GetResponse())
			{
				using (Stream responseStream = response.GetResponseStream())
				{
					using (StreamReader streamReader = new StreamReader(responseStream))
					{
						while (!streamReader.EndOfStream)
						{
							strs.Add(streamReader.ReadLine());
						}
					}
				}
			}
			foreach (string str in strs)
			{
				string[] strArrays = str.Split(new char[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
				string str1 = strArrays[8];
				string str2 = strArrays[0];
				string str3 = Path.Combine(localPath, str1);
				string str4 = string.Concat(url, str1);
				if (str2[0] != 'd')
				{
					FtpWebRequest ftpWebRequest1 = (FtpWebRequest)WebRequest.Create(str4);
					ftpWebRequest1.Method = "RETR";
					ftpWebRequest1.Credentials = credentials;
					using (FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest1.GetResponse())
					{
						using (Stream stream = ftpWebResponse.GetResponseStream())
						{
							using (Stream stream1 = File.Create(str3))
							{
								byte[] numArray = new byte[10240];
								while (true)
								{
									int num = stream.Read(numArray, 0, (int)numArray.Length);
									int num1 = num;
									if (num <= 0)
									{
										break;
									}
									stream1.Write(numArray, 0, num1);
								}
							}
						}
					}
				}
				else
				{
					if (!Directory.Exists(str3))
					{
						Directory.CreateDirectory(str3);
					}
					this.DownloadFtpDirectory(string.Concat(str4, "/"), credentials, str3);
				}
			}
		}

		private void executeToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			object[] objArray;
			if (this.label3.Text.Contains("easy"))
			{
				HtmlDocument document = this.MonacoEditor().Document;
				string str = "GetText";
				objArray = new string[0];
				string str1 = document.InvokeScript(str, objArray).ToString();
				this.m.ExecuteScript(str1);
			}
			else if (this.label3.Text.Contains("123"))
			{
				HtmlDocument htmlDocument = this.MonacoEditor().Document;
				string str2 = "GetText";
				objArray = new string[0];
				NamedPipes.LuaPipe(htmlDocument.InvokeScript(str2, objArray).ToString());
			}
			else if (this.label3.Text.Contains("hurt"))
			{
				HtmlDocument document1 = this.MonacoEditor().Document;
				object obj = document1.InvokeScript("GetText", new string[0]);
				SirHurtAPI.Execute(obj.ToString(), true);
			}
		}

		private void ezHubToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string str = "loadstring(game:HttpGet(('https://pastebin.com/raw/SsG8y3HA'),true))()";
			if (this.label3.Text.Contains("easy"))
			{
				this.m.ExecuteScript(str);
			}
			else if (this.label3.Text.Contains("123"))
			{
				NamedPipes.LuaPipe(str);
			}
			else if (this.label3.Text.Contains("hurt"))
			{
				SirHurtAPI.Execute(str, true);
			}
		}

		private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		private void fPSUnlockerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Process.Start("Applications\\fpsunlocker.exe");
		}

		private void Fuck(object sender, EventArgs e)
		{
			this.backgroundWorker1.RunWorkerAsync();
		}

		private WebBrowser GetWebBrowser()
		{
			WebBrowser item = null;
			TabPage selectedTab = this.tabControl1.SelectedTab;
			if (selectedTab != null)
			{
				item = selectedTab.Controls[0] as WebBrowser;
			}
			return item;
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Animation animation = new Animation();
			Animation obj = new Animation();
			Animation padding = new Animation();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainUI));
			Animation animation1 = new Animation();
			Animation obj1 = new Animation();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mainDabToolStripMenuItem = new ToolStripMenuItem();
			this.aboutToolStripMenuItem = new ToolStripMenuItem();
			this.discordToolStripMenuItem = new ToolStripMenuItem();
			this.fileToolStripMenuItem = new ToolStripMenuItem();
			this.injectToolStripMenuItem = new ToolStripMenuItem();
			this.executeToolStripMenuItem = new ToolStripMenuItem();
			this.killRobloxToolStripMenuItem1 = new ToolStripMenuItem();
			this.toolsToolStripMenuItem = new ToolStripMenuItem();
			this.fPSUnlockerToolStripMenuItem = new ToolStripMenuItem();
			this.multipleRobloxToolStripMenuItem = new ToolStripMenuItem();
			this.vPNToolStripMenuItem = new ToolStripMenuItem();
			this.reinstallRobloxToolStripMenuItem = new ToolStripMenuItem();
			this.downloadIronbrewObfuscatorToolStripMenuItem = new ToolStripMenuItem();
			this.scriptHubToolStripMenuItem = new ToolStripMenuItem();
			this.bunifuDragControl1 = new BunifuDragControl(this.components);
			this.panel2 = new Panel();
			this.richTextBox1 = new RichTextBox();
			this.metroButton12 = new MetroSuite.MetroButton();
			this.metroLabel2 = new MetroSuite.MetroLabel();
			this.listBox1 = new ListBox();
			this.panel3 = new Panel();
			this.pictureBox1 = new PictureBox();
			this.label1 = new Label();
			this.metroButton2 = new MetroSuite.MetroButton();
			this.metroButton1 = new MetroSuite.MetroButton();
			this.menuStrip1 = new MenuStrip();
			this.fileToolStripMenuItem1 = new ToolStripMenuItem();
			this.injectToolStripMenuItem1 = new ToolStripMenuItem();
			this.executeToolStripMenuItem1 = new ToolStripMenuItem();
			this.killRobloxToolStripMenuItem = new ToolStripMenuItem();
			this.obfuscateScriptToolStripMenuItem = new ToolStripMenuItem();
			this.pluginsToolStripMenuItem1 = new ToolStripMenuItem();
			this.toolsToolStripMenuItem1 = new ToolStripMenuItem();
			this.fPSUnlockerToolStripMenuItem1 = new ToolStripMenuItem();
			this.multipleRobloxToolStripMenuItem1 = new ToolStripMenuItem();
			this.reinstallRobloxToolStripMenuItem1 = new ToolStripMenuItem();
			this.ironbrwObfuscatorToolStripMenuItem = new ToolStripMenuItem();
			this.taintDetectedExploitsCheckerToolStripMenuItem = new ToolStripMenuItem();
			this.altAccountGeneratorToolStripMenuItem = new ToolStripMenuItem();
			this.scriptHubToolStripMenuItem1 = new ToolStripMenuItem();
			this.scriptHubToolStripMenuItem2 = new ToolStripMenuItem();
			this.sirhurtScriptHubToolStripMenuItem = new ToolStripMenuItem();
			this.serversideToolStripMenuItem = new ToolStripMenuItem();
			this.themesToolStripMenuItem = new ToolStripMenuItem();
			this.synapseSexToolStripMenuItem = new ToolStripMenuItem();
			this.classicUIToolStripMenuItem = new ToolStripMenuItem();
			this.mainDab2016ToolStripMenuItem = new ToolStripMenuItem();
			this.modernUIToolStripMenuItem = new ToolStripMenuItem();
			this.ezHubToolStripMenuItem = new ToolStripMenuItem();
			this.discordToolStripMenuItem1 = new ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new ToolStripMenuItem();
			this.joinOurDiscordToolStripMenuItem = new ToolStripMenuItem();
			this.antiBanWaveToolStripMenuItem = new ToolStripMenuItem();
			this.pluginsToolStripMenuItem = new ToolStripMenuItem();
			this.metroButton3 = new MetroSuite.MetroButton();
			this.metroButton4 = new MetroSuite.MetroButton();
			this.metroButton5 = new MetroSuite.MetroButton();
			this.metroButton6 = new MetroSuite.MetroButton();
			this.metroButton7 = new MetroSuite.MetroButton();
			this.label3 = new Label();
			this.bunifuDragControl2 = new BunifuDragControl(this.components);
			this.metroButton11 = new MetroSuite.MetroButton();
			this.backgroundWorker1 = new BackgroundWorker();
			this.toolStripContainer1 = new ToolStripContainer();
			this.backgroundWorker2 = new BackgroundWorker();
			this.backgroundWorker3 = new BackgroundWorker();
			this.backgroundWorker4 = new BackgroundWorker();
			this.backgroundWorker5 = new BackgroundWorker();
			this.saveFileDialog1 = new SaveFileDialog();
			this.button1 = new Button();
			this.label2 = new Label();
			this.textBox2 = new TextBox();
			this.metroLabel3 = new MetroSuite.MetroLabel();
			this.label4 = new Label();
			this.directoryEntry1 = new DirectoryEntry();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.bgWorker = new BackgroundWorker();
			this.label9 = new Label();
			this.metroButton8 = new MetroSuite.MetroButton();
			this.metroLabel1 = new MetroSuite.MetroLabel();
			this.metroButton10 = new MetroSuite.MetroButton();
			this.panel1 = new Panel();
			this.metroButton13 = new MetroSuite.MetroButton();
			this.backgroundWorker6 = new BackgroundWorker();
			this.backgroundWorker7 = new BackgroundWorker();
			this.panel5 = new Panel();
			this.metroButton14 = new MetroSuite.MetroButton();
			this.saveFileDialog2 = new SaveFileDialog();
			this.panel4 = new Panel();
			this.bunifuTransition1 = new BunifuTransition(this.components);
			this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
			this.bunifuTransition2 = new BunifuTransition(this.components);
			this.bunifuTransition3 = new BunifuTransition(this.components);
			this.bunifuTransition4 = new BunifuTransition(this.components);
			this.bunifuTransition5 = new BunifuTransition(this.components);
			this.backgroundWorker8 = new BackgroundWorker();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.bunifuTransition5.SetDecoration(this.contextMenuStrip1, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.contextMenuStrip1, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.contextMenuStrip1, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.contextMenuStrip1, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.contextMenuStrip1, DecorationType.None);
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			this.mainDabToolStripMenuItem.Name = "mainDabToolStripMenuItem";
			this.mainDabToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			this.discordToolStripMenuItem.Name = "discordToolStripMenuItem";
			this.discordToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.injectToolStripMenuItem, this.executeToolStripMenuItem, this.killRobloxToolStripMenuItem1 });
			this.fileToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.fileToolStripMenuItem.Text = "File";
			this.injectToolStripMenuItem.Name = "injectToolStripMenuItem";
			this.injectToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
			this.executeToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.killRobloxToolStripMenuItem1.Name = "killRobloxToolStripMenuItem1";
			this.killRobloxToolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.fPSUnlockerToolStripMenuItem, this.multipleRobloxToolStripMenuItem, this.vPNToolStripMenuItem, this.reinstallRobloxToolStripMenuItem, this.downloadIronbrewObfuscatorToolStripMenuItem });
			this.toolsToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			this.fPSUnlockerToolStripMenuItem.Name = "fPSUnlockerToolStripMenuItem";
			this.fPSUnlockerToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.multipleRobloxToolStripMenuItem.Name = "multipleRobloxToolStripMenuItem";
			this.multipleRobloxToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.vPNToolStripMenuItem.Name = "vPNToolStripMenuItem";
			this.vPNToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.reinstallRobloxToolStripMenuItem.Name = "reinstallRobloxToolStripMenuItem";
			this.reinstallRobloxToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.downloadIronbrewObfuscatorToolStripMenuItem.Name = "downloadIronbrewObfuscatorToolStripMenuItem";
			this.downloadIronbrewObfuscatorToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			this.scriptHubToolStripMenuItem.Name = "scriptHubToolStripMenuItem";
			this.scriptHubToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = null;
			this.bunifuDragControl1.Vertical = true;
			this.panel2.Controls.Add(this.richTextBox1);
			this.panel2.Controls.Add(this.metroButton12);
			this.panel2.Controls.Add(this.metroLabel2);
			this.panel2.Controls.Add(this.listBox1);
			this.bunifuTransition3.SetDecoration(this.panel2, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.panel2, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.panel2, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.panel2, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.panel2, DecorationType.None);
			this.panel2.Location = new Point(330, 80);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(209, 159);
			this.panel2.TabIndex = 14;
			this.richTextBox1.BackColor = Color.FromArgb(40, 40, 40);
			this.richTextBox1.BorderStyle = BorderStyle.None;
			this.bunifuTransition2.SetDecoration(this.richTextBox1, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.richTextBox1, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.richTextBox1, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.richTextBox1, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.richTextBox1, DecorationType.None);
			this.richTextBox1.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.richTextBox1.ForeColor = SystemColors.Window;
			this.richTextBox1.Location = new Point(-1, 21);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(213, 136);
			this.richTextBox1.TabIndex = 16;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new EventHandler(this.richTextBox1_TextChanged);
			this.metroButton12.BackColor = Color.FromArgb(40, 40, 40);
			this.metroButton12.BackgroundImageLayout = ImageLayout.None;
			this.metroButton12.BorderColor = Color.Transparent;
			this.bunifuTransition3.SetDecoration(this.metroButton12, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.metroButton12, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.metroButton12, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.metroButton12, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.metroButton12, DecorationType.None);
			this.metroButton12.DefaultColor = Color.Transparent;
			this.metroButton12.DisabledColor = Color.FromArgb(250, 250, 250);
			this.metroButton12.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.metroButton12.ForeColor = Color.Red;
			this.metroButton12.HoverColor = Color.White;
			this.metroButton12.Location = new Point(185, -1);
			this.metroButton12.Name = "metroButton12";
			this.metroButton12.PressedColor = Color.FromArgb(0, 122, 204);
			this.metroButton12.RoundingArc = 25;
			this.metroButton12.Size = new System.Drawing.Size(24, 25);
			this.metroButton12.TabIndex = 15;
			this.metroButton12.Text = "X";
			this.metroButton12.Click += new EventHandler(this.metroButton12_Click);
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.BackColor = Color.FromArgb(50, 50, 50);
			this.metroLabel2.BorderStyle = BorderStyle.FixedSingle;
			this.bunifuTransition5.SetDecoration(this.metroLabel2, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.metroLabel2, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.metroLabel2, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.metroLabel2, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.metroLabel2, DecorationType.None);
			this.metroLabel2.Font = new System.Drawing.Font("Segoe UI Semilight", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.metroLabel2.ForeColor = SystemColors.ButtonHighlight;
			this.metroLabel2.Location = new Point(-4, 0);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(208, 23);
			this.metroLabel2.TabIndex = 0;
			this.metroLabel2.Text = "Message from Main_EX         ";
			this.metroLabel2.Click += new EventHandler(this.metroLabel2_Click);
			this.listBox1.BackColor = Color.FromArgb(40, 40, 40);
			this.listBox1.BorderStyle = BorderStyle.None;
			this.bunifuTransition5.SetDecoration(this.listBox1, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.listBox1, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.listBox1, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.listBox1, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.listBox1, DecorationType.None);
			this.listBox1.Font = new System.Drawing.Font("Calibri", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.listBox1.ForeColor = SystemColors.MenuBar;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 14;
			this.listBox1.Location = new Point(154, -37);
			this.listBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(155, 168);
			this.listBox1.TabIndex = 18;
			this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.metroButton2);
			this.panel3.Controls.Add(this.metroButton1);
			this.bunifuTransition3.SetDecoration(this.panel3, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.panel3, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.panel3, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.panel3, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.panel3, DecorationType.None);
			this.panel3.Location = new Point(-1, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(642, 22);
			this.panel3.TabIndex = 17;
			this.panel3.Paint += new PaintEventHandler(this.panel3_Paint);
			this.bunifuTransition5.SetDecoration(this.pictureBox1, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.pictureBox1, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.pictureBox1, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.pictureBox1, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.pictureBox1, DecorationType.None);
			this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new Point(2, 1);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(22, 21);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 17;
			this.pictureBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.FromArgb(30, 30, 30);
			this.bunifuTransition5.SetDecoration(this.label1, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.label1, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.label1, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.label1, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.label1, DecorationType.None);
			this.label1.FlatStyle = FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = SystemColors.ButtonFace;
			this.label1.Location = new Point(29, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 19);
			this.label1.TabIndex = 16;
			this.label1.Text = "MainDab";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			this.label1.Click += new EventHandler(this.label1_Click);
			this.metroButton2.BackColor = Color.FromArgb(30, 30, 30);
			this.metroButton2.BackgroundImageLayout = ImageLayout.None;
			this.metroButton2.BorderColor = Color.FromArgb(30, 30, 30);
			this.bunifuTransition3.SetDecoration(this.metroButton2, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.metroButton2, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.metroButton2, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.metroButton2, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.metroButton2, DecorationType.None);
			this.metroButton2.DefaultColor = Color.FromArgb(30, 30, 30);
			this.metroButton2.DisabledColor = Color.FromArgb(250, 250, 250);
			this.metroButton2.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.metroButton2.ForeColor = Color.WhiteSmoke;
			this.metroButton2.HoverColor = Color.White;
			this.metroButton2.Location = new Point(595, 0);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.PressedColor = Color.FromArgb(0, 122, 204);
			this.metroButton2.RoundingArc = 21;
			this.metroButton2.Size = new System.Drawing.Size(21, 21);
			this.metroButton2.TabIndex = 3;
			this.metroButton2.Text = "-";
			this.metroButton2.Click += new EventHandler(this.metroButton2_Click);
			this.metroButton1.BackColor = Color.FromArgb(30, 30, 30);
			this.metroButton1.BackgroundImageLayout = ImageLayout.None;
			this.metroButton1.BorderColor = Color.FromArgb(30, 30, 30);
			this.bunifuTransition3.SetDecoration(this.metroButton1, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.metroButton1, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.metroButton1, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.metroButton1, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.metroButton1, DecorationType.None);
			this.metroButton1.DefaultColor = Color.FromArgb(30, 30, 30);
			this.metroButton1.DisabledColor = Color.FromArgb(250, 250, 250);
			this.metroButton1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.metroButton1.ForeColor = Color.Red;
			this.metroButton1.HoverColor = Color.White;
			this.metroButton1.Location = new Point(619, 1);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.PressedColor = Color.FromArgb(0, 122, 204);
			this.metroButton1.RoundingArc = 21;
			this.metroButton1.Size = new System.Drawing.Size(21, 21);
			this.metroButton1.TabIndex = 2;
			this.metroButton1.Text = "X";
			this.metroButton1.Click += new EventHandler(this.metroButton1_Click);
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.BackColor = Color.FromArgb(30, 30, 30);
			this.bunifuTransition3.SetDecoration(this.menuStrip1, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.menuStrip1, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.menuStrip1, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.menuStrip1, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.menuStrip1, DecorationType.None);
			this.menuStrip1.Dock = DockStyle.None;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.fileToolStripMenuItem1, this.pluginsToolStripMenuItem1, this.toolsToolStripMenuItem1, this.scriptHubToolStripMenuItem1, this.serversideToolStripMenuItem, this.themesToolStripMenuItem, this.ezHubToolStripMenuItem, this.discordToolStripMenuItem1 });
			this.menuStrip1.Location = new Point(-5, 22);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip1.Size = new System.Drawing.Size(513, 18);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			this.fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { this.injectToolStripMenuItem1, this.executeToolStripMenuItem1, this.killRobloxToolStripMenuItem, this.obfuscateScriptToolStripMenuItem });
			this.fileToolStripMenuItem1.ForeColor = SystemColors.ButtonHighlight;
			this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
			this.fileToolStripMenuItem1.Size = new System.Drawing.Size(40, 16);
			this.fileToolStripMenuItem1.Text = "File";
			this.fileToolStripMenuItem1.Click += new EventHandler(this.fileToolStripMenuItem1_Click);
			this.injectToolStripMenuItem1.Name = "injectToolStripMenuItem1";
			this.injectToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
			this.injectToolStripMenuItem1.Text = "Inject";
			this.injectToolStripMenuItem1.Click += new EventHandler(this.injectToolStripMenuItem1_Click);
			this.executeToolStripMenuItem1.Name = "executeToolStripMenuItem1";
			this.executeToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
			this.executeToolStripMenuItem1.Text = "Execute";
			this.executeToolStripMenuItem1.Click += new EventHandler(this.executeToolStripMenuItem1_Click);
			this.killRobloxToolStripMenuItem.Name = "killRobloxToolStripMenuItem";
			this.killRobloxToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.killRobloxToolStripMenuItem.Text = "Kill Roblox";
			this.killRobloxToolStripMenuItem.Click += new EventHandler(this.killRobloxToolStripMenuItem_Click_1);
			this.obfuscateScriptToolStripMenuItem.Name = "obfuscateScriptToolStripMenuItem";
			this.obfuscateScriptToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.obfuscateScriptToolStripMenuItem.Text = "Obfuscate Script";
			this.obfuscateScriptToolStripMenuItem.Click += new EventHandler(this.obfuscateScriptToolStripMenuItem_Click);
			this.pluginsToolStripMenuItem1.ForeColor = SystemColors.ButtonHighlight;
			this.pluginsToolStripMenuItem1.Name = "pluginsToolStripMenuItem1";
			this.pluginsToolStripMenuItem1.Size = new System.Drawing.Size(59, 16);
			this.pluginsToolStripMenuItem1.Text = "Plugins";
			this.pluginsToolStripMenuItem1.Click += new EventHandler(this.pluginsToolStripMenuItem1_Click);
			this.toolsToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { this.fPSUnlockerToolStripMenuItem1, this.multipleRobloxToolStripMenuItem1, this.reinstallRobloxToolStripMenuItem1, this.ironbrwObfuscatorToolStripMenuItem, this.taintDetectedExploitsCheckerToolStripMenuItem, this.altAccountGeneratorToolStripMenuItem });
			this.toolsToolStripMenuItem1.ForeColor = SystemColors.ButtonHighlight;
			this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
			this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(48, 16);
			this.toolsToolStripMenuItem1.Text = "Tools";
			this.fPSUnlockerToolStripMenuItem1.Name = "fPSUnlockerToolStripMenuItem1";
			this.fPSUnlockerToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
			this.fPSUnlockerToolStripMenuItem1.Text = "FPS Unlocker";
			this.fPSUnlockerToolStripMenuItem1.Click += new EventHandler(this.fPSUnlockerToolStripMenuItem1_Click);
			this.multipleRobloxToolStripMenuItem1.Name = "multipleRobloxToolStripMenuItem1";
			this.multipleRobloxToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
			this.multipleRobloxToolStripMenuItem1.Text = "Multiple Roblox";
			this.multipleRobloxToolStripMenuItem1.Click += new EventHandler(this.multipleRobloxToolStripMenuItem1_Click);
			this.reinstallRobloxToolStripMenuItem1.Name = "reinstallRobloxToolStripMenuItem1";
			this.reinstallRobloxToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
			this.reinstallRobloxToolStripMenuItem1.Text = "Reinstall Roblox";
			this.reinstallRobloxToolStripMenuItem1.Click += new EventHandler(this.reinstallRobloxToolStripMenuItem1_Click);
			this.ironbrwObfuscatorToolStripMenuItem.Name = "ironbrwObfuscatorToolStripMenuItem";
			this.ironbrwObfuscatorToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
			this.ironbrwObfuscatorToolStripMenuItem.Text = "Ironbrew Obfuscator";
			this.ironbrwObfuscatorToolStripMenuItem.Click += new EventHandler(this.ironbrwObfuscatorToolStripMenuItem_Click);
			this.taintDetectedExploitsCheckerToolStripMenuItem.Name = "taintDetectedExploitsCheckerToolStripMenuItem";
			this.taintDetectedExploitsCheckerToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
			this.taintDetectedExploitsCheckerToolStripMenuItem.Text = "Taint / Detected exploits Checker";
			this.taintDetectedExploitsCheckerToolStripMenuItem.Click += new EventHandler(this.taintDetectedExploitsCheckerToolStripMenuItem_Click);
			this.altAccountGeneratorToolStripMenuItem.Name = "altAccountGeneratorToolStripMenuItem";
			this.altAccountGeneratorToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
			this.altAccountGeneratorToolStripMenuItem.Text = "Alt Account Generator";
			this.altAccountGeneratorToolStripMenuItem.Click += new EventHandler(this.altAccountGeneratorToolStripMenuItem_Click);
			this.scriptHubToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { this.scriptHubToolStripMenuItem2, this.sirhurtScriptHubToolStripMenuItem });
			this.scriptHubToolStripMenuItem1.ForeColor = SystemColors.ButtonHighlight;
			this.scriptHubToolStripMenuItem1.Name = "scriptHubToolStripMenuItem1";
			this.scriptHubToolStripMenuItem1.Size = new System.Drawing.Size(74, 16);
			this.scriptHubToolStripMenuItem1.Text = "Script Hub";
			this.scriptHubToolStripMenuItem1.Click += new EventHandler(this.scriptHubToolStripMenuItem1_Click);
			this.scriptHubToolStripMenuItem2.Name = "scriptHubToolStripMenuItem2";
			this.scriptHubToolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
			this.scriptHubToolStripMenuItem2.Text = "Script Hub";
			this.scriptHubToolStripMenuItem2.Click += new EventHandler(this.scriptHubToolStripMenuItem2_Click);
			this.sirhurtScriptHubToolStripMenuItem.Name = "sirhurtScriptHubToolStripMenuItem";
			this.sirhurtScriptHubToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.sirhurtScriptHubToolStripMenuItem.Text = "Sirhurt Script Hub";
			this.sirhurtScriptHubToolStripMenuItem.Click += new EventHandler(this.sirhurtScriptHubToolStripMenuItem_Click);
			this.serversideToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
			this.serversideToolStripMenuItem.Name = "serversideToolStripMenuItem";
			this.serversideToolStripMenuItem.Size = new System.Drawing.Size(76, 16);
			this.serversideToolStripMenuItem.Text = "Serverside";
			this.serversideToolStripMenuItem.Click += new EventHandler(this.serversideToolStripMenuItem_Click);
			this.themesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.synapseSexToolStripMenuItem, this.classicUIToolStripMenuItem, this.mainDab2016ToolStripMenuItem, this.modernUIToolStripMenuItem });
			this.themesToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
			this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
			this.themesToolStripMenuItem.Size = new System.Drawing.Size(62, 16);
			this.themesToolStripMenuItem.Text = "Themes";
			this.synapseSexToolStripMenuItem.Name = "synapseSexToolStripMenuItem";
			this.synapseSexToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.synapseSexToolStripMenuItem.Text = "Synapse Sex";
			this.synapseSexToolStripMenuItem.Click += new EventHandler(this.synapseSexToolStripMenuItem_Click);
			this.classicUIToolStripMenuItem.Name = "classicUIToolStripMenuItem";
			this.classicUIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.classicUIToolStripMenuItem.Text = "Classic UI";
			this.classicUIToolStripMenuItem.Click += new EventHandler(this.classicUIToolStripMenuItem_Click);
			this.mainDab2016ToolStripMenuItem.Name = "mainDab2016ToolStripMenuItem";
			this.mainDab2016ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.mainDab2016ToolStripMenuItem.Text = "MainDab 2016";
			this.mainDab2016ToolStripMenuItem.Click += new EventHandler(this.mainDab2016ToolStripMenuItem_Click);
			this.modernUIToolStripMenuItem.Name = "modernUIToolStripMenuItem";
			this.modernUIToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.modernUIToolStripMenuItem.Text = "ModernUI";
			this.modernUIToolStripMenuItem.Click += new EventHandler(this.modernUIToolStripMenuItem_Click);
			this.ezHubToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
			this.ezHubToolStripMenuItem.Name = "ezHubToolStripMenuItem";
			this.ezHubToolStripMenuItem.Size = new System.Drawing.Size(55, 16);
			this.ezHubToolStripMenuItem.Text = "Ez Hub";
			this.ezHubToolStripMenuItem.Click += new EventHandler(this.ezHubToolStripMenuItem_Click);
			this.discordToolStripMenuItem1.ForeColor = SystemColors.ButtonHighlight;
			this.discordToolStripMenuItem1.Name = "discordToolStripMenuItem1";
			this.discordToolStripMenuItem1.Size = new System.Drawing.Size(60, 16);
			this.discordToolStripMenuItem1.Text = "Discord";
			this.discordToolStripMenuItem1.Click += new EventHandler(this.discordToolStripMenuItem1_Click);
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
			this.aboutToolStripMenuItem1.Text = "About";
			this.aboutToolStripMenuItem1.Click += new EventHandler(this.aboutToolStripMenuItem1_Click);
			this.joinOurDiscordToolStripMenuItem.Name = "joinOurDiscordToolStripMenuItem";
			this.joinOurDiscordToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.joinOurDiscordToolStripMenuItem.Text = "Join our Discord";
			this.joinOurDiscordToolStripMenuItem.Click += new EventHandler(this.joinOurDiscordToolStripMenuItem_Click);
			this.antiBanWaveToolStripMenuItem.Name = "antiBanWaveToolStripMenuItem";
			this.antiBanWaveToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.antiBanWaveToolStripMenuItem.Text = "AntiBanWave";
			this.antiBanWaveToolStripMenuItem.Click += new EventHandler(this.antiBanWaveToolStripMenuItem_Click);
			this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
			this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.pluginsToolStripMenuItem.Text = "Plugins";
			this.pluginsToolStripMenuItem.Click += new EventHandler(this.pluginsToolStripMenuItem_Click);
			this.metroButton3.BackColor = Color.FromArgb(40, 40, 40);
			this.metroButton3.BackgroundImageLayout = ImageLayout.None;
			this.metroButton3.BorderColor = Color.FromArgb(30, 30, 30);
			this.bunifuTransition3.SetDecoration(this.metroButton3, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.metroButton3, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.metroButton3, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.metroButton3, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.metroButton3, DecorationType.None);
			this.metroButton3.DefaultColor = Color.FromArgb(30, 30, 30);
			this.metroButton3.DisabledColor = Color.FromArgb(30, 30, 30);
			this.metroButton3.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.metroButton3.ForeColor = Color.WhiteSmoke;
			this.metroButton3.HoverColor = Color.FromArgb(40, 40, 40);
			this.metroButton3.Location = new Point(-11, 255);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.PressedColor = Color.FromArgb(30, 30, 30);
			this.metroButton3.RoundingArc = 26;
			this.metroButton3.Size = new System.Drawing.Size(89, 26);
			this.metroButton3.TabIndex = 4;
			this.metroButton3.Text = "Execute";
			this.metroButton3.Click += new EventHandler(this.metroButton3_Click);
			this.metroButton4.BackColor = Color.FromArgb(40, 40, 40);
			this.metroButton4.BackgroundImageLayout = ImageLayout.None;
			this.metroButton4.BorderColor = Color.FromArgb(30, 30, 30);
			this.bunifuTransition3.SetDecoration(this.metroButton4, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.metroButton4, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.metroButton4, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.metroButton4, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.metroButton4, DecorationType.None);
			this.metroButton4.DefaultColor = Color.FromArgb(30, 30, 30);
			this.metroButton4.DisabledColor = Color.FromArgb(30, 30, 30);
			this.metroButton4.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.metroButton4.ForeColor = Color.WhiteSmoke;
			this.metroButton4.HoverColor = Color.FromArgb(40, 40, 40);
			this.metroButton4.Location = new Point(84, 255);
			this.metroButton4.Name = "metroButton4";
			this.metroButton4.PressedColor = Color.FromArgb(30, 30, 30);
			this.metroButton4.RoundingArc = 26;
			this.metroButton4.Size = new System.Drawing.Size(80, 26);
			this.metroButton4.TabIndex = 7;
			this.metroButton4.Text = "Open";
			this.metroButton4.Click += new EventHandler(this.metroButton4_Click);
			this.metroButton5.BackColor = Color.FromArgb(40, 40, 40);
			this.metroButton5.BackgroundImageLayout = ImageLayout.None;
			this.metroButton5.BorderColor = Color.FromArgb(30, 30, 30);
			this.bunifuTransition3.SetDecoration(this.metroButton5, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.metroButton5, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.metroButton5, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.metroButton5, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.metroButton5, DecorationType.None);
			this.metroButton5.DefaultColor = Color.FromArgb(30, 30, 30);
			this.metroButton5.DisabledColor = Color.FromArgb(30, 30, 30);
			this.metroButton5.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.metroButton5.ForeColor = Color.WhiteSmoke;
			this.metroButton5.HoverColor = Color.FromArgb(40, 40, 40);
			this.metroButton5.Location = new Point(160, 255);
			this.metroButton5.Name = "metroButton5";
			this.metroButton5.PressedColor = Color.FromArgb(30, 30, 30);
			this.metroButton5.RoundingArc = 26;
			this.metroButton5.Size = new System.Drawing.Size(84, 26);
			this.metroButton5.TabIndex = 8;
			this.metroButton5.Text = "Save";
			this.metroButton5.Click += new EventHandler(this.metroButton5_Click);
			this.metroButton6.BackColor = Color.FromArgb(40, 40, 40);
			this.metroButton6.BackgroundImageLayout = ImageLayout.None;
			this.metroButton6.BorderColor = Color.FromArgb(30, 30, 30);
			this.bunifuTransition3.SetDecoration(this.metroButton6, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.metroButton6, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.metroButton6, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.metroButton6, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.metroButton6, DecorationType.None);
			this.metroButton6.DefaultColor = Color.FromArgb(30, 30, 30);
			this.metroButton6.DisabledColor = Color.FromArgb(30, 30, 30);
			this.metroButton6.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.metroButton6.ForeColor = Color.WhiteSmoke;
			this.metroButton6.HoverColor = Color.FromArgb(40, 40, 40);
			this.metroButton6.Location = new Point(322, 256);
			this.metroButton6.Name = "metroButton6";
			this.metroButton6.PressedColor = Color.FromArgb(30, 30, 30);
			this.metroButton6.RoundingArc = 26;
			this.metroButton6.Size = new System.Drawing.Size(82, 26);
			this.metroButton6.TabIndex = 9;
			this.metroButton6.Text = "Kill Roblox";
			this.metroButton6.Click += new EventHandler(this.metroButton6_Click);
			this.metroButton7.BackColor = Color.FromArgb(40, 40, 40);
			this.metroButton7.BackgroundImageLayout = ImageLayout.None;
			this.metroButton7.BorderColor = Color.FromArgb(30, 30, 30);
			this.bunifuTransition3.SetDecoration(this.metroButton7, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.metroButton7, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.metroButton7, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.metroButton7, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.metroButton7, DecorationType.None);
			this.metroButton7.DefaultColor = Color.FromArgb(30, 30, 30);
			this.metroButton7.DisabledColor = Color.FromArgb(30, 30, 30);
			this.metroButton7.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.metroButton7.ForeColor = Color.WhiteSmoke;
			this.metroButton7.HoverColor = Color.FromArgb(40, 40, 40);
			this.metroButton7.Location = new Point(414, 256);
			this.metroButton7.Name = "metroButton7";
			this.metroButton7.PressedColor = Color.FromArgb(30, 30, 30);
			this.metroButton7.RoundingArc = 26;
			this.metroButton7.Size = new System.Drawing.Size(73, 26);
			this.metroButton7.TabIndex = 10;
			this.metroButton7.Text = "Inject";
			this.metroButton7.Click += new EventHandler(this.metroButton7_Click);
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.FromArgb(30, 30, 30);
			this.bunifuTransition5.SetDecoration(this.label3, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.label3, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.label3, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.label3, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.label3, DecorationType.None);
			this.label3.ForeColor = Color.FromArgb(30, 30, 30);
			this.label3.Location = new Point(515, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "label1";
			this.label3.Click += new EventHandler(this.label3_Click);
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.panel3;
			this.bunifuDragControl2.Vertical = true;
			this.metroButton11.BackColor = Color.FromArgb(40, 40, 40);
			this.metroButton11.BackgroundImageLayout = ImageLayout.None;
			this.metroButton11.BorderColor = Color.FromArgb(30, 30, 30);
			this.bunifuTransition3.SetDecoration(this.metroButton11, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.metroButton11, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.metroButton11, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.metroButton11, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.metroButton11, DecorationType.None);
			this.metroButton11.DefaultColor = Color.FromArgb(30, 30, 30);
			this.metroButton11.DisabledColor = Color.FromArgb(30, 30, 30);
			this.metroButton11.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.metroButton11.ForeColor = Color.WhiteSmoke;
			this.metroButton11.HoverColor = Color.FromArgb(40, 40, 40);
			this.metroButton11.Location = new Point(234, 256);
			this.metroButton11.Name = "metroButton11";
			this.metroButton11.PressedColor = Color.FromArgb(30, 30, 30);
			this.metroButton11.RoundingArc = 26;
			this.metroButton11.Size = new System.Drawing.Size(82, 26);
			this.metroButton11.TabIndex = 13;
			this.metroButton11.Text = "Clear";
			this.metroButton11.Click += new EventHandler(this.metroButton11_Click);
			this.backgroundWorker1.DoWork += new DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.bunifuTransition3.SetDecoration(this.toolStripContainer1.BottomToolStripPanel, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.toolStripContainer1.BottomToolStripPanel, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.toolStripContainer1.BottomToolStripPanel, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.toolStripContainer1.BottomToolStripPanel, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.toolStripContainer1.BottomToolStripPanel, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.toolStripContainer1.ContentPanel, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.toolStripContainer1.ContentPanel, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.toolStripContainer1.ContentPanel, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.toolStripContainer1.ContentPanel, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.toolStripContainer1.ContentPanel, DecorationType.None);
			this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(7, 0);
			this.bunifuTransition4.SetDecoration(this.toolStripContainer1, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.toolStripContainer1, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.toolStripContainer1, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.toolStripContainer1, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.toolStripContainer1, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.toolStripContainer1.LeftToolStripPanel, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.toolStripContainer1.LeftToolStripPanel, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.toolStripContainer1.LeftToolStripPanel, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.toolStripContainer1.LeftToolStripPanel, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.toolStripContainer1.LeftToolStripPanel, DecorationType.None);
			this.toolStripContainer1.Location = new Point(673, 71);
			this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.bunifuTransition3.SetDecoration(this.toolStripContainer1.RightToolStripPanel, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.toolStripContainer1.RightToolStripPanel, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.toolStripContainer1.RightToolStripPanel, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.toolStripContainer1.RightToolStripPanel, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.toolStripContainer1.RightToolStripPanel, DecorationType.None);
			this.toolStripContainer1.Size = new System.Drawing.Size(7, 10);
			this.toolStripContainer1.TabIndex = 15;
			this.toolStripContainer1.Text = "toolStripContainer1";
			this.bunifuTransition3.SetDecoration(this.toolStripContainer1.TopToolStripPanel, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.toolStripContainer1.TopToolStripPanel, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.toolStripContainer1.TopToolStripPanel, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.toolStripContainer1.TopToolStripPanel, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.toolStripContainer1.TopToolStripPanel, DecorationType.None);
			this.backgroundWorker2.DoWork += new DoWorkEventHandler(this.backgroundWorker2_DoWork);
			this.backgroundWorker3.DoWork += new DoWorkEventHandler(this.backgroundWorker3_DoWork);
			this.backgroundWorker4.DoWork += new DoWorkEventHandler(this.backgroundWorker4_DoWork);
			this.backgroundWorker5.DoWork += new DoWorkEventHandler(this.backgroundWorker5_DoWork);
			this.button1.BackColor = Color.FromArgb(40, 40, 40);
			this.bunifuTransition3.SetDecoration(this.button1, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.button1, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.button1, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.button1, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.button1, DecorationType.None);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.ForeColor = SystemColors.ButtonHighlight;
			this.button1.Location = new Point(102, 90);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(124, 35);
			this.button1.TabIndex = 5;
			this.button1.Text = "Login!";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.label2.AutoSize = true;
			this.bunifuTransition5.SetDecoration(this.label2, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.label2, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.label2, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.label2, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.label2, DecorationType.None);
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = SystemColors.ControlLightLight;
			this.label2.Location = new Point(3, 38);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(256, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Please type in your Discord username with the # in it.";
			this.textBox2.BackColor = Color.FromArgb(40, 40, 40);
			this.textBox2.BorderStyle = BorderStyle.None;
			this.bunifuTransition5.SetDecoration(this.textBox2, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.textBox2, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.textBox2, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.textBox2, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.textBox2, DecorationType.None);
			this.textBox2.Font = new System.Drawing.Font("Calibri", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.textBox2.ForeColor = SystemColors.Window;
			this.textBox2.Location = new Point(2, 60);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(328, 17);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "Type in your Discord user name here...";
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.BackColor = Color.FromArgb(50, 50, 50);
			this.metroLabel3.BorderStyle = BorderStyle.FixedSingle;
			this.bunifuTransition5.SetDecoration(this.metroLabel3, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.metroLabel3, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.metroLabel3, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.metroLabel3, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.metroLabel3, DecorationType.None);
			this.metroLabel3.Font = new System.Drawing.Font("Segoe UI Semilight", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.metroLabel3.ForeColor = SystemColors.ButtonHighlight;
			this.metroLabel3.Location = new Point(0, 0);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(496, 23);
			this.metroLabel3.TabIndex = 1;
			this.metroLabel3.Text = "Sign in with Discord                                                                                       ";
			this.label4.AutoSize = true;
			this.bunifuTransition5.SetDecoration(this.label4, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.label4, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.label4, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.label4, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.label4, DecorationType.None);
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = SystemColors.ControlLightLight;
			this.label4.Location = new Point(637, 273);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Signed in as Guest";
			this.label4.Click += new EventHandler(this.label4_Click);
			this.bunifuTransition5.SetDecoration(this.contextMenuStrip2, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.contextMenuStrip2, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.contextMenuStrip2, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.contextMenuStrip2, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.contextMenuStrip2, DecorationType.None);
			this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
			this.contextMenuStrip2.Opening += new CancelEventHandler(this.contextMenuStrip2_Opening);
			this.bgWorker.DoWork += new DoWorkEventHandler(this.backgroundWorker6_DoWork);
			this.label9.AutoSize = true;
			this.bunifuTransition5.SetDecoration(this.label9, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.label9, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.label9, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.label9, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.label9, DecorationType.None);
			this.label9.Font = new System.Drawing.Font("Consolas", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.ForeColor = SystemColors.ButtonHighlight;
			this.label9.Location = new Point(9, 282);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(127, 13);
			this.label9.TabIndex = 20;
			this.label9.Text = "0 | No issues found.";
			this.label9.Click += new EventHandler(this.label9_Click);
			this.metroButton8.BackColor = Color.FromArgb(40, 40, 40);
			this.metroButton8.BackgroundImageLayout = ImageLayout.None;
			this.metroButton8.BorderColor = Color.FromArgb(30, 30, 30);
			this.bunifuTransition3.SetDecoration(this.metroButton8, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.metroButton8, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.metroButton8, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.metroButton8, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.metroButton8, DecorationType.None);
			this.metroButton8.DefaultColor = Color.FromArgb(30, 30, 30);
			this.metroButton8.DisabledColor = Color.FromArgb(30, 30, 30);
			this.metroButton8.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.metroButton8.ForeColor = Color.WhiteSmoke;
			this.metroButton8.HoverColor = Color.FromArgb(40, 40, 40);
			this.metroButton8.Location = new Point(6, 29);
			this.metroButton8.Name = "metroButton8";
			this.metroButton8.PressedColor = Color.FromArgb(30, 30, 30);
			this.metroButton8.RoundingArc = 26;
			this.metroButton8.Size = new System.Drawing.Size(154, 26);
			this.metroButton8.TabIndex = 12;
			this.metroButton8.Text = "EasyExploits";
			this.metroButton8.Click += new EventHandler(this.metroButton8_Click);
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.BackColor = Color.Transparent;
			this.bunifuTransition5.SetDecoration(this.metroLabel1, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.metroLabel1, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.metroLabel1, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.metroLabel1, DecorationType.None);
			this.bunifuTransition3.SetDecoration(this.metroLabel1, DecorationType.None);
			this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 9f);
			this.metroLabel1.ForeColor = SystemColors.ButtonFace;
			this.metroLabel1.Location = new Point(-3, 6);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(189, 14);
			this.metroLabel1.TabIndex = 14;
			this.metroLabel1.Text = "              Choose a DLL                       ";
			this.metroButton10.BackColor = Color.FromArgb(40, 40, 40);
			this.metroButton10.BackgroundImageLayout = ImageLayout.None;
			this.metroButton10.BorderColor = Color.FromArgb(30, 30, 30);
			this.metroButton10.Cursor = Cursors.AppStarting;
			this.bunifuTransition3.SetDecoration(this.metroButton10, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.metroButton10, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.metroButton10, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.metroButton10, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.metroButton10, DecorationType.None);
			this.metroButton10.DefaultColor = Color.FromArgb(30, 30, 30);
			this.metroButton10.DisabledColor = Color.FromArgb(250, 250, 250);
			this.metroButton10.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.metroButton10.ForeColor = Color.Red;
			this.metroButton10.HoverColor = Color.White;
			this.metroButton10.Location = new Point(138, 3);
			this.metroButton10.Name = "metroButton10";
			this.metroButton10.PressedColor = Color.FromArgb(0, 122, 204);
			this.metroButton10.RoundingArc = 25;
			this.metroButton10.Size = new System.Drawing.Size(28, 25);
			this.metroButton10.TabIndex = 12;
			this.metroButton10.Text = "X";
			this.metroButton10.Click += new EventHandler(this.metroButton10_Click);
			this.panel1.Controls.Add(this.metroButton13);
			this.panel1.Controls.Add(this.metroButton10);
			this.panel1.Controls.Add(this.metroLabel1);
			this.panel1.Controls.Add(this.metroButton8);
			this.bunifuTransition3.SetDecoration(this.panel1, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.panel1, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.panel1, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.panel1, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.panel1, DecorationType.None);
			this.panel1.Location = new Point(173, 83);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(166, 93);
			this.panel1.TabIndex = 11;
			this.metroButton13.BackColor = Color.FromArgb(40, 40, 40);
			this.metroButton13.BackgroundImageLayout = ImageLayout.None;
			this.metroButton13.BorderColor = Color.FromArgb(30, 30, 30);
			this.bunifuTransition3.SetDecoration(this.metroButton13, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.metroButton13, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.metroButton13, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.metroButton13, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.metroButton13, DecorationType.None);
			this.metroButton13.DefaultColor = Color.FromArgb(30, 30, 30);
			this.metroButton13.DisabledColor = Color.FromArgb(30, 30, 30);
			this.metroButton13.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.metroButton13.ForeColor = Color.WhiteSmoke;
			this.metroButton13.HoverColor = Color.FromArgb(40, 40, 40);
			this.metroButton13.Location = new Point(3, 61);
			this.metroButton13.Name = "metroButton13";
			this.metroButton13.PressedColor = Color.FromArgb(30, 30, 30);
			this.metroButton13.RoundingArc = 26;
			this.metroButton13.Size = new System.Drawing.Size(154, 26);
			this.metroButton13.TabIndex = 15;
			this.metroButton13.Text = "SirHurt";
			this.metroButton13.Click += new EventHandler(this.metroButton13_Click_1);
			this.backgroundWorker6.DoWork += new DoWorkEventHandler(this.backgroundWorker6_DoWork_1);
			this.backgroundWorker7.DoWork += new DoWorkEventHandler(this.backgroundWorker7_DoWork);
			this.bunifuTransition3.SetDecoration(this.panel5, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.panel5, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.panel5, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.panel5, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.panel5, DecorationType.None);
			this.panel5.Location = new Point(-2, 61);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(489, 4);
			this.panel5.TabIndex = 17;
			this.metroButton14.BackColor = Color.Black;
			this.metroButton14.BackgroundImageLayout = ImageLayout.None;
			this.metroButton14.BorderColor = Color.FromArgb(30, 30, 30);
			this.bunifuTransition3.SetDecoration(this.metroButton14, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.metroButton14, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.metroButton14, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.metroButton14, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.metroButton14, DecorationType.None);
			this.metroButton14.DefaultColor = Color.FromArgb(30, 30, 30);
			this.metroButton14.DisabledColor = Color.FromArgb(250, 250, 250);
			this.metroButton14.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.metroButton14.ForeColor = Color.WhiteSmoke;
			this.metroButton14.HoverColor = Color.White;
			this.metroButton14.Location = new Point(461, 43);
			this.metroButton14.Name = "metroButton14";
			this.metroButton14.PressedColor = Color.FromArgb(0, 122, 204);
			this.metroButton14.RoundingArc = 23;
			this.metroButton14.Size = new System.Drawing.Size(23, 23);
			this.metroButton14.TabIndex = 17;
			this.metroButton14.Text = "+";
			this.metroButton14.Click += new EventHandler(this.metroButton14_Click_1);
			this.bunifuTransition3.SetDecoration(this.panel4, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.panel4, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.panel4, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.panel4, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.panel4, DecorationType.None);
			this.panel4.Location = new Point(-1, 250);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(642, 7);
			this.panel4.TabIndex = 24;
			this.bunifuTransition1.AnimationType = AnimationType.Rotate;
			this.bunifuTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (PointF)componentResourceManager.GetObject("animation8.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (PointF)componentResourceManager.GetObject("animation8.MosaicCoeff");
			animation.MosaicShift = (PointF)componentResourceManager.GetObject("animation8.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (PointF)componentResourceManager.GetObject("animation8.ScaleCoeff");
			animation.SlideCoeff = (PointF)componentResourceManager.GetObject("animation8.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.bunifuTransition1.DefaultAnimation = animation;
			this.tabControl1.Appearance = TabAppearance.FlatButtons;
			this.bunifuTransition3.SetDecoration(this.tabControl1, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this.tabControl1, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this.tabControl1, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this.tabControl1, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this.tabControl1, DecorationType.Custom);
			this.tabControl1.FontWeight = MetroTabControlWeight.Regular;
			this.tabControl1.ItemSize = new System.Drawing.Size(103, 25);
			this.tabControl1.Location = new Point(-5, 43);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Size = new System.Drawing.Size(492, 211);
			this.tabControl1.Style = MetroColorStyle.White;
			this.tabControl1.TabIndex = 23;
			this.tabControl1.Theme = MetroThemeStyle.Dark;
			this.tabControl1.UseSelectable = true;
			this.tabControl1.UseStyleColors = true;
			this.tabControl1.SelectedIndexChanged += new EventHandler(this.tabControl1_SelectedIndexChanged_1);
			this.bunifuTransition2.AnimationType = AnimationType.VertSlide;
			this.bunifuTransition2.Cursor = null;
			obj.AnimateOnlyDifferences = true;
			obj.BlindCoeff = (PointF)componentResourceManager.GetObject("animation9.BlindCoeff");
			obj.LeafCoeff = 0f;
			obj.MaxTime = 1f;
			obj.MinTime = 0f;
			obj.MosaicCoeff = (PointF)componentResourceManager.GetObject("animation9.MosaicCoeff");
			obj.MosaicShift = (PointF)componentResourceManager.GetObject("animation9.MosaicShift");
			obj.MosaicSize = 0;
			obj.Padding = new System.Windows.Forms.Padding(0);
			obj.RotateCoeff = 0f;
			obj.RotateLimit = 0f;
			obj.ScaleCoeff = (PointF)componentResourceManager.GetObject("animation9.ScaleCoeff");
			obj.SlideCoeff = (PointF)componentResourceManager.GetObject("animation9.SlideCoeff");
			obj.TimeCoeff = 0f;
			obj.TransparencyCoeff = 0f;
			this.bunifuTransition2.DefaultAnimation = obj;
			this.bunifuTransition3.AnimationType = AnimationType.VertSlide;
			this.bunifuTransition3.Cursor = null;
			padding.AnimateOnlyDifferences = true;
			padding.BlindCoeff = (PointF)componentResourceManager.GetObject("animation6.BlindCoeff");
			padding.LeafCoeff = 0f;
			padding.MaxTime = 1f;
			padding.MinTime = 0f;
			padding.MosaicCoeff = (PointF)componentResourceManager.GetObject("animation6.MosaicCoeff");
			padding.MosaicShift = (PointF)componentResourceManager.GetObject("animation6.MosaicShift");
			padding.MosaicSize = 0;
			padding.Padding = new System.Windows.Forms.Padding(0);
			padding.RotateCoeff = 0f;
			padding.RotateLimit = 0f;
			padding.ScaleCoeff = (PointF)componentResourceManager.GetObject("animation6.ScaleCoeff");
			padding.SlideCoeff = (PointF)componentResourceManager.GetObject("animation6.SlideCoeff");
			padding.TimeCoeff = 0f;
			padding.TransparencyCoeff = 0f;
			this.bunifuTransition3.DefaultAnimation = padding;
			this.bunifuTransition4.AnimationType = AnimationType.VertSlide;
			this.bunifuTransition4.Cursor = null;
			animation1.AnimateOnlyDifferences = true;
			animation1.BlindCoeff = (PointF)componentResourceManager.GetObject("animation7.BlindCoeff");
			animation1.LeafCoeff = 0f;
			animation1.MaxTime = 1f;
			animation1.MinTime = 0f;
			animation1.MosaicCoeff = (PointF)componentResourceManager.GetObject("animation7.MosaicCoeff");
			animation1.MosaicShift = (PointF)componentResourceManager.GetObject("animation7.MosaicShift");
			animation1.MosaicSize = 0;
			animation1.Padding = new System.Windows.Forms.Padding(0);
			animation1.RotateCoeff = 0f;
			animation1.RotateLimit = 0f;
			animation1.ScaleCoeff = (PointF)componentResourceManager.GetObject("animation7.ScaleCoeff");
			animation1.SlideCoeff = (PointF)componentResourceManager.GetObject("animation7.SlideCoeff");
			animation1.TimeCoeff = 0f;
			animation1.TransparencyCoeff = 0f;
			this.bunifuTransition4.DefaultAnimation = animation1;
			this.bunifuTransition5.AnimationType = AnimationType.VertSlide;
			this.bunifuTransition5.Cursor = null;
			obj1.AnimateOnlyDifferences = true;
			obj1.BlindCoeff = (PointF)componentResourceManager.GetObject("animation10.BlindCoeff");
			obj1.LeafCoeff = 0f;
			obj1.MaxTime = 1f;
			obj1.MinTime = 0f;
			obj1.MosaicCoeff = (PointF)componentResourceManager.GetObject("animation10.MosaicCoeff");
			obj1.MosaicShift = (PointF)componentResourceManager.GetObject("animation10.MosaicShift");
			obj1.MosaicSize = 0;
			obj1.Padding = new System.Windows.Forms.Padding(0);
			obj1.RotateCoeff = 0f;
			obj1.RotateLimit = 0f;
			obj1.ScaleCoeff = (PointF)componentResourceManager.GetObject("animation10.ScaleCoeff");
			obj1.SlideCoeff = (PointF)componentResourceManager.GetObject("animation10.SlideCoeff");
			obj1.TimeCoeff = 0f;
			obj1.TransparencyCoeff = 0f;
			this.bunifuTransition5.DefaultAnimation = obj1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(30, 30, 30);
			base.ClientSize = new System.Drawing.Size(638, 300);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.metroButton14);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.panel5);
			base.Controls.Add(this.menuStrip1);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.toolStripContainer1);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.metroButton11);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.metroButton7);
			base.Controls.Add(this.metroButton6);
			base.Controls.Add(this.metroButton5);
			base.Controls.Add(this.metroButton4);
			base.Controls.Add(this.metroButton3);
			this.bunifuTransition3.SetDecoration(this, DecorationType.None);
			this.bunifuTransition2.SetDecoration(this, DecorationType.None);
			this.bunifuTransition1.SetDecoration(this, DecorationType.None);
			this.bunifuTransition4.SetDecoration(this, DecorationType.None);
			this.bunifuTransition5.SetDecoration(this, DecorationType.None);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.menuStrip1;
			base.Name = "MainUI";
			this.Text = "0,0,0,0";
			base.Load += new EventHandler(this.MainUI_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void injectToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.panel1.Show();
		}

		private void ironbrwObfuscatorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Ironbrew Obfuscator cracked will now download.");
			Console.WriteLine("Starting checks");
			WebClient webClient = new WebClient();
			if (!Directory.Exists("Ironbrew"))
			{
				Console.WriteLine("Deleting ironbrew files if found");
				if (File.Exists("ironbrew.zip"))
				{
					File.Delete("ironbrew.zip");
				}
				if (File.Exists("c:\\luac.exe"))
				{
					File.Delete("c:\\luac.exe");
				}
				if (File.Exists("c:\\luajit.exe"))
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
				if (File.Exists("ironbrew.zip"))
				{
					File.Delete("ironbrew.zip");
					Console.WriteLine("Deleted ironbrew.zip");
				}
				Console.WriteLine("Download complete");
				MessageBox.Show("Ironbrew is downloaded!");
				Console.WriteLine("This console window will now close.");
			}
			else
			{
				Console.WriteLine("Ironbrew found downloaded");
				MessageBox.Show("Ironbrew is already downloaded!");
			}
		}

		private void joinBetaTestingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("You are joining the Beta program. To get the beta tester role, DM MainEX to get it.");
			(new WebClient()).DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/BetaUpdater.exe?raw=true", "betaupdate.exe");
			ServicePointManager.ServerCertificateValidationCallback = (object a, X509Certificate b, X509Chain c, SslPolicyErrors d) => true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			Process.Start("betaupdate.exe");
			Environment.Exit(0);
		}

		private void joinOurDiscordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/mHATydM");
		}

		private void killRobloxToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (Process.GetProcessesByName("RobloxPlayerBeta").Length != 0)
			{
				try
				{
					Process.GetProcessesByName("RobloxPlayerBeta")[0].Kill();
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message.ToString());
				}
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void label3_Click(object sender, EventArgs e)
		{
		}

		private void label4_Click(object sender, EventArgs e)
		{
		}

		private void label9_Click(object sender, EventArgs e)
		{
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.MonacoEditor().Document.InvokeScript("SetText", new object[] { "" });
				Console.WriteLine("Monaco cleared");
				string str = File.ReadAllText(string.Concat("Scripts\\", this.listBox1.SelectedItem.ToString()));
				if (this.listBox1.SelectedItem != null)
				{
					this.MonacoEditor().Document.InvokeScript("SetText", new object[] { str });
				}
			}
			catch
			{
			}
		}

		private void mainDab2016ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new MainDab2016()).Show();
			base.Hide();
		}

		private void mainDabToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		private void mainDabV1ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new Form4()).Show();
			base.Hide();
		}

		private void mainDabV2ToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void MainUI_Load(object sender, EventArgs e)
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
				string friendlyName = AppDomain.CurrentDomain.FriendlyName;
				if (registryKey.GetValue(friendlyName) == null)
				{
					registryKey.SetValue(friendlyName, 11001, RegistryValueKind.DWord);
				}
				registryKey = null;
				friendlyName = null;
			}
			catch (Exception exception)
			{
			}
			WebBrowser webBrowser = new WebBrowser();
			WebClient webClient = new WebClient()
			{
				Proxy = null
			};
			TabPage tabPage = new TabPage("Tab 1");
			tabPage.Controls.Add(webBrowser);
			webBrowser.Dock = DockStyle.Fill;
			this.tabControl1.TabPages.Add(tabPage);
			this.tabControl1.SelectedTab = tabPage;
			webBrowser.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
			webBrowser.Document.InvokeScript("SetTheme", new string[] { "Dark" });
			this.addBase();
			this.addMath();
			this.addGlobalNS();
			this.addGlobalV();
			this.addGlobalF();
			byte[] numArray = webClient.DownloadData("https://pastebin.com/raw/swEhPMAB");
			if (Encoding.UTF8.GetString(numArray) == "1")
			{
				this.panel2.Show();
				byte[] numArray1 = webClient.DownloadData("https://pastebin.com/raw/vGdkCKxB");
				string str = Encoding.UTF8.GetString(numArray1);
				this.richTextBox1.Text = str;
				byte[] numArray2 = webClient.DownloadData("https://pastebin.com/raw/Fefmpk8w");
				if (Encoding.UTF8.GetString(numArray2) == "1")
				{
					this.metroLabel2.BackColor = Color.Red;
				}
			}
			ManagementObjectCollection managementObjectCollections = (new ManagementObjectSearcher("Select ProcessorId From Win32_processor")).Get();
			string str1 = "";
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollections.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					str1 = ((ManagementObject)enumerator.Current)["ProcessorId"].ToString();
				}
			}
			if (Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\WindowsMicrosoftSys32", "Setting1", null) == null)
			{
				this.label4.Text = "Signed in as guest";
			}
			BackgroundWorker backgroundWorker = new BackgroundWorker()
			{
				WorkerReportsProgress = true,
				WorkerSupportsCancellation = true
			};
			backgroundWorker.DoWork += new DoWorkEventHandler(this.BackgroundWorkerOnDoWork);
			backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(this.BackgroundWorkerOnProgressChanged);
			DispatcherTimer dispatcherTimer = new DispatcherTimer()
			{
				Interval = TimeSpan.FromMilliseconds(200)
			};
			dispatcherTimer.Tick += new EventHandler(this.SyntaxCheck);
			dispatcherTimer.Start();
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void metroButton10_Click(object sender, EventArgs e)
		{
			this.panel1.Hide();
		}

		private void metroButton11_Click(object sender, EventArgs e)
		{
			this.MonacoEditor().Document.InvokeScript("SetText", new object[] { "" });
			Console.WriteLine("Monaco cleared");
		}

		private void metroButton12_Click(object sender, EventArgs e)
		{
			this.panel2.Hide();
		}

		private void metroButton13_Click(object sender, EventArgs e)
		{
		}

		private void metroButton13_Click_1(object sender, EventArgs e)
		{
			this.label3.Text = "hurt";
			this.backgroundWorker6.RunWorkerAsync();
			this.panel1.Visible = false;
		}

		private void metroButton14_Click(object sender, EventArgs e)
		{
		}

		private void metroButton14_Click_1(object sender, EventArgs e)
		{
			WebBrowser webBrowser = new WebBrowser();
			WebClient webClient = new WebClient();
			TabPage tabPage = new TabPage(string.Concat("Tab", this.intValue.ToString()));
			this.intValue++;
			tabPage.AutoScroll = true;
			tabPage.Controls.Add(webBrowser);
			webBrowser.Dock = DockStyle.Fill;
			this.tabControl1.TabPages.Add(tabPage);
			this.tabControl1.SelectedTab = tabPage;
			webBrowser.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
			webBrowser.Document.InvokeScript("SetTheme", new string[] { "Dark" });
			this.addBase();
			this.addMath();
			this.addGlobalNS();
			this.addGlobalV();
			this.addGlobalF();
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void metroButton3_Click(object sender, EventArgs e)
		{
			object[] objArray;
			byte[] numArray = (new WebClient()).DownloadData("https://pastebin.com/raw/eKHr5sij");
			Encoding.UTF8.GetString(numArray);
			if (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
			{
				this.backgroundWorker2.RunWorkerAsync();
			}
			else if (this.label3.Text.Contains("easy"))
			{
				HtmlDocument document = this.MonacoEditor().Document;
				string str = "GetText";
				objArray = new string[0];
				string str1 = document.InvokeScript(str, objArray).ToString();
				this.m.ExecuteScript(str1);
			}
			else if (this.label3.Text.Contains("123"))
			{
				HtmlDocument htmlDocument = this.MonacoEditor().Document;
				string str2 = "GetText";
				objArray = new string[0];
				NamedPipes.LuaPipe(htmlDocument.InvokeScript(str2, objArray).ToString());
			}
			else if (this.label3.Text.Contains("hurt"))
			{
				HtmlDocument document1 = this.MonacoEditor().Document;
				object obj = document1.InvokeScript("GetText", new string[0]);
				SirHurtAPI.Execute(obj.ToString(), true);
			}
		}

		private void metroButton4_Click(object sender, EventArgs e)
		{
			if (Functions.openfiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					string str = File.ReadAllText(Functions.openfiledialog.FileName);
					this.MonacoEditor().Document.InvokeScript("SetText", new object[] { str });
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					MessageBox.Show(string.Concat("Error: Could not read file from disk. Original error: ", exception.Message));
					Console.WriteLine("File can't be opened");
				}
			}
			GC.Collect();
			GC.WaitForPendingFinalizers();
			GC.Collect();
		}

		private void metroButton5_Click(object sender, EventArgs e)
		{
			if (Functions.openfiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					this.MonacoEditor().Document.InvokeScript("SetText", new object[] { File.ReadAllText(Functions.openfiledialog.FileName) });
				}
				catch (Exception exception)
				{
					MessageBox.Show("This file is corrupted or not supported.", "MainDab");
				}
			}
		}

		private void metroButton6_Click(object sender, EventArgs e)
		{
			if (Process.GetProcessesByName("RobloxPlayerBeta").Length != 0)
			{
				try
				{
					Process.GetProcessesByName("RobloxPlayerBeta")[0].Kill();
				}
				catch (Exception exception)
				{
					MessageBox.Show(exception.Message.ToString());
				}
			}
		}

		private void metroButton7_Click(object sender, EventArgs e)
		{
			if (Process.GetProcessesByName("RobloxPlayerBeta").Length != 0)
			{
				this.panel1.Show();
				this.panel1.BringToFront();
				this.label1.Text = "MainDab (Choosing DLL...)";
			}
			else
			{
				this.backgroundWorker2.RunWorkerAsync();
			}
		}

		private void metroButton8_Click(object sender, EventArgs e)
		{
			this.label3.Text = "easy";
			if (Process.GetProcessesByName("RobloxPlayerBeta").Length != 0)
			{
				this.backgroundWorker3.RunWorkerAsync();
			}
			else
			{
				this.backgroundWorker2.RunWorkerAsync();
			}
			this.panel1.Hide();
			GC.Collect();
			GC.WaitForPendingFinalizers();
			GC.Collect();
		}

		private void metroButton9_Click(object sender, EventArgs e)
		{
			this.label3.Text = "123";
			if (Process.GetProcessesByName("RobloxPlayerBeta").Length != 0)
			{
				this.backgroundWorker4.RunWorkerAsync();
			}
			else
			{
				this.backgroundWorker2.RunWorkerAsync();
			}
			this.panel1.Hide();
		}

		private void metroLabel2_Click(object sender, EventArgs e)
		{
		}

		private void metroLabel4_Click(object sender, EventArgs e)
		{
		}

		private void modernUIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new NewuI()).Show();
			base.Hide();
		}

		private WebBrowser MonacoEditor()
		{
			WebBrowser item = null;
			TabPage selectedTab = this.tabControl1.SelectedTab;
			if (selectedTab != null)
			{
				item = selectedTab.Controls[0] as WebBrowser;
			}
			return item;
		}

		private void MonacoEditor_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			BackgroundWorker backgroundWorker = new BackgroundWorker()
			{
				WorkerReportsProgress = true,
				WorkerSupportsCancellation = true
			};
			backgroundWorker.DoWork += new DoWorkEventHandler(this.BackgroundWorkerOnDoWork);
			backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(this.BackgroundWorkerOnProgressChanged);
		}

		private void multipleRobloxToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Process.Start("Applications\\multirblx.exe");
		}

		private void obfuscateScriptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Obfuscator coming soon...");
		}

		private void oMG111111ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("I never said that you could have sex, hey!");
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{
		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{
		}

		private void pluginsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string str = "c://lugin.exe";
			if (File.Exists(str))
			{
				File.Delete(str);
			}
			(new WebClient()).DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/plugin.exe?raw=true", "plugin.exe");
			Process.Start("plugin.exe");
		}

		private void pluginsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Process.Start("Plugins.exe");
		}

		private void reinstallRobloxToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Reinstalling Roblox", "CoolXploit", MessageBoxButtons.OK);
			try
			{
				Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
				for (int i = 0; i < (int)processesByName.Length; i++)
				{
					processesByName[i].Kill();
				}
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				MessageBox.Show(Convert.ToString(exception), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			try
			{
				Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
				if (Directory.Exists("Roblox"))
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
				if (Directory.Exists("Roblox"))
				{
					Directory.Delete("Roblox", true);
				}
				if (File.Exists("Installer.exe"))
				{
					File.Delete("Installer.exe");
				}
			}
			catch
			{
			}
			(new WebClient()).DownloadFile("http://setup.roblox.com/RobloxPlayerLauncher.exe", "Installer.exe");
			Process.Start("Installer.exe");
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void Runagain()
		{
			this.bgWorker.RunWorkerAsync();
		}

		private void scriptHubToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		private void scriptHubToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			(new Hub1()).Show();
		}

		private void serversideToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string str = "game.JointsService.WeldRequest:FireServer(\"gui\")";
			if (this.label3.Text.Contains("easy"))
			{
				this.m.ExecuteScript(str);
				MessageBox.Show("Serverside ran! If the GUI dosen't show up, make sure that you are in a serversided game! Check our discord in #serversided-games for a list of serversided games! Also note that this functions is still in beta...", "Notice");
			}
			else if (!this.label3.Text.Contains("123"))
			{
				MessageBox.Show("Please inject before running the serverside!");
			}
			else
			{
				NamedPipes.LuaPipe(str);
				MessageBox.Show("Serverside ran! If the GUI dosen't show up, make sure that you are in a serversided game! Check our discord in #serversided-games for a list of serversided games! Also note that this functions is still in beta...", "Notice");
			}
		}

		private void SetTabHeader(TabPage page, Color color)
		{
			this.TabColors[page] = color;
			this.tabControl1.Invalidate();
		}

		private void signInWithDiscordToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void sirhurtScriptHubToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Scripts.OpenScriptHub();
		}

		private void synapseSexToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new SynapseX___mainj1()).Show();
			base.Hide();
		}

		public void SyntaxCheck(object sendere, EventArgs ee)
		{
			string str = this.MonacoEditor().Document.InvokeScript("GetText").ToString();
			if (str != this.oldtext)
			{
				this.oldtext = str;
				float single = 0f;
				string str1 = str;
				for (int i = 0; i < str1.Length; i++)
				{
					char chr = str1[i];
					single += 1f;
				}
				try
				{
					(new Script()).DoString(str, null, null);
					this.label9.ForeColor = Color.White;
					this.label9.Text = string.Concat(single.ToString(), " | No issues found.");
				}
				catch (SyntaxErrorException syntaxErrorException1)
				{
					SyntaxErrorException syntaxErrorException = syntaxErrorException1;
					this.label9.ForeColor = Color.Red;
					this.label9.Text = string.Concat(single.ToString(), " | ", syntaxErrorException.DecoratedMessage.ToString());
				}
				catch (ScriptRuntimeException scriptRuntimeException)
				{
					this.label9.ForeColor = Color.White;
					this.label9.Text = string.Concat(single.ToString(), " | No issues found.");
				}
			}
		}

		private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
		{
			using (Brush solidBrush = new SolidBrush(this.TabColors[this.tabControl1.TabPages[e.Index]]))
			{
				e.Graphics.FillRectangle(solidBrush, e.Bounds);
				SizeF sizeF = e.Graphics.MeasureString(this.tabControl1.TabPages[e.Index].Text, e.Font);
				Graphics graphics = e.Graphics;
				string text = this.tabControl1.TabPages[e.Index].Text;
				System.Drawing.Font font = e.Font;
				Brush black = Brushes.Black;
				float left = (float)e.Bounds.Left;
				Rectangle bounds = e.Bounds;
				float width = left + ((float)bounds.Width - sizeF.Width) / 2f;
				float top = (float)e.Bounds.Top;
				bounds = e.Bounds;
				graphics.DrawString(text, font, black, width, top + ((float)bounds.Height - sizeF.Height) / 2f + 1f);
				Rectangle rectangle = e.Bounds;
				rectangle.Offset(0, 1);
				rectangle.Inflate(0, -1);
				e.Graphics.DrawRectangle(Pens.DarkGray, rectangle);
				e.DrawFocusRectangle();
			}
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
		}

		private void taintDetectedExploitsCheckerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new TaintCheck()).Show();
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		private void uploadScriptToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void vPNToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Process.Start("Applications\\vpn.exe");
		}
	}
}