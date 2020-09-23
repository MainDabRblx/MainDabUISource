using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMainDab
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();


        }

        private void Loading_Load(object sender, EventArgs e)
        {
            this.backgroundWorker1.RunWorkerAsync();
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Size = new Size(0, 0);


            System.Threading.Thread.Sleep(100);//To pause the execution for sometime.
            this.Size = new Size(100, 100);
            this.CenterToScreen();
            System.Threading.Thread.Sleep(100);//To pause the execution for sometime.
            this.Size = new Size(200, 200);
            this.CenterToScreen();
            System.Threading.Thread.Sleep(100);//To pause the execution for sometime.
            this.Size = new Size(300, 250);
            this.CenterToScreen();
            System.Threading.Thread.Sleep(100);//To pause the execution for sometime.
            this.Size = new Size(400,292);
            this.CenterToScreen();
            System.Threading.Thread.Sleep(100);//To pause the execution for sometime.

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
