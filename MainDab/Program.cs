using System;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ProjectMainDab
{
    // Token: 0x02000014 RID: 20
    internal static class Program
    {


        // Token: 0x0600015F RID: 351 RVA: 0x000188A4 File Offset: 0x00016AA4
        [STAThread]

        private static void Main()
        {
            WebClient webClient = new WebClient();



            WebClient webClient2 = new WebClient();
            byte[] bytes = webClient2.DownloadData("https://pastebin.com/raw/QpwkAJS4");
            string we = Encoding.UTF8.GetString(bytes);
            string a2 = "Project MainDab V.6.1";
            if (we == a2)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new IconUI());
            }
            else
            {
                MessageBox.Show("MainDab Update found! Click OK to update.");
                webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDab%20Updater.exe?raw=true", "update.exe");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                MessageBox.Show("Updater finished downloading, Click OK to continue.");
                Process.Start("update.exe");
                Environment.Exit(0);
            }


        }
    }
}

