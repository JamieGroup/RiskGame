using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Linq;

namespace RiskGame
{
    public partial class frmFriendList : Form
    {
        int numberOfUsers;
        string[,] users;
        int currentLine = 0;

        public frmFriendList()
        {
            InitializeComponent();
        }

        private void frmFriendList_Load(object sender, EventArgs e)
        {
            string[] userDetails = File.ReadAllLines("cachedUsers.conf");
            foreach (string user in userDetails)
            {
                var splitDetails = user.Split('~');
                AddToScreen(splitDetails[0], splitDetails[1]);
                currentLine++;
            }
        }

        private void AddToScreen(string username, string avatar)
        {
            // Add the user to the screen
            Panel pnl = new Panel();
            pnl.Name = "pnl_" + username;
            int x = 6;
            int y = 7;
            y += (70*currentLine);
            pnl.Location = new Point(x, y);
            pnl.Size = new Size(668, 164);
            pnlUsers.Controls.Add(pnl);

            PictureBox pb = new PictureBox();
            pb.Name = "pb_" + username;
            pb.Location = new Point(0, 0);
            pb.Size = new Size(64, 64);
            pb.ImageLocation = @avatar;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pnl.Controls.Add(pb);

            Label lbI = new Label();
            lbI.Name = "lbI_" + username;
            lbI.Text = "Offline";
            lbI.Font = new Font("Segoe UI", 10);
            lbI.Location = new Point(70, 37);
            pnl.Controls.Add(lbI);

            Label lb = new Label();
            lb.Name = "lb_" + username;
            lb.Text = username;
            lb.Font = new Font("Segoe UI", 16);
            lb.AutoSize = false;
            lb.Width = 200;
            lb.Height = TextRenderer.MeasureText(lb.Text, lb.Font).Height;
            lb.Location = new Point(70, 5);
            pnl.Controls.Add(lb);

            Button btn = new Button();
            btn.Name = "btn_" + username;
            btn.Location = new Point(491, 7);
            btn.Size = new Size(174, 48);
            btn.Font = new Font("Segoe UI", 16);
            btn.Text = "Add Friend";
            pnl.Controls.Add(btn);
        }
    }
}
