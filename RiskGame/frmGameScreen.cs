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
    public partial class frmGameScreen : Form
    {
        int pauseShown = 1;
        public static Game Game = frmSetupGame.Game;
        public static Plys Pl2 = frmSetupGame.Player2;
        public static Plys Pl3 = frmSetupGame.Player3;
        public frmGameScreen()
        {
            InitializeComponent();
        }

        private void frmGameScreen_Load(object sender, EventArgs e)
        {
            if(!frmLogin.human.DEBUGSkipToGame)
                Application.OpenForms["frmDashboard"].Close();
            int AICount = Game.AICount;
            int OthersCount = Game.OthersCount;
            int playerCount = AICount + OthersCount;
            Game.currentPlayer = 0;
            pnlPause.Location = new Point(-455, 0);

            
            Game.calcPlayers();
            new frmPlayerSwapper().Show();

            Region[] regions = new Region[25];
            string[] allRegionData = File.ReadAllLines("regions.conf");
            for(int i = 0; i<File.ReadLines("regions.conf").Count(); i++)
            {
                //regions[i] = new Region();
            }

            pnlBase.BackColor = Color.FromArgb(153, 220, 243);
            
        }

        private void lbGamePaused_Click(object sender, EventArgs e)
        {

        }

        private void frmGameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                pauseShown++;
                if (pauseShown % 2 == 0)
                {
                    //Pause
                    AnimatePauseScreen(0);
                }
                else
                {
                    //Unpause
                    AnimatePauseScreen(1);
                }
            }
        }

        private void AnimatePauseScreen(int direction)
        {
            int currentState = Game.state;
            //Default location: -455,0
            //Paused location: 0,0

            if (direction == 0)
            {
                //Pause
                Game.state = 4;
                lbGamePaused.Visible = true;
                int xCurrent = pnlPause.Location.X;
                int animateSpeed = 5;
                for(int i = 0; i < (455/animateSpeed); i++)
                {
                    pnlPause.Location = new Point(xCurrent + (Convert.ToInt32(animateSpeed) * i), 0);
                    pnlPause.Refresh();
                }
            }
            else
            {
                //Unpause
                Game.state = currentState;
                int xCurrent = pnlPause.Location.X;
                int animateSpeed = 5;
                for (int i = 0; i < (455 / animateSpeed); i++)
                {
                    pnlPause.Location = new Point(xCurrent - (Convert.ToInt32(animateSpeed) * i), 0);
                    pnlPause.Refresh();
                }
                lbGamePaused.Visible = false;
            }
        }

        private void lbPauseResume_Click(object sender, EventArgs e)
        {
            PauseAction(0);
        }

        private void lbPauseQuit_Click(object sender, EventArgs e)
        {
            PauseAction(4);
        }

        private void pnlPause_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PauseAction(int ID)
        {
            switch(ID)
            {
                case 0:
                    //Resume
                    pauseShown++;
                    AnimatePauseScreen(1);
                    break;
                case 1:
                    //Invite
                    //Idea: Allow the user to substitute in (a) real player(s) in place of (an|both) AI(s).
                    MessageBox.Show("Invite");
                    break;
                case 2:
                    //Overview
                    //Idea: Maybe show the Player Swapping screen without changing who's turn it is, to show the player's current status,
                    //e.g. how many troops they have, how many regions they control, etc., since this was going to be shown here anyway.
                    MessageBox.Show("Overview");
                    break;
                case 3:
                    //Settings
                    MessageBox.Show("Settings");
                    break;
                case 4:
                    //Quit
                    if (MessageBox.Show("Are you sure you want to Quit?\r\n\r\nNone of your progress will be saved!\r\n\r\nClick Yes to confirm, click No to return to the game.", "Are you sure you want to Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Hide();
                        new frmDashboard().Show();
                    }
                    else
                    {
                        pauseShown++;
                        AnimatePauseScreen(1);
                    }
                    break;
            }
        }
        private void PauseMouseAction(PictureBox pb, Image i)
        {
            pb.Image = i;
        }

        private bool IsClose(Color trg, Color what)
        {
            bool valid = false;

            var rDist = Math.Abs(trg.R - what.R);
            var gDist = Math.Abs(trg.G - what.G);
            var bDist = Math.Abs(trg.B - what.B);

            //Lowering threshold leads to more tolerancy
            if (rDist + gDist + bDist < 10)
            {
                valid = true;
            }

            return valid;
        }

        //Flood Fill Algorithm
        private void FloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            Queue<Point> pixels = new Queue<Point>();
            targetColor = bmp.GetPixel(pt.X, pt.Y);
            pixels.Enqueue(pt);

            while (pixels.Count > 0)
            {
                Point a = pixels.Dequeue();
                if (a.X < bmp.Width && a.X > 0 &&
                        a.Y < bmp.Height && a.Y > 0)//make sure we stay within bounds
                {
                    if (IsClose(bmp.GetPixel(a.X, a.Y), targetColor))
                    {
                        bmp.SetPixel(a.X, a.Y, replacementColor);
                        pixels.Enqueue(new Point(a.X - 1, a.Y));
                        pixels.Enqueue(new Point(a.X + 1, a.Y));
                        pixels.Enqueue(new Point(a.X, a.Y - 1));
                        pixels.Enqueue(new Point(a.X, a.Y + 1));
                        pbBase.Refresh();
                    }
                }
            }
            pbBase.Refresh(); //refresh our main picture box
            return;
        }

        private void FloodFillSpeed(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            targetColor = Color.White;

            Queue<Point> pixels = new Queue<Point>();

            pixels.Enqueue(pt);
            while (pixels.Count != 0)
            {
                Point temp = pixels.Dequeue();
                int y1 = temp.Y;
                while (y1 >= 0 && IsClose(bmp.GetPixel(temp.X, y1), targetColor))
                {
                    y1--;
                }
                y1++;
                bool spanLeft = false;
                bool spanRight = false;
                while (y1 < bmp.Height && IsClose(bmp.GetPixel(temp.X, y1), targetColor))
                {
                    bmp.SetPixel(temp.X, y1, replacementColor);
                    pbBase.Refresh();

                    if (!spanLeft && temp.X > 0 && IsClose(bmp.GetPixel(temp.X, y1), targetColor))
                    {
                        pixels.Enqueue(new Point(temp.X - 1, y1));
                        spanLeft = true;
                    }
                    else if (spanLeft && temp.X - 1 == 0 && IsClose(bmp.GetPixel(temp.X, y1), targetColor))
                    {
                        spanLeft = false;
                    }
                    if (!spanRight && temp.X < bmp.Width - 1 && IsClose(bmp.GetPixel(temp.X, y1), targetColor))
                    {
                        pixels.Enqueue(new Point(temp.X + 1, y1));
                        spanRight = true;
                    }
                    else if (spanRight && temp.X < bmp.Width - 1 && IsClose(bmp.GetPixel(temp.X, y1), targetColor))
                    {
                        spanRight = false;
                    }
                    y1++;
                }

            }
            pbBase.Refresh();

        }

        private void pnlPauseResume_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseResume, Properties.Resources.PlayButtonHover);
        }

        private void pnlPauseResume_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseResume, Properties.Resources.PlayButtonDefault);
        }

        private void lbPauseResume_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseResume, Properties.Resources.PlayButtonHover);
        }

        private void lbPauseResume_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseResume, Properties.Resources.PlayButtonDefault);
        }

        private void pbPauseResume_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseResume, Properties.Resources.PlayButtonHover);
        }

        private void pbPauseResume_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseResume, Properties.Resources.PlayButtonDefault);
        }

        private void pnlPauseInvite_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseInvite, Properties.Resources.InviteButtonHover);
        }

        private void pnlPauseInvite_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseInvite, Properties.Resources.InviteButtonDefault);
        }

        private void bPauseInvite_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseInvite, Properties.Resources.InviteButtonHover);
        }

        private void bPauseInvite_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseInvite, Properties.Resources.InviteButtonDefault);
        }

        private void pbPauseInvite_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseInvite, Properties.Resources.InviteButtonHover);
        }

        private void pbPauseInvite_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseInvite, Properties.Resources.InviteButtonDefault);
        }

        private void pnlPauseOverview_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseOverview, Properties.Resources.OverviewButtonHover);
        }

        private void pnlPauseOverview_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseOverview, Properties.Resources.OverviewButtonDefault);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseOverview, Properties.Resources.OverviewButtonHover);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseOverview, Properties.Resources.OverviewButtonDefault);
        }

        private void pbPauseOverview_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseOverview, Properties.Resources.OverviewButtonHover);
        }

        private void pbPauseOverview_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseOverview, Properties.Resources.OverviewButtonDefault);
        }

        private void pnlPauseSettings_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseSettings, Properties.Resources.SettingsButtonHover);
        }

        private void pnlPauseSettings_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseSettings, Properties.Resources.SettingsButtonDefault);
        }

        private void lbPauseSettings_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseSettings, Properties.Resources.SettingsButtonHover);
        }

        private void lbPauseSettings_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseSettings, Properties.Resources.SettingsButtonDefault);
        }

        private void pbPauseSettings_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseSettings, Properties.Resources.SettingsButtonHover);
        }

        private void pbPauseSettings_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseSettings, Properties.Resources.SettingsButtonDefault);
        }

        private void pnlPauseQuit_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseQuit, Properties.Resources.QuitButtonHover);
        }

        private void pnlPauseQuit_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseQuit, Properties.Resources.QuitButtonDefault);
        }

        private void lbPauseQuit_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseQuit, Properties.Resources.QuitButtonHover);
        }

        private void lbPauseQuit_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseQuit, Properties.Resources.QuitButtonDefault);
        }

        private void pbPauseQuit_MouseEnter(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseQuit, Properties.Resources.QuitButtonHover);
        }

        private void pbPauseQuit_MouseLeave(object sender, EventArgs e)
        {
            PauseMouseAction(pbPauseQuit, Properties.Resources.QuitButtonDefault);
        }

        private void pbPauseQuit_Click(object sender, EventArgs e)
        {
            PauseAction(4);
        }

        private void pnlPauseQuit_Click(object sender, EventArgs e)
        {
            PauseAction(4);
        }

        private void pnlPauseSettings_Click(object sender, EventArgs e)
        {
            PauseAction(3);
        }

        private void lbPauseSettings_Click(object sender, EventArgs e)
        {
            PauseAction(3);
        }

        private void pbPauseSettings_Click(object sender, EventArgs e)
        {
            PauseAction(3);
        }

        private void pnlPauseOverview_Click(object sender, EventArgs e)
        {
            PauseAction(2);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PauseAction(2);
        }

        private void pbPauseOverview_Click(object sender, EventArgs e)
        {
            PauseAction(2);
        }

        private void pnlPauseInvite_Click(object sender, EventArgs e)
        {
            PauseAction(1);
        }

        private void bPauseInvite_Click(object sender, EventArgs e)
        {
            PauseAction(1);
        }

        private void pbPauseInvite_Click(object sender, EventArgs e)
        {
            PauseAction(1);
        }

        private void pnlPauseResume_Click(object sender, EventArgs e)
        {
            PauseAction(0);
        }

        private void pbPauseResume_Click(object sender, EventArgs e)
        {
            PauseAction(0);
        }

        private void pnlBase_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlBase_MouseDown(object sender, MouseEventArgs e)
        {
            

        }

        private void pbBase_Click(object sender, EventArgs e)
        {

        }

        private void pbBase_MouseDown(object sender, MouseEventArgs e)
        {
            Point cursorPos = new Point(e.X, e.Y);
            //MessageBox.Show(string.Format("X: {0} Y: {1}", cursorPos.X, cursorPos.Y));
            //Color change = Color.FromName(frmLogin.human.accentColour);
            FloodFill((Bitmap)pbBase.Image, cursorPos, Color.White, Color.MediumPurple);
        }
    }
}
