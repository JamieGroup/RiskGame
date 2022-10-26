
namespace RiskGame
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lbGamesPlayed = new System.Windows.Forms.Label();
            this.lbLabelGamesWon = new System.Windows.Forms.Label();
            this.lbLabelGamesLost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccentColour = new System.Windows.Forms.TextBox();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.txtAccentColour);
            this.pnlSidebar.Controls.Add(this.label5);
            this.pnlSidebar.Controls.Add(this.label4);
            this.pnlSidebar.Controls.Add(this.label3);
            this.pnlSidebar.Controls.Add(this.label2);
            this.pnlSidebar.Controls.Add(this.lbLabelGamesLost);
            this.pnlSidebar.Controls.Add(this.lbLabelGamesWon);
            this.pnlSidebar.Controls.Add(this.lbGamesPlayed);
            this.pnlSidebar.Controls.Add(this.label1);
            this.pnlSidebar.Controls.Add(this.pbAvatar);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 1);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(146, 461);
            this.pnlSidebar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "TestAccount";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.Location = new System.Drawing.Point(1, 3);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(145, 143);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 4;
            this.pbAvatar.TabStop = false;
            // 
            // lbGamesPlayed
            // 
            this.lbGamesPlayed.AutoSize = true;
            this.lbGamesPlayed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGamesPlayed.Location = new System.Drawing.Point(12, 179);
            this.lbGamesPlayed.Name = "lbGamesPlayed";
            this.lbGamesPlayed.Size = new System.Drawing.Size(124, 21);
            this.lbGamesPlayed.TabIndex = 6;
            this.lbGamesPlayed.Text = "Games Played: 0";
            // 
            // lbLabelGamesWon
            // 
            this.lbLabelGamesWon.AutoSize = true;
            this.lbLabelGamesWon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabelGamesWon.Location = new System.Drawing.Point(11, 210);
            this.lbLabelGamesWon.Name = "lbLabelGamesWon";
            this.lbLabelGamesWon.Size = new System.Drawing.Size(97, 21);
            this.lbLabelGamesWon.TabIndex = 7;
            this.lbLabelGamesWon.Text = "Games Won:";
            // 
            // lbLabelGamesLost
            // 
            this.lbLabelGamesLost.AutoSize = true;
            this.lbLabelGamesLost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabelGamesLost.Location = new System.Drawing.Point(12, 240);
            this.lbLabelGamesLost.Name = "lbLabelGamesLost";
            this.lbLabelGamesLost.Size = new System.Drawing.Size(94, 21);
            this.lbLabelGamesLost.TabIndex = 8;
            this.lbLabelGamesLost.Text = "Games Lost:";
            this.lbLabelGamesLost.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(103, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(103, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Friends (0)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Accent Colour";
            // 
            // txtAccentColour
            // 
            this.txtAccentColour.BackColor = System.Drawing.Color.Yellow;
            this.txtAccentColour.Cursor = System.Windows.Forms.Cursors.No;
            this.txtAccentColour.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccentColour.Location = new System.Drawing.Point(8, 345);
            this.txtAccentColour.Name = "txtAccentColour";
            this.txtAccentColour.ReadOnly = true;
            this.txtAccentColour.Size = new System.Drawing.Size(131, 35);
            this.txtAccentColour.TabIndex = 13;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "frmDashboard";
            this.Text = "Risk: Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lbLabelGamesLost;
        private System.Windows.Forms.Label lbLabelGamesWon;
        private System.Windows.Forms.Label lbGamesPlayed;
        private System.Windows.Forms.TextBox txtAccentColour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}