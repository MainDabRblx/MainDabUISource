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
 Contact via discord (Main_EX#3898, My Discord ID is 766314130880593932, if that doesn't work join discord.io/maindab)
 I no longer bother annotating code, find out what it does yourself
 */

using MoonSharp.Interpreter;
using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Web;
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
using System.Runtime.InteropServices;
using System.Net.Http;
using System.Collections.Generic;
using PastebinAPIs;


namespace MainDab
{

    public partial class MainWindow : Window
    {
        string currentver = "MainDab V.12.7"; // current version
        string listboxopenornot = "false"; // listbox
        WebClient HITLER = new WebClient(); // hitler moment :D
        private DiscordRpcClient client; // discordsexual 
        private readonly Classes.EasyExploitsAPI.Module ezclap = new Classes.EasyExploitsAPI.Module(); // EasyExploits API
        private readonly Classes.WeAreDevsAPI.ExploitAPI wrd = new Classes.WeAreDevsAPI.ExploitAPI(); // WeAreDevs API
        private readonly Classes.ShadowCheatsAPI.Module shadowcheats = new Classes.ShadowCheatsAPI.Module();
        //  private readonly AnemoAPI.Anemo sexcheats = new AnemoAPI.Anemo();  // Converted to Arch from ShadowCheats
        string currentdll = "Selected API : EasyExploits API"; // by default...
        private readonly BackgroundWorker worker = new BackgroundWorker();
        [DllImport("kernel32.dll")] // just grabbed this off uhhhhhhhhhhhhhhhhh
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        public MainWindow()
        {
            
            Console.WriteLine("\r\n  __  __       _       _____        _     \r\n |  \\/  |     (_)     |  __ \\      | |    \r\n | \\  / | __ _ _ _ __ | |  | | __ _| |__  \r\n | |\\/| |/ _` | | '_ \\| |  | |/ _` | '_ \\ \r\n | |  | | (_| | | | | | |__| | (_| | |_) |\r\n |_|  |_|\\__,_|_|_| |_|_____/ \\__,_|_.__/ \r\n                                          \r\n                                          \r\n");
            Console.WriteLine("Debugging console | Join MainDab at discord.io/maindab if you need help");
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
            Process[] pname = Process.GetProcessesByName("RobloxPlayerBeta");
            if (pname.Length > 0)
            {

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
                if (currentdll == "Selected API : ShadowCheats API")
                {

                    shadowcheats.Attach();
                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;

                        this.Dispatcher.Invoke(() =>
                        {
                            TopBar.Content = "MainDab | Injecting ShadowCheats API...";

                        });
                        Thread.Sleep(6000);
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
                if (currentdll == "Selected API : MainDab LBI")
                {
               
                   WebClient webClient = new WebClient();
                   Functions.exploitdllname = "MainDab.dll";
                   NamedPipes.luapipename = "uwuLBIPipe";
                    new Thread(() =>
                    {
                        if (NamedPipes.NamedPipeExist("uwuLBIPipe"))
                        {
                            MessageBox.Show("MainDab LBI already injected!", "MainDab");
                        }
                        else
                        {
                            Thread.CurrentThread.IsBackground = true;

                            this.Dispatcher.Invoke(() =>
                            {
                                TopBar.Content = "MainDab | Updating MainDab LBI";
                            });
                            if (File.Exists("MainDab.dll"))
                            {
                                File.Delete("MainDab.dll");
                            }
                            webClient.DownloadFile("https://github.com/deaddlocust/Cyrup-Files/raw/main/MainDab.dll", "MainDab.dll");
                            this.Dispatcher.Invoke(() =>
                            {
                                TopBar.Content = "MainDab";
                            });
                            Functions.Inject();
                        }
                  
                    }).Start();


                }

                if (currentdll == "Selected API : Anemo API")
            {
                    //sexcheats.InjectAnemo();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;

                    this.Dispatcher.Invoke(() =>
                    {
                        TopBar.Content = "MainDab | Injecting Anemo API...";

                    });
                    Thread.Sleep(8000);
                    this.Dispatcher.Invoke(() =>
                    {
                        TopBar.Content = "MainDab | Anemo API Injected!";
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
                    wrd.LaunchExploit();
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
            }
            else
            {
                MessageBox.Show("Please open ROBLOX before injecting!", "MainDab");
            }


        }
        private void Execute()
        {
            Process[] pname = Process.GetProcessesByName("RobloxPlayerBeta");
            if (pname.Length > 0)
            {

                if (currentdll == "Selected API : MainDab LBI")
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

                /* if (currentdll == "Selected API : CheatSquad")
                 {
                     shitsquad.Execute(textEditor.Text);
                 }*/
                else if (currentdll == "Selected API : EasyExploits API")
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
                else if (currentdll == "Selected API : Anemo API")
                {
                    //sexcheats.ExecuteScript(textEditor.Text);
                }

                else if (currentdll == "Selected API : WeAreDevs")
                {
                    wrd.SendLuaScript(textEditor.Text);
                }
                else if (currentdll == "Selected API : ShadowCheats API")
                {
                    shadowcheats.ExecuteScript(textEditor.Text);
                }
                else if (currentdll == "Selected API : Custom")
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
                else
                {
                    MessageBox.Show("You must inject (click the syringe icon) before executing a script!");
                }
            }
            else
            {
                MessageBox.Show("You must open Roblox and inject before attempting to run the script!");
            }
        } // Execute
        private void textEditor_Loaded(object sender, RoutedEventArgs e)
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_SHOW);
            Console.WriteLine("Checking for updates...\n");
            WebClient webClient = new WebClient();
            byte[] succ1 = webClient.DownloadData("https://pastebin.com/raw/QpwkAJS4");
            string we = Encoding.UTF8.GetString(succ1);

            byte[] succ = webClient.DownloadData("https://pastebin.com/raw/TeKDGrbg");
            string discord = Encoding.UTF8.GetString(succ);
            Process.Start(discord);
           // remember to reenable!
            if (we == currentver)
            {
                Console.WriteLine("Already using latest MainDab version\n");
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
           
                
                string whentheimpostorissus = ("--[[\r\nWelcome to MainDab!\r\nMake sure to join MainDab's discord at discord.io/maindab\r\nIf you need help, join our discord!\r\n--]]\r\n-- Paste in your text below this comment.\n\nprint(\"MainDab is poggers\")");
                textEditor.Text = whentheimpostorissus;
                System.IO.Stream str = Properties.Resources.Notify;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                if (File.Exists("lua.xshd"))
                {
                   File.Delete("lua.xshd");
                   string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua.xshd");
                    File.WriteAllText("lua.xshd", penis); // just in case need new update
                }

                if (!File.Exists("lua.xshd")) // onv
                {
                   string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua.xshd");
                   File.WriteAllText("lua.xshd", penis);
                }
                // pp penis big 
                Stream input = File.OpenRead("lua.xshd");
                XmlTextReader xmlTextReader = new XmlTextReader(input);
                textEditor.SyntaxHighlighting = HighlightingLoader.Load(xmlTextReader, HighlightingManager.Instance);
                snd.Play();
            }
            else
            {
                Console.WriteLine("Update found\n");
                webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDab%20Updater.exe?raw=true", "update.exe");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                Process.Start("update.exe");
                Environment.Exit(0);
            }
         
          
            // Change directory to avoid useless directories :/
            Console.WriteLine("All done\n");
            ShowWindow(handle, SW_HIDE);

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
                Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*"
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
                        /*
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
                        }*/
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
                        /*try
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
                        }*/
                    }
               
            }
            catch (Exception sexual)
            {
                MessageBox.Show("An error has occured, here is the error :\n\n" + sexual, "Report this to Main_EX in Discord!");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
         
            if (currentdll == "Selected API : EasyExploits API")
            {
                ezclap.ExecuteScript(scriptseggx);
            }
            if (currentdll == "Selected API : MainDab LBI")
            {
                NamedPipes.LuaPipe(scriptseggx);
            }
            if (currentdll == "Selected API : WeAreDevs")
            {
               wrd.SendLuaScript(scriptseggx);
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
            var webClient= new WebClient();
            byte[] succ = webClient.DownloadData("https://pastebin.com/raw/TeKDGrbg");
            string discord = Encoding.UTF8.GetString(succ);
            Process.Start(discord);
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
            this.sex.Navigate("https://maindabusagecounter.netlify.app/");

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
              if (File.Exists("ArchAPI.dll"))
             {
                File.Delete("ArchAPI.dll");
             }
             RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MainDabData");
             if (key != null)
             {
                 string apishouldbe = (key.GetValue("DLL").ToString());
                 SelectedAPILabel.Content = apishouldbe;
                 currentdll = apishouldbe;
               
            }
            RegistryKey maindabtheme = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MainDabTheme");
            if (maindabtheme != null)
            {
                // honestly could be x1000 more efficient and save more space but idc
                string theme = (maindabtheme.GetValue("THEME").ToString());
                if (theme == "Default")
                {
                    Border.Visibility = Visibility.Hidden;

                    if (!Directory.Exists("EditorThemes"))
                    {
                        Directory.CreateDirectory("EditorThemes");
                    }
                   
                    if (!File.Exists("EditorThemes\\lua_md_default.xshd")) // onv
                    {
                        string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua_md_default.xshd");
                        File.WriteAllText("EditorThemes\\lua_md_default.xshd", penis);
                    }
                    // pp penis big 
                    Stream input = File.OpenRead("EditorThemes\\lua_md_default.xshd");
                    XmlTextReader xmlTextReader = new XmlTextReader(input);
                    textEditor.SyntaxHighlighting = HighlightingLoader.Load(xmlTextReader, HighlightingManager.Instance);
                }
                if (theme == "Purple")
                {
                    Border.Visibility = Visibility.Visible;
                    Border.Fill = new SolidColorBrush(Color.FromRgb(200, 0, 255));
                    if (!Directory.Exists("EditorThemes"))
                    {
                        Directory.CreateDirectory("EditorThemes");
                    }
                    
                    if (!File.Exists("EditorThemes\\lua_md_royalpurple.xshd")) // onv
                    {
                        string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua_md_royalpurple.xshd");
                        File.WriteAllText("EditorThemes\\lua_md_royalpurple.xshd", penis);
                    }
                    // pp penis big 
                    Stream input = File.OpenRead("EditorThemes\\lua_md_royalpurple.xshd");
                    XmlTextReader xmlTextReader = new XmlTextReader(input);
                    textEditor.SyntaxHighlighting = HighlightingLoader.Load(xmlTextReader, HighlightingManager.Instance);

                }
                if (theme == "Red")
                {
                    Border.Visibility = Visibility.Visible;
                    Border.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    if (!Directory.Exists("EditorThemes"))
                    {
                        Directory.CreateDirectory("EditorThemes");
                    }
                  

                    if (!File.Exists("EditorThemes\\lua_md_crimsonred.xshd")) // onv
                    {
                        string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua_md_crimsonred.xshd");
                        File.WriteAllText("EditorThemes\\lua_md_crimsonred.xshd", penis);
                    }
                    // pp penis big 
                    Stream input = File.OpenRead("EditorThemes\\lua_md_crimsonred.xshd");
                    XmlTextReader xmlTextReader = new XmlTextReader(input);
                    textEditor.SyntaxHighlighting = HighlightingLoader.Load(xmlTextReader, HighlightingManager.Instance);
                   
                }
                if (theme == "Blue")
                {
                    Border.Visibility = Visibility.Visible;
                    Border.Fill = new SolidColorBrush(Color.FromRgb(0, 238, 255));
                    if (!Directory.Exists("EditorThemes"))
                    {
                        Directory.CreateDirectory("EditorThemes");
                    }
                   

                    if (!File.Exists("EditorThemes\\lua_md_purityblue.xshd")) // onv
                    {
                        string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua_md_purityblue.xshd");
                        File.WriteAllText("EditorThemes\\lua_md_purityblue.xshd", penis);
                    }
                    // pp penis big 
                    Stream input = File.OpenRead("EditorThemes\\lua_md_purityblue.xshd");
                    XmlTextReader xmlTextReader = new XmlTextReader(input);
                    textEditor.SyntaxHighlighting = HighlightingLoader.Load(xmlTextReader, HighlightingManager.Instance);
                }
                if (theme == "Green")
                {
                    Border.Visibility = Visibility.Visible;
                    Border.Fill = new SolidColorBrush(Color.FromRgb(9, 222, 118));
                    if (!Directory.Exists("EditorThemes"))
                    {
                        Directory.CreateDirectory("EditorThemes");
                    }
                   

                    if (!File.Exists("EditorThemes\\lua_md_maindabgreen.xshd")) // onv
                    {
                        string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua_md_maindabgreen.xshd");
                        File.WriteAllText("EditorThemes\\lua_md_maindabgreen.xshd", penis);
                    }
                    // pp penis big 
                    Stream input = File.OpenRead("EditorThemes\\lua_md_maindabgreen.xshd");
                    XmlTextReader xmlTextReader = new XmlTextReader(input);
                    textEditor.SyntaxHighlighting = HighlightingLoader.Load(xmlTextReader, HighlightingManager.Instance);
                }
              

            }
            client = new DiscordRpcClient("795935176873213982")
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
                Details = "Using MainDab V12",
                State = "MainDab Roblox Exploit | discord.io/maindab",

                Timestamps = new Timestamps
                {
                    Start = DateTime.UtcNow,

                },

                Assets = new Assets
                {
                    LargeImageKey = "image_large",
                    LargeImageText = "MainDab Roblox Exploit",

                    SmallImageKey = "image_roblox"
                }

            });

        }

        private void MenuItem_Click_20(object sender, RoutedEventArgs e)
        {

            Form1 creditui = new Form1();
            creditui.Show();
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
            Credits creditui = new Credits();
            creditui.Show();
        }

        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            
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


            System.Windows.Threading.DispatcherTimer reload = new System.Windows.Threading.DispatcherTimer();
            reload.Tick += new EventHandler(reload_Tick);
            reload.Interval = new TimeSpan(0, 0, 10);
            reload.Start();

            System.Windows.Threading.DispatcherTimer checkforupdateseveryminute = new System.Windows.Threading.DispatcherTimer();
            reload.Tick += new EventHandler(reload_Tick);
            reload.Interval = new TimeSpan(0, 0, 60);
            reload.Start();

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
        private void reload_Tick(object sender, EventArgs e)
        {

            this.sex.Refresh();

        }
        private void checkforupdateseveryminute_Tick(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            byte[] succ1 = webClient.DownloadData("https://pastebin.com/raw/QpwkAJS4");
            string we = Encoding.UTF8.GetString(succ1);
            if (we == currentver)
            {
            }
            else
            {
                Console.WriteLine("Update found\n");
                webClient.DownloadFile("https://github.com/leonardssy/ProjectDab/blob/master/MainDab%20Updater.exe?raw=true", "update.exe");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                Process.Start("update.exe");
                Environment.Exit(0);
            }
        }
        private void Shado(object sender, RoutedEventArgs e)
        {
            currentdll = "Selected API : Anemo API";
            SelectedAPILabel.Content = "Selected API : Anemo API";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabData");
            key.SetValue("DLL", "Selected API : Anemo API");
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

        private void Load(object sender, RoutedEventArgs e)
        {

        }

        private void Unload(object sender, RoutedEventArgs e)
        {

        }

        private void TabablzControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void joinmein(object sender, MouseButtonEventArgs e)
        {
            Process.Start("Https://discord.io/maindab");
        }

        private void github(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://github.com/MainDabRblx/MainDabUISource");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void DeepPain(object sender, RoutedEventArgs e)
        {

            currentdll = "Selected API : Acrylix";
            SelectedAPILabel.Content = "Selected API : Acrylix";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabData");
            key.SetValue("DLL", "Selected API : Acrylix");
            key.Close();
        }

        private void visiornot(object sender, MouseButtonEventArgs e)
        {
            if (listboxopenornot == "true")
            {  
                fuckbm2.Visibility = Visibility.Hidden;
              //  textEditor.Width = 524;
                listboxopenornot = "false";
            }
            else if (listboxopenornot == "false")
            {
                
                fuckbm2.Visibility = Visibility.Visible;
               // textEditor.Width = 403;
                listboxopenornot = "true";
            }
        }

        private void EnableDisabledDiscordRPC(object sender, RoutedEventArgs e)
        {

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MainDabData");
            if (key != null)
            {
                string enabledornotlol = (key.GetValue("DiscordRPCEnabled").ToString());
                key.Close();
                if (enabledornotlol == "true")
                {
                    RegistryKey Create = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabData");
                    Create.SetValue("DiscordRPCEnabled", "false");
                    Create.Close();
                    MessageBox.Show("Discord RPC (Rich Presence) is now turned off! Click OK to close MainDab. You will need to reopen MainDab manually.");
                    this.Hide();
                    Environment.Exit(0);

                }
                if (enabledornotlol == "false")
                {
                    RegistryKey Create = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabData");
                    Create.SetValue("DiscordRPCEnabled", "true");
                    Create.Close();
                    MessageBox.Show("Discord RPC (Rich Presence) is now turned on! Click OK to close MainDab. You will need to reopen MainDab manually.");
                    this.Hide();
                    Environment.Exit(0);

                }
            }



            
        }

        private void MenuSaveFile_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void UploadPastebin(object sender, RoutedEventArgs e)
        {
            var api = new PastebinAPI();
            api.APIKey = "91w9z9nHwR_DONb86nwDX5QbhUKP_TqX"; // I would imagine you're reading this at this very moment.
            var createRequest = new PasteCreateRequest();
            createRequest.Code = "-- Uploaded to Pastebin from MainDab | discord.io/maindab \n\n" + textEditor.Text;
            createRequest.Name = "Script";
            createRequest.ExpireDate = PasteExpireDate.Never;
            createRequest.Private = PastePrivate.Public;
            createRequest.Format = "lua";
            createRequest.UserKey = string.Empty; 
            var url = api.CreatePaste(createRequest);
            textEditor.Text = ("--[[\nYour script has been uploaded to Pastebin.\nThe Pastebin link is " + url + "\n--]]");
            Console.WriteLine(url);

        }

        private void BMLBI(object sender, RoutedEventArgs e)
        {
            currentdll = "Selected API : MainDab LBI";
            SelectedAPILabel.Content = "Selected API : MainDab LBI";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabData");
            key.SetValue("DLL", "Selected API : MainDab LBI");
            key.Close();
        }

        private void killroblox(object sender, MouseButtonEventArgs e)
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("RobloxPlayerBeta"))
                {
                    proc.Kill();
                    MessageBox.Show("Roblox process killed / ended");
                }

            }
            catch
            {
                MessageBox.Show("Roblox process has already been killed, or Roblox isn't running.");
            }
        }

        private void schub(object sender, MouseButtonEventArgs e)
        {
            ScriptHub.Visibility = Visibility.Visible;
       }

        private void SniffHub(object sender, RoutedEventArgs e)
        {
            string sexhub = "loadstring(game:HttpGet('https://raw.githubusercontent.com/2dgeneralspam1/Sniff-Hub/main/sniff%20hub%20lite'))()";
            Process.Start("https://dsc.gg/sniffcommunity");
            Process[] pname = Process.GetProcessesByName("RobloxPlayerBeta");
            if (pname.Length > 0)
            {
                if (currentdll == "Selected API : EasyExploits API")
                {
                    ezclap.ExecuteScript(sexhub);
                }
                if (currentdll == "Selected API : Anemo API")
                {
                  // sexcheats.ExecuteScript(sexhub);
                }
                else
                {
                    MessageBox.Show("Please use either EasyExploits API or Arch API. You can change the DLL by clicking 'Select DLL'.");
                }
               
            }
            else
            {
                MessageBox.Show("Please start/open ROBLOX first!");
            }
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TabablzControl_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DefaultThemeButton(object sender, RoutedEventArgs e)
        {
            Border.Visibility = Visibility.Hidden;
            
            if (!Directory.Exists("EditorThemes"))
            {
                Directory.CreateDirectory("EditorThemes");
            }
            if (File.Exists("EditorThemes\\lua_md_default.xshd"))
            {
                File.Delete("EditorThemes\\lua_md_default.xshd");
                string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua_md_default.xshd");
                File.WriteAllText("EditorThemes\\lua_md_default.xshd", penis); // just in case need new update
            }

            if (!File.Exists("EditorThemes\\lua_md_default.xshd")) // onv
            {
                string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua_md_default.xshd");
                File.WriteAllText("EditorThemes\\lua_md_default.xshd", penis);
            }
            // pp penis big 
            Stream input = File.OpenRead("EditorThemes\\lua_md_default.xshd");
            XmlTextReader xmlTextReader = new XmlTextReader(input);
            textEditor.SyntaxHighlighting = HighlightingLoader.Load(xmlTextReader, HighlightingManager.Instance);
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabTheme");
            key.SetValue("THEME", "Default");
            key.Close();
            MessageBox.Show("New theme applied");
        }

        private void RoyalPurple(object sender, RoutedEventArgs e)
        {
            Border.Visibility = Visibility.Visible;
            Border.Fill = new SolidColorBrush(Color.FromRgb(200, 0, 255));
            if (!Directory.Exists("EditorThemes"))
            {
                Directory.CreateDirectory("EditorThemes");
            }
            if (File.Exists("EditorThemes\\lua_md_royalpurple.xshd"))
            {
                File.Delete("EditorThemes\\lua_md_royalpurple.xshd");
                string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua_md_royalpurple.xshd");
                File.WriteAllText("EditorThemes\\lua_md_royalpurple.xsdd", penis); // just in case need new update
            }

            if (!File.Exists("EditorThemes\\lua_md_royalpurple.xshd")) // onv
            {
                string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua_md_royalpurple.xshd");
                File.WriteAllText("EditorThemes\\lua_md_royalpurple.xshd", penis);
            }
            // pp penis big 
            Stream input = File.OpenRead("EditorThemes\\lua_md_royalpurple.xshd");
            XmlTextReader xmlTextReader = new XmlTextReader(input);
            textEditor.SyntaxHighlighting = HighlightingLoader.Load(xmlTextReader, HighlightingManager.Instance);
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabTheme");
            key.SetValue("THEME", "Purple");
            key.Close();
            MessageBox.Show("New theme applied");
        }

        private void CrimsonRed(object sender, RoutedEventArgs e)
        {
            Border.Visibility = Visibility.Visible;
            Border.Fill = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            if (!Directory.Exists("EditorThemes"))
            {
                Directory.CreateDirectory("EditorThemes");
            }
            if (File.Exists("EditorThemes\\lua_md_crimsonred.xshd"))
            {
                File.Delete("EditorThemes\\lua_md_crimsonred.xshd");
                string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua_md_crimsonred.xshd");
                File.WriteAllText("EditorThemes\\lua_md_crimsonred.xshd", penis); // just in case need new update
            }

            if (!File.Exists("EditorThemes\\lua_md_crimsonred.xshd")) // onv
            {
                string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua_md_crimsonred.xshd");
                File.WriteAllText("EditorThemes\\lua_md_crimsonred.xshd", penis);
            }
            // pp penis big 
            Stream input = File.OpenRead("EditorThemes\\lua_md_crimsonred.xshd");
            XmlTextReader xmlTextReader = new XmlTextReader(input);
            textEditor.SyntaxHighlighting = HighlightingLoader.Load(xmlTextReader, HighlightingManager.Instance);
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabTheme");
            key.SetValue("THEME", "Red");
            key.Close();
            MessageBox.Show("New theme applied");
        }

        private void Purity(object sender, RoutedEventArgs e)
        {
            Border.Visibility = Visibility.Visible;
            Border.Fill = new SolidColorBrush(Color.FromRgb(0, 238, 255));
            if (!Directory.Exists("EditorThemes"))
            {
                Directory.CreateDirectory("EditorThemes");
            }
            if (File.Exists("EditorThemes\\lua_md_purityblue.xshd"))
            {
                File.Delete("EditorThemes\\lua_md_purityblue.xshd");
                string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua_md_purityblue.xshd");
                File.WriteAllText("EditorThemes\\lua_md_purityblue.xshd", penis); // just in case need new update
            }

            if (!File.Exists("EditorThemes\\lua_md_purityblue.xshd")) // onv
            {
                string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua_md_purityblue.xshd");
                File.WriteAllText("EditorThemes\\lua_md_purityblue.xshd", penis);
            }
            // pp penis big 
            Stream input = File.OpenRead("EditorThemes\\lua_md_purityblue.xshd");
            XmlTextReader xmlTextReader = new XmlTextReader(input);
            textEditor.SyntaxHighlighting = HighlightingLoader.Load(xmlTextReader, HighlightingManager.Instance);
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabTheme");
            key.SetValue("THEME", "Blue");
            key.Close();
            MessageBox.Show("New theme applied");
        }

        private void green(object sender, RoutedEventArgs e)
        {
            Border.Visibility = Visibility.Visible;
            Border.Fill = new SolidColorBrush(Color.FromRgb(9, 222, 118));
            if (!Directory.Exists("EditorThemes"))
            {
                Directory.CreateDirectory("EditorThemes");
            }
            if (File.Exists("EditorThemes\\lua_md_maindabgreen.xshd"))
            {
                File.Delete("EditorThemes\\lua_md_maindabgreen.xshd");
                string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua_md_maindabgreen.xshd");
                File.WriteAllText("EditorThemes\\lua_mdlua_md_maindabgreen.xshd", penis); // just in case need new update
            }

            if (!File.Exists("EditorThemes\\lua_md_maindabgreen.xshd")) // onv
            {
                string penis = HITLER.DownloadString("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/Themes/lua_md_maindabgreen.xshd");
                File.WriteAllText("EditorThemes\\lua_md_maindabgreen.xshd", penis);
            }
            // pp penis big 
            Stream input = File.OpenRead("EditorThemes\\lua_md_maindabgreen.xshd");
            XmlTextReader xmlTextReader = new XmlTextReader(input);
            textEditor.SyntaxHighlighting = HighlightingLoader.Load(xmlTextReader, HighlightingManager.Instance);
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabTheme");
            key.SetValue("THEME", "Green");
            key.Close();
            MessageBox.Show("New theme applied");
        }

        private void UwU(object sender, RoutedEventArgs e)
        {
            /*
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                this.Dispatcher.Invoke(() =>
                {
                    TopBar.Content = "MainDab | Updating PuppyMilk...";

                });
                var sex = new WebClient();
                sex.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/ExtraApplications/PuppyMilkV3.exe?raw=true", "PuppyMilkV3.exe");
                this.Dispatcher.Invoke(() =>
                {
                    TopBar.Content = "MainDab | PuppyMilk Updated!";
                });
                Thread.Sleep(1000);
                this.Dispatcher.Invoke(() =>
                {
                    TopBar.Content = "MainDab";
                });
            }).Start();*/
        }

        private void MDLBI(object sender, RoutedEventArgs e)
        {
            currentdll = "Selected API : MainDab LBI";
            SelectedAPILabel.Content = "Selected API : MainDab LBI";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabData");
            key.SetValue("DLL", "Selected API : MainDab LBI");
            key.Close();
        }

        private void GetVersionOwO(object sender, RoutedEventArgs e)
        {
      
            
        }

        private void ShadowCheats(object sender, RoutedEventArgs e)
        {
            currentdll = "Selected API : ShadowCheats API";
            SelectedAPILabel.Content = "Selected API : ShadowCheats API";
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MainDabData");
            key.SetValue("DLL", "Selected API : ShadowCheats API");
            key.Close();
        }
    }

}
