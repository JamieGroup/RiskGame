using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

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
        string passwordHash = "";

        bool moveAssets = false;
        char moveX;
        char moveY;

        public frmLogin()
        {

            if (!File.Exists("cachedUsers.conf"))
            {
                frmLogin.human.firstLaunch = true;
                File.Create("cachedUsers.conf").Dispose();
                Hide();
                new frmRegister().Show();
            }
            else
            {
                currentLine = 0;
                numberOfUsers = File.ReadAllLines("cachedUsers.conf").Count();
                users = new string[numberOfUsers, 4];
                InitializeComponent();
                CenterToScreen();

                // Read in the details from the users.txt file
                string[] userDetails = File.ReadAllLines("cachedUsers.conf");
                foreach (string user in userDetails)
                {
                    var splitDetails = user.Split('~');
                    for (int i = 0; i < 3; i++)
                    {
                        users[currentLine, i] = splitDetails[i];
                    }
                    AddToScreen(splitDetails[0], splitDetails[1], splitDetails[2]);
                    currentLine++;
                }
            }

            txtBigPassword.PasswordChar = '*';
        }

        private void AddToScreen(string username, string avatar, string password)
        {
            passwordA = password;
            // Add the user to the screen
            Panel pnl = new Panel();
            pnl.Name = "pnl_" + username;
            pnl.Click += new EventHandler(loginActionPanel_Click);
            int x = 0;
            int y = 0;
            if (currentLine <= 4)
            {
                y = 68;
                x = 12 + (currentLine * 189);
            }
            else if (currentLine <= 9)
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
            pnl.BackColor = Color.Transparent;
            this.Controls.Add(pnl);

            PictureBox pb = new PictureBox();
            pb.Name = "pb_" + username;
            pb.Click += new EventHandler(loginActionPictureBox_Click);
            pb.Location = new Point(0, 0);
            pb.Size = new Size(135, 135);
            pb.ImageLocation = @avatar;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.BackColor = Color.Transparent;
            pnl.Controls.Add(pb);

            Label lb = new Label();
            lb.Name = "lb_" + username;
            lb.Click += new EventHandler(loginActionLabel_Click);
            lb.Text = username;
            lb.Font = new Font("Segoe UI", 14);
            lb.TextAlign = ContentAlignment.MiddleCenter;
            lb.Left = (pnl.ClientSize.Width / 2) - (lb.Width / 2);
            lb.Location = new Point(lb.Left, 142);
            lb.BackColor = Color.Transparent;
            lb.ForeColor = Color.White;
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

        private string getPasswordHash(string username)
        {
            //Search through the cachedUsers.conf file for the username, and read across the line to get the password hash
            string[] userDetails = File.ReadAllLines("cachedUsers.conf");
            foreach (string user in userDetails)
            {
                var splitDetails = user.Split('~');
                if (splitDetails[0] == username)
                {
                    return splitDetails[2];
                }
            }
            return null;
        }

        private void loginUser(string usr)
        {
            //Make all panels invisible
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    c.Visible = false;
                }
            }

            pnlBigCredentialsHolder.Visible = true;
            pnl_Sidebar_0.Visible = true;
            
            // Read in the details from the users.txt file
            string[] userDetails = File.ReadAllLines("cachedUsers.conf");
            int currentLine = 1;
            foreach (string user in userDetails)
            {
                if (user.Split('~')[0]==usr)
                {
                    pbBigAvatar.ImageLocation = user.Split('~')[1];
                    lbBigUsername.Text = usr;
                    lbBigUsername.TextAlign = ContentAlignment.MiddleCenter;
                    lbBigUsername.Left = (pnlBigUsernameHolder.ClientSize.Width / 2) - (lbBigUsername.Width / 2);
                    txtBigPassword.PasswordChar = '*';
                }

                Panel pnl = new Panel();
                pnl.Name = "pnl_Sidebar_" + user.Split('~')[0];
                pnl.Location = new Point(-250, currentLine*100);
                pnl.Size = new Size(250, 100);
                pnl.Visible = true;
                Controls.Add(pnl);
                
                PictureBox pb = new PictureBox();
                pb.ImageLocation = user.Split('~')[1];
                pb.Size = new Size(75, 75);
                pb.Location = new Point(10, 10);
                pb.Name = "pb_Sidebar_" + user.Split('~')[0];
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pnl.Controls.Add(pb);

                Label lb = new Label();
                lb.Font = new Font("Segoe UI", 16);
                lb.Name = "lb_Sidebar_" + user.Split('~')[0];
                lb.Text = user.Split('~')[0];
                lb.Location = new Point(90, 35);
                lb.AutoSize = false;
                lb.Size = new Size(200, 50); // set width and height
                pnl.Controls.Add(lb);

                //animateTo(pnl, new Point(0, currentLine * 100));

                currentLine++;
            }

            //Next, slide in the other accounts one by one in on the left.
            //animateTo(pnl_Sidebar_0, new Point(0,0));
        }

        private void animateTo(Control ctl, Point pt)
        {
            ctl.BringToFront();
            Point current = ctl.Location;

            while (current != pt)
            {
                if (current.X < pt.X)
                    current.X+=40;
                else if (current.X > pt.X)
                    current.X -= 40;
                if (current.Y < pt.Y)
                    current.Y += 40;
                else if (current.Y > pt.Y)
                    current.Y -= 40;
                
                // update the control's location using Control.Invoke
                ctl.Invoke((MethodInvoker)delegate
                {
                    ctl.Location = current;
                });

                ctl.Refresh();
                Thread.Sleep(1);
            }
        }

        private void btnBigLogin_Click(object sender, EventArgs e)
        {
            string usr = lbBigUsername.Text;
            string inputHashed = AES.GetHashString(txtBigPassword.Text);
            if (inputHashed == getPasswordHash(usr))
            {
                //Login!
                human = Serializer.DeserializePlayer(usr, txtBigPassword.Text);

                Hide();
                new frmDashboard().Show();
            }
            else
            {
                MessageBox.Show("Incorrect Password! 3 attempts left.");
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

        private void DEBUGbtnSkipToGame_Click(object sender, EventArgs e)
        {
            frmLogin.human.DEBUGSkipToGame = true;
            loginUser("0");
            Hide();
            new frmSetupGame().Show();

        }

        private void DEBUGcbIgnoreAssigned_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void newProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pbBigShow_MouseDown(object sender, MouseEventArgs e)
        {
            pbBigShow.Image = Properties.Resources.passwordHide;
            txtBigPassword.PasswordChar = '\0';
        }

        private void pbBigShow_MouseUp(object sender, MouseEventArgs e)
        {
            pbBigShow.Image = Properties.Resources.passwordShow;
            txtBigPassword.PasswordChar = '*';
        }

        private void btnDifferentAccount_Click(object sender, EventArgs e)
        {
            //Make all panels in the form visible
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    c.Visible = true;
                }
            }

            pnlBigCredentialsHolder.Visible = false;
            pnl_Sidebar_0.Visible = false;
        }

        private void txtBigPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                string usr = lbBigUsername.Text;
                string inputHashed = AES.GetHashString(txtBigPassword.Text);
                if (inputHashed == getPasswordHash(usr))
                {
                    //Login!
                    human = Serializer.DeserializePlayer(usr, txtBigPassword.Text);

                    Hide();
                    new frmDashboard().Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Password! 3 attempts left.");
                }
            }
        }
    }
}
