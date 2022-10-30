
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLabelGamesLost = new System.Windows.Forms.Label();
            this.lbLabelGamesWon = new System.Windows.Forms.Label();
            this.lbGamesPlayed = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.pnlSidebar2 = new System.Windows.Forms.Panel();
            this.btnAccentColourDisplay = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAccentColour = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.pnlSidebar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.btnAccentColour);
            this.pnlSidebar.Controls.Add(this.label5);
            this.pnlSidebar.Controls.Add(this.label4);
            this.pnlSidebar.Controls.Add(this.label3);
            this.pnlSidebar.Controls.Add(this.label2);
            this.pnlSidebar.Controls.Add(this.lbLabelGamesLost);
            this.pnlSidebar.Controls.Add(this.lbLabelGamesWon);
            this.pnlSidebar.Controls.Add(this.lbGamesPlayed);
            this.pnlSidebar.Controls.Add(this.lbUsername);
            this.pnlSidebar.Controls.Add(this.pbAvatar);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 1);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(146, 461);
            this.pnlSidebar.TabIndex = 0;
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
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(13, 149);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(126, 30);
            this.lbUsername.TabIndex = 5;
            this.lbUsername.Text = "TestAccount";
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
            // pnlSidebar2
            // 
            this.pnlSidebar2.Controls.Add(this.btnAccentColourDisplay);
            this.pnlSidebar2.Controls.Add(this.label14);
            this.pnlSidebar2.Controls.Add(this.label6);
            this.pnlSidebar2.Controls.Add(this.pictureBox1);
            this.pnlSidebar2.Controls.Add(this.label7);
            this.pnlSidebar2.Controls.Add(this.label8);
            this.pnlSidebar2.Controls.Add(this.label9);
            this.pnlSidebar2.Controls.Add(this.label10);
            this.pnlSidebar2.Controls.Add(this.label11);
            this.pnlSidebar2.Controls.Add(this.label12);
            this.pnlSidebar2.Controls.Add(this.label13);
            this.pnlSidebar2.Location = new System.Drawing.Point(1000, 1);
            this.pnlSidebar2.Name = "pnlSidebar2";
            this.pnlSidebar2.Size = new System.Drawing.Size(213, 461);
            this.pnlSidebar2.TabIndex = 1;
            this.pnlSidebar2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSidebar2_Paint);
            // 
            // btnAccentColourDisplay
            // 
            this.btnAccentColourDisplay.Location = new System.Drawing.Point(110, 328);
            this.btnAccentColourDisplay.Name = "btnAccentColourDisplay";
            this.btnAccentColourDisplay.Size = new System.Drawing.Size(96, 30);
            this.btnAccentColourDisplay.TabIndex = 15;
            this.btnAccentColourDisplay.UseVisualStyleBackColor = true;
            this.btnAccentColourDisplay.Click += new System.EventHandler(this.btnAccentColourDisplay_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(8, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 32);
            this.label14.TabIndex = 14;
            this.label14.Text = "Game Statistics";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Accent Colour:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Friends (0)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(138, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 30);
            this.label8.TabIndex = 10;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label9.Location = new System.Drawing.Point(142, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 30);
            this.label9.TabIndex = 9;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 30);
            this.label10.TabIndex = 8;
            this.label10.Text = "Games Lost:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 30);
            this.label11.TabIndex = 7;
            this.label11.Text = "Games Won:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 30);
            this.label12.TabIndex = 6;
            this.label12.Text = "Games Played: 0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(84, 394);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 30);
            this.label13.TabIndex = 5;
            this.label13.Text = "TestAccount";
            // 
            // btnAccentColour
            // 
            this.btnAccentColour.Location = new System.Drawing.Point(7, 345);
            this.btnAccentColour.Name = "btnAccentColour";
            this.btnAccentColour.Size = new System.Drawing.Size(127, 30);
            this.btnAccentColour.TabIndex = 16;
            this.btnAccentColour.UseVisualStyleBackColor = true;
            this.btnAccentColour.Click += new System.EventHandler(this.btnAccentColour_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 528);
            this.Controls.Add(this.pnlSidebar2);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "frmDashboard";
            this.Text = "Risk: Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.pnlSidebar2.ResumeLayout(false);
            this.pnlSidebar2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lbLabelGamesLost;
        private System.Windows.Forms.Label lbLabelGamesWon;
        private System.Windows.Forms.Label lbGamesPlayed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlSidebar2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAccentColourDisplay;
        private System.Windows.Forms.Button btnAccentColour;
    }
}