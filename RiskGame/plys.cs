using System;
using System.Collections.Generic;
using System.Drawing;

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
        public Color accentColour { get; set; }
        public int numberFriends { get; set; }

        public bool DEBUGSkipToGame { get; set; }
        public bool DEBUGIgnoreAssigned { get; set; }

        private List<string> friendsList = new List<string>(0);

        public int globalUserID { get; set; }
        public string passwordHash { get; set; }
        public bool accountLocked { get; set; }
        public int globalRanking { get; set; }

        public bool firstLaunch { get; set; }
        public bool isAdmin { get; set; }


        public int tutorialLevel { get; set; }
        public int tutorialScore { get; set; }
        public bool multiplayerSelected { get; set; }
        public bool realPerson { get; set; }

        public int numberRegions { get; set; }
        public int numberTradingCards { get; set; }
        public int numberTroops { get; set; }
        public int troopPocket { get; set; }
        public int gamePlayerID { get; set; }
        public string sentFrom { get; set; }

        //Constructors
        public Plys(string _username, string _avatar, int _gamesPlayed, int _gamesWon, int _gamesLost, Color _accentColour, List<string> _friendsList, int _globalUserID, string _passwordHash, bool _accountLocked, int _globalRanking)
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
        public Plys(string _username, string _avatar)
        {
            username = _username;
            avatar = _avatar;
        }
        public Plys()
        {
            username = "";
            avatar = "";
            gamesPlayed = 0;
            gamesWon = 0;
            gamesLost = 0;
            accentColour = Color.Yellow;
            accountLocked = false;
        }
        public Plys(bool _realPerson, string _username, Color _colour, int _AICount, int _OthersCount, string _avatar)
        {
            realPerson = _realPerson;
            username = _username;
            accentColour = _colour;
            avatar = _avatar;
        }
        public void aquireRegion()
        {
            numberRegions++;
        }
    }
}
