
namespace RiskGame
{
    partial class frmColourSwitcher
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
            this.pnlHolder = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a colour";
            // 
            // pnlHolder
            // 
            this.pnlHolder.Location = new System.Drawing.Point(21, 49);
            this.pnlHolder.Name = "pnlHolder";
            this.pnlHolder.Size = new System.Drawing.Size(424, 260);
            this.pnlHolder.TabIndex = 4;
            // 
            // frmColourSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 328);
            this.Controls.Add(this.pnlHolder);
            this.Controls.Add(this.label1);
            this.Name = "frmColourSwitcher";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.frmColourSwitcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlHolder;
    }
}