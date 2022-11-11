
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
            this.pnlAns2 = new System.Windows.Forms.Panel();
            this.lbAns2 = new System.Windows.Forms.Label();
            this.pnlAns3 = new System.Windows.Forms.Panel();
            this.lbAns3 = new System.Windows.Forms.Label();
            this.pnlAns4 = new System.Windows.Forms.Panel();
            this.lbAns4 = new System.Windows.Forms.Label();
            this.pbAns4Check = new System.Windows.Forms.PictureBox();
            this.pbAns3Check = new System.Windows.Forms.PictureBox();
            this.pbAns2Check = new System.Windows.Forms.PictureBox();
            this.pbAns1Check = new System.Windows.Forms.PictureBox();
            this.pbTutorialAnimatedScreen = new System.Windows.Forms.PictureBox();
            this.pbCheckAnswers = new System.Windows.Forms.PictureBox();
            this.lbCheck = new System.Windows.Forms.Label();
            this.pnlAns1.SuspendLayout();
            this.pnlAns2.SuspendLayout();
            this.pnlAns3.SuspendLayout();
            this.pnlAns4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns4Check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns3Check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns2Check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns1Check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTutorialAnimatedScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckAnswers)).BeginInit();
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
            this.pnlAns1.Controls.Add(this.pbAns1Check);
            this.pnlAns1.Location = new System.Drawing.Point(0, 173);
            this.pnlAns1.Name = "pnlAns1";
            this.pnlAns1.Size = new System.Drawing.Size(570, 132);
            this.pnlAns1.TabIndex = 6;
            this.pnlAns1.Click += new System.EventHandler(this.pnlAns1_Click);
            // 
            // lbAns1
            // 
            this.lbAns1.AutoSize = true;
            this.lbAns1.Font = new System.Drawing.Font("Segoe UI Semibold", 32F, System.Drawing.FontStyle.Bold);
            this.lbAns1.Location = new System.Drawing.Point(157, 43);
            this.lbAns1.Name = "lbAns1";
            this.lbAns1.Size = new System.Drawing.Size(199, 59);
            this.lbAns1.TabIndex = 3;
            this.lbAns1.Text = "Answer 1";
            this.lbAns1.Click += new System.EventHandler(this.lbAns1_Click);
            // 
            // pnlAns2
            // 
            this.pnlAns2.Controls.Add(this.lbAns2);
            this.pnlAns2.Controls.Add(this.pbAns2Check);
            this.pnlAns2.Location = new System.Drawing.Point(0, 357);
            this.pnlAns2.Name = "pnlAns2";
            this.pnlAns2.Size = new System.Drawing.Size(570, 132);
            this.pnlAns2.TabIndex = 7;
            this.pnlAns2.Click += new System.EventHandler(this.pnlAns2_Click);
            // 
            // lbAns2
            // 
            this.lbAns2.AutoSize = true;
            this.lbAns2.Font = new System.Drawing.Font("Segoe UI Semibold", 32F, System.Drawing.FontStyle.Bold);
            this.lbAns2.Location = new System.Drawing.Point(157, 41);
            this.lbAns2.Name = "lbAns2";
            this.lbAns2.Size = new System.Drawing.Size(206, 59);
            this.lbAns2.TabIndex = 4;
            this.lbAns2.Text = "Answer 2";
            this.lbAns2.Click += new System.EventHandler(this.lbAns2_Click);
            // 
            // pnlAns3
            // 
            this.pnlAns3.Controls.Add(this.lbAns3);
            this.pnlAns3.Controls.Add(this.pbAns3Check);
            this.pnlAns3.Location = new System.Drawing.Point(596, 173);
            this.pnlAns3.Name = "pnlAns3";
            this.pnlAns3.Size = new System.Drawing.Size(589, 132);
            this.pnlAns3.TabIndex = 8;
            this.pnlAns3.Click += new System.EventHandler(this.pnlAns3_Click);
            // 
            // lbAns3
            // 
            this.lbAns3.AutoSize = true;
            this.lbAns3.Font = new System.Drawing.Font("Segoe UI Semibold", 32F, System.Drawing.FontStyle.Bold);
            this.lbAns3.Location = new System.Drawing.Point(134, 43);
            this.lbAns3.Name = "lbAns3";
            this.lbAns3.Size = new System.Drawing.Size(206, 59);
            this.lbAns3.TabIndex = 5;
            this.lbAns3.Text = "Answer 3";
            this.lbAns3.Click += new System.EventHandler(this.lbAns3_Click);
            // 
            // pnlAns4
            // 
            this.pnlAns4.Controls.Add(this.lbAns4);
            this.pnlAns4.Controls.Add(this.pbAns4Check);
            this.pnlAns4.Location = new System.Drawing.Point(596, 354);
            this.pnlAns4.Name = "pnlAns4";
            this.pnlAns4.Size = new System.Drawing.Size(589, 132);
            this.pnlAns4.TabIndex = 9;
            this.pnlAns4.Click += new System.EventHandler(this.pnlAns4_Click);
            // 
            // lbAns4
            // 
            this.lbAns4.AutoSize = true;
            this.lbAns4.Font = new System.Drawing.Font("Segoe UI Semibold", 32F, System.Drawing.FontStyle.Bold);
            this.lbAns4.Location = new System.Drawing.Point(133, 45);
            this.lbAns4.Name = "lbAns4";
            this.lbAns4.Size = new System.Drawing.Size(207, 59);
            this.lbAns4.TabIndex = 6;
            this.lbAns4.Text = "Answer 4";
            this.lbAns4.Click += new System.EventHandler(this.lbAns4_Click);
            // 
            // pbAns4Check
            // 
            this.pbAns4Check.Image = global::RiskGame.Properties.Resources.Tutorial_Checkbox;
            this.pbAns4Check.Location = new System.Drawing.Point(3, 3);
            this.pbAns4Check.Name = "pbAns4Check";
            this.pbAns4Check.Size = new System.Drawing.Size(125, 125);
            this.pbAns4Check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAns4Check.TabIndex = 5;
            this.pbAns4Check.TabStop = false;
            this.pbAns4Check.Click += new System.EventHandler(this.pbAns4Check_Click);
            // 
            // pbAns3Check
            // 
            this.pbAns3Check.Image = global::RiskGame.Properties.Resources.Tutorial_Checkbox;
            this.pbAns3Check.Location = new System.Drawing.Point(3, 4);
            this.pbAns3Check.Name = "pbAns3Check";
            this.pbAns3Check.Size = new System.Drawing.Size(125, 125);
            this.pbAns3Check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAns3Check.TabIndex = 4;
            this.pbAns3Check.TabStop = false;
            this.pbAns3Check.Click += new System.EventHandler(this.pbAns3Check_Click);
            // 
            // pbAns2Check
            // 
            this.pbAns2Check.Image = global::RiskGame.Properties.Resources.Tutorial_Checkbox;
            this.pbAns2Check.Location = new System.Drawing.Point(26, 3);
            this.pbAns2Check.Name = "pbAns2Check";
            this.pbAns2Check.Size = new System.Drawing.Size(125, 125);
            this.pbAns2Check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAns2Check.TabIndex = 3;
            this.pbAns2Check.TabStop = false;
            this.pbAns2Check.Click += new System.EventHandler(this.pbAns2Check_Click);
            // 
            // pbAns1Check
            // 
            this.pbAns1Check.Image = global::RiskGame.Properties.Resources.Tutorial_Checkbox;
            this.pbAns1Check.Location = new System.Drawing.Point(26, 3);
            this.pbAns1Check.Name = "pbAns1Check";
            this.pbAns1Check.Size = new System.Drawing.Size(125, 125);
            this.pbAns1Check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAns1Check.TabIndex = 2;
            this.pbAns1Check.TabStop = false;
            this.pbAns1Check.Click += new System.EventHandler(this.pbAns1Check_Click);
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
            // pbCheckAnswers
            // 
            this.pbCheckAnswers.BackColor = System.Drawing.Color.LightGray;
            this.pbCheckAnswers.Enabled = false;
            this.pbCheckAnswers.Location = new System.Drawing.Point(216, 539);
            this.pbCheckAnswers.Name = "pbCheckAnswers";
            this.pbCheckAnswers.Size = new System.Drawing.Size(750, 80);
            this.pbCheckAnswers.TabIndex = 11;
            this.pbCheckAnswers.TabStop = false;
            // 
            // lbCheck
            // 
            this.lbCheck.AutoSize = true;
            this.lbCheck.Enabled = false;
            this.lbCheck.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lbCheck.ForeColor = System.Drawing.Color.DarkGray;
            this.lbCheck.Location = new System.Drawing.Point(467, 555);
            this.lbCheck.Name = "lbCheck";
            this.lbCheck.Size = new System.Drawing.Size(230, 45);
            this.lbCheck.TabIndex = 12;
            this.lbCheck.Text = "Check Answer";
            // 
            // frmTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 631);
            this.Controls.Add(this.lbCheck);
            this.Controls.Add(this.pbCheckAnswers);
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
            this.pnlAns2.ResumeLayout(false);
            this.pnlAns2.PerformLayout();
            this.pnlAns3.ResumeLayout(false);
            this.pnlAns3.PerformLayout();
            this.pnlAns4.ResumeLayout(false);
            this.pnlAns4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns4Check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns3Check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns2Check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAns1Check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTutorialAnimatedScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckAnswers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTutorialAnimatedScreen;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.PictureBox pbAns1Check;
        private System.Windows.Forms.PictureBox pbAns2Check;
        private System.Windows.Forms.PictureBox pbAns3Check;
        private System.Windows.Forms.PictureBox pbAns4Check;
        private System.Windows.Forms.Panel pnlAns1;
        private System.Windows.Forms.Panel pnlAns2;
        private System.Windows.Forms.Panel pnlAns3;
        private System.Windows.Forms.Panel pnlAns4;
        private System.Windows.Forms.Label lbAns1;
        private System.Windows.Forms.Label lbAns2;
        private System.Windows.Forms.Label lbAns3;
        private System.Windows.Forms.Label lbAns4;
        private System.Windows.Forms.PictureBox pbCheckAnswers;
        private System.Windows.Forms.Label lbCheck;
    }
}