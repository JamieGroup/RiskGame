using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiskGame
{
    public partial class frmLogin : Form
    {
        /*
         * Format for player file:
         * username~ENCpassword~avatar
         */
        public static Plys human = new Plys();
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
