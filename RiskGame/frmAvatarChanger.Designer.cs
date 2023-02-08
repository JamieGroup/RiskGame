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
            this.pnlRnd3 = new System.Windows.Forms.Panel();
            this.pnlRnd2 = new System.Windows.Forms.Panel();
            this.pnlRnd1 = new System.Windows.Forms.Panel();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbInstructions = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.pnlRandomHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
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
            // pnlRnd3
            // 
            this.pnlRnd3.Location = new System.Drawing.Point(517, 4);
            this.pnlRnd3.Name = "pnlRnd3";
            this.pnlRnd3.Size = new System.Drawing.Size(240, 240);
            this.pnlRnd3.TabIndex = 2;
            // 
            // pnlRnd2
            // 
            this.pnlRnd2.Location = new System.Drawing.Point(259, 4);
            this.pnlRnd2.Name = "pnlRnd2";
            this.pnlRnd2.Size = new System.Drawing.Size(240, 240);
            this.pnlRnd2.TabIndex = 1;
            // 
            // pnlRnd1
            // 
            this.pnlRnd1.Location = new System.Drawing.Point(4, 4);
            this.pnlRnd1.Name = "pnlRnd1";
            this.pnlRnd1.Size = new System.Drawing.Size(240, 240);
            this.pnlRnd1.TabIndex = 0;
            this.pnlRnd1.Click += new System.EventHandler(this.pnlRnd1_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(22, 383);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(240, 45);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "Reroll Images";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenImage.Location = new System.Drawing.Point(375, 48);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(404, 46);
            this.btnOpenImage.TabIndex = 2;
            this.btnOpenImage.Text = "Or choose your own...";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(157, 30);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Avatar Changer";
            // 
            // lbInstructions
            // 
            this.lbInstructions.AutoSize = true;
            this.lbInstructions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstructions.Location = new System.Drawing.Point(21, 63);
            this.lbInstructions.Name = "lbInstructions";
            this.lbInstructions.Size = new System.Drawing.Size(274, 25);
            this.lbInstructions.TabIndex = 4;
            this.lbInstructions.Text = "Choose a random image below";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(643, 383);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(141, 45);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done!";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(552, 372);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(75, 75);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 6;
            this.pbPreview.TabStop = false;
            this.pbPreview.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmAvatarChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lbInstructions);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.pnlRandomHolder);
            this.Name = "frmAvatarChanger";
            this.Text = "Avatar Changer";
            this.Load += new System.EventHandler(this.frmAvatarChanger_Load);
            this.pnlRandomHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRandomHolder;
        private System.Windows.Forms.Panel pnlRnd3;
        private System.Windows.Forms.Panel pnlRnd2;
        private System.Windows.Forms.Panel pnlRnd1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbInstructions;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.PictureBox pbPreview;
    }
}