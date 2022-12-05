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

        public Region(string _name)
        {
            name = _name;
        }
        
        public void SetTerritory()
        {
            territory = name.Split('_')[0];
        }
        public string GetOwner()
        {
            return $"Player {owner}";
        }
    }
}
