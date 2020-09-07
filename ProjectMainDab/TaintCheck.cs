using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjectMainDab
{
	public class TaintCheck : Form
	{
		private IContainer components = null;

		private Label label1;

		private Label label2;

		private RichTextBox richTextBox1;

		private Label label3;

		private Label label4;

		private Label label5;

		private BunifuDragControl bunifuDragControl2;

		public TaintCheck()
		{
			this.InitializeComponent();
			int num = 0;
			foreach (string str in Directory.EnumerateFiles(string.Concat(Environment.GetEnvironmentVariable("LocalAppData"), "\\Roblox\\Logs\\archive"), "*.ini"))
			{
				string str1 = File.ReadAllText(str);
				if (str1.Contains("IsTainted=true"))
				{
					num++;
					if ((!str1.Contains("TaintingModuleDirectory=") ? false : str1.Contains("TaintingModule=")))
					{
						string str2 = str1.Substring(str1.IndexOf("TaintingModule=") + "TaintingModule=".Length);
						str2 = str2.Substring(0, str2.IndexOf("\n"));
						string str3 = str1.Substring(str1.IndexOf("TaintingModuleDirectory=") + "TaintingModuleDirectory=".Length);
						str3 = string.Concat(str3.Substring(0, str3.IndexOf("\n")), "\\", str2);
						RichTextBox richTextBox = this.richTextBox1;
						string[] text = new string[] { richTextBox.Text, null, null, null, null };
						DateTime lastWriteTime = File.GetLastWriteTime(str);
						text[1] = lastWriteTime.ToString();
						text[2] = ": ";
						text[3] = str3;
						text[4] = "\n";
						richTextBox.Text = string.Concat(text);
					}
				}
			}
			this.label3.Text = string.Concat("Number Of Detections: ", num.ToString());
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new Label();
			this.label2 = new Label();
			this.richTextBox1 = new RichTextBox();
			this.label3 = new Label();
			this.label4 = new Label();
			this.label5 = new Label();
			this.bunifuDragControl2 = new BunifuDragControl(this.components);
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.FromArgb(40, 40, 40);
			this.label1.Font = new System.Drawing.Font("Calibri", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.ForeColor = SystemColors.ButtonFace;
			this.label1.Location = new Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(887, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Roblox Taint / Detected exploit Checker                                                                                                                                                 ";
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = SystemColors.ButtonHighlight;
			this.label2.Location = new Point(1, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(281, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Checks for detected exploits though Roblox's logs!";
			this.richTextBox1.BackColor = Color.FromArgb(30, 30, 30);
			this.richTextBox1.BorderStyle = BorderStyle.None;
			this.richTextBox1.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.richTextBox1.ForeColor = SystemColors.Window;
			this.richTextBox1.Location = new Point(4, 60);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(497, 152);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new EventHandler(this.richTextBox1_TextChanged);
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = SystemColors.ButtonHighlight;
			this.label3.Location = new Point(1, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Number of detections : ";
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = SystemColors.ButtonHighlight;
			this.label4.Location = new Point(1, 215);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(332, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Spot MainDab in the logs? Tell MainEX, and he will fix it up.";
			this.label5.AutoSize = true;
			this.label5.BackColor = Color.FromArgb(40, 40, 40);
			this.label5.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label5.ForeColor = Color.FromArgb(192, 0, 0);
			this.label5.Location = new Point(481, 2);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 18);
			this.label5.TabIndex = 5;
			this.label5.Text = "X";
			this.label5.Click += new EventHandler(this.label5_Click);
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.label1;
			this.bunifuDragControl2.Vertical = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.ClientSize = new System.Drawing.Size(497, 233);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "TaintCheck";
			this.Text = "TaintCheck";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void label5_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}
	}
}