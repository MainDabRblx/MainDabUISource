using Bunifu.Framework.UI;
using DiscordRPC;
using DiscordRPC.Events;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using EasyExploits;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Drawing.Html;
using Microsoft.Win32;
using ProjectMainDab.Properties;
using SirHurtAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProjectMainDab
{
	public class MainEx : Form
	{
		private WebClient wc = new WebClient();

		private string defPath = string.Concat(Application.StartupPath, "//Monaco//");

		private Module m = new Module();

		public DiscordRpcClient client;

		public string oldtext = "";

		private WebClient webClient = new WebClient();

		private int listisopen = 0;

		private int intValue = 2;

		private IContainer components = null;

		private Panel panel1;

		private Panel panel2;

		private BunifuFlatButton bunifuFlatButton2;

		private BunifuFlatButton bunifuFlatButton1;

		private MenuStrip menuStrip2;

		private ToolStripMenuItem fileToolStripMenuItem1;

		private ToolStripMenuItem injectToolStripMenuItem1;

		private ToolStripMenuItem killRobloxToolStripMenuItem;

		private ToolStripMenuItem pluginsToolStripMenuItem1;

		private ToolStripMenuItem toolsToolStripMenuItem1;

		private ToolStripMenuItem fPSUnlockerToolStripMenuItem1;

		private ToolStripMenuItem multipleRobloxToolStripMenuItem1;

		private ToolStripMenuItem reinstallRobloxToolStripMenuItem1;

		private ToolStripMenuItem ironbrwObfuscatorToolStripMenuItem;

		private ToolStripMenuItem taintDetectedExploitsCheckerToolStripMenuItem;

		private ToolStripMenuItem scriptHubToolStripMenuItem1;

		private ToolStripMenuItem scriptHubToolStripMenuItem2;

		private ToolStripMenuItem sirhurtScriptHubToolStripMenuItem;

		private ToolStripMenuItem ezHubToolStripMenuItem;

		private PictureBox pictureBox1;

		private MetroButton metroButton1;

		private Panel panel3;

		private Panel panel4;

		private PictureBox pictureBox2;

		private Panel stationary;

		private Panel Execute;

		private MetroTabControl tabControl1;

		private HtmlToolTip htmlToolTip1;

		private MetroTabControl metroTabControl1;

		private ListBox listBox1;

		private BunifuFlatButton bunifuFlatButton3;

		private BunifuFlatButton bunifuFlatButton4;

		private BunifuFlatButton bunifuFlatButton5;

		private BunifuFlatButton bunifuFlatButton6;

		private BunifuFlatButton bunifuFlatButton7;

		private BunifuFlatButton bunifuFlatButton8;

		private BunifuFlatButton bunifuFlatButton9;

		private Panel panel5;

		private BunifuFlatButton bunifuFlatButton12;

		private BunifuFlatButton bunifuFlatButton11;

		private BunifuFlatButton bunifuFlatButton10;

		private Label label1;

		private PictureBox pictureBox3;

		private Label label9;

		private BackgroundWorker backgroundWorker1;

		private Label label3;

		private BackgroundWorker backgroundWorker2;

		private BackgroundWorker backgroundWorker3;

		private BackgroundWorker backgroundWorker4;

		private ToolStripMenuItem executeToolStripMenuItem;

		private ToolStripMenuItem clearToolStripMenuItem;

		private ToolStripMenuItem injecToolStripMenuItem;

		private BunifuDragControl bunifuDragControl1;

		private PictureBox pictureBox4;

		private ToolStripMenuItem serversodeToolStripMenuItem;

		public MainEx()
		{
			this.InitializeComponent();
			this.listBox1.Visible = false;
			this.listisopen = 0;
			this.backgroundWorker1.RunWorkerAsync();
			this.panel5.Hide();
			Functions.PopulateListBox(this.listBox1, "./scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./scripts", "*.lua");
			WebClient webClient = new WebClient();
			this.client = new DiscordRpcClient("714648958265327737")
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
				State = "Join here : discord.gg/N4EuuV8",
				Assets = new Assets()
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
			(new WebClient()).Proxy = null;
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

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
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
			this.label9.Text = "ScriptHub updated!";
			Thread.Sleep(1000);
			this.label9.Text = "MainDab, made by Main_EX#3898";
		}

		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			this.label9.Text = "Please inject before attempting to execute!";
			Thread.Sleep(1000);
			this.label9.Text = "MainDab, made by Main_EX#3898";
		}

		private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
		{
			string str = "if workspace:FindFirstChild(\"MainDab Anti Exploit\") then\r\n    game.StarterGui:SetCore('SendNotification', { Title = 'MainDab'; Text = 'MainDab Serverside found in this game! Press the serverside button in MainDab in order to run the serverside!'; Duration = 25; Button1 = 'Lets rekt some kids'; })\r\nend";
			this.panel5.Hide();
			this.m.LaunchExploit();
			this.label9.Text = "MainDab (Injecting...)";
			Thread.Sleep(5000);
			this.label9.Text = "MainDab, made by Main_EX#3898";
			Thread.Sleep(5000);
			this.m.ExecuteScript(str);
		}

		private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
		{
			SirHurtAPI.LaunchExploit();
			this.panel5.Hide();
		}

		private void bunifuFlatButton1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void bunifuFlatButton10_Click(object sender, EventArgs e)
		{
			this.panel5.Hide();
		}

		private void bunifuFlatButton11_Click(object sender, EventArgs e)
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
			this.panel5.Hide();
		}

		private void bunifuFlatButton12_Click(object sender, EventArgs e)
		{
		}

		private void bunifuFlatButton2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void bunifuFlatButton3_Click(object sender, EventArgs e)
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
				htmlDocument.InvokeScript(str2, objArray).ToString();
			}
			else if (this.label3.Text.Contains("hurt"))
			{
				HtmlDocument document1 = this.MonacoEditor().Document;
				string str3 = "GetText";
				objArray = new string[0];
				document1.InvokeScript(str3, objArray).ToString();
			}
		}

		private void bunifuFlatButton4_Click(object sender, EventArgs e)
		{
			this.MonacoEditor().Document.InvokeScript("SetText", new object[] { "" });
			Console.WriteLine("Monaco cleared");
		}

		private void bunifuFlatButton5_Click(object sender, EventArgs e)
		{
			this.panel5.Show();
		}

		private void bunifuFlatButton6_Click(object sender, EventArgs e)
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

		private void bunifuFlatButton7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Coming soon");
		}

		private void bunifuFlatButton8_Click(object sender, EventArgs e)
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

		private void bunifuFlatButton9_Click(object sender, EventArgs e)
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

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void executeToolStripMenuItem_Click(object sender, EventArgs e)
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
				htmlDocument.InvokeScript(str2, objArray).ToString();
			}
			else if (this.label3.Text.Contains("hurt"))
			{
				HtmlDocument document1 = this.MonacoEditor().Document;
				string str3 = "GetText";
				objArray = new string[0];
				document1.InvokeScript(str3, objArray).ToString();
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

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainEx));
			this.panel1 = new Panel();
			this.bunifuFlatButton2 = new BunifuFlatButton();
			this.bunifuFlatButton1 = new BunifuFlatButton();
			this.menuStrip2 = new MenuStrip();
			this.fileToolStripMenuItem1 = new ToolStripMenuItem();
			this.injectToolStripMenuItem1 = new ToolStripMenuItem();
			this.killRobloxToolStripMenuItem = new ToolStripMenuItem();
			this.pluginsToolStripMenuItem1 = new ToolStripMenuItem();
			this.executeToolStripMenuItem = new ToolStripMenuItem();
			this.clearToolStripMenuItem = new ToolStripMenuItem();
			this.injecToolStripMenuItem = new ToolStripMenuItem();
			this.serversodeToolStripMenuItem = new ToolStripMenuItem();
			this.toolsToolStripMenuItem1 = new ToolStripMenuItem();
			this.fPSUnlockerToolStripMenuItem1 = new ToolStripMenuItem();
			this.multipleRobloxToolStripMenuItem1 = new ToolStripMenuItem();
			this.reinstallRobloxToolStripMenuItem1 = new ToolStripMenuItem();
			this.ironbrwObfuscatorToolStripMenuItem = new ToolStripMenuItem();
			this.taintDetectedExploitsCheckerToolStripMenuItem = new ToolStripMenuItem();
			this.scriptHubToolStripMenuItem1 = new ToolStripMenuItem();
			this.scriptHubToolStripMenuItem2 = new ToolStripMenuItem();
			this.sirhurtScriptHubToolStripMenuItem = new ToolStripMenuItem();
			this.ezHubToolStripMenuItem = new ToolStripMenuItem();
			this.panel2 = new Panel();
			this.pictureBox1 = new PictureBox();
			this.metroButton1 = new MetroButton();
			this.panel3 = new Panel();
			this.label3 = new Label();
			this.label9 = new Label();
			this.panel4 = new Panel();
			this.pictureBox4 = new PictureBox();
			this.pictureBox3 = new PictureBox();
			this.pictureBox2 = new PictureBox();
			this.stationary = new Panel();
			this.Execute = new Panel();
			this.listBox1 = new ListBox();
			this.tabControl1 = new MetroTabControl();
			this.htmlToolTip1 = new HtmlToolTip();
			this.metroTabControl1 = new MetroTabControl();
			this.bunifuFlatButton3 = new BunifuFlatButton();
			this.bunifuFlatButton4 = new BunifuFlatButton();
			this.bunifuFlatButton5 = new BunifuFlatButton();
			this.bunifuFlatButton6 = new BunifuFlatButton();
			this.bunifuFlatButton7 = new BunifuFlatButton();
			this.bunifuFlatButton8 = new BunifuFlatButton();
			this.bunifuFlatButton9 = new BunifuFlatButton();
			this.panel5 = new Panel();
			this.bunifuFlatButton12 = new BunifuFlatButton();
			this.bunifuFlatButton11 = new BunifuFlatButton();
			this.bunifuFlatButton10 = new BunifuFlatButton();
			this.label1 = new Label();
			this.backgroundWorker1 = new BackgroundWorker();
			this.backgroundWorker2 = new BackgroundWorker();
			this.backgroundWorker3 = new BackgroundWorker();
			this.backgroundWorker4 = new BackgroundWorker();
			this.bunifuDragControl1 = new BunifuDragControl(this.components);
			this.panel1.SuspendLayout();
			this.menuStrip2.SuspendLayout();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			this.stationary.SuspendLayout();
			this.Execute.SuspendLayout();
			this.panel5.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = Color.FromArgb(60, 60, 60);
			this.panel1.Controls.Add(this.bunifuFlatButton2);
			this.panel1.Controls.Add(this.bunifuFlatButton1);
			this.panel1.Controls.Add(this.menuStrip2);
			this.panel1.Location = new Point(27, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(620, 24);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
			this.bunifuFlatButton2.Activecolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton2.BackColor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton2.BackgroundImageLayout = ImageLayout.Stretch;
			this.bunifuFlatButton2.BorderRadius = 0;
			this.bunifuFlatButton2.ButtonText = "     -";
			this.bunifuFlatButton2.Cursor = Cursors.Hand;
			this.bunifuFlatButton2.DisabledColor = Color.Gray;
			this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bunifuFlatButton2.ForeColor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton2.Iconcolor = Color.Transparent;
			this.bunifuFlatButton2.Iconimage = null;
			this.bunifuFlatButton2.Iconimage_right = null;
			this.bunifuFlatButton2.Iconimage_right_Selected = null;
			this.bunifuFlatButton2.Iconimage_Selected = null;
			this.bunifuFlatButton2.IconMarginLeft = 0;
			this.bunifuFlatButton2.IconMarginRight = 0;
			this.bunifuFlatButton2.IconRightVisible = true;
			this.bunifuFlatButton2.IconRightZoom = 0;
			this.bunifuFlatButton2.IconVisible = true;
			this.bunifuFlatButton2.IconZoom = 90;
			this.bunifuFlatButton2.IsTab = false;
			this.bunifuFlatButton2.Location = new Point(536, 1);
			this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.bunifuFlatButton2.Name = "bunifuFlatButton2";
			this.bunifuFlatButton2.Normalcolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton2.OnHovercolor = Color.FromArgb(70, 70, 70);
			this.bunifuFlatButton2.OnHoverTextColor = Color.White;
			this.bunifuFlatButton2.selected = false;
			this.bunifuFlatButton2.Size = new System.Drawing.Size(23, 24);
			this.bunifuFlatButton2.TabIndex = 3;
			this.bunifuFlatButton2.Text = "     -";
			this.bunifuFlatButton2.TextAlign = ContentAlignment.MiddleLeft;
			this.bunifuFlatButton2.Textcolor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bunifuFlatButton2.Click += new EventHandler(this.bunifuFlatButton2_Click);
			this.bunifuFlatButton1.Activecolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton1.BackColor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton1.BackgroundImageLayout = ImageLayout.None;
			this.bunifuFlatButton1.BorderRadius = 0;
			this.bunifuFlatButton1.ButtonText = "     X";
			this.bunifuFlatButton1.Cursor = Cursors.Hand;
			this.bunifuFlatButton1.DisabledColor = Color.Gray;
			this.bunifuFlatButton1.ForeColor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton1.Iconcolor = Color.Transparent;
			this.bunifuFlatButton1.Iconimage = null;
			this.bunifuFlatButton1.Iconimage_right = null;
			this.bunifuFlatButton1.Iconimage_right_Selected = null;
			this.bunifuFlatButton1.Iconimage_Selected = null;
			this.bunifuFlatButton1.IconMarginLeft = 0;
			this.bunifuFlatButton1.IconMarginRight = 0;
			this.bunifuFlatButton1.IconRightVisible = true;
			this.bunifuFlatButton1.IconRightZoom = 0;
			this.bunifuFlatButton1.IconVisible = true;
			this.bunifuFlatButton1.IconZoom = 90;
			this.bunifuFlatButton1.IsTab = false;
			this.bunifuFlatButton1.Location = new Point(557, 1);
			this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.bunifuFlatButton1.Name = "bunifuFlatButton1";
			this.bunifuFlatButton1.Normalcolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton1.OnHovercolor = Color.Red;
			this.bunifuFlatButton1.OnHoverTextColor = Color.White;
			this.bunifuFlatButton1.selected = false;
			this.bunifuFlatButton1.Size = new System.Drawing.Size(26, 24);
			this.bunifuFlatButton1.TabIndex = 2;
			this.bunifuFlatButton1.Text = "     X";
			this.bunifuFlatButton1.TextAlign = ContentAlignment.MiddleLeft;
			this.bunifuFlatButton1.Textcolor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bunifuFlatButton1.Click += new EventHandler(this.bunifuFlatButton1_Click);
			this.menuStrip2.AutoSize = false;
			this.menuStrip2.BackColor = Color.FromArgb(60, 60, 60);
			this.menuStrip2.Dock = DockStyle.None;
			this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip2.Items.AddRange(new ToolStripItem[] { this.fileToolStripMenuItem1, this.pluginsToolStripMenuItem1, this.toolsToolStripMenuItem1, this.scriptHubToolStripMenuItem1 });
			this.menuStrip2.Location = new Point(-1, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
			this.menuStrip2.Size = new System.Drawing.Size(267, 24);
			this.menuStrip2.TabIndex = 2;
			this.menuStrip2.Text = "menuStrip2";
			this.fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { this.injectToolStripMenuItem1, this.killRobloxToolStripMenuItem });
			this.fileToolStripMenuItem1.ForeColor = Color.FromArgb(210, 210, 210);
			this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
			this.fileToolStripMenuItem1.Size = new System.Drawing.Size(40, 22);
			this.fileToolStripMenuItem1.Text = "File";
			this.fileToolStripMenuItem1.Click += new EventHandler(this.fileToolStripMenuItem1_Click);
			this.injectToolStripMenuItem1.Name = "injectToolStripMenuItem1";
			this.injectToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
			this.injectToolStripMenuItem1.Text = "Open";
			this.injectToolStripMenuItem1.Click += new EventHandler(this.injectToolStripMenuItem1_Click);
			this.killRobloxToolStripMenuItem.Name = "killRobloxToolStripMenuItem";
			this.killRobloxToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
			this.killRobloxToolStripMenuItem.Text = "Kill Roblox";
			this.killRobloxToolStripMenuItem.Click += new EventHandler(this.killRobloxToolStripMenuItem_Click);
			this.pluginsToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { this.executeToolStripMenuItem, this.clearToolStripMenuItem, this.injecToolStripMenuItem, this.serversodeToolStripMenuItem });
			this.pluginsToolStripMenuItem1.ForeColor = Color.FromArgb(210, 210, 210);
			this.pluginsToolStripMenuItem1.Name = "pluginsToolStripMenuItem1";
			this.pluginsToolStripMenuItem1.Size = new System.Drawing.Size(70, 22);
			this.pluginsToolStripMenuItem1.Text = "Execution";
			this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
			this.executeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.executeToolStripMenuItem.Text = "Execute";
			this.executeToolStripMenuItem.Click += new EventHandler(this.executeToolStripMenuItem_Click);
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.clearToolStripMenuItem.Text = "Clear";
			this.injecToolStripMenuItem.Name = "injecToolStripMenuItem";
			this.injecToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.injecToolStripMenuItem.Text = "Inject";
			this.injecToolStripMenuItem.Click += new EventHandler(this.injecToolStripMenuItem_Click);
			this.serversodeToolStripMenuItem.Name = "serversodeToolStripMenuItem";
			this.serversodeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.serversodeToolStripMenuItem.Text = "Serverside";
			this.serversodeToolStripMenuItem.Click += new EventHandler(this.serversodeToolStripMenuItem_Click);
			this.toolsToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { this.fPSUnlockerToolStripMenuItem1, this.multipleRobloxToolStripMenuItem1, this.reinstallRobloxToolStripMenuItem1, this.ironbrwObfuscatorToolStripMenuItem, this.taintDetectedExploitsCheckerToolStripMenuItem });
			this.toolsToolStripMenuItem1.ForeColor = Color.FromArgb(210, 210, 210);
			this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
			this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(78, 22);
			this.toolsToolStripMenuItem1.Text = "Extensions";
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
			this.scriptHubToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { this.scriptHubToolStripMenuItem2, this.sirhurtScriptHubToolStripMenuItem, this.ezHubToolStripMenuItem });
			this.scriptHubToolStripMenuItem1.ForeColor = Color.FromArgb(210, 210, 210);
			this.scriptHubToolStripMenuItem1.Name = "scriptHubToolStripMenuItem1";
			this.scriptHubToolStripMenuItem1.Size = new System.Drawing.Size(74, 22);
			this.scriptHubToolStripMenuItem1.Text = "Script Hub";
			this.scriptHubToolStripMenuItem2.Name = "scriptHubToolStripMenuItem2";
			this.scriptHubToolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
			this.scriptHubToolStripMenuItem2.Text = "Script Hub";
			this.scriptHubToolStripMenuItem2.Click += new EventHandler(this.scriptHubToolStripMenuItem2_Click);
			this.sirhurtScriptHubToolStripMenuItem.Name = "sirhurtScriptHubToolStripMenuItem";
			this.sirhurtScriptHubToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.sirhurtScriptHubToolStripMenuItem.Text = "Sirhurt Script Hub";
			this.sirhurtScriptHubToolStripMenuItem.Click += new EventHandler(this.sirhurtScriptHubToolStripMenuItem_Click);
			this.ezHubToolStripMenuItem.Name = "ezHubToolStripMenuItem";
			this.ezHubToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.ezHubToolStripMenuItem.Text = "EzHub";
			this.ezHubToolStripMenuItem.Click += new EventHandler(this.ezHubToolStripMenuItem_Click);
			this.panel2.BackColor = Color.FromArgb(50, 50, 50);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Location = new Point(-1, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(29, 25);
			this.panel2.TabIndex = 1;
			this.pictureBox1.Image = Resources.Maindab;
			this.pictureBox1.Location = new Point(1, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(27, 26);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.metroButton1.Location = new Point(0, 0);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(75, 23);
			this.metroButton1.TabIndex = 0;
			this.metroButton1.UseSelectable = true;
			this.panel3.BackColor = SystemColors.Highlight;
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Location = new Point(-1, 295);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(673, 27);
			this.panel3.TabIndex = 2;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(578, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 22;
			this.label3.Text = "label2";
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Consolas", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.ForeColor = SystemColors.ButtonHighlight;
			this.label9.Location = new Point(5, 3);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(151, 13);
			this.label9.TabIndex = 21;
			this.label9.Text = "Downloading ScriptHub...";
			this.panel4.BackColor = Color.FromArgb(50, 50, 50);
			this.panel4.Controls.Add(this.pictureBox4);
			this.panel4.Controls.Add(this.pictureBox3);
			this.panel4.Controls.Add(this.pictureBox2);
			this.panel4.Location = new Point(0, 26);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(49, 269);
			this.panel4.TabIndex = 3;
			this.pictureBox4.Image = (Image)componentResourceManager.GetObject("pictureBox4.Image");
			this.pictureBox4.Location = new Point(-2, 87);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(51, 42);
			this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 2;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new EventHandler(this.pictureBox4_Click);
			this.pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new Point(-1, 45);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(51, 42);
			this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new EventHandler(this.pictureBox3_Click);
			this.pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new Point(-1, 1);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(51, 42);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new EventHandler(this.pictureBox2_Click);
			this.stationary.Controls.Add(this.Execute);
			this.stationary.Location = new Point(51, 27);
			this.stationary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.stationary.Name = "stationary";
			this.stationary.Size = new System.Drawing.Size(562, 235);
			this.stationary.TabIndex = 4;
			this.Execute.Controls.Add(this.listBox1);
			this.Execute.Location = new Point(0, 1);
			this.Execute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Execute.Name = "Execute";
			this.Execute.Size = new System.Drawing.Size(562, 234);
			this.Execute.TabIndex = 2;
			this.listBox1.BackColor = Color.FromArgb(30, 30, 30);
			this.listBox1.BorderStyle = BorderStyle.None;
			this.listBox1.ForeColor = Color.White;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new Point(-1, -2);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(106, 234);
			this.listBox1.TabIndex = 0;
			this.tabControl1.FontWeight = MetroTabControlWeight.Regular;
			this.tabControl1.ItemSize = new System.Drawing.Size(40, 23);
			this.tabControl1.Location = new Point(49, 26);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Size = new System.Drawing.Size(561, 238);
			this.tabControl1.SizeMode = TabSizeMode.Fixed;
			this.tabControl1.Style = MetroColorStyle.White;
			this.tabControl1.TabIndex = 0;
			this.tabControl1.Theme = MetroThemeStyle.Dark;
			this.tabControl1.UseSelectable = true;
			this.htmlToolTip1.OwnerDraw = true;
			this.metroTabControl1.Location = new Point(0, 0);
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.Size = new System.Drawing.Size(200, 100);
			this.metroTabControl1.TabIndex = 0;
			this.metroTabControl1.UseSelectable = true;
			this.bunifuFlatButton3.Activecolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton3.BackColor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton3.BackgroundImageLayout = ImageLayout.Stretch;
			this.bunifuFlatButton3.BorderRadius = 0;
			this.bunifuFlatButton3.ButtonText = "Execute";
			this.bunifuFlatButton3.Cursor = Cursors.Hand;
			this.bunifuFlatButton3.DisabledColor = Color.Gray;
			this.bunifuFlatButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bunifuFlatButton3.ForeColor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton3.Iconcolor = Color.Transparent;
			this.bunifuFlatButton3.Iconimage = null;
			this.bunifuFlatButton3.Iconimage_right = null;
			this.bunifuFlatButton3.Iconimage_right_Selected = null;
			this.bunifuFlatButton3.Iconimage_Selected = null;
			this.bunifuFlatButton3.IconMarginLeft = 0;
			this.bunifuFlatButton3.IconMarginRight = 0;
			this.bunifuFlatButton3.IconRightVisible = true;
			this.bunifuFlatButton3.IconRightZoom = 0;
			this.bunifuFlatButton3.IconVisible = true;
			this.bunifuFlatButton3.IconZoom = 90;
			this.bunifuFlatButton3.IsTab = false;
			this.bunifuFlatButton3.Location = new Point(49, 263);
			this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.bunifuFlatButton3.Name = "bunifuFlatButton3";
			this.bunifuFlatButton3.Normalcolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton3.OnHovercolor = Color.FromArgb(70, 70, 70);
			this.bunifuFlatButton3.OnHoverTextColor = Color.White;
			this.bunifuFlatButton3.selected = false;
			this.bunifuFlatButton3.Size = new System.Drawing.Size(81, 32);
			this.bunifuFlatButton3.TabIndex = 4;
			this.bunifuFlatButton3.Text = "Execute";
			this.bunifuFlatButton3.TextAlign = ContentAlignment.MiddleCenter;
			this.bunifuFlatButton3.Textcolor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bunifuFlatButton3.Click += new EventHandler(this.bunifuFlatButton3_Click);
			this.bunifuFlatButton4.Activecolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton4.BackColor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton4.BackgroundImageLayout = ImageLayout.Stretch;
			this.bunifuFlatButton4.BorderRadius = 0;
			this.bunifuFlatButton4.ButtonText = "Clear";
			this.bunifuFlatButton4.Cursor = Cursors.Hand;
			this.bunifuFlatButton4.DisabledColor = Color.Gray;
			this.bunifuFlatButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bunifuFlatButton4.ForeColor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton4.Iconcolor = Color.Transparent;
			this.bunifuFlatButton4.Iconimage = null;
			this.bunifuFlatButton4.Iconimage_right = null;
			this.bunifuFlatButton4.Iconimage_right_Selected = null;
			this.bunifuFlatButton4.Iconimage_Selected = null;
			this.bunifuFlatButton4.IconMarginLeft = 0;
			this.bunifuFlatButton4.IconMarginRight = 0;
			this.bunifuFlatButton4.IconRightVisible = true;
			this.bunifuFlatButton4.IconRightZoom = 0;
			this.bunifuFlatButton4.IconVisible = true;
			this.bunifuFlatButton4.IconZoom = 90;
			this.bunifuFlatButton4.IsTab = false;
			this.bunifuFlatButton4.Location = new Point(129, 263);
			this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.bunifuFlatButton4.Name = "bunifuFlatButton4";
			this.bunifuFlatButton4.Normalcolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton4.OnHovercolor = Color.FromArgb(70, 70, 70);
			this.bunifuFlatButton4.OnHoverTextColor = Color.White;
			this.bunifuFlatButton4.selected = false;
			this.bunifuFlatButton4.Size = new System.Drawing.Size(81, 32);
			this.bunifuFlatButton4.TabIndex = 5;
			this.bunifuFlatButton4.Text = "Clear";
			this.bunifuFlatButton4.TextAlign = ContentAlignment.MiddleCenter;
			this.bunifuFlatButton4.Textcolor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bunifuFlatButton4.Click += new EventHandler(this.bunifuFlatButton4_Click);
			this.bunifuFlatButton5.Activecolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton5.BackColor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton5.BackgroundImageLayout = ImageLayout.Stretch;
			this.bunifuFlatButton5.BorderRadius = 0;
			this.bunifuFlatButton5.ButtonText = "Inject";
			this.bunifuFlatButton5.Cursor = Cursors.Hand;
			this.bunifuFlatButton5.DisabledColor = Color.Gray;
			this.bunifuFlatButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bunifuFlatButton5.ForeColor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton5.Iconcolor = Color.Transparent;
			this.bunifuFlatButton5.Iconimage = null;
			this.bunifuFlatButton5.Iconimage_right = null;
			this.bunifuFlatButton5.Iconimage_right_Selected = null;
			this.bunifuFlatButton5.Iconimage_Selected = null;
			this.bunifuFlatButton5.IconMarginLeft = 0;
			this.bunifuFlatButton5.IconMarginRight = 0;
			this.bunifuFlatButton5.IconRightVisible = true;
			this.bunifuFlatButton5.IconRightZoom = 0;
			this.bunifuFlatButton5.IconVisible = true;
			this.bunifuFlatButton5.IconZoom = 90;
			this.bunifuFlatButton5.IsTab = false;
			this.bunifuFlatButton5.Location = new Point(209, 263);
			this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.bunifuFlatButton5.Name = "bunifuFlatButton5";
			this.bunifuFlatButton5.Normalcolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton5.OnHovercolor = Color.FromArgb(70, 70, 70);
			this.bunifuFlatButton5.OnHoverTextColor = Color.White;
			this.bunifuFlatButton5.selected = false;
			this.bunifuFlatButton5.Size = new System.Drawing.Size(81, 32);
			this.bunifuFlatButton5.TabIndex = 6;
			this.bunifuFlatButton5.Text = "Inject";
			this.bunifuFlatButton5.TextAlign = ContentAlignment.MiddleCenter;
			this.bunifuFlatButton5.Textcolor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bunifuFlatButton5.Click += new EventHandler(this.bunifuFlatButton5_Click);
			this.bunifuFlatButton6.Activecolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton6.BackColor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton6.BackgroundImageLayout = ImageLayout.Stretch;
			this.bunifuFlatButton6.BorderRadius = 0;
			this.bunifuFlatButton6.ButtonText = "Open";
			this.bunifuFlatButton6.Cursor = Cursors.Hand;
			this.bunifuFlatButton6.DisabledColor = Color.Gray;
			this.bunifuFlatButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bunifuFlatButton6.ForeColor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton6.Iconcolor = Color.Transparent;
			this.bunifuFlatButton6.Iconimage = null;
			this.bunifuFlatButton6.Iconimage_right = null;
			this.bunifuFlatButton6.Iconimage_right_Selected = null;
			this.bunifuFlatButton6.Iconimage_Selected = null;
			this.bunifuFlatButton6.IconMarginLeft = 0;
			this.bunifuFlatButton6.IconMarginRight = 0;
			this.bunifuFlatButton6.IconRightVisible = true;
			this.bunifuFlatButton6.IconRightZoom = 0;
			this.bunifuFlatButton6.IconVisible = true;
			this.bunifuFlatButton6.IconZoom = 90;
			this.bunifuFlatButton6.IsTab = false;
			this.bunifuFlatButton6.Location = new Point(289, 263);
			this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.bunifuFlatButton6.Name = "bunifuFlatButton6";
			this.bunifuFlatButton6.Normalcolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton6.OnHovercolor = Color.FromArgb(70, 70, 70);
			this.bunifuFlatButton6.OnHoverTextColor = Color.White;
			this.bunifuFlatButton6.selected = false;
			this.bunifuFlatButton6.Size = new System.Drawing.Size(81, 32);
			this.bunifuFlatButton6.TabIndex = 7;
			this.bunifuFlatButton6.Text = "Open";
			this.bunifuFlatButton6.TextAlign = ContentAlignment.MiddleCenter;
			this.bunifuFlatButton6.Textcolor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bunifuFlatButton6.Click += new EventHandler(this.bunifuFlatButton6_Click);
			this.bunifuFlatButton7.Activecolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton7.BackColor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton7.BackgroundImageLayout = ImageLayout.Stretch;
			this.bunifuFlatButton7.BorderRadius = 0;
			this.bunifuFlatButton7.ButtonText = "Save";
			this.bunifuFlatButton7.Cursor = Cursors.Hand;
			this.bunifuFlatButton7.DisabledColor = Color.Gray;
			this.bunifuFlatButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bunifuFlatButton7.ForeColor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton7.Iconcolor = Color.Transparent;
			this.bunifuFlatButton7.Iconimage = null;
			this.bunifuFlatButton7.Iconimage_right = null;
			this.bunifuFlatButton7.Iconimage_right_Selected = null;
			this.bunifuFlatButton7.Iconimage_Selected = null;
			this.bunifuFlatButton7.IconMarginLeft = 0;
			this.bunifuFlatButton7.IconMarginRight = 0;
			this.bunifuFlatButton7.IconRightVisible = true;
			this.bunifuFlatButton7.IconRightZoom = 0;
			this.bunifuFlatButton7.IconVisible = true;
			this.bunifuFlatButton7.IconZoom = 90;
			this.bunifuFlatButton7.IsTab = false;
			this.bunifuFlatButton7.Location = new Point(369, 263);
			this.bunifuFlatButton7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.bunifuFlatButton7.Name = "bunifuFlatButton7";
			this.bunifuFlatButton7.Normalcolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton7.OnHovercolor = Color.FromArgb(70, 70, 70);
			this.bunifuFlatButton7.OnHoverTextColor = Color.White;
			this.bunifuFlatButton7.selected = false;
			this.bunifuFlatButton7.Size = new System.Drawing.Size(81, 32);
			this.bunifuFlatButton7.TabIndex = 8;
			this.bunifuFlatButton7.Text = "Save";
			this.bunifuFlatButton7.TextAlign = ContentAlignment.MiddleCenter;
			this.bunifuFlatButton7.Textcolor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bunifuFlatButton7.Click += new EventHandler(this.bunifuFlatButton7_Click);
			this.bunifuFlatButton8.Activecolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton8.BackColor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton8.BackgroundImageLayout = ImageLayout.Stretch;
			this.bunifuFlatButton8.BorderRadius = 0;
			this.bunifuFlatButton8.ButtonText = "Kill Roblox";
			this.bunifuFlatButton8.Cursor = Cursors.Hand;
			this.bunifuFlatButton8.DisabledColor = Color.Gray;
			this.bunifuFlatButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bunifuFlatButton8.ForeColor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton8.Iconcolor = Color.Transparent;
			this.bunifuFlatButton8.Iconimage = null;
			this.bunifuFlatButton8.Iconimage_right = null;
			this.bunifuFlatButton8.Iconimage_right_Selected = null;
			this.bunifuFlatButton8.Iconimage_Selected = null;
			this.bunifuFlatButton8.IconMarginLeft = 0;
			this.bunifuFlatButton8.IconMarginRight = 0;
			this.bunifuFlatButton8.IconRightVisible = true;
			this.bunifuFlatButton8.IconRightZoom = 0;
			this.bunifuFlatButton8.IconVisible = true;
			this.bunifuFlatButton8.IconZoom = 90;
			this.bunifuFlatButton8.IsTab = false;
			this.bunifuFlatButton8.Location = new Point(449, 263);
			this.bunifuFlatButton8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.bunifuFlatButton8.Name = "bunifuFlatButton8";
			this.bunifuFlatButton8.Normalcolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton8.OnHovercolor = Color.FromArgb(70, 70, 70);
			this.bunifuFlatButton8.OnHoverTextColor = Color.White;
			this.bunifuFlatButton8.selected = false;
			this.bunifuFlatButton8.Size = new System.Drawing.Size(164, 32);
			this.bunifuFlatButton8.TabIndex = 9;
			this.bunifuFlatButton8.Text = "Kill Roblox";
			this.bunifuFlatButton8.TextAlign = ContentAlignment.MiddleCenter;
			this.bunifuFlatButton8.Textcolor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bunifuFlatButton8.Click += new EventHandler(this.bunifuFlatButton8_Click);
			this.bunifuFlatButton9.Activecolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton9.BackColor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton9.BackgroundImageLayout = ImageLayout.Stretch;
			this.bunifuFlatButton9.BorderRadius = 0;
			this.bunifuFlatButton9.ButtonText = "+";
			this.bunifuFlatButton9.Cursor = Cursors.Hand;
			this.bunifuFlatButton9.DisabledColor = Color.Gray;
			this.bunifuFlatButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bunifuFlatButton9.ForeColor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton9.Iconcolor = Color.Transparent;
			this.bunifuFlatButton9.Iconimage = null;
			this.bunifuFlatButton9.Iconimage_right = null;
			this.bunifuFlatButton9.Iconimage_right_Selected = null;
			this.bunifuFlatButton9.Iconimage_Selected = null;
			this.bunifuFlatButton9.IconMarginLeft = 0;
			this.bunifuFlatButton9.IconMarginRight = 0;
			this.bunifuFlatButton9.IconRightVisible = true;
			this.bunifuFlatButton9.IconRightZoom = 0;
			this.bunifuFlatButton9.IconVisible = true;
			this.bunifuFlatButton9.IconZoom = 90;
			this.bunifuFlatButton9.IsTab = false;
			this.bunifuFlatButton9.Location = new Point(587, 26);
			this.bunifuFlatButton9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.bunifuFlatButton9.Name = "bunifuFlatButton9";
			this.bunifuFlatButton9.Normalcolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton9.OnHovercolor = Color.FromArgb(70, 70, 70);
			this.bunifuFlatButton9.OnHoverTextColor = Color.White;
			this.bunifuFlatButton9.selected = false;
			this.bunifuFlatButton9.Size = new System.Drawing.Size(23, 27);
			this.bunifuFlatButton9.TabIndex = 10;
			this.bunifuFlatButton9.Text = "+";
			this.bunifuFlatButton9.TextAlign = ContentAlignment.MiddleCenter;
			this.bunifuFlatButton9.Textcolor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton9.TextFont = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bunifuFlatButton9.Click += new EventHandler(this.bunifuFlatButton9_Click);
			this.panel5.Controls.Add(this.bunifuFlatButton12);
			this.panel5.Controls.Add(this.bunifuFlatButton11);
			this.panel5.Controls.Add(this.bunifuFlatButton10);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Location = new Point(230, 92);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(171, 103);
			this.panel5.TabIndex = 4;
			this.bunifuFlatButton12.Activecolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton12.BackColor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton12.BackgroundImageLayout = ImageLayout.Stretch;
			this.bunifuFlatButton12.BorderRadius = 0;
			this.bunifuFlatButton12.ButtonText = "SirHurt API";
			this.bunifuFlatButton12.Cursor = Cursors.Hand;
			this.bunifuFlatButton12.DisabledColor = Color.Gray;
			this.bunifuFlatButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bunifuFlatButton12.ForeColor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton12.Iconcolor = Color.Transparent;
			this.bunifuFlatButton12.Iconimage = null;
			this.bunifuFlatButton12.Iconimage_right = null;
			this.bunifuFlatButton12.Iconimage_right_Selected = null;
			this.bunifuFlatButton12.Iconimage_Selected = null;
			this.bunifuFlatButton12.IconMarginLeft = 0;
			this.bunifuFlatButton12.IconMarginRight = 0;
			this.bunifuFlatButton12.IconRightVisible = true;
			this.bunifuFlatButton12.IconRightZoom = 0;
			this.bunifuFlatButton12.IconVisible = true;
			this.bunifuFlatButton12.IconZoom = 90;
			this.bunifuFlatButton12.IsTab = false;
			this.bunifuFlatButton12.Location = new Point(6, 66);
			this.bunifuFlatButton12.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.bunifuFlatButton12.Name = "bunifuFlatButton12";
			this.bunifuFlatButton12.Normalcolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton12.OnHovercolor = Color.FromArgb(70, 70, 70);
			this.bunifuFlatButton12.OnHoverTextColor = Color.White;
			this.bunifuFlatButton12.selected = false;
			this.bunifuFlatButton12.Size = new System.Drawing.Size(160, 32);
			this.bunifuFlatButton12.TabIndex = 12;
			this.bunifuFlatButton12.Text = "SirHurt API";
			this.bunifuFlatButton12.TextAlign = ContentAlignment.MiddleCenter;
			this.bunifuFlatButton12.Textcolor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton12.TextFont = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bunifuFlatButton12.Click += new EventHandler(this.bunifuFlatButton12_Click);
			this.bunifuFlatButton11.Activecolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton11.BackColor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton11.BackgroundImageLayout = ImageLayout.Stretch;
			this.bunifuFlatButton11.BorderRadius = 0;
			this.bunifuFlatButton11.ButtonText = "EasyExploits API";
			this.bunifuFlatButton11.Cursor = Cursors.Hand;
			this.bunifuFlatButton11.DisabledColor = Color.Gray;
			this.bunifuFlatButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bunifuFlatButton11.ForeColor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton11.Iconcolor = Color.Transparent;
			this.bunifuFlatButton11.Iconimage = null;
			this.bunifuFlatButton11.Iconimage_right = null;
			this.bunifuFlatButton11.Iconimage_right_Selected = null;
			this.bunifuFlatButton11.Iconimage_Selected = null;
			this.bunifuFlatButton11.IconMarginLeft = 0;
			this.bunifuFlatButton11.IconMarginRight = 0;
			this.bunifuFlatButton11.IconRightVisible = true;
			this.bunifuFlatButton11.IconRightZoom = 0;
			this.bunifuFlatButton11.IconVisible = true;
			this.bunifuFlatButton11.IconZoom = 90;
			this.bunifuFlatButton11.IsTab = false;
			this.bunifuFlatButton11.Location = new Point(6, 31);
			this.bunifuFlatButton11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.bunifuFlatButton11.Name = "bunifuFlatButton11";
			this.bunifuFlatButton11.Normalcolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton11.OnHovercolor = Color.FromArgb(70, 70, 70);
			this.bunifuFlatButton11.OnHoverTextColor = Color.White;
			this.bunifuFlatButton11.selected = false;
			this.bunifuFlatButton11.Size = new System.Drawing.Size(160, 32);
			this.bunifuFlatButton11.TabIndex = 11;
			this.bunifuFlatButton11.Text = "EasyExploits API";
			this.bunifuFlatButton11.TextAlign = ContentAlignment.MiddleCenter;
			this.bunifuFlatButton11.Textcolor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton11.TextFont = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bunifuFlatButton11.Click += new EventHandler(this.bunifuFlatButton11_Click);
			this.bunifuFlatButton10.Activecolor = Color.FromArgb(60, 60, 60);
			this.bunifuFlatButton10.BackColor = Color.FromArgb(30, 30, 30);
			this.bunifuFlatButton10.BackgroundImageLayout = ImageLayout.None;
			this.bunifuFlatButton10.BorderRadius = 0;
			this.bunifuFlatButton10.ButtonText = "     X";
			this.bunifuFlatButton10.Cursor = Cursors.Hand;
			this.bunifuFlatButton10.DisabledColor = Color.Gray;
			this.bunifuFlatButton10.ForeColor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton10.Iconcolor = Color.Transparent;
			this.bunifuFlatButton10.Iconimage = null;
			this.bunifuFlatButton10.Iconimage_right = null;
			this.bunifuFlatButton10.Iconimage_right_Selected = null;
			this.bunifuFlatButton10.Iconimage_Selected = null;
			this.bunifuFlatButton10.IconMarginLeft = 0;
			this.bunifuFlatButton10.IconMarginRight = 0;
			this.bunifuFlatButton10.IconRightVisible = true;
			this.bunifuFlatButton10.IconRightZoom = 0;
			this.bunifuFlatButton10.IconVisible = true;
			this.bunifuFlatButton10.IconZoom = 90;
			this.bunifuFlatButton10.IsTab = false;
			this.bunifuFlatButton10.Location = new Point(141, 2);
			this.bunifuFlatButton10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.bunifuFlatButton10.Name = "bunifuFlatButton10";
			this.bunifuFlatButton10.Normalcolor = Color.FromArgb(30, 30, 30);
			this.bunifuFlatButton10.OnHovercolor = Color.Red;
			this.bunifuFlatButton10.OnHoverTextColor = Color.White;
			this.bunifuFlatButton10.selected = false;
			this.bunifuFlatButton10.Size = new System.Drawing.Size(27, 27);
			this.bunifuFlatButton10.TabIndex = 4;
			this.bunifuFlatButton10.Text = "     X";
			this.bunifuFlatButton10.TextAlign = ContentAlignment.MiddleLeft;
			this.bunifuFlatButton10.Textcolor = Color.FromArgb(210, 210, 210);
			this.bunifuFlatButton10.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.bunifuFlatButton10.Click += new EventHandler(this.bunifuFlatButton10_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.Location = new Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Choose a DLL...";
			this.backgroundWorker1.DoWork += new DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker2.DoWork += new DoWorkEventHandler(this.backgroundWorker2_DoWork);
			this.backgroundWorker3.DoWork += new DoWorkEventHandler(this.backgroundWorker3_DoWork);
			this.backgroundWorker4.DoWork += new DoWorkEventHandler(this.backgroundWorker4_DoWork);
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.panel1;
			this.bunifuDragControl1.Vertical = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(30, 30, 30);
			base.ClientSize = new System.Drawing.Size(611, 315);
			base.Controls.Add(this.bunifuFlatButton8);
			base.Controls.Add(this.bunifuFlatButton7);
			base.Controls.Add(this.bunifuFlatButton6);
			base.Controls.Add(this.bunifuFlatButton5);
			base.Controls.Add(this.bunifuFlatButton4);
			base.Controls.Add(this.bunifuFlatButton3);
			base.Controls.Add(this.panel5);
			base.Controls.Add(this.bunifuFlatButton9);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.stationary);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.panel2);
			this.ForeColor = Color.White;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Location = new Point(200, 300);
			base.Name = "MainEx";
			this.Text = "MainEx";
			this.panel1.ResumeLayout(false);
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.panel2.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox1).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox4).EndInit();
			((ISupportInitialize)this.pictureBox3).EndInit();
			((ISupportInitialize)this.pictureBox2).EndInit();
			this.stationary.ResumeLayout(false);
			this.Execute.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			base.ResumeLayout(false);
		}

		private void injecToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel5.Show();
		}

		private void injectToolStripMenuItem1_Click(object sender, EventArgs e)
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

		private void killRobloxToolStripMenuItem_Click(object sender, EventArgs e)
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

		private void multipleRobloxToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Process.Start("Applications\\multirblx.exe");
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			if (this.listisopen != 0)
			{
				this.listisopen = 0;
				this.tabControl1.Size = new System.Drawing.Size(563, 237);
				this.tabControl1.Location = new Point(50, 26);
				this.listBox1.Visible = false;
			}
			else
			{
				this.listisopen = 1;
				this.tabControl1.Size = new System.Drawing.Size(492, 237);
				this.tabControl1.Location = new Point(150, 26);
				this.listBox1.Visible = true;
			}
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			(new Hub1()).Show();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/N4EuuV8");
		}

		private void reinstallRobloxToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Reinstalling Roblox, MainDab may freeze for a while.", "MainDab", MessageBoxButtons.OK);
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

		private void scriptHubToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			(new Hub1()).Show();
		}

		private void serversodeToolStripMenuItem_Click(object sender, EventArgs e)
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

		private void sirhurtScriptHubToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Scripts.OpenScriptHub();
		}

		private void taintDetectedExploitsCheckerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new TaintCheck()).Show();
		}
	}
}