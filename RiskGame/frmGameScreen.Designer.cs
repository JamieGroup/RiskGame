
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
            this.pnlPause = new System.Windows.Forms.Panel();
            this.lbGamePaused = new System.Windows.Forms.Label();
            this.lbPauseResume = new System.Windows.Forms.Label();
            this.lbPauseCopyright = new System.Windows.Forms.Label();
            this.lbPauseDebugVersion = new System.Windows.Forms.Label();
            this.lbPauseQuit = new System.Windows.Forms.Label();
            this.pnlPause.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPause
            // 
            this.pnlPause.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlPause.Controls.Add(this.lbPauseQuit);
            this.pnlPause.Controls.Add(this.lbPauseDebugVersion);
            this.pnlPause.Controls.Add(this.lbPauseCopyright);
            this.pnlPause.Controls.Add(this.lbPauseResume);
            this.pnlPause.Controls.Add(this.lbGamePaused);
            this.pnlPause.Location = new System.Drawing.Point(0, 0);
            this.pnlPause.Name = "pnlPause";
            this.pnlPause.Size = new System.Drawing.Size(450, 858);
            this.pnlPause.TabIndex = 0;
            // 
            // lbGamePaused
            // 
            this.lbGamePaused.AutoSize = true;
            this.lbGamePaused.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGamePaused.Location = new System.Drawing.Point(85, 39);
            this.lbGamePaused.Name = "lbGamePaused";
            this.lbGamePaused.Size = new System.Drawing.Size(244, 50);
            this.lbGamePaused.TabIndex = 0;
            this.lbGamePaused.Text = "Game Paused";
            this.lbGamePaused.Click += new System.EventHandler(this.lbGamePaused_Click);
            // 
            // lbPauseResume
            // 
            this.lbPauseResume.AutoSize = true;
            this.lbPauseResume.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPauseResume.Location = new System.Drawing.Point(83, 151);
            this.lbPauseResume.Name = "lbPauseResume";
            this.lbPauseResume.Size = new System.Drawing.Size(330, 65);
            this.lbPauseResume.TabIndex = 1;
            this.lbPauseResume.Text = "Resume Game";
            this.lbPauseResume.Click += new System.EventHandler(this.lbPauseResume_Click);
            // 
            // lbPauseCopyright
            // 
            this.lbPauseCopyright.AutoSize = true;
            this.lbPauseCopyright.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPauseCopyright.Location = new System.Drawing.Point(51, 824);
            this.lbPauseCopyright.Name = "lbPauseCopyright";
            this.lbPauseCopyright.Size = new System.Drawing.Size(311, 30);
            this.lbPauseCopyright.TabIndex = 2;
            this.lbPauseCopyright.Text = "Copyright (C) Risk Game, 2022-3";
            // 
            // lbPauseDebugVersion
            // 
            this.lbPauseDebugVersion.AutoSize = true;
            this.lbPauseDebugVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPauseDebugVersion.Location = new System.Drawing.Point(135, 803);
            this.lbPauseDebugVersion.Name = "lbPauseDebugVersion";
            this.lbPauseDebugVersion.Size = new System.Drawing.Size(139, 21);
            this.lbPauseDebugVersion.TabIndex = 3;
            this.lbPauseDebugVersion.Text = "Risk; Ver. PreAlpha";
            // 
            // lbPauseQuit
            // 
            this.lbPauseQuit.AutoSize = true;
            this.lbPauseQuit.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPauseQuit.Location = new System.Drawing.Point(83, 665);
            this.lbPauseQuit.Name = "lbPauseQuit";
            this.lbPauseQuit.Size = new System.Drawing.Size(255, 65);
            this.lbPauseQuit.TabIndex = 4;
            this.lbPauseQuit.Text = "Quit Game";
            this.lbPauseQuit.Click += new System.EventHandler(this.lbPauseQuit_Click);
            // 
            // frmGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.pnlPause);
            this.Name = "frmGameScreen";
            this.Text = "Risk: Game Screen";
            this.Load += new System.EventHandler(this.frmGameScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGameScreen_KeyDown);
            this.pnlPause.ResumeLayout(false);
            this.pnlPause.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPause;
        private System.Windows.Forms.Label lbGamePaused;
        private System.Windows.Forms.Label lbPauseResume;
        private System.Windows.Forms.Label lbPauseCopyright;
        private System.Windows.Forms.Label lbPauseDebugVersion;
        private System.Windows.Forms.Label lbPauseQuit;
    }
}