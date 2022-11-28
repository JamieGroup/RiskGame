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
        public frmGameScreen()
        {
            InitializeComponent();
        }

        private void frmGameScreen_Load(object sender, EventArgs e)
        {
            int AICount = frmSetupGame.Game.AICount;
            int OthersCount = frmSetupGame.Game.OthersCount;
            int playerCount = AICount + OthersCount;

            label4.Text = frmLogin.human.username + frmLogin.human.accentColour;

            label5.Text = frmSetupGame.Player2.username + frmSetupGame.Player2.accentColour;
            
            if(playerCount == 2)
                label6.Text = frmSetupGame.Player3.username + frmSetupGame.Player3.accentColour;

        }

        private void lbGamePaused_Click(object sender, EventArgs e)
        {

        }
    }
}
