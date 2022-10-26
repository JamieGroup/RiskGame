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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            //Open the avatar changer
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            txtAccentColour.BackColor = Color.FromName(frmLogin.human.accentColour);
        }
    }
}
