using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjectMainDab
{
	public class Form2 : Form
	{
		public const int WM_NCLBUTTONDOWN = 161;

		public const int HT_CAPTION = 2;

		private const int SW_HIDE = 0;

		private const int SW_SHOW = 5;

		private IContainer components = null;

		private Label TitleDraggable;

		private Label CloseButton;

		private Button button4;

		private Button button1;

		private Button button2;

		private Button button3;

		private Button button6;

		private Button button5;

		private Button button7;

		public Form2()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			(new Hub1()).Show();
			base.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("Applications\\multirblx.exe");
			Directory.SetCurrentDirectory(Directory.GetCurrentDirectory());
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Process.Start("Applications\\fpsunlocker.exe");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			NamedPipes.LuaPipe("game.JointsService.WeldRequest:FireServer(\"gui\")");
			MessageBox.Show("Serverside ran! If the GUI dosen't show up, make sure that you are in a serversided game! Check our discord in #serversided-games for a list of serversided games! Also note that this functions is still in beta...", "Notice");
		}

		private void button5_Click(object sender, EventArgs e)
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

		private void button6_Click(object sender, EventArgs e)
		{
			Process.Start("Applications\\vpn.exe");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			IntPtr consoleWindow = Form2.GetConsoleWindow();
			Form2.ShowWindow(consoleWindow, 5);
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
				Form2.ShowWindow(consoleWindow, 0);
			}
			else
			{
				Console.WriteLine("Ironbrew found downloaded");
				MessageBox.Show("Ironbrew is already downloaded!");
				Form2.ShowWindow(consoleWindow, 0);
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\OurSettings");
			if (registryKey == null)
			{
				MessageBox.Show(" Settings don't exist! ");
			}
			else if (registryKey != null)
			{
				RegistryKey registryKey1 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\OurSettings", true);
				string str = registryKey1.GetValue("Setting1").ToString();
				string str1 = "SOFTWARE\\OurSettings";
				string str2 = "SOFTWARE\\OurSettings1";
				using (RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(str1, true))
				{
					if (registryKey != null)
					{
						registryKey.DeleteValue(str);
					}
					else
					{
						MessageBox.Show("Error resetting!");
					}
				}
				using (RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey(str2, true))
				{
					if (registryKey != null)
					{
						registryKey.DeleteValue("yes");
						MessageBox.Show("Reset sucessful!");
						(new Form6()).Show();
						base.Hide();
					}
					else
					{
						MessageBox.Show("Error resetting!");
					}
				}
				(new Form6()).Show();
				MessageBox.Show("Settings reset!");
			}
			else
			{
				RegistryKey registryKey4 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\OurSettings");
				string str3 = registryKey4.GetValue("Setting1").ToString();
				using (RegistryKey registryKey5 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\OurSettings", true))
				{
					if (registryKey != null)
					{
						registryKey.DeleteValue(str3);
						MessageBox.Show("Reset sucessful!");
						(new Form6()).Show();
						base.Hide();
					}
					else
					{
						MessageBox.Show("Error resetting!");
					}
				}
			}
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			base.Hide();
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

		private void Form2_Load(object sender, EventArgs e)
		{
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Region = System.Drawing.Region.FromHrgn(Form2.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern IntPtr GetConsoleWindow();

		private void InitializeComponent()
		{
			this.TitleDraggable = new Label();
			this.CloseButton = new Label();
			this.button4 = new Button();
			this.button1 = new Button();
			this.button2 = new Button();
			this.button3 = new Button();
			this.button6 = new Button();
			this.button5 = new Button();
			this.button7 = new Button();
			base.SuspendLayout();
			this.TitleDraggable.BackColor = Color.FromArgb(60, 60, 60);
			this.TitleDraggable.Font = new System.Drawing.Font("Calibri", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.TitleDraggable.ForeColor = SystemColors.ButtonHighlight;
			this.TitleDraggable.Location = new Point(-1, 1);
			this.TitleDraggable.Name = "TitleDraggable";
			this.TitleDraggable.Size = new System.Drawing.Size(435, 35);
			this.TitleDraggable.TabIndex = 1;
			this.TitleDraggable.Text = "Menu";
			this.TitleDraggable.Click += new EventHandler(this.TitleDraggable_Click);
			this.TitleDraggable.MouseDown += new MouseEventHandler(this.TitleDraggable_MouseDown);
			this.CloseButton.AutoSize = true;
			this.CloseButton.BackColor = Color.FromArgb(60, 60, 60);
			this.CloseButton.Font = new System.Drawing.Font("Calibri", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.CloseButton.ForeColor = Color.Red;
			this.CloseButton.Location = new Point(221, 9);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(20, 23);
			this.CloseButton.TabIndex = 2;
			this.CloseButton.Text = "X";
			this.CloseButton.Click += new EventHandler(this.CloseButton_Click);
			this.button4.BackColor = Color.FromArgb(60, 60, 60);
			this.button4.Cursor = Cursors.Hand;
			this.button4.Enabled = false;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button4.ForeColor = SystemColors.Control;
			this.button4.Location = new Point(10, 231);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(231, 30);
			this.button4.TabIndex = 14;
			this.button4.Text = "Serverside / Backdoor";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new EventHandler(this.button4_Click);
			this.button1.BackColor = Color.FromArgb(60, 60, 60);
			this.button1.Cursor = Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button1.ForeColor = SystemColors.Control;
			this.button1.Location = new Point(10, 51);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(231, 30);
			this.button1.TabIndex = 15;
			this.button1.Text = "Online Script hub";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.button2.BackColor = Color.FromArgb(60, 60, 60);
			this.button2.Cursor = Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button2.ForeColor = SystemColors.Control;
			this.button2.Location = new Point(10, 123);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(231, 30);
			this.button2.TabIndex = 16;
			this.button2.Text = "Multiple Roblox";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.button3.BackColor = Color.FromArgb(60, 60, 60);
			this.button3.Cursor = Cursors.Hand;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button3.ForeColor = SystemColors.Control;
			this.button3.Location = new Point(10, 87);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(231, 30);
			this.button3.TabIndex = 17;
			this.button3.Text = "FPS Unlocker";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new EventHandler(this.button3_Click);
			this.button6.BackColor = Color.FromArgb(60, 60, 60);
			this.button6.Cursor = Cursors.Hand;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button6.ForeColor = SystemColors.Control;
			this.button6.Location = new Point(10, 267);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(231, 30);
			this.button6.TabIndex = 19;
			this.button6.Text = "VPN";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new EventHandler(this.button6_Click);
			this.button5.BackColor = Color.FromArgb(60, 60, 60);
			this.button5.Cursor = Cursors.Hand;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button5.ForeColor = SystemColors.Control;
			this.button5.Location = new Point(10, 159);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(231, 30);
			this.button5.TabIndex = 20;
			this.button5.Text = "Reinstall Roblox";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new EventHandler(this.button5_Click);
			this.button7.BackColor = Color.FromArgb(60, 60, 60);
			this.button7.Cursor = Cursors.Hand;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button7.ForeColor = SystemColors.Control;
			this.button7.Location = new Point(10, 195);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(231, 30);
			this.button7.TabIndex = 21;
			this.button7.Text = "Script Obfuscator (Ironbrew)";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new EventHandler(this.button7_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(50, 50, 50);
			base.ClientSize = new System.Drawing.Size(248, 310);
			base.Controls.Add(this.button7);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.CloseButton);
			base.Controls.Add(this.TitleDraggable);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Form2";
			this.Text = "Form2";
			base.Load += new EventHandler(this.Form2_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern bool ReleaseCapture();

		[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		private void TitleDraggable_Click(object sender, EventArgs e)
		{
		}

		private void TitleDraggable_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				Form2.ReleaseCapture();
				Form2.SendMessage(base.Handle, 161, 2, 0);
			}
		}
	}
}