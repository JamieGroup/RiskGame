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
            this.pbPl1Avatar = new System.Windows.Forms.PictureBox();
            this.pbPl3Avatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPl1Username = new System.Windows.Forms.Label();
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.pbPl2Avatar = new System.Windows.Forms.PictureBox();
            this.lbPl2Username = new System.Windows.Forms.Label();
            this.pnlPlayer3 = new System.Windows.Forms.Panel();
            this.lbPl3Username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPl1Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPl3Avatar)).BeginInit();
            this.pnlPlayer1.SuspendLayout();
            this.pnlPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPl2Avatar)).BeginInit();
            this.pnlPlayer3.SuspendLayout();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 41);
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
            this.pnlPlayer1.Location = new System.Drawing.Point(123, 123);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(631, 107);
            this.pnlPlayer1.TabIndex = 5;
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.Controls.Add(this.pbPl2Avatar);
            this.pnlPlayer2.Controls.Add(this.lbPl2Username);
            this.pnlPlayer2.Location = new System.Drawing.Point(123, 269);
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
            this.pnlPlayer3.Location = new System.Drawing.Point(123, 415);
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
            // frmPlayerSwapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1032, 621);
            this.Controls.Add(this.pnlPlayer3);
            this.Controls.Add(this.pnlPlayer2);
            this.Controls.Add(this.pnlPlayer1);
            this.Controls.Add(this.label1);
            this.Name = "frmPlayerSwapper";
            this.Text = "Risk: Player Swapper";
            this.Load += new System.EventHandler(this.frmPlayerSwapper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPl1Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPl3Avatar)).EndInit();
            this.pnlPlayer1.ResumeLayout(false);
            this.pnlPlayer1.PerformLayout();
            this.pnlPlayer2.ResumeLayout(false);
            this.pnlPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPl2Avatar)).EndInit();
            this.pnlPlayer3.ResumeLayout(false);
            this.pnlPlayer3.PerformLayout();
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
    }
}