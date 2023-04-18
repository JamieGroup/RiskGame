namespace RiskGame
{
    partial class frmRoundEnd
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
            this.pbLose = new System.Windows.Forms.PictureBox();
            this.pbWin = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnGoToDashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLose
            // 
            this.pbLose.Image = global::RiskGame.Properties.Resources.atleastyoutried;
            this.pbLose.Location = new System.Drawing.Point(290, 73);
            this.pbLose.Name = "pbLose";
            this.pbLose.Size = new System.Drawing.Size(515, 384);
            this.pbLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLose.TabIndex = 1;
            this.pbLose.TabStop = false;
            this.pbLose.Visible = false;
            // 
            // pbWin
            // 
            this.pbWin.Image = global::RiskGame.Properties.Resources.balloon_colors;
            this.pbWin.Location = new System.Drawing.Point(216, 73);
            this.pbWin.Name = "pbWin";
            this.pbWin.Size = new System.Drawing.Size(589, 384);
            this.pbWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWin.TabIndex = 0;
            this.pbWin.TabStop = false;
            this.pbWin.Visible = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 32F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTitle.Location = new System.Drawing.Point(512, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(276, 59);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Round Over";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Segoe UI Black", 32F, System.Drawing.FontStyle.Bold);
            this.lbMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.lbMessage.Location = new System.Drawing.Point(12, 9);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(276, 59);
            this.lbMessage.TabIndex = 3;
            this.lbMessage.Text = "Round Over";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbInfo.Location = new System.Drawing.Point(17, 84);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(46, 30);
            this.lbInfo.TabIndex = 4;
            this.lbInfo.Text = "abc";
            // 
            // btnGoToDashboard
            // 
            this.btnGoToDashboard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToDashboard.Location = new System.Drawing.Point(12, 388);
            this.btnGoToDashboard.Name = "btnGoToDashboard";
            this.btnGoToDashboard.Size = new System.Drawing.Size(225, 50);
            this.btnGoToDashboard.TabIndex = 5;
            this.btnGoToDashboard.Text = "Return to Dashboard";
            this.btnGoToDashboard.UseVisualStyleBackColor = true;
            this.btnGoToDashboard.Click += new System.EventHandler(this.btnGoToDashboard_Click);
            // 
            // frmRoundEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoToDashboard);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pbLose);
            this.Controls.Add(this.pbWin);
            this.DoubleBuffered = true;
            this.Name = "frmRoundEnd";
            this.Text = "Risk: Round Over";
            ((System.ComponentModel.ISupportInitialize)(this.pbLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWin;
        private System.Windows.Forms.PictureBox pbLose;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnGoToDashboard;
    }
}