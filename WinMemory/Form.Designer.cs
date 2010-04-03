namespace WinMemory
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gameMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highscoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMemoryGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBox_NewGame = new System.Windows.Forms.GroupBox();
            this.picbox_GameSize = new System.Windows.Forms.PictureBox();
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.radBtn_Large = new System.Windows.Forms.RadioButton();
            this.radBtn_Medium = new System.Windows.Forms.RadioButton();
            this.radBtn_Small = new System.Windows.Forms.RadioButton();
            this.radBtn_Mini = new System.Windows.Forms.RadioButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip_ClickScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip_Attempts = new System.Windows.Forms.ToolStripStatusLabel();
            this.imagelist_GameSize = new System.Windows.Forms.ImageList(this.components);
            this.gameMenu.SuspendLayout();
            this.grpBox_NewGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_GameSize)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameMenu
            // 
            this.gameMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.gameMenu.Location = new System.Drawing.Point(0, 0);
            this.gameMenu.Name = "gameMenu";
            this.gameMenu.Size = new System.Drawing.Size(544, 24);
            this.gameMenu.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highscoresToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // highscoresToolStripMenuItem
            // 
            this.highscoresToolStripMenuItem.Name = "highscoresToolStripMenuItem";
            this.highscoresToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.highscoresToolStripMenuItem.Text = "Highscores";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMemoryGameToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMemoryGameToolStripMenuItem
            // 
            this.aboutMemoryGameToolStripMenuItem.Name = "aboutMemoryGameToolStripMenuItem";
            this.aboutMemoryGameToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.aboutMemoryGameToolStripMenuItem.Text = "About Memory Game";
            this.aboutMemoryGameToolStripMenuItem.Click += new System.EventHandler(this.aboutMemoryGameToolStripMenuItem_Click);
            // 
            // grpBox_NewGame
            // 
            this.grpBox_NewGame.Controls.Add(this.picbox_GameSize);
            this.grpBox_NewGame.Controls.Add(this.btn_StartGame);
            this.grpBox_NewGame.Controls.Add(this.radBtn_Large);
            this.grpBox_NewGame.Controls.Add(this.radBtn_Medium);
            this.grpBox_NewGame.Controls.Add(this.radBtn_Small);
            this.grpBox_NewGame.Controls.Add(this.radBtn_Mini);
            this.grpBox_NewGame.Location = new System.Drawing.Point(60, 112);
            this.grpBox_NewGame.Name = "grpBox_NewGame";
            this.grpBox_NewGame.Size = new System.Drawing.Size(401, 276);
            this.grpBox_NewGame.TabIndex = 3;
            this.grpBox_NewGame.TabStop = false;
            this.grpBox_NewGame.Text = "Game settings";
            // 
            // picbox_GameSize
            // 
            this.picbox_GameSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picbox_GameSize.Location = new System.Drawing.Point(143, 36);
            this.picbox_GameSize.Name = "picbox_GameSize";
            this.picbox_GameSize.Size = new System.Drawing.Size(200, 168);
            this.picbox_GameSize.TabIndex = 10;
            this.picbox_GameSize.TabStop = false;
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.Location = new System.Drawing.Point(143, 222);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(130, 35);
            this.btn_StartGame.TabIndex = 0;
            this.btn_StartGame.Text = "Start!";
            this.btn_StartGame.UseVisualStyleBackColor = true;
            this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click_1);
            // 
            // radBtn_Large
            // 
            this.radBtn_Large.AutoSize = true;
            this.radBtn_Large.Location = new System.Drawing.Point(35, 152);
            this.radBtn_Large.Name = "radBtn_Large";
            this.radBtn_Large.Size = new System.Drawing.Size(78, 17);
            this.radBtn_Large.TabIndex = 4;
            this.radBtn_Large.Text = "Large (5x6)";
            this.radBtn_Large.UseVisualStyleBackColor = true;
            this.radBtn_Large.CheckedChanged += new System.EventHandler(this.radBtn_Large_CheckedChanged);
            // 
            // radBtn_Medium
            // 
            this.radBtn_Medium.AutoSize = true;
            this.radBtn_Medium.Location = new System.Drawing.Point(35, 120);
            this.radBtn_Medium.Name = "radBtn_Medium";
            this.radBtn_Medium.Size = new System.Drawing.Size(88, 17);
            this.radBtn_Medium.TabIndex = 3;
            this.radBtn_Medium.Text = "Medium (4x5)";
            this.radBtn_Medium.UseVisualStyleBackColor = true;
            this.radBtn_Medium.CheckedChanged += new System.EventHandler(this.radBtn_Medium_CheckedChanged);
            // 
            // radBtn_Small
            // 
            this.radBtn_Small.AutoSize = true;
            this.radBtn_Small.Location = new System.Drawing.Point(35, 88);
            this.radBtn_Small.Name = "radBtn_Small";
            this.radBtn_Small.Size = new System.Drawing.Size(76, 17);
            this.radBtn_Small.TabIndex = 2;
            this.radBtn_Small.Text = "Small (3x4)";
            this.radBtn_Small.UseVisualStyleBackColor = true;
            this.radBtn_Small.CheckedChanged += new System.EventHandler(this.radBtn_Small_CheckedChanged);
            // 
            // radBtn_Mini
            // 
            this.radBtn_Mini.AutoSize = true;
            this.radBtn_Mini.Location = new System.Drawing.Point(35, 54);
            this.radBtn_Mini.Name = "radBtn_Mini";
            this.radBtn_Mini.Size = new System.Drawing.Size(70, 17);
            this.radBtn_Mini.TabIndex = 1;
            this.radBtn_Mini.Text = "Mini (2x3)";
            this.radBtn_Mini.UseVisualStyleBackColor = true;
            this.radBtn_Mini.CheckedChanged += new System.EventHandler(this.radBtn_Mini_CheckedChanged);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 15);
            this.toolStripStatusLabel1.Text = "Clicks:";
            // 
            // toolStrip_ClickScore
            // 
            this.toolStrip_ClickScore.Name = "toolStrip_ClickScore";
            this.toolStrip_ClickScore.Size = new System.Drawing.Size(13, 15);
            this.toolStrip_ClickScore.Text = "0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStrip_ClickScore,
            this.toolStripStatusLabel3,
            this.toolStrip_Attempts});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 482);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(544, 20);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "Attempts:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(59, 15);
            this.toolStripStatusLabel3.Text = "Attempts:";
            // 
            // toolStrip_Attempts
            // 
            this.toolStrip_Attempts.Name = "toolStrip_Attempts";
            this.toolStrip_Attempts.Size = new System.Drawing.Size(13, 15);
            this.toolStrip_Attempts.Text = "0";
            // 
            // imagelist_GameSize
            // 
            this.imagelist_GameSize.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelist_GameSize.ImageStream")));
            this.imagelist_GameSize.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelist_GameSize.Images.SetKeyName(0, "mini.png");
            this.imagelist_GameSize.Images.SetKeyName(1, "small.png");
            this.imagelist_GameSize.Images.SetKeyName(2, "medium.png");
            this.imagelist_GameSize.Images.SetKeyName(3, "large.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 502);
            this.Controls.Add(this.grpBox_NewGame);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gameMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.gameMenu;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gameMenu.ResumeLayout(false);
            this.gameMenu.PerformLayout();
            this.grpBox_NewGame.ResumeLayout(false);
            this.grpBox_NewGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_GameSize)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip gameMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highscoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMemoryGameToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBox_NewGame;
        private System.Windows.Forms.RadioButton radBtn_Large;
        private System.Windows.Forms.RadioButton radBtn_Medium;
        private System.Windows.Forms.RadioButton radBtn_Small;
        private System.Windows.Forms.RadioButton radBtn_Mini;
        private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip_ClickScore;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip_Attempts;
        private System.Windows.Forms.ImageList imagelist_GameSize;
        private System.Windows.Forms.PictureBox picbox_GameSize;
    }
}

