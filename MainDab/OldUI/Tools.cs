using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace ProjectMainDab
{
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (File.Exists("ultrasurf.exe"))
            {
                Process.Start("Applications\\ultrasurf.exe");
            }
            else
            {
                MessageBox.Show("Downloading VPN. Click OK to continue.");
                WebClient sex = new WebClient();
                sex.DownloadFile("https://ultrasurf.us/download/ultrasurf.exe", "Applications\\ultrasurf.exe");
                Process.Start("Applications\\ultrasurf.exe");
                MessageBox.Show("VPN downloaded and started!");
            }
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            if (File.Exists("fpsunlocker.exe"))
            {
                Process.Start("Applications\\fpsunlocker.exe");
            }
            else
            {
                MessageBox.Show("Downloading VPN. Click OK to continue.");
                WebClient sex = new WebClient();
                sex.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/fpsunlocker.exe?raw=true", "Applications\\fpsunlocker.exe");
                Process.Start("Applications\\fpsunlocker.exe");
                MessageBox.Show("FPS unlocker downloaded and started!");
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (File.Exists("multirblx.exe"))
            {
                Process.Start("Applications\\multirblx.exe");
            }
            else
            {
                MessageBox.Show("Downloading VPN. Click OK to continue.");
                WebClient sex = new WebClient();
                sex.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/multirblx.exe?raw=true", "Applications\\multirblx.exe");
                Process.Start("Applications\\multirblx.exe");
                MessageBox.Show("Multiple Roblox downloaded and started!");
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://hakie.net/FollowerBot/follow.php");
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Process.Start("https://obfuscator.aztupscripts.xyz/Home");
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

            TaintCheck Form = new TaintCheck();
            Form.Show();
        }

        private void X_Click(object sender, EventArgs e)
        {
            base.Hide();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (File.Exists("AltAccountGenerator.exe"))
            {
                Process.Start("Applications\\AltAccountGenerator.exe");
            }
            else
            {
                MessageBox.Show("Downloading AltAccountGenerator. Click OK to continue.");
                WebClient sex = new WebClient();
                sex.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/AltAccountGenerator.exe?raw=true", "Applications\\AltAccountGenerator.exe");
                Process.Start("Applications\\AltAccountGenerator.exe");
                MessageBox.Show("AltAccountGenerator downloaded and started!");
            }
        }
    }
}
