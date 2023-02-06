using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RiskGame
{
    public partial class frmAvatarChanger : Form
    {
        
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

                    Color col = new Color();
                    int h = rnd.Next(0, 5);
                    switch (h)
                    {
                        case 0: col = Color.Red; break;
                        case 1: col = Color.Aqua; break;
                        case 2: col = Color.Yellow; break;
                        case 3: col = Color.LightGreen; break;
                        case 4: col = Color.Fuchsia; break;
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

        private void pnlRnd1_Click(object sender, EventArgs e)
        {
            int width = pnlRnd1.Size.Width;
            int height = pnlRnd1.Size.Height;

            Bitmap bmp = new Bitmap(width, height);
            pnlRnd1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));

            bmp.Save($"\\avatars\\test.png");
        }
    }
}
