namespace ProjectMainDab
{
	// Token: 0x02000008 RID: 8
	public partial class Hub1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000089 RID: 137 RVA: 0x0000B364 File Offset: 0x00009564
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000B39C File Offset: 0x0000959C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.fileSystemWatcher1 = new global::System.IO.FileSystemWatcher();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new global::System.Windows.Forms.RichTextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.bindingSource1 = new global::System.Windows.Forms.BindingSource(this.components);
			this.button2 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.fileSystemWatcher1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource1).BeginInit();
			base.SuspendLayout();
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			this.listBox1.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.listBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listBox1.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.listBox1.ForeColor = global::System.Drawing.SystemColors.Window;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 24;
			this.listBox1.Location = new global::System.Drawing.Point(3, 3);
			this.listBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(213, 408);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new global::System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.richTextBox1.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.ForeColor = global::System.Drawing.SystemColors.Window;
			this.richTextBox1.Location = new global::System.Drawing.Point(218, 2);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(326, 86);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "Description of script here...";
			this.richTextBox1.TextChanged += new global::System.EventHandler(this.richTextBox1_TextChanged);
			this.richTextBox2.Location = new global::System.Drawing.Point(150, 474);
			this.richTextBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new global::System.Drawing.Size(13, 13);
			this.richTextBox2.TabIndex = 2;
			this.richTextBox2.Text = "";
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new global::System.Drawing.Point(220, 353);
			this.button1.Name = "button1";
			this.button1.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.button1.Size = new global::System.Drawing.Size(158, 54);
			this.button1.TabIndex = 6;
			this.button1.Text = "Execute (EasyExploits)";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.pictureBox1.Location = new global::System.Drawing.Point(218, 97);
			this.pictureBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(326, 248);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new global::System.Drawing.Point(386, 353);
			this.button2.Name = "button2";
			this.button2.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.button2.Size = new global::System.Drawing.Size(158, 54);
			this.button2.TabIndex = 7;
			this.button2.Text = "Execute (MainDabAPI)";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			base.ClientSize = new global::System.Drawing.Size(548, 422);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.richTextBox2);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.listBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "Hub1";
			this.Text = "Script Hub";
			base.Load += new global::System.EventHandler(this.Hub1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.fileSystemWatcher1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400009A RID: 154
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400009B RID: 155
		private global::System.IO.FileSystemWatcher fileSystemWatcher1;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.BindingSource bindingSource1;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.RichTextBox richTextBox2;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.Button button2;
	}
}
