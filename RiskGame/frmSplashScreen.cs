using System;
using System.Threading;
using System.Windows.Forms;

namespace RiskGame
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            CenterToScreen();
            tmrLoading.Start();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            // ^ loading bar
            prbrLoading.Increment(5);

            //Update label to bar's value
            lbLoading.Text = $"{prbrLoading.Value} %";

            if (prbrLoading.Value >= 100)
            {
                tmrLoading.Stop();
                Thread.Sleep(1000);
                Hide();
                new frmDashboard().Show();
            }
        }
    }
}
