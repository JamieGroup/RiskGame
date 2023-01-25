using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RiskGame
{
    public class Game
    {
        //2 Relative to local game - never saves outside of the program.
        public int AICount { get; set; }
        public int OthersCount { get; set; }
        public int state { get; set; }
        public bool twoPlayers { get; set; }
        public int currentPlayer { get; set; }
        public bool newPlayer { get; set; }
        public int turnsChanged { get; set; }

        //Constructor
        public Game()
        {

        }

        public void calcPlayers()
        {
            if (OthersCount + AICount < 2)
                twoPlayers = true;
            else
                twoPlayers = false;
        }

        Timer tmr = new Timer();
        public async void Message(string msgText, Panel pnl, Label lb)
        {
            tmr.Start();
            tmr.Interval = 1000;

            //1263, 51
            //1541, 51
            //-278

            for (int i = 0; i<278; i++)
            {
                pnl.Location = new Point(1541 - i, 51);
            }
            lb.Text = msgText;
            await Task.Delay(10000);
            for (int i = 0; i < 278; i++)
            {
                pnl.Location = new Point(1263 + i, 51);
            }
        }

        public Bitmap MakeGrayscale(Bitmap original)
        {
            int height = original.Height;
            int width = original.Width;
            Color p;

            for(int y = 0; y<height; y++)
            {
                for(int x = 0; x<height; x++)
                {
                    //Get pixel value
                    p = original.GetPixel(x, y);
                    int avg = (p.R + p.G + p.B) / 3;

                    original.SetPixel(x, y, Color.FromArgb(p.A, avg, avg, avg));
                }
            }

            return original;
        }
    }
}
