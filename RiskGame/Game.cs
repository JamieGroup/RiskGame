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
        public void Message(string msgText, Panel pnl, Label lb)
        {
            tmr.Start();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);

            //1263, 51
            //1541, 51
            //-278

            for (int i = 0; i<278; i++)
            {
                pnl.Location = new Point(1541 - i, 51);
            }
            lb.Text = msgText;
        }
        
        void tmr_Tick(object sender, EventArgs e)
        {
            //Call method
            //if(tmr.)
        }
    }
}
