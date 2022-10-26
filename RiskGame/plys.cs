﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskGame
{
    [Serializable]
    public class Plys
    {
        public string username { get; set; }
        public string avatar { get; set; }
        public int gamesPlayed { get; set; }
        public int gamesWon { get; set; }
        public int gamesLost { get; set; }
        public string accentColour { get; set; }
        public int numberFriends { get; set; }
        
        private List<string> friendsList = new List<string>(0);

        public int globalUserID { get; set; }
        public string passwordHash { get; set; }
        public bool accountLocked { get; set; }
        public int globalRanking { get; set; }
        
        //Relative to local game - never saves outside of the program.
        public int numberRegions { get; set; }

    //Constructors
        public Plys(string _username, string _avatar, int _gamesPlayed, int _gamesWon, int _gamesLost, string _accentColour, List<string>_friendsList, int _globalUserID, string _passwordHash, bool _accountLocked, int _globalRanking)
        {
            username = _username;
            avatar = _avatar;
            gamesPlayed = _gamesPlayed;
            gamesWon = _gamesWon;
            gamesLost = _gamesLost;
            accentColour = _accentColour;
            friendsList = _friendsList;
            globalUserID = _globalUserID;
            passwordHash = _passwordHash;
            accountLocked = _accountLocked;
            globalRanking = _globalRanking;
        }
        public Plys()
        {
            username = "";
            avatar = "";
            gamesPlayed = 0;
            gamesWon = 0;
            gamesLost = 0;
            accentColour = "Yellow";
            accountLocked = false;
        }
        public void aquireRegion()
        {
            numberRegions++;
        }
    }
}