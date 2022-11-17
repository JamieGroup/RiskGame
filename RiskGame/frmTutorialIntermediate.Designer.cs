
namespace RiskGame
{
    partial class frmTutorialIntermediate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutorialIntermediate));
            this.pnlNumberSelection = new System.Windows.Forms.Panel();
            this.lbNumberSelectEnter = new System.Windows.Forms.Label();
            this.lbNumberSelectDisplay = new System.Windows.Forms.Label();
            this.pbNumberSelection = new System.Windows.Forms.PictureBox();
            this.lbNumberSelectionHelp = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.prbTime = new System.Windows.Forms.ProgressBar();
            this.lbQNum = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.pbTutorialAnimatedScreen = new System.Windows.Forms.PictureBox();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlNumberSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumberSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTutorialAnimatedScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNumberSelection
            // 
            this.pnlNumberSelection.Controls.Add(this.lbNumberSelectEnter);
            this.pnlNumberSelection.Controls.Add(this.lbNumberSelectDisplay);
            this.pnlNumberSelection.Controls.Add(this.pbNumberSelection);
            this.pnlNumberSelection.Controls.Add(this.lbNumberSelectionHelp);
            this.pnlNumberSelection.Location = new System.Drawing.Point(31, 180);
            this.pnlNumberSelection.Name = "pnlNumberSelection";
            this.pnlNumberSelection.Size = new System.Drawing.Size(1182, 319);
            this.pnlNumberSelection.TabIndex = 15;
            this.pnlNumberSelection.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnlNumberSelection_Scroll);
            this.pnlNumberSelection.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlNumberSelection_MouseDown);
            // 
            // lbNumberSelectEnter
            // 
            this.lbNumberSelectEnter.AutoSize = true;
            this.lbNumberSelectEnter.Font = new System.Drawing.Font("Segoe UI Semibold", 40F, System.Drawing.FontStyle.Bold);
            this.lbNumberSelectEnter.Location = new System.Drawing.Point(800, 223);
            this.lbNumberSelectEnter.Name = "lbNumberSelectEnter";
            this.lbNumberSelectEnter.Size = new System.Drawing.Size(175, 72);
            this.lbNumberSelectEnter.TabIndex = 3;
            this.lbNumberSelectEnter.Text = "Enter!";
            // 
            // lbNumberSelectDisplay
            // 
            this.lbNumberSelectDisplay.AutoSize = true;
            this.lbNumberSelectDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 40F, System.Drawing.FontStyle.Bold);
            this.lbNumberSelectDisplay.Location = new System.Drawing.Point(850, 129);
            this.lbNumberSelectDisplay.Name = "lbNumberSelectDisplay";
            this.lbNumberSelectDisplay.Size = new System.Drawing.Size(82, 72);
            this.lbNumberSelectDisplay.TabIndex = 2;
            this.lbNumberSelectDisplay.Text = "10";
            // 
            // pbNumberSelection
            // 
            this.pbNumberSelection.Image = global::RiskGame.Properties.Resources.numberSelection;
            this.pbNumberSelection.Location = new System.Drawing.Point(683, 9);
            this.pbNumberSelection.Name = "pbNumberSelection";
            this.pbNumberSelection.Size = new System.Drawing.Size(412, 307);
            this.pbNumberSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNumberSelection.TabIndex = 0;
            this.pbNumberSelection.TabStop = false;
            // 
            // lbNumberSelectionHelp
            // 
            this.lbNumberSelectionHelp.AutoSize = true;
            this.lbNumberSelectionHelp.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberSelectionHelp.Location = new System.Drawing.Point(58, 10);
            this.lbNumberSelectionHelp.Name = "lbNumberSelectionHelp";
            this.lbNumberSelectionHelp.Size = new System.Drawing.Size(564, 296);
            this.lbNumberSelectionHelp.TabIndex = 1;
            this.lbNumberSelectionHelp.Text = resources.GetString("lbNumberSelectionHelp.Text");
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::RiskGame.Properties.Resources.riskLogo;
            this.pbLogo.Location = new System.Drawing.Point(985, -1);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(204, 120);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 21;
            this.pbLogo.TabStop = false;
            // 
            // prbTime
            // 
            this.prbTime.Location = new System.Drawing.Point(451, 122);
            this.prbTime.Name = "prbTime";
            this.prbTime.Size = new System.Drawing.Size(313, 40);
            this.prbTime.TabIndex = 20;
            this.prbTime.Visible = false;
            // 
            // lbQNum
            // 
            this.lbQNum.AutoSize = true;
            this.lbQNum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbQNum.Location = new System.Drawing.Point(12, 122);
            this.lbQNum.Name = "lbQNum";
            this.lbQNum.Size = new System.Drawing.Size(145, 32);
            this.lbQNum.TabIndex = 19;
            this.lbQNum.Text = "Question: 1";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbScore.Location = new System.Drawing.Point(1083, 122);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(105, 32);
            this.lbScore.TabIndex = 18;
            this.lbScore.Text = "Score: 0";
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lbQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lbQuestion.Location = new System.Drawing.Point(22, 34);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(378, 51);
            this.lbQuestion.TabIndex = 17;
            this.lbQuestion.Text = "Question Goes Here!";
            // 
            // pbTutorialAnimatedScreen
            // 
            this.pbTutorialAnimatedScreen.Image = global::RiskGame.Properties.Resources.Tutorial_Animated_Screen_long;
            this.pbTutorialAnimatedScreen.Location = new System.Drawing.Point(4, -1);
            this.pbTutorialAnimatedScreen.Name = "pbTutorialAnimatedScreen";
            this.pbTutorialAnimatedScreen.Size = new System.Drawing.Size(1185, 120);
            this.pbTutorialAnimatedScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTutorialAnimatedScreen.TabIndex = 16;
            this.pbTutorialAnimatedScreen.TabStop = false;
            // 
            // frmTutorialIntermediate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 513);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.prbTime);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.lbQNum);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pnlNumberSelection);
            this.Controls.Add(this.pbTutorialAnimatedScreen);
            this.Name = "frmTutorialIntermediate";
            this.Text = "Risk: Intermediate Tutorial";
            this.Load += new System.EventHandler(this.frmTutorialIntermediate_Load);
            this.pnlNumberSelection.ResumeLayout(false);
            this.pnlNumberSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNumberSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTutorialAnimatedScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNumberSelection;
        private System.Windows.Forms.PictureBox pbNumberSelection;
        private System.Windows.Forms.Label lbNumberSelectionHelp;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ProgressBar prbTime;
        private System.Windows.Forms.Label lbQNum;
        private System.Windows.Forms.PictureBox pbTutorialAnimatedScreen;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Label lbNumberSelectEnter;
        private System.Windows.Forms.Label lbNumberSelectDisplay;
    }
}