using MainDabWPF.Injection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDab.Classes
{
    static class MainExecution
    {
        
        public static void Execute(string script)
        {
           
            Classes.EasyExploitsAPI.Module ezclap = new Classes.EasyExploitsAPI.Module(); // EasyExploits API
            Classes.WeAreDevsAPI.ExploitAPI wrd = new Classes.WeAreDevsAPI.ExploitAPI(); // WeAreDevs API
            Classes.ShadowCheatsAPI.Module shadowcheats = new Classes.ShadowCheatsAPI.Module(); // ShadowSex API
            Process[] pname = Process.GetProcessesByName("RobloxPlayerBeta");
            if (pname.Length > 0)
            {

                if (Classes.SelectedDLL.SelectedAPI == "Selected API : MainDab LBI")
                {
                    try
                    {
                        NamedPipes.LuaPipe(script);
                    }
                    catch (Exception sexual)
                    {
                        MessageBox.Show("An error has occured, here is the error :\n\n" + sexual + "\n\nMake sure you are on a tab, and not on the script hub tab!", "Report this to Main_EX in Discord!");
                    }

                }
                else if (Classes.SelectedDLL.SelectedAPI == "Selected API : EasyExploits API")
                {
                    try
                    {
                        ezclap.ExecuteScript(script);
                    }
                    catch (Exception sexual)
                    {
                        MessageBox.Show("An error has occured, here is the error :\n\n" + sexual + "\n\nMake sure you are on a tab, and not on the script hub tab!", "Report this to Main_EX in Discord!");
                    }
                }
                else if (Classes.SelectedDLL.SelectedAPI == "Selected API : WeAreDevs")
                {
                    wrd.SendLuaScript(script);
                }
                else if (Classes.SelectedDLL.SelectedAPI == "Selected API : ShadowCheats API")
                {
                    shadowcheats.ExecuteScript(script);
                }
                else if (Classes.SelectedDLL.SelectedAPI == "Selected API : Custom")
                {
                    try
                    {
                        NamedPipes.LuaPipe(script);
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
        }

    }
}
