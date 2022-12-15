﻿
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DEBUG_cbFirstLaunch = new System.Windows.Forms.CheckBox();
            this.DEBUG_cbRequirePassword = new System.Windows.Forms.CheckBox();
            this.DEBUGbtnSkipToGame = new System.Windows.Forms.Button();
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
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 583);
            this.Controls.Add(this.DEBUGbtnSkipToGame);
            this.Controls.Add(this.DEBUG_cbRequirePassword);
            this.Controls.Add(this.DEBUG_cbFirstLaunch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "Risk: Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox DEBUG_cbFirstLaunch;
        private System.Windows.Forms.CheckBox DEBUG_cbRequirePassword;
        private System.Windows.Forms.Button DEBUGbtnSkipToGame;
    }
}