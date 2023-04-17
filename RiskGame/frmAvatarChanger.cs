using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RiskGame
{
    public partial class frmAvatarChanger : Form
    {
        string absoluteAvatar;

        public frmAvatarChanger()
        {
            InitializeComponent();
            RollAvatars();
        }

        private void btnRandom_Click(object sender, System.EventArgs e)
        {
            //Reroll avatars
            pnlRnd1.Controls.Clear();
            pnlRnd2.Controls.Clear();
            pnlRnd3.Controls.Clear();
            RollAvatars();
        }

        private void RollAvatars()
        {
            Random rnd = new Random();
            for(int q=0; q<3;q++)
            {
                for (int i = 0; i < 64; i++)
                {
                    Color weightedColour = Color.White;
                    switch (q)
                    {
                        case 0: weightedColour = Color.Yellow; break;
                        case 1: weightedColour = Color.Aqua; break;
                        case 2: weightedColour = Color.Fuchsia; break;
                        default: weightedColour = Color.White; break;
                    }
                    Panel pnl = new Panel();
                    pnl.Size = new System.Drawing.Size(30, 30);
                    int xValue = 0;
                    int yValue = 0;
                    if (i <= 7)
                    {
                        xValue = 30 + i * 30; yValue = 0;
                    }
                    else if (i <= 15)
                    {
                        xValue = 30 + (i - 8) * 30;
                        yValue = 30;
                    }
                    else if (i <= 23)
                    {
                        xValue = 30 + (i - 16) * 30;
                        yValue = 60;
                    }
                    else if (i <= 31)
                    {
                        xValue = 30 + (i - 24) * 30;
                        yValue = 90;
                    }
                    else if (i <= 39)
                    {
                        xValue = 30 + (i - 32) * 30;
                        yValue = 120;
                    }
                    else if (i <= 47)
                    {
                        xValue = 30 + (i - 40) * 30;
                        yValue = 150;
                    }
                    else if (i <= 55)
                    {
                        xValue = 30 + (i - 48) * 30;
                        yValue = 180;
                    }
                    else
                    {
                        xValue = 30 + (i - 56) * 30;
                        yValue = 210;
                    }

                    pnl.Location = new System.Drawing.Point(xValue, yValue);
                    pnl.Click += new EventHandler(PanelAction_Click);
                    pnl.Name = ($"pnlMini_{i}_{q}");

                    Color col = new Color();
                    int h = rnd.Next(0, 7);
                    switch (h)
                    {
                        case 0: col = Color.Red; break;
                        case 1: col = Color.Aqua; break;
                        case 2: col = Color.Yellow; break;
                        case 3: col = Color.LightGreen; break;
                        case 4: col = Color.Fuchsia; break;
                        case 5: col = weightedColour; break;
                        case 6: col = weightedColour; break;    
                    }
                    pnl.BackColor = col;
                    if (q == 0)
                        pnlRnd1.Controls.Add(pnl);
                    else if (q == 1)
                        pnlRnd2.Controls.Add(pnl);
                    else
                        pnlRnd3.Controls.Add(pnl);
                }
            }
        }

        private void PanelAction_Click(object sender, EventArgs e)
        {
            int selectedPanel = Convert.ToInt32(((Panel)sender).Name.Split('_')[2]);
            int width = 240;
            int height = 240;
            Bitmap bmp = new Bitmap(width, height);

            switch (selectedPanel)
            {
                case 0:
                    pnlRnd1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    break;
                case 1:
                    pnlRnd2.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    break;
                case 2:
                    pnlRnd3.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    break;
            }

            bmp.Save($"avatars\\{frmLogin.human.username}.png");
            pbPreview.Image = bmp;
        }

        private void pnlRnd1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            //For any other formats
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pbPreview.ImageLocation = of.FileName;
                absoluteAvatar = of.FileName;
                File.Copy(absoluteAvatar, $"avatars\\{frmLogin.human.username}.png", true);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmAvatarChanger_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            frmLogin.human.avatar = $"avatars\\{frmLogin.human.username}.png";
            Serializer.SerializePlayer(frmLogin.human);
            Hide();
        }
    }
}
