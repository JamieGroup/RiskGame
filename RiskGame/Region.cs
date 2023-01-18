using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RiskGame
{
    class Region
    {
        public int owner { get; set; }
        public string territory { get; set; }
        public string name { get; set; }
        public int CentralX { get; set; }
        public int CentralY { get; set; }
        public string colour { get; set; }
        public int troopCount;

        public Region()
        {
            owner = -1;
            territory = "none";
            name = "none";
            CentralX = 0;
            CentralY = 0;
        }

        public Region(string _name)
        {
            name = _name;
        }
        
        public void addTroops(int _addTroops)
        {
            troopCount += _addTroops;
        }

        public void SetController(int _owner)
        {
            owner = _owner;
        }
        public void SetTerritory()
        {
            territory = name.Split('_')[0];
        }
        public string GetOwner()
        {
            return $"{owner}";
        }
        public void SetPoint(int x, int y)
        {
            CentralX = x;
            CentralY = y;
        }

        public bool Closeness(Region source, Region potentialTarget)
        {
            bool close = false;

            string[] relations = File.ReadAllLines("relations.conf");
            for(int i = 0; i<relations.Length; i++)
            {
                string[] relationList = relations[i].Split('~');
                if (relationList[0] == source.name)
                {
                    
                    for (int g = 0; g < relationList.Length; g++)
                    {
                        if (relationList[g] == potentialTarget.name)
                        {
                            close = true;
                        }
                    }
                }
            }

            return close;
        }
    }
}
