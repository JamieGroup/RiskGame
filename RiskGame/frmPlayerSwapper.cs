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
    public partial class frmPlayerSwapper : Form
    {
        public frmPlayerSwapper()
        {
            InitializeComponent();
        }

        private void frmPlayerSwapper_Load(object sender, EventArgs e)
        {
            if (frmGameScreen.Game.OthersCount + frmGameScreen.Game.AICount < 3)
                pnlPlayer3.Visible = false;

            lbPl1Username.Text = frmLogin.human.username;
            lbPl2Username.Text = frmGameScreen.Pl2.username;
            lbPl3Username.Text = frmGameScreen.Pl3.username;
            pbPl1Avatar.ImageLocation = frmLogin.human.avatar;
            pbPl2Avatar.ImageLocation = frmGameScreen.Pl2.avatar;
            pbPl3Avatar.ImageLocation = frmGameScreen.Pl3.avatar;
        }
    }
}
