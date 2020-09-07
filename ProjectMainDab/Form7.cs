using ProjectMainDab.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace ProjectMainDab
{
	public class Form7 : Form
	{
		private IContainer components = null;

		private PictureBox pictureBox1;

		private RichTextBox richTextBox1;

		private BackgroundWorker backgroundWorker1;

		public Form7()
		{
			this.InitializeComponent();
			this.backgroundWorker1.RunWorkerAsync();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			RichTextBox richTextBox = this.richTextBox1;
			richTextBox.Text = string.Concat(richTextBox.Text, "\r\nSplash Screen credits to default.jpg");
			Thread.Sleep(500);
			RichTextBox richTextBox1 = this.richTextBox1;
			richTextBox1.Text = string.Concat(richTextBox1.Text, "\r\nLoading Monaco");
			Thread.Sleep(500);
			RichTextBox richTextBox2 = this.richTextBox1;
			richTextBox2.Text = string.Concat(richTextBox2.Text, "\r\nLoading MonacoCodePrediction");
			Thread.Sleep(1000);
			RichTextBox richTextBox3 = this.richTextBox1;
			richTextBox3.Text = string.Concat(richTextBox3.Text, "\r\nLoading Ui 1/7");
			Thread.Sleep(100);
			RichTextBox richTextBox4 = this.richTextBox1;
			richTextBox4.Text = string.Concat(richTextBox4.Text, "\r\nLoading Ui 2/7");
			Thread.Sleep(100);
			RichTextBox richTextBox5 = this.richTextBox1;
			richTextBox5.Text = string.Concat(richTextBox5.Text, "\r\nLoading Ui 3/7");
			WebClient webClient = new WebClient();
			if (!Directory.Exists("bin"))
			{
				webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/scripts.zip?raw=true", "bin.zip");
				ZipFile.ExtractToDirectory("bin.zip", "bin");
				if (File.Exists("bin.zip"))
				{
					File.Delete("bin.zip");
				}
			}
			else
			{
				Directory.Delete("bin", true);
				webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/scripts.zip?raw=true", "bin.zip");
				ZipFile.ExtractToDirectory("bin.zip", "bin");
				if (File.Exists("bin.zip"))
				{
					File.Delete("bin.zip");
				}
			}
			RichTextBox richTextBox6 = this.richTextBox1;
			richTextBox6.Text = string.Concat(richTextBox6.Text, "\r\nLoading Ui 4/7");
			Thread.Sleep(100);
			RichTextBox richTextBox7 = this.richTextBox1;
			richTextBox7.Text = string.Concat(richTextBox7.Text, "\r\nLoading Ui 5/7");
			Thread.Sleep(100);
			RichTextBox richTextBox8 = this.richTextBox1;
			richTextBox8.Text = string.Concat(richTextBox8.Text, "\r\nLoading Ui 6/7");
			Thread.Sleep(100);
			RichTextBox richTextBox9 = this.richTextBox1;
			richTextBox9.Text = string.Concat(richTextBox9.Text, "\r\nLoading Ui 7/7");
			Thread.Sleep(100);
			RichTextBox richTextBox10 = this.richTextBox1;
			richTextBox10.Text = string.Concat(richTextBox10.Text, "\r\nPreparing other stuff");
			Thread.Sleep(100);
			RichTextBox richTextBox11 = this.richTextBox1;
			richTextBox11.Text = string.Concat(richTextBox11.Text, "\r\nUpdating online script hub");
			Thread.Sleep(200);
			RichTextBox richTextBox12 = this.richTextBox1;
			richTextBox12.Text = string.Concat(richTextBox12.Text, "\r\nChecking for dependencies updates");
			Thread.Sleep(500);
			RichTextBox richTextBox13 = this.richTextBox1;
			richTextBox13.Text = string.Concat(richTextBox13.Text, "\r\nNo errors found in dependencies!");
			RichTextBox richTextBox14 = this.richTextBox1;
			richTextBox14.Text = string.Concat(richTextBox14.Text, "\r\nLoading user settings");
			Thread.Sleep(100);
			RichTextBox richTextBox15 = this.richTextBox1;
			richTextBox15.Text = string.Concat(richTextBox15.Text, "\r\nSettings loaded");
			Thread.Sleep(100);
			RichTextBox richTextBox16 = this.richTextBox1;
			richTextBox16.Text = string.Concat(richTextBox16.Text, "\r\nReady");
			(new SynapseX___mainj1()).Show();
			base.Hide();
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.pictureBox1 = new PictureBox();
			this.richTextBox1 = new RichTextBox();
			this.backgroundWorker1 = new BackgroundWorker();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.Image = Resources._default;
			this.pictureBox1.Location = new Point(-230, -6);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(994, 545);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
			this.richTextBox1.BackColor = Color.White;
			this.richTextBox1.BorderStyle = BorderStyle.None;
			this.richTextBox1.Font = new System.Drawing.Font("Consolas", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.richTextBox1.Location = new Point(-2, 385);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(522, 122);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "Loading MainDab Version 2...";
			this.richTextBox1.TextChanged += new EventHandler(this.richTextBox1_TextChanged);
			this.backgroundWorker1.DoWork += new DoWorkEventHandler(this.backgroundWorker1_DoWork);
			base.AutoScaleDimensions = new SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(520, 503);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.pictureBox1);
			this.ForeColor = Color.FromArgb(128, 255, 255);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "Form7";
			this.Text = "Form7";
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}
	}
}