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
        int secretMode = 0;
        //if secretMode is even, uncheck the checkbox, otherwise, check it.

        bool singleplayerSelected = false;
        bool multiplayerSelected = frmLogin.human.multiplayerSelected;
        string other1Name;
        string other2Name;
        int AICount = 0;

        public static Plys Player2 = new Plys();
        public static Plys Player3 = new Plys();
        public static Game Game = new Game();
        public frmSetupGame()
        {
            CenterToScreen();
            InitializeComponent();
            multiplayerSelected = frmLogin.human.multiplayerSelected;
            btnPlayerColour.BackColor = Color.FromName(frmLogin.human.accentColour);
            pbSecretMode.Image = Properties.Resources.Tutorial_Checkbox;
            multiCheck();
        }

        private void multiCheck()
        {
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

                lbPlayerColour.Visible = false;
                btnPlayerColour.Visible = false;
                pnlSecretMode.Visible = false;
                panel1.Location = new Point(12, 77);

                pbStartMultiplayer.Image = Properties.Resources.StartGameButton;
                pnlAI1Settings.Visible = false;
                pnlAI2Settings.Visible = false;
                pnlHuman2Controls.Visible = true;
                pnlHuman3Controls.Visible = true;
                trbrAISelector.Maximum = 1;
                lbSelect1.Visible = false;
                lbSelect0.Text = "1";
                lbSelect2.Text = "2";
                //pbStartSingleplayer.Image = null;
                pnlDice.Visible = false;
                btnH2Colour.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                btnH3Colour.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
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
            //Randomly select 2 colours
            
            //Repeat random colour selection for the AI until they are sufficiently different from each other so the user can tell them apart.
            //Also change them if they are too close to the user's colour.
            do
            {
                btnH2Colour.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                btnH3Colour.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            } while (ColorsAreClose(btnAI1Colour.BackColor, btnAI2Colour.BackColor, 300) || ColorsAreClose(btnAI1Colour.BackColor, Color.FromName(frmLogin.human.accentColour), 100) || ColorsAreClose(btnAI2Colour.BackColor, Color.FromName(frmLogin.human.accentColour), 100));

            txtH2.Text = other1Name;
            txtH3.Text = other2Name;
        }

        private void trbrAISelector_Scroll(object sender, EventArgs e)
        {
            
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

        private void gameStart(int AIs, int Others, Color Colour, string Username)
        {
            frmSetupGame.Game.AICount = AIs;
            frmSetupGame.Game.OthersCount = Others;
            int i1 = rnd.Next(1, 6);
            string a1 = "/avatars/default/default" + i1 + ".jpg";
            string c1 = Convert.ToString(Colour);
            if (AIs == 1)
            {
                Player2 = new Plys(false, Username, c1, AIs, Others, a1);
            }
        }
        private void gameStart(int AIs, int Others, Color Colour1, string Username1, Color Colour2, string Username2)
        {
            string c1 = Convert.ToString(Colour1);
            string c2 = Convert.ToString(Colour2);
            int i1 = rnd.Next(1, 6);
            string a1 = "/avatars/default/default" + i1 + ".jpg";
            int i2 = rnd.Next(1, 6);
            string a2 = "/avatars/default/default" + i2 + ".jpg";
            frmSetupGame.Game.AICount = AIs;
            frmSetupGame.Game.OthersCount = Others;
            if (AIs > 0)
            {
                Player2 = new Plys(false, Username1, c1, AIs, Others, a1);
            }
            if (AIs == 2)
            {
                Player3 = new Plys(false, Username2, c2, AIs, Others, a2);
            }

            if (AIs == 0 && Others > 0)
            {
                Player2 = new Plys(true, Username1, c1, AIs, Others, a1);
            }
            else
            {
                Player3 = new Plys(true, Username2, c2, AIs, Others, a2);
            }
        }
        private void pbStartSingleplayer_Click(object sender, EventArgs e)
        {
            if (trbrAISelector.Value == 0)
            {
                MessageBox.Show("You must have at least 1 AI enabled to play Singleplayer!", "AI required!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (trbrAISelector.Value == 1)
            {
                //Start game with 1 AI and no other real humans.
                gameStart(1, 0, btnAI1Colour.BackColor, AI1Name);
                Hide();
                new frmGameScreen().Show();
            }
            else
            {
                //Start game with 2 AIs and no other real humans.
                gameStart(2, 0, btnAI1Colour.BackColor, AI1Name, btnAI2Colour.BackColor, AI2Name);
                Hide();
                new frmGameScreen().Show();
            }
        }

        private void pbStartMultiplayer_Click(object sender, EventArgs e)
        {
            if (multiplayerSelected && (AICount + trbrAISelector.Value) <= 3)
            {
                if (trbrAISelector.Value == 0)
                {
                    gameStart(1, 1, btnAI1Colour.BackColor, AI1Name, btnH2Colour.BackColor, txtH2.Text);
                    Hide();
                    new frmGameScreen().Show();
                }
                else if (trbrAISelector.Value == 1)
                {
                    gameStart(0, 2, btnH2Colour.BackColor, txtH2.Text, btnH3Colour.BackColor, txtH3.Text);
                    Hide();
                    new frmGameScreen().Show();
                }
            }
            else
            {
                //MessageBox.Show("You have selected 2 AIs and 2 others! \r\nThis game only supports 3 total players.\r\nPlease adjust your number of others, or AIs\r\nby clicking the back button.", "Too many players!");
            }

            if (!multiplayerSelected)
            {
                if (trbrAISelector.Value == 2)
                {
                    MessageBox.Show("You must have at most 1 AI enabled to play Multiplayer!", "Too many players!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AICount = trbrAISelector.Value;
                    //Start game with either 2 or 1 real humans and no AIs or 1 real human and 1 AI.
                    frmLogin.human.multiplayerSelected = true;
                    multiplayerSelected = true;
                    //Hide();
                    //new frmSetupGame().Show();
                    multiCheck();
                    this.Controls.Clear();
                    multiCheck();
                    this.InitializeComponent();
                    multiCheck();
                }
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

        private void trbrAISelector_ValueChanged(object sender, EventArgs e)
        {
            if (!multiplayerSelected)
            {
                rollAIs();
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
    }
}
