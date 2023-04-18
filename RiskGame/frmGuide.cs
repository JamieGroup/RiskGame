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
    public partial class frmGuide : Form
    {
        public frmGuide()
        {
            InitializeComponent();
            rtxGuide.LoadFile("risk.rtf");
            if (frmLogin.human.tutorialLevel == 0)
                this.Name = "Risk: Beginner Guide";
            else if(frmLogin.human.tutorialLevel==1)
                this.Name = "Risk: Advanced Guide";
            else
                this.Name = "Risk: Guide";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            frmLogin.human.firstLaunch = false;
            Hide();
            new frmDashboard().Show();
        }

        private void btnMoreHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please visit https://hasbro.com from more information and help!");
        }
    }
}
