using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RiskGame
{
    public partial class frmRegister : Form
    {
        bool acceptUsername = false;
        bool acceptPassword = false;
        bool acceptConfirmPassword = false;
        string relativeAvatar;
        string absoluteAvatar;
        int ID;
        bool sameAvatar = true;

        Random rnd = new Random();
        Plys tmpPlayer = new Plys();

        public frmRegister()
        {
            InitializeComponent();
            disableDescriptions();
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
            absoluteAvatar = $"avatars\\default\\default{rnd.Next(1, 6)}.jpg";
            pbAvatar.ImageLocation = absoluteAvatar;
            ID = (File.ReadLines("cachedUsers.conf").Count());
        }

        private void disableDescriptions()
        {
            lbUsernameDescription.Visible = false;
            lbPasswordDescription.Visible = false;
            lbConfirmDescription.Visible = false;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            disableDescriptions();
            animate(pnlPassword, 1, 240, true);
            animate(pnlConfirmPassword, 1, 340, true);
            lbUsernameDescription.Visible = true;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            disableDescriptions();
            animate(pnlPassword, 1, 183, false);
            animate(pnlConfirmPassword, 1, 340, true);
            lbPasswordDescription.Visible = true;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            disableDescriptions();
            animate(pnlPassword, 1, 183, false);
            animate(pnlConfirmPassword, 1, 297, false);
            lbConfirmDescription.Visible = true;
        }

        private void animate(Panel pnl, int speed, int destY, bool down)
        {
            //Down = +, Up = -
            if (down)
            {
                int xCurrent = pnl.Location.X;
                int yCurrent = pnl.Location.Y;
                for (int i = 0; i < ((destY - yCurrent) / speed); i++)
                {
                    pnl.Location = new Point(xCurrent, yCurrent + (Convert.ToInt32(speed) * i));
                    pnl.Refresh();
                }
            }
            else
            {
                int xCurrent = pnl.Location.X;
                int yCurrent = pnl.Location.Y;
                int displacement = destY - yCurrent;
                for (int i = 0; i > (displacement / speed); i--)
                {
                    pnl.Location = new Point(xCurrent, yCurrent + (Convert.ToInt32(speed) * i));
                    pnl.Refresh();
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            //lbAvatar.Text = txtUsername.Text + " (Avatar)";
            if (txtUsername.Text.Length < 2 || txtUsername.Text.Length > 25 || userInUse(txtUsername.Text)){
                acceptUsername = false;
            }
            else{
                acceptUsername = true;
            }
        }

        private bool userInUse(string usr)
        {
            bool inUse = false;
            string[] usernames = File.ReadAllLines("cachedUsers.conf");
            int i = 0;
            foreach (string user in usernames)
            {
                usernames[i] = usernames[i].Split('~')[0];
                i++;
            }
            if (usernames.Contains(usr))
                inUse = true;
            return inUse;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length >= 6 && txtPassword.Text.Any(char.IsDigit) && txtPassword.Text.Any(char.IsUpper)){
                acceptPassword = true;
            }
            else{
                acceptPassword = false;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirmPassword.Text){
                acceptConfirmPassword = true;
            }
            else{
                acceptConfirmPassword = false;
            }
        }

        private bool HasSpecialChars(string yourString)
        {
            return yourString.Any(ch => !char.IsLetterOrDigit(ch));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(!cbIgnoreRequirements.Checked)
            {
                if (sameAvatar)
                {
                    MessageBox.Show("Please select an avatar!", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!acceptUsername)
                {
                    MessageBox.Show("Username must be 2-25 characters in length!", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!acceptPassword)
                {
                    MessageBox.Show("Password must be at least 6 characters in length, and contain at least 1 number and 1 uppercase letter!", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!acceptConfirmPassword)
                {
                    MessageBox.Show("Passwords must match!", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PublishUser();
                }
            }
            else if(!userInUse(txtUsername.Text))
            {
                PublishUser();
            }
            else
            {
                MessageBox.Show("This user already exists! \r\nTry logging in again, or reset your password.", "User in use");
            }
        }

        private void PublishUser()
        {
            //Create a path to the user details
            string filePath = @"cachedUsers.conf";
            FileStream aFile;
            StreamWriter sw;

            try
            {
                File.Copy(absoluteAvatar, $"avatars\\{txtUsername.Text}.png", true);

                //If a user file doesn't exist, create one
                if (!File.Exists(filePath))
                {
                    aFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                }
                else
                {
                    aFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                }
                sw = new StreamWriter(aFile);
                string username = txtUsername.Text;
                string passwordHash = AES.GetHashString(txtPassword.Text);
                string avatar = pbAvatar.ImageLocation;
                tmpPlayer.passwordHash = passwordHash;
                tmpPlayer.firstLaunch = true;
                bool isAdmin = false;
                if (cbAdmin.Checked)
                    isAdmin = true;
                bool isLocked = false;
                tmpPlayer.accountLocked = isLocked;
                tmpPlayer.isAdmin = isAdmin;

                sw.WriteLine($"{username}~avatars\\{txtUsername.Text}.png~{passwordHash}~{isAdmin}~{isLocked}~0");

                sw.Dispose();
                aFile.Dispose();

                tmpPlayer.username = username;
                tmpPlayer.avatar = $"avatars\\{txtUsername.Text}.png";
                Serializer.SerializePlayer(tmpPlayer);

                Hide();
                new frmLogin().Show();

                MessageBox.Show("User has been added successfully.", "Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("User failed to add.\r\nSorry for any inconvenience.\r\nError Details:\r\n" + ex.Message, "Error occurred");
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            sameAvatar = false;
            //Open the avatar changer

            var fileContent = string.Empty;
            var filePath = string.Empty;
            var inDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = inDir + "\\Pictures";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.tif;...";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    pbAvatar.Image = new Bitmap(openFileDialog.FileName);

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    relativeAvatar = openFileDialog.SafeFileName;
                    absoluteAvatar = openFileDialog.FileName;
                }
            }
        }
    }
}
