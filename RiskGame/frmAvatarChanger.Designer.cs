namespace RiskGame
{
    partial class frmAvatarChanger
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
            this.pnlRandomHolder = new System.Windows.Forms.Panel();
            this.pnlRnd1 = new System.Windows.Forms.Panel();
            this.pnlRnd2 = new System.Windows.Forms.Panel();
            this.pnlRnd3 = new System.Windows.Forms.Panel();
            this.btnRandom = new System.Windows.Forms.Button();
            this.pnlRandomHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRandomHolder
            // 
            this.pnlRandomHolder.Controls.Add(this.pnlRnd3);
            this.pnlRandomHolder.Controls.Add(this.pnlRnd2);
            this.pnlRandomHolder.Controls.Add(this.pnlRnd1);
            this.pnlRandomHolder.Location = new System.Drawing.Point(22, 115);
            this.pnlRandomHolder.Name = "pnlRandomHolder";
            this.pnlRandomHolder.Size = new System.Drawing.Size(762, 251);
            this.pnlRandomHolder.TabIndex = 0;
            // 
            // pnlRnd1
            // 
            this.pnlRnd1.Location = new System.Drawing.Point(4, 4);
            this.pnlRnd1.Name = "pnlRnd1";
            this.pnlRnd1.Size = new System.Drawing.Size(240, 240);
            this.pnlRnd1.TabIndex = 0;
            this.pnlRnd1.Click += new System.EventHandler(this.pnlRnd1_Click);
            // 
            // pnlRnd2
            // 
            this.pnlRnd2.Location = new System.Drawing.Point(259, 4);
            this.pnlRnd2.Name = "pnlRnd2";
            this.pnlRnd2.Size = new System.Drawing.Size(240, 240);
            this.pnlRnd2.TabIndex = 1;
            // 
            // pnlRnd3
            // 
            this.pnlRnd3.Location = new System.Drawing.Point(517, 4);
            this.pnlRnd3.Name = "pnlRnd3";
            this.pnlRnd3.Size = new System.Drawing.Size(240, 240);
            this.pnlRnd3.TabIndex = 2;
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(281, 383);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(240, 45);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "Reroll Images";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // frmAvatarChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.pnlRandomHolder);
            this.Name = "frmAvatarChanger";
            this.Text = "Avatar Changer";
            this.pnlRandomHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRandomHolder;
        private System.Windows.Forms.Panel pnlRnd3;
        private System.Windows.Forms.Panel pnlRnd2;
        private System.Windows.Forms.Panel pnlRnd1;
        private System.Windows.Forms.Button btnRandom;
    }
}