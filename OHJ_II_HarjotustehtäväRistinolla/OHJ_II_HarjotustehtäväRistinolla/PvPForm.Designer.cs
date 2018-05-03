namespace OHJ_II_HarjotustehtäväRistinolla
{
    partial class PvPForm
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
            this.btnReturnToMainForm = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblChooseExsitingPlayerInPvE = new System.Windows.Forms.Label();
            this.lblPvPFormCreateNewPlayer = new System.Windows.Forms.Label();
            this.btnCreateNewPlayer = new System.Windows.Forms.Button();
            this.lblPvPFormTopic = new System.Windows.Forms.Label();
            this.lstbPlayerList = new System.Windows.Forms.ListBox();
            this.lstbPlayerList2 = new System.Windows.Forms.ListBox();
            this.lblExistingPlayer1 = new System.Windows.Forms.Label();
            this.lblExistingPlayer2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnToMainForm
            // 
            this.btnReturnToMainForm.Location = new System.Drawing.Point(117, 205);
            this.btnReturnToMainForm.Name = "btnReturnToMainForm";
            this.btnReturnToMainForm.Size = new System.Drawing.Size(70, 23);
            this.btnReturnToMainForm.TabIndex = 15;
            this.btnReturnToMainForm.Text = "Alkuun";
            this.btnReturnToMainForm.UseVisualStyleBackColor = true;
            this.btnReturnToMainForm.Click += new System.EventHandler(this.btnReturnToMainForm_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(13, 205);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 13;
            this.btnStartGame.Text = "Aloita peli!";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblChooseExsitingPlayerInPvE
            // 
            this.lblChooseExsitingPlayerInPvE.AutoSize = true;
            this.lblChooseExsitingPlayerInPvE.Location = new System.Drawing.Point(12, 137);
            this.lblChooseExsitingPlayerInPvE.Name = "lblChooseExsitingPlayerInPvE";
            this.lblChooseExsitingPlayerInPvE.Size = new System.Drawing.Size(148, 13);
            this.lblChooseExsitingPlayerInPvE.TabIndex = 12;
            this.lblChooseExsitingPlayerInPvE.Text = "Valitse olemassaoleva pelaaja";
            // 
            // lblPvPFormCreateNewPlayer
            // 
            this.lblPvPFormCreateNewPlayer.AutoSize = true;
            this.lblPvPFormCreateNewPlayer.Location = new System.Drawing.Point(12, 76);
            this.lblPvPFormCreateNewPlayer.Name = "lblPvPFormCreateNewPlayer";
            this.lblPvPFormCreateNewPlayer.Size = new System.Drawing.Size(84, 13);
            this.lblPvPFormCreateNewPlayer.TabIndex = 11;
            this.lblPvPFormCreateNewPlayer.Text = "Luo uusi pelaaja";
            // 
            // btnCreateNewPlayer
            // 
            this.btnCreateNewPlayer.Location = new System.Drawing.Point(15, 92);
            this.btnCreateNewPlayer.Name = "btnCreateNewPlayer";
            this.btnCreateNewPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNewPlayer.TabIndex = 10;
            this.btnCreateNewPlayer.Text = "Uusi";
            this.btnCreateNewPlayer.UseVisualStyleBackColor = true;
            this.btnCreateNewPlayer.Click += new System.EventHandler(this.btnCreateNewPlayer_Click);
            // 
            // lblPvPFormTopic
            // 
            this.lblPvPFormTopic.AutoSize = true;
            this.lblPvPFormTopic.Location = new System.Drawing.Point(12, 35);
            this.lblPvPFormTopic.Name = "lblPvPFormTopic";
            this.lblPvPFormTopic.Size = new System.Drawing.Size(292, 13);
            this.lblPvPFormTopic.TabIndex = 8;
            this.lblPvPFormTopic.Text = "Sinä vs. toinen pelaaja!! Kumpi onkaan parempi pelaamaan?";
            // 
            // lstbPlayerList
            // 
            this.lstbPlayerList.FormattingEnabled = true;
            this.lstbPlayerList.Location = new System.Drawing.Point(174, 84);
            this.lstbPlayerList.Name = "lstbPlayerList";
            this.lstbPlayerList.Size = new System.Drawing.Size(120, 108);
            this.lstbPlayerList.TabIndex = 17;
            this.lstbPlayerList.SelectedIndexChanged += new System.EventHandler(this.lstbPlayerList_SelectedIndexChanged);
            // 
            // lstbPlayerList2
            // 
            this.lstbPlayerList2.FormattingEnabled = true;
            this.lstbPlayerList2.Location = new System.Drawing.Point(333, 84);
            this.lstbPlayerList2.Name = "lstbPlayerList2";
            this.lstbPlayerList2.Size = new System.Drawing.Size(120, 108);
            this.lstbPlayerList2.TabIndex = 19;
            this.lstbPlayerList2.SelectedIndexChanged += new System.EventHandler(this.lstbPlayerList2_SelectedIndexChanged);
            // 
            // lblExistingPlayer1
            // 
            this.lblExistingPlayer1.AutoSize = true;
            this.lblExistingPlayer1.Location = new System.Drawing.Point(171, 68);
            this.lblExistingPlayer1.Name = "lblExistingPlayer1";
            this.lblExistingPlayer1.Size = new System.Drawing.Size(51, 13);
            this.lblExistingPlayer1.TabIndex = 20;
            this.lblExistingPlayer1.Text = "Pelaaja 1";
            // 
            // lblExistingPlayer2
            // 
            this.lblExistingPlayer2.AutoSize = true;
            this.lblExistingPlayer2.Location = new System.Drawing.Point(330, 68);
            this.lblExistingPlayer2.Name = "lblExistingPlayer2";
            this.lblExistingPlayer2.Size = new System.Drawing.Size(51, 13);
            this.lblExistingPlayer2.TabIndex = 21;
            this.lblExistingPlayer2.Text = "Pelaaja 2";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(216, 207);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Sulje";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnMainClose_Click);
            // 
            // PvPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblExistingPlayer2);
            this.Controls.Add(this.lblExistingPlayer1);
            this.Controls.Add(this.lstbPlayerList2);
            this.Controls.Add(this.lstbPlayerList);
            this.Controls.Add(this.btnReturnToMainForm);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblChooseExsitingPlayerInPvE);
            this.Controls.Add(this.lblPvPFormCreateNewPlayer);
            this.Controls.Add(this.btnCreateNewPlayer);
            this.Controls.Add(this.lblPvPFormTopic);
            this.Name = "PvPForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnToMainForm;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblChooseExsitingPlayerInPvE;
        private System.Windows.Forms.Label lblPvPFormCreateNewPlayer;
        private System.Windows.Forms.Button btnCreateNewPlayer;
        private System.Windows.Forms.Label lblPvPFormTopic;
        private System.Windows.Forms.ListBox lstbPlayerList;
        private System.Windows.Forms.ListBox lstbPlayerList2;
        private System.Windows.Forms.Label lblExistingPlayer1;
        private System.Windows.Forms.Label lblExistingPlayer2;
        private System.Windows.Forms.Button btnClose;
    }
}