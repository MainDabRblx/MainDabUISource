using Microsoft.Win32;
using ProjectMainDab.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProjectMainDab
{
	public class Form3 : Form
	{
		private const int SW_HIDE = 0;

		private const int SW_SHOW = 5;

		public const int WM_NCLBUTTONDOWN = 161;

		public const int HT_CAPTION = 2;

		private IContainer components = null;

		private Label TitleDraggable;

		private Label CloseButton;

		private Button button4;

		private Button button1;

		private Button button2;

		private Button button3;

		private BackgroundWorker backgroundWorker1;

		private PictureBox pictureBox1;

		private BindingSource bindingSource1;

		public Form3()
		{
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Region = System.Drawing.Region.FromHrgn(Form3.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
			Console.WriteLine("Project MainDab Launcher loaded.");
			Thread.Sleep(1000);
			IntPtr consoleWindow = Form3.GetConsoleWindow();
			this.InitializeComponent();
			Form3.ShowWindow(consoleWindow, 0);
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.DialogResult dialogResult = MessageBox.Show("Do you want to use the Older UI from now on?", "Hmmm", MessageBoxButtons.YesNo);
			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.DialogResult dialogResult1 = MessageBox.Show("Are you really sure you want to? You can't change this later on.", "LOL REALLY?", MessageBoxButtons.YesNo);
				if (dialogResult1 == System.Windows.Forms.DialogResult.Yes)
				{
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\OurSettings1");
					registryKey.SetValue("Setting2", "yes");
					registryKey.Close();
					(new Form4()).Show();
					base.Hide();
				}
				else if (dialogResult1 == System.Windows.Forms.DialogResult.No)
				{
				}
			}
			else if (dialogResult == System.Windows.Forms.DialogResult.No)
			{
				(new Form4()).Show();
				base.Hide();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Reinstalling Roblox", "ProjectMainDab", MessageBoxButtons.OK);
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

		private void button2_Click_1(object sender, EventArgs e)
		{
			(new Form5()).Show();
			base.Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			byte[] numArray = (new WebClient()).DownloadData("https://pastebin.com/raw/QpwkAJS4");
			string str = Encoding.UTF8.GetString(numArray);
			MessageBox.Show("Redownloaing exploit");
			(new WebClient()).DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDab.zip?raw=true", string.Concat(str, ".zip"));
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			(new SynapseX___mainj1()).Show();
			base.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
		}

		private void button5_Click(object sender, EventArgs e)
		{
			(new Form8()).Show();
			base.Hide();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
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

		private void Form3_Load(object sender, EventArgs e)
		{
			using (dWebHook _dWebHook = new dWebHook())
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\OurSettings");
				if (registryKey == null)
				{
					MessageBox.Show("Error reading from User Data. User NOT FOUND. Click OK to create an account.");
					(new Form6()).Show();
					base.Hide();
				}
				else
				{
					string str = registryKey.GetValue("Setting1").ToString();
					_dWebHook.ProfilePicture = "https://www.kindpng.com/picc/m/287-2874533_discord-server-icon-logo-discord-png-transparent-png.png";
					_dWebHook.UserName = "User opened up MainDab";
					_dWebHook.WebHook = "https://discordapp.com/api/webhooks/692356553138765914/e6U3hmqWbgrrXix036OIcU_Fm5QHAd7HtA8i-4qGhiJv8YMPhwbL7HSaXb6J37Jnuc34";
					_dWebHook.SendMessage(string.Concat("```User ", str, " has opened up Project MainDab!```"));
				}
			}
			base.Show();
			this.backgroundWorker1.RunWorkerAsync();
		}

		[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern IntPtr GetConsoleWindow();

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.TitleDraggable = new Label();
			this.CloseButton = new Label();
			this.button4 = new Button();
			this.button1 = new Button();
			this.button2 = new Button();
			this.button3 = new Button();
			this.backgroundWorker1 = new BackgroundWorker();
			this.pictureBox1 = new PictureBox();
			this.bindingSource1 = new BindingSource(this.components);
			((ISupportInitialize)this.pictureBox1).BeginInit();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			base.SuspendLayout();
			this.TitleDraggable.BackColor = Color.FromArgb(60, 60, 60);
			this.TitleDraggable.Font = new System.Drawing.Font("Calibri", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.TitleDraggable.ForeColor = SystemColors.ButtonHighlight;
			this.TitleDraggable.Location = new Point(-3, -3);
			this.TitleDraggable.Name = "TitleDraggable";
			this.TitleDraggable.Size = new System.Drawing.Size(435, 35);
			this.TitleDraggable.TabIndex = 2;
			this.TitleDraggable.Text = "Launcher";
			this.TitleDraggable.Click += new EventHandler(this.TitleDraggable_Click);
			this.TitleDraggable.MouseDown += new MouseEventHandler(this.TitleDraggable_MouseDown);
			this.CloseButton.AutoSize = true;
			this.CloseButton.BackColor = Color.FromArgb(60, 60, 60);
			this.CloseButton.Font = new System.Drawing.Font("Calibri", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.CloseButton.ForeColor = Color.Red;
			this.CloseButton.Location = new Point(220, 1);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(20, 23);
			this.CloseButton.TabIndex = 3;
			this.CloseButton.Text = "X";
			this.CloseButton.Click += new EventHandler(this.CloseButton_Click);
			this.button4.BackColor = Color.FromArgb(60, 60, 60);
			this.button4.Cursor = Cursors.Hand;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button4.ForeColor = SystemColors.Control;
			this.button4.Location = new Point(3, 36);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(231, 30);
			this.button4.TabIndex = 15;
			this.button4.Text = "Default UI (click here to continue)";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new EventHandler(this.button4_Click);
			this.button1.BackColor = Color.FromArgb(60, 60, 60);
			this.button1.Cursor = Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button1.ForeColor = SystemColors.Control;
			this.button1.Location = new Point(3, 72);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(231, 30);
			this.button1.TabIndex = 16;
			this.button1.Text = "Old UI";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.button2.BackColor = Color.FromArgb(60, 60, 60);
			this.button2.Cursor = Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button2.ForeColor = SystemColors.Control;
			this.button2.Location = new Point(3, 109);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(231, 30);
			this.button2.TabIndex = 19;
			this.button2.Text = "Classic UI";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new EventHandler(this.button2_Click_1);
			this.button3.BackColor = Color.FromArgb(60, 60, 60);
			this.button3.Cursor = Cursors.Hand;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button3.ForeColor = SystemColors.Control;
			this.button3.Location = new Point(3, 145);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(231, 30);
			this.button3.TabIndex = 20;
			this.button3.Text = "Synapse X theme";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new EventHandler(this.button3_Click_1);
			this.backgroundWorker1.DoWork += new DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.pictureBox1.BackColor = Color.FromArgb(60, 60, 60);
			this.pictureBox1.Image = Resources.discord_icon;
			this.pictureBox1.Location = new Point(114, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(31, 32);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 23;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(50, 50, 50);
			base.ClientSize = new System.Drawing.Size(240, 187);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.CloseButton);
			base.Controls.Add(this.TitleDraggable);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			base.Name = "Form3";
			this.Text = "Form3";
			base.Load += new EventHandler(this.Form3_Load);
			((ISupportInitialize)this.pictureBox1).EndInit();
			((ISupportInitialize)this.bindingSource1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/rvKA5g7");
		}

		[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		public static extern bool ReleaseCapture();

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

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
				Form3.ReleaseCapture();
				Form3.SendMessage(base.Handle, 161, 2, 0);
			}
		}
	}
}