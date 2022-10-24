using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskGame
{
    class plys
    {
        private string username;
        private string avatar;
        private int gamesPlayed;
        private int gamesWon;
        private int gamesLost;
        string accentColour;
        int numberFriends;
        List<string> friendsList = new List<string>(0);
        int globalUserID;
        string passwordHash;
        bool accountLocked;
        int globalRanking;

        //Constructors
        public plys(string _username, string _avatar, int _gamesPlayed, int _gamesWon, int _gamesLost, string _accentColour, List<string>_friendsList, int _globalUserID, string _passwordHash, bool _accountLocked, int _globalRankning)
        {
            username = _username;
            avatar = _avatar;
            gamesPlayed = _gamesPlayed;
            gamesWon = _gamesWon;
            gamesLost = _gamesLost;
            accentColour = _accentColour;
            numberFriends;
            friendsList;
            globalUserID;
            passwordHash;
            accountLocked;
            globalRanking;
    }
    }
}
