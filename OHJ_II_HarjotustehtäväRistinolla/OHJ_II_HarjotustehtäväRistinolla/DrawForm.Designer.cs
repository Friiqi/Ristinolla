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
            this.components = new System.ComponentModel.Container();
            this.lblPlayer1FullName = new System.Windows.Forms.Label();
            this.lblPlayer1TotalWins = new System.Windows.Forms.Label();
            this.lblPlayer1TotalDraws = new System.Windows.Forms.Label();
            this.lblPlayer2TotalDraws = new System.Windows.Forms.Label();
            this.lblPlayer2TotalWins = new System.Windows.Forms.Label();
            this.lblPlayer2FullName = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblWhoseTurn = new System.Windows.Forms.Label();
            this.lblActivePlayerName = new System.Windows.Forms.Label();
            this.AINeedsToThink2 = new System.Windows.Forms.Timer(this.components);
            this.lblPlayer1TotalLosses = new System.Windows.Forms.Label();
            this.lblPlayer2TotalLosses = new System.Windows.Forms.Label();
            this.lblDraws = new System.Windows.Forms.Label();
            this.lblLosses = new System.Windows.Forms.Label();
            this.lblLosses2 = new System.Windows.Forms.Label();
            this.lblDraws2 = new System.Windows.Forms.Label();
            this.lblWins2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayer1FullName
            // 
            this.lblPlayer1FullName.AutoSize = true;
            this.lblPlayer1FullName.Location = new System.Drawing.Point(12, 9);
            this.lblPlayer1FullName.Name = "lblPlayer1FullName";
            this.lblPlayer1FullName.Size = new System.Drawing.Size(66, 13);
            this.lblPlayer1FullName.TabIndex = 0;
            this.lblPlayer1FullName.Text = "Pelaajannimi";
            // 
            // lblPlayer1TotalWins
            // 
            this.lblPlayer1TotalWins.AutoSize = true;
            this.lblPlayer1TotalWins.Location = new System.Drawing.Point(49, 22);
            this.lblPlayer1TotalWins.Name = "lblPlayer1TotalWins";
            this.lblPlayer1TotalWins.Size = new System.Drawing.Size(76, 13);
            this.lblPlayer1TotalWins.TabIndex = 1;
            this.lblPlayer1TotalWins.Text = "voitotyhteensa";
            // 
            // lblPlayer1TotalDraws
            // 
            this.lblPlayer1TotalDraws.AutoSize = true;
            this.lblPlayer1TotalDraws.Location = new System.Drawing.Point(68, 35);
            this.lblPlayer1TotalDraws.Name = "lblPlayer1TotalDraws";
            this.lblPlayer1TotalDraws.Size = new System.Drawing.Size(89, 13);
            this.lblPlayer1TotalDraws.TabIndex = 2;
            this.lblPlayer1TotalDraws.Text = "tasapelityhteensa";
            // 
            // lblPlayer2TotalDraws
            // 
            this.lblPlayer2TotalDraws.AutoSize = true;
            this.lblPlayer2TotalDraws.Location = new System.Drawing.Point(766, 35);
            this.lblPlayer2TotalDraws.Name = "lblPlayer2TotalDraws";
            this.lblPlayer2TotalDraws.Size = new System.Drawing.Size(89, 13);
            this.lblPlayer2TotalDraws.TabIndex = 5;
            this.lblPlayer2TotalDraws.Text = "tasapelityhteensa";
            this.lblPlayer2TotalDraws.Click += new System.EventHandler(this.lblPlayer2TotalDraws_Click);
            // 
            // lblPlayer2TotalWins
            // 
            this.lblPlayer2TotalWins.AutoSize = true;
            this.lblPlayer2TotalWins.Location = new System.Drawing.Point(750, 22);
            this.lblPlayer2TotalWins.Name = "lblPlayer2TotalWins";
            this.lblPlayer2TotalWins.Size = new System.Drawing.Size(76, 13);
            this.lblPlayer2TotalWins.TabIndex = 4;
            this.lblPlayer2TotalWins.Text = "voitotyhteensa";
            // 
            // lblPlayer2FullName
            // 
            this.lblPlayer2FullName.AutoSize = true;
            this.lblPlayer2FullName.Location = new System.Drawing.Point(710, 9);
            this.lblPlayer2FullName.Name = "lblPlayer2FullName";
            this.lblPlayer2FullName.Size = new System.Drawing.Size(66, 13);
            this.lblPlayer2FullName.TabIndex = 3;
            this.lblPlayer2FullName.Text = "Pelaaja2nimi";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(12, 22);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(34, 13);
            this.lblWins.TabIndex = 7;
            this.lblWins.Text = "Voitot";
            // 
            // lblWhoseTurn
            // 
            this.lblWhoseTurn.AutoSize = true;
            this.lblWhoseTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhoseTurn.Location = new System.Drawing.Point(264, 9);
            this.lblWhoseTurn.Name = "lblWhoseTurn";
            this.lblWhoseTurn.Size = new System.Drawing.Size(87, 20);
            this.lblWhoseTurn.TabIndex = 8;
            this.lblWhoseTurn.Text = "Pelivuoro:";
            // 
            // lblActivePlayerName
            // 
            this.lblActivePlayerName.AutoSize = true;
            this.lblActivePlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivePlayerName.Location = new System.Drawing.Point(363, 9);
            this.lblActivePlayerName.Name = "lblActivePlayerName";
            this.lblActivePlayerName.Size = new System.Drawing.Size(77, 20);
            this.lblActivePlayerName.TabIndex = 9;
            this.lblActivePlayerName.Text = "[pelaaja]";
            // 
            // AINeedsToThink2
            // 
            this.AINeedsToThink2.Tick += new System.EventHandler(this.AINeedsToThink2_Tick);
            // 
            // lblPlayer1TotalLosses
            // 
            this.lblPlayer1TotalLosses.AutoSize = true;
            this.lblPlayer1TotalLosses.Location = new System.Drawing.Point(49, 48);
            this.lblPlayer1TotalLosses.Name = "lblPlayer1TotalLosses";
            this.lblPlayer1TotalLosses.Size = new System.Drawing.Size(79, 13);
            this.lblPlayer1TotalLosses.TabIndex = 10;
            this.lblPlayer1TotalLosses.Text = "haviotyhteensa";
            // 
            // lblPlayer2TotalLosses
            // 
            this.lblPlayer2TotalLosses.AutoSize = true;
            this.lblPlayer2TotalLosses.Location = new System.Drawing.Point(750, 48);
            this.lblPlayer2TotalLosses.Name = "lblPlayer2TotalLosses";
            this.lblPlayer2TotalLosses.Size = new System.Drawing.Size(79, 13);
            this.lblPlayer2TotalLosses.TabIndex = 11;
            this.lblPlayer2TotalLosses.Text = "haviotyhteensa";
            // 
            // lblDraws
            // 
            this.lblDraws.AutoSize = true;
            this.lblDraws.Location = new System.Drawing.Point(12, 35);
            this.lblDraws.Name = "lblDraws";
            this.lblDraws.Size = new System.Drawing.Size(50, 13);
            this.lblDraws.TabIndex = 13;
            this.lblDraws.Text = "Tasapelit";
            // 
            // lblLosses
            // 
            this.lblLosses.AutoSize = true;
            this.lblLosses.Location = new System.Drawing.Point(12, 48);
            this.lblLosses.Name = "lblLosses";
            this.lblLosses.Size = new System.Drawing.Size(34, 13);
            this.lblLosses.TabIndex = 14;
            this.lblLosses.Text = "Voitot";
            // 
            // lblLosses2
            // 
            this.lblLosses2.AutoSize = true;
            this.lblLosses2.Location = new System.Drawing.Point(710, 48);
            this.lblLosses2.Name = "lblLosses2";
            this.lblLosses2.Size = new System.Drawing.Size(34, 13);
            this.lblLosses2.TabIndex = 19;
            this.lblLosses2.Text = "Voitot";
            // 
            // lblDraws2
            // 
            this.lblDraws2.AutoSize = true;
            this.lblDraws2.Location = new System.Drawing.Point(710, 35);
            this.lblDraws2.Name = "lblDraws2";
            this.lblDraws2.Size = new System.Drawing.Size(50, 13);
            this.lblDraws2.TabIndex = 18;
            this.lblDraws2.Text = "Tasapelit";
            // 
            // lblWins2
            // 
            this.lblWins2.AutoSize = true;
            this.lblWins2.Location = new System.Drawing.Point(710, 22);
            this.lblWins2.Name = "lblWins2";
            this.lblWins2.Size = new System.Drawing.Size(34, 13);
            this.lblWins2.TabIndex = 17;
            this.lblWins2.Text = "Voitot";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Sulje";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblLosses2);
            this.Controls.Add(this.lblDraws2);
            this.Controls.Add(this.lblWins2);
            this.Controls.Add(this.lblLosses);
            this.Controls.Add(this.lblDraws);
            this.Controls.Add(this.lblPlayer2TotalLosses);
            this.Controls.Add(this.lblPlayer1TotalLosses);
            this.Controls.Add(this.lblActivePlayerName);
            this.Controls.Add(this.lblWhoseTurn);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblPlayer2TotalDraws);
            this.Controls.Add(this.lblPlayer2TotalWins);
            this.Controls.Add(this.lblPlayer2FullName);
            this.Controls.Add(this.lblPlayer1TotalDraws);
            this.Controls.Add(this.lblPlayer1TotalWins);
            this.Controls.Add(this.lblPlayer1FullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DrawForm";
            this.Text = "Ristinolla";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DrawForm_FormClosing);
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
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblWhoseTurn;
        private System.Windows.Forms.Label lblActivePlayerName;
        private System.Windows.Forms.Timer AINeedsToThink2;
        private System.Windows.Forms.Label lblPlayer1TotalLosses;
        private System.Windows.Forms.Label lblPlayer2TotalLosses;
        private System.Windows.Forms.Label lblDraws;
        private System.Windows.Forms.Label lblLosses;
        private System.Windows.Forms.Label lblLosses2;
        private System.Windows.Forms.Label lblDraws2;
        private System.Windows.Forms.Label lblWins2;
        private System.Windows.Forms.Button btnClose;
    }
}