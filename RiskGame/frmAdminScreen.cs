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
    public partial class frmAdminScreen : Form
    {
        string selected = "";
        public frmAdminScreen()
        {
            InitializeComponent();
            HideAllPanels();
            CorrectAllPanels();
        }

        private void optionSelect(string s)
        {
            HideAllPanels();
            switch(s)
            {
                case "DOP":
                    tcDAP.Visible = true;
                    break;
                case "IAI":
                    tcIAI.Visible = true;
                    break;
                case "GIN":
                    //Info
                    break;
                case "AAL":
                    tcAttributes.Visible = true;
                    break;
                case "AAS":
                    tcAAS.Visible = true;
                    break;
            }
        }

        private void AccountAndSecurity()
        {
            tcAAS.Visible = true;
            optionSelect("AAS");
            //tpLockedAccounts
            string[] users = File.ReadAllLines("cachedUsers.conf");
            int numLocked = 0;
            for(int i=0; i<users.Length; i++)
            {
                string[] currentUser = users[i].Split('~');
                if (currentUser[4] == "True")
                {
                    numLocked++;
                    
                    Panel pnl = new Panel();
                    pnl.Size = new Size(747, 95);
                    pnl.Location = new Point(5, 40 + 95*(numLocked-1));
                    tpLockedAccounts.Controls.Add(pnl);

                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(64, 64);
                    pb.Location = new Point(7, 16);
                    pb.ImageLocation = currentUser[1];
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pnl.Controls.Add(pb);

                    Label lb = new Label();
                    lb.Font = new Font("Segoe UI", 20);
                    lb.Location = new Point(90, 30);
                    lb.Text = currentUser[0];
                    pnl.Controls.Add(lb);

                    Button btn = new Button();
                    btn.Size = new Size(132, 44);
                    btn.Location = new Point(600, 30);
                    btn.Font = new Font("Segoe UI", 14);
                    btn.Text = "Unlock";
                    btn.Name = "btnUnlock_" + currentUser[0];
                    btn.Click += new EventHandler(UnlockAccount_Action);
                    pnl.Controls.Add(btn);
                }
            }
        }

        private void UnlockAccount_Action(Object sender, EventArgs e)
        {
            
        }

        private void DataAndOnlinePrivacy()
        {
            optionSelect("DOP");
        }

        private void InGameAI()
        {
            optionSelect("IAI");
        }

        private void GameInformation()
        {
            optionSelect("GIN");
        }

        private void AttributesAndLegal()
        {
            optionSelect("AAL");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HideAllPanels()
        {
            btnBack.Visible = false;
            tcAAS.Visible = false;
            tcDAP.Visible = false;
            tcIAI.Visible = false;
        }
        private void CorrectAllPanels()
        {
            tcAAS.Parent = this;
            tcAttributes.Parent = this;
            tcDAP.Parent = this;
            tcIAI.Parent = this;

            tcAAS.Location = new Point(12, 50);
            tcAttributes.Location = new Point(12, 50);
            tcDAP.Location = new Point(12, 50);
            tcIAI.Location = new Point(12, 50);
        }

        private void btnOptionsBack_Click(object sender, EventArgs e)
        {
            //pnlAdminSettings.Visible = false;
        }

        private void pnlAdminSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnlPWchange.Visible)
                pnlPWchange.Visible = false;
            else
                pnlPWchange.Visible = true;
        }

        private void pnl1_Click(object sender, EventArgs e)
        {
            AccountAndSecurity();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HideAllPanels();
        }
    }
}
