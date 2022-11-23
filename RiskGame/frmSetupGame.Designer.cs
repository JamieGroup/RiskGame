
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
            this.lbPlayerSelectorDescription = new System.Windows.Forms.Label();
            this.trbrAISelector = new System.Windows.Forms.TrackBar();
            this.lbSelect0 = new System.Windows.Forms.Label();
            this.lbSelect1 = new System.Windows.Forms.Label();
            this.lbSelect2 = new System.Windows.Forms.Label();
            this.pnlAI1Settings = new System.Windows.Forms.Panel();
            this.btnAI1Colour = new System.Windows.Forms.Button();
            this.pnlAI2Settings = new System.Windows.Forms.Panel();
            this.btnAI2Colour = new System.Windows.Forms.Button();
            this.btnPlayerColour = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDice = new System.Windows.Forms.Panel();
            this.pnlSecretMode = new System.Windows.Forms.Panel();
            this.lbSecretModeDescription = new System.Windows.Forms.Label();
            this.lbSecretMode = new System.Windows.Forms.Label();
            this.pbSecretMode = new System.Windows.Forms.PictureBox();
            this.pnlHuman2Controls = new System.Windows.Forms.Panel();
            this.btnH2Colour = new System.Windows.Forms.Button();
            this.lbH2Colour = new System.Windows.Forms.Label();
            this.txtH2 = new System.Windows.Forms.TextBox();
            this.lbH2Name = new System.Windows.Forms.Label();
            this.lbH2Title = new System.Windows.Forms.Label();
            this.pbStartMultiplayer = new System.Windows.Forms.PictureBox();
            this.pbStartSingleplayer = new System.Windows.Forms.PictureBox();
            this.pnlHuman3Controls = new System.Windows.Forms.Panel();
            this.btnH3Colour = new System.Windows.Forms.Button();
            this.lbH3Colour = new System.Windows.Forms.Label();
            this.txtH3 = new System.Windows.Forms.TextBox();
            this.lbH3Name = new System.Windows.Forms.Label();
            this.lbH3Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbrAISelector)).BeginInit();
            this.pnlAI1Settings.SuspendLayout();
            this.pnlAI2Settings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSecretMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecretMode)).BeginInit();
            this.pnlHuman2Controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartMultiplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartSingleplayer)).BeginInit();
            this.pnlHuman3Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPlayerColour
            // 
            this.lbPlayerColour.AutoSize = true;
            this.lbPlayerColour.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbPlayerColour.Location = new System.Drawing.Point(12, 58);
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
            // lbPlayerSelectorDescription
            // 
            this.lbPlayerSelectorDescription.AutoSize = true;
            this.lbPlayerSelectorDescription.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerSelectorDescription.Location = new System.Drawing.Point(8, 16);
            this.lbPlayerSelectorDescription.Name = "lbPlayerSelectorDescription";
            this.lbPlayerSelectorDescription.Size = new System.Drawing.Size(409, 30);
            this.lbPlayerSelectorDescription.TabIndex = 4;
            this.lbPlayerSelectorDescription.Text = "How many AIs would you like to play with?";
            // 
            // trbrAISelector
            // 
            this.trbrAISelector.Location = new System.Drawing.Point(8, 52);
            this.trbrAISelector.Maximum = 2;
            this.trbrAISelector.Name = "trbrAISelector";
            this.trbrAISelector.Size = new System.Drawing.Size(496, 45);
            this.trbrAISelector.TabIndex = 5;
            this.trbrAISelector.Value = 1;
            this.trbrAISelector.Scroll += new System.EventHandler(this.trbrAISelector_Scroll);
            // 
            // lbSelect0
            // 
            this.lbSelect0.AutoSize = true;
            this.lbSelect0.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelect0.Location = new System.Drawing.Point(11, 80);
            this.lbSelect0.Name = "lbSelect0";
            this.lbSelect0.Size = new System.Drawing.Size(24, 30);
            this.lbSelect0.TabIndex = 6;
            this.lbSelect0.Text = "0";
            // 
            // lbSelect1
            // 
            this.lbSelect1.AutoSize = true;
            this.lbSelect1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelect1.Location = new System.Drawing.Point(245, 80);
            this.lbSelect1.Name = "lbSelect1";
            this.lbSelect1.Size = new System.Drawing.Size(24, 30);
            this.lbSelect1.TabIndex = 7;
            this.lbSelect1.Text = "1";
            // 
            // lbSelect2
            // 
            this.lbSelect2.AutoSize = true;
            this.lbSelect2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelect2.Location = new System.Drawing.Point(480, 80);
            this.lbSelect2.Name = "lbSelect2";
            this.lbSelect2.Size = new System.Drawing.Size(24, 30);
            this.lbSelect2.TabIndex = 8;
            this.lbSelect2.Text = "2";
            // 
            // pnlAI1Settings
            // 
            this.pnlAI1Settings.Controls.Add(this.lbAI1Colour);
            this.pnlAI1Settings.Controls.Add(this.btnAI1Colour);
            this.pnlAI1Settings.Location = new System.Drawing.Point(22, 266);
            this.pnlAI1Settings.Name = "pnlAI1Settings";
            this.pnlAI1Settings.Size = new System.Drawing.Size(695, 56);
            this.pnlAI1Settings.TabIndex = 9;
            // 
            // btnAI1Colour
            // 
            this.btnAI1Colour.Location = new System.Drawing.Point(3, 3);
            this.btnAI1Colour.Name = "btnAI1Colour";
            this.btnAI1Colour.Size = new System.Drawing.Size(179, 46);
            this.btnAI1Colour.TabIndex = 11;
            this.btnAI1Colour.UseVisualStyleBackColor = true;
            // 
            // pnlAI2Settings
            // 
            this.pnlAI2Settings.Controls.Add(this.lbAI2Colour);
            this.pnlAI2Settings.Controls.Add(this.btnAI2Colour);
            this.pnlAI2Settings.Location = new System.Drawing.Point(22, 315);
            this.pnlAI2Settings.Name = "pnlAI2Settings";
            this.pnlAI2Settings.Size = new System.Drawing.Size(695, 56);
            this.pnlAI2Settings.TabIndex = 10;
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
            this.btnPlayerColour.Location = new System.Drawing.Point(208, 58);
            this.btnPlayerColour.Name = "btnPlayerColour";
            this.btnPlayerColour.Size = new System.Drawing.Size(179, 46);
            this.btnPlayerColour.TabIndex = 13;
            this.btnPlayerColour.UseVisualStyleBackColor = true;
            this.btnPlayerColour.Click += new System.EventHandler(this.btnPlayerColour_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlDice);
            this.panel1.Controls.Add(this.lbPlayerSelectorDescription);
            this.panel1.Controls.Add(this.lbSelect0);
            this.panel1.Controls.Add(this.lbSelect1);
            this.panel1.Controls.Add(this.lbSelect2);
            this.panel1.Controls.Add(this.trbrAISelector);
            this.panel1.Location = new System.Drawing.Point(22, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 114);
            this.panel1.TabIndex = 17;
            // 
            // pnlDice
            // 
            this.pnlDice.BackgroundImage = global::RiskGame.Properties.Resources.dice;
            this.pnlDice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlDice.Location = new System.Drawing.Point(418, 3);
            this.pnlDice.Name = "pnlDice";
            this.pnlDice.Size = new System.Drawing.Size(86, 52);
            this.pnlDice.TabIndex = 18;
            this.pnlDice.Click += new System.EventHandler(this.pbDice_Click);
            // 
            // pnlSecretMode
            // 
            this.pnlSecretMode.Controls.Add(this.lbSecretModeDescription);
            this.pnlSecretMode.Controls.Add(this.lbSecretMode);
            this.pnlSecretMode.Controls.Add(this.pbSecretMode);
            this.pnlSecretMode.Location = new System.Drawing.Point(514, 12);
            this.pnlSecretMode.Name = "pnlSecretMode";
            this.pnlSecretMode.Size = new System.Drawing.Size(272, 92);
            this.pnlSecretMode.TabIndex = 18;
            // 
            // lbSecretModeDescription
            // 
            this.lbSecretModeDescription.AutoSize = true;
            this.lbSecretModeDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbSecretModeDescription.Location = new System.Drawing.Point(99, 41);
            this.lbSecretModeDescription.Name = "lbSecretModeDescription";
            this.lbSecretModeDescription.Size = new System.Drawing.Size(163, 42);
            this.lbSecretModeDescription.TabIndex = 19;
            this.lbSecretModeDescription.Text = "Shows you as offline \r\nto other Risk players.";
            // 
            // lbSecretMode
            // 
            this.lbSecretMode.AutoSize = true;
            this.lbSecretMode.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecretMode.Location = new System.Drawing.Point(96, 4);
            this.lbSecretMode.Name = "lbSecretMode";
            this.lbSecretMode.Size = new System.Drawing.Size(166, 37);
            this.lbSecretMode.TabIndex = 4;
            this.lbSecretMode.Text = "Secret Mode";
            // 
            // pbSecretMode
            // 
            this.pbSecretMode.Image = global::RiskGame.Properties.Resources.Tutorial_Checkbox;
            this.pbSecretMode.Location = new System.Drawing.Point(0, 0);
            this.pbSecretMode.Name = "pbSecretMode";
            this.pbSecretMode.Size = new System.Drawing.Size(93, 92);
            this.pbSecretMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSecretMode.TabIndex = 3;
            this.pbSecretMode.TabStop = false;
            this.pbSecretMode.Click += new System.EventHandler(this.pbSecretMode_Click);
            // 
            // pnlHuman2Controls
            // 
            this.pnlHuman2Controls.Controls.Add(this.btnH2Colour);
            this.pnlHuman2Controls.Controls.Add(this.lbH2Colour);
            this.pnlHuman2Controls.Controls.Add(this.txtH2);
            this.pnlHuman2Controls.Controls.Add(this.lbH2Name);
            this.pnlHuman2Controls.Controls.Add(this.lbH2Title);
            this.pnlHuman2Controls.Location = new System.Drawing.Point(19, 211);
            this.pnlHuman2Controls.Name = "pnlHuman2Controls";
            this.pnlHuman2Controls.Size = new System.Drawing.Size(290, 134);
            this.pnlHuman2Controls.TabIndex = 19;
            // 
            // btnH2Colour
            // 
            this.btnH2Colour.Location = new System.Drawing.Point(85, 83);
            this.btnH2Colour.Name = "btnH2Colour";
            this.btnH2Colour.Size = new System.Drawing.Size(202, 34);
            this.btnH2Colour.TabIndex = 4;
            this.btnH2Colour.UseVisualStyleBackColor = true;
            // 
            // lbH2Colour
            // 
            this.lbH2Colour.AutoSize = true;
            this.lbH2Colour.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbH2Colour.Location = new System.Drawing.Point(6, 84);
            this.lbH2Colour.Name = "lbH2Colour";
            this.lbH2Colour.Size = new System.Drawing.Size(75, 25);
            this.lbH2Colour.TabIndex = 3;
            this.lbH2Colour.Text = "Colour:";
            // 
            // txtH2
            // 
            this.txtH2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtH2.Location = new System.Drawing.Point(85, 43);
            this.txtH2.Name = "txtH2";
            this.txtH2.Size = new System.Drawing.Size(202, 33);
            this.txtH2.TabIndex = 2;
            // 
            // lbH2Name
            // 
            this.lbH2Name.AutoSize = true;
            this.lbH2Name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbH2Name.Location = new System.Drawing.Point(6, 46);
            this.lbH2Name.Name = "lbH2Name";
            this.lbH2Name.Size = new System.Drawing.Size(69, 25);
            this.lbH2Name.TabIndex = 1;
            this.lbH2Name.Text = "Name:";
            // 
            // lbH2Title
            // 
            this.lbH2Title.AutoSize = true;
            this.lbH2Title.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lbH2Title.Location = new System.Drawing.Point(5, 10);
            this.lbH2Title.Name = "lbH2Title";
            this.lbH2Title.Size = new System.Drawing.Size(88, 25);
            this.lbH2Title.TabIndex = 0;
            this.lbH2Title.Text = "Human 2";
            this.lbH2Title.Click += new System.EventHandler(this.lbH2Title_Click);
            // 
            // pbStartMultiplayer
            // 
            this.pbStartMultiplayer.Image = global::RiskGame.Properties.Resources.StartMultiPlayer;
            this.pbStartMultiplayer.Location = new System.Drawing.Point(514, 391);
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
            this.pbStartSingleplayer.Location = new System.Drawing.Point(22, 391);
            this.pbStartSingleplayer.Name = "pbStartSingleplayer";
            this.pbStartSingleplayer.Size = new System.Drawing.Size(261, 100);
            this.pbStartSingleplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStartSingleplayer.TabIndex = 15;
            this.pbStartSingleplayer.TabStop = false;
            this.pbStartSingleplayer.Click += new System.EventHandler(this.pbStartSingleplayer_Click);
            // 
            // pnlHuman3Controls
            // 
            this.pnlHuman3Controls.Controls.Add(this.btnH3Colour);
            this.pnlHuman3Controls.Controls.Add(this.lbH3Colour);
            this.pnlHuman3Controls.Controls.Add(this.txtH3);
            this.pnlHuman3Controls.Controls.Add(this.lbH3Name);
            this.pnlHuman3Controls.Controls.Add(this.lbH3Title);
            this.pnlHuman3Controls.Location = new System.Drawing.Point(483, 211);
            this.pnlHuman3Controls.Name = "pnlHuman3Controls";
            this.pnlHuman3Controls.Size = new System.Drawing.Size(290, 134);
            this.pnlHuman3Controls.TabIndex = 20;
            // 
            // btnH3Colour
            // 
            this.btnH3Colour.Location = new System.Drawing.Point(81, 82);
            this.btnH3Colour.Name = "btnH3Colour";
            this.btnH3Colour.Size = new System.Drawing.Size(202, 34);
            this.btnH3Colour.TabIndex = 5;
            this.btnH3Colour.UseVisualStyleBackColor = true;
            // 
            // lbH3Colour
            // 
            this.lbH3Colour.AutoSize = true;
            this.lbH3Colour.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbH3Colour.Location = new System.Drawing.Point(6, 84);
            this.lbH3Colour.Name = "lbH3Colour";
            this.lbH3Colour.Size = new System.Drawing.Size(75, 25);
            this.lbH3Colour.TabIndex = 4;
            this.lbH3Colour.Text = "Colour:";
            // 
            // txtH3
            // 
            this.txtH3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtH3.Location = new System.Drawing.Point(81, 38);
            this.txtH3.Name = "txtH3";
            this.txtH3.Size = new System.Drawing.Size(202, 33);
            this.txtH3.TabIndex = 3;
            // 
            // lbH3Name
            // 
            this.lbH3Name.AutoSize = true;
            this.lbH3Name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbH3Name.Location = new System.Drawing.Point(6, 46);
            this.lbH3Name.Name = "lbH3Name";
            this.lbH3Name.Size = new System.Drawing.Size(69, 25);
            this.lbH3Name.TabIndex = 2;
            this.lbH3Name.Text = "Name:";
            // 
            // lbH3Title
            // 
            this.lbH3Title.AutoSize = true;
            this.lbH3Title.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lbH3Title.Location = new System.Drawing.Point(5, 10);
            this.lbH3Title.Name = "lbH3Title";
            this.lbH3Title.Size = new System.Drawing.Size(88, 25);
            this.lbH3Title.TabIndex = 1;
            this.lbH3Title.Text = "Human 3";
            this.lbH3Title.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmSetupGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.pnlHuman3Controls);
            this.Controls.Add(this.pnlHuman2Controls);
            this.Controls.Add(this.pnlSecretMode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbStartMultiplayer);
            this.Controls.Add(this.pbStartSingleplayer);
            this.Controls.Add(this.btnPlayerColour);
            this.Controls.Add(this.pnlAI2Settings);
            this.Controls.Add(this.pnlAI1Settings);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSecretMode.ResumeLayout(false);
            this.pnlSecretMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecretMode)).EndInit();
            this.pnlHuman2Controls.ResumeLayout(false);
            this.pnlHuman2Controls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartMultiplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStartSingleplayer)).EndInit();
            this.pnlHuman3Controls.ResumeLayout(false);
            this.pnlHuman3Controls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPlayerColour;
        private System.Windows.Forms.Label lbAI1Colour;
        private System.Windows.Forms.Label lbAI2Colour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPlayerSelectorDescription;
        private System.Windows.Forms.TrackBar trbrAISelector;
        private System.Windows.Forms.Label lbSelect0;
        private System.Windows.Forms.Label lbSelect1;
        private System.Windows.Forms.Label lbSelect2;
        private System.Windows.Forms.Panel pnlAI1Settings;
        private System.Windows.Forms.Panel pnlAI2Settings;
        private System.Windows.Forms.Button btnAI1Colour;
        private System.Windows.Forms.Button btnAI2Colour;
        private System.Windows.Forms.Button btnPlayerColour;
        private System.Windows.Forms.PictureBox pbStartSingleplayer;
        private System.Windows.Forms.PictureBox pbStartMultiplayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDice;
        private System.Windows.Forms.Panel pnlSecretMode;
        private System.Windows.Forms.PictureBox pbSecretMode;
        private System.Windows.Forms.Label lbSecretModeDescription;
        private System.Windows.Forms.Label lbSecretMode;
        private System.Windows.Forms.Panel pnlHuman2Controls;
        private System.Windows.Forms.Panel pnlHuman3Controls;
        private System.Windows.Forms.Label lbH2Title;
        private System.Windows.Forms.Label lbH3Title;
        private System.Windows.Forms.TextBox txtH2;
        private System.Windows.Forms.Label lbH2Name;
        private System.Windows.Forms.TextBox txtH3;
        private System.Windows.Forms.Label lbH3Name;
        private System.Windows.Forms.Button btnH2Colour;
        private System.Windows.Forms.Label lbH2Colour;
        private System.Windows.Forms.Button btnH3Colour;
        private System.Windows.Forms.Label lbH3Colour;
    }
}