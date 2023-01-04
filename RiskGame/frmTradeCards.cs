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
    public partial class frmTradeCards : Form
    {
        public frmTradeCards()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void frmTradeCards_Load(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            frmGameScreen.Game.newPlayer = true;
            Hide();
            Application.OpenForms["frmGameScreen"].WindowState = FormWindowState.Normal;
        }
    }
}
