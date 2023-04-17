namespace RiskGame
{
    partial class frmGuide
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
            this.rtxGuide = new System.Windows.Forms.RichTextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxGuide
            // 
            this.rtxGuide.Location = new System.Drawing.Point(0, -1);
            this.rtxGuide.Name = "rtxGuide";
            this.rtxGuide.Size = new System.Drawing.Size(837, 405);
            this.rtxGuide.TabIndex = 0;
            this.rtxGuide.Text = "";
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(621, 410);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(201, 39);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "I understand";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // frmGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.rtxGuide);
            this.Name = "frmGuide";
            this.Text = "Risk: Guide";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxGuide;
        private System.Windows.Forms.Button btnGo;
    }
}