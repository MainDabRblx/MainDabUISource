using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainDab
{
    public partial class Credits : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Credits()
        {
            InitializeComponent();
            DevelopmentView.Visible = true;
            ModPanel.Visible = false;
            LibariesUsed.Visible = false;
            ToolsUsed.Visible = false;
            Other.Visible = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            base.Hide();
        }

        private void Credits_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Other_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DevelopmentView.Visible = true;
            ModPanel.Visible = false;
            LibariesUsed.Visible = false;
            ToolsUsed.Visible = false;
            Other.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DevelopmentView.Visible = false;
            ModPanel.Visible = true;
            LibariesUsed.Visible = false;
            ToolsUsed.Visible = false;
            Other.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DevelopmentView.Visible = false;
            ModPanel.Visible = false;
            LibariesUsed.Visible = true;
            ToolsUsed.Visible = false;
            Other.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DevelopmentView.Visible = false;
            ModPanel.Visible = false;
            LibariesUsed.Visible = false;
            ToolsUsed.Visible = true;
            Other.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DevelopmentView.Visible = false;
            ModPanel.Visible = false;
            LibariesUsed.Visible = false;
            ToolsUsed.Visible = false;
            Other.Visible = true;
        }
    }
}
