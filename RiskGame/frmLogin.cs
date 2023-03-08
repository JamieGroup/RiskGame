using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
            this.Controls.Add(pnl);

            PictureBox pb = new PictureBox();
            pb.Name = "pb_" + username;
            pb.Click += new EventHandler(loginActionPictureBox_Click);
            pb.Location = new Point(0, 0);
            pb.Size = new Size(135, 135);
            pb.ImageLocation = @avatar;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pnl.Controls.Add(pb);

            Label lb = new Label();
            lb.Name = "lb_" + username;
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

        private void animateTo(Control ctl, Point destination)
        {
            int xDiff = destination.X - ctl.Location.X;
            int yDiff = destination.Y - ctl.Location.Y;
            //Diffs being >0 means that control has to move right or up
            //Otherwise move left or down

            moveAssets = true;
            if(xDiff>0)
            {
                moveX = 'R';
                moveY = 'U';
            }
            else
            {
                moveX = 'L';
                moveY = 'D';
            }

            for(int i = 0; i<Math.Abs(xDiff); i++)
            {
                if (xDiff > 0)
                {
                    ctl.Location = new Point(ctl.Location.X + 1, ctl.Location.Y);
                }
                else
                {
                    ctl.Location = new Point(ctl.Location.X - 1, ctl.Location.Y);
                }
                if(yDiff>0)
                {
                    ctl.Location = new Point(ctl.Location.X, ctl.Location.Y-1);
                }
                else
                {
                    ctl.Location = new Point(ctl.Location.X, ctl.Location.Y + 1);
                }
                xDiff = destination.X - ctl.Location.X;
                yDiff = destination.Y - ctl.Location.Y;
            }
            
        }

        private void loginUser(string usr)
        {
            //Move user assets (username&avatar) to the centre, and create a password box, password
            //hide/show button, and a login button.
            PictureBox pb = Controls["pb_"+usr] as PictureBox;
            Label lb = Controls["lb_" + usr] as Label;

            //Dest locations: 
            //Avatar: 416,99
            //Username: 443,322
            animateTo(lb,new Point(443, 322));
            animateTo(pb, new Point(416, 99));

            //Next, slide in the other accounts one by one in on the left.

            string inputPassword = Microsoft.VisualBasic.Interaction.InputBox("Enter your password:", usr, "");
            string inputHashed = AES.GetHashString(inputPassword);
            if(inputHashed == getPasswordHash(usr))
            {
                //Login!
                human = Serializer.DeserializePlayer(usr, inputPassword);

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
    }
}
