using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectMainDab
{
	public class Form6 : Form
	{
		private IContainer components = null;

		private TextBox textBox1;

		private Label TitleDraggable;

		private Label label1;

		private Button button3;

		private Label label2;

		private Label label3;

		private TextBox textBox2;

		public Form6()
		{
			this.InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (this.textBox1.Text.Contains("main_ex"))
			{
				MessageBox.Show("DONT YOU DARE TRY FUCKING IMPERSONATE ME BITCH", "Main_EX says no");
			}
			else if (this.textBox1.Text == "")
			{
				MessageBox.Show("Please type in a username");
			}
			else if (this.textBox1.Text != " ")
			{
				string text = this.textBox1.Text;
				string str = this.textBox2.Text;
				using (dWebHook _dWebHook = new dWebHook())
				{
					RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\OurSettings");
					registryKey.SetValue("Setting1", text);
					registryKey.Close();
					_dWebHook.ProfilePicture = "https://www.kindpng.com/picc/m/287-2874533_discord-server-icon-logo-discord-png-transparent-png.png";
					_dWebHook.UserName = "Sign up bot";
					_dWebHook.WebHook = "https://discordapp.com/api/webhooks/692356553138765914/e6U3hmqWbgrrXix036OIcU_Fm5QHAd7HtA8i-4qGhiJv8YMPhwbL7HSaXb6J37Jnuc34";
					_dWebHook.SendMessage(string.Concat(new string[] { "```A new user signed up! YAY!\nUsername : ", text, "\nDiscord Username :", str, "```" }));
					(new Form3()).Show();
					base.Hide();
				}
			}
			else
			{
				MessageBox.Show("Please type in a proper username");
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

		private void Form6_Load(object sender, EventArgs e)
		{
		}

		private void InitializeComponent()
		{
			this.textBox1 = new TextBox();
			this.TitleDraggable = new Label();
			this.label1 = new Label();
			this.button3 = new Button();
			this.label2 = new Label();
			this.label3 = new Label();
			this.textBox2 = new TextBox();
			base.SuspendLayout();
			this.textBox1.Location = new Point(10, 146);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(416, 26);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
			this.TitleDraggable.BackColor = Color.FromArgb(50, 50, 50);
			this.TitleDraggable.Font = new System.Drawing.Font("Calibri", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.TitleDraggable.ForeColor = SystemColors.ButtonHighlight;
			this.TitleDraggable.Location = new Point(1, 2);
			this.TitleDraggable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TitleDraggable.Name = "TitleDraggable";
			this.TitleDraggable.Size = new System.Drawing.Size(1168, 54);
			this.TitleDraggable.TabIndex = 1;
			this.TitleDraggable.Text = "       Project MainDab";
			this.TitleDraggable.Click += new EventHandler(this.TitleDraggable_Click);
			this.label1.AutoSize = true;
			this.label1.ForeColor = SystemColors.ButtonHighlight;
			this.label1.Location = new Point(13, 74);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(428, 60);
			this.label1.TabIndex = 17;
			this.label1.Text = "Welcome! You are probrably here because you want to use \r\nProject MainDab! In order to use it, please type in a \r\nusername. Choose wisely, as you cannot change it later.\r\n";
			this.button3.BackColor = Color.FromArgb(60, 60, 60);
			this.button3.Cursor = Cursors.Hand;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Calibri", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button3.ForeColor = SystemColors.Control;
			this.button3.Location = new Point(10, 244);
			this.button3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(416, 58);
			this.button3.TabIndex = 43;
			this.button3.Text = "Continue to Project MainDab";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new EventHandler(this.button3_Click);
			this.label2.AutoSize = true;
			this.label2.ForeColor = SystemColors.ButtonHighlight;
			this.label2.Location = new Point(54, 310);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(330, 40);
			this.label2.TabIndex = 44;
			this.label2.Text = "           Note : This is a one time thing!\r\nAnswering improperly may get you blacklisted!";
			this.label3.AutoSize = true;
			this.label3.ForeColor = SystemColors.ButtonHighlight;
			this.label3.Location = new Point(18, 183);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(395, 20);
			this.label3.TabIndex = 45;
			this.label3.Text = "Please type in your Discord username with the # below.";
			this.textBox2.Location = new Point(10, 207);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(416, 26);
			this.textBox2.TabIndex = 46;
			base.AutoScaleDimensions = new SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(30, 30, 30);
			base.ClientSize = new System.Drawing.Size(440, 360);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.TitleDraggable);
			base.Controls.Add(this.textBox1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Name = "Form6";
			this.Text = "Choose a username...";
			base.Load += new EventHandler(this.Form6_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void TitleDraggable_Click(object sender, EventArgs e)
		{
		}
	}
}