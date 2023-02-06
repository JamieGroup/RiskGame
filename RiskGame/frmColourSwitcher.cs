using System;
using System.Drawing;
using System.Windows.Forms;

namespace RiskGame
{
    public partial class frmColourSwitcher : Form
    {
        public frmColourSwitcher()
        {
            InitializeComponent();
        }

        private void frmColourSwitcher_Load(object sender, EventArgs e)
        {
            LoadColours();
        }

        private void LoadColours()
        {
            for (int i = 0; i < 9; i++)
            {
                Point loc = new Point();
                Color col = new Color();
                switch (i)
                {
                    case 0: loc = new Point(0, 0); col = Color.Red; break;
                    case 1: loc = new Point(160, 0); col = Color.Orange; break;
                    case 2: loc = new Point(320, 0); col = Color.Yellow; break;
                    case 3: loc = new Point(0, 90); col = Color.LightGreen; break;
                    case 4: loc = new Point(160, 90); col = Color.Green; break;
                    case 5: loc = new Point(320, 90); col = Color.Teal; break;
                    case 6: loc = new Point(0, 180); col = Color.Aqua; break;
                    case 7: loc = new Point(160, 180); col = Color.Magenta; break;
                    case 8: loc = new Point(320, 180); col = Color.Purple; break;
                    default:
                        MessageBox.Show("Error displaying colours. Going to Dashboard.");
                        Hide(); new frmDashboard().Show(); break;
                }

                Panel pnl = new Panel();
                pnl.Name = "pnl_" + col.Name;
                pnl.Location = loc;
                pnl.BackColor = col;
                pnl.Click += new EventHandler(Pnl_Click);
                pnl.Size = new Size(100, 50);
                pnlHolder.Controls.Add(pnl);

                Label lb = new Label();
                lb.Name = "lb_" + col.Name;
                lb.Location = new Point(loc.X + 3, loc.Y + 53);
                lb.Text = col.Name;
                lb.Click += new EventHandler(Lb_Click);
                lb.Font = new Font("Segoe UI", 12);
                pnlHolder.Controls.Add(lb);
            }
        }

        private void Pnl_Click(object sender, EventArgs e)
        {
            string selectedPanel = ((Panel)sender).Name.Split('_')[1];
            Color selectedColour = Color.FromName(selectedPanel);
            frmLogin.human.accentColour = selectedColour;
            Hide();
        }
        private void Lb_Click(object sender, EventArgs e)
        {
            string selectedLabel = ((Label)sender).Name.Split('_')[1];
            Color selectedColour = Color.FromName(selectedLabel);
            frmLogin.human.accentColour = selectedColour;
            Hide();
        }
    }
}
