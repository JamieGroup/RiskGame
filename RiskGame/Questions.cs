using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskGame
{
    class Questions
    {
        //Declare the variables required in the class
        public string question { get; set; }
        public string a1 { get; set; }
        public string a2 { get; set; }
        public string a3 { get; set; }
        public string a4 { get; set; }
        public string correct { get; set; }

        //Constructor to set up the initial values
        public Questions(string _question, string A1, string A2, string A3, string A4, string CAns)
        {
            question = _question;
            a1 = A1;
            a2 = A2;
            a3 = A3;
            a4 = A4;
            correct = CAns;
        }
    }
}
