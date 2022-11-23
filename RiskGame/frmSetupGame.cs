﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RiskGame
{
    public partial class frmSetupGame : Form
    {
        string AI1Name;
        string AI2Name;
        Random rnd = new Random();
        int secretMode = 0;
        //if secretMode is even, uncheck the checkbox, otherwise, check it.

        bool singleplayerSelected = false;
        bool multiplayerSelected = frmLogin.human.multiplayerSelected;
        public frmSetupGame()
        {
            CenterToScreen();
            InitializeComponent();
            pnlAI1Settings.Visible = true;
            pnlAI2Settings.Visible = false;
            btnPlayerColour.BackColor = Color.FromName(frmLogin.human.accentColour);
            pbSecretMode.Image = Properties.Resources.Tutorial_Checkbox;
            if (!multiplayerSelected)
            {
                lbPlayerSelectorDescription.Text = $"How many AIs would you like to play with?";
                rollAIs();
                pnlAI1Settings.Visible = true;
                pnlAI2Settings.Visible = false;
                pnlHuman2Controls.Visible = false;
                pnlHuman3Controls.Visible = false;
            }
            else
            {
                lbPlayerSelectorDescription.Text = $"How many others would you like to play with?";
                rollOthers();

                txtH2.Text = AI1Name;
                txtH3.Text = AI2Name;
                btnH2Colour.BackColor = btnAI1Colour.BackColor;
                btnH3Colour.BackColor = btnAI2Colour.BackColor;

                pbStartMultiplayer.Image = Properties.Resources.StartGameButton;
                pnlAI1Settings.Visible = false;
                pnlAI2Settings.Visible = false;
                pnlHuman2Controls.Visible = true;
                pnlHuman3Controls.Visible = true;
                trbrAISelector.Maximum = 1;
                lbSelect1.Visible = false;
                lbSelect0.Text = "1";
                lbSelect2.Text = "2";
                pbStartSingleplayer.Image = null;
                pnlDice.Visible = false;
            }  
        }

        private void rollAIs()
        {
            //Randomly select 2 first names
            string[] names = File.ReadAllLines("names.txt");
            var ids = Enumerable.Range(1, 1100).ToArray();
            //Repeat random selection until both the AI names are different from each other and from the player's username.
            do
            {
                Shuffle(ids);
                AI1Name = names[ids[0]];
                AI2Name = names[ids[1]];
            } while (AI1Name==AI2Name || AI1Name==frmLogin.human.username || AI2Name==frmLogin.human.username);

            //Repeat random colour selection for the AI until they are sufficiently different from each other so the user can tell them apart.
            //Also change them if they are too close to the user's colour.
            do
            {
                btnAI1Colour.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                btnAI2Colour.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            } while (ColorsAreClose(btnAI1Colour.BackColor, btnAI2Colour.BackColor, 300) || ColorsAreClose(btnAI1Colour.BackColor, Color.FromName(frmLogin.human.accentColour), 100) || ColorsAreClose(btnAI2Colour.BackColor, Color.FromName(frmLogin.human.accentColour), 100));

            lbAI1Colour.Text = $"[AI1] {AI1Name}'s Colour";
            lbAI2Colour.Text = $"[AI2] {AI2Name}'s Colour";
        }

        private void rollOthers()
        {
            //Randomly select 2 first names
            string[] names = File.ReadAllLines("names.txt");
            var ids = Enumerable.Range(1, 1100).ToArray();
            //Repeat random selection until both the others names are different from each other and from the player's username.
            do
            {
                Shuffle(ids);
                txtH2.Text = names[ids[0]];
                txtH3.Text = names[ids[1]];
            } while (txtH2.Text == txtH3.Text || txtH2.Text == frmLogin.human.username || txtH3.Text == frmLogin.human.username);

            //Repeat random colour selection for the AI until they are sufficiently different from each other so the user can tell them apart.
            //Also change them if they are too close to the user's colour.
            do
            {
                btnH2Colour.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                btnH3Colour.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            } while (ColorsAreClose(btnAI1Colour.BackColor, btnAI2Colour.BackColor, 300) || ColorsAreClose(btnAI1Colour.BackColor, Color.FromName(frmLogin.human.accentColour), 100) || ColorsAreClose(btnAI2Colour.BackColor, Color.FromName(frmLogin.human.accentColour), 100));

            lbAI1Colour.Text = $"[AI1] {AI1Name}'s Colour";
            lbAI2Colour.Text = $"[AI2] {AI2Name}'s Colour";
        }

        private void trbrAISelector_Scroll(object sender, EventArgs e)
        {
            if(!multiplayerSelected)
            {
                if (trbrAISelector.Value == 0)
                {
                    pnlAI1Settings.Visible = false;
                    pnlAI2Settings.Visible = false;
                    pbStartSingleplayer.Image = Properties.Resources.StartSinglePlayerDisabled;
                    pbStartMultiplayer.Image = Properties.Resources.StartMultiPlayer;
                }
                else if (trbrAISelector.Value == 1)
                {
                    pnlAI1Settings.Visible = true;
                    pnlAI2Settings.Visible = false;
                    pbStartSingleplayer.Image = Properties.Resources.StartSinglePlayer;
                    pbStartMultiplayer.Image = Properties.Resources.StartMultiPlayer;
                }
                else
                {
                    pnlAI1Settings.Visible = true;
                    pnlAI2Settings.Visible = true;
                    pbStartSingleplayer.Image = Properties.Resources.StartSinglePlayer;
                    pbStartMultiplayer.Image = Properties.Resources.StartMultiPlayerDisabled;
                }
            }
            else
            {
                if (trbrAISelector.Value == 0)
                {
                    pnlHuman2Controls.Visible = true;
                    pnlHuman3Controls.Visible = false;
                }
                else
                {
                    pnlHuman2Controls.Visible = true;
                    pnlHuman3Controls.Visible = true;
                }
            }
        }
        public bool ColorsAreClose(Color a, Color b, int threshhold)
        {

            var rDist = Math.Abs(a.R - b.R);
            var gDist = Math.Abs(a.G - b.G);
            var bDist = Math.Abs(a.B - b.B);

            if (rDist + gDist + bDist > threshhold)
                return false;

            return true;
        }

        private void frmSetupGame_Load(object sender, EventArgs e)
        {

        }

        void Shuffle(int[] arr)
        {
            Random rnd = new Random();
            for (int i = arr.Length; i > 1; i--)
            {
                int pos = rnd.Next(i);
                var x = arr[i - 1];
                arr[i - 1] = arr[pos];
                arr[pos] = x;
            }
        }

        private void pbDice_Click(object sender, EventArgs e)
        {
            rollAIs();
        }

        private void btnPlayerColour_Click(object sender, EventArgs e)
        {
            //Open the colour changer
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = btnPlayerColour.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnPlayerColour.BackColor = colorDialog.Color;
                frmLogin.human.accentColour = colorDialog.Color.Name;
            }
        }

        private void pbStartSingleplayer_Click(object sender, EventArgs e)
        {
            if (trbrAISelector.Value == 0)
            {
                MessageBox.Show("You must have at least 1 AI enabled to play Singleplayer!", "AI required!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Start game with either 1 or 2 AIs and no other real humans.
            }
        }

        private void pbStartMultiplayer_Click(object sender, EventArgs e)
        {
            if (trbrAISelector.Value == 2)
            {
                MessageBox.Show("You must have at most 2 AIs enabled to play Multiplayer!", "Too many players!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Start game with either 2 or 1 real humans and no AIs or 1 real human and 1 AI.
                frmLogin.human.multiplayerSelected = true;
                Hide();
                new frmSetupGame().Show();
            }
        }

        private void pbSecretMode_Click(object sender, EventArgs e)
        {
            secretMode++;
            if(secretMode%2 == 0)
            {
                pbSecretMode.Image = Properties.Resources.Tutorial_Checkbox;
            }
            else
            {
                pbSecretMode.Image = Properties.Resources.Tutorial_Checkbox_Checked;
            }
        }

        private void lbH2Title_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}