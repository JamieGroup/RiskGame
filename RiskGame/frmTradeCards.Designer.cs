
namespace RiskGame
{
    partial class frmTradeCards
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
            this.pnlTradeSidebar = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.pnlTradeSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTradeSidebar
            // 
            this.pnlTradeSidebar.BackColor = System.Drawing.Color.LightGray;
            this.pnlTradeSidebar.Controls.Add(this.btnContinue);
            this.pnlTradeSidebar.Location = new System.Drawing.Point(694, -1);
            this.pnlTradeSidebar.Name = "pnlTradeSidebar";
            this.pnlTradeSidebar.Size = new System.Drawing.Size(339, 622);
            this.pnlTradeSidebar.TabIndex = 0;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(58, 509);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // frmTradeCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 621);
            this.Controls.Add(this.pnlTradeSidebar);
            this.Name = "frmTradeCards";
            this.Text = "Risk: Trade Cards";
            this.Load += new System.EventHandler(this.frmTradeCards_Load);
            this.pnlTradeSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTradeSidebar;
        private System.Windows.Forms.Button btnContinue;
    }
}