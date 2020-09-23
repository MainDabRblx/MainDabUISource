using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace ProjectMainDab
{
	// Token: 0x02000016 RID: 22
	public partial class TaintCheck : Form
	{
		// Token: 0x06000190 RID: 400 RVA: 0x0001AAE0 File Offset: 0x00018CE0
		public TaintCheck()
		{
			this.InitializeComponent();
			int num = 0;
			foreach (string path in Directory.EnumerateFiles(Environment.GetEnvironmentVariable("LocalAppData") + "\\Roblox\\Logs\\archive", "*.ini"))
			{
				string text = File.ReadAllText(path);
				bool flag = text.Contains("IsTainted=true");
				if (flag)
				{
					num++;
					bool flag2 = text.Contains("TaintingModuleDirectory=") && text.Contains("TaintingModule=");
					if (flag2)
					{
						string text2 = text.Substring(text.IndexOf("TaintingModule=") + "TaintingModule=".Length);
						text2 = text2.Substring(0, text2.IndexOf("\n"));
						string text3 = text.Substring(text.IndexOf("TaintingModuleDirectory=") + "TaintingModuleDirectory=".Length);
						text3 = text3.Substring(0, text3.IndexOf("\n")) + "\\" + text2;
						RichTextBox richTextBox = this.richTextBox1;
						richTextBox.Text = string.Concat(new string[]
						{
							richTextBox.Text,
							File.GetLastWriteTime(path).ToString(),
							": ",
							text3,
							"\n"
						});
					}
				}
			}
			this.label3.Text = "Number Of Detections: " + num.ToString();
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000028EF File Offset: 0x00000AEF
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000BA3C File Offset: 0x00009C3C
		private void label5_Click(object sender, EventArgs e)
		{
			base.Hide();
		}
	}
}
