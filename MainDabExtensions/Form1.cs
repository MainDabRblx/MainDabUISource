using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics; 

namespace MainDabExtensions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WebClient webClient = new WebClient();

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("[EXTENSION] taintlogs.exe"))
            {
                Process.Start("[EXTENSION] taintlogs.exe");
            }
            else
            { 
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/EXTENSION/TaintLogs.exe?raw=true", "[EXTENSION] taintlogs.exe");
                Process.Start("[EXTENSION] taintlogs.exe");
            }
        }
    }
}
