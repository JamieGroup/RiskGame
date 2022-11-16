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
using System.Runtime.InteropServices;

namespace RiskGame
{
    public partial class frmTutorial : Form
    {
        string tutorialLevel = "";
        int qNum = 0;
        Questions[] Qs = new Questions[3];
        string correct;
        string ansGiven;
        int idGiven;
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
            pnlNumberSelection.Visible = false;
            SetUpQuestion();
            displayQ();
        }

        private void frmTutorial_Load(object sender, EventArgs e)
        {
            lbQuestion.Parent = pbTutorialAnimatedScreen;
            lbQuestion.BackColor = Color.Transparent;
            lbQuestion.ForeColor = Color.White;
            //pnlAns1.BackColor = Color.Yellow;
            pbLogo.BackColor = Color.Transparent;
            pbLogo.Parent = pbTutorialAnimatedScreen;
        }

        private void displayQ()
        {
            EnableAllAssets();
            if (qNum <= 1 && tutorialLevel == "Intermediate")
            {
                pnlNumberSelection.Visible = true;
                //default location: 381, 3
                //move to: 703, 6
                bool correctLocation = false;
                do
                {
                    pbNumberSelection.Left -= 322;
                    if (pbNumberSelection.Location == new Point(703, 6))
                        correctLocation = true;

                } while (!correctLocation);
            }
            prbTime.Visible = false;
            lbQNum.Text = $"Question {qNum + 1}";
            lbScore.Text = $"Score: {frmLogin.human.tutorialScore}";
            pbAns1.Image = Properties.Resources.Tutorial_Checkbox;
            pbAns2.Image = Properties.Resources.Tutorial_Checkbox;
            pbAns3.Image = Properties.Resources.Tutorial_Checkbox;
            pbAns4.Image = Properties.Resources.Tutorial_Checkbox;
            pnlAns1.BackColor = Color.Transparent;
            pnlAns2.BackColor = Color.Transparent;
            pnlAns3.BackColor = Color.Transparent;
            pnlAns4.BackColor = Color.Transparent;

            setAnswers();
        }

        private void setAnswers()
        {
            string qHere = Qs[qNum].question;
            //Default (1 line) - 27, 33
            //2 line 27, 9 (when > 32 charaters)
            lbQuestion.MaximumSize = new Size(1142, 104);
            lbQuestion.AutoSize = true;
            if (qHere.Length > 32)
            {
                lbQuestion.Location = new Point(27, 9);
                //lbQuestion.Text = qHere.Substring(0, 32) + Environment.NewLine + qHere.Substring(32);
            }
            else
            {
                lbQuestion.Location = new Point(27, 33);
            }
            lbQuestion.Text = qHere;

            lbAns1.MaximumSize = new Size(440, 90);
            lbAns2.MaximumSize = new Size(440, 90);
            lbAns3.MaximumSize = new Size(440, 90);
            lbAns4.MaximumSize = new Size(440, 90);

            lbAns1.AutoSize = true;
            lbAns2.AutoSize = true;
            lbAns3.AutoSize = true;
            lbAns4.AutoSize = true;

            lbAns1.Text = Qs[qNum].a1;
            lbAns2.Text = Qs[qNum].a2;
            lbAns3.Text = Qs[qNum].a3;
            lbAns4.Text = Qs[qNum].a4;
            correct = Qs[qNum].correct;

            //(> 20 characters) = 109, 23
            //1 line = 109, 51

            if (lbAns1.Text.Length > 30)
                lbAns1.Location = new Point(109, 16);
            else
                lbAns1.Location = new Point(109, 51);
            if (lbAns2.Text.Length > 30)
                lbAns2.Location = new Point(109, 16);
            else
                lbAns2.Location = new Point(109, 51);
            if (lbAns3.Text.Length > 30)
                lbAns3.Location = new Point(109, 16);
            else
                lbAns3.Location = new Point(109, 51);
            if (lbAns4.Text.Length > 30)
                lbAns4.Location = new Point(109, 16);
            else
                lbAns4.Location = new Point(109, 51);
        }

        private void DisableAllAssets()
        {
            lbAns1.Enabled = false;
            lbAns2.Enabled = false;
            lbAns3.Enabled = false;
            lbAns4.Enabled = false;
            pbAns1.Enabled = false;
            pbAns2.Enabled = false;
            pbAns3.Enabled = false;
            pbAns4.Enabled = false;
            pnlAns1.Enabled = false;
            pnlAns2.Enabled = false;
            pnlAns3.Enabled = false;
            pnlAns4.Enabled = false;
        }

        private void EnableAllAssets()
        {
            lbAns1.Enabled = true;
            lbAns2.Enabled = true;
            lbAns3.Enabled = true;
            lbAns4.Enabled = true;
            pbAns1.Enabled = true;
            pbAns2.Enabled = true;
            pbAns3.Enabled = true;
            pbAns4.Enabled = true;
            pnlAns1.Enabled = true;
            pnlAns2.Enabled = true;
            pnlAns3.Enabled = true;
            pnlAns4.Enabled = true;
        }

        private void correction()
        {
            DisableAllAssets();
            if (idGiven == 1)
            {
                ansGiven = lbAns1.Text;
            }
            else if (idGiven == 2)
            {
                ansGiven = lbAns2.Text;
            }
            else if (idGiven == 3)
            {
                ansGiven = lbAns3.Text;
            }
            else if (idGiven == 4)
            {
                ansGiven = lbAns4.Text;
            }
            else
            {
                MessageBox.Show("Invalid Answer!");
            }

            string selectedPanel = "pnlAns" + idGiven;
            string correctPanel = "pnlAns" + correct;

            Panel spanel = Controls[selectedPanel] as Panel;
            Panel cpanel = Controls[correctPanel] as Panel;
            

            if (spanel == cpanel)
                spanel.BackColor = Color.LawnGreen;
            else
            {
                cpanel.BackColor = Color.LawnGreen;
                spanel.BackColor = Color.LightCoral;
            }
            if (spanel == cpanel)
            {
                frmLogin.human.tutorialScore++;
                lbScore.Text = $"Score: {frmLogin.human.tutorialScore}";
            }

            prbTime.Visible = true;
            prbTime.Maximum = 100;
            prbTime.Value = 0;
            tmrTime.Start();
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

        private void answerClicked(object e, string senderType)
        {
            //MessageBox.Show(((Panel)e).Name);
            //Color paleYellow = Color.FromArgb(1, 227, 242, 148);
            
            string searchCase = "";
            if (senderType == "lb")
            {
                searchCase = (((Label)e).Name);
            }
            else if (senderType == "pb")
            {
                searchCase = (((PictureBox)e).Name);
            }
            else
            {
                searchCase = (((Panel)e).Name);
            }
            searchCase = (Convert.ToString(searchCase[searchCase.Length - 1]));
            idGiven = Convert.ToInt32(searchCase);
            switch (searchCase)
            {
                case "1":
                    pbAns1.Image = Properties.Resources.Tutorial_Checkbox_Checked;
                    pnlAns1.BackColor = Color.LightBlue;
                    break;
                case "2":
                    pbAns2.Image = Properties.Resources.Tutorial_Checkbox_Checked;
                    pnlAns2.BackColor = Color.LightBlue;
                    break;
                case "3":
                    pbAns3.Image = Properties.Resources.Tutorial_Checkbox_Checked;
                    pnlAns3.BackColor = Color.LightBlue;
                    break;
                case "4":
                    pbAns4.Image = Properties.Resources.Tutorial_Checkbox_Checked;
                    pnlAns4.BackColor = Color.LightBlue;
                    break;
            }

            correction();
        }

        private void lbAns1_Click(object sender, EventArgs e)
        {
            answerClicked(lbAns1, "lb");
        }

        private void pbAns1Check_Click(object sender, EventArgs e)
        {
            answerClicked(pbAns1, "pb");
        }

        private void pnlAns1_Click(object sender, EventArgs e)
        {
            answerClicked(pnlAns1, "pnl");
        }

        private void pnlAns3_Click(object sender, EventArgs e)
        {
            answerClicked(pnlAns3, "pnl");
        }

        private void lbAns3_Click(object sender, EventArgs e)
        {
            answerClicked(lbAns3, "lb");
        }

        private void pbAns3Check_Click(object sender, EventArgs e)
        {
            answerClicked(pbAns3, "pb");
        }

        private void pnlAns2_Click(object sender, EventArgs e)
        {
            answerClicked(pnlAns2, "pnl");
        }

        private void lbAns2_Click(object sender, EventArgs e)
        {
            answerClicked(lbAns2, "lb");
        }

        private void pbAns2Check_Click(object sender, EventArgs e)
        {
            answerClicked(pbAns2, "pb");
        }

        private void pnlAns4_Click(object sender, EventArgs e)
        {
            answerClicked(pnlAns4, "pnl");
        }

        private void lbAns4_Click(object sender, EventArgs e)
        {
            answerClicked(lbAns4, "lb");
        }

        private void pbAns4Check_Click(object sender, EventArgs e)
        {
            answerClicked(pbAns4, "pb");
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            prbTime.Value++;
            if (prbTime.Value == prbTime.Maximum)
            {
                tmrTime.Stop();
                qNum++;
                if(qNum<2)
                {
                    displayQ();
                }
                else
                {
                    tutorialLevel = "Intermediate";
                    frmLogin.human.tutorialLevel = 1;
                    this.Text = $"Risk: {tutorialLevel} tutorial";
                    SetUpQuestion();
                    displayQ();
                    qNum = 1;
                }
            }
        }

        private void pbTutorialAnimatedScreen_Click(object sender, EventArgs e)
        {

        }
    }

    public class NewProgressBar : ProgressBar
    {
        public NewProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height - 4;
            e.Graphics.FillRectangle(Brushes.Red, 2, 2, rec.Width, rec.Height);
        }
    }
}
