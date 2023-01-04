using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

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

            lbPl1Username.Text = frmLogin.human.username;
            lbPl2Username.Text = frmGameScreen.Pl2.username;
            
            pbPl1Avatar.Image = Image.FromFile(@frmLogin.human.avatar);
            string pathPl2 = "avatars\\" + frmGameScreen.Pl2.avatar;
            pbPl2Avatar.Image = Image.FromFile(pathPl2);
            frmLogin.human.troopPocket = 4;
            frmGameScreen.Pl2.troopPocket = 4;
            frmGameScreen.Pl3.troopPocket = 4;
            BringToFront();
            DecidePlayer();
        }

        private void DecidePlayer()
        {
            int currentPlayer = frmGameScreen.Game.currentPlayer;
            if(twoPlayers)
            {
                currentPlayer++;
                if (currentPlayer > 2)
                    currentPlayer = 1;
            }
            else
            {
                currentPlayer++;
                if (currentPlayer > 3)
                    currentPlayer = 1;
            }
            frmGameScreen.Game.currentPlayer = currentPlayer;
            frmGameScreen.Game.state = 0;

            lbPl1Username.ForeColor = Color.Black;
            lbPl2Username.ForeColor = Color.Black;
            lbPl3Username.ForeColor = Color.Black;

            if (currentPlayer == 1)
                lbPl1Username.ForeColor = Color.LawnGreen;
            else if (currentPlayer == 2)
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
    }
}
