using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjectMainDab
{
	public class Form5 : Form
	{
		private IContainer components = null;

		private RichTextBox richTextBox1;

		private Button button1;

		private Button button2;

		private Button button3;

		private Button button4;

		private RichTextBox richTextBox2;

		private OpenFileDialog openFileDialog1;

		private Button button5;

		public Form5()
		{
			this.InitializeComponent();
			this.richTextBox2.ReadOnly = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			NamedPipes.LuaPipe(this.richTextBox1.Text);
			RichTextBox richTextBox = this.richTextBox2;
			richTextBox.Text = string.Concat(richTextBox.Text, "\r\nSending script");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Functions.Inject();
			RichTextBox richTextBox = this.richTextBox2;
			richTextBox.Text = string.Concat(richTextBox.Text, "\r\nInjecting DLL");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (Functions.openfiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				try
				{
					string str = File.ReadAllText(Functions.openfiledialog.FileName);
					this.richTextBox1.Text = str;
					RichTextBox richTextBox = this.richTextBox2;
					richTextBox.Text = string.Concat(richTextBox.Text, "\r\nFile opened.");
				}
				catch (Exception exception1)
				{
					Exception exception = exception1;
					MessageBox.Show(string.Concat("Error: Could not read file from disk. Original error: ", exception.Message));
					Console.WriteLine("File can't be opened for some reason");
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.richTextBox1.Text = "";
			RichTextBox richTextBox = this.richTextBox2;
			richTextBox.Text = string.Concat(richTextBox.Text, "\r\nTextbox cleared.");
		}

		private void button5_Click(object sender, EventArgs e)
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

		private void InitializeComponent()
		{
			this.richTextBox1 = new RichTextBox();
			this.button1 = new Button();
			this.button2 = new Button();
			this.button3 = new Button();
			this.button4 = new Button();
			this.richTextBox2 = new RichTextBox();
			this.openFileDialog1 = new OpenFileDialog();
			this.button5 = new Button();
			base.SuspendLayout();
			this.richTextBox1.Font = new System.Drawing.Font("Consolas", 8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.richTextBox1.Location = new Point(7, 8);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(480, 187);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "-- Script goes here";
			this.richTextBox1.TextChanged += new EventHandler(this.richTextBox1_TextChanged);
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button1.Location = new Point(7, 198);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 44);
			this.button1.TabIndex = 1;
			this.button1.Text = "Execute";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button2.Location = new Point(147, 198);
			this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(136, 44);
			this.button2.TabIndex = 2;
			this.button2.Text = "Inject";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new EventHandler(this.button2_Click);
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button3.Location = new Point(7, 246);
			this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(136, 44);
			this.button3.TabIndex = 3;
			this.button3.Text = "Open file";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new EventHandler(this.button3_Click);
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button4.Location = new Point(147, 246);
			this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(136, 44);
			this.button4.TabIndex = 4;
			this.button4.Text = "Clear textbox";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new EventHandler(this.button4_Click);
			this.richTextBox2.Font = new System.Drawing.Font("Consolas", 7f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.richTextBox2.Location = new Point(290, 200);
			this.richTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(197, 138);
			this.richTextBox2.TabIndex = 5;
			this.richTextBox2.Text = "Events go here";
			this.openFileDialog1.FileName = "openFileDialog1";
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button5.Location = new Point(7, 294);
			this.button5.Margin = new System.Windows.Forms.Padding(2);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(276, 44);
			this.button5.TabIndex = 6;
			this.button5.Text = "Go back to Main UI";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new EventHandler(this.button5_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(493, 340);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.richTextBox2);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.richTextBox1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			base.Name = "Form5";
			this.Text = "Project MainDab (Old school theme)";
			base.Load += new EventHandler(this.Project_MainDab_Load);
			base.ResumeLayout(false);
		}

		private void Project_MainDab_Load(object sender, EventArgs e)
		{
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}
	}
}