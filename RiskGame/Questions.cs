namespace RiskGame
{
    class Questions
    {
        //Declare the variables required in the class
        private string question;
        private string a1;
        private string a2;
        private string a3;
        private string a4;
        private string correct;



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

        public string _question
        {
            get { return question; }
            set { question = value; }
        }
        public string A1
        {
            get { return a1; }
            set { a1 = value; }
        }
        public string A2
        {
            get { return a2; }
            set { a2 = value; }
        }
        public string A3
        {
            get { return a3; }
            set { a3 = value; }
        }
        public string A4
        {
            get { return a4; }
            set { a4 = value; }
        }
        public string CAns
        {
            get { return correct; }
            set { correct = value; }
        }
    }
}
