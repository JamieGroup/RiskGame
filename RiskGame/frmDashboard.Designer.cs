
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.btnAccentColour = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLabelGamesLost = new System.Windows.Forms.Label();
            this.lbLabelGamesWon = new System.Windows.Forms.Label();
            this.lbGamesPlayed = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lbTutorialEasy = new System.Windows.Forms.Label();
            this.lbTutorialHard = new System.Windows.Forms.Label();
            this.lbSkipTutorial = new System.Windows.Forms.Label();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.pbTutorialEasy = new System.Windows.Forms.PictureBox();
            this.pbTutorialHard = new System.Windows.Forms.PictureBox();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTutorialEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTutorialHard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.Transparent;
            this.pnlSidebar.Controls.Add(this.label6);
            this.pnlSidebar.Controls.Add(this.pbAdmin);
            this.pnlSidebar.Controls.Add(this.pbLogout);
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
            this.pnlSidebar.Size = new System.Drawing.Size(146, 528);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pbAdmin
            // 
            this.pbAdmin.Image = global::RiskGame.Properties.Resources.adminscreenicon;
            this.pbAdmin.Location = new System.Drawing.Point(3, 383);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(140, 68);
            this.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdmin.TabIndex = 17;
            this.pbAdmin.TabStop = false;
            this.pbAdmin.Click += new System.EventHandler(this.pbAdmin_Click);
            // 
            // pbLogout
            // 
            this.pbLogout.Image = global::RiskGame.Properties.Resources.LogoutButton_Resize;
            this.pbLogout.Location = new System.Drawing.Point(3, 457);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(140, 68);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogout.TabIndex = 2;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbLogout.MouseEnter += new System.EventHandler(this.pbLogout_MouseEnter);
            this.pbLogout.MouseLeave += new System.EventHandler(this.pbLogout_MouseLeave);
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
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Friends (0)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(95, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(95, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            // 
            // lbLabelGamesLost
            // 
            this.lbLabelGamesLost.AutoSize = true;
            this.lbLabelGamesLost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLabelGamesLost.ForeColor = System.Drawing.Color.White;
            this.lbLabelGamesLost.Location = new System.Drawing.Point(4, 276);
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
            this.lbLabelGamesWon.ForeColor = System.Drawing.Color.White;
            this.lbLabelGamesWon.Location = new System.Drawing.Point(3, 246);
            this.lbLabelGamesWon.Name = "lbLabelGamesWon";
            this.lbLabelGamesWon.Size = new System.Drawing.Size(97, 21);
            this.lbLabelGamesWon.TabIndex = 7;
            this.lbLabelGamesWon.Text = "Games Won:";
            // 
            // lbGamesPlayed
            // 
            this.lbGamesPlayed.AutoSize = true;
            this.lbGamesPlayed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGamesPlayed.ForeColor = System.Drawing.Color.White;
            this.lbGamesPlayed.Location = new System.Drawing.Point(4, 215);
            this.lbGamesPlayed.Name = "lbGamesPlayed";
            this.lbGamesPlayed.Size = new System.Drawing.Size(111, 21);
            this.lbGamesPlayed.TabIndex = 6;
            this.lbGamesPlayed.Text = "Games Played:";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
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
            this.pbAvatar.Click += new System.EventHandler(this.pbAvatar_Click);
            // 
            // lbTutorialEasy
            // 
            this.lbTutorialEasy.AutoSize = true;
            this.lbTutorialEasy.BackColor = System.Drawing.Color.Transparent;
            this.lbTutorialEasy.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTutorialEasy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTutorialEasy.Location = new System.Drawing.Point(485, 471);
            this.lbTutorialEasy.Name = "lbTutorialEasy";
            this.lbTutorialEasy.Size = new System.Drawing.Size(88, 25);
            this.lbTutorialEasy.TabIndex = 4;
            this.lbTutorialEasy.Text = "Beginner";
            // 
            // lbTutorialHard
            // 
            this.lbTutorialHard.AutoSize = true;
            this.lbTutorialHard.BackColor = System.Drawing.Color.Transparent;
            this.lbTutorialHard.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTutorialHard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTutorialHard.Location = new System.Drawing.Point(654, 471);
            this.lbTutorialHard.Name = "lbTutorialHard";
            this.lbTutorialHard.Size = new System.Drawing.Size(123, 25);
            this.lbTutorialHard.TabIndex = 5;
            this.lbTutorialHard.Text = "Intermediate";
            // 
            // lbSkipTutorial
            // 
            this.lbSkipTutorial.AutoSize = true;
            this.lbSkipTutorial.BackColor = System.Drawing.Color.Transparent;
            this.lbSkipTutorial.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSkipTutorial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSkipTutorial.Location = new System.Drawing.Point(783, 420);
            this.lbSkipTutorial.Name = "lbSkipTutorial";
            this.lbSkipTutorial.Size = new System.Drawing.Size(244, 25);
            this.lbSkipTutorial.TabIndex = 6;
            this.lbSkipTutorial.Text = "I\'m an expert! Skip Tutorial";
            this.lbSkipTutorial.Click += new System.EventHandler(this.lbSkipTutorial_Click);
            // 
            // tmrTick
            // 
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // pbTutorialEasy
            // 
            this.pbTutorialEasy.Image = global::RiskGame.Properties.Resources.book;
            this.pbTutorialEasy.Location = new System.Drawing.Point(466, 365);
            this.pbTutorialEasy.Name = "pbTutorialEasy";
            this.pbTutorialEasy.Size = new System.Drawing.Size(132, 103);
            this.pbTutorialEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTutorialEasy.TabIndex = 3;
            this.pbTutorialEasy.TabStop = false;
            this.pbTutorialEasy.Click += new System.EventHandler(this.pbTutorialEasy_Click);
            // 
            // pbTutorialHard
            // 
            this.pbTutorialHard.Image = global::RiskGame.Properties.Resources.sword;
            this.pbTutorialHard.Location = new System.Drawing.Point(649, 365);
            this.pbTutorialHard.Name = "pbTutorialHard";
            this.pbTutorialHard.Size = new System.Drawing.Size(128, 103);
            this.pbTutorialHard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTutorialHard.TabIndex = 2;
            this.pbTutorialHard.TabStop = false;
            this.pbTutorialHard.Click += new System.EventHandler(this.pbTutorialHard_Click);
            // 
            // pbPlay
            // 
            this.pbPlay.Image = global::RiskGame.Properties.Resources.PlayTutorialAnimation;
            this.pbPlay.Location = new System.Drawing.Point(447, 161);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(465, 182);
            this.pbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlay.TabIndex = 1;
            this.pbPlay.TabStop = false;
            this.pbPlay.Click += new System.EventHandler(this.pbPlay_Click);
            this.pbPlay.MouseEnter += new System.EventHandler(this.pbPlay_MouseEnter);
            this.pbPlay.MouseLeave += new System.EventHandler(this.pbPlay_MouseLeave);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.Location = new System.Drawing.Point(1006, 12);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(200, 50);
            this.btnFeedback.TabIndex = 7;
            this.btnFeedback.Text = "Send Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(555, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Games Played";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(110, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "0";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RiskGame.Properties.Resources.loginBackground1;
            this.ClientSize = new System.Drawing.Size(1218, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.lbSkipTutorial);
            this.Controls.Add(this.lbTutorialHard);
            this.Controls.Add(this.lbTutorialEasy);
            this.Controls.Add(this.pbTutorialEasy);
            this.Controls.Add(this.pbTutorialHard);
            this.Controls.Add(this.pbPlay);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "frmDashboard";
            this.Text = "Risk: Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDashboard_FormClosing);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.Enter += new System.EventHandler(this.frmDashboard_Enter);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTutorialEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTutorialHard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnAccentColour;
        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.PictureBox pbTutorialHard;
        private System.Windows.Forms.PictureBox pbTutorialEasy;
        private System.Windows.Forms.Label lbTutorialEasy;
        private System.Windows.Forms.Label lbTutorialHard;
        private System.Windows.Forms.Label lbSkipTutorial;
        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.PictureBox pbAdmin;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}