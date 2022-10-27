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
            btnAccentColourDisplay.BackColor = Color.FromName(frmLogin.human.accentColour);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlSidebar2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAccentColourDisplay_Click(object sender, EventArgs e)
        {
            //Open the colour changer
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = txtAccentColour.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnAccentColourDisplay.BackColor = colorDialog.Color;
                frmLogin.human.accentColour = colorDialog.Color.Name;
            }
        }
    }
}
