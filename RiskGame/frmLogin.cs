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
    public partial class frmLogin : Form
    {
        /*
         * Format for player file:
         * username~ENCpassword~avatar
         */
        public static Plys human = new Plys();
        static int currentLine = 0;

        static int numberOfUsers;
        static string[,] users;

        static string passwordA = "";

        public frmLogin()
        {
            if (!File.Exists("users.conf"))
            {
                frmLogin.human.firstLaunch = true;
                File.Create("users.conf").Dispose();
                Hide();
                new frmRegister().Show();
            }
            else 
            {
                currentLine = 0;
                numberOfUsers = File.ReadAllLines("users.conf").Count();
                users = new string[numberOfUsers, 4];
                InitializeComponent();
                CenterToScreen();

                // Read in the details from the users.txt file
                string[] userDetails = System.IO.File.ReadAllLines("users.conf");
                foreach (string user in userDetails)
                {
                    var splitDetails = user.Split('~');
                    for (int i = 0; i < 4; i++)
                    {
                        users[currentLine, i] = splitDetails[i];
                    }
                    AddToScreen(splitDetails[0], splitDetails[1], splitDetails[2], splitDetails[3]);
                    currentLine++;
                }
            }
        }

        private void AddToScreen(string id, string username, string avatar, string password)
        {
            passwordA = password;
            // Add the user to the screen
            Panel pnl = new Panel();
            pnl.Name = "pnl_" + id;
            pnl.Click += new EventHandler(loginActionPanel_Click);
            int x = 0;
            int y = 0;
            if (currentLine<=4)
            {
                y = 68;
                x = 12 + (currentLine * 189);
            }
            else if (currentLine<=9)
            {
                y = 68 + 175;
                x = 12 + ((currentLine - 5) * 189);
            }
            else
            {
                y = 68 + 175 + 175;
                x = 12 + ((currentLine - 10) * 189);
            }
            pnl.Location = new Point(x, y);
            pnl.Size = new Size(135, 180);
            this.Controls.Add(pnl);

            PictureBox pb = new PictureBox();
            pb.Name = "pb_" + id;
            pb.Click += new EventHandler(loginActionPictureBox_Click);
            pb.Location = new Point(0, 0);
            pb.Size = new Size(135, 135);
            pb.ImageLocation = "avatars\\" + avatar;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pnl.Controls.Add(pb);

            Label lb = new Label();
            lb.Name = "lb_" + lb;
            lb.Click += new EventHandler(loginActionLabel_Click);
            lb.Text = username;
            lb.Font = new Font("Segoe UI", 14);
            lb.TextAlign = ContentAlignment.MiddleCenter;
            lb.Left = (pnl.ClientSize.Width / 2) - (lb.Width / 2);
            lb.Location = new Point(lb.Left, 142);
            pnl.Controls.Add(lb);
        }

        private void loginActionPanel_Click(object sender, EventArgs e)
        {
            string selectedUserID = ((Panel)sender).Name.Split('_')[1];
            loginUser(selectedUserID);
        }

        private void loginActionPictureBox_Click(object sender, EventArgs e)
        {
            string selectedUserID = ((PictureBox)sender).Name.Split('_')[1];
            loginUser(selectedUserID);
        }
        
        private void loginUser(string id)
        {
            if (!DEBUG_cbRequirePassword.Checked)
            {
                frmLogin.human.username = users[Convert.ToInt32(id), 1];
                frmLogin.human.avatar = users[Convert.ToInt32(id), 2];
                Hide();
                new frmDashboard().Show();
            }
            else if (Microsoft.VisualBasic.Interaction.InputBox("Enter your password:", users[Convert.ToInt32(id), 1], "", 0, 0) == users[Convert.ToInt32(id), 3])
            {
                frmLogin.human.username = users[Convert.ToInt32(id), 1];
                frmLogin.human.avatar = users[Convert.ToInt32(id), 2];
                Hide();
                new frmDashboard().Show();
            }
            else
            {
                MessageBox.Show("Invalid Password!");
            }
        }
        
        private void loginActionLabel_Click(object sender, EventArgs e)
        {
            string selectedUserID = ((Label)sender).Name.Split('_')[1];
            loginUser(selectedUserID);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void DEBUG_cbFirstLaunch_CheckedChanged(object sender, EventArgs e)
        {
            if (DEBUG_cbFirstLaunch.Checked)
            {
                frmLogin.human.firstLaunch = true;
            }
            else
            {
                frmLogin.human.firstLaunch = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            new frmRegister().Show();
        }
    }
}
