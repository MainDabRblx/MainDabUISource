/*
  __  __       _       _____        _       _____       _     _             ______            _       _ _   
 |  \/  |     (_)     |  __ \      | |     |  __ \     | |   | |           |  ____|          | |     (_) |  
 | \  / | __ _ _ _ __ | |  | | __ _| |__   | |__) |___ | |__ | | _____  __ | |__  __  ___ __ | | ___  _| |_ 
 | |\/| |/ _` | | '_ \| |  | |/ _` | '_ \  |  _  // _ \| '_ \| |/ _ \ \/ / |  __| \ \/ / '_ \| |/ _ \| | __|
 | |  | | (_| | | | | | |__| | (_| | |_) | | | \ \ (_) | |_) | | (_) >  <  | |____ >  <| |_) | | (_) | | |_ 
 |_|  |_|\__,_|_|_| |_|_____/ \__,_|_.__/  |_|  \_\___/|_.__/|_|\___/_/\_\ |______/_/\_\ .__/|_|\___/|_|\__|
                                                                                       | |                  
                                                                                       |_|                  
 MainDab 2021, by Main_EX#3898 at discord.io/maindab
 Contact via discord (Main_EX#7720, My Discord ID is 766314130880593932, if that doesn't work join discord.io/maindab)
 Contact via email - maindabex@gmail.com or yohatipynoo@gmail.com
 I don't use other communication platforms, other Main_EX's you see are not affliated with me.
 My Discord ID is 766314130880593932
 Feel free to look around and take some parts of the code.
 oh and I'm also sorry for the profane words :3
 */
using MoonSharp.Interpreter;
using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Web;
using CheatSquadAPI;
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
using System.Linq;
using System.IO.Compression;
using System.Reflection;
using DiscordRPC.Logging;
using ShadowCheats;
using System.Runtime.InteropServices;

namespace MainDab
{
    public partial class MainWindow : Window
    {
        string currentver = "MainDab V.10.9";
        WebClient HITLER = new WebClient(); // HEIL HITLER!
        private DiscordRpcClient client;
        private readonly CheatSquadAPI.Module shitsquad = new CheatSquadAPI.Module(); // CheatSquad API
        private readonly EasyExploits.Module ezclap = new EasyExploits.Module(); // EasyExploits API
        private readonly ShadowCheats.Module sexcheats = new ShadowCheats.Module();  // ShadowCheats API
        string currentdll = "Selected API : EasyExploits";
        private readonly BackgroundWorker worker = new BackgroundWorker();
        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool LaunchExploit(); // WRD Inject
        [DllImport("WeAreDevs_API.cpp.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool SendLimitedLuaScript(string script); // WRD Execute

        public MainWindow()
        { 
                
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
            // pp penis big 
       


        }

        #region Functions
        public static void Joshualikesexuwuwuwwowowowowowow(ListBox lsb, string Folder, string FileType)
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

        public static OpenFileDialog openfiledialog = new OpenFileDialog 
        {
            Filter = "Text Files and Lua Files (*.txt *.lua)|*.txt;*.lua|All files (*.*)|*.*",
            FilterIndex = 1,
            RestoreDirectory = true,
            Title = "Open Document"
        };
        #endregion
        // New functions, making changing code slightly easier
        private void Injection()
        {
           
            if (currentdll == "Selected API : CheatSquad")
            {
                shitsquad.Attach();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    this.Dispatcher.Invoke(() =>
                    {
                        TopBar.Content = "MainDab | Injecting Cheatsquad API...";

                    });
                    Thread.Sleep(7000);
                    this.Dispatcher.Invoke(() =>
                    {
                        TopBar.Content = "MainDab | Cheatsquad API Injected!";
                    });
                    Thread.Sleep(1000);
                    this.Dispatcher.Invoke(() =>
                    {
                        TopBar.Content = "MainDab";
                    });


                }).Start();


            }
            if (currentdll == "Selected API : EasyExploits API")
            {
                ezclap.LaunchExploit();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    this.Dispatcher.Invoke(() =>
                    {
                        TopBar.Content = "MainDab | Injecting EasyExploits API...";

                    });
                    Thread.Sleep(6000);
                    this.Dispatcher.Invoke(() =>
                    {
                        TopBar.Content = "MainDab | EasyExploits API Injected!";
                    });
                    Thread.Sleep(1000);
                    this.Dispatcher.Invoke(() =>
                    {
                        TopBar.Content = "MainDab";
                    });
                }).Start();
            }

            if (currentdll == "Selected API : ShadowCheats")
            {
                sexcheats.Attach();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    this.Dispatcher.Invoke(() =>
                    {
                        TopBar.Content = "MainDab | Injecting ShadowCheats API...";

                    });
                    Thread.Sleep(8000);
                    this.Dispatcher.Invoke(() =>
                    {
                        TopBar.Content = "MainDab | ShadowCheats API Injected!";
                    });
                    Thread.Sleep(1000);
                    this.Dispatcher.Invoke(() =>
                    {
                        TopBar.Content = "MainDab";
                    });
                }).Start();
            }

            if (currentdll == "Selected API : WeAreDevs")
            {
                
                new Thread(() =>
                {
                    LaunchExploit();
                    Thread.CurrentThread.IsBackground = true;

                    this.Dispatcher.Invoke(() =>
                    {
                        TopBar.Content = "MainDab | Injecting WeAreDevs API...";

                    });
                    Thread.Sleep(3000);
                    this.Dispatcher.Invoke(() =>
                    {
                        TopBar.Content = "MainDab | WeAreDevs API Injected!";
                    });
                    Thread.Sleep(1000);
                    this.Dispatcher.Invoke(() =>
                    {
                        TopBar.Content = "MainDab";
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
                       // Status.Content = "Injecting Custom API...";

                    });
                    Thread.Sleep(6000);
                    this.Dispatcher.Invoke(() =>
                    {
                        //Status.Content = "";
                    });
                }).Start();
            }
        } // Inject
        private void Execute()
        {
            
            if (currentdll == "Selected API : CheatSquad")
            {
                shitsquad.Execute(textEditor.Text);
            }

            if (currentdll == "Selected API : EasyExploits API")
            {
                try
                {
                    ezclap.ExecuteScript(textEditor.Text);
                }
                catch (Exception sexual)
                {
                    MessageBox.Show("An error has occured, here is the error :\n\n" + sexual + "\n\nMake sure you are on a tab, and not on the script hub tab!", "Report this to Main_EX in Discord!");
                }
            }
            if (currentdll == "Selected API : ShadowCheats")
            {
               sexcheats.ExecuteScript(textEditor.Text);
            }
            if (currentdll == "Selected API : WeAreDevs")
            {
                SendLimitedLuaScript(textEditor.Text);
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
        } // Execute
        private void textEditor_Loaded(object sender, RoutedEventArgs e)
        {

            WebClient webClient = new WebClient();
            byte[] succ1 = webClient.DownloadData("https://pastebin.com/raw/QpwkAJS4");
            string we = Encoding.UTF8.GetString(succ1);

            byte[] succ = webClient.DownloadData("https://pastebin.com/raw/TeKDGrbg");
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
                if (!Directory.Exists("Applications"))
                {
                    Directory.CreateDirectory("Applications");
                }
                if (!Directory.Exists("autoexec"))
                {
                    Directory.CreateDirectory("autoexec");
                }
                if (!Directory.Exists("Scripts"))
                {
                    Directory.CreateDirectory("Scripts");
                }
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
                    Details = "Using MainDab V10",
                    State = "MainDab Roblox SEXploit | discord.io/maindab",

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

            Stream input = File.OpenRead("lua.xshd");
            XmlTextReader xmlTextReader = new XmlTextReader(input);
            textEditor.SyntaxHighlighting = HighlightingLoader.Load(xmlTextReader, HighlightingManager.Instance);
            // Change directory to avoid useless directories :/


        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Execute();
        }

        private void Viewer_Loaded(object sender, RoutedEventArgs e)
        {
            
           Joshualikesexuwuwuwwowowowowowow(this.fuckbm2, "Scripts", "*.txt");
            Joshualikesexuwuwuwwowowowowowow(this.fuckbm2, "Scripts", "*.lua");
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
     
        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            if (File.Exists("Applications\\MainDabExtensions.exe"))
            {
                Process.Start("Applications\\MainDabExtensions.exe");
            }
            else
            {
                MessageBox.Show("Downloading Extensions. Click OK to continue.");
                var sex = new WebClient();
                sex.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/MainDabExtensions.exe?raw=true",
                    "Applications\\MainDabExtensions.exe");
                Process.Start("Applications\\MainDabExtensions.exe");
                MessageBox.Show("Extensions downloaded and started!");
            }
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

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Execute();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            currentdll = "Selected API : EasyExploits API";
            SelectedAPILabel.Content = "Selected API : EasyExploits API";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabData");
            key.SetValue("DLL", "Selected API : EasyExploits API");
            key.Close();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textEditor.Text = "";
        }
        private string GetSpecifiedLine(string fileName, int specifiedLine)
        {
            int lineCount = 0;

            using (StreamReader sr = new StreamReader(fileName))
            {
                lineCount++;
                var line = sr.ReadLine();

                while (line != null)
                {
                    if (lineCount == specifiedLine)
                    {
                        return line;
                    }
                    line = sr.ReadLine();
                }

                return null;
            }
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
            Injection();
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
            SelectedAPILabel.Content = "Selected API : Cheatsquad";
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
            Injection();
        }

        private void NI(object sender, RoutedEventArgs e)
        {
            if (File.Exists("Applications\\fpsunlocker.exe"))
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
            if (File.Exists("Applications\\multirblx.exe"))
            {
                Process.Start("Applications\\multirblx.exe");
            }
            else
            {
                MessageBox.Show("Downloading Multiple Roblox. Click OK to continue.");
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

        private void ScriptHub_Loaded(object sender, RoutedEventArgs e)
        {
            
            try
            {
                string text3 = textEditor.Text;
                global::MoonSharp.Interpreter.Script script = new global::MoonSharp.Interpreter.Script();
                global::MoonSharp.Interpreter.DynValue dynValue = script.DoString(text3, null, null);
                this.SyntaxLabel.Content =  "No errors found.";
                this.SyntaxLabel.Foreground = Brushes.White;
            }
            catch (global::MoonSharp.Interpreter.SyntaxErrorException ex)
            {
                this.SyntaxLabel.Content = ex.DecoratedMessage.ToString();
                this.SyntaxLabel.Foreground = Brushes.Red;
            }
            catch (global::MoonSharp.Interpreter.ScriptRuntimeException)
            {
                this.SyntaxLabel.Content = "No errors found.";
                this.SyntaxLabel.Foreground = Brushes.White;
            }

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
                Joshualikesexuwuwuwwowowowowowow(listbox, "./bin/scripts", "*.txt");
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
            
            if (currentdll == "Selected API : CheatSquad")
            {
                shitsquad.Execute(scriptseggx);
            }
            if (currentdll == "Selected API : EasyExploits API")
            {
                ezclap.ExecuteScript(scriptseggx);
            }
            if (currentdll == "Selected API : ShadowCheats")
            {
               sexcheats.ExecuteScript(scriptseggx);
            }
            if (currentdll == "Selected API : WeAreDevs")
            {
               SendLimitedLuaScript(scriptseggx);
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Functions.exploitdllname = DLLNAME.Text;
            NamedPipes.luapipename = Pipe.Text;
            custom.Visibility = Visibility.Hidden;
            SelectedAPILabel.Content = "Selected API : Custom";
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
                SelectedAPILabel.Content = apishouldbe;
                currentdll = apishouldbe;
            }
        }

        private void MenuItem_Click_20(object sender, RoutedEventArgs e)
        {

            if (File.Exists("Applications\\MainDabExtensions.exe"))
            {
                Process.Start("Applications\\MainDabExtensions.exe");
            }
            else
            {
                MessageBox.Show("Downloading Extensions in order to open the taint logs. Click OK to continue.");
                var sex = new WebClient();
                sex.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/MainDabExtensions.exe?raw=true",
                    "Applications\\MainDabExtensions.exe");
                Process.Start("Applications\\MainDabExtensions.exe");
                MessageBox.Show("Extensions downloaded and started!");
            }
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
            custom.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click_23(object sender, RoutedEventArgs e)
        {
            WebClient webClient2 = new WebClient();
            byte[] bytes = webClient2.DownloadData("https://pastebin.com/raw/TU1EWx3w");
            string we = Encoding.UTF8.GetString(bytes);
            MessageBox.Show(we, "MainDab Credits");
        }

        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            ScriptHub.Visibility = Visibility.Visible;
        }
      
        private void Internal(object sender, RoutedEventArgs e)
        {
            MainDabInternal form = new MainDabInternal();
            form.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Environment.Exit(0);
        }

        private void die(object sender, RoutedEventArgs e)
        {
            try
            {
                Process[] proc =  Process.GetProcessesByName("RobloxPlayerBeta");
                proc[0].Kill();
            }
            catch { MessageBox.Show("Roblox isn't open."); }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
           
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
           
            try
            {
                string text3 = textEditor.Text;
                global::MoonSharp.Interpreter.Script script = new global::MoonSharp.Interpreter.Script();
                global::MoonSharp.Interpreter.DynValue dynValue = script.DoString(text3, null, null);
                this.SyntaxLabel.Content = "No errors found.";
                this.SyntaxLabel.Foreground = Brushes.White;
            }
            catch (global::MoonSharp.Interpreter.SyntaxErrorException ex)
            {
                this.SyntaxLabel.Content = ex.DecoratedMessage.ToString();
                this.SyntaxLabel.Foreground = Brushes.Red;
            }
            catch (global::MoonSharp.Interpreter.ScriptRuntimeException)
            {
                this.SyntaxLabel.Content = "No errors found.";
                this.SyntaxLabel.Foreground = Brushes.White;
            }
            
        }

        private void Shado(object sender, RoutedEventArgs e)
        {
            currentdll = "Selected API : ShadowCheats";
            SelectedAPILabel.Content = "Selected API : ShadowCheats";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabData");
            key.SetValue("DLL", "Selected API : ShadowCheats");
            key.Close();
        }

        private void WeAreSkids(object sender, RoutedEventArgs e)
        {
            currentdll = "Selected API : WeAreDevs";
            SelectedAPILabel.Content = "Selected API : WeAreDevs";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabData");
            key.SetValue("DLL", "Selected API : WeAreDevs");
            key.Close();
        }
    }
}
