namespace ProjectMainDab
{
	// Token: 0x02000016 RID: 22
	public partial class TaintCheck : global::System.Windows.Forms.Form
	{
		// Token: 0x06000193 RID: 403 RVA: 0x0001AC90 File Offset: 0x00018E90
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0001ACC8 File Offset: 0x00018EC8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.label1.Font = new global::System.Drawing.Font("Calibri", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new global::System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(887, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Roblox Taint / Detected exploit Checker                                                                                                                                                 ";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Calibri", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new global::System.Drawing.Point(1, 25);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(281, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Checks for detected exploits though Roblox's logs!";
			this.richTextBox1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Font = new global::System.Drawing.Font("Calibri", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBox1.ForeColor = global::System.Drawing.SystemColors.Window;
			this.richTextBox1.Location = new global::System.Drawing.Point(4, 60);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(497, 152);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new global::System.EventHandler(this.richTextBox1_TextChanged);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Calibri", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new global::System.Drawing.Point(1, 42);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(132, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Number of detections : ";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Calibri", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new global::System.Drawing.Point(1, 215);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(332, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Spot MainDab in the logs? Tell MainEX, and he will fix it up.";
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.label5.Font = new global::System.Drawing.Font("Calibri", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.label5.Location = new global::System.Drawing.Point(481, 2);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(16, 18);
			this.label5.TabIndex = 5;
			this.label5.Text = "X";
			this.label5.Click += new global::System.EventHandler(this.label5_Click);
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.label1;
			this.bunifuDragControl2.Vertical = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			base.ClientSize = new global::System.Drawing.Size(497, 233);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "TaintCheck";
			this.Text = "TaintCheck";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000194 RID: 404
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000195 RID: 405
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000196 RID: 406
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000197 RID: 407
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000198 RID: 408
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000199 RID: 409
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400019A RID: 410
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400019B RID: 411
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
	}
}
