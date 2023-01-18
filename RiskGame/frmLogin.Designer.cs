
namespace RiskGame
{
    partial class frmLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.DEBUG_cbRequirePassword = new System.Windows.Forms.CheckBox();
            this.DEBUGbtnSkipToGame = new System.Windows.Forms.Button();
            this.DEBUG_cbFirstLaunch = new System.Windows.Forms.CheckBox();
            this.DEBUGcbIgnoreAssigned = new System.Windows.Forms.CheckBox();
            this.newProgressBar1 = new RiskGame.NewProgressBar();
            this.pbNewArrow = new System.Windows.Forms.PictureBox();
            this.pbNewUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Risk!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(418, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please select your account.";
            // 
            // DEBUG_cbRequirePassword
            // 
            this.DEBUG_cbRequirePassword.AutoSize = true;
            this.DEBUG_cbRequirePassword.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEBUG_cbRequirePassword.Location = new System.Drawing.Point(225, 55);
            this.DEBUG_cbRequirePassword.Name = "DEBUG_cbRequirePassword";
            this.DEBUG_cbRequirePassword.Size = new System.Drawing.Size(289, 23);
            this.DEBUG_cbRequirePassword.TabIndex = 4;
            this.DEBUG_cbRequirePassword.Text = "Debug Tool: Require Password?";
            this.DEBUG_cbRequirePassword.UseVisualStyleBackColor = true;
            // 
            // DEBUGbtnSkipToGame
            // 
            this.DEBUGbtnSkipToGame.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEBUGbtnSkipToGame.Location = new System.Drawing.Point(12, 51);
            this.DEBUGbtnSkipToGame.Name = "DEBUGbtnSkipToGame";
            this.DEBUGbtnSkipToGame.Size = new System.Drawing.Size(206, 28);
            this.DEBUGbtnSkipToGame.TabIndex = 5;
            this.DEBUGbtnSkipToGame.Text = "Debug: Skip to Game";
            this.DEBUGbtnSkipToGame.UseVisualStyleBackColor = true;
            this.DEBUGbtnSkipToGame.Click += new System.EventHandler(this.DEBUGbtnSkipToGame_Click);
            // 
            // DEBUG_cbFirstLaunch
            // 
            this.DEBUG_cbFirstLaunch.AutoSize = true;
            this.DEBUG_cbFirstLaunch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEBUG_cbFirstLaunch.Location = new System.Drawing.Point(541, 55);
            this.DEBUG_cbFirstLaunch.Name = "DEBUG_cbFirstLaunch";
            this.DEBUG_cbFirstLaunch.Size = new System.Drawing.Size(253, 23);
            this.DEBUG_cbFirstLaunch.TabIndex = 3;
            this.DEBUG_cbFirstLaunch.Text = "Debug Tool: First Launch?";
            this.DEBUG_cbFirstLaunch.UseVisualStyleBackColor = true;
            this.DEBUG_cbFirstLaunch.CheckedChanged += new System.EventHandler(this.DEBUG_cbFirstLaunch_CheckedChanged);
            // 
            // DEBUGcbIgnoreAssigned
            // 
            this.DEBUGcbIgnoreAssigned.AutoSize = true;
            this.DEBUGcbIgnoreAssigned.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEBUGcbIgnoreAssigned.Location = new System.Drawing.Point(541, 84);
            this.DEBUGcbIgnoreAssigned.Name = "DEBUGcbIgnoreAssigned";
            this.DEBUGcbIgnoreAssigned.Size = new System.Drawing.Size(280, 23);
            this.DEBUGcbIgnoreAssigned.TabIndex = 6;
            this.DEBUGcbIgnoreAssigned.Text = "Debug Tool: Ignore Assigned?";
            this.DEBUGcbIgnoreAssigned.UseVisualStyleBackColor = true;
            this.DEBUGcbIgnoreAssigned.CheckedChanged += new System.EventHandler(this.DEBUGcbIgnoreAssigned_CheckedChanged);
            // 
            // newProgressBar1
            // 
            this.newProgressBar1.Location = new System.Drawing.Point(282, 430);
            this.newProgressBar1.Name = "newProgressBar1";
            this.newProgressBar1.Size = new System.Drawing.Size(100, 23);
            this.newProgressBar1.TabIndex = 8;
            // 
            // pbNewArrow
            // 
            this.pbNewArrow.BackColor = System.Drawing.Color.Transparent;
            this.pbNewArrow.Image = global::RiskGame.Properties.Resources.CurvedArrowFixed;
            this.pbNewArrow.Location = new System.Drawing.Point(813, 100);
            this.pbNewArrow.Name = "pbNewArrow";
            this.pbNewArrow.Size = new System.Drawing.Size(142, 126);
            this.pbNewArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNewArrow.TabIndex = 9;
            this.pbNewArrow.TabStop = false;
            this.pbNewArrow.Visible = false;
            // 
            // pbNewUser
            // 
            this.pbNewUser.BackColor = System.Drawing.Color.Transparent;
            this.pbNewUser.Image = global::RiskGame.Properties.Resources.loginNewUserPrompt;
            this.pbNewUser.Location = new System.Drawing.Point(520, 177);
            this.pbNewUser.Name = "pbNewUser";
            this.pbNewUser.Size = new System.Drawing.Size(344, 110);
            this.pbNewUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNewUser.TabIndex = 7;
            this.pbNewUser.TabStop = false;
            this.pbNewUser.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RiskGame.Properties.Resources.AddNewUser;
            this.pictureBox1.Location = new System.Drawing.Point(800, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 583);
            this.Controls.Add(this.pbNewArrow);
            this.Controls.Add(this.newProgressBar1);
            this.Controls.Add(this.DEBUGcbIgnoreAssigned);
            this.Controls.Add(this.DEBUGbtnSkipToGame);
            this.Controls.Add(this.DEBUG_cbRequirePassword);
            this.Controls.Add(this.DEBUG_cbFirstLaunch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbNewUser);
            this.Name = "frmLogin";
            this.Text = "Risk: Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNewArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox DEBUG_cbRequirePassword;
        private System.Windows.Forms.Button DEBUGbtnSkipToGame;
        private System.Windows.Forms.CheckBox DEBUG_cbFirstLaunch;
        private System.Windows.Forms.CheckBox DEBUGcbIgnoreAssigned;
        private System.Windows.Forms.PictureBox pbNewUser;
        private NewProgressBar newProgressBar1;
        private System.Windows.Forms.PictureBox pbNewArrow;
    }
}