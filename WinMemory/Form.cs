using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.IO;
using WinMemory.Resources;

namespace WinMemory
{
    public partial class frmMain : Form
    {
        private List<Button> gameButtons;
        private Memory theGame;
        /*
        private Assembly _assembly;
        Stream _imageStream;
        */
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // intial GUI settings
            newGameToolStripMenuItem.Enabled = false;

            picbox_GameSize.BackgroundImage = (Image)imagelist_GameSize.Images[3];
            radBtn_Large.Checked = true;
            /*
            try
            {
                _assembly = Assembly.GetExecutingAssembly();
                _imageStream = _assembly.GetManifestResourceStream("WinMemory.Resources.bild1.jpg");
            }
            catch
            {
                MessageBox.Show("Error while trying to access embedded resources!");
            }
             */
        }

        void NewGame()
        {
            
            // Dispose game object if not null before creating new one
            if (theGame != null)
            {
                theGame.Dispose();
            }

            int row = 0;
            int col = 0;

            // Determine game matris
            if (radBtn_Mini.Checked == true)
            { // Mini
                row = 2;
                col = 3;
            } else if (radBtn_Small.Checked == true) { // Small
                row = 3;
                col = 4;
            } else if (radBtn_Medium.Checked == true) { // Medium
                row = 4;
                col = 5;
            } else { // Large
                row = 5;
                col = 6;
            }

            gameButtons = new List<Button>();

            theGame = new Memory(row * col,this);

            int count = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    gameButtons.Add(new Button());
                    //gameButtons[count].Text = "Test" + count.ToString();
                    gameButtons[count].Name = "button" + count.ToString();
                    gameButtons[count].Click += new EventHandler(GameButtons_Click);
                    gameButtons[count].Location = new Point(20 + (j * 85), 40 + (i * 85));
                    gameButtons[count].Size = new Size(80, 80);
                    gameButtons[count].Visible = true;

                    //string test = theGame.GetButtonPicture(gameButtons[count].Name);
                    gameButtons[count].BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("defaultbild");
                    //gameButtons[count].BackgroundImage = new Bitmap(_imageStream);
                    //gameButtons[count].BackgroundImage = Properties.Resources.bild1;
                    //gameButtons[count].BackColor = Color.Gainsboro;
                    //gameButtons[count].Enabled = false;
                    Controls.Add(gameButtons[count]);
                    count++;
                }
            }

            newGameToolStripMenuItem.Enabled = true;
        }


        /// <summary>
        /// Called with Menu -> New Game so the game settings layer can be viewed
        /// </summary>
        void ButtonVisibility(bool state)
        {
            foreach (Button btn in gameButtons)
            {
                btn.Visible = false;
            }
        }

        void GameSettingsVisibility(bool state)
        {
            switch (state)
            {
                case true:
                    {
                        grpBox_NewGame.Show();
                    }break;
                case false:
                    {
                        grpBox_NewGame.Hide();
                    }break;
            }
        }

        /// <summary>
        /// Event handler for button clicks
        /// </summary>
        /// <param name="sender">The button which were clicked</param>
        /// <param name="e">mumbojumbo</param>
        void GameButtons_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;

            theGame.ButtonClicked(currentButton.Name);
           
        }

        /// <summary>
        /// Change specific button.BackgroundImage, called from Memory class
        /// </summary>
        /// <param name="button_id"></param>
        /// <param name="picture_name"></param>
        public void ChangePicture(int button_id, string picture_name)
        {
            gameButtons[button_id].BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(picture_name);  
        }

        /// <summary>
        /// Adds score/buttonclick/matching attemp to counters.
        /// </summary>
        /// <param name="btn_click">If true add to button clicks, if false add to Matching attemp</param>
        public void AddToCounter(bool btn_click, int score)
        {
            if (btn_click)
            {
                toolStrip_ClickScore.Text = score.ToString();
            }
            else
            {
                toolStrip_Attempts.Text = score.ToString();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (theGame != null)
            {   // we cant delete what we dont have
                theGame.Dispose();
            }
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hide gameblocks and show new game settings panel
            ButtonVisibility(false);
            GameSettingsVisibility(true);
            newGameToolStripMenuItem.Enabled = false;
            btn_StartGame.Focus();

            theGame.Dispose();
            theGame = null;
            gameButtons.Clear();
            gameButtons = null;

            toolStrip_Attempts.Text = "0";
            toolStrip_ClickScore.Text = "0";
        }

        private void aboutMemoryGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.StartPosition = FormStartPosition.CenterParent;
            aboutBox.ShowDialog(this);
        }

        /// <summary>
        /// Memory game calls this function when its game over
        /// </summary>
        public void InvokeGameOver(int clicks, int matches)
        {
            DialogResult gameoverDialog = MessageBox.Show(String.Format("Congratz! You made it with {0} button clicks and {1} matching attempts :).\n Do you wanna start a new game?", clicks, matches),"Game over", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);

            if (gameoverDialog == DialogResult.Yes)
            {
                ButtonVisibility(false);
                GameSettingsVisibility(true);
                newGameToolStripMenuItem.Enabled = false;
                toolStrip_Attempts.Text = "0";
                toolStrip_ClickScore.Text = "0";
            }
            else
            { // do nothing, or terminate program?

            }

        }


        private void btn_StartGame_Click_1(object sender, EventArgs e)
        {
            grpBox_NewGame.Hide();
            NewGame();
        }

        private void radBtn_Mini_CheckedChanged(object sender, EventArgs e)
        {
            picbox_GameSize.BackgroundImage = (Image)imagelist_GameSize.Images[0];
        }

        private void radBtn_Small_CheckedChanged(object sender, EventArgs e)
        {
            picbox_GameSize.BackgroundImage = (Image)imagelist_GameSize.Images[1];
        }

        private void radBtn_Medium_CheckedChanged(object sender, EventArgs e)
        {
            picbox_GameSize.BackgroundImage = (Image)imagelist_GameSize.Images[2];
        }

        private void radBtn_Large_CheckedChanged(object sender, EventArgs e)
        {
            picbox_GameSize.BackgroundImage = (Image)imagelist_GameSize.Images[3];
        }


    }
}
