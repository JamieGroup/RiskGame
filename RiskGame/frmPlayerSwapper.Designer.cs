namespace RiskGame
{
    partial class frmPlayerSwapper
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbPl1Username = new System.Windows.Forms.Label();
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.pbPl1Avatar = new System.Windows.Forms.PictureBox();
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.pbPl2Avatar = new System.Windows.Forms.PictureBox();
            this.lbPl2Username = new System.Windows.Forms.Label();
            this.pnlPlayer3 = new System.Windows.Forms.Panel();
            this.lbPl3Username = new System.Windows.Forms.Label();
            this.pbPl3Avatar = new System.Windows.Forms.PictureBox();
            this.pnlStripe = new System.Windows.Forms.Panel();
            this.pbTradeCards = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPl1Avatar)).BeginInit();
            this.pnlPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPl2Avatar)).BeginInit();
            this.pnlPlayer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPl3Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTradeCards)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Risk: Player Swapper";
            // 
            // lbPl1Username
            // 
            this.lbPl1Username.AutoSize = true;
            this.lbPl1Username.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPl1Username.Location = new System.Drawing.Point(143, 13);
            this.lbPl1Username.Name = "lbPl1Username";
            this.lbPl1Username.Size = new System.Drawing.Size(223, 37);
            this.lbPl1Username.TabIndex = 4;
            this.lbPl1Username.Text = "Player1Username";
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.Controls.Add(this.pbPl1Avatar);
            this.pnlPlayer1.Controls.Add(this.lbPl1Username);
            this.pnlPlayer1.Location = new System.Drawing.Point(90, 107);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(631, 107);
            this.pnlPlayer1.TabIndex = 5;
            // 
            // pbPl1Avatar
            // 
            this.pbPl1Avatar.Image = global::RiskGame.Properties.Resources.dice;
            this.pbPl1Avatar.Location = new System.Drawing.Point(3, 3);
            this.pbPl1Avatar.Name = "pbPl1Avatar";
            this.pbPl1Avatar.Size = new System.Drawing.Size(115, 101);
            this.pbPl1Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPl1Avatar.TabIndex = 0;
            this.pbPl1Avatar.TabStop = false;
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.Controls.Add(this.pbPl2Avatar);
            this.pnlPlayer2.Controls.Add(this.lbPl2Username);
            this.pnlPlayer2.Location = new System.Drawing.Point(90, 253);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(631, 107);
            this.pnlPlayer2.TabIndex = 6;
            // 
            // pbPl2Avatar
            // 
            this.pbPl2Avatar.Image = global::RiskGame.Properties.Resources.dice;
            this.pbPl2Avatar.Location = new System.Drawing.Point(3, 3);
            this.pbPl2Avatar.Name = "pbPl2Avatar";
            this.pbPl2Avatar.Size = new System.Drawing.Size(115, 101);
            this.pbPl2Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPl2Avatar.TabIndex = 0;
            this.pbPl2Avatar.TabStop = false;
            // 
            // lbPl2Username
            // 
            this.lbPl2Username.AutoSize = true;
            this.lbPl2Username.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPl2Username.Location = new System.Drawing.Point(143, 13);
            this.lbPl2Username.Name = "lbPl2Username";
            this.lbPl2Username.Size = new System.Drawing.Size(223, 37);
            this.lbPl2Username.TabIndex = 4;
            this.lbPl2Username.Text = "Player2Username";
            // 
            // pnlPlayer3
            // 
            this.pnlPlayer3.Controls.Add(this.lbPl3Username);
            this.pnlPlayer3.Controls.Add(this.pbPl3Avatar);
            this.pnlPlayer3.Location = new System.Drawing.Point(90, 399);
            this.pnlPlayer3.Name = "pnlPlayer3";
            this.pnlPlayer3.Size = new System.Drawing.Size(631, 107);
            this.pnlPlayer3.TabIndex = 7;
            // 
            // lbPl3Username
            // 
            this.lbPl3Username.AutoSize = true;
            this.lbPl3Username.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPl3Username.Location = new System.Drawing.Point(143, 13);
            this.lbPl3Username.Name = "lbPl3Username";
            this.lbPl3Username.Size = new System.Drawing.Size(223, 37);
            this.lbPl3Username.TabIndex = 4;
            this.lbPl3Username.Text = "Player3Username";
            // 
            // pbPl3Avatar
            // 
            this.pbPl3Avatar.Image = global::RiskGame.Properties.Resources.dice;
            this.pbPl3Avatar.Location = new System.Drawing.Point(3, 3);
            this.pbPl3Avatar.Name = "pbPl3Avatar";
            this.pbPl3Avatar.Size = new System.Drawing.Size(115, 101);
            this.pbPl3Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPl3Avatar.TabIndex = 2;
            this.pbPl3Avatar.TabStop = false;
            // 
            // pnlStripe
            // 
            this.pnlStripe.Location = new System.Drawing.Point(12, 597);
            this.pnlStripe.Name = "pnlStripe";
            this.pnlStripe.Size = new System.Drawing.Size(1032, 152);
            this.pnlStripe.TabIndex = 8;
            // 
            // pbTradeCards
            // 
            this.pbTradeCards.Image = global::RiskGame.Properties.Resources.tradeCardsAnimation;
            this.pbTradeCards.Location = new System.Drawing.Point(800, 408);
            this.pbTradeCards.Name = "pbTradeCards";
            this.pbTradeCards.Size = new System.Drawing.Size(220, 98);
            this.pbTradeCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTradeCards.TabIndex = 9;
            this.pbTradeCards.TabStop = false;
            this.pbTradeCards.Click += new System.EventHandler(this.pbTradeCards_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(929, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(91, 75);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmPlayerSwapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1032, 621);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pbTradeCards);
            this.Controls.Add(this.pnlStripe);
            this.Controls.Add(this.pnlPlayer3);
            this.Controls.Add(this.pnlPlayer2);
            this.Controls.Add(this.pnlPlayer1);
            this.Controls.Add(this.label1);
            this.Name = "frmPlayerSwapper";
            this.Text = "Risk: Player Swapper";
            this.Load += new System.EventHandler(this.frmPlayerSwapper_Load);
            this.pnlPlayer1.ResumeLayout(false);
            this.pnlPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPl1Avatar)).EndInit();
            this.pnlPlayer2.ResumeLayout(false);
            this.pnlPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPl2Avatar)).EndInit();
            this.pnlPlayer3.ResumeLayout(false);
            this.pnlPlayer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPl3Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTradeCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPl1Avatar;
        private System.Windows.Forms.PictureBox pbPl3Avatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPl1Username;
        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.PictureBox pbPl2Avatar;
        private System.Windows.Forms.Label lbPl2Username;
        private System.Windows.Forms.Panel pnlPlayer3;
        private System.Windows.Forms.Label lbPl3Username;
        private System.Windows.Forms.Panel pnlStripe;
        private System.Windows.Forms.PictureBox pbTradeCards;
        private System.Windows.Forms.Button btnHelp;
    }
}