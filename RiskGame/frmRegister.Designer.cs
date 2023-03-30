
namespace RiskGame
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.lbCreate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbConfirmPassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbUsernameDescription = new System.Windows.Forms.Label();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.pnlConfirmPassword = new System.Windows.Forms.Panel();
            this.lbPasswordDescription = new System.Windows.Forms.Label();
            this.lbConfirmDescription = new System.Windows.Forms.Label();
            this.cbIgnoreRequirements = new System.Windows.Forms.CheckBox();
            this.lbAvatar = new System.Windows.Forms.Label();
            this.lbAvatarDescrption = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlUsername.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlConfirmPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCreate
            // 
            this.lbCreate.AutoSize = true;
            this.lbCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreate.Location = new System.Drawing.Point(100, 9);
            this.lbCreate.Name = "lbCreate";
            this.lbCreate.Size = new System.Drawing.Size(324, 42);
            this.lbCreate.TabIndex = 1;
            this.lbCreate.Text = "Create an account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RiskGame.Properties.Resources.NewUserIcon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbUsername.Location = new System.Drawing.Point(-7, -4);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(164, 37);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(-1, 39);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(465, 43);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(0, 44);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(465, 43);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(-7, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(158, 37);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(0, 44);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(467, 43);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            this.txtConfirmPassword.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.AutoSize = true;
            this.lbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPassword.Location = new System.Drawing.Point(-7, 0);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(280, 37);
            this.lbConfirmPassword.TabIndex = 6;
            this.lbConfirmPassword.Text = "Confirm Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(20, 354);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(242, 71);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbUsernameDescription
            // 
            this.lbUsernameDescription.AutoSize = true;
            this.lbUsernameDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsernameDescription.Location = new System.Drawing.Point(295, 163);
            this.lbUsernameDescription.Name = "lbUsernameDescription";
            this.lbUsernameDescription.Size = new System.Drawing.Size(482, 63);
            this.lbUsernameDescription.TabIndex = 9;
            this.lbUsernameDescription.Text = resources.GetString("lbUsernameDescription.Text");
            // 
            // pnlUsername
            // 
            this.pnlUsername.Controls.Add(this.lbUsername);
            this.pnlUsername.Controls.Add(this.txtUsername);
            this.pnlUsername.Location = new System.Drawing.Point(299, 75);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(478, 85);
            this.pnlUsername.TabIndex = 10;
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.lbPassword);
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Location = new System.Drawing.Point(299, 183);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(478, 87);
            this.pnlPassword.TabIndex = 11;
            // 
            // pnlConfirmPassword
            // 
            this.pnlConfirmPassword.Controls.Add(this.lbConfirmPassword);
            this.pnlConfirmPassword.Controls.Add(this.txtConfirmPassword);
            this.pnlConfirmPassword.Location = new System.Drawing.Point(299, 297);
            this.pnlConfirmPassword.Name = "pnlConfirmPassword";
            this.pnlConfirmPassword.Size = new System.Drawing.Size(478, 91);
            this.pnlConfirmPassword.TabIndex = 12;
            // 
            // lbPasswordDescription
            // 
            this.lbPasswordDescription.AutoSize = true;
            this.lbPasswordDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordDescription.Location = new System.Drawing.Point(295, 273);
            this.lbPasswordDescription.Name = "lbPasswordDescription";
            this.lbPasswordDescription.Size = new System.Drawing.Size(468, 63);
            this.lbPasswordDescription.TabIndex = 13;
            this.lbPasswordDescription.Text = "This should be a secure password, your personal data is protected \r\nwith AES-256 " +
    "encryption. Enter at least 1 number, 1 Uppercase \r\ncharacter, and a special symb" +
    "ol. Must be at least 6 characters long.";
            // 
            // lbConfirmDescription
            // 
            this.lbConfirmDescription.AutoSize = true;
            this.lbConfirmDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmDescription.Location = new System.Drawing.Point(299, 391);
            this.lbConfirmDescription.Name = "lbConfirmDescription";
            this.lbConfirmDescription.Size = new System.Drawing.Size(347, 21);
            this.lbConfirmDescription.TabIndex = 14;
            this.lbConfirmDescription.Text = "This should be exactly the same as the password.";
            // 
            // cbIgnoreRequirements
            // 
            this.cbIgnoreRequirements.AutoSize = true;
            this.cbIgnoreRequirements.Checked = true;
            this.cbIgnoreRequirements.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreRequirements.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIgnoreRequirements.Location = new System.Drawing.Point(563, 9);
            this.cbIgnoreRequirements.Name = "cbIgnoreRequirements";
            this.cbIgnoreRequirements.Size = new System.Drawing.Size(225, 34);
            this.cbIgnoreRequirements.TabIndex = 15;
            this.cbIgnoreRequirements.Text = "Ignore Requirements";
            this.cbIgnoreRequirements.UseVisualStyleBackColor = true;
            // 
            // lbAvatar
            // 
            this.lbAvatar.AutoSize = true;
            this.lbAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvatar.Location = new System.Drawing.Point(76, 250);
            this.lbAvatar.Name = "lbAvatar";
            this.lbAvatar.Size = new System.Drawing.Size(110, 37);
            this.lbAvatar.TabIndex = 16;
            this.lbAvatar.Text = "Avatar";
            // 
            // lbAvatarDescrption
            // 
            this.lbAvatarDescrption.AutoSize = true;
            this.lbAvatarDescrption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAvatarDescrption.Location = new System.Drawing.Point(16, 291);
            this.lbAvatarDescrption.Name = "lbAvatarDescrption";
            this.lbAvatarDescrption.Size = new System.Drawing.Size(242, 60);
            this.lbAvatarDescrption.TabIndex = 17;
            this.lbAvatarDescrption.Text = "Click the above image to change.\r\nYour avatar will appear with your\r\nusername whe" +
    "n playing.";
            this.lbAvatarDescrption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(36, 80);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(180, 167);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 18;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.pbAvatar_Click);
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdmin.Location = new System.Drawing.Point(682, 12);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(95, 29);
            this.cbAdmin.TabIndex = 19;
            this.cbAdmin.Text = "Admin?";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.lbAvatarDescrption);
            this.Controls.Add(this.lbAvatar);
            this.Controls.Add(this.cbIgnoreRequirements);
            this.Controls.Add(this.lbConfirmDescription);
            this.Controls.Add(this.pnlConfirmPassword);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlUsername);
            this.Controls.Add(this.lbUsernameDescription);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbCreate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbPasswordDescription);
            this.Name = "frmRegister";
            this.Text = "Risk: Create an account";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlConfirmPassword.ResumeLayout(false);
            this.pnlConfirmPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCreate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lbConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbUsernameDescription;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel pnlConfirmPassword;
        private System.Windows.Forms.Label lbPasswordDescription;
        private System.Windows.Forms.Label lbConfirmDescription;
        private System.Windows.Forms.CheckBox cbIgnoreRequirements;
        private System.Windows.Forms.Label lbAvatar;
        private System.Windows.Forms.Label lbAvatarDescrption;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.CheckBox cbAdmin;
    }
}