using EasyExploits;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace ProjectMainDab
{
	public class Hub1 : Form
	{
		private Module m = new Module();

		private IContainer components = null;

		private FileSystemWatcher fileSystemWatcher1;

		private BindingSource bindingSource1;

		private ListBox listBox1;

		private PictureBox pictureBox1;

		private RichTextBox richTextBox2;

		private RichTextBox richTextBox1;

		private Button button1;

		private Button button2;

		public Hub1()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.m.ExecuteScript(this.richTextBox2.Text);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			NamedPipes.LuaPipe(this.richTextBox2.Text);
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void Hub1_Load(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			Functions.PopulateListBox1(this.listBox1, "./bin/scripts", "*.txt");
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.fileSystemWatcher1 = new FileSystemWatcher();
			this.listBox1 = new ListBox();
			this.richTextBox1 = new RichTextBox();
			this.richTextBox2 = new RichTextBox();
			this.button1 = new Button();
			this.pictureBox1 = new PictureBox();
			this.bindingSource1 = new BindingSource(this.components);
			this.button2 = new Button();
			((ISupportInitialize)this.fileSystemWatcher1).BeginInit();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			((ISupportInitialize)this.bindingSource1).BeginInit();
			base.SuspendLayout();
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			this.listBox1.BackColor = Color.FromArgb(40, 40, 40);
			this.listBox1.BorderStyle = BorderStyle.None;
			this.listBox1.Font = new System.Drawing.Font("Calibri", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.listBox1.ForeColor = SystemColors.Window;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 24;
			this.listBox1.Location = new Point(3, 3);
			this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(213, 408);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
			this.richTextBox1.BackColor = Color.FromArgb(40, 40, 40);
			this.richTextBox1.BorderStyle = BorderStyle.None;
			this.richTextBox1.ForeColor = SystemColors.Window;
			this.richTextBox1.Location = new Point(218, 2);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(326, 86);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "Description of script here...";
			this.richTextBox1.TextChanged += new EventHandler(this.richTextBox1_TextChanged);
			this.richTextBox2.Location = new Point(150, 474);
			this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(13, 13);
			this.richTextBox2.TabIndex = 2;
			this.richTextBox2.Text = "";
			this.button1.BackColor = Color.FromArgb(40, 40, 40);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.ForeColor = SystemColors.ButtonHighlight;
			this.button1.Location = new Point(220, 353);
			this.button1.Name = "button1";
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button1.Size = new System.Drawing.Size(158, 54);
			this.button1.TabIndex = 6;
			this.button1.Text = "Execute (EasyExploits)";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.pictureBox1.Location = new Point(218, 97);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(326, 248);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.button2.BackColor = Color.FromArgb(40, 40, 40);
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.ForeColor = SystemColors.ButtonHighlight;
			this.button2.Location = new Point(386, 353);
			this.button2.Name = "button2";
			this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button2.Size = new System.Drawing.Size(158, 54);
			this.button2.TabIndex = 7;
			this.button2.Text = "Execute (MainDabAPI)";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new EventHandler(this.button2_Click);
			base.AutoScaleDimensions = new SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(30, 30, 30);
			base.ClientSize = new System.Drawing.Size(548, 422);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.richTextBox2);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.listBox1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "Hub1";
			this.Text = "Script Hub";
			base.Load += new EventHandler(this.Hub1_Load);
			((ISupportInitialize)this.fileSystemWatcher1).EndInit();
			((ISupportInitialize)this.pictureBox1).EndInit();
			((ISupportInitialize)this.bindingSource1).EndInit();
			base.ResumeLayout(false);
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
						this.pictureBox1.Image = Image.FromStream(responseStream);
					}
				}
			}
		}

		private void metroButton13_Click(object sender, EventArgs e)
		{
			this.m.ExecuteScript("loadstring(game:HttpGet(('https://pastebin.com/raw/qUPwqTyr'),true))()");
		}

		private void pictureBox14_Click(object sender, EventArgs e)
		{
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}
	}
}