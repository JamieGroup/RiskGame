using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RiskGame
{
    public partial class frmTutorialIntermediate : Form
    {
        string tutorialLevel = "";
        int qNum = 0;
        Questions[] Qs = new Questions[3];
        string correct;
        string ansGiven;
        int idGiven;
        public frmTutorialIntermediate()
        {
            InitializeComponent();
            CenterToScreen();
            SetUpQuestion();
            displayQ();
        }

        private void frmTutorialIntermediate_Load(object sender, EventArgs e)
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
            //Should the system show the Number Selection Panel?
            pnlNumberSelection.Location = new Point(0, 167);
            if (qNum <= 1)
            {
                pnlNumberSelection.Visible = true;
                //default location: 381, 3
                //move to: 703, 6
                pbNumberSelection.Visible = true;
                pbNumberSelection.Parent = pnlNumberSelection;
                pbNumberSelection.Image = Properties.Resources.numberSelection;
                //Thread.Sleep(2500);
                //int currentX = pbNumberSelection.Location.X;
                //int currentY = pbNumberSelection.Location.Y;
                //int animationSpeed = 1000;
                //Point currentP = new Point(currentX, currentY);
                //if (currentP != new Point(703, 6))
                //{
                //    for (int i = 0; i < animationSpeed; i++)
                //    {
                //        pbNumberSelection.Location = new Point(pbNumberSelection.Location.X + 1, currentY);
                //    }
                //}
            }
            prbTime.Visible = false;
            lbQNum.Text = $"Question {qNum + 1}";
            lbScore.Text = $"Score: {frmLogin.human.tutorialScore}";

            setAnswers();
        }

        private void setAnswers()
        {
            string qHere = Qs[qNum]._question;
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
        }

        private void DisableAllAssets()
        {

        }

        private void EnableAllAssets()
        {

        }

        private void correction()
        {
            DisableAllAssets();

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
            tmrTimer.Start();
        }

        private void SetUpQuestion()
        {
            string[] questions = File.ReadAllLines($"Tutorial_Intermediate.txt");
            //Add to array of classes
            for (int i = 0; i < questions.Length; i++)
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

            correction();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            prbTime.Value++;
            if (prbTime.Value == prbTime.Maximum)
            {
                tmrTimer.Stop();
                qNum++;
                if (qNum < 2)
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

        private void pnlNumberSelection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlNumberSelection_Scroll(object sender, ScrollEventArgs e)
        {
            //Get mouse scroll information


            if (Math.Abs(e.NewValue) == e.NewValue)
            {
                //Positive
                int currentNum = Convert.ToInt32(lbNumberSelectDisplay.Text);
                lbNumberSelectDisplay.Text = Convert.ToString(currentNum++);
            }
            else
            {
                //Negative
            }
        }

        private void pnlNumberSelection_MouseDown(object sender, MouseEventArgs e)
        {
            if (Math.Abs(e.Delta) == e.Delta)
            {
                //Positive
                int currentNum = Convert.ToInt32(lbNumberSelectDisplay.Text);
                lbNumberSelectDisplay.Text = Convert.ToString(currentNum++);
            }
            else
            {
                //Negative
            }
        }
    }
}
