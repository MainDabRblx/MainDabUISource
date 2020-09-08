using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AltAccountGent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            WebClient webClient2 = new WebClient();
            webClient2.DownloadFile("https://raw.githubusercontent.com/MainDabRblx/ProjectDab/master/no.txt", "stuff.txt");
            var fileName = "stuff.txt";
            var file = File.ReadLines(fileName).ToList();
            int count = file.Count();
            Random rnd = new Random();
            int skip = rnd.Next(0, count);
            string line = file.Skip(skip).First();
            string final = line.Replace(":", "\nPassword : ");

            richTextBox1.Text = ("Username : " + final);
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;


            File.Delete("stuff.txt");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Main_EX#3898\nJoin my discord at discord.io/maindab", "Credits");

        }
    }
}
