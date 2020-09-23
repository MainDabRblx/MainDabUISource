using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheatSquadAPI;

namespace ProjectMainDab
{
    public partial class SynapseSex : Form
    {
        private SEX shitsquad = new SEX(); // CheatSquad API
        public SynapseSex()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://x.synapse.to");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/synapse");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            shitsquad.Attach();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");
            Process.Start("https://v3rmillion.net");

        }

        private void button1_Click(object sender, EventArgs e)
        {
             shitsquad.Execute(richTextBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }
    }
}
