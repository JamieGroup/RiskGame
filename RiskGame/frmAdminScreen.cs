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
            HideAllPanels();
        }

        private void optionSelect(string s)
        {
            
        }

        private void AccountAndSecurity()
        {
            tcAAS.Visible = true;
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
            btnBack.Visible = false;
            tcAAS.Visible = false;
            tcDAP.Visible = false;
            tcIAI.Visible = false;

        }

        private void btnOptionsBack_Click(object sender, EventArgs e)
        {
            //pnlAdminSettings.Visible = false;
        }

        private void pnlAdminSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pnlPWchange.Visible)
                pnlPWchange.Visible = false;
            else
                pnlPWchange.Visible = true;
        }

        private void pnl1_Click(object sender, EventArgs e)
        {
            tcAAS.Visible = true;
            btnBack.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HideAllPanels();
        }
    }
}
