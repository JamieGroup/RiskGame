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
    public partial class frmFeedback : Form
    {
        public frmFeedback()
        {
            InitializeComponent();
            lbFileName.Visible = false;
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 4)
            {
                textBox3.Visible = true;
                label4.Visible = true;
            }
            else
            {
                textBox3.Visible = false;
                label4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new frmDashboard().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new frmDashboard().Show();
            MessageBox.Show("Thank you for your feedback!", "Sent Feedback!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Open file dialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            ofd.Title = "Select an image to send feedback";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Set the image
                lbFileName.Text = ofd.SafeFileName;
                lbFileName.Visible = true;
                pbImage.Visible = true;
                pbImage.ImageLocation = ofd.FileName;
                pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
