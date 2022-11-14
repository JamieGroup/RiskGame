using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RiskGame
{
    public partial class frmTutorial : Form
    {
        string tutorialLevel = "";
        int qNum = 0;
        Questions[] Qs = new Questions[3];
        string correct;
        int idCorrect;
        string ansGiven;
        public frmTutorial()
        {
            InitializeComponent();
            CenterToScreen();
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
        
        }

        private void displayQ()
        {
            pbAns1Check.Image = Properties.Resources.Tutorial_Checkbox;
            pbAns2Check.Image = Properties.Resources.Tutorial_Checkbox;
            pbAns3Check.Image = Properties.Resources.Tutorial_Checkbox;
            pbAns4Check.Image = Properties.Resources.Tutorial_Checkbox;
            pnlAns1.BackColor = Color.Transparent;
            pnlAns2.BackColor = Color.Transparent;
            pnlAns3.BackColor = Color.Transparent;
            pnlAns4.BackColor = Color.Transparent;
            lbQuestion.Text = Qs[qNum].question;
            lbAns1.Text = Qs[qNum].a1;
            lbAns2.Text = Qs[qNum].a2;
            lbAns3.Text = Qs[qNum].a3;
            lbAns4.Text = Qs[qNum].a4;
            correct = Qs[qNum].correct;
        }

        private void correction()
        {
            if (pbAns1Check.Image == Properties.Resources.Tutorial_Checkbox_Checked)
            {
                ansGiven = lbAns1.Text;
            }
            else if (pbAns2Check.Image == Properties.Resources.Tutorial_Checkbox_Checked)
            {
                ansGiven = lbAns2.Text;
            }
            else if (pbAns3Check.Image == Properties.Resources.Tutorial_Checkbox_Checked)
            {
                ansGiven = lbAns3.Text;
            }
            else if (pbAns4Check.Image == Properties.Resources.Tutorial_Checkbox_Checked)
            {
                ansGiven = lbAns4.Text;
            }
            else
            {
                MessageBox.Show("Invalid Answer!");
            }

            if(lbAns1.Text == ansGiven)
            {
                pnlAns1.BackColor = Color.LawnGreen;
                pnlAns2.BackColor = Color.Red;
                pnlAns3.BackColor = Color.Red;
                pnlAns4.BackColor = Color.Red;
            }
            else if (lbAns2.Text == ansGiven)
            {
                pnlAns2.BackColor = Color.LawnGreen;
                pnlAns1.BackColor = Color.Red;
                pnlAns3.BackColor = Color.Red;
                pnlAns4.BackColor = Color.Red;
            }
            else if (lbAns3.Text == ansGiven)
            {
                pnlAns3.BackColor = Color.LawnGreen;
                pnlAns2.BackColor = Color.Red;
                pnlAns1.BackColor = Color.Red;
                pnlAns4.BackColor = Color.Red;
            }
            else if (lbAns4.Text == ansGiven)
            {
                pnlAns4.BackColor = Color.LawnGreen;
                pnlAns2.BackColor = Color.Red;
                pnlAns3.BackColor = Color.Red;
                pnlAns1.BackColor = Color.Red;
            }

            if (ansGiven == correct)
            {
                frmLogin.human.tutorialScore++;

            }
        }

        private void SetUpQuestion()
        {
            string[] questions = File.ReadAllLines($"Tutorial_{tutorialLevel}.txt");
            //Add to array of classes
            for (int i=0; i<questions.Length; i++)
            {
                string[] qParts = questions[i].Split('~');
                Qs[i] = new Questions(qParts[0], qParts[1], qParts[2], qParts[3], qParts[4], qParts[5]);
            }
        }

        private void answerClicked(int id)
        {
            Color paleYellow = Color.FromArgb(1, 227, 242, 148);
            switch (id)
            {
                case 1:
                    pbAns1Check.Image = Properties.Resources.Tutorial_Checkbox_Checked;
                    pnlAns1.BackColor = Color.LightBlue;
                    break;
                case 2:
                    pbAns2Check.Image = Properties.Resources.Tutorial_Checkbox_Checked;
                    pnlAns2.BackColor = Color.LightBlue;
                    break;
                case 3:
                    pbAns3Check.Image = Properties.Resources.Tutorial_Checkbox_Checked;
                    pnlAns3.BackColor = Color.LightBlue;
                    break;
                case 4:
                    pbAns4Check.Image = Properties.Resources.Tutorial_Checkbox_Checked;
                    pnlAns4.BackColor = Color.LightBlue;
                    break;
            }
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
