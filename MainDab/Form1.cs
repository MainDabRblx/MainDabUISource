using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
			this.label1.Text = "Number Of Detections: " + num.ToString();
		}

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
