using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectMainDab
{
	public class MainDab : Form
	{
		private IContainer components = null;

		private Panel panel1;

		private Panel panel2;

		private Panel panel3;

		private Label label1;

		private ListBox listBox1;

		private WebBrowser webBrowser1;

		private Label label2;

		public MainDab()
		{
			this.InitializeComponent();
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
			this.panel1 = new Panel();
			this.panel2 = new Panel();
			this.panel3 = new Panel();
			this.label1 = new Label();
			this.listBox1 = new ListBox();
			this.webBrowser1 = new WebBrowser();
			this.label2 = new Label();
			this.panel3.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = Color.FromArgb(40, 40, 40);
			this.panel1.Location = new Point(2, 51);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(80, 369);
			this.panel1.TabIndex = 0;
			this.panel2.BackColor = Color.FromArgb(4, 132, 210);
			this.panel2.Location = new Point(2, 415);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(897, 43);
			this.panel2.TabIndex = 1;
			this.panel3.BackColor = Color.FromArgb(30, 30, 30);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new Point(2, 3);
			this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(897, 46);
			this.panel3.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.FromArgb(30, 30, 30);
			this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 13f);
			this.label1.ForeColor = SystemColors.ButtonHighlight;
			this.label1.Location = new Point(349, 6);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 36);
			this.label1.TabIndex = 2;
			this.label1.Text = "MainDab";
			this.listBox1.BackColor = Color.FromArgb(40, 40, 40);
			this.listBox1.BorderStyle = BorderStyle.None;
			this.listBox1.ForeColor = SystemColors.ScrollBar;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new Point(727, 55);
			this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(172, 360);
			this.listBox1.TabIndex = 2;
			this.webBrowser1.Location = new Point(82, 55);
			this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(30, 31);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(644, 360);
			this.webBrowser1.TabIndex = 3;
			this.label2.AutoSize = true;
			this.label2.ForeColor = SystemColors.Control;
			this.label2.Location = new Point(459, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "but it's VS Code";
			this.label2.Click += new EventHandler(this.label2_Click);
			base.AutoScaleDimensions = new SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(20, 20, 20);
			base.ClientSize = new System.Drawing.Size(897, 449);
			base.Controls.Add(this.webBrowser1);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "MainDab";
			this.Text = "MainDab";
			base.Load += new EventHandler(this.MainDab_Load);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			base.ResumeLayout(false);
		}

		private void label2_Click(object sender, EventArgs e)
		{
		}

		private void MainDab_Load(object sender, EventArgs e)
		{
		}
	}
}