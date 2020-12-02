
using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Windows;
using CheatSquadAPI;
using SirHurtAPI;
using System.Windows.Controls;
using System.Windows.Input;
using DiscordRPC;
using System.Windows.Media;
using System.Xml;
using System.ComponentModel;
using System.Net;
using System.Diagnostics;
using System.Threading;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using MainDabWPF.Injection;
using System.Net.Http.Headers;
using System.Linq;
using System.Windows.Media.Imaging;
using System.IO.Compression;
using System.Reflection;
using DiscordRPC.Logging;
using System.Windows.Interop;

namespace MainDab
{

    public partial class MainWindow : Window
    {
        WebClient HITLER = new WebClient(); // HEIL HITLER!
        private readonly DiscordRpcClient client;
        private readonly CheatSquadAPI.Module shitsquad = new CheatSquadAPI.Module(); // CheatSquad API
        string currentdll = "Selected API : CheatSquad";
        private readonly BackgroundWorker worker = new BackgroundWorker();

        public MainWindow()
        {
            var webClient = new WebClient();
            client = new DiscordRpcClient("714648958265327737")
            {
                Logger = new ConsoleLogger
                {
                    Level = LogLevel.Warning
                }
            };
            client.OnReady += delegate { };
            client.OnPresenceUpdate += delegate { };
            
            client.Initialize();
            // this.panel6.Visible = false;
            client.SetPresence(new RichPresence
            {
                Details = "Using MainDab V9",
                State = "MainDab Roblox Exploit | discord.io/maindab",

                Timestamps = new Timestamps
                {
                    Start = DateTime.UtcNow,
                  
                },

                Assets = new Assets
                {
                    LargeImageKey = "image_large",
                    LargeImageText = "MainDab Roblox Exploit",
                    
                    SmallImageKey = "image_small"
                }

            });



            // Update system now on main ui.
            if (File.Exists("update.exe"))
            {
                File.Delete("update.exe");
            }

            WebClient webClient2 = new WebClient();
            byte[] bytes = webClient2.DownloadData("https://pastebin.com/raw/QpwkAJS4");
            string we = Encoding.UTF8.GetString(bytes);
            string currentver = "MainDab V.9.2";
            byte[] succ = webClient2.DownloadData("https://pastebin.com/raw/TeKDGrbg");
            string discord = Encoding.UTF8.GetString(succ);
            Process.Start(discord);
            if (we == currentver)
            {

                if (!Directory.Exists("autoexec"))
                {
                    Console.WriteLine("Creating autoexec folder...");
                    Directory.CreateDirectory("autoexec");
                }
                if (!Directory.Exists("workspace"))
                {
                    Console.WriteLine("Creating workspace folder...");
                    Directory.CreateDirectory("workspace");
                }



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
            }
            else
            {
                webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDab%20Updater.exe?raw=true", "update.exe");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                Process.Start("update.exe");
                Environment.Exit(0);
            }
                if (File.Exists("lua.xshd"))
                {
                    File.Delete("lua.xshd");
                    string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/lua.xshd");
                    File.WriteAllText("lua.xshd", penis); // just in case need new update
                }

                if (!File.Exists("lua.xshd")) // onv
                {
                    string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/lua.xshd");
                    File.WriteAllText("lua.xshd", penis);
                }
                // pp penis big!

            
           
        }


        public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Folder);
            FileInfo[] files = directoryInfo.GetFiles(FileType);
            foreach (FileInfo fileInfo in files)
            {
                lsb.Items.Add(fileInfo.Name);
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();

        }

        private void Viewer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string script = File.ReadAllText(string.Format("./Scripts/{0}", this.fuckbm2.SelectedItem));
            textEditor.Text = script;
        }


        public static T FindVisualChild<T>(DependencyObject parent) where T : DependencyObject // omg so complicated!1111111
        {
            int i = 0;
            while (i < VisualTreeHelper.GetChildrenCount(parent))
            {
                DependencyObject child = VisualTreeHelper.GetChild(parent, i);
                bool flag = child != null && child is T;
                T result;
                if (flag)
                {
                    result = (T)((object)child);
                }
                else
                {
                    T t = FindVisualChild<T>(child);
                    bool flag2 = t != null;
                    if (!flag2)
                    {
                        i++;
                        continue;
                    }
                    result = t;
                }
                return result;
            }
            return default(T);
        }


        public static OpenFileDialog openfiledialog = new OpenFileDialog 
        {
            Filter = "Text Files and Lua Files (*.txt *.lua)|*.txt;*.lua|All files (*.*)|*.*",
            FilterIndex = 1,
            RestoreDirectory = true,
            Title = "Open Document"
        };

        private void textEditor_Loaded(object sender, RoutedEventArgs e)
        {
            Stream input = File.OpenRead("lua.xshd");
            XmlTextReader xmlTextReader = new XmlTextReader(input);
            textEditor.SyntaxHighlighting = HighlightingLoader.Load(xmlTextReader, HighlightingManager.Instance);
            // Change directory to avoid useless directories :/

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

                    }
                }
            }
            if (num > 0)
            {
                MessageBox.Show("You have been tainted by Roblox! This means that your roblox crash logs were uploaded to Roblox, and you are most likely up for a ban. Click on extensions and download the taint log checker to see more details.", "WARNING");
            }

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (currentdll == "Selected API : Sirhurt API")
            {
                SirHurtAPI.SirHurtAPI.Execute(textEditor.Text, true);
            }
            if (currentdll == "Selected API : CheatSquad")
            {
                shitsquad.Execute(textEditor.Text);
            }
            if (currentdll == "Selected API : MainDabAPI")
            {
                try
                {
                    NamedPipes.LuaPipe(textEditor.Text);
                }
                catch (Exception sexual)
                {
                    MessageBox.Show("An error has occured, here is the error :\n\n" + sexual + "\n\nMake sure you are on a tab, and not on the script hub tab!", "Report this to Main_EX in Discord!");
                }
            }
            if (currentdll == "Selected API : Custom")
            {
                try
                {
                    NamedPipes.LuaPipe(textEditor.Text);
                }
                catch (Exception sexual)
                {
                    MessageBox.Show("An error has occured, here is the error :\n\n" + sexual + "\n\nMake sure you are on a tab, and not on the script hub tab!", "Report this to Main_EX in Discord!");
                }

            }
        }

        private void Viewer_Loaded(object sender, RoutedEventArgs e)
        {
            
            PopulateListBox(this.fuckbm2, "Scripts", "*.txt");
            PopulateListBox(this.fuckbm2, "Scripts", "*.lua");
            /*
            new Thread(() =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    Status.Content = "Updating MainDab.dll...";
                });
                if (File.Exists("MainDab.dll")) File.Delete("MainDab.dll");
                var url1 = "https://github.com/leonardssy/ProjectDab/blob/master/MainDab.dll?raw=true";
                var filename1 = "MainDab.dll";
                using (var wc = new WebClient())
                {
                    wc.DownloadFile(url1, filename1);
                }
                this.Dispatcher.Invoke(() =>
                {
                    Status.Content = " ";
                });
            }).Start();*/
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            base.Hide();
            Environment.Exit(0);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;

        }

        private void Close_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void Nigger_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }


        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (currentdll == "Selected API : Sirhurt API")
            {
                SirHurtAPI.SirHurtAPI.Execute(textEditor.Text, true);
            }
            if (currentdll == "Selected API : CheatSquad")
            {
                shitsquad.Execute(textEditor.Text);
            }
            if (currentdll == "Selected API : MainDabAPI")
            {
                try
                {
                    NamedPipes.LuaPipe(textEditor.Text);
                }
                catch (Exception sexual)
                {
                    MessageBox.Show("An error has occured, here is the error :\n\n" + sexual + "\n\nMake sure you are on a tab, and not on the script hub tab!", "Report this to Main_EX in Discord!");
                }
            }
            if (currentdll == "Selected API : Custom")
            {
                try
                {
                    NamedPipes.LuaPipe(textEditor.Text);
                }
                catch (Exception sexual)
                {
                    MessageBox.Show("An error has occured, here is the error :\n\n" + sexual + "\n\nMake sure you are on a tab, and not on the script hub tab!", "Report this to Main_EX in Discord!");
                }

            }
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            currentdll = "Selected API : MainDabAPI";
            label6.Content = "Selected API : MainDabAPI";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabData");
            key.SetValue("DLL", "Selected API : MainDabAPI");
            key.Close();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            currentdll = "Selected API : Lush API";
            label6.Content = "Selected API : Lush API";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabData");
            key.SetValue("DLL", "Selected API : Lush API");
            key.Close();

        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            custom.Visibility = Visibility.Visible;
            // if you are reading this, sex is fun
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textEditor.Text = "";
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {

            System.Windows.Forms.OpenFileDialog hailhitler = new System.Windows.Forms.OpenFileDialog()
            {
                CheckFileExists = true,
                Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (hailhitler.ShowDialog() == System.Windows.Forms.DialogResult.OK) // i hate wpf geez winforms 4 life - mainex
            {
                textEditor.Text = File.ReadAllText(hailhitler.FileName);
            }
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            if (currentdll == "Selected API : Sirhurt API")
            {
                SirHurtAPI.SirHurtAPI.LaunchExploit();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    while (!SirHurtAPI.SirHurtAPI.isInjected())
                    {
                        this.Dispatcher.Invoke(() =>
                        {
                            Status.Content = "Injecting Sirhurt API...";
                        });
                        Thread.Sleep(500);
                    }
                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "Game loading...";
                    });
                    Thread.Sleep(3000);
                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "Sirhurt API Injected!";
                    });
                    Thread.Sleep(1000);
                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "";
                    });
                }).Start();

            }
            if (currentdll == "Selected API : CheatSquad")
            {
                shitsquad.Attach();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "Injecting Cheatsquad API...";

                    });
                    Thread.Sleep(7000);
                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "Cheatsquad API Injected!";
                    });
                    Thread.Sleep(1000);
                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "";
                    });


                }).Start();


            }
            if (currentdll == "Selected API : Lush API")
            {
                Functions.Inject();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "Injecting Lush API...";

                    });
                    Thread.Sleep(6000);
                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "Lush API Injected!";
                    });
                    Thread.Sleep(1000);
                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "";
                    });
                }).Start();
            }
            if (currentdll == "Selected API : Custom")
            {
                Functions.Inject();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "Injecting Custom API...";

                    });
                    Thread.Sleep(6000);
                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "";
                    });
                }).Start();
            }
        }

        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog hailhitler = new System.Windows.Forms.OpenFileDialog()
            {
                CheckFileExists = true,
                Filter = "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (hailhitler.ShowDialog() == System.Windows.Forms.DialogResult.OK) // i hate wpf geez winforms 4 life - mainex
            {
                textEditor.Text = File.ReadAllText(hailhitler.FileName);
            }
        }

        private void dddd(object sender, RoutedEventArgs e)
        {
            currentdll = "Selected API : Cheatsquad";
            label6.Content = "Selected API : Cheatsquad";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabData");
            key.SetValue("DLL", "Selected API : CheatSquad");
            key.Close();
        }

        private void MenuItem_Click_11(object sender, RoutedEventArgs e)
        {
            var flag = Process.GetProcessesByName("RobloxPlayerBeta").Length == 0;
            if (!flag)
                try
                {
                    var processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
                    processesByName[0].Kill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void MenuItem_Click_12(object sender, RoutedEventArgs e)
        {
            textEditor.Text = "";
        }

        private void MenuItem_Click_13(object sender, RoutedEventArgs e)
        {
            if (currentdll == "Selected API : Sirhurt API")
            {
                SirHurtAPI.SirHurtAPI.LaunchExploit();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    while (!SirHurtAPI.SirHurtAPI.isInjected())
                    {
                        this.Dispatcher.Invoke(() =>
                        {
                            Status.Content = "Injecting Sirhurt API...";
                        });
                        Thread.Sleep(500);
                    }
                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "Game loading...";
                    });
                    Thread.Sleep(3000);
                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "Sirhurt API Injected!";
                    });
                    Thread.Sleep(1000);
                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "";
                    });
                }).Start();

            }
            if (currentdll == "Selected API : CheatSquad")
            {
                shitsquad.Attach();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "Injecting Cheatsquad API...";

                    });
                    Thread.Sleep(7000);
                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "Cheatsquad API Injected!";
                    });
                    Thread.Sleep(1000);
                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "";
                    });


                }).Start();


            }
            if (currentdll == "Selected API : Lush API")
            {
                Functions.Inject();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "Injecting Lush API...";

                    });
                    Thread.Sleep(6000);
                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "Lush API Injected!";
                    });
                    Thread.Sleep(1000);
                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "";
                    });
                }).Start();
            }
            if (currentdll == "Selected API : Custom")
            {
                Functions.Inject();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "Injecting Custom API...";

                    });
                    Thread.Sleep(6000);
                    this.Dispatcher.Invoke(() =>
                    {
                        Status.Content = "";
                    });
                }).Start();
            }
        }

        private void NI(object sender, RoutedEventArgs e)
        {
            if (File.Exists("fpsunlocker.exe"))
            {
                Process.Start("Applications\\fpsunlocker.exe");
            }
            else
            {
                MessageBox.Show("Downloading FPS Unlocker. Click OK to continue.");
                var sex = new WebClient();
                sex.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/fpsunlocker.exe?raw=true",
                    "Applications\\fpsunlocker.exe");
                Process.Start("Applications\\fpsunlocker.exe");
                MessageBox.Show("FPS unlocker downloaded and started!");
            }
        }

        private void MenuItem_Click_14(object sender, RoutedEventArgs e)
        {
            if (File.Exists("multirblx.exe"))
            {
                Process.Start("Applications\\multirblx.exe");
            }
            else
            {
                MessageBox.Show("Downloading VPN. Click OK to continue.");
                var sex = new WebClient();
                sex.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/multirblx.exe?raw=true",
                    "Applications\\multirblx.exe");
                Process.Start("Applications\\multirblx.exe");
                MessageBox.Show("Multiple Roblox downloaded and started!");
            }
        }

        private void MenuItem_Click_15(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Reinstalling Roblox, MainDab may freeze for a while.", "MainDab");
            try
            {
                foreach (var process in Process.GetProcessesByName("RobloxPlayerBeta")) process.Kill();
            }
            catch (Exception value)
            {
                MessageBox.Show(Convert.ToString(value), "Error");
            }

            try
            {
                Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
                var flag = Directory.Exists("Roblox");
                var flag2 = flag;
                if (flag2) Directory.Delete("Roblox", true);
            }
            catch
            {
            }

            try
            {
                Directory.SetCurrentDirectory(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
                var flag3 = Directory.Exists("Roblox");
                var flag4 = flag3;
                if (flag4) Directory.Delete("Roblox", true);
                var flag5 = File.Exists("Installer.exe");
                var flag6 = flag5;
                if (flag6) File.Delete("Installer.exe");
            }
            catch
            {
            }

            new WebClient().DownloadFile("http://setup.roblox.com/RobloxPlayerLauncher.exe", "Installer.exe");
            Process.Start("Installer.exe");
        }

        private void MenuItem_Click_16(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDab%20Updater.exe?raw=true", "update.exe");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            Process.Start("update.exe");
            Environment.Exit(0);
        }

        private void sss(object sender, RoutedEventArgs e)
        {
            ScriptHub.Visibility = Visibility.Visible;
        }

        private void ScriptHub_Loaded(object sender, RoutedEventArgs e)
        {
            ScriptHub.Visibility = Visibility.Hidden;
            var flag = File.Exists("bin.zip");
            if (flag) File.Delete("bin.zip");
            var path = "bin";
            var flag2 = Directory.Exists(path);
            if (flag2)
            {
                var path2 = "bin";
                Directory.Delete(path2, true);
            }

            var url = "https://github.com/leonardssy/ProjectDab/blob/master/scripts.zip?raw=true";
            var filename = "bin.zip";
            using (var wc = new WebClient())
            {
                wc.DownloadFile(url, filename);
            }

            var sourceArchiveFileName = "bin.zip";
            var destinationDirectoryName = "bin";
            ZipFile.ExtractToDirectory(sourceArchiveFileName, destinationDirectoryName);
            File.Delete("bin.zip");
            listbox.Items.Clear();
            try

            {
                PopulateListBox(listbox, "./bin/scripts", "*.txt");
            }
            catch
            {
                MessageBox.Show(
                    "Failed to open scripthub as it detects no scripts or folder, try close and rerun MainDab.");
                Hide();
            }
        }
        string scriptseggx = "";
        private void ListBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                new Thread(() =>
                {
                    var text = File.ReadAllText("bin\\scripts\\" + listbox.SelectedItem);
                    var flag = listbox.SelectedItem != null;
                    var flag2 = flag;
                    if (flag2)
                    {
                        var text2 = text;
                        scriptseggx = text2;

                        var text3 = text2.Split('\r', '\n').FirstOrDefault();
                        var text4 = text3.Remove(0, 2);
                        richfuckbox.AppendText(text4);
                        var text5 = text2.Split(new[]
                        {
                            '\r',
                            '\n'
                        }, StringSplitOptions.RemoveEmptyEntries)[1];
                        var text6 = text5;
                        var text7 = text6.Remove(0, 2);
                        var requestUriString = text7;
                        try
                        {
                            var webRequest = WebRequest.Create(requestUriString);
                            using (var response = webRequest.GetResponse())
                            {
                                using (var responseStream = response.GetResponseStream())
                                {

                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Failed to get image.");
                        }
                    }
                }).Start();
            }
            catch (Exception sexual)
            {
                MessageBox.Show("An error has occured, here is the error :\n\n" + sexual, "Report this to Main_EX in Discord!");
            }
        }

        private void d(object sender, MouseButtonEventArgs e)
        {
            if (currentdll == "Selected API : Sirhurt API")
            {
                SirHurtAPI.SirHurtAPI.Execute(scriptseggx, true);
            }
            if (currentdll == "Selected API : CheatSquad")
            {
                shitsquad.Execute(scriptseggx);
            }
            if (currentdll == "Selected API : MainDabAPI")
            {
                NamedPipes.LuaPipe(scriptseggx);
             }
            if (currentdll == "Selected API : Custom")
            {
                NamedPipes.LuaPipe(scriptseggx);
            }

            // Main_EX#3898 @ MainDab RBLX

        }

        private void listbox_MouseDown(object sender, MouseButtonEventArgs e)
        {

            try
            {
                new Thread(() =>
                {
                    var text = File.ReadAllText("bin\\scripts\\" + listbox.SelectedItem);
                    var flag = listbox.SelectedItem != null;
                    var flag2 = flag;
                    if (flag2)
                    {
                        var text2 = text;
                        scriptseggx = text2;

                        var text3 = text2.Split('\r', '\n').FirstOrDefault();
                        var text4 = text3.Remove(0, 2);
                        richfuckbox.AppendText(text4);
                        var text5 = text2.Split(new[]
                        {
                            '\r',
                            '\n'
                        }, StringSplitOptions.RemoveEmptyEntries)[1];
                        var text6 = text5;
                        var text7 = text6.Remove(0, 2);
                        var requestUriString = text7;
                        try
                        {
                            var webRequest = WebRequest.Create(requestUriString);
                            using (var response = webRequest.GetResponse())
                            {
                                using (var responseStream = response.GetResponseStream())
                                {



                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Failed to get image.");
                        }
                    }
                }).Start();
            }
            catch (Exception sexual)
            {
                MessageBox.Show("An error has occured, here is the error :\n\n" + sexual, "Report this to Main_EX in Discord!");
            }
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                
                    var text = File.ReadAllText("bin\\scripts\\" + listbox.SelectedItem);
                    var flag = listbox.SelectedItem != null;
                    var flag2 = flag;
                    if (flag2)
                    {
                        var text2 = text;
                    richfuckbox.Document.Blocks.Clear();
                    scriptseggx = text2;

                        var text3 = text2.Split('\r', '\n').FirstOrDefault();
                        var text4 = text3.Remove(0, 2);

                        richfuckbox.AppendText(text4);
                        var text5 = text2.Split(new[]
                        {
                            '\r',
                            '\n'
                        }, StringSplitOptions.RemoveEmptyEntries)[1];
                        var text6 = text5;
                        var text7 = text6.Remove(0, 2);
                        var requestUriString = text7;
                        try
                        {
                            var webRequest = WebRequest.Create(requestUriString);
                            using (var response = webRequest.GetResponse())
                            {
                                using (var responseStream = response.GetResponseStream())
                                {



                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Failed to get image.");
                        }
                    }
               
            }
            catch (Exception sexual)
            {
                MessageBox.Show("An error has occured, here is the error :\n\n" + sexual, "Report this to Main_EX in Discord!");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (currentdll == "Selected API : Sirhurt API")
            {
                SirHurtAPI.SirHurtAPI.Execute(scriptseggx, true);
            }
            if (currentdll == "Selected API : CheatSquad")
            {
                shitsquad.Execute(scriptseggx);
            }
            if (currentdll == "Selected API : Lush API")
            {
                NamedPipes.LuaPipe(scriptseggx);
            }
            if (currentdll == "Selected API : Custom")
            {
                NamedPipes.LuaPipe(scriptseggx);
            }
        }

        private void Button_ManipulationStarting(object sender, ManipulationStartingEventArgs e)
        {

        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ScriptHub.Visibility = Visibility.Hidden;
        }

        private void NEIn(object sender, RoutedEventArgs e)
        {
            Process.Start("https://discord.gg/e5kbU75");
        }

        private void MenuItem_Click_17(object sender, RoutedEventArgs e)
        {
            Process.Start("https://yohatipynoo.gitbook.io/maindab-documentation/");
        }

        private void Ellipse_KeyDown(object sender, KeyEventArgs e)
        {
            ScriptHub.Visibility = Visibility.Hidden;
        }

        private void sex_Loaded(object sender, RoutedEventArgs e)
        {
            this.sex.Navigate("https://seasoned-charmed-cold.glitch.me/");

            dynamic activeX = this.sex.GetType().InvokeMember("ActiveXInstance",
                BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, this.sex, new object[] { });

            activeX.Silent = true;
        }

        private void MenuItem_Click_18(object sender, RoutedEventArgs e)
        {
            var script = "loadstring(game:HttpGet(\"https://pastebin.com/raw/SsG8y3HA\", true))()";
            if (label6.Content == "Selected API : CheatSquad")
                new Thread(() => { shitsquad.Execute(script); }).Start();
          
            if (label6.Content == "Selected API : MainDabAPI")
                new Thread(() => { NamedPipes.LuaPipe(script); }).Start();
            if (label6.Content == "Selected API : Custom")
                new Thread(() => { NamedPipes.LuaPipe(script); }).Start();
            if (label6.Content == "Selected API : Sirhurt API")
                new Thread(() => { SirHurtAPI.SirHurtAPI.Execute(script, true); }).Start();
        }

        private void MenuItem_Click_19(object sender, RoutedEventArgs e)
        {
            SirHurtAPI.Scripts.OpenScriptHub();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Functions.exploitdllname = DLLNAME.Text;
            NamedPipes.luapipename = Pipe.Text;
            custom.Visibility = Visibility.Hidden;
            label6.Content = "Selected API : Custom";
            currentdll = "Selected API : Custom";
        }

        private void Ellipse_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            custom.Visibility = Visibility.Hidden;

        }

        private void label6_Loaded(object sender, RoutedEventArgs e)
        {
           
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MainDabData");
            if (key != null)
            {
                string apishouldbe = (key.GetValue("DLL").ToString());
                key.Close();
                label6.Content = apishouldbe;
                 currentdll = apishouldbe;
               
               

            }
        }

        private void MenuItem_Click_20(object sender, RoutedEventArgs e)
        {
           
        }

        private void custom_Loaded(object sender, RoutedEventArgs e)
        {
            custom.Visibility = Visibility.Hidden;
        }

        private void MenuItem_Click_21(object sender, RoutedEventArgs e)
        {
            custom.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_22(object sender, RoutedEventArgs e)
        {
            currentdll = "Selected API : Sirhurt API";
            label6.Content = "Selected API : Sirhurt API";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabData");
            key.SetValue("DLL", "Selected API : Sirhurt API");
            key.Close();
        }

        private void MenuItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void MenuItem_Click_23(object sender, RoutedEventArgs e)
        {
            WebClient webClient2 = new WebClient();
            byte[] bytes = webClient2.DownloadData("https://pastebin.com/raw/TU1EWx3w");
            string we = Encoding.UTF8.GetString(bytes);
            MessageBox.Show(we, "MainDab Credits");
        }
    }
}
