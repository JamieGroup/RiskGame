using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
