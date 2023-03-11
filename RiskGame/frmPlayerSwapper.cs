using System;
using System.Drawing;
using System.Windows.Forms;

namespace RiskGame
{
    public partial class frmPlayerSwapper : Form
    {
        //public sealed class ColorMatrix { }
        bool twoPlayers;
        public frmPlayerSwapper()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void frmPlayerSwapper_Load(object sender, EventArgs e)
        {
            lbPl1Username.Text = frmLogin.human.username;
            lbPl2Username.Text = frmGameScreen.Pl2.username;
            pbPl1Avatar.Image = Image.FromFile(@frmLogin.human.avatar);
            string pathPl2 = "avatars\\" + frmGameScreen.Pl2.avatar;
            pbPl2Avatar.Image = Image.FromFile(pathPl2);

            Application.OpenForms["frmGameScreen"].WindowState = FormWindowState.Minimized;
            Application.OpenForms["frmGameScreen"].Size = new Size(1554, 812);
            pnlStripe.Visible = false;
            twoPlayers = frmGameScreen.Game.twoPlayers;
            pnlPlayer3.Visible = !twoPlayers;
            if (!twoPlayers)
            {
                //Player 3 Operations

                lbPl3Username.Text = frmGameScreen.Pl3.username;
                string pathPl3 = "avatars\\" + frmGameScreen.Pl3.avatar;
                pbPl3Avatar.Image = Image.FromFile(pathPl3);
            }

            frmLogin.human.troopPocket = 4;
            frmGameScreen.Pl2.troopPocket = 4;
            frmGameScreen.Pl3.troopPocket = 4;
            BringToFront();
            DecidePlayer();
        }

        private void DecidePlayer()
        {
            int currentPlayer = frmGameScreen.Game.currentPlayer;
            if (frmGameScreen.Game.turnsChanged == 0)
            {

            }
            else
            {
                if (twoPlayers)
                {
                    currentPlayer++;
                    if (currentPlayer > 1)
                        currentPlayer = 0;
                }
                else
                {
                    currentPlayer++;
                    if (currentPlayer > 2)
                        currentPlayer = 0;
                }
            }
            frmGameScreen.Game.currentPlayer = currentPlayer;
            frmGameScreen.Game.state = 0;

            lbPl1Username.ForeColor = Color.Black;
            lbPl2Username.ForeColor = Color.Black;
            lbPl3Username.ForeColor = Color.Black;

            if (currentPlayer == 0)
                lbPl1Username.ForeColor = Color.LawnGreen;
            else if (currentPlayer == 1)
                lbPl2Username.ForeColor = Color.LawnGreen;
            else
                lbPl3Username.ForeColor = Color.LawnGreen;
        }

        private void PushBack()
        {
            /*Push back means closing player swapper and maximising the game screen again;
            while sending over a temporary value in the Game object to tell game screen
            that a new player has been chosen.*/
            frmGameScreen.Game.newPlayer = true;
            Hide();
            Application.OpenForms["frmGameScreen"].WindowState = FormWindowState.Normal;
            Application.OpenForms["frmGameScreen"].Size = new Size(1554, 813);

        }

        private void Trade()
        {
            Hide();
            new frmTradeCards().Show();
        }

        private void pbTradeCards_Click(object sender, EventArgs e)
        {
            Trade();
        }

        private void wmpVideoAI_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsMediaEnded || (WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsStopped)
            {
                wmpVideoAI.Visible = false;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Show a message box asking if the user has their audio unmuted
            if (MessageBox.Show("Please now unmute your audio, then click 'Ok' to continue.\r\nInfo: The following video is being streamed from Google Drive so may take a moment to download.", "Unmute your Audio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //If yes, play the video
                wmpVideoAI.Visible = true;
                wmpVideoAI.URL = "https://drive.google.com/uc?export=download&id=1NCDCZHX6m9sSV6z2E71ASZx923Ai2spI";
                wmpVideoAI.BringToFront();
            }
        }
    }
}
