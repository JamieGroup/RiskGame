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
    public partial class frmAdminScreen : Form
    {
        string selected = "";
        public frmAdminScreen()
        {
            InitializeComponent();
            
        }

        private void optionSelect(string s)
        {
            
        }

        private void AccountAndSecurity()
        {
            optionSelect("AAS");
        }

        private void DataAndOnlinePrivacy()
        {
            optionSelect("DOP");
        }

        private void InGameAI()
        {
            optionSelect("IAI");
        }

        private void GameInformation()
        {
            optionSelect("GIN");
        }

        private void AttributesAndLegal()
        {
            optionSelect("AAL");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HideAllPanels()
        {
            pnlAdminSettings.Visible = false;
            //pnlGi.Visible = false;
            //pnlDAP.Visible = false;
            //pnlAAL.Visible = false;
            //pnlIGAI.Visible = false;
        }

        private void btnOptionsBack_Click(object sender, EventArgs e)
        {
            pnlAdminSettings.Visible = false;
        }
    }
}
