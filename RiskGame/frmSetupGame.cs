using System;
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
        public frmSetupGame()
        {
            CenterToScreen();
            InitializeComponent();
            pnlAI1Settings.Visible = true;
            pnlAI2Settings.Visible = false;
            btnPlayerColour.BackColor = Color.FromName(frmLogin.human.accentColour);
            rollAIs();
        }

        private void rollAIs()
        {
            //Randomly select 2 first names
            string[] names = File.ReadAllLines("names.txt");
            var ids = Enumerable.Range(1, 100).ToArray();
            Shuffle(ids);
            AI1Name = names[ids[0]];
            AI2Name = names[ids[1]];
            btnAI1Colour.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            btnAI2Colour.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));

            lbAI1Colour.Text = $"[AI1] {AI1Name}'s Colour";
            lbAI2Colour.Text = $"[AI2] {AI2Name}'s Colour";
        }

        private void trbrAISelector_Scroll(object sender, EventArgs e)
        {
            if (trbrAISelector.Value == 0)
            {
                pnlAI1Settings.Visible = false;
                pnlAI2Settings.Visible = false;
                pbStartSingleplayer.Image = Properties.Resources.StartSinglePlayerDisabled;
            }
            else if(trbrAISelector.Value == 1)
            {
                pnlAI1Settings.Visible = true;
                pnlAI2Settings.Visible = false;
                pbStartSingleplayer.Image = Properties.Resources.StartSinglePlayer;
            }
            else
            {
                pnlAI1Settings.Visible = true;
                pnlAI2Settings.Visible = true;
                pbStartSingleplayer.Image = Properties.Resources.StartSinglePlayer;
            }
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
        }

        private void pbStartMultiplayer_Click(object sender, EventArgs e)
        {
            if (trbrAISelector.Value == 2)
            {
                MessageBox.Show("You must have at most 2 AIs enabled to play Multiplayer!", "Too many players!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
