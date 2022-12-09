
namespace RiskGame
{
    partial class frmGameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameScreen));
            this.pnlPause = new System.Windows.Forms.Panel();
            this.pnlPauseQuit = new System.Windows.Forms.Panel();
            this.pbPauseQuit = new System.Windows.Forms.PictureBox();
            this.lbPauseQuit = new System.Windows.Forms.Label();
            this.pnlPauseSettings = new System.Windows.Forms.Panel();
            this.pbPauseSettings = new System.Windows.Forms.PictureBox();
            this.lbPauseSettings = new System.Windows.Forms.Label();
            this.pnlPauseOverview = new System.Windows.Forms.Panel();
            this.pbPauseOverview = new System.Windows.Forms.PictureBox();
            this.lbPauseOverview = new System.Windows.Forms.Label();
            this.pnlPauseInvite = new System.Windows.Forms.Panel();
            this.pbPauseInvite = new System.Windows.Forms.PictureBox();
            this.bPauseInvite = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.div1 = new System.Windows.Forms.Label();
            this.lbPauseDebugVersion = new System.Windows.Forms.Label();
            this.lbPauseCopyright = new System.Windows.Forms.Label();
            this.lbGamePaused = new System.Windows.Forms.Label();
            this.pnlPauseResume = new System.Windows.Forms.Panel();
            this.pbPauseResume = new System.Windows.Forms.PictureBox();
            this.lbPauseResume = new System.Windows.Forms.Label();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.pnlPause.SuspendLayout();
            this.pnlPauseQuit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPauseQuit)).BeginInit();
            this.pnlPauseSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPauseSettings)).BeginInit();
            this.pnlPauseOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPauseOverview)).BeginInit();
            this.pnlPauseInvite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPauseInvite)).BeginInit();
            this.pnlPauseResume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPauseResume)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPause
            // 
            this.pnlPause.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlPause.Controls.Add(this.pnlPauseQuit);
            this.pnlPause.Controls.Add(this.pnlPauseSettings);
            this.pnlPause.Controls.Add(this.pnlPauseOverview);
            this.pnlPause.Controls.Add(this.pnlPauseInvite);
            this.pnlPause.Controls.Add(this.label2);
            this.pnlPause.Controls.Add(this.div1);
            this.pnlPause.Controls.Add(this.lbPauseDebugVersion);
            this.pnlPause.Controls.Add(this.lbPauseCopyright);
            this.pnlPause.Controls.Add(this.lbGamePaused);
            this.pnlPause.Controls.Add(this.pnlPauseResume);
            this.pnlPause.Location = new System.Drawing.Point(-455, 0);
            this.pnlPause.Name = "pnlPause";
            this.pnlPause.Size = new System.Drawing.Size(455, 813);
            this.pnlPause.TabIndex = 0;
            this.pnlPause.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPause_Paint);
            // 
            // pnlPauseQuit
            // 
            this.pnlPauseQuit.Controls.Add(this.pbPauseQuit);
            this.pnlPauseQuit.Controls.Add(this.lbPauseQuit);
            this.pnlPauseQuit.Location = new System.Drawing.Point(0, 596);
            this.pnlPauseQuit.Name = "pnlPauseQuit";
            this.pnlPauseQuit.Size = new System.Drawing.Size(455, 103);
            this.pnlPauseQuit.TabIndex = 19;
            this.pnlPauseQuit.Click += new System.EventHandler(this.pnlPauseQuit_Click);
            this.pnlPauseQuit.MouseEnter += new System.EventHandler(this.pnlPauseQuit_MouseEnter);
            this.pnlPauseQuit.MouseLeave += new System.EventHandler(this.pnlPauseQuit_MouseLeave);
            // 
            // pbPauseQuit
            // 
            this.pbPauseQuit.BackColor = System.Drawing.Color.Transparent;
            this.pbPauseQuit.Image = global::RiskGame.Properties.Resources.QuitButtonDefault;
            this.pbPauseQuit.Location = new System.Drawing.Point(9, 15);
            this.pbPauseQuit.Name = "pbPauseQuit";
            this.pbPauseQuit.Size = new System.Drawing.Size(77, 71);
            this.pbPauseQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPauseQuit.TabIndex = 6;
            this.pbPauseQuit.TabStop = false;
            this.pbPauseQuit.Click += new System.EventHandler(this.pbPauseQuit_Click);
            this.pbPauseQuit.MouseEnter += new System.EventHandler(this.pbPauseQuit_MouseEnter);
            this.pbPauseQuit.MouseLeave += new System.EventHandler(this.pbPauseQuit_MouseLeave);
            // 
            // lbPauseQuit
            // 
            this.lbPauseQuit.AutoSize = true;
            this.lbPauseQuit.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPauseQuit.Location = new System.Drawing.Point(89, 14);
            this.lbPauseQuit.Name = "lbPauseQuit";
            this.lbPauseQuit.Size = new System.Drawing.Size(255, 65);
            this.lbPauseQuit.TabIndex = 4;
            this.lbPauseQuit.Text = "Quit Game";
            this.lbPauseQuit.Click += new System.EventHandler(this.lbPauseQuit_Click);
            this.lbPauseQuit.MouseEnter += new System.EventHandler(this.lbPauseQuit_MouseEnter);
            this.lbPauseQuit.MouseLeave += new System.EventHandler(this.lbPauseQuit_MouseLeave);
            // 
            // pnlPauseSettings
            // 
            this.pnlPauseSettings.Controls.Add(this.pbPauseSettings);
            this.pnlPauseSettings.Controls.Add(this.lbPauseSettings);
            this.pnlPauseSettings.Location = new System.Drawing.Point(0, 477);
            this.pnlPauseSettings.Name = "pnlPauseSettings";
            this.pnlPauseSettings.Size = new System.Drawing.Size(455, 103);
            this.pnlPauseSettings.TabIndex = 18;
            this.pnlPauseSettings.Click += new System.EventHandler(this.pnlPauseSettings_Click);
            this.pnlPauseSettings.MouseEnter += new System.EventHandler(this.pnlPauseSettings_MouseEnter);
            this.pnlPauseSettings.MouseLeave += new System.EventHandler(this.pnlPauseSettings_MouseLeave);
            // 
            // pbPauseSettings
            // 
            this.pbPauseSettings.BackColor = System.Drawing.Color.Transparent;
            this.pbPauseSettings.Image = global::RiskGame.Properties.Resources.SettingsButtonDefault;
            this.pbPauseSettings.Location = new System.Drawing.Point(12, 15);
            this.pbPauseSettings.Name = "pbPauseSettings";
            this.pbPauseSettings.Size = new System.Drawing.Size(77, 71);
            this.pbPauseSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPauseSettings.TabIndex = 10;
            this.pbPauseSettings.TabStop = false;
            this.pbPauseSettings.Click += new System.EventHandler(this.pbPauseSettings_Click);
            this.pbPauseSettings.MouseEnter += new System.EventHandler(this.pbPauseSettings_MouseEnter);
            this.pbPauseSettings.MouseLeave += new System.EventHandler(this.pbPauseSettings_MouseLeave);
            // 
            // lbPauseSettings
            // 
            this.lbPauseSettings.AutoSize = true;
            this.lbPauseSettings.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPauseSettings.Location = new System.Drawing.Point(92, 14);
            this.lbPauseSettings.Name = "lbPauseSettings";
            this.lbPauseSettings.Size = new System.Drawing.Size(198, 65);
            this.lbPauseSettings.TabIndex = 9;
            this.lbPauseSettings.Text = "Settings";
            this.lbPauseSettings.Click += new System.EventHandler(this.lbPauseSettings_Click);
            this.lbPauseSettings.MouseEnter += new System.EventHandler(this.lbPauseSettings_MouseEnter);
            this.lbPauseSettings.MouseLeave += new System.EventHandler(this.lbPauseSettings_MouseLeave);
            // 
            // pnlPauseOverview
            // 
            this.pnlPauseOverview.Controls.Add(this.pbPauseOverview);
            this.pnlPauseOverview.Controls.Add(this.lbPauseOverview);
            this.pnlPauseOverview.Location = new System.Drawing.Point(0, 358);
            this.pnlPauseOverview.Name = "pnlPauseOverview";
            this.pnlPauseOverview.Size = new System.Drawing.Size(455, 103);
            this.pnlPauseOverview.TabIndex = 17;
            this.pnlPauseOverview.Click += new System.EventHandler(this.pnlPauseOverview_Click);
            this.pnlPauseOverview.MouseEnter += new System.EventHandler(this.pnlPauseOverview_MouseEnter);
            this.pnlPauseOverview.MouseLeave += new System.EventHandler(this.pnlPauseOverview_MouseLeave);
            // 
            // pbPauseOverview
            // 
            this.pbPauseOverview.BackColor = System.Drawing.Color.Transparent;
            this.pbPauseOverview.Image = global::RiskGame.Properties.Resources.OverviewButtonDefault;
            this.pbPauseOverview.Location = new System.Drawing.Point(12, 15);
            this.pbPauseOverview.Name = "pbPauseOverview";
            this.pbPauseOverview.Size = new System.Drawing.Size(77, 71);
            this.pbPauseOverview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPauseOverview.TabIndex = 12;
            this.pbPauseOverview.TabStop = false;
            this.pbPauseOverview.Click += new System.EventHandler(this.pbPauseOverview_Click);
            this.pbPauseOverview.MouseEnter += new System.EventHandler(this.pbPauseOverview_MouseEnter);
            this.pbPauseOverview.MouseLeave += new System.EventHandler(this.pbPauseOverview_MouseLeave);
            // 
            // lbPauseOverview
            // 
            this.lbPauseOverview.AutoSize = true;
            this.lbPauseOverview.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPauseOverview.Location = new System.Drawing.Point(92, 14);
            this.lbPauseOverview.Name = "lbPauseOverview";
            this.lbPauseOverview.Size = new System.Drawing.Size(360, 65);
            this.lbPauseOverview.TabIndex = 11;
            this.lbPauseOverview.Text = "Game Overview";
            this.lbPauseOverview.Click += new System.EventHandler(this.label1_Click);
            this.lbPauseOverview.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lbPauseOverview.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // pnlPauseInvite
            // 
            this.pnlPauseInvite.Controls.Add(this.pbPauseInvite);
            this.pnlPauseInvite.Controls.Add(this.bPauseInvite);
            this.pnlPauseInvite.Location = new System.Drawing.Point(0, 239);
            this.pnlPauseInvite.Name = "pnlPauseInvite";
            this.pnlPauseInvite.Size = new System.Drawing.Size(455, 103);
            this.pnlPauseInvite.TabIndex = 16;
            this.pnlPauseInvite.Click += new System.EventHandler(this.pnlPauseInvite_Click);
            this.pnlPauseInvite.MouseEnter += new System.EventHandler(this.pnlPauseInvite_MouseEnter);
            this.pnlPauseInvite.MouseLeave += new System.EventHandler(this.pnlPauseInvite_MouseLeave);
            // 
            // pbPauseInvite
            // 
            this.pbPauseInvite.BackColor = System.Drawing.Color.Transparent;
            this.pbPauseInvite.Image = global::RiskGame.Properties.Resources.InviteButtonDefault;
            this.pbPauseInvite.Location = new System.Drawing.Point(12, 15);
            this.pbPauseInvite.Name = "pbPauseInvite";
            this.pbPauseInvite.Size = new System.Drawing.Size(77, 71);
            this.pbPauseInvite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPauseInvite.TabIndex = 8;
            this.pbPauseInvite.TabStop = false;
            this.pbPauseInvite.Click += new System.EventHandler(this.pbPauseInvite_Click);
            this.pbPauseInvite.MouseEnter += new System.EventHandler(this.pbPauseInvite_MouseEnter);
            this.pbPauseInvite.MouseLeave += new System.EventHandler(this.pbPauseInvite_MouseLeave);
            // 
            // bPauseInvite
            // 
            this.bPauseInvite.AutoSize = true;
            this.bPauseInvite.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPauseInvite.Location = new System.Drawing.Point(92, 14);
            this.bPauseInvite.Name = "bPauseInvite";
            this.bPauseInvite.Size = new System.Drawing.Size(309, 65);
            this.bPauseInvite.TabIndex = 7;
            this.bPauseInvite.Text = "Invite Friends";
            this.bPauseInvite.Click += new System.EventHandler(this.bPauseInvite_Click);
            this.bPauseInvite.MouseEnter += new System.EventHandler(this.bPauseInvite_MouseEnter);
            this.bPauseInvite.MouseLeave += new System.EventHandler(this.bPauseInvite_MouseLeave);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(41, 730);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 2);
            this.label2.TabIndex = 14;
            // 
            // div1
            // 
            this.div1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.div1.Location = new System.Drawing.Point(31, 80);
            this.div1.Name = "div1";
            this.div1.Size = new System.Drawing.Size(393, 2);
            this.div1.TabIndex = 13;
            // 
            // lbPauseDebugVersion
            // 
            this.lbPauseDebugVersion.AutoSize = true;
            this.lbPauseDebugVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPauseDebugVersion.Location = new System.Drawing.Point(135, 745);
            this.lbPauseDebugVersion.Name = "lbPauseDebugVersion";
            this.lbPauseDebugVersion.Size = new System.Drawing.Size(139, 21);
            this.lbPauseDebugVersion.TabIndex = 3;
            this.lbPauseDebugVersion.Text = "Risk; Ver. PreAlpha";
            // 
            // lbPauseCopyright
            // 
            this.lbPauseCopyright.AutoSize = true;
            this.lbPauseCopyright.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPauseCopyright.Location = new System.Drawing.Point(51, 766);
            this.lbPauseCopyright.Name = "lbPauseCopyright";
            this.lbPauseCopyright.Size = new System.Drawing.Size(311, 30);
            this.lbPauseCopyright.TabIndex = 2;
            this.lbPauseCopyright.Text = "Copyright (C) Risk Game, 2022-3";
            // 
            // lbGamePaused
            // 
            this.lbGamePaused.AutoSize = true;
            this.lbGamePaused.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGamePaused.Location = new System.Drawing.Point(94, 20);
            this.lbGamePaused.Name = "lbGamePaused";
            this.lbGamePaused.Size = new System.Drawing.Size(244, 50);
            this.lbGamePaused.TabIndex = 0;
            this.lbGamePaused.Text = "Game Paused";
            this.lbGamePaused.Click += new System.EventHandler(this.lbGamePaused_Click);
            // 
            // pnlPauseResume
            // 
            this.pnlPauseResume.Controls.Add(this.pbPauseResume);
            this.pnlPauseResume.Controls.Add(this.lbPauseResume);
            this.pnlPauseResume.Location = new System.Drawing.Point(0, 120);
            this.pnlPauseResume.Name = "pnlPauseResume";
            this.pnlPauseResume.Size = new System.Drawing.Size(455, 103);
            this.pnlPauseResume.TabIndex = 15;
            this.pnlPauseResume.Click += new System.EventHandler(this.pnlPauseResume_Click);
            this.pnlPauseResume.MouseEnter += new System.EventHandler(this.pnlPauseResume_MouseEnter);
            this.pnlPauseResume.MouseLeave += new System.EventHandler(this.pnlPauseResume_MouseLeave);
            // 
            // pbPauseResume
            // 
            this.pbPauseResume.BackColor = System.Drawing.Color.Transparent;
            this.pbPauseResume.Image = global::RiskGame.Properties.Resources.PlayButtonDefault;
            this.pbPauseResume.Location = new System.Drawing.Point(9, 17);
            this.pbPauseResume.Name = "pbPauseResume";
            this.pbPauseResume.Size = new System.Drawing.Size(77, 71);
            this.pbPauseResume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPauseResume.TabIndex = 5;
            this.pbPauseResume.TabStop = false;
            this.pbPauseResume.Click += new System.EventHandler(this.pbPauseResume_Click);
            this.pbPauseResume.MouseEnter += new System.EventHandler(this.pbPauseResume_MouseEnter);
            this.pbPauseResume.MouseLeave += new System.EventHandler(this.pbPauseResume_MouseLeave);
            // 
            // lbPauseResume
            // 
            this.lbPauseResume.AutoSize = true;
            this.lbPauseResume.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPauseResume.Location = new System.Drawing.Point(89, 17);
            this.lbPauseResume.Name = "lbPauseResume";
            this.lbPauseResume.Size = new System.Drawing.Size(330, 65);
            this.lbPauseResume.TabIndex = 1;
            this.lbPauseResume.Text = "Resume Game";
            this.lbPauseResume.Click += new System.EventHandler(this.lbPauseResume_Click);
            this.lbPauseResume.MouseEnter += new System.EventHandler(this.lbPauseResume_MouseEnter);
            this.lbPauseResume.MouseLeave += new System.EventHandler(this.lbPauseResume_MouseLeave);
            // 
            // pnlBase
            // 
            this.pnlBase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBase.BackgroundImage")));
            this.pnlBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBase.Location = new System.Drawing.Point(3, 12);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(1569, 784);
            this.pnlBase.TabIndex = 1;
            this.pnlBase.Click += new System.EventHandler(this.pnlBase_Click);
            this.pnlBase.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBase_Paint);
            // 
            // frmGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 813);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.pnlPause);
            this.Name = "frmGameScreen";
            this.Text = "Risk: Game Screen";
            this.Load += new System.EventHandler(this.frmGameScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGameScreen_KeyDown);
            this.pnlPause.ResumeLayout(false);
            this.pnlPause.PerformLayout();
            this.pnlPauseQuit.ResumeLayout(false);
            this.pnlPauseQuit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPauseQuit)).EndInit();
            this.pnlPauseSettings.ResumeLayout(false);
            this.pnlPauseSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPauseSettings)).EndInit();
            this.pnlPauseOverview.ResumeLayout(false);
            this.pnlPauseOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPauseOverview)).EndInit();
            this.pnlPauseInvite.ResumeLayout(false);
            this.pnlPauseInvite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPauseInvite)).EndInit();
            this.pnlPauseResume.ResumeLayout(false);
            this.pnlPauseResume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPauseResume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPause;
        private System.Windows.Forms.Label lbGamePaused;
        private System.Windows.Forms.Label lbPauseResume;
        private System.Windows.Forms.Label lbPauseCopyright;
        private System.Windows.Forms.Label lbPauseDebugVersion;
        private System.Windows.Forms.Label lbPauseQuit;
        private System.Windows.Forms.PictureBox pbPauseResume;
        private System.Windows.Forms.PictureBox pbPauseOverview;
        private System.Windows.Forms.Label lbPauseOverview;
        private System.Windows.Forms.PictureBox pbPauseSettings;
        private System.Windows.Forms.Label lbPauseSettings;
        private System.Windows.Forms.PictureBox pbPauseInvite;
        private System.Windows.Forms.Label bPauseInvite;
        private System.Windows.Forms.PictureBox pbPauseQuit;
        private System.Windows.Forms.Label div1;
        private System.Windows.Forms.Panel pnlPauseQuit;
        private System.Windows.Forms.Panel pnlPauseSettings;
        private System.Windows.Forms.Panel pnlPauseOverview;
        private System.Windows.Forms.Panel pnlPauseInvite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlPauseResume;
        private System.Windows.Forms.Panel pnlBase;
    }
}