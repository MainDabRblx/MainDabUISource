using Bunifu.Framework.UI;
using DiscordRPC;
using DiscordRPC.Events;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using EasyExploits;
using Microsoft.Win32;
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
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ProjectMainDab
{
	public class NewuI : Form
	{
		private Module m = new Module();

		public DiscordRpcClient client;

		private System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();

		private string defPath = string.Concat(Application.StartupPath, "//Monaco//");

		private IContainer components = null;

		private Panel panel1;

		private Panel panel2;

		private Label label1;

		private Panel panel4;

		private Label label4;

		private Label label3;

		private Label label2;

		private Panel Execution;

		private WebBrowser MonacoEditor;

		private Button button5;

		private Button button4;

		private Button button3;

		private Button button2;

		private Button button1;

		private BackgroundWorker backgroundWorker1;

		private BunifuDragControl bunifuDragControl1;

		private Panel Tools;

		private Button button6;

		private Button button7;

		private Button button8;

		private Button button10;

		private Button button9;

		private Label label5;

		private Button button11;

		private Button button12;

		private Button button13;

		private Panel Serverside;

		private Button button15;

		private Button button14;

		private Panel ScriptHub;

		private ListBox listBox1;

		private Button button16;

		private PictureBox pictureBox6;

		private RichTextBox richTextBox1;

		private BackgroundWorker backgroundWorker2;

		private RichTextBox richTextBox2;

		private Panel Others;

		private Button button17;

		private Panel panel5;

		private Panel panel6;

		private FlowLayoutPanel flowLayoutPanel1;

		private PictureBox pictureBox1;

		private PictureBox pictureBox2;

		private PictureBox pictureBox4;

		private PictureBox pictureBox3;

		private PictureBox pictureBox5;

		private PictureBox pictureBox7;

		private Panel panel3;

		private Button button18;

		public NewuI()
		{
			this.InitializeComponent();
			this.backgroundWorker2.RunWorkerAsync();
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
				State = "Join here : discord.gg/TKcPeaq",
				Assets = new Assets()
				{
					LargeImageKey = "render",
					LargeImageText = "render",
					SmallImageKey = "render"
				}
			});
			base.Opacity = 0;
			this.t1.Interval = 10;
			this.t1.Tick += new EventHandler(this.fadeIn);
			this.t1.Start();
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
			this.MonacoEditor.Document.InvokeScript("AddIntellisense", new object[] { label, kind, detail, insertText });
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
			if (Process.GetProcessesByName("RobloxPlayerBeta").Length != 0)
			{
				this.panel4.Show();
				this.button4.Enabled = false;
				this.label4.Text = "Injecting EasyExploits...";
				this.m.LaunchExploit();
				Thread.Sleep(5000);
				this.button4.Enabled = true;
				this.panel4.Hide();
			}
			else
			{
				MessageBox.Show("Roblox isn't started!");
			}
		}

		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			this.label4.Text = "Updating Script Hub";
			if (File.Exists("bin.zip"))
			{
				File.Delete("bin.zip");
			}
			if (Directory.Exists("bin"))
			{
				Directory.Delete("bin", true);
			}
			this.listBox1.Items.Clear();
			(new WebClient()).DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/scripts.zip?raw=true", "bin.zip");
			ZipFile.ExtractToDirectory("bin.zip", "bin");
			File.Delete("bin.zip");
			this.listBox1.Items.Clear();
			Functions.PopulateListBox1(this.listBox1, "./bin/scripts", "*.txt");
			this.label4.Text = "Update done!";
			Thread.Sleep(1000);
			this.panel4.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			HtmlDocument document = this.MonacoEditor.Document;
			string str = "GetText";
			object[] objArray = new string[0];
			string str1 = document.InvokeScript(str, objArray).ToString();
			this.m.ExecuteScript(str1);
		}

		private void button10_Click(object sender, EventArgs e)
		{
			(new TaintCheck()).Show();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			this.m.ExecuteScript("loadstring(game:HttpGet(('https://pastebin.com/raw/SsG8y3HA'),true))()");
		}

		private void button12_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/mHATydM");
		}

		private void button13_Click(object sender, EventArgs e)
		{
			Process.Start("Applications\\multirblx.exe");
		}

		private void button14_Click(object sender, EventArgs e)
		{
			this.m.ExecuteScript("game.JointsService.WeldRequest:FireServer(\"gui\")");
			MessageBox.Show("Serverside ran! If the GUI dosen't show up, check that you are in a serversided game! Check our discord in #serversided-games for a list of serversided games!", "Notice");
		}

		private void button15_Click(object sender, EventArgs e)
		{
			this.m.ExecuteScript("if workspace[\"MainDab Anti Exploit\"] == nil then\r\nprint(\"Serverside not found in game!\")\r\nelse\r\nprint(\"Serverside found in game!\")\r\nend");
			MessageBox.Show("Press F9 to see the details. If it's backdoored, it should print it is. If you encounter an errorm that means the the serverside dosen't exist in the game!", "Notice");
		}

		private void button16_Click(object sender, EventArgs e)
		{
			this.m.ExecuteScript(this.richTextBox2.Text);
		}

		private void button17_Click(object sender, EventArgs e)
		{
		}

		private void button18_Click(object sender, EventArgs e)
		{
			(new MainUI()).Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.MonacoEditor.Document.InvokeScript("SetText", new object[] { "" });
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (Functions.openfiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					string str = File.ReadAllText(Functions.openfiledialog.FileName);
					this.MonacoEditor.Document.InvokeScript("SetText", new object[] { str });
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					MessageBox.Show(string.Concat("Error: Could not read file from disk. Original error: ", exception.Message));
					Console.WriteLine("File can't be opened");
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.backgroundWorker1.RunWorkerAsync();
		}

		private void button5_Click(object sender, EventArgs e)
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

		private void button6_Click(object sender, EventArgs e)
		{
			using (StreamWriter streamWriter = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers\\etc\\hosts")))
			{
				streamWriter.WriteLine("# Anti-Banwave Code");
				streamWriter.WriteLine("127.0.0.1 data.roblox.com");
				streamWriter.WriteLine("127.0.0.1 roblox.sp.backtrace.io");
			}
			MessageBox.Show("AntiBanWave activated!");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Process.Start("Applications\\fpsunlocker.exe");
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Process.Start("Applications\\vpn.exe");
		}

		private void button9_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Reinstalling Roblox", "MainDab", MessageBoxButtons.OK);
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

		[DllImport("Gdi32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void fadeIn(object sender, EventArgs e)
		{
			if (base.Opacity < 1)
			{
				base.Opacity = base.Opacity + 0.05;
			}
			else
			{
				this.t1.Stop();
			}
		}

		private void fadeOut(object sender, EventArgs e)
		{
			if (base.Opacity > 0)
			{
				base.Opacity = base.Opacity - 0.05;
			}
			else
			{
				this.t1.Stop();
				base.Close();
			}
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(NewuI));
			this.panel1 = new Panel();
			this.panel5 = new Panel();
			this.label5 = new Label();
			this.panel4 = new Panel();
			this.label4 = new Label();
			this.label3 = new Label();
			this.label2 = new Label();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.Execution = new Panel();
			this.richTextBox2 = new RichTextBox();
			this.MonacoEditor = new WebBrowser();
			this.button5 = new Button();
			this.button4 = new Button();
			this.button3 = new Button();
			this.button2 = new Button();
			this.button1 = new Button();
			this.ScriptHub = new Panel();
			this.button16 = new Button();
			this.pictureBox6 = new PictureBox();
			this.richTextBox1 = new RichTextBox();
			this.listBox1 = new ListBox();
			this.Others = new Panel();
			this.button17 = new Button();
			this.Tools = new Panel();
			this.button13 = new Button();
			this.button12 = new Button();
			this.button11 = new Button();
			this.button10 = new Button();
			this.button9 = new Button();
			this.button8 = new Button();
			this.button7 = new Button();
			this.button6 = new Button();
			this.Serverside = new Panel();
			this.button15 = new Button();
			this.button14 = new Button();
			this.backgroundWorker1 = new BackgroundWorker();
			this.bunifuDragControl1 = new BunifuDragControl(this.components);
			this.backgroundWorker2 = new BackgroundWorker();
			this.panel6 = new Panel();
			this.panel3 = new Panel();
			this.button18 = new Button();
			this.flowLayoutPanel1 = new FlowLayoutPanel();
			this.pictureBox1 = new PictureBox();
			this.pictureBox2 = new PictureBox();
			this.pictureBox4 = new PictureBox();
			this.pictureBox3 = new PictureBox();
			this.pictureBox7 = new PictureBox();
			this.pictureBox5 = new PictureBox();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.Execution.SuspendLayout();
			this.ScriptHub.SuspendLayout();
			((ISupportInitialize)this.pictureBox6).BeginInit();
			this.Others.SuspendLayout();
			this.Tools.SuspendLayout();
			this.Serverside.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel3.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			((ISupportInitialize)this.pictureBox7).BeginInit();
			((ISupportInitialize)this.pictureBox5).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = Color.RoyalBlue;
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new Point(-16, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1205, 33);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
			this.panel5.Location = new Point(176, 40);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(69, 73);
			this.panel5.TabIndex = 4;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Leelawadee", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.Location = new Point(117, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(22, 15);
			this.label5.TabIndex = 5;
			this.label5.Text = "V4";
			this.panel4.BackColor = Color.MediumAquamarine;
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new Point(251, 1);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(265, 31);
			this.panel4.TabIndex = 4;
			this.label4.AutoSize = true;
			this.label4.Location = new Point(3, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 18);
			this.label4.TabIndex = 0;
			this.label4.Text = "Doing Shit";
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Leelawadee", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.Snow;
			this.label3.Location = new Point(683, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(18, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "-";
			this.label3.Click += new EventHandler(this.label3_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Leelawadee", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Red;
			this.label2.Location = new Point(705, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "X";
			this.label2.Click += new EventHandler(this.label2_Click);
			this.panel2.Location = new Point(17, 62);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(235, 411);
			this.panel2.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Leelawadee", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.ForeColor = SystemColors.Control;
			this.label1.Location = new Point(17, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "MainDab";
			this.Execution.Controls.Add(this.richTextBox2);
			this.Execution.Controls.Add(this.MonacoEditor);
			this.Execution.Controls.Add(this.button5);
			this.Execution.Controls.Add(this.button4);
			this.Execution.Controls.Add(this.button3);
			this.Execution.Controls.Add(this.button2);
			this.Execution.Controls.Add(this.button1);
			this.Execution.Dock = DockStyle.Fill;
			this.Execution.Location = new Point(0, 0);
			this.Execution.Name = "Execution";
			this.Execution.Size = new System.Drawing.Size(531, 292);
			this.Execution.TabIndex = 3;
			this.richTextBox2.Location = new Point(469, 281);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(60, 67);
			this.richTextBox2.TabIndex = 8;
			this.richTextBox2.Text = "";
			this.MonacoEditor.Location = new Point(4, 3);
			this.MonacoEditor.MinimumSize = new System.Drawing.Size(20, 20);
			this.MonacoEditor.Name = "MonacoEditor";
			this.MonacoEditor.Size = new System.Drawing.Size(523, 219);
			this.MonacoEditor.TabIndex = 5;
			this.MonacoEditor.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
			this.button5.BackColor = Color.FromArgb(50, 50, 50);
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.ForeColor = Color.White;
			this.button5.Location = new Point(424, 228);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(103, 33);
			this.button5.TabIndex = 4;
			this.button5.Text = "Kill Roblox";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new EventHandler(this.button5_Click);
			this.button4.BackColor = Color.FromArgb(50, 50, 50);
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.ForeColor = Color.White;
			this.button4.Location = new Point(324, 228);
			this.button4.Name = "button4";
			this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button4.Size = new System.Drawing.Size(94, 33);
			this.button4.TabIndex = 3;
			this.button4.Text = "Inject";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new EventHandler(this.button4_Click);
			this.button3.BackColor = Color.FromArgb(50, 50, 50);
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.ForeColor = Color.White;
			this.button3.Location = new Point(221, 228);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(97, 33);
			this.button3.TabIndex = 2;
			this.button3.Text = "Open";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new EventHandler(this.button3_Click);
			this.button2.BackColor = Color.FromArgb(50, 50, 50);
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.ForeColor = Color.White;
			this.button2.Location = new Point(116, 228);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(99, 33);
			this.button2.TabIndex = 1;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.button1.BackColor = Color.FromArgb(50, 50, 50);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.ForeColor = Color.White;
			this.button1.Location = new Point(7, 228);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(103, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "Execute";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.ScriptHub.Controls.Add(this.button16);
			this.ScriptHub.Controls.Add(this.pictureBox6);
			this.ScriptHub.Controls.Add(this.richTextBox1);
			this.ScriptHub.Controls.Add(this.listBox1);
			this.ScriptHub.Dock = DockStyle.Fill;
			this.ScriptHub.Location = new Point(0, 0);
			this.ScriptHub.Name = "ScriptHub";
			this.ScriptHub.Size = new System.Drawing.Size(531, 292);
			this.ScriptHub.TabIndex = 7;
			this.ScriptHub.Paint += new PaintEventHandler(this.ScriptHub_Paint);
			this.button16.BackColor = Color.FromArgb(50, 50, 50);
			this.button16.FlatAppearance.BorderSize = 0;
			this.button16.FlatStyle = FlatStyle.Flat;
			this.button16.ForeColor = Color.White;
			this.button16.Location = new Point(211, 217);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(207, 44);
			this.button16.TabIndex = 7;
			this.button16.Text = "Execute Script!";
			this.button16.UseVisualStyleBackColor = false;
			this.button16.Click += new EventHandler(this.button16_Click);
			this.pictureBox6.Location = new Point(210, 67);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(208, 144);
			this.pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 3;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Click += new EventHandler(this.pictureBox6_Click);
			this.richTextBox1.BackColor = Color.FromArgb(40, 40, 40);
			this.richTextBox1.BorderStyle = BorderStyle.None;
			this.richTextBox1.Font = new System.Drawing.Font("Leelawadee", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.richTextBox1.ForeColor = SystemColors.Window;
			this.richTextBox1.Location = new Point(207, 7);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(211, 57);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "Description of script here...";
			this.listBox1.BackColor = Color.FromArgb(50, 50, 50);
			this.listBox1.BorderStyle = BorderStyle.None;
			this.listBox1.Font = new System.Drawing.Font("Leelawadee", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.listBox1.ForeColor = SystemColors.Window;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 14;
			this.listBox1.Location = new Point(7, 5);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(194, 252);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
			this.Others.Controls.Add(this.button17);
			this.Others.Dock = DockStyle.Fill;
			this.Others.Location = new Point(0, 0);
			this.Others.Name = "Others";
			this.Others.Size = new System.Drawing.Size(531, 292);
			this.Others.TabIndex = 8;
			this.button17.BackColor = Color.FromArgb(50, 50, 50);
			this.button17.FlatAppearance.BorderSize = 0;
			this.button17.FlatStyle = FlatStyle.Flat;
			this.button17.ForeColor = Color.White;
			this.button17.Location = new Point(22, 12);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(120, 28);
			this.button17.TabIndex = 8;
			this.button17.Text = "About MainDab";
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += new EventHandler(this.button17_Click);
			this.Tools.Controls.Add(this.button13);
			this.Tools.Controls.Add(this.button12);
			this.Tools.Controls.Add(this.button11);
			this.Tools.Controls.Add(this.button10);
			this.Tools.Controls.Add(this.button9);
			this.Tools.Controls.Add(this.button8);
			this.Tools.Controls.Add(this.button7);
			this.Tools.Controls.Add(this.button6);
			this.Tools.Dock = DockStyle.Fill;
			this.Tools.Location = new Point(0, 0);
			this.Tools.Name = "Tools";
			this.Tools.Size = new System.Drawing.Size(531, 292);
			this.Tools.TabIndex = 6;
			this.button13.BackColor = Color.FromArgb(50, 50, 50);
			this.button13.FlatAppearance.BorderSize = 0;
			this.button13.FlatStyle = FlatStyle.Flat;
			this.button13.ForeColor = Color.White;
			this.button13.Location = new Point(186, 186);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(163, 52);
			this.button13.TabIndex = 8;
			this.button13.Text = "MultiRoblox";
			this.button13.UseVisualStyleBackColor = false;
			this.button13.Click += new EventHandler(this.button13_Click);
			this.button12.BackColor = Color.FromArgb(50, 50, 50);
			this.button12.FlatAppearance.BorderSize = 0;
			this.button12.FlatStyle = FlatStyle.Flat;
			this.button12.ForeColor = Color.White;
			this.button12.Location = new Point(184, 128);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(163, 52);
			this.button12.TabIndex = 7;
			this.button12.Text = "Join our Discord";
			this.button12.UseVisualStyleBackColor = false;
			this.button12.Click += new EventHandler(this.button12_Click);
			this.button11.BackColor = Color.FromArgb(50, 50, 50);
			this.button11.FlatAppearance.BorderSize = 0;
			this.button11.FlatStyle = FlatStyle.Flat;
			this.button11.ForeColor = Color.White;
			this.button11.Location = new Point(184, 70);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(163, 52);
			this.button11.TabIndex = 6;
			this.button11.Text = "EZ Hub";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new EventHandler(this.button11_Click);
			this.button10.BackColor = Color.FromArgb(50, 50, 50);
			this.button10.FlatAppearance.BorderSize = 0;
			this.button10.FlatStyle = FlatStyle.Flat;
			this.button10.ForeColor = Color.White;
			this.button10.Location = new Point(184, 12);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(163, 52);
			this.button10.TabIndex = 5;
			this.button10.Text = "Tainted / Detected exploits checker";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new EventHandler(this.button10_Click);
			this.button9.BackColor = Color.FromArgb(50, 50, 50);
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatStyle = FlatStyle.Flat;
			this.button9.ForeColor = Color.White;
			this.button9.Location = new Point(15, 186);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(163, 52);
			this.button9.TabIndex = 4;
			this.button9.Text = "Reinstall Roblox";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new EventHandler(this.button9_Click);
			this.button8.BackColor = Color.FromArgb(50, 50, 50);
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = FlatStyle.Flat;
			this.button8.ForeColor = Color.White;
			this.button8.Location = new Point(15, 128);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(163, 52);
			this.button8.TabIndex = 3;
			this.button8.Text = "VPN";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new EventHandler(this.button8_Click);
			this.button7.BackColor = Color.FromArgb(50, 50, 50);
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.ForeColor = Color.White;
			this.button7.Location = new Point(15, 70);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(163, 52);
			this.button7.TabIndex = 2;
			this.button7.Text = "FPS Unlocker";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new EventHandler(this.button7_Click);
			this.button6.BackColor = Color.FromArgb(50, 50, 50);
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.ForeColor = Color.White;
			this.button6.Location = new Point(15, 12);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(163, 52);
			this.button6.TabIndex = 1;
			this.button6.Text = "Anti Ban Wave";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new EventHandler(this.button6_Click);
			this.Serverside.Controls.Add(this.button15);
			this.Serverside.Controls.Add(this.button14);
			this.Serverside.Dock = DockStyle.Fill;
			this.Serverside.Location = new Point(0, 0);
			this.Serverside.Name = "Serverside";
			this.Serverside.Size = new System.Drawing.Size(531, 292);
			this.Serverside.TabIndex = 9;
			this.button15.BackColor = Color.FromArgb(50, 50, 50);
			this.button15.FlatAppearance.BorderSize = 0;
			this.button15.FlatStyle = FlatStyle.Flat;
			this.button15.ForeColor = Color.White;
			this.button15.Location = new Point(14, 67);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(163, 52);
			this.button15.TabIndex = 6;
			this.button15.Text = "Check if game is serversided";
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += new EventHandler(this.button15_Click);
			this.button14.BackColor = Color.FromArgb(50, 50, 50);
			this.button14.FlatAppearance.BorderSize = 0;
			this.button14.FlatStyle = FlatStyle.Flat;
			this.button14.ForeColor = Color.White;
			this.button14.Location = new Point(14, 9);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(163, 52);
			this.button14.TabIndex = 5;
			this.button14.Text = "Execute serverside";
			this.button14.UseVisualStyleBackColor = false;
			this.button14.Click += new EventHandler(this.button14_Click);
			this.backgroundWorker1.DoWork += new DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.panel1;
			this.bunifuDragControl1.Vertical = true;
			this.backgroundWorker2.DoWork += new DoWorkEventHandler(this.backgroundWorker2_DoWork);
			this.panel6.Controls.Add(this.Execution);
			this.panel6.Controls.Add(this.panel3);
			this.panel6.Controls.Add(this.Serverside);
			this.panel6.Controls.Add(this.Others);
			this.panel6.Controls.Add(this.ScriptHub);
			this.panel6.Controls.Add(this.Tools);
			this.panel6.Location = new Point(177, 35);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(531, 292);
			this.panel6.TabIndex = 4;
			this.panel3.Controls.Add(this.button18);
			this.panel3.Dock = DockStyle.Fill;
			this.panel3.Location = new Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(531, 292);
			this.panel3.TabIndex = 9;
			this.button18.BackColor = Color.FromArgb(50, 50, 50);
			this.button18.FlatAppearance.BorderSize = 0;
			this.button18.FlatStyle = FlatStyle.Flat;
			this.button18.ForeColor = Color.White;
			this.button18.Location = new Point(7, 15);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(240, 46);
			this.button18.TabIndex = 1;
			this.button18.Text = "Obfuscator coming soon!";
			this.button18.UseVisualStyleBackColor = false;
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.BackColor = Color.FromArgb(48, 48, 48);
			this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
			this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
			this.flowLayoutPanel1.Controls.Add(this.pictureBox4);
			this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
			this.flowLayoutPanel1.Controls.Add(this.pictureBox7);
			this.flowLayoutPanel1.Controls.Add(this.pictureBox5);
			this.flowLayoutPanel1.Location = new Point(1, 35);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(175, 276);
			this.flowLayoutPanel1.TabIndex = 52;
			this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(146, 48);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new Point(3, 57);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(146, 48);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new EventHandler(this.pictureBox2_Click);
			this.pictureBox4.Image = (Image)componentResourceManager.GetObject("pictureBox4.Image");
			this.pictureBox4.Location = new Point(3, 111);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(145, 49);
			this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 3;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new EventHandler(this.pictureBox4_Click);
			this.pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new Point(3, 166);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(145, 51);
			this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new EventHandler(this.pictureBox3_Click);
			this.pictureBox7.Image = (Image)componentResourceManager.GetObject("pictureBox7.Image");
			this.pictureBox7.Location = new Point(3, 223);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(146, 56);
			this.pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox7.TabIndex = 5;
			this.pictureBox7.TabStop = false;
			this.pictureBox7.Click += new EventHandler(this.pictureBox7_Click);
			this.pictureBox5.Image = (Image)componentResourceManager.GetObject("pictureBox5.Image");
			this.pictureBox5.Location = new Point(3, 285);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(146, 53);
			this.pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 4;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new EventHandler(this.pictureBox5_Click);
			base.AutoScaleDimensions = new SizeF(8f, 18f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(40, 40, 40);
			base.ClientSize = new System.Drawing.Size(711, 307);
			base.Controls.Add(this.flowLayoutPanel1);
			base.Controls.Add(this.panel6);
			base.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Leelawadee", 11f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ForeColor = SystemColors.ButtonHighlight;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "NewuI";
			this.Text = "Doing Shit";
			base.Load += new EventHandler(this.NewuI_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.Execution.ResumeLayout(false);
			this.ScriptHub.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox6).EndInit();
			this.Others.ResumeLayout(false);
			this.Tools.ResumeLayout(false);
			this.Serverside.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox1).EndInit();
			((ISupportInitialize)this.pictureBox2).EndInit();
			((ISupportInitialize)this.pictureBox4).EndInit();
			((ISupportInitialize)this.pictureBox3).EndInit();
			((ISupportInitialize)this.pictureBox7).EndInit();
			((ISupportInitialize)this.pictureBox5).EndInit();
			base.ResumeLayout(false);
		}

		private void label2_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void label3_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string str = File.ReadAllText(string.Concat("bin\\scripts\\", this.listBox1.SelectedItem.ToString()));
			if (this.listBox1.SelectedItem != null)
			{
				string str1 = str;
				this.richTextBox2.Text = str1;
				string str2 = str1.Split(new char[] { '\r', '\n' }).FirstOrDefault<string>();
				string str3 = str2.Remove(0, 2);
				this.richTextBox1.Text = str3;
				string str4 = str1.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)[1];
				string str5 = str4.Remove(0, 2);
				using (WebResponse response = WebRequest.Create(str5).GetResponse())
				{
					using (Stream responseStream = response.GetResponseStream())
					{
						this.pictureBox6.Image = Image.FromStream(responseStream);
					}
				}
			}
		}

		private void NewuI_Load(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient()
			{
				Proxy = null
			};
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
			this.MonacoEditor.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
			this.MonacoEditor.Document.InvokeScript("SetTheme", new string[] { "Dark" });
			this.addBase();
			this.addMath();
			this.addGlobalNS();
			this.addGlobalV();
			this.addGlobalF();
			this.MonacoEditor.Document.InvokeScript("SetText", new object[] { "-- Made by MainEX" });
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Execution.BringToFront();
			this.Execution.Show();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Tools.BringToFront();
			this.Tools.Show();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.Serverside.BringToFront();
			this.Serverside.Show();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			this.ScriptHub.BringToFront();
			this.ScriptHub.Show();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			this.Others.BringToFront();
			this.Others.Show();
			this.ScriptHub.Hide();
			this.Serverside.Hide();
			this.Execution.Hide();
			this.Others.BringToFront();
			this.Others.Show();
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			this.panel3.BringToFront();
			this.panel3.Show();
		}

		private void ScriptHub_Paint(object sender, PaintEventArgs e)
		{
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
		}

		private void trackBar1_Scroll_1(object sender, EventArgs e)
		{
		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}
	}
}