
namespace RiskGame
{
    partial class frmSplashScreen
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.prbrLoading = new System.Windows.Forms.ProgressBar();
            this.tmrLoading = new System.Windows.Forms.Timer(this.components);
            this.lbLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::RiskGame.Properties.Resources.riskLogo;
            this.pbLogo.Location = new System.Drawing.Point(186, 77);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(467, 190);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // prbrLoading
            // 
            this.prbrLoading.Location = new System.Drawing.Point(186, 297);
            this.prbrLoading.Name = "prbrLoading";
            this.prbrLoading.Size = new System.Drawing.Size(467, 73);
            this.prbrLoading.TabIndex = 1;
            // 
            // tmrLoading
            // 
            this.tmrLoading.Tick += new System.EventHandler(this.tmrLoading_Tick);
            // 
            // lbLoading
            // 
            this.lbLoading.AutoSize = true;
            this.lbLoading.BackColor = System.Drawing.SystemColors.Control;
            this.lbLoading.Font = new System.Drawing.Font("Segoe UI Black", 36F, System.Drawing.FontStyle.Bold);
            this.lbLoading.Location = new System.Drawing.Point(352, 373);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(129, 65);
            this.lbLoading.TabIndex = 2;
            this.lbLoading.Text = "50%";
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.lbLoading);
            this.Controls.Add(this.prbrLoading);
            this.Controls.Add(this.pbLogo);
            this.Name = "frmSplashScreen";
            this.Text = "Risk: Splash Screen";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ProgressBar prbrLoading;
        private System.Windows.Forms.Timer tmrLoading;
        private System.Windows.Forms.Label lbLoading;
    }
}

