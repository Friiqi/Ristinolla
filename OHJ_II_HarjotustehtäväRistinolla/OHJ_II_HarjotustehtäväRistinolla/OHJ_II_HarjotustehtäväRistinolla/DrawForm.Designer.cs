namespace OHJ_II_HarjotustehtäväRistinolla
{
    partial class DrawForm
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
            this.lblPlayer1FullName = new System.Windows.Forms.Label();
            this.lblPlayer1TotalWins = new System.Windows.Forms.Label();
            this.lblPlayer1TotalDraws = new System.Windows.Forms.Label();
            this.lblPlayer2TotalDraws = new System.Windows.Forms.Label();
            this.lblPlayer2TotalWins = new System.Windows.Forms.Label();
            this.lblPlayer2FullName = new System.Windows.Forms.Label();
            this.lblPlayer2TotalPlayTime = new System.Windows.Forms.Label();
            this.lblPlayer1TotalPlayTime = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblPlayer1FullName
            // 
            this.lblPlayer1FullName.AutoSize = true;
            this.lblPlayer1FullName.Location = new System.Drawing.Point(117, 9);
            this.lblPlayer1FullName.Name = "lblPlayer1FullName";
            this.lblPlayer1FullName.Size = new System.Drawing.Size(66, 13);
            this.lblPlayer1FullName.TabIndex = 0;
            this.lblPlayer1FullName.Text = "Pelaajannimi";
            // 
            // lblPlayer1TotalWins
            // 
            this.lblPlayer1TotalWins.AutoSize = true;
            this.lblPlayer1TotalWins.Location = new System.Drawing.Point(117, 26);
            this.lblPlayer1TotalWins.Name = "lblPlayer1TotalWins";
            this.lblPlayer1TotalWins.Size = new System.Drawing.Size(76, 13);
            this.lblPlayer1TotalWins.TabIndex = 1;
            this.lblPlayer1TotalWins.Text = "voitotyhteensa";
            // 
            // lblPlayer1TotalDraws
            // 
            this.lblPlayer1TotalDraws.AutoSize = true;
            this.lblPlayer1TotalDraws.Location = new System.Drawing.Point(117, 43);
            this.lblPlayer1TotalDraws.Name = "lblPlayer1TotalDraws";
            this.lblPlayer1TotalDraws.Size = new System.Drawing.Size(89, 13);
            this.lblPlayer1TotalDraws.TabIndex = 2;
            this.lblPlayer1TotalDraws.Text = "tasapelityhteensa";
            // 
            // lblPlayer2TotalDraws
            // 
            this.lblPlayer2TotalDraws.AutoSize = true;
            this.lblPlayer2TotalDraws.Location = new System.Drawing.Point(608, 43);
            this.lblPlayer2TotalDraws.Name = "lblPlayer2TotalDraws";
            this.lblPlayer2TotalDraws.Size = new System.Drawing.Size(89, 13);
            this.lblPlayer2TotalDraws.TabIndex = 5;
            this.lblPlayer2TotalDraws.Text = "tasapelityhteensa";
            // 
            // lblPlayer2TotalWins
            // 
            this.lblPlayer2TotalWins.AutoSize = true;
            this.lblPlayer2TotalWins.Location = new System.Drawing.Point(608, 26);
            this.lblPlayer2TotalWins.Name = "lblPlayer2TotalWins";
            this.lblPlayer2TotalWins.Size = new System.Drawing.Size(76, 13);
            this.lblPlayer2TotalWins.TabIndex = 4;
            this.lblPlayer2TotalWins.Text = "voitotyhteensa";
            // 
            // lblPlayer2FullName
            // 
            this.lblPlayer2FullName.AutoSize = true;
            this.lblPlayer2FullName.Location = new System.Drawing.Point(608, 9);
            this.lblPlayer2FullName.Name = "lblPlayer2FullName";
            this.lblPlayer2FullName.Size = new System.Drawing.Size(66, 13);
            this.lblPlayer2FullName.TabIndex = 3;
            this.lblPlayer2FullName.Text = "Pelaaja2nimi";
            // 
            // lblPlayer2TotalPlayTime
            // 
            this.lblPlayer2TotalPlayTime.AutoSize = true;
            this.lblPlayer2TotalPlayTime.Location = new System.Drawing.Point(719, 9);
            this.lblPlayer2TotalPlayTime.Name = "lblPlayer2TotalPlayTime";
            this.lblPlayer2TotalPlayTime.Size = new System.Drawing.Size(65, 13);
            this.lblPlayer2TotalPlayTime.TabIndex = 6;
            this.lblPlayer2TotalPlayTime.Text = "totalplaytime";
            // 
            // lblPlayer1TotalPlayTime
            // 
            this.lblPlayer1TotalPlayTime.AutoSize = true;
            this.lblPlayer1TotalPlayTime.Location = new System.Drawing.Point(12, 9);
            this.lblPlayer1TotalPlayTime.Name = "lblPlayer1TotalPlayTime";
            this.lblPlayer1TotalPlayTime.Size = new System.Drawing.Size(65, 13);
            this.lblPlayer1TotalPlayTime.TabIndex = 7;
            this.lblPlayer1TotalPlayTime.Text = "totalplaytime";
            // 
            // backgroundWorker1
            // 
            //this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlayer1TotalPlayTime);
            this.Controls.Add(this.lblPlayer2TotalPlayTime);
            this.Controls.Add(this.lblPlayer2TotalDraws);
            this.Controls.Add(this.lblPlayer2TotalWins);
            this.Controls.Add(this.lblPlayer2FullName);
            this.Controls.Add(this.lblPlayer1TotalDraws);
            this.Controls.Add(this.lblPlayer1TotalWins);
            this.Controls.Add(this.lblPlayer1FullName);
            this.Name = "DrawForm";
            this.Text = "Ristinolla";
            this.Load += new System.EventHandler(this.DrawForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1FullName;
        private System.Windows.Forms.Label lblPlayer1TotalWins;
        private System.Windows.Forms.Label lblPlayer1TotalDraws;
        private System.Windows.Forms.Label lblPlayer2TotalDraws;
        private System.Windows.Forms.Label lblPlayer2TotalWins;
        private System.Windows.Forms.Label lblPlayer2FullName;
        private System.Windows.Forms.Label lblPlayer2TotalPlayTime;
        private System.Windows.Forms.Label lblPlayer1TotalPlayTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}