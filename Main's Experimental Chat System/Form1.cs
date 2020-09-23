using Discord;
using Discord.Gateway;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Main_EX#3898 @ discord.io/maindab
namespace Main_s_Experimental_Chat_System
{
    // PLEASE MAKE SURE TO USE A USER TOKEN. THIS DOES NOT SUPPORT BOTS.
    public partial class Form1 : Form
    {
        int isopen = 0; // Varible for the settings tab below
        string yesnt = ""; // This variable is for saving the previous chat
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(365, 207); // Puts it back to original size
            try // If thing.txt is found. Thing.txt is used to store messages that are recieved.
            {
                if (File.Exists("thing.txt"))
                {
                    File.Delete("thing.txt"); // Noone wants to see the old text
                }
            }
            catch // Just so the user won't see any errors.
            {

            }
            if (!File.Exists("thing.txt")) // if thing.txt dosen't exist
            {

                File.Create("thing.txt"); // create it

            }
            if (!File.Exists("username.txt")) // if username.txt dosen't exist. username.txt is for storing the username of the user
            {

                File.Create("username.txt");
                File.WriteAllText("username.txt", "User"); // write to file

            }
            yesnt = richTextBox1.Text; // saving previous data
            string sdafnasjkdfasdf = File.ReadAllText("username.txt"); // creates a varible for annoncing someone has joined
            DiscordClient client = new DiscordClient("tokenhere"); // paste ur token here. must be a user token.
            DiscordMessage message = client.SendMessage(757426913643069490, sdafnasjkdfasdf + " is now on!", false); // tells eveyrone someone is on
            // change 757426913643069490 with ur channel id
            try
            {
                this.backgroundWorker1.RunWorkerAsync(); // runs some code

                timer2.Enabled = true; // starts another thing
            }
            catch
            {
            }

        }
        string rich = "";

        private static void client_OnMessageReceived(DiscordSocketClient client, MessageEventArgs args) // When the appplications revieces a message. suggested that the user you are logged into can only see one channel.
        {
            string someText = (args.Message.Content); // text recieved
            string oldtext = ""; // old text
            System.Threading.Thread.Sleep(100);
            if (oldtext == someText) // here i attempted to make it check if the sane nessage has been sent
            {
                DiscordMessage message = client.SendMessage(757426913643069490, "Hello, World", false); // ignore this code.
                message.Delete();
                message.Delete();
            }
            else
            {
                File.WriteAllText("thing.txt", someText); // else write to the text
                oldtext = someText;
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) // auto scoll so you don't have to always scroll
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }

        private void timer2_Tick(object sender, EventArgs e) // loop code

        {
            try // just so user dosent see errors
            {
                yesnt = richTextBox1.Text;// saves message logs 
                string readText = File.ReadAllText("thing.txt"); // thing.txt contains the most recent message
                if (rich == readText)
                {
                    // suggested you don't do anything here, this just checks if a user sent the same thing again. do not remove this part!
                }
                else
                {
                    richTextBox1.Text = ""; // clear textbox
                    richTextBox1.Text = (yesnt + "\n" + readText); // previous message logs + new line + new text
                    rich = readText; // saves the current recieved message as a string
                }
            }
            catch
            {

            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) // just so the client dosen't lag
        {
            DiscordSocketClient client = new DiscordSocketClient();
            client.OnMessageReceived += client_OnMessageReceived; // check for messages
            client.Login("tokenhere"); // put ur user token here
        }

        private void label2_Click(object sender, EventArgs e) // when x pressed
        {
            string sdafnasjkdfasdf = File.ReadAllText("username.txt"); // reads for username
            DiscordClient client = new DiscordClient("tokenhere"); // put ur user token here
            DiscordMessage message = client.SendMessage(757426913643069490, sdafnasjkdfasdf + " has left.", false); // tellls people someone left
            // change 757426913643069490 with ur channel id
            Environment.Exit(0); // obvious
        }

        private void label3_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized; // obvious 
        }

        private void label4_Click(object sender, EventArgs e) // send button, alternatively the user can press enter to send
        {
            try // just so user dosen't see error
            {
                this.backgroundWorker2.RunWorkerAsync(); // run code
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e) // nothing here
        {

        }

        private void label6_Click(object sender, EventArgs e) // changing username button
        {
            if (textBox2.Text == "Type your username here") // just so it isn't blank
            {
                MessageBox.Show("Please enter a vaild username!", "MainDab Chat System BETA");
            }
            else if (textBox2.Text == "") // just so it isn't blank
            {
                MessageBox.Show("Please enter a vaild username!", "MainDab Chat System BETA");
            }
            else // success
            {
                File.WriteAllText("username.txt", textBox2.Text);
            }
        }

        private void label5_Click(object sender, EventArgs e) // settings bar
        {
            if (isopen == 0) // if the setings is closed
            {
                this.Size = new Size(365, 247);

                isopen = 1; // sets the settings to open
            }
            else // if isopen!= 0 then (if already open)
            {
                this.Size = new Size(365, 207); // then close
                isopen = 0; // sets varible to show its closed
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ""; // clear chat, idk why you would though.
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            string no = File.ReadAllText("username.txt"); // read username
            DiscordClient client = new DiscordClient("tokenhere"); // paste ur user token here
            if (textBox1.Text == "") // just so user dosen't send blank...
            {
                MessageBox.Show("Please enter a message!", "MainDab Chat System BETA"); // tells them
            }
            else if (textBox1.Text == "Type your message in here..") // also just to make sure they don't send the example message
            {
                MessageBox.Show("Please enter a message!", "MainDab Chat System BETA"); // tells them, be user friendly!
            }
            else
            {
                DiscordMessage message = client.SendMessage(757426913643069490, ("[" + no + "] " + textBox1.Text + "\n"), false); // sends message to discord
                // change 757426913643069490 with ur channel id
                textBox1.Text = ""; // clears textbox
            }
        }

        private void e(object sender, KeyEventArgs e) // when the enter key is pressed, so the send message dosen't have to be clicked all the time
        {
            if (e.KeyCode == Keys.Return) // if enter key pressed
            {

                try
                {
                    this.backgroundWorker2.RunWorkerAsync(); // run code

                }
                catch
                {

                }
                e.Handled = true; // so no error sounds play while clicked.
                e.SuppressKeyPress = true;
            }
        }
    }
}
// that is pretty much it, i don't mind if you skid it but just make sure to give credits.
