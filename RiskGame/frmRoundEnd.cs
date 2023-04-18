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
    public partial class frmRoundEnd : Form
    {
        public frmRoundEnd()
        {
            InitializeComponent();
            if(frmLogin.human.lastWin)
            {
                pbWin.Visible = true;
                lbMessage.Text = "Well Done!";
                lbMessage.ForeColor = Color.Green;
                lbInfo.Text = ($"You Win! You control " +
                    $"\r\na total of {frmLogin.human.lastScore}, " +
                    $"\r\nwhereas your oppoents " +
                    $"\r\ncontrol an average of {frmLogin.human.lastOpScore} " +
                    $"\r\nregions!");
            }
            else
            {
                pbLose.Visible = true;
                lbMessage.Text = "Better luck next time!";
                lbMessage.ForeColor = Color.Red;
                lbInfo.Text = ($"You Lose! Your opponents " +
                    $"\r\ncontrol an average of {frmLogin.human.lastOpScore} " +
                    $"\r\nregions! \r\nBut you only " +
                    $"\r\ncontrol a total of {frmLogin.human.lastScore}!");
            }
            
            
        }

        private void btnGoToDashboard_Click(object sender, EventArgs e)
        {
            Hide();
            new frmDashboard().Show();
        }
    }
}
