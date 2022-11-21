
namespace RiskGame
{
    partial class frmSetupGame
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
            this.lbPlayerColour = new System.Windows.Forms.Label();
            this.lbAI1Colour = new System.Windows.Forms.Label();
            this.lbAI2Colour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trbrAISelector = new System.Windows.Forms.TrackBar();
            this.lbSelect0 = new System.Windows.Forms.Label();
            this.lbSelect1 = new System.Windows.Forms.Label();
            this.lbSelect2 = new System.Windows.Forms.Label();
            this.pnlAI1Settings = new System.Windows.Forms.Panel();
            this.pnlAI2Settings = new System.Windows.Forms.Panel();
            this.btnAI1Colour = new System.Windows.Forms.Button();
            this.btnAI2Colour = new System.Windows.Forms.Button();
            this.btnPlayerColour = new System.Windows.Forms.Button();
            this.pbStartMultiplayer = new System.Windows.Forms.PictureBox();
            this.pbStartSingleplayer = new System.Windows.Forms.PictureBox();
            this.pbDice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trbrAISelector)).BeginInit();
            this.pnlAI1Settings.SuspendLayout();
            this.pnlAI2Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartMultiplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartSingleplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPlayerColour
            // 
            this.lbPlayerColour.AutoSize = true;
            this.lbPlayerColour.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbPlayerColour.Location = new System.Drawing.Point(12, 120);
            this.lbPlayerColour.Name = "lbPlayerColour";
            this.lbPlayerColour.Size = new System.Drawing.Size(170, 37);
            this.lbPlayerColour.TabIndex = 0;
            this.lbPlayerColour.Text = "Your Colour:";
            // 
            // lbAI1Colour
            // 
            this.lbAI1Colour.AutoSize = true;
            this.lbAI1Colour.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbAI1Colour.Location = new System.Drawing.Point(182, 9);
            this.lbAI1Colour.Name = "lbAI1Colour";
            this.lbAI1Colour.Size = new System.Drawing.Size(169, 37);
            this.lbAI1Colour.TabIndex = 1;
            this.lbAI1Colour.Text = "AI1\'s Colour:";
            // 
            // lbAI2Colour
            // 
            this.lbAI2Colour.AutoSize = true;
            this.lbAI2Colour.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbAI2Colour.Location = new System.Drawing.Point(182, 10);
            this.lbAI2Colour.Name = "lbAI2Colour";
            this.lbAI2Colour.Size = new System.Drawing.Size(173, 37);
            this.lbAI2Colour.TabIndex = 2;
            this.lbAI2Colour.Text = "AI2\'s Colour:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Risk Game Setup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "How many AIs would you like to play with?";
            // 
            // trbrAISelector
            // 
            this.trbrAISelector.Location = new System.Drawing.Point(447, 60);
            this.trbrAISelector.Maximum = 2;
            this.trbrAISelector.Name = "trbrAISelector";
            this.trbrAISelector.Size = new System.Drawing.Size(328, 45);
            this.trbrAISelector.TabIndex = 5;
            this.trbrAISelector.Value = 1;
            this.trbrAISelector.Scroll += new System.EventHandler(this.trbrAISelector_Scroll);
            // 
            // lbSelect0
            // 
            this.lbSelect0.AutoSize = true;
            this.lbSelect0.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelect0.Location = new System.Drawing.Point(450, 84);
            this.lbSelect0.Name = "lbSelect0";
            this.lbSelect0.Size = new System.Drawing.Size(24, 30);
            this.lbSelect0.TabIndex = 6;
            this.lbSelect0.Text = "0";
            // 
            // lbSelect1
            // 
            this.lbSelect1.AutoSize = true;
            this.lbSelect1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelect1.Location = new System.Drawing.Point(601, 84);
            this.lbSelect1.Name = "lbSelect1";
            this.lbSelect1.Size = new System.Drawing.Size(24, 30);
            this.lbSelect1.TabIndex = 7;
            this.lbSelect1.Text = "1";
            // 
            // lbSelect2
            // 
            this.lbSelect2.AutoSize = true;
            this.lbSelect2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelect2.Location = new System.Drawing.Point(751, 84);
            this.lbSelect2.Name = "lbSelect2";
            this.lbSelect2.Size = new System.Drawing.Size(24, 30);
            this.lbSelect2.TabIndex = 8;
            this.lbSelect2.Text = "2";
            // 
            // pnlAI1Settings
            // 
            this.pnlAI1Settings.Controls.Add(this.lbAI1Colour);
            this.pnlAI1Settings.Controls.Add(this.btnAI1Colour);
            this.pnlAI1Settings.Location = new System.Drawing.Point(19, 172);
            this.pnlAI1Settings.Name = "pnlAI1Settings";
            this.pnlAI1Settings.Size = new System.Drawing.Size(695, 56);
            this.pnlAI1Settings.TabIndex = 9;
            // 
            // pnlAI2Settings
            // 
            this.pnlAI2Settings.Controls.Add(this.lbAI2Colour);
            this.pnlAI2Settings.Controls.Add(this.btnAI2Colour);
            this.pnlAI2Settings.Location = new System.Drawing.Point(19, 221);
            this.pnlAI2Settings.Name = "pnlAI2Settings";
            this.pnlAI2Settings.Size = new System.Drawing.Size(695, 56);
            this.pnlAI2Settings.TabIndex = 10;
            // 
            // btnAI1Colour
            // 
            this.btnAI1Colour.Location = new System.Drawing.Point(3, 3);
            this.btnAI1Colour.Name = "btnAI1Colour";
            this.btnAI1Colour.Size = new System.Drawing.Size(179, 46);
            this.btnAI1Colour.TabIndex = 11;
            this.btnAI1Colour.UseVisualStyleBackColor = true;
            // 
            // btnAI2Colour
            // 
            this.btnAI2Colour.Location = new System.Drawing.Point(3, 7);
            this.btnAI2Colour.Name = "btnAI2Colour";
            this.btnAI2Colour.Size = new System.Drawing.Size(179, 46);
            this.btnAI2Colour.TabIndex = 12;
            this.btnAI2Colour.UseVisualStyleBackColor = true;
            // 
            // btnPlayerColour
            // 
            this.btnPlayerColour.Location = new System.Drawing.Point(208, 120);
            this.btnPlayerColour.Name = "btnPlayerColour";
            this.btnPlayerColour.Size = new System.Drawing.Size(179, 46);
            this.btnPlayerColour.TabIndex = 13;
            this.btnPlayerColour.UseVisualStyleBackColor = true;
            this.btnPlayerColour.Click += new System.EventHandler(this.btnPlayerColour_Click);
            // 
            // pbStartMultiplayer
            // 
            this.pbStartMultiplayer.Image = global::RiskGame.Properties.Resources.StartMultiPlayer;
            this.pbStartMultiplayer.Location = new System.Drawing.Point(514, 338);
            this.pbStartMultiplayer.Name = "pbStartMultiplayer";
            this.pbStartMultiplayer.Size = new System.Drawing.Size(261, 100);
            this.pbStartMultiplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStartMultiplayer.TabIndex = 16;
            this.pbStartMultiplayer.TabStop = false;
            this.pbStartMultiplayer.Click += new System.EventHandler(this.pbStartMultiplayer_Click);
            // 
            // pbStartSingleplayer
            // 
            this.pbStartSingleplayer.Image = global::RiskGame.Properties.Resources.StartSinglePlayer;
            this.pbStartSingleplayer.Location = new System.Drawing.Point(22, 338);
            this.pbStartSingleplayer.Name = "pbStartSingleplayer";
            this.pbStartSingleplayer.Size = new System.Drawing.Size(261, 100);
            this.pbStartSingleplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStartSingleplayer.TabIndex = 15;
            this.pbStartSingleplayer.TabStop = false;
            this.pbStartSingleplayer.Click += new System.EventHandler(this.pbStartSingleplayer_Click);
            // 
            // pbDice
            // 
            this.pbDice.Image = global::RiskGame.Properties.Resources.dice;
            this.pbDice.Location = new System.Drawing.Point(714, 120);
            this.pbDice.Name = "pbDice";
            this.pbDice.Size = new System.Drawing.Size(61, 46);
            this.pbDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDice.TabIndex = 14;
            this.pbDice.TabStop = false;
            this.pbDice.Click += new System.EventHandler(this.pbDice_Click);
            // 
            // frmSetupGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbStartMultiplayer);
            this.Controls.Add(this.pbStartSingleplayer);
            this.Controls.Add(this.pbDice);
            this.Controls.Add(this.btnPlayerColour);
            this.Controls.Add(this.pnlAI2Settings);
            this.Controls.Add(this.pnlAI1Settings);
            this.Controls.Add(this.lbSelect2);
            this.Controls.Add(this.lbSelect1);
            this.Controls.Add(this.lbSelect0);
            this.Controls.Add(this.trbrAISelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPlayerColour);
            this.Name = "frmSetupGame";
            this.Text = "Risk: Setup Game";
            this.Load += new System.EventHandler(this.frmSetupGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbrAISelector)).EndInit();
            this.pnlAI1Settings.ResumeLayout(false);
            this.pnlAI1Settings.PerformLayout();
            this.pnlAI2Settings.ResumeLayout(false);
            this.pnlAI2Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartMultiplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartSingleplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPlayerColour;
        private System.Windows.Forms.Label lbAI1Colour;
        private System.Windows.Forms.Label lbAI2Colour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trbrAISelector;
        private System.Windows.Forms.Label lbSelect0;
        private System.Windows.Forms.Label lbSelect1;
        private System.Windows.Forms.Label lbSelect2;
        private System.Windows.Forms.Panel pnlAI1Settings;
        private System.Windows.Forms.Panel pnlAI2Settings;
        private System.Windows.Forms.Button btnAI1Colour;
        private System.Windows.Forms.Button btnAI2Colour;
        private System.Windows.Forms.Button btnPlayerColour;
        private System.Windows.Forms.PictureBox pbDice;
        private System.Windows.Forms.PictureBox pbStartSingleplayer;
        private System.Windows.Forms.PictureBox pbStartMultiplayer;
    }
}