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
        bool fl = frmLogin.human.firstLaunch;
        public frmDashboard()
        {
            InitializeComponent();
            CenterToScreen();
            pbLogout.Image = Properties.Resources.LogoutButton_NOTHover2;
            pbTutorialEasy.Visible = false;
            pbTutorialHard.Visible = false;
            lbTutorialEasy.Visible = false;
            lbTutorialHard.Visible = false;
            lbSkipTutorial.Visible = false;
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
            btnAccentColour.BackColor = Color.FromName(frmLogin.human.accentColour);
            lbUsername.Text = frmLogin.human.username;
            pbAvatar.ImageLocation = "avatars\\" + frmLogin.human.avatar;

            if (frmLogin.human.firstLaunch)
            {
                pbPlay.Image = Properties.Resources.PlayTutorialAnimation;
                MessageBox.Show("Welcome to Risk! This is your first time playing, so we'll take you through a quick tutorial to get you started. Click the green animated button to continue.", "Welcome to Risk!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pbPlay.Image = Properties.Resources.PlayGameAnimation;
                
            }
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

        private void btnAccentColour_Click(object sender, EventArgs e)
        {
            //Open the colour changer
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = btnAccentColour.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnAccentColour.BackColor = colorDialog.Color;
                frmLogin.human.accentColour = colorDialog.Color.Name;
            }
        }

        //These methods change the animated play button's image from the closed book to the open book depending on
        //where the users mouse is (over the image or not).
        //2 are needed for the 2 states of the button ("Game" and "Tutorial").
        private void pbPlay_MouseEnter(object sender, EventArgs e)
        {
            if (frmLogin.human.firstLaunch)
            {
                pbPlay.Image = Properties.Resources.PlayTutorialAnimation_Hover;
            }
            else
            {
                pbPlay.Image = Properties.Resources.PlayGameAnimation_Hover;
            }
        }

        private void pbPlay_MouseLeave(object sender, EventArgs e)
        {
            if (frmLogin.human.firstLaunch)
            {
                pbPlay.Image = Properties.Resources.PlayTutorialAnimation;
            }
            else
            {
                pbPlay.Image = Properties.Resources.PlayGameAnimation;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            frmLogin.human = new Plys();
            new frmLogin().Show();
        }

        private void pbLogout_MouseEnter(object sender, EventArgs e)
        {
            pbLogout.Image = Properties.Resources.LogoutButton_Resize;
        }

        private void pbLogout_MouseLeave(object sender, EventArgs e)
        {
            pbLogout.Image = Properties.Resources.LogoutButton_NOTHover2;
        }

        private void pbPlay_Click(object sender, EventArgs e)
        {
            if(fl)
            {
                //Code to run if the player clicks on "Play Tutorial"
                pbTutorialEasy.Visible = true;
                pbTutorialHard.Visible = true;
                lbTutorialEasy.Visible = true;
                lbTutorialHard.Visible = true;
                lbSkipTutorial.Visible = true;
            }
        }

        private void lbSkipTutorial_Click(object sender, EventArgs e)
        {
            frmLogin.human.firstLaunch = false;
            Hide();
            new frmDashboard().Show();
        }

        private void pbTutorialEasy_Click(object sender, EventArgs e)
        {
            frmLogin.human.tutorialLevel = 0;
            Hide();
            new frmTutorial().Show();
        }

        private void pbTutorialHard_Click(object sender, EventArgs e)
        {
            frmLogin.human.tutorialLevel = 1;
            Hide();
            new frmTutorial().Show();
        }
    }
}
