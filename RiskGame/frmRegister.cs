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
    public partial class frmRegister : Form
    {
        bool acceptUsername = false;
        bool acceptPassword = false;
        bool acceptConfirmPassword = false;

        Random rnd = new Random();

        public frmRegister()
        {
            InitializeComponent();
            disableDescriptions();
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
            pbAvatar.ImageLocation = $"avatars\\default\\default{rnd.Next(1, 6)}.jpg";
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
            animate(pnlPassword, 1, 183, true);
            animate(pnlConfirmPassword, 1, 297, false);
            lbConfirmDescription.Visible = true;
        }

        private void animate(Panel pnl, int speed, int destY, bool down)
        {
            //Down = +, Up = -
            if(down)
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
            if (txtUsername.Text.Length < 2 || txtUsername.Text.Length > 25)
            {
                acceptUsername = false;
            }
            else
            {
                acceptUsername = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length >= 6 && HasSpecialChars(txtPassword.Text) && txtPassword.Text.Any(char.IsDigit) && txtPassword.Text.Any(char.IsUpper))
            {
                acceptPassword = true;
            }
            else
            {
                acceptPassword = false;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text == txtConfirmPassword.Text)
            {
                acceptConfirmPassword = true;
            }
            else
            {
                acceptConfirmPassword = false;
            }
        }

        private bool HasSpecialChars(string yourString)
        {
            return yourString.Any(ch => !char.IsLetterOrDigit(ch));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (acceptUsername && acceptPassword && acceptConfirmPassword)
            {
                PublishUser();
            }
            else if (cbIgnoreRequirements.Checked)
            {
                PublishUser();
            }
            else
            {
                MessageBox.Show("Invalid Details!");
            }
        }
        
        private void PublishUser()
        {
            //Create a path to the user details
            string filePath = @"users.conf";
            FileStream aFile;
            StreamWriter sw;

            try
            {
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
                string password = txtPassword.Text;
                int ID = (File.ReadLines(filePath).Count()) + 1;
                string avatar = pbAvatar.ImageLocation;

                sw.WriteLine($"{ID}~{username}~{avatar}~{password}");

                sw.Close();
                aFile.Close();

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
            //Open the avatar changer
            //Allow the user to choose a picture file
            //Set the picture box to the chosen file
            //Set the avatar to the chosen file
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.ImageLocation = ofd.FileName;
            }

        }
    }
}
