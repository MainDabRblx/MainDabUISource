using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CheatSquadAPI;
using DiscordRPC;
using DiscordRPC.Logging;
using Microsoft.Win32;
using OxygenU_API;
using ShadowCheats;

namespace ProjectMainDab
{
    public partial class MainUI : Form
    {
        private readonly DiscordRpcClient client;

        // Just some monaco stuff, I won't annotate it because idc
        private readonly string defPath = Application.StartupPath + "//Monaco//";
        private readonly Api freesex = new Api(); // EasyExploits
        private int intValue = 2; // TabControl value stuff ok
        private readonly Client oxygen = new Client();
        private readonly SEX shitsquad = new SEX(); // CheatSquad API

        public MainUI()
        {
            InitializeComponent();
            try
            {
                // Monaco code on startup.

                var registryKey = Registry.CurrentUser.OpenSubKey(
                    "SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                var friendlyName = AppDomain.CurrentDomain.FriendlyName;
                var flag = registryKey.GetValue(friendlyName) == null;
                var flag2 = flag;
                if (flag2) registryKey.SetValue(friendlyName, 11001, RegistryValueKind.DWord);
            }
            catch (Exception)
            {
            }

            var webBrowser = new WebBrowser();
            var webClient2 = new WebClient();
            webClient2.Proxy = null;
            var tabPage = new TabPage("Tab 1");
            tabPage.Controls.Add(webBrowser);
            webBrowser.Dock = DockStyle.Fill;
            visualStudioTabControl1.TabPages.Add(tabPage);
            visualStudioTabControl1.SelectedTab = tabPage;
            webBrowser.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
            var document = webBrowser.Document;
            var scriptName = "SetTheme";
            object[] args =
            {
                "Dark"
            };
            document.InvokeScript(scriptName, args);
            addBase();
            addMath();
            addGlobalNS();
            addGlobalV();
            addGlobalF();
            Functions.PopulateListBox(listBox1, "./scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./scripts", "*.lua");

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
                Details = "Using MainDab V7",
                State = "Join here : discord.io/maindab",
                Assets = new Assets
                {
                    LargeImageKey = "render",
                    LargeImageText = "render",
                    SmallImageKey = "render"
                }
            });
            backgroundWorker1.RunWorkerAsync();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            menuStrip2.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void addIntel(string label, string kind, string detail, string insertText)
        {
            var text = "\"" + label + "\"";
            var text2 = "\"" + kind + "\"";
            var text3 = "\"" + detail + "\"";
            var text4 = "\"" + insertText + "\"";
            MonacoEditor().Document.InvokeScript("AddIntellisense", new object[]
            {
                label,
                kind,
                detail,
                insertText
            });
        }

        // Token: 0x06000010 RID: 16 RVA: 0x000025CC File Offset: 0x000007CC
        private void addGlobalF()
        {
            var array = File.ReadAllLines(defPath + "//globalf.txt");
            foreach (var text in array)
            {
                var flag = text.Contains(':');
                var flag2 = flag;
                if (flag2)
                    addIntel(text, "Function", text, text.Substring(1));
                else
                    addIntel(text, "Function", text, text);
            }
        }

        // Token: 0x06000011 RID: 17 RVA: 0x00002644 File Offset: 0x00000844
        private void addGlobalV()
        {
            foreach (var text in File.ReadLines(defPath + "//globalv.txt")) addIntel(text, "Variable", text, text);
        }

        // Token: 0x06000012 RID: 18 RVA: 0x000026B0 File Offset: 0x000008B0
        private void addGlobalNS()
        {
            foreach (var text in File.ReadLines(defPath + "//globalns.txt")) addIntel(text, "Class", text, text);
        }

        // Token: 0x06000013 RID: 19 RVA: 0x0000271C File Offset: 0x0000091C
        private void addMath()
        {
            foreach (var text in File.ReadLines(defPath + "//classfunc.txt")) addIntel(text, "Method", text, text);
        }

        // Token: 0x06000014 RID: 20 RVA: 0x00002788 File Offset: 0x00000988
        private void addBase()
        {
            foreach (var text in File.ReadLines(defPath + "//base.txt")) addIntel(text, "Keyword", text, text);
        }

        // Token: 0x06000015 RID: 21 RVA: 0x000027F4 File Offset: 0x000009F4
        private WebBrowser MonacoEditor()
        {
            WebBrowser result = null;
            var selectedTab = visualStudioTabControl1.SelectedTab;
            var flag = selectedTab != null;
            if (flag) result = selectedTab.Controls[0] as WebBrowser;
            return result;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
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
            listBox2.Items.Clear();
            try

            {
                Functions.PopulateListBox1(listBox2, "./bin/scripts", "*.txt");
            }
            catch
            {
                MessageBox.Show(
                    "Failed to open scripthub as it detects no scripts or folder, try close and rerun MainDab.");
                Hide();
            }

            label5.Text = "Updating MainDab.dll...";
            if (File.Exists("MainDab.dll")) File.Delete("MainDab.dll");
            var url1 = "https://github.com/leonardssy/ProjectDab/blob/master/MainDab.dll?raw=true";
            var filename1 = "MainDab.dll";
            using (var wc = new WebClient())
            {
                wc.DownloadFile(url1, filename1);
            }

            label5.Text = "Update dones!";
            Thread.Sleep(1000);
            label5.Text = "Waiting for commands...";
        }

        private void cheatSquadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = "Selected API : CheatSquad";
        }

        private void shadowCheatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = "Selected API : ShadowCheats";
        }

        private void mainDabAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = "Selected API : MainDabAPI";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (label6.Text == "Selected API : CheatSquad") CheatSquad.RunWorkerAsync();
            if (label6.Text == "Selected API : ShadowCheats") ShadowCheats.RunWorkerAsync();
            if (label6.Text == "Selected API : MainDabAPI") MainDabAPI.RunWorkerAsync();
            if (label6.Text == "Selected API : OxygenU API") OxygenU.RunWorkerAsync();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            visualStudioTabControl1.SelectedIndex = 0;
        }

        private void scriptHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visualStudioTabControl1.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (label6.Text == "Selected API : OxygenU API")
            {
                var document = MonacoEditor().Document;
                var scriptName = "GetText";
                object[] array = new string[0];
                var args = array;
                var obj = document.InvokeScript(scriptName, args);
                var script = obj.ToString();
                oxygen.Execute(script);
            }

            if (label6.Text == "Selected API : CheatSquad")
            {
                var document = MonacoEditor().Document;
                var scriptName = "GetText";
                object[] array = new string[0];
                var args = array;
                var obj = document.InvokeScript(scriptName, args);
                var script = obj.ToString();
                shitsquad.Execute(script);
            }

            if (label6.Text == "Selected API : ShadowCheats")
            {
                var document = MonacoEditor().Document;
                var scriptName = "GetText";
                object[] array = new string[0];
                var args = array;
                var obj = document.InvokeScript(scriptName, args);
                var script = obj.ToString();
                freesex.ExecuteFromInterpreter(script);
            }

            if (label6.Text == "Selected API : MainDabAPI")
            {
                var document = MonacoEditor().Document;
                var scriptName = "GetText";
                object[] array = new string[0];
                var args = array;
                var obj = document.InvokeScript(scriptName, args);
                var script = obj.ToString();
                NamedPipes.LuaPipe(script);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MonacoEditor().Document.InvokeScript("SetText", new object[]
            {
                ""
            });
            Console.WriteLine("Monaco cleared");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var flag = Functions.openfiledialog.ShowDialog() == DialogResult.OK;
            if (flag)
                try
                {
                    var text = File.ReadAllText(Functions.openfiledialog.FileName);
                    MonacoEditor().Document.InvokeScript("SetText", new object[]
                    {
                        text
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    Console.WriteLine("File can't be opened");
                }
        }

        private void injectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var flag = Functions.openfiledialog.ShowDialog() == DialogResult.OK;
            if (flag)
                try
                {
                    var text = File.ReadAllText(Functions.openfiledialog.FileName);
                    MonacoEditor().Document.InvokeScript("SetText", new object[]
                    {
                        text
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    Console.WriteLine("File can't be opened");
                }
        }

        private void killRobloxToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void injectMainDabAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = "Selected API : MainDabAPI";
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                label5.Text = "Injection in progress...";
                Thread.Sleep(3000);
                label5.Text = "Waiting for commands...";
            }).Start();
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label6.Text == "Selected API : OxygenU API")
            {
                var document = MonacoEditor().Document;
                var scriptName = "GetText";
                object[] array = new string[0];
                var args = array;
                var obj = document.InvokeScript(scriptName, args);
                var script = obj.ToString();
                oxygen.Execute(script);
            }

            if (label6.Text == "Selected API : CheatSquad")
            {
                var document = MonacoEditor().Document;
                var scriptName = "GetText";
                object[] array = new string[0];
                var args = array;
                var obj = document.InvokeScript(scriptName, args);
                var script = obj.ToString();
                shitsquad.Execute(script);
            }

            if (label6.Text == "Selected API : ShadowCheats")
            {
                var document = MonacoEditor().Document;
                var scriptName = "GetText";
                object[] array = new string[0];
                var args = array;
                var obj = document.InvokeScript(scriptName, args);
                var script = obj.ToString();
                freesex.ExecuteFromInterpreter(script);
            }

            if (label6.Text == "Selected API : MainDabAPI")
            {
                var document = MonacoEditor().Document;
                var scriptName = "GetText";
                object[] array = new string[0];
                var args = array;
                var obj = document.InvokeScript(scriptName, args);
                var script = obj.ToString();
                NamedPipes.LuaPipe(script);
            }
        }

        private void pluginsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonacoEditor().Document.InvokeScript("SetText", new object[]
            {
                ""
            });
            Console.WriteLine("Monaco cleared");
        }

        private void injecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label6.Text == "Selected API : CheatSquad") CheatSquad.RunWorkerAsync();
            if (label6.Text == "Selected API : ShadowCheats") ShadowCheats.RunWorkerAsync();
            if (label6.Text == "Selected API : MainDabAPI") MainDabAPI.RunWorkerAsync();
            if (label6.Text == "Selected API : OxygenU API") OxygenU.RunWorkerAsync();
        }

        private void serversodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var script = "game.JointsService.WeldRequest:FireServer(\"gui\")";
            if (label6.Text == "Selected API : Oxygenu API")
                new Thread(() => { oxygen.Execute(script); }).Start();
            if (label6.Text == "Selected API : CheatSquad")
                new Thread(() => { shitsquad.Execute(script); }).Start();
            if (label6.Text == "Selected API : ShadowCheats")
                new Thread(() => { freesex.LoadIntoRoblox(script); }).Start();
            if (label6.Text == "Selected API : MainDabAPI")
                new Thread(() => { NamedPipes.LuaPipe(script); }).Start();
        }

        private void pDXHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var script = "loadstring(game:HttpGet(\"https://www.codepile.net/raw/9Eye4JEb.lua\", true))()";
            if (label6.Text == "Selected API : Oxygenu API")
                new Thread(() => { oxygen.Execute(script); }).Start();
            if (label6.Text == "Selected API : CheatSquad")
                new Thread(() => { shitsquad.Execute(script); }).Start();
            if (label6.Text == "Selected API : ShadowCheats")
                new Thread(() => { freesex.LoadIntoRoblox(script); }).Start();
            if (label6.Text == "Selected API : MainDabAPI")
                new Thread(() => { NamedPipes.LuaPipe(script); }).Start();
        }

        private void fPSUnlockerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (File.Exists("fpsunlocker.exe"))
            {
                Process.Start("Applications\\fpsunlocker.exe");
            }
            else
            {
                MessageBox.Show("Downloading VPN. Click OK to continue.");
                var sex = new WebClient();
                sex.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/fpsunlocker.exe?raw=true",
                    "Applications\\fpsunlocker.exe");
                Process.Start("Applications\\fpsunlocker.exe");
                MessageBox.Show("FPS unlocker downloaded and started!");
            }
        }

        private void multipleRobloxToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void reinstallRobloxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reinstalling Roblox, MainDab may freeze for a while.", "MainDab", MessageBoxButtons.OK);
            try
            {
                foreach (var process in Process.GetProcessesByName("RobloxPlayerBeta")) process.Kill();
            }
            catch (Exception value)
            {
                MessageBox.Show(Convert.ToString(value), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

        private void taintDetectedExploitsCheckerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaintCheck Form = new TaintCheck();
            Form.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MonacoEditor().Document.InvokeScript("SetText", new object[]
                {
                    ""
                });
                Console.WriteLine("Monaco cleared");
                var text = File.ReadAllText("Scripts\\" + listBox1.SelectedItem);
                var flag = listBox1.SelectedItem != null;
                var flag2 = flag;
                if (flag2)
                    MonacoEditor().Document.InvokeScript("SetText", new object[]
                    {
                        text
                    });
            }
            catch
            {
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                new Thread(() =>
                {
                    var text = File.ReadAllText("bin\\scripts\\" + listBox2.SelectedItem);
                    var flag = listBox2.SelectedItem != null;
                    var flag2 = flag;
                    if (flag2)
                    {
                        var text2 = text;
                        fastColoredTextBox1.Text = text2;

                        var text3 = text2.Split('\r', '\n').FirstOrDefault();
                        var text4 = text3.Remove(0, 2);
                        richTextBox1.Text = text4;
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
                                    pictureBox6.Image = Image.FromStream(responseStream);
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
            catch
            {
            }
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            if (label6.Text == "Selected API : ShadowCheats")
                freesex.ExecuteFromInterpreter(fastColoredTextBox1.Text);
            else if (label6.Text == "Selected API : CheatSquad")
                shitsquad.Execute(fastColoredTextBox1.Text);
            else if (label6.Text == "Selected API : MainDabAPI")
                NamedPipes.LuaPipe(fastColoredTextBox1.Text);
            else if (label6.Text == "Selected API : OxygenU API")
                oxygen.Execute(fastColoredTextBox1.Text);
            else
                MessageBox.Show("Please inject");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
            var webBrowser = new WebBrowser();
            var webClient = new WebClient();
            var tabPage = new TabPage("Tab" + intValue);
            var num = intValue + 1;
            intValue = num;
            tabPage.AutoScroll = true;
            tabPage.Controls.Add(webBrowser);
            webBrowser.Dock = DockStyle.Fill;
            visualStudioTabControl1.TabPages.Add(tabPage);
            visualStudioTabControl1.SelectedTab = tabPage;
            webBrowser.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
            var document = webBrowser.Document;
            var scriptName = "SetTheme";
            object[] args =
            {
                "Dark"
            };
            document.InvokeScript(scriptName, args);
            addBase();
            addMath();
            addGlobalNS();
            addGlobalV();
            addGlobalF();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void joinOurDiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/s9P8Ycw");
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://maindab.ga");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var webClient2 = new WebClient();
            var bytes = webClient2.DownloadData("https://pastebin.com/raw/QpwkAJS4");
            var we = Encoding.UTF8.GetString(bytes);
            MessageBox.Show(
                "MainDab Roblox Exploit\n\nMade by Main_EX#3898\nDLL by Foresaken#0254\nAnd you, the user of MainDab!\n\nRunning " +
                we + ".\ndiscord.gg/s9P8Ycw", "Credits and stuff");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("Chat"))
                backgroundWorker2.RunWorkerAsync();
            else if (Directory.Exists("Chat")) Process.Start("Chat\\Chatg\\Chat.exe");
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var client = new WebClient())
            {
                label5.Text = "Downloading chat zip";
                client.DownloadFile("https://github.com/MainDabRblx/ProjectDab/blob/master/Chat.zip?raw=true",
                    "Chat.zip");
                label5.Text = "Unzipping chat zip";
                ZipFile.ExtractToDirectory("Chat.zip", "Chat");
                label5.Text = "Starting chat";
                Process.Start("Chat\\Chatg\\Chat.exe");
                Process.Start("Chat\\Chatg\\Chat.exe");
                File.Delete("Chat.zip");
                label5.Text = "Waiting for commands...";
            }
        }

        private void CheatSquad_DoWork(object sender, DoWorkEventArgs e)
        {
            var webClient2 = new WebClient();
            var bytes = webClient2.DownloadData("https://pastebin.com/raw/CqYKJzcv");
            var we = Encoding.UTF8.GetString(bytes);
            shitsquad.Attach();
            label5.Text = "Injecting CheatSquad API...";
            Thread.Sleep(5000);
            label5.Text = "Injection complete";
            Thread.Sleep(1000);
            label5.Text = "Waiting for commands...";
            Thread.Sleep(3000);
            shitsquad.Execute(we);
        }

        private void ShadowCheats_DoWork(object sender, DoWorkEventArgs e)
        {
            var webClient2 = new WebClient();
            var bytes = webClient2.DownloadData("https://pastebin.com/raw/CqYKJzcv");
            var we = Encoding.UTF8.GetString(bytes);
            freesex.LoadIntoRoblox();
            label5.Text = "Injecting ShadowCheats...";
            Thread.Sleep(5000);
            label5.Text = "Injection complete";
            Thread.Sleep(1000);
            label5.Text = "Waiting for commands...";
            Thread.Sleep(3000);
            freesex.ExecuteFromInterpreter(we);
        }

        private void MainDabAPI_DoWork(object sender, DoWorkEventArgs e)
        {
            var webClient2 = new WebClient();
            var bytes = webClient2.DownloadData("https://pastebin.com/raw/CqYKJzcv");
            var we = Encoding.UTF8.GetString(bytes);
            label5.Text = "Injection in progress...";
            Functions.Inject();
            Thread.Sleep(3000);
            label5.Text = "Waiting for commands...";
            Thread.Sleep(3000);
            NamedPipes.LuaPipe(we);
        }

        private void OxygenU_DoWork(object sender, DoWorkEventArgs e)
        {
            var webClient2 = new WebClient();
            var bytes = webClient2.DownloadData("https://pastebin.com/raw/CqYKJzcv");
            var we = Encoding.UTF8.GetString(bytes);
            label5.Text = "Injection in progress...";
            oxygen.Attach();
            Thread.Sleep(5000);
            label5.Text = "Injection complete!";
            Thread.Sleep(2000);
            label5.Text = "Waiting for commands...";
            Thread.Sleep(3000);
            oxygen.Execute(we);
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {
        }

        public class TestColorTable : ProfessionalColorTable
        {
            public override Color MenuBorder => Color.Black; //added for changing the menu border
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var document = MonacoEditor().Document;
            var scriptName = "GetText";
            object[] array = new string[0];
            var args = array;
            var obj = document.InvokeScript(scriptName, args);
            var script = obj.ToString();
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.RestoreDirectory = true;
            savefile.InitialDirectory = Directory.GetCurrentDirectory();
            savefile.FileName = String.Format("{0}.txt", script);
            savefile.DefaultExt = "*.txt*";
            savefile.Filter = ".txt file|*.txt";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(savefile.FileName))
                    sw.WriteLine(script);
            }

        }

        private void ezHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var script = "loadstring(game:HttpGet(\"https://pastebin.com/raw/SsG8y3HA\", true))()";
            if (label6.Text == "Selected API : Oxygenu API")
                new Thread(() => { oxygen.Execute(script); }).Start();
            if (label6.Text == "Selected API : CheatSquad")
                new Thread(() => { shitsquad.Execute(script); }).Start();
            if (label6.Text == "Selected API : ShadowCheats")
                new Thread(() => { freesex.LoadIntoRoblox(script); }).Start();
            if (label6.Text == "Selected API : MainDabAPI")
                new Thread(() => { NamedPipes.LuaPipe(script); }).Start();
        }

        private void scriptHubToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("work in progress");
        }
    }
}