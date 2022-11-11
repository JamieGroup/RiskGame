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
    public partial class frmTutorial : Form
    {
        string tutorialLevel = "";
        public frmTutorial()
        {
            InitializeComponent();
            if (frmLogin.human.tutorialLevel == 0)
            {
                tutorialLevel = "Beginner";
            }
            else
            {
                tutorialLevel = "Intermediate";
            }

            this.Text = $"Risk: {tutorialLevel} Tutorial";

        }

        private void frmTutorial_Load(object sender, EventArgs e)
        {
            lbQuestion.Parent = pbTutorialAnimatedScreen;
            lbQuestion.BackColor = Color.Transparent;
            lbQuestion.ForeColor = Color.White;
            //pnlAns1.BackColor = Color.Yellow;
            lbCheck.Parent = pbCheckAnswers;
            lbCheck.BackColor = Color.Transparent;
        }

        private void answerClicked(int id)
        {
            switch (id)
            {
                case 1:
                    pbAns1Check.Image = Properties.Resources.Tutorial_Checkbox_Checked;
                    pnlAns1.BackColor = Color.Yellow;
                    break;
                case 2:
                    pbAns2Check.Image = Properties.Resources.Tutorial_Checkbox_Checked;
                    pnlAns2.BackColor = Color.Yellow;
                    break;
                case 3:
                    pbAns3Check.Image = Properties.Resources.Tutorial_Checkbox_Checked;
                    pnlAns3.BackColor = Color.Yellow;
                    break;
                case 4:
                    pbAns4Check.Image = Properties.Resources.Tutorial_Checkbox_Checked;
                    pnlAns4.BackColor = Color.Yellow;
                    break;
            }

            lbCheck.Enabled = true;
            pbCheckAnswers.Enabled = true;
            
            pbCheckAnswers.Image = Properties.Resources.WaitingBar_Green_Animated;
            lbCheck.ForeColor = Color.Black;
            pbCheckAnswers.SizeMode = PictureBoxSizeMode.StretchImage;

            pbCheckAnswers.BackColor = Color.Transparent;

            lbCheck.Visible = true;
            lbCheck.BringToFront();
        }

        private void lbAns1_Click(object sender, EventArgs e)
        {
            answerClicked(1);
        }

        private void pbAns1Check_Click(object sender, EventArgs e)
        {
            answerClicked(1);
        }

        private void pnlAns1_Click(object sender, EventArgs e)
        {
            answerClicked(1);
        }

        private void pnlAns3_Click(object sender, EventArgs e)
        {
            answerClicked(3);
        }

        private void lbAns3_Click(object sender, EventArgs e)
        {
            answerClicked(3);
        }

        private void pbAns3Check_Click(object sender, EventArgs e)
        {
            answerClicked(3);
        }

        private void pnlAns2_Click(object sender, EventArgs e)
        {
            answerClicked(2);
        }

        private void lbAns2_Click(object sender, EventArgs e)
        {
            answerClicked(2);
        }

        private void pbAns2Check_Click(object sender, EventArgs e)
        {
            answerClicked(2);
        }

        private void pnlAns4_Click(object sender, EventArgs e)
        {
            answerClicked(4);
        }

        private void lbAns4_Click(object sender, EventArgs e)
        {
            answerClicked(4);
        }

        private void pbAns4Check_Click(object sender, EventArgs e)
        {
            answerClicked(4);
        }
    }
}
