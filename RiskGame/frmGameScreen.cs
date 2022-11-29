using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiskGame
{
    public partial class frmGameScreen : Form
    {
        int pauseShown = 1;
        Game Game = frmSetupGame.Game;
        public frmGameScreen()
        {
            InitializeComponent();
        }

        private void frmGameScreen_Load(object sender, EventArgs e)
        {
            int AICount = frmSetupGame.Game.AICount;
            int OthersCount = frmSetupGame.Game.OthersCount;
            int playerCount = AICount + OthersCount;
            pnlPause.Location = new Point(-450, 0);

            //label4.Text = frmLogin.human.username + frmLogin.human.accentColour;

            //label5.Text = frmSetupGame.Player2.username + frmSetupGame.Player2.accentColour;
            
            //if(playerCount == 2)
            //    label6.Text = frmSetupGame.Player3.username + frmSetupGame.Player3.accentColour;

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
            //Default location: -450,0
            //Paused location: 0,0

            if (direction == 0)
            {
                //Pause
                Game.state = 4;
                lbGamePaused.Visible = true;
                int xCurrent = pnlPause.Location.X;
                int animateSpeed = 5;
                for(int i = 0; i < (450/animateSpeed); i++)
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
                for (int i = 0; i < (450 / animateSpeed); i++)
                {
                    pnlPause.Location = new Point(xCurrent - (Convert.ToInt32(animateSpeed) * i), 0);
                    pnlPause.Refresh();
                }
                lbGamePaused.Visible = false;
            }
        }

        private void lbPauseResume_Click(object sender, EventArgs e)
        {
            pauseShown++;
            AnimatePauseScreen(1);
        }

        private void lbPauseQuit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to Quit?\r\n\r\nNone of your progress will be saved!\r\n\r\nClick Yes to confirm, click No to return to the game.", "Are you sure you want to Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Hide();
                new frmDashboard().Show();
            } 
            else
            {
                pauseShown++;
                AnimatePauseScreen(1);
            }
        }
    }
}
