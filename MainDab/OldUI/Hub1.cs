using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace ProjectMainDab
{
    // Token: 0x02000008 RID: 8
    public partial class Hub1 : Form
    {
        // Token: 0x06000081 RID: 129 RVA: 0x0000B19E File Offset: 0x0000939E
        public Hub1()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000082 RID: 130 RVA: 0x0000B1C1 File Offset: 0x000093C1
        private void Hub1_Load(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            try

            {
                Functions.PopulateListBox1(this.listBox1, "./bin/scripts", "*.txt");
            }
            catch
            {
                MessageBox.Show("Failed to open scripthub as it detects no scripts or folder, try close and rerun MainDab.");
                this.Hide();
            }
        }

        // Token: 0x06000083 RID: 131 RVA: 0x000028EF File Offset: 0x00000AEF

        // Token: 0x06000085 RID: 133 RVA: 0x0000B210 File Offset: 0x00009410
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = File.ReadAllText("bin\\scripts\\" + this.listBox1.SelectedItem.ToString());
            bool flag = this.listBox1.SelectedItem != null;
            bool flag2 = flag;
            if (flag2)
            {
                string text2 = text;
                this.richTextBox2.Text = text2;
                string text3 = text2.Split(new char[]
                {
                    '\r',
                    '\n'
                }).FirstOrDefault<string>();
                string text4 = text3.Remove(0, 2);
                this.richTextBox1.Text = text4;
                string text5 = text2.Split(new char[]
                {
                    '\r',
                    '\n'
                }, StringSplitOptions.RemoveEmptyEntries)[1];
                string text6 = text5;
                string text7 = text6.Remove(0, 2);
                string requestUriString = text7;
                WebRequest webRequest = WebRequest.Create(requestUriString);
                using (WebResponse response = webRequest.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        this.pictureBox1.Image = Image.FromStream(responseStream);
                    }
                }
            }
        }

        // Token: 0x06000086 RID: 134 RVA: 0x0000B334 File Offset: 0x00009534
        private void button1_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x06000087 RID: 135 RVA: 0x000028EF File Offset: 0x00000AEF
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x06000088 RID: 136 RVA: 0x0000B34E File Offset: 0x0000954E
        private void button2_Click(object sender, EventArgs e)
        {
            NamedPipes.LuaPipe(this.richTextBox2.Text);
        }
    }
}