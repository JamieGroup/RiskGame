using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
