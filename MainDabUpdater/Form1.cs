﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace MainDabUpdater
{
    public partial class Form1 : Form
    {
        // Drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public Form1()
        {
            InitializeComponent(); 
            backgroundWorker1.RunWorkerAsync();
        }
        string thing = "";
        string oi = "";

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Update starting
            thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Starting Update");
            try
            {
                foreach (Process proc in Process.GetProcessesByName("MainDab"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Thread.Sleep(1000);
            WebClient webClient = new WebClient();

            thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Deleting MainDab");
            string path = "MainDab.exe";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
           
            // Deleting stuff no longer needed
            if (File.Exists("MetroFramework.dll"))
            {
                thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Deleting MetroFramework");
                File.Delete("MetroFramework.dll");
            }
            if (File.Exists("SirHurtAPI.dll"))
            {
                thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Deleting SirhurtAPI");
                File.Delete("SirHurtAPI.dll");
            }
            if (File.Exists("Axon.dll"))
            {
                File.Delete("Axon.dll");
            }
            if (File.Exists("VisualStudioTabControl.dll"))
            {
                thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Deleting VisualStudioTabControl.dll");
                File.Delete("VisualStudioTabControl.dll");
            }



            // API Stuff
            thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Downloading new CheatSquad API");
            if (File.Exists("CheatSquadAPI.dll"))
            {
                File.Delete("CheatSquadAPI.dll");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/CheatSquadAPI.dll?raw=true", "CheatSquadAPI.dll");
            }
            if (!File.Exists("CheatSquadAPI.dll"))
            {
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/CheatSquadAPI.dll?raw=true", "CheatSquadAPI.dll");
            }
            thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Downloading new EasyExploits API");
            if (File.Exists("EasyExploits.dll"))
            {
                File.Delete("EasyExploits.dll");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/EasyExploits.dll?raw=true", "EasyExploits.dll");
            }

            if (!File.Exists("EasyExploits.dll"))
            {
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/EasyExploits.dll?raw=true", "EasyExploits.dll");
            }
            if (File.Exists("ShadowCheats.dll"))
            {
                File.Delete("ShadowCheats.dll");
                thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Updating ShadowCheats API");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/ShadowCheats.dll?raw=true", "ShadowCheats.dll");
            }
            if (!File.Exists("ShadowCheats.dll"))
            {
                thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Downloading ShadowCheats API");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/ShadowCheats.dll?raw=true", "ShadowCheats.dll");
            }
            if (File.Exists("WeAreDevs_API.cpp.dll"))
            {
                File.Delete("WeAreDevs_API.cpp.dll");
                thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Updating WeAreDevs_API.cpp.dll");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/WeAreDevs_API.cpp.dll?raw=true", "WeAreDevs_API.cpp.dll");
            }
            if (!File.Exists("WeAreDevs_API.cpp.dll"))
            {
                thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Downloading WeAreDevs_API.cpp.dll");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/WeAreDevs_API.cpp.dll?raw=true", "WeAreDevs_API.cpp.dll");
            }

            // Downloading extra dependencies
           
            if (!File.Exists("MoonSharp.Interpreter.dll"))
            {
                thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Downloading MoonShaprer Interpreter");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/MoonSharp.Interpreter.dll?raw=true", "MoonSharp.Interpreter.dll");
            }
            if (!File.Exists("ICSharpCode.AvalonEdit.dll"))
            {
                thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Downloading AvalonEdit");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/ICSharpCode.AvalonEdit.dll?raw=true", "ICSharpCode.AvalonEdit.dll");
            }


            // Downloading new MainDab
            ServicePointManager.ServerCertificateValidationCallback = ((object a, X509Certificate b, X509Chain c, SslPolicyErrors d) => true);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Downloading new version of MainDab");
            webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDab.exe?raw=true", "MainDab.exe");
            thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " MainDab Downloaded");

            // Timer thingy
            thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Starting MainDab in 5s");
            Thread.Sleep(1000);
            thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Starting MainDab in 4s");
            Thread.Sleep(1000);
            thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Starting MainDab in 3s");
            Thread.Sleep(1000);
            thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Starting MainDab in 2s");
            Thread.Sleep(1000);
            thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Starting MainDab in 1s");
            Thread.Sleep(1000);
            thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Starting MainDab in 0s");
            Thread.Sleep(500);

            // Start MainDab
            Process.Start("MainDab.exe");
            Environment.Exit(0);
        }
        private void timer1_Tick(object sender, EventArgs e) { if (thing == oi){}else{richTextBox1.AppendText("\n" + thing);thing = oi;}}
        private void richTextBox1_TextChanged(object sender, EventArgs e){}
    }
}