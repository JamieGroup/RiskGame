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
            int AICount = frmLogin.human.AICount;
            int OthersCount = frmLogin.human.OthersCount;

            if(OthersCount>0)
                label5.Text = frmSetupGame.Other1.username + frmSetupGame.Other1.accentColour;
            if(OthersCount == 2)
                label6.Text = frmSetupGame.Other2.username + frmSetupGame.Other2.accentColour;

            if(OthersCount == 0 && AICount > 0)
                label5.Text = frmSetupGame.AI1.username + frmSetupGame.AI1.accentColour;
            if(OthersCount == 0 && AICount == 2)
                label6.Text = frmSetupGame.AI2.username + frmSetupGame.AI2.accentColour;
        }
    }
}
