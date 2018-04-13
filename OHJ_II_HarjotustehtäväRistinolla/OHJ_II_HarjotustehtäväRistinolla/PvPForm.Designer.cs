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
            this.button2 = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblChooseExsitingPlayerInPvE = new System.Windows.Forms.Label();
            this.lblPvPFormCreateNewPlayer = new System.Windows.Forms.Label();
            this.btnCreateNerPlayer = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblPvPFormTopic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturnToMainForm
            // 
            this.btnReturnToMainForm.Location = new System.Drawing.Point(116, 205);
            this.btnReturnToMainForm.Name = "btnReturnToMainForm";
            this.btnReturnToMainForm.Size = new System.Drawing.Size(70, 23);
            this.btnReturnToMainForm.TabIndex = 15;
            this.btnReturnToMainForm.Text = "Alkuun";
            this.btnReturnToMainForm.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(13, 205);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 13;
            this.btnStartGame.Text = "Aloita peli!";
            this.btnStartGame.UseVisualStyleBackColor = true;
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
            // btnCreateNerPlayer
            // 
            this.btnCreateNerPlayer.Location = new System.Drawing.Point(15, 92);
            this.btnCreateNerPlayer.Name = "btnCreateNerPlayer";
            this.btnCreateNerPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNerPlayer.TabIndex = 10;
            this.btnCreateNerPlayer.Text = "Uusi";
            this.btnCreateNerPlayer.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 17);
            this.listBox1.TabIndex = 9;
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
            // PvPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturnToMainForm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblChooseExsitingPlayerInPvE);
            this.Controls.Add(this.lblPvPFormCreateNewPlayer);
            this.Controls.Add(this.btnCreateNerPlayer);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblPvPFormTopic);
            this.Name = "PvPForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnToMainForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblChooseExsitingPlayerInPvE;
        private System.Windows.Forms.Label lblPvPFormCreateNewPlayer;
        private System.Windows.Forms.Button btnCreateNerPlayer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblPvPFormTopic;
    }
}