using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ProjectMainDab
{
	public class Form8 : Form
	{
		private WebClient webClient = new WebClient();

		private IContainer components = null;

		private Button button5;

		private Label label1;

		private Button button1;

		private Label label2;

		private Button button2;

		private FlowLayoutPanel flowLayoutPanel1;

		private Button button3;

		private Button button4;

		private Button button6;

		private Button button7;

		private Button button8;

		private Button button9;

		private Button button10;

		private Button button11;

		public Form8()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!File.Exists("MainDabChiSimp.exe"))
			{
				this.webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDabChiSimp.exe?raw=true", "MainDabChiSimp.exe");
				Process.Start("MainDabChiSimp.exe");
				Environment.Exit(0);
			}
			else
			{
				MessageBox.Show("MainDabChiSimp.exe");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!File.Exists("MainDabChi.exe"))
			{
				this.webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDabChi.exe?raw=true", "MainDabChi.exe");
				Process.Start("MainDabChi.exe");
				Environment.Exit(0);
			}
			else
			{
				MessageBox.Show("MainDabChi.exe");
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (!File.Exists("MainDabCMD.exe"))
			{
				this.webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDabCMD.exe?raw=true", "MainDabCMD.exe");
				Process.Start("MainDabCMD.exe");
				Environment.Exit(0);
			}
			else
			{
				MessageBox.Show("MainDabCMD is already downloaded!");
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

		private void Form8_Load(object sender, EventArgs e)
		{
		}

		private void InitializeComponent()
		{
			this.button5 = new Button();
			this.label1 = new Label();
			this.button1 = new Button();
			this.label2 = new Label();
			this.button2 = new Button();
			this.flowLayoutPanel1 = new FlowLayoutPanel();
			this.button3 = new Button();
			this.button4 = new Button();
			this.button6 = new Button();
			this.button7 = new Button();
			this.button8 = new Button();
			this.button9 = new Button();
			this.button10 = new Button();
			this.button11 = new Button();
			this.flowLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.button5.BackColor = Color.FromArgb(60, 60, 60);
			this.button5.Cursor = Cursors.Hand;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button5.ForeColor = SystemColors.Control;
			this.button5.Location = new Point(15, 338);
			this.button5.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(266, 58);
			this.button5.TabIndex = 45;
			this.button5.Text = "MainDab CMD version";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new EventHandler(this.button5_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new Point(12, 310);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 20);
			this.label1.TabIndex = 46;
			this.label1.Text = "MISC Modules";
			this.label1.Click += new EventHandler(this.label1_Click);
			this.button1.BackColor = Color.FromArgb(60, 60, 60);
			this.button1.Cursor = Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button1.ForeColor = SystemColors.Control;
			this.button1.Location = new Point(6, 8);
			this.button1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(267, 58);
			this.button1.TabIndex = 47;
			this.button1.Text = "Simplified Chinese";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 20);
			this.label2.TabIndex = 48;
			this.label2.Text = "Language Modules";
			this.button2.BackColor = Color.FromArgb(60, 60, 60);
			this.button2.Cursor = Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button2.ForeColor = SystemColors.Control;
			this.button2.Location = new Point(285, 8);
			this.button2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(267, 58);
			this.button2.TabIndex = 50;
			this.button2.Text = "Traditional Chinese";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.BackColor = Color.FromArgb(40, 40, 40);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.button2);
			this.flowLayoutPanel1.Controls.Add(this.button3);
			this.flowLayoutPanel1.Controls.Add(this.button4);
			this.flowLayoutPanel1.Controls.Add(this.button6);
			this.flowLayoutPanel1.Controls.Add(this.button7);
			this.flowLayoutPanel1.Controls.Add(this.button8);
			this.flowLayoutPanel1.Controls.Add(this.button9);
			this.flowLayoutPanel1.Controls.Add(this.button10);
			this.flowLayoutPanel1.Controls.Add(this.button11);
			this.flowLayoutPanel1.Location = new Point(1, 32);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(598, 275);
			this.flowLayoutPanel1.TabIndex = 51;
			this.button3.BackColor = Color.FromArgb(60, 60, 60);
			this.button3.Cursor = Cursors.Hand;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button3.ForeColor = SystemColors.Control;
			this.button3.Location = new Point(6, 82);
			this.button3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(267, 58);
			this.button3.TabIndex = 51;
			this.button3.Text = "Coming Soon";
			this.button3.UseVisualStyleBackColor = false;
			this.button4.BackColor = Color.FromArgb(60, 60, 60);
			this.button4.Cursor = Cursors.Hand;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button4.ForeColor = SystemColors.Control;
			this.button4.Location = new Point(285, 82);
			this.button4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(267, 58);
			this.button4.TabIndex = 52;
			this.button4.Text = "Coming Soon";
			this.button4.UseVisualStyleBackColor = false;
			this.button6.BackColor = Color.FromArgb(60, 60, 60);
			this.button6.Cursor = Cursors.Hand;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button6.ForeColor = SystemColors.Control;
			this.button6.Location = new Point(6, 156);
			this.button6.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(267, 58);
			this.button6.TabIndex = 53;
			this.button6.Text = "Coming Soon";
			this.button6.UseVisualStyleBackColor = false;
			this.button7.BackColor = Color.FromArgb(60, 60, 60);
			this.button7.Cursor = Cursors.Hand;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button7.ForeColor = SystemColors.Control;
			this.button7.Location = new Point(285, 156);
			this.button7.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(267, 58);
			this.button7.TabIndex = 54;
			this.button7.Text = "Coming Soon";
			this.button7.UseVisualStyleBackColor = false;
			this.button8.BackColor = Color.FromArgb(60, 60, 60);
			this.button8.Cursor = Cursors.Hand;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button8.ForeColor = SystemColors.Control;
			this.button8.Location = new Point(6, 230);
			this.button8.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(267, 58);
			this.button8.TabIndex = 55;
			this.button8.Text = "Coming Soon";
			this.button8.UseVisualStyleBackColor = false;
			this.button9.BackColor = Color.FromArgb(60, 60, 60);
			this.button9.Cursor = Cursors.Hand;
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatStyle = FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button9.ForeColor = SystemColors.Control;
			this.button9.Location = new Point(285, 230);
			this.button9.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(267, 58);
			this.button9.TabIndex = 56;
			this.button9.Text = "Coming Soon";
			this.button9.UseVisualStyleBackColor = false;
			this.button10.BackColor = Color.FromArgb(60, 60, 60);
			this.button10.Cursor = Cursors.Hand;
			this.button10.FlatAppearance.BorderSize = 0;
			this.button10.FlatStyle = FlatStyle.Flat;
			this.button10.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button10.ForeColor = SystemColors.Control;
			this.button10.Location = new Point(6, 304);
			this.button10.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(267, 58);
			this.button10.TabIndex = 57;
			this.button10.Text = "Coming Soon";
			this.button10.UseVisualStyleBackColor = false;
			this.button11.BackColor = Color.FromArgb(60, 60, 60);
			this.button11.Cursor = Cursors.Hand;
			this.button11.FlatAppearance.BorderSize = 0;
			this.button11.FlatStyle = FlatStyle.Flat;
			this.button11.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button11.ForeColor = SystemColors.Control;
			this.button11.Location = new Point(285, 304);
			this.button11.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(267, 58);
			this.button11.TabIndex = 58;
			this.button11.Text = "Coming Soon";
			this.button11.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(40, 40, 40);
			base.ClientSize = new System.Drawing.Size(601, 403);
			base.Controls.Add(this.flowLayoutPanel1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button5);
			this.ForeColor = SystemColors.Control;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Name = "Form8";
			this.Text = "Downloadable Modules";
			base.Load += new EventHandler(this.Form8_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}
	}
}