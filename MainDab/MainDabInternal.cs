using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDab
{
    public partial class MainDabInternal : Form
    {
        static string getString(char[] arr)
        {
            // string() is a used to  
            // convert the char array 
            // to string 
            string s = new string(arr);

            return s;
        }
        public MainDabInternal()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]

        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.LimeGreen, e.ClipRectangle);
        }
        private void MainDabInternal_Load(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("RobloxPlayerBeta");
            if (pname.Length == 0)
            {
                MessageBox.Show("Please open Roblox first idiot");
                this.Hide();
                this.Close();
            }
            else
            {
                foreach (Process p in pname)
                {
                    int ha = p.Id;
                    Process process = Process.GetProcessById(ha);

                    process.WaitForInputIdle();

                    SetParent(process.MainWindowHandle, this.Handle);
                }
            }
            //this.BackColor = Color.Transparent;
           // this.TransparencyKey = Color.LimeGreen;
        }
    }
}
