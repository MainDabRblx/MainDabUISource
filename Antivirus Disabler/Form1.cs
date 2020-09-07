using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antivirus_Disabler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Process.Start("disable.reg");
            MessageBox.Show("Click Yes to allow the values to be written to the registry.", "Disabler");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("enable.reg");
            MessageBox.Show("Click Yes to allow the values to be written to the registry.", "Disabler");
        }
    }
}
