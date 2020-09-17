using System;
using System.Diagnostics;
using System.IO;
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


            // If directory does not exist, don't even try   
            if (Directory.Exists("Applications"))
            {

            }
            else
            {
                Directory.CreateDirectory("Applications");
            }
            if (Directory.Exists("autoexec"))
            {

            }
            else
            {
                Directory.CreateDirectory("autoexec");
            }
            if (Directory.Exists("Plugins"))
            {
                System.IO.DirectoryInfo di = new DirectoryInfo("Plugins");

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
                Directory.Delete("Plugins");
            }

            if (Directory.Exists("Scripts"))
            {

            }
            else
            {
                Directory.CreateDirectory("Scripts");
                string fileName = "Scripts\\!Readmeh.txt";
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes("-- Paste your text files in the Scripts folder! The text files should include the script.\n");
                    fs.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes("-- Just saying...");
                    fs.Write(author, 0, author.Length);
                }

                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }


            }
            if (File.Exists("Scripts\\!Readmeh.txt"))
            {

            }
            else
            {
                Directory.CreateDirectory("Scripts");
                string fileName = "Scripts\\!Readmeh.txt";
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes("-- Paste your text files in the Scripts folder! The text files should include the script.\n");
                    fs.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes("-- Just saying...");
                    fs.Write(author, 0, author.Length);
                }

                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }


            WebClient webClient2 = new WebClient();
            byte[] bytes = webClient2.DownloadData("https://pastebin.com/raw/QpwkAJS4");
            string we = Encoding.UTF8.GetString(bytes);
            string a2 = "Project MainDab V.6.8";
            try
            {
                if (we == a2)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new IconUI());
                }
                else
                {
                    if (File.Exists("Startup.txt"))
                    {
                        File.Delete("Startup.txt");
                    }
                    string fileName = "Startup.txt";
                    using (FileStream fs = File.Create(fileName))
                    {
                        // Add some text to file    
                        Byte[] title = new UTF8Encoding(true).GetBytes("[* Starting MainDab]\n[* Checking ifisuptodate]\n[! ifisuptodate return false, download update]\n");
                        fs.Write(title, 0, title.Length);
                        byte[] author = new UTF8Encoding(true).GetBytes("Startup failed, update found");
                        fs.Write(author, 0, author.Length);
                    }
                    webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDab%20Updater.exe?raw=true", "update.exe");
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    Process.Start("update.exe");
                    Environment.Exit(0);
                }
            }
            catch
            {
                if (File.Exists("Startup.txt"))
                {
                    File.Delete("Startup.txt");
                }
                string fileName = "Startup.txt";
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes("[* Starting MainDab]\n[* Checking ifisuptodate]\n[! ifisuptodate error no connection, open ui and prompt]\n[* Connecting to Github]\n[* Updating script hub]\n[* Script hub done, close stream]\n[* Check for missing folder]\n[* All done]\n");
                    fs.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes("Startup complete");
                    fs.Write(author, 0, author.Length);
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new IconUI());
                MessageBox.Show("There seems to be an error starting getting an update, please contact me at Main_EX#3898 on discord (or tell me in MainDab discord server.\n\nThe UI anyways opened up, feel free to use MainDab.", "Another error");
            }


        }
    }
}

