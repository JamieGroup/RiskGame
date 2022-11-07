
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
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
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
            this.label4.Location = new System.Drawing.Point(34, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Friends (0)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(95, 276);
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
            this.label2.Location = new System.Drawing.Point(95, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            // 
            // lbLabelGamesLost
            // 
            this.lbLabelGamesLost.AutoSize = true;
            this.lbLabelGamesLost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lbGamesPlayed.Location = new System.Drawing.Point(4, 215);
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
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 528);
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
    }
}