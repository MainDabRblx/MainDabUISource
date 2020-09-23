namespace ProjectMainDab
{
	// Token: 0x02000004 RID: 4
	public partial class MainEx : global::System.Windows.Forms.Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00003540 File Offset: 0x00001740
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003578 File Offset: 0x00001778
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEx));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.injectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.killRobloxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.injectMainDabAPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.injecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serversodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fPSUnlockerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleRobloxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reinstallRobloxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ironbrwObfuscatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taintDetectedExploitsCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptHubToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stationary = new System.Windows.Forms.Panel();
            this.Execute = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton9 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton13 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton12 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton11 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton10 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker7 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.stationary.SuspendLayout();
            this.Execute.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.menuStrip2);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(27, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 24);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "     -";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(536, 0);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(23, 24);
            this.bunifuFlatButton2.TabIndex = 3;
            this.bunifuFlatButton2.Text = "     -";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "     X";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(559, 0);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(26, 24);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "     X";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuTransition1.SetDecoration(this.menuStrip2, BunifuAnimatorNS.DecorationType.None);
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.pluginsToolStripMenuItem1,
            this.toolsToolStripMenuItem1,
            this.scriptHubToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(-1, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(267, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.injectToolStripMenuItem1,
            this.killRobloxToolStripMenuItem,
            this.injectMainDabAPIToolStripMenuItem});
            this.fileToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem1.Text = "File";
            this.fileToolStripMenuItem1.Click += new System.EventHandler(this.fileToolStripMenuItem1_Click);
            // 
            // injectToolStripMenuItem1
            // 
            this.injectToolStripMenuItem1.Name = "injectToolStripMenuItem1";
            this.injectToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.injectToolStripMenuItem1.Text = "Open";
            this.injectToolStripMenuItem1.Click += new System.EventHandler(this.injectToolStripMenuItem1_Click);
            // 
            // killRobloxToolStripMenuItem
            // 
            this.killRobloxToolStripMenuItem.Name = "killRobloxToolStripMenuItem";
            this.killRobloxToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.killRobloxToolStripMenuItem.Text = "Kill Roblox";
            this.killRobloxToolStripMenuItem.Click += new System.EventHandler(this.killRobloxToolStripMenuItem_Click);
            // 
            // injectMainDabAPIToolStripMenuItem
            // 
            this.injectMainDabAPIToolStripMenuItem.Name = "injectMainDabAPIToolStripMenuItem";
            this.injectMainDabAPIToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.injectMainDabAPIToolStripMenuItem.Text = "Inject MainDabAPI";
            this.injectMainDabAPIToolStripMenuItem.Click += new System.EventHandler(this.injectMainDabAPIToolStripMenuItem_Click);
            // 
            // pluginsToolStripMenuItem1
            // 
            this.pluginsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.injecToolStripMenuItem,
            this.serversodeToolStripMenuItem});
            this.pluginsToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.pluginsToolStripMenuItem1.Name = "pluginsToolStripMenuItem1";
            this.pluginsToolStripMenuItem1.Size = new System.Drawing.Size(71, 22);
            this.pluginsToolStripMenuItem1.Text = "Execution";
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.executeToolStripMenuItem.Text = "Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.executeToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // injecToolStripMenuItem
            // 
            this.injecToolStripMenuItem.Name = "injecToolStripMenuItem";
            this.injecToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.injecToolStripMenuItem.Text = "Inject";
            this.injecToolStripMenuItem.Click += new System.EventHandler(this.injecToolStripMenuItem_Click);
            // 
            // serversodeToolStripMenuItem
            // 
            this.serversodeToolStripMenuItem.Name = "serversodeToolStripMenuItem";
            this.serversodeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.serversodeToolStripMenuItem.Text = "Serverside";
            this.serversodeToolStripMenuItem.Click += new System.EventHandler(this.serversodeToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fPSUnlockerToolStripMenuItem1,
            this.multipleRobloxToolStripMenuItem1,
            this.reinstallRobloxToolStripMenuItem1,
            this.ironbrwObfuscatorToolStripMenuItem,
            this.taintDetectedExploitsCheckerToolStripMenuItem});
            this.toolsToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(75, 22);
            this.toolsToolStripMenuItem1.Text = "Extensions";
            // 
            // fPSUnlockerToolStripMenuItem1
            // 
            this.fPSUnlockerToolStripMenuItem1.Name = "fPSUnlockerToolStripMenuItem1";
            this.fPSUnlockerToolStripMenuItem1.Size = new System.Drawing.Size(247, 22);
            this.fPSUnlockerToolStripMenuItem1.Text = "FPS Unlocker";
            this.fPSUnlockerToolStripMenuItem1.Click += new System.EventHandler(this.fPSUnlockerToolStripMenuItem1_Click);
            // 
            // multipleRobloxToolStripMenuItem1
            // 
            this.multipleRobloxToolStripMenuItem1.Name = "multipleRobloxToolStripMenuItem1";
            this.multipleRobloxToolStripMenuItem1.Size = new System.Drawing.Size(247, 22);
            this.multipleRobloxToolStripMenuItem1.Text = "Multiple Roblox";
            this.multipleRobloxToolStripMenuItem1.Click += new System.EventHandler(this.multipleRobloxToolStripMenuItem1_Click);
            // 
            // reinstallRobloxToolStripMenuItem1
            // 
            this.reinstallRobloxToolStripMenuItem1.Name = "reinstallRobloxToolStripMenuItem1";
            this.reinstallRobloxToolStripMenuItem1.Size = new System.Drawing.Size(247, 22);
            this.reinstallRobloxToolStripMenuItem1.Text = "Reinstall Roblox";
            this.reinstallRobloxToolStripMenuItem1.Click += new System.EventHandler(this.reinstallRobloxToolStripMenuItem1_Click);
            // 
            // ironbrwObfuscatorToolStripMenuItem
            // 
            this.ironbrwObfuscatorToolStripMenuItem.Name = "ironbrwObfuscatorToolStripMenuItem";
            this.ironbrwObfuscatorToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.ironbrwObfuscatorToolStripMenuItem.Text = "Ironbrew Obfuscator";
            this.ironbrwObfuscatorToolStripMenuItem.Click += new System.EventHandler(this.ironbrwObfuscatorToolStripMenuItem_Click);
            // 
            // taintDetectedExploitsCheckerToolStripMenuItem
            // 
            this.taintDetectedExploitsCheckerToolStripMenuItem.Name = "taintDetectedExploitsCheckerToolStripMenuItem";
            this.taintDetectedExploitsCheckerToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.taintDetectedExploitsCheckerToolStripMenuItem.Text = "Taint / Detected exploits Checker";
            this.taintDetectedExploitsCheckerToolStripMenuItem.Click += new System.EventHandler(this.taintDetectedExploitsCheckerToolStripMenuItem_Click);
            // 
            // scriptHubToolStripMenuItem1
            // 
            this.scriptHubToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.scriptHubToolStripMenuItem1.Name = "scriptHubToolStripMenuItem1";
            this.scriptHubToolStripMenuItem1.Size = new System.Drawing.Size(75, 22);
            this.scriptHubToolStripMenuItem1.Text = "Script Hub";
            this.scriptHubToolStripMenuItem1.Click += new System.EventHandler(this.scriptHubToolStripMenuItem1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 25);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // metroButton1
            // 
            this.bunifuTransition1.SetDecoration(this.metroButton1, BunifuAnimatorNS.DecorationType.None);
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.UseSelectable = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.metroProgressBar1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label9);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(-1, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(673, 27);
            this.panel3.TabIndex = 2;
            // 
            // metroProgressBar1
            // 
            this.bunifuTransition1.SetDecoration(this.metroProgressBar1, BunifuAnimatorNS.DecorationType.None);
            this.metroProgressBar1.Location = new System.Drawing.Point(417, 2);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(193, 15);
            this.metroProgressBar1.TabIndex = 23;
            this.metroProgressBar1.Click += new System.EventHandler(this.metroProgressBar1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Location = new System.Drawing.Point(578, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "label2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(5, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Downloading ScriptHub...";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.bunifuTransition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(0, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(49, 269);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox5
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox5, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(51, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Image = global::ProjectMainDab.Properties.Resources.disc;
            this.pictureBox4.Location = new System.Drawing.Point(-1, 139);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-1, 93);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 47);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // stationary
            // 
            this.stationary.Controls.Add(this.Execute);
            this.bunifuTransition1.SetDecoration(this.stationary, BunifuAnimatorNS.DecorationType.None);
            this.stationary.Location = new System.Drawing.Point(51, 27);
            this.stationary.Margin = new System.Windows.Forms.Padding(2);
            this.stationary.Name = "stationary";
            this.stationary.Size = new System.Drawing.Size(562, 235);
            this.stationary.TabIndex = 4;
            // 
            // Execute
            // 
            this.Execute.Controls.Add(this.listBox1);
            this.bunifuTransition1.SetDecoration(this.Execute, BunifuAnimatorNS.DecorationType.None);
            this.Execute.Location = new System.Drawing.Point(0, 1);
            this.Execute.Margin = new System.Windows.Forms.Padding(2);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(562, 234);
            this.Execute.TabIndex = 2;
            this.Execute.Paint += new System.Windows.Forms.PaintEventHandler(this.Execute_Paint);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.listBox1, BunifuAnimatorNS.DecorationType.None);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(106, 234);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.metroTabPage1);
            this.bunifuTransition1.SetDecoration(this.tabControl1, BunifuAnimatorNS.DecorationType.None);
            this.tabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 23);
            this.tabControl1.Location = new System.Drawing.Point(43, 26);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 238);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.Style = MetroFramework.MetroColorStyle.White;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroTabPage1.Controls.Add(this.panel6);
            this.bunifuTransition1.SetDecoration(this.metroTabPage1, BunifuAnimatorNS.DecorationType.None);
            this.metroTabPage1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 27);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(558, 207);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Home";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.richTextBox1);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.pictureBox9);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.pictureBox8);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.pictureBox7);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label2);
            this.bunifuTransition1.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.panel6.Location = new System.Drawing.Point(110, -2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(447, 211);
            this.panel6.TabIndex = 2;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuTransition1.SetDecoration(this.richTextBox1, BunifuAnimatorNS.DecorationType.None);
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.Location = new System.Drawing.Point(302, 84);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(246, 115);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.label11.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(298, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Latest Update";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(299, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Checking for Updates...";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Red;
            this.bunifuTransition1.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.panel7.Location = new System.Drawing.Point(436, 31);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(14, 15);
            this.panel7.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(298, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Update Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Join our Discord";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox9
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox9, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(16, 112);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(18, 23);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Open a new tab";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox8
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox8, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(16, 85);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(18, 23);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Open the Script Hub";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox7
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox7, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(16, 58);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(18, 23);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "To get started, here are some shortcuts.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to MainDab!";
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
            // 
            // metroTabControl1
            // 
            this.bunifuTransition1.SetDecoration(this.metroTabControl1, BunifuAnimatorNS.DecorationType.None);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Size = new System.Drawing.Size(200, 100);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Execute";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(49, 263);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(81, 32);
            this.bunifuFlatButton3.TabIndex = 4;
            this.bunifuFlatButton3.Text = "Execute";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Clear";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(129, 263);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(81, 32);
            this.bunifuFlatButton4.TabIndex = 5;
            this.bunifuFlatButton4.Text = "Clear";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "Inject";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(209, 263);
            this.bunifuFlatButton5.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(81, 32);
            this.bunifuFlatButton5.TabIndex = 6;
            this.bunifuFlatButton5.Text = "Inject";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Open";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = null;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(289, 263);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(81, 32);
            this.bunifuFlatButton6.TabIndex = 7;
            this.bunifuFlatButton6.Text = "Open";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "Save";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = null;
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 90D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(369, 263);
            this.bunifuFlatButton7.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(81, 32);
            this.bunifuFlatButton7.TabIndex = 8;
            this.bunifuFlatButton7.Text = "Save";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "Kill Roblox";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = null;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(449, 263);
            this.bunifuFlatButton8.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(164, 32);
            this.bunifuFlatButton8.TabIndex = 9;
            this.bunifuFlatButton8.Text = "Kill Roblox";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
            // 
            // bunifuFlatButton9
            // 
            this.bunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton9.BorderRadius = 0;
            this.bunifuFlatButton9.ButtonText = "+";
            this.bunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.Iconimage = null;
            this.bunifuFlatButton9.Iconimage_right = null;
            this.bunifuFlatButton9.Iconimage_right_Selected = null;
            this.bunifuFlatButton9.Iconimage_Selected = null;
            this.bunifuFlatButton9.IconMarginLeft = 0;
            this.bunifuFlatButton9.IconMarginRight = 0;
            this.bunifuFlatButton9.IconRightVisible = true;
            this.bunifuFlatButton9.IconRightZoom = 0D;
            this.bunifuFlatButton9.IconVisible = true;
            this.bunifuFlatButton9.IconZoom = 90D;
            this.bunifuFlatButton9.IsTab = false;
            this.bunifuFlatButton9.Location = new System.Drawing.Point(587, 26);
            this.bunifuFlatButton9.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton9.Name = "bunifuFlatButton9";
            this.bunifuFlatButton9.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton9.selected = false;
            this.bunifuFlatButton9.Size = new System.Drawing.Size(23, 27);
            this.bunifuFlatButton9.TabIndex = 10;
            this.bunifuFlatButton9.Text = "+";
            this.bunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton9.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton9.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton9.Click += new System.EventHandler(this.bunifuFlatButton9_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bunifuFlatButton13);
            this.panel5.Controls.Add(this.bunifuFlatButton12);
            this.panel5.Controls.Add(this.bunifuFlatButton11);
            this.panel5.Controls.Add(this.bunifuFlatButton10);
            this.panel5.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Location = new System.Drawing.Point(224, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 102);
            this.panel5.TabIndex = 4;
            // 
            // bunifuFlatButton13
            // 
            this.bunifuFlatButton13.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton13.BorderRadius = 0;
            this.bunifuFlatButton13.ButtonText = "MainDabAPI (Testing)";
            this.bunifuFlatButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton13, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton13.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton13.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton13.Iconimage = null;
            this.bunifuFlatButton13.Iconimage_right = null;
            this.bunifuFlatButton13.Iconimage_right_Selected = null;
            this.bunifuFlatButton13.Iconimage_Selected = null;
            this.bunifuFlatButton13.IconMarginLeft = 0;
            this.bunifuFlatButton13.IconMarginRight = 0;
            this.bunifuFlatButton13.IconRightVisible = true;
            this.bunifuFlatButton13.IconRightZoom = 0D;
            this.bunifuFlatButton13.IconVisible = true;
            this.bunifuFlatButton13.IconZoom = 90D;
            this.bunifuFlatButton13.IsTab = false;
            this.bunifuFlatButton13.Location = new System.Drawing.Point(6, 101);
            this.bunifuFlatButton13.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton13.Name = "bunifuFlatButton13";
            this.bunifuFlatButton13.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton13.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton13.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton13.selected = false;
            this.bunifuFlatButton13.Size = new System.Drawing.Size(160, 32);
            this.bunifuFlatButton13.TabIndex = 13;
            this.bunifuFlatButton13.Text = "MainDabAPI (Testing)";
            this.bunifuFlatButton13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton13.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton13.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton13.Click += new System.EventHandler(this.bunifuFlatButton13_Click);
            // 
            // bunifuFlatButton12
            // 
            this.bunifuFlatButton12.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton12.BorderRadius = 0;
            this.bunifuFlatButton12.ButtonText = "SirHurt API";
            this.bunifuFlatButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton12, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton12.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton12.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton12.Iconimage = null;
            this.bunifuFlatButton12.Iconimage_right = null;
            this.bunifuFlatButton12.Iconimage_right_Selected = null;
            this.bunifuFlatButton12.Iconimage_Selected = null;
            this.bunifuFlatButton12.IconMarginLeft = 0;
            this.bunifuFlatButton12.IconMarginRight = 0;
            this.bunifuFlatButton12.IconRightVisible = true;
            this.bunifuFlatButton12.IconRightZoom = 0D;
            this.bunifuFlatButton12.IconVisible = true;
            this.bunifuFlatButton12.IconZoom = 90D;
            this.bunifuFlatButton12.IsTab = false;
            this.bunifuFlatButton12.Location = new System.Drawing.Point(6, 66);
            this.bunifuFlatButton12.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton12.Name = "bunifuFlatButton12";
            this.bunifuFlatButton12.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton12.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton12.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton12.selected = false;
            this.bunifuFlatButton12.Size = new System.Drawing.Size(160, 32);
            this.bunifuFlatButton12.TabIndex = 12;
            this.bunifuFlatButton12.Text = "SirHurt API";
            this.bunifuFlatButton12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton12.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton12.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton12.Click += new System.EventHandler(this.bunifuFlatButton12_Click);
            // 
            // bunifuFlatButton11
            // 
            this.bunifuFlatButton11.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton11.BorderRadius = 0;
            this.bunifuFlatButton11.ButtonText = "EasyExploits API";
            this.bunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.Iconimage = null;
            this.bunifuFlatButton11.Iconimage_right = null;
            this.bunifuFlatButton11.Iconimage_right_Selected = null;
            this.bunifuFlatButton11.Iconimage_Selected = null;
            this.bunifuFlatButton11.IconMarginLeft = 0;
            this.bunifuFlatButton11.IconMarginRight = 0;
            this.bunifuFlatButton11.IconRightVisible = true;
            this.bunifuFlatButton11.IconRightZoom = 0D;
            this.bunifuFlatButton11.IconVisible = true;
            this.bunifuFlatButton11.IconZoom = 90D;
            this.bunifuFlatButton11.IsTab = false;
            this.bunifuFlatButton11.Location = new System.Drawing.Point(6, 31);
            this.bunifuFlatButton11.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton11.Name = "bunifuFlatButton11";
            this.bunifuFlatButton11.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton11.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton11.selected = false;
            this.bunifuFlatButton11.Size = new System.Drawing.Size(160, 32);
            this.bunifuFlatButton11.TabIndex = 11;
            this.bunifuFlatButton11.Text = "EasyExploits API";
            this.bunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton11.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton11.TextFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton11.Click += new System.EventHandler(this.bunifuFlatButton11_Click);
            // 
            // bunifuFlatButton10
            // 
            this.bunifuFlatButton10.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bunifuFlatButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton10.BorderRadius = 0;
            this.bunifuFlatButton10.ButtonText = "     X";
            this.bunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.Iconimage = null;
            this.bunifuFlatButton10.Iconimage_right = null;
            this.bunifuFlatButton10.Iconimage_right_Selected = null;
            this.bunifuFlatButton10.Iconimage_Selected = null;
            this.bunifuFlatButton10.IconMarginLeft = 0;
            this.bunifuFlatButton10.IconMarginRight = 0;
            this.bunifuFlatButton10.IconRightVisible = true;
            this.bunifuFlatButton10.IconRightZoom = 0D;
            this.bunifuFlatButton10.IconVisible = true;
            this.bunifuFlatButton10.IconZoom = 90D;
            this.bunifuFlatButton10.IsTab = false;
            this.bunifuFlatButton10.Location = new System.Drawing.Point(144, 0);
            this.bunifuFlatButton10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton10.Name = "bunifuFlatButton10";
            this.bunifuFlatButton10.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuFlatButton10.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton10.selected = false;
            this.bunifuFlatButton10.Size = new System.Drawing.Size(27, 27);
            this.bunifuFlatButton10.TabIndex = 4;
            this.bunifuFlatButton10.Text = "     X";
            this.bunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton10.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.bunifuFlatButton10.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton10.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a DLL...";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // backgroundWorker5
            // 
            this.backgroundWorker5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker5_DoWork);
            // 
            // backgroundWorker6
            // 
            this.backgroundWorker6.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker6_DoWork);
            // 
            // backgroundWorker7
            // 
            this.backgroundWorker7.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker7_DoWork);
            // 
            // MainEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(611, 315);
            this.Controls.Add(this.bunifuFlatButton8);
            this.Controls.Add(this.bunifuFlatButton7);
            this.Controls.Add(this.bunifuFlatButton6);
            this.Controls.Add(this.bunifuFlatButton5);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.bunifuFlatButton9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.stationary);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 300);
            this.Name = "MainEx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainEx";
            this.panel1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.stationary.ResumeLayout(false);
            this.Execute.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x04000010 RID: 16
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000013 RID: 19
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;

		// Token: 0x04000014 RID: 20
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.MenuStrip menuStrip2;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.ToolStripMenuItem injectToolStripMenuItem1;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.ToolStripMenuItem killRobloxToolStripMenuItem;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem1;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.ToolStripMenuItem fPSUnlockerToolStripMenuItem1;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.ToolStripMenuItem multipleRobloxToolStripMenuItem1;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.ToolStripMenuItem reinstallRobloxToolStripMenuItem1;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.ToolStripMenuItem ironbrwObfuscatorToolStripMenuItem;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.ToolStripMenuItem taintDetectedExploitsCheckerToolStripMenuItem;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.ToolStripMenuItem scriptHubToolStripMenuItem1;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000025 RID: 37
		private global::MetroFramework.Controls.MetroButton metroButton1;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Panel stationary;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Panel Execute;

		// Token: 0x0400002B RID: 43
		private global::MetroFramework.Controls.MetroTabControl tabControl1;

		// Token: 0x0400002C RID: 44
		private global::MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;

		// Token: 0x0400002D RID: 45
		private global::MetroFramework.Controls.MetroTabControl metroTabControl1;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x0400002F RID: 47
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;

		// Token: 0x04000030 RID: 48
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;

		// Token: 0x04000031 RID: 49
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;

		// Token: 0x04000032 RID: 50
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;

		// Token: 0x04000033 RID: 51
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;

		// Token: 0x04000034 RID: 52
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;

		// Token: 0x04000035 RID: 53
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton9;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x04000037 RID: 55
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton12;

		// Token: 0x04000038 RID: 56
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton11;

		// Token: 0x04000039 RID: 57
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton10;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400003D RID: 61
		private global::System.ComponentModel.BackgroundWorker backgroundWorker1;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400003F RID: 63
		private global::System.ComponentModel.BackgroundWorker backgroundWorker2;

		// Token: 0x04000040 RID: 64
		private global::System.ComponentModel.BackgroundWorker backgroundWorker3;

		// Token: 0x04000041 RID: 65
		private global::System.ComponentModel.BackgroundWorker backgroundWorker4;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.ToolStripMenuItem injecToolStripMenuItem;

		// Token: 0x04000045 RID: 69
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.PictureBox pictureBox4;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.ToolStripMenuItem serversodeToolStripMenuItem;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton13;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.Windows.Forms.ToolStripMenuItem injectMainDabAPIToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker6;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker7;
    }
}
