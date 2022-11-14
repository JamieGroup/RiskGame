﻿
namespace RiskGame
{
    partial class frmTutorial
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
            this.lbQuestion = new System.Windows.Forms.Label();
            this.pnlAns1 = new System.Windows.Forms.Panel();
            this.lbAns1 = new System.Windows.Forms.Label();
            this.pbAns1 = new System.Windows.Forms.PictureBox();
            this.pnlAns2 = new System.Windows.Forms.Panel();
            this.lbAns2 = new System.Windows.Forms.Label();
            this.pbAns2 = new System.Windows.Forms.PictureBox();
            this.pnlAns3 = new System.Windows.Forms.Panel();
            this.lbAns3 = new System.Windows.Forms.Label();
            this.pbAns3 = new System.Windows.Forms.PictureBox();
            this.pnlAns4 = new System.Windows.Forms.Panel();
            this.lbAns4 = new System.Windows.Forms.Label();
            this.pbAns4 = new System.Windows.Forms.PictureBox();
            this.pbTutorialAnimatedScreen = new System.Windows.Forms.PictureBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbQNum = new System.Windows.Forms.Label();
            this.pnlAns1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns1)).BeginInit();
            this.pnlAns2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns2)).BeginInit();
            this.pnlAns3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns3)).BeginInit();
            this.pnlAns4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTutorialAnimatedScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lbQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.Location = new System.Drawing.Point(12, 25);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(481, 65);
            this.lbQuestion.TabIndex = 1;
            this.lbQuestion.Text = "Question Goes Here!";
            // 
            // pnlAns1
            // 
            this.pnlAns1.Controls.Add(this.lbAns1);
            this.pnlAns1.Controls.Add(this.pbAns1);
            this.pnlAns1.Location = new System.Drawing.Point(0, 173);
            this.pnlAns1.Name = "pnlAns1";
            this.pnlAns1.Size = new System.Drawing.Size(570, 132);
            this.pnlAns1.TabIndex = 6;
            this.pnlAns1.Click += new System.EventHandler(this.pnlAns1_Click);
            // 
            // lbAns1
            // 
            this.lbAns1.AutoSize = true;
            this.lbAns1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAns1.Location = new System.Drawing.Point(109, 54);
            this.lbAns1.Name = "lbAns1";
            this.lbAns1.Size = new System.Drawing.Size(149, 45);
            this.lbAns1.TabIndex = 3;
            this.lbAns1.Text = "Answer 1";
            this.lbAns1.Click += new System.EventHandler(this.lbAns1_Click);
            // 
            // pbAns1
            // 
            this.pbAns1.Image = global::RiskGame.Properties.Resources.Tutorial_Checkbox;
            this.pbAns1.Location = new System.Drawing.Point(12, 27);
            this.pbAns1.Name = "pbAns1";
            this.pbAns1.Size = new System.Drawing.Size(91, 85);
            this.pbAns1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAns1.TabIndex = 2;
            this.pbAns1.TabStop = false;
            this.pbAns1.Click += new System.EventHandler(this.pbAns1Check_Click);
            // 
            // pnlAns2
            // 
            this.pnlAns2.Controls.Add(this.lbAns2);
            this.pnlAns2.Controls.Add(this.pbAns2);
            this.pnlAns2.Location = new System.Drawing.Point(0, 357);
            this.pnlAns2.Name = "pnlAns2";
            this.pnlAns2.Size = new System.Drawing.Size(570, 132);
            this.pnlAns2.TabIndex = 7;
            this.pnlAns2.Click += new System.EventHandler(this.pnlAns2_Click);
            // 
            // lbAns2
            // 
            this.lbAns2.AutoSize = true;
            this.lbAns2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lbAns2.Location = new System.Drawing.Point(109, 54);
            this.lbAns2.Name = "lbAns2";
            this.lbAns2.Size = new System.Drawing.Size(154, 45);
            this.lbAns2.TabIndex = 4;
            this.lbAns2.Text = "Answer 2";
            this.lbAns2.Click += new System.EventHandler(this.lbAns2_Click);
            // 
            // pbAns2
            // 
            this.pbAns2.Image = global::RiskGame.Properties.Resources.Tutorial_Checkbox;
            this.pbAns2.Location = new System.Drawing.Point(12, 28);
            this.pbAns2.Name = "pbAns2";
            this.pbAns2.Size = new System.Drawing.Size(91, 85);
            this.pbAns2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAns2.TabIndex = 3;
            this.pbAns2.TabStop = false;
            this.pbAns2.Click += new System.EventHandler(this.pbAns2Check_Click);
            // 
            // pnlAns3
            // 
            this.pnlAns3.Controls.Add(this.lbAns3);
            this.pnlAns3.Controls.Add(this.pbAns3);
            this.pnlAns3.Location = new System.Drawing.Point(596, 173);
            this.pnlAns3.Name = "pnlAns3";
            this.pnlAns3.Size = new System.Drawing.Size(589, 132);
            this.pnlAns3.TabIndex = 8;
            this.pnlAns3.Click += new System.EventHandler(this.pnlAns3_Click);
            // 
            // lbAns3
            // 
            this.lbAns3.AutoSize = true;
            this.lbAns3.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lbAns3.Location = new System.Drawing.Point(107, 54);
            this.lbAns3.Name = "lbAns3";
            this.lbAns3.Size = new System.Drawing.Size(154, 45);
            this.lbAns3.TabIndex = 5;
            this.lbAns3.Text = "Answer 3";
            this.lbAns3.Click += new System.EventHandler(this.lbAns3_Click);
            // 
            // pbAns3
            // 
            this.pbAns3.Image = global::RiskGame.Properties.Resources.Tutorial_Checkbox;
            this.pbAns3.Location = new System.Drawing.Point(10, 27);
            this.pbAns3.Name = "pbAns3";
            this.pbAns3.Size = new System.Drawing.Size(91, 85);
            this.pbAns3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAns3.TabIndex = 4;
            this.pbAns3.TabStop = false;
            this.pbAns3.Click += new System.EventHandler(this.pbAns3Check_Click);
            // 
            // pnlAns4
            // 
            this.pnlAns4.Controls.Add(this.lbAns4);
            this.pnlAns4.Controls.Add(this.pbAns4);
            this.pnlAns4.Location = new System.Drawing.Point(596, 357);
            this.pnlAns4.Name = "pnlAns4";
            this.pnlAns4.Size = new System.Drawing.Size(589, 132);
            this.pnlAns4.TabIndex = 9;
            this.pnlAns4.Click += new System.EventHandler(this.pnlAns4_Click);
            // 
            // lbAns4
            // 
            this.lbAns4.AutoSize = true;
            this.lbAns4.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lbAns4.Location = new System.Drawing.Point(107, 57);
            this.lbAns4.Name = "lbAns4";
            this.lbAns4.Size = new System.Drawing.Size(154, 45);
            this.lbAns4.TabIndex = 6;
            this.lbAns4.Text = "Answer 4";
            this.lbAns4.Click += new System.EventHandler(this.lbAns4_Click);
            // 
            // pbAns4
            // 
            this.pbAns4.Image = global::RiskGame.Properties.Resources.Tutorial_Checkbox;
            this.pbAns4.Location = new System.Drawing.Point(10, 31);
            this.pbAns4.Name = "pbAns4";
            this.pbAns4.Size = new System.Drawing.Size(91, 85);
            this.pbAns4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAns4.TabIndex = 5;
            this.pbAns4.TabStop = false;
            this.pbAns4.Click += new System.EventHandler(this.pbAns4Check_Click);
            // 
            // pbTutorialAnimatedScreen
            // 
            this.pbTutorialAnimatedScreen.Image = global::RiskGame.Properties.Resources.Tutorial_Animated_Screen_long;
            this.pbTutorialAnimatedScreen.Location = new System.Drawing.Point(0, -2);
            this.pbTutorialAnimatedScreen.Name = "pbTutorialAnimatedScreen";
            this.pbTutorialAnimatedScreen.Size = new System.Drawing.Size(1185, 120);
            this.pbTutorialAnimatedScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTutorialAnimatedScreen.TabIndex = 0;
            this.pbTutorialAnimatedScreen.TabStop = false;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(1089, 132);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(83, 25);
            this.lbScore.TabIndex = 10;
            this.lbScore.Text = "Score: 0";
            // 
            // lbQNum
            // 
            this.lbQNum.AutoSize = true;
            this.lbQNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQNum.Location = new System.Drawing.Point(12, 132);
            this.lbQNum.Name = "lbQNum";
            this.lbQNum.Size = new System.Drawing.Size(113, 25);
            this.lbQNum.TabIndex = 11;
            this.lbQNum.Text = "Question: 1";
            // 
            // frmTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 488);
            this.Controls.Add(this.lbQNum);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.pnlAns4);
            this.Controls.Add(this.pnlAns3);
            this.Controls.Add(this.pnlAns2);
            this.Controls.Add(this.pnlAns1);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.pbTutorialAnimatedScreen);
            this.Name = "frmTutorial";
            this.Text = "Risk: Tutorial";
            this.Load += new System.EventHandler(this.frmTutorial_Load);
            this.pnlAns1.ResumeLayout(false);
            this.pnlAns1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns1)).EndInit();
            this.pnlAns2.ResumeLayout(false);
            this.pnlAns2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns2)).EndInit();
            this.pnlAns3.ResumeLayout(false);
            this.pnlAns3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns3)).EndInit();
            this.pnlAns4.ResumeLayout(false);
            this.pnlAns4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTutorialAnimatedScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTutorialAnimatedScreen;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.PictureBox pbAns1;
        private System.Windows.Forms.PictureBox pbAns2;
        private System.Windows.Forms.PictureBox pbAns3;
        private System.Windows.Forms.PictureBox pbAns4;
        private System.Windows.Forms.Panel pnlAns1;
        private System.Windows.Forms.Panel pnlAns2;
        private System.Windows.Forms.Panel pnlAns3;
        private System.Windows.Forms.Panel pnlAns4;
        private System.Windows.Forms.Label lbAns1;
        private System.Windows.Forms.Label lbAns2;
        private System.Windows.Forms.Label lbAns3;
        private System.Windows.Forms.Label lbAns4;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbQNum;
    }
}