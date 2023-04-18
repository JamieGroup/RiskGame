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
            btnBack.Visible = true;
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
                    rtxImages.LoadFile(@"attributes\\images.rtf", RichTextBoxStreamType.RichText);
                    rtxSounds.LoadFile(@"attributes\\sounds.rtf", RichTextBoxStreamType.RichText);
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
            PopulateUnlockAccounts();
            PopulateManageUsers();
        }

        private void PopulateUnlockAccounts()
        {
            Label lbTitle = new Label();
            lbTitle.Location = new Point(10, 10);
            lbTitle.Text = "Locked Accounts";
            lbTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            tpLockedAccounts.Controls.Add(lbTitle);

            PictureBox pbLA = new PictureBox();
            pbLA.Location = new Point(235, 37);
            pbLA.Size = new Size(409, 322);
            pbLA.Image = Properties.Resources.LockedAccountsEmpty;
            pbLA.Visible = true;
            pbLockedAccountsNotFound.Visible = true;

            string[] users = File.ReadAllLines("cachedUsers.conf");
            int numLocked = 0;
            for (int i = 0; i < users.Length; i++)
            {
                string[] currentUser = users[i].Split('~');
                if (currentUser[4] == "True")
                {
                    pbLockedAccountsNotFound.Visible = false;
                    pbLA.Visible = false;
                    numLocked++;

                    Panel pnl = new Panel();
                    pnl.Size = new Size(747, 95);
                    pnl.Location = new Point(5, 40 + 95 * (numLocked - 1));
                    tpLockedAccounts.Controls.Add(pnl);

                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(64, 64);
                    pb.Location = new Point(7, 16);
                    pb.ImageLocation = currentUser[1];
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pnl.Controls.Add(pb);

                    Label lb = new Label();
                    lb.Font = new Font("Segoe UI", 20);
                    lb.Height = 50;
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
            string selectedUsername = ((Button)sender).Name.Split('_')[1];
            string[] users = File.ReadAllLines("cachedUsers.conf");
            for(int i=0; i<users.Length; i++)
            {
                string currentLine = users[i];
                if (users[i].Split('~')[0] == selectedUsername)
                {
                    users[i] = $"{users[i].Split('~')[0]}~{users[i].Split('~')[1]}~{users[i].Split('~')[2]}~{users[i].Split('~')[3]}~False~0";
                    break;
                }
            }
            File.WriteAllLines("cachedUsers.conf", users);

            //Delete all panels in tpLockedAccounts
            tpLockedAccounts.Controls.Clear();

            //Repopulate the panels
            PopulateUnlockAccounts();
        }

        private void PopulateManageUsers()
        {
            Label lbTitle = new Label();
            lbTitle.Location = new Point(10, 10);
            lbTitle.Text = "Delete Users";
            lbTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            tpManageUsers.Controls.Add(lbTitle);

            string[] users = File.ReadAllLines("cachedUsers.conf");
            int lineNum = 0;
            for (int i = 0; i < users.Length; i++)
            {
                string[] currentUser = users[i].Split('~');
                lineNum++;
                    Panel pnl = new Panel();
                    pnl.Size = new Size(747, 95);
                    pnl.Location = new Point(5, 40 + 95 * (lineNum - 1));
                    tpManageUsers.Controls.Add(pnl);

                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(64, 64);
                    pb.Location = new Point(7, 16);
                    pb.ImageLocation = currentUser[1];
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                pnl.Controls.Add(pb);

                    Label lb = new Label();
                    lb.Font = new Font("Segoe UI", 20);
                    lb.Height = 50;
                    lb.Location = new Point(90, 30);
                    lb.Text = currentUser[0];
                pnl.Controls.Add(lb);

                    Button btn = new Button();
                    btn.Size = new Size(132, 44);
                    btn.Location = new Point(600, 30);
                    btn.Font = new Font("Segoe UI", 14);
                    btn.Text = "Delete";
                    btn.Name = "btnDelete_" + currentUser[0];
                    btn.Click += new EventHandler(DeleteAccount_Action);
                pnl.Controls.Add(btn);
            }
        }
        private void DeleteAccount_Action(Object sender, EventArgs e)
        {
            //If messagebox is yes
            if (MessageBox.Show("Are you sure you want to delete this user?", "Delete User.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string selectedUsername = ((Button)sender).Name.Split('_')[1];
                string[] users = File.ReadAllLines("cachedUsers.conf");
                for (int i = 0; i < users.Length; i++)
                {
                    string currentLine = users[i];
                    if (users[i].Split('~')[0] == selectedUsername)
                    {
                        users = RemoveIndices(users, i);
                        break;
                    }
                }
                File.WriteAllLines("cachedUsers.conf", users);

                //Delete all panels in tpLockedAccounts
                tpManageUsers.Controls.Clear();

                //Repopulate the panels
                PopulateManageUsers();
            }
        }
        private string[] RemoveIndices(string[] IndicesArray, int RemoveAt)
        {
            string[] newIndicesArray = new string[IndicesArray.Length - 1];

            int i = 0;
            int j = 0;
            while (i < IndicesArray.Length)
            {
                if (i != RemoveAt)
                {
                    newIndicesArray[j] = IndicesArray[i];
                    j++;
                }

                i++;
            }

            return newIndicesArray;
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
            CorrectAllPanels();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            tcInfo.Visible = true;
            btnBack.Visible = true;
            rtxInfo.LoadFile("risk.rtf");
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
            tcAttributes.Visible = false;
            tcInfo.Visible = false;
        }
        private void CorrectAllPanels()
        {
            tcAAS.Parent = this;
            tcAttributes.Parent = this;
            tcDAP.Parent = this;
            tcIAI.Parent = this;
            tcInfo.Parent = this;

            tcAAS.Location = new Point(12, 50);
            tcAttributes.Location = new Point(12, 50);
            tcDAP.Location = new Point(12, 50);
            tcIAI.Location = new Point(12, 50);
            tcInfo.Location = new Point(12, 50);
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
            {
                pnlPWchange.Visible = false;
                btnOpenChangePW.Text = "Change Password";
            }
            else
            {
                pnlPWchange.Visible = true;
                btnOpenChangePW.Text = "Close";
            }
        }

        private void pnl1_Click(object sender, EventArgs e)
        {
            AccountAndSecurity();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            btnBack.Visible = false;
        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            if(txtNewPW.Text == txtConfirmNewPW.Text && validPWTest(txtNewPW.Text))
            {
                string selectedUsername = frmLogin.human.username;
                string[] users = File.ReadAllLines("cachedUsers.conf");
                for (int i = 0; i < users.Length; i++)
                {
                    string currentLine = users[i];
                    if (users[i].Split('~')[0] == selectedUsername)
                    {
                        users[i] = $"{users[i].Split('~')[0]}~{users[i].Split('~')[1]}~{AES.GetHashString(txtNewPW.Text)}~{users[i].Split('~')[3]}~{users[i].Split('~')[4]}~{users[i].Split('~')[5]}";
                        break;
                    }
                }
                File.WriteAllLines("cachedUsers.conf", users);
                MessageBox.Show("Password changed successfully!");
            }
            else
            {
                MessageBox.Show("Passwords do not match!");
            }
        }

        private bool validPWTest(string pw)
        {
            if (pw.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long!");
                return false;
            }
            else if (!pw.Any(char.IsUpper))
            {
                MessageBox.Show("Password must contain at least one uppercase letter!");
                return false;
            }
            else if (!pw.Any(char.IsDigit))
            {
                MessageBox.Show("Password must contain at least one number!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void pnl4_Click(object sender, EventArgs e)
        {
            tcInfo.Visible = true;
            btnBack.Visible = true;
            rtxInfo.LoadFile("risk.rtf");
        }

        private void pnl5_Click(object sender, EventArgs e)
        {
            AttributesAndLegal();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Hide();
            new frmDashboard().Show();
        }

        private void lb1_Click(object sender, EventArgs e)
        {
            AccountAndSecurity();
        }

        private void lb5_Click(object sender, EventArgs e)
        {
            AttributesAndLegal();
        }
    }
}
