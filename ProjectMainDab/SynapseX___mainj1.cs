using Bunifu.Framework.UI;
using EasyExploits;
using Microsoft.Win32;
using ProjectMainDab.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMainDab
{
	public class SynapseX___mainj1 : Form
	{
		private Module m = new Module();

		private WebClient wc = new WebClient();

		private string defPath = string.Concat(Application.StartupPath, "//Monaco//");

		private IContainer components = null;

		private Panel panel1;

		private Button button3;

		private Button button2;

		private PictureBox pictureBox1;

		private Button button1;

		private Button button4;

		private Button button5;

		private Button button6;

		private Button button7;

		private Button button10;

		private OpenFileDialog openFileDialog1;

		private SaveFileDialog saveFileDialog1;

		private ListBox listBox1;

		private TextBox textBox1;

		private BunifuDragControl bunifuDragControl1;

		private BunifuDragControl bunifuDragControl2;

		private BunifuDragControl bunifuDragControl4;

		private BunifuDragControl bunifuDragControl5;

		private Label label1;

		private Button button8;

		private WebBrowser webBrowser1;

		private Label label2;

		private BunifuDragControl bunifuDragControl3;

		private BunifuDragControl bunifuDragControl6;

		private BunifuDragControl bunifuDragControl7;

		private BunifuDragControl bunifuDragControl8;

		private PictureBox pictureBox3;

		public SynapseX___mainj1()
		{
			this.InitializeComponent();
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
			this.webBrowser1.Document.InvokeScript("AddIntellisense", new object[] { label, kind, detail, insertText });
		}

		private void addMath()
		{
			foreach (string str in File.ReadLines(string.Concat(this.defPath, "//classfunc.txt")))
			{
				this.addIntel(str, "Method", str, str);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			HtmlDocument document = this.webBrowser1.Document;
			string str = "GetText";
			object[] objArray = new string[0];
			string str1 = document.InvokeScript(str, objArray).ToString();
			this.m.ExecuteScript(str1);
		}

		private void Button1_MouseEnter(object sender, EventArgs e)
		{
			this.button1.FlatAppearance.BorderSize = 1;
			this.button1.FlatAppearance.BorderColor = Color.White;
		}

		private void Button1_MouseLeave(object sender, EventArgs e)
		{
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.BorderColor = Color.White;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			if (Process.GetProcessesByName("RobloxPlayerBeta").Length != 0)
			{
				this.m.LaunchExploit();
			}
			else
			{
				MessageBox.Show("MainDab isn't started!");
			}
		}

		private void Button10_MouseEnter(object sender, EventArgs e)
		{
			this.button10.FlatAppearance.BorderSize = 1;
			this.button10.FlatAppearance.BorderColor = Color.White;
		}

		private void Button10_MouseLeave(object sender, EventArgs e)
		{
			this.button10.FlatAppearance.BorderSize = 0;
			this.button10.FlatAppearance.BorderColor = Color.White;
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			base.Close();
			(new MainUI()).Show();
		}

		private void Button2_MouseEnter(object sender, EventArgs e)
		{
			this.button2.FlatAppearance.BorderSize = 1;
			this.button2.FlatAppearance.BorderColor = Color.White;
		}

		private void Button2_MouseLeave(object sender, EventArgs e)
		{
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.BorderColor = Color.White;
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void Button3_MouseEnter(object sender, EventArgs e)
		{
			this.button3.FlatAppearance.BorderSize = 1;
			this.button3.FlatAppearance.BorderColor = Color.White;
		}

		private void Button3_MouseLeave(object sender, EventArgs e)
		{
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatAppearance.BorderColor = Color.White;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.webBrowser1.Document.InvokeScript("SetText", new object[] { "" });
		}

		private void Button4_MouseEnter(object sender, EventArgs e)
		{
			this.button4.FlatAppearance.BorderSize = 1;
			this.button4.FlatAppearance.BorderColor = Color.White;
		}

		private void Button4_MouseLeave(object sender, EventArgs e)
		{
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatAppearance.BorderColor = Color.White;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (Functions.openfiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					this.webBrowser1.Document.InvokeScript("SetText", new object[] { File.ReadAllText(Functions.openfiledialog.FileName) });
				}
				catch (Exception exception)
				{
					MessageBox.Show("This file is corrupted or not supported.", "Synapse X");
				}
			}
		}

		private void Button5_MouseEnter(object sender, EventArgs e)
		{
			this.button5.FlatAppearance.BorderSize = 1;
			this.button5.FlatAppearance.BorderColor = Color.White;
		}

		private void Button5_MouseLeave(object sender, EventArgs e)
		{
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatAppearance.BorderColor = Color.White;
		}

		private void Button6_Click(object sender, EventArgs e)
		{
		}

		private void Button6_MouseEnter(object sender, EventArgs e)
		{
			this.button6.FlatAppearance.BorderSize = 1;
			this.button6.FlatAppearance.BorderColor = Color.White;
		}

		private void Button6_MouseLeave(object sender, EventArgs e)
		{
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatAppearance.BorderColor = Color.White;
		}

		private void button7_Click(object sender, EventArgs e)
		{
		}

		private void Button7_MouseEnter(object sender, EventArgs e)
		{
			this.button7.FlatAppearance.BorderSize = 1;
			this.button7.FlatAppearance.BorderColor = Color.White;
		}

		private void Button7_MouseLeave(object sender, EventArgs e)
		{
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatAppearance.BorderColor = Color.White;
		}

		private void Button8_Click(object sender, EventArgs e)
		{
			Process.Start("www.pornhub.com");
		}

		private void Button8_MouseEnter(object sender, EventArgs e)
		{
			this.button8.FlatAppearance.BorderSize = 1;
			this.button8.FlatAppearance.BorderColor = Color.White;
		}

		private void Button8_MouseLeave(object sender, EventArgs e)
		{
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatAppearance.BorderColor = Color.White;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			(new Form2()).ShowDialog();
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void fastColoredTextBox1_Load(object sender, EventArgs e)
		{
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./scripts", "*.lua");
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
				registryKey = null;
				friendlyName = null;
				registryKey = null;
				friendlyName = null;
			}
			catch (Exception exception)
			{
			}
			this.webBrowser1.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
			await Task.Delay(500);
			HtmlDocument document = this.webBrowser1.Document;
			string[] strArrays = new string[] { "Dark" };
			document.InvokeScript("SetTheme", strArrays);
			this.addBase();
			this.addMath();
			this.addGlobalNS();
			this.addGlobalV();
			this.addGlobalF();
			HtmlDocument htmlDocument = this.webBrowser1.Document;
			object[] objArray = new object[] { "" };
			htmlDocument.InvokeScript("SetText", objArray);
			webClient = null;
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel1 = new Panel();
			this.pictureBox3 = new PictureBox();
			this.label2 = new Label();
			this.textBox1 = new TextBox();
			this.button3 = new Button();
			this.button2 = new Button();
			this.label1 = new Label();
			this.pictureBox1 = new PictureBox();
			this.button1 = new Button();
			this.button4 = new Button();
			this.button5 = new Button();
			this.button6 = new Button();
			this.button7 = new Button();
			this.button10 = new Button();
			this.openFileDialog1 = new OpenFileDialog();
			this.saveFileDialog1 = new SaveFileDialog();
			this.listBox1 = new ListBox();
			this.bunifuDragControl1 = new BunifuDragControl(this.components);
			this.bunifuDragControl2 = new BunifuDragControl(this.components);
			this.bunifuDragControl4 = new BunifuDragControl(this.components);
			this.bunifuDragControl5 = new BunifuDragControl(this.components);
			this.button8 = new Button();
			this.webBrowser1 = new WebBrowser();
			this.bunifuDragControl3 = new BunifuDragControl(this.components);
			this.bunifuDragControl6 = new BunifuDragControl(this.components);
			this.bunifuDragControl7 = new BunifuDragControl(this.components);
			this.bunifuDragControl8 = new BunifuDragControl(this.components);
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = Color.FromArgb(50, 50, 50);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new Point(-6, -11);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1186, 92);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
			this.pictureBox3.Image = Resources._7uJh9W1;
			this.pictureBox3.Location = new Point(22, 20);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(69, 65);
			this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 41;
			this.pictureBox3.TabStop = false;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(267, 30);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 40);
			this.label2.TabIndex = 23;
			this.label2.Text = "SEX";
			this.textBox1.BackColor = Color.FromArgb(50, 50, 50);
			this.textBox1.BorderStyle = BorderStyle.None;
			this.textBox1.Cursor = Cursors.Default;
			this.textBox1.ForeColor = Color.FromArgb(50, 50, 50);
			this.textBox1.Location = new Point(606, 54);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(404, 31);
			this.textBox1.TabIndex = 22;
			this.textBox1.Visible = false;
			this.button3.BackColor = Color.FromArgb(70, 70, 70);
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 50, 80);
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999f);
			this.button3.ForeColor = Color.White;
			this.button3.Location = new Point(1065, 26);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(38, 38);
			this.button3.TabIndex = 6;
			this.button3.Text = "-";
			this.button3.TextAlign = ContentAlignment.BottomCenter;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new EventHandler(this.Button3_Click);
			this.button3.MouseEnter += new EventHandler(this.Button3_MouseEnter);
			this.button3.MouseLeave += new EventHandler(this.Button3_MouseLeave);
			this.button2.BackColor = Color.FromArgb(238, 82, 83);
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 50, 80);
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999f);
			this.button2.ForeColor = Color.White;
			this.button2.Location = new Point(1112, 26);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(38, 38);
			this.button2.TabIndex = 5;
			this.button2.Text = "X";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new EventHandler(this.Button2_Click);
			this.button2.MouseEnter += new EventHandler(this.Button2_MouseEnter);
			this.button2.MouseLeave += new EventHandler(this.Button2_MouseLeave);
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Consolas", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.WhiteSmoke;
			this.label1.Location = new Point(96, 25);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 48);
			this.label1.TabIndex = 2;
			this.label1.Text = "SYNAPSE\r\n";
			this.pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
			this.pictureBox1.Image = Resources._7uJh9W;
			this.pictureBox1.Location = new Point(20, 14);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(68, 65);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.button1.BackColor = Color.FromArgb(60, 60, 60);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 50, 80);
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.button1.ForeColor = Color.White;
			this.button1.Location = new Point(8, 489);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 45);
			this.button1.TabIndex = 13;
			this.button1.Text = "Execute";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.button1.MouseEnter += new EventHandler(this.Button1_MouseEnter);
			this.button1.MouseLeave += new EventHandler(this.Button1_MouseLeave);
			this.button4.BackColor = Color.FromArgb(60, 60, 60);
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 50, 80);
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.button4.ForeColor = Color.White;
			this.button4.Location = new Point(145, 488);
			this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(129, 46);
			this.button4.TabIndex = 14;
			this.button4.Text = "Cum";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new EventHandler(this.button4_Click);
			this.button4.MouseEnter += new EventHandler(this.Button4_MouseEnter);
			this.button4.MouseLeave += new EventHandler(this.Button4_MouseLeave);
			this.button5.BackColor = Color.FromArgb(60, 60, 60);
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 50, 80);
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.button5.ForeColor = Color.White;
			this.button5.Location = new Point(282, 488);
			this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(129, 46);
			this.button5.TabIndex = 15;
			this.button5.Text = "Open Penis";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new EventHandler(this.button5_Click);
			this.button5.MouseEnter += new EventHandler(this.Button5_MouseEnter);
			this.button5.MouseLeave += new EventHandler(this.Button5_MouseLeave);
			this.button6.BackColor = Color.FromArgb(60, 60, 60);
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 50, 80);
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button6.ForeColor = Color.White;
			this.button6.Location = new Point(419, 488);
			this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(129, 46);
			this.button6.TabIndex = 16;
			this.button6.Text = "Execute Penis";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new EventHandler(this.Button6_Click);
			this.button6.MouseEnter += new EventHandler(this.Button6_MouseEnter);
			this.button6.MouseLeave += new EventHandler(this.Button6_MouseLeave);
			this.button7.BackColor = Color.FromArgb(60, 60, 60);
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 50, 80);
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.button7.ForeColor = Color.White;
			this.button7.Location = new Point(556, 488);
			this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(129, 48);
			this.button7.TabIndex = 17;
			this.button7.Text = "Save Penis";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new EventHandler(this.button7_Click);
			this.button7.MouseEnter += new EventHandler(this.Button7_MouseEnter);
			this.button7.MouseLeave += new EventHandler(this.Button7_MouseLeave);
			this.button10.BackColor = Color.FromArgb(60, 60, 60);
			this.button10.FlatAppearance.BorderSize = 0;
			this.button10.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 50, 80);
			this.button10.FlatStyle = FlatStyle.Flat;
			this.button10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.button10.ForeColor = Color.White;
			this.button10.Location = new Point(948, 488);
			this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(196, 48);
			this.button10.TabIndex = 20;
			this.button10.Text = "Start Cumming";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new EventHandler(this.button10_Click);
			this.button10.MouseEnter += new EventHandler(this.Button10_MouseEnter);
			this.button10.MouseLeave += new EventHandler(this.Button10_MouseLeave);
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = " Text Files(*.txt)|*.txt|Lua Files(*.lua)|*.lua|All Files(*.*)|*.*";
			this.openFileDialog1.RestoreDirectory = true;
			this.saveFileDialog1.Filter = " Text Files(*.txt)|*.txt|Lua Files(*.lua)|*.lua|All Files(*.*)|*.*";
			this.listBox1.BackColor = Color.FromArgb(30, 30, 30);
			this.listBox1.BorderStyle = BorderStyle.None;
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.listBox1.ForeColor = Color.White;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 22;
			this.listBox1.Location = new Point(948, 85);
			this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(196, 396);
			this.listBox1.TabIndex = 21;
			this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this;
			this.bunifuDragControl1.Vertical = true;
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.label1;
			this.bunifuDragControl2.Vertical = true;
			this.bunifuDragControl4.Fixed = true;
			this.bunifuDragControl4.Horizontal = true;
			this.bunifuDragControl4.TargetControl = this.panel1;
			this.bunifuDragControl4.Vertical = true;
			this.bunifuDragControl5.Fixed = true;
			this.bunifuDragControl5.Horizontal = true;
			this.bunifuDragControl5.TargetControl = this.pictureBox1;
			this.bunifuDragControl5.Vertical = true;
			this.button8.BackColor = Color.FromArgb(60, 60, 60);
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 50, 80);
			this.button8.FlatStyle = FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.button8.ForeColor = Color.White;
			this.button8.Location = new Point(693, 488);
			this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(243, 48);
			this.button8.TabIndex = 18;
			this.button8.Text = "Open PornHub";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new EventHandler(this.Button8_Click);
			this.button8.MouseEnter += new EventHandler(this.Button8_MouseEnter);
			this.button8.MouseLeave += new EventHandler(this.Button8_MouseLeave);
			this.webBrowser1.Location = new Point(-2, 85);
			this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(30, 31);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(938, 397);
			this.webBrowser1.TabIndex = 22;
			this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
			this.bunifuDragControl3.Fixed = true;
			this.bunifuDragControl3.Horizontal = true;
			this.bunifuDragControl3.TargetControl = this.label2;
			this.bunifuDragControl3.Vertical = true;
			this.bunifuDragControl6.Fixed = true;
			this.bunifuDragControl6.Horizontal = true;
			this.bunifuDragControl6.TargetControl = null;
			this.bunifuDragControl6.Vertical = true;
			this.bunifuDragControl7.Fixed = true;
			this.bunifuDragControl7.Horizontal = true;
			this.bunifuDragControl7.TargetControl = null;
			this.bunifuDragControl7.Vertical = true;
			this.bunifuDragControl8.Fixed = true;
			this.bunifuDragControl8.Horizontal = true;
			this.bunifuDragControl8.TargetControl = null;
			this.bunifuDragControl8.Vertical = true;
			base.AutoScaleDimensions = new SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(50, 50, 50);
			base.ClientSize = new System.Drawing.Size(1155, 549);
			base.Controls.Add(this.webBrowser1);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.button10);
			base.Controls.Add(this.button8);
			base.Controls.Add(this.button7);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "SynapseX___mainj1";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Synapse X";
			base.Load += new EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.pictureBox3).EndInit();
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		private void Label3_Click(object sender, EventArgs e)
		{
		}

		[DllImport("WeAreDevs_API.cpp.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.None, ExactSpelling=false)]
		public static extern bool LaunchExploit();

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.webBrowser1.Document.InvokeScript("SetText", new object[] { "" });
			Console.WriteLine("Monaco cleared");
			string str = File.ReadAllText(string.Concat("Scripts\\", this.listBox1.SelectedItem.ToString()));
			if (this.listBox1.SelectedItem != null)
			{
				this.webBrowser1.Document.InvokeScript("SetText", new object[] { str });
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		[DllImport("WeAreDevs_API.cpp.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.None, ExactSpelling=false)]
		public static extern bool SendCommand(string script);

		[DllImport("WeAreDevs_API.cpp.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.None, ExactSpelling=false)]
		public static extern bool SendLimitedLuaScript(string script);

		[DllImport("WeAreDevs_API.cpp.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.None, ExactSpelling=false)]
		public static extern bool SendLuaCScript(string script);

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}
	}
}