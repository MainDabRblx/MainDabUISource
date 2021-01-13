using System;
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
            Console.WriteLine("UPDATER : Downloading EasyExploits API...");
            if (File.Exists("EasyExploits.dll"))
            {
                File.Delete("EasyExploits.dll");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/EasyExploits.dll?raw=true", "EasyExploits.dll");
            }

            if (!File.Exists("EasyExploits.dll"))
            {
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/EasyExploits.dll?raw=true", "EasyExploits.dll");
            }

          
            if (!File.Exists("MetroFramework.dll"))
            {
                thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Downloading MetroFramework");
                webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MetroFramework.dll?raw=true", "MetroFramework.dll");
            }

            if (!File.Exists("ICSharpCode.AvalonEdit.dll"))
            {
                thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Downloading AvalonEdit");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/ICSharpCode.AvalonEdit.dll?raw=true", "ICSharpCode.AvalonEdit.dll");
            
            }
            if (!File.Exists("CheatSquadAPI.dll"))
            {
                thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Downloading CheatSquad API");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/CheatSquadAPI.dll?raw=true", "CheatSquadAPI.dll");
            }


            thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Downloading MoonShaprer Interpreter");
            if (!File.Exists("MoonSharp.Interpreter.dll"))
            {
                File.Delete("MoonSharp.Interpreter.dll");
                webClient.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/MoonSharp.Interpreter.dll?raw=true", "MoonSharp.Interpreter.dll");
            }

            ServicePointManager.ServerCertificateValidationCallback = ((object a, X509Certificate b, X509Chain c, SslPolicyErrors d) => true);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Downloading new version of MainDab");
            webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDab.exe?raw=true", "MainDab.exe");
            thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " MainDab Downloaded");
            thing = ("[" + DateTime.Now.ToString("h:mm:ss tt") + "]" + " Starting MainDab in 5s");
            WebClient webClient4 = new WebClient();
            byte[] bytes = webClient4.DownloadData("https://pastebin.com/raw/6pVUMAGi");
            string @string = Encoding.UTF8.GetString(bytes);
            Console.WriteLine("\n" + @string + "\n");
            Console.WriteLine("\n oh fuck black magic 2");
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
            Process.Start("MainDab.exe");
            Environment.Exit(0);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (thing == oi)
            {

            }
            else
            {
                richTextBox1.AppendText("\n" + thing);
                thing = oi;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
