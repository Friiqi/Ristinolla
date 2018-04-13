namespace OHJ_II_HarjotustehtäväRistinolla
{
    partial class PvEForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCreateNerPlayer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChooseExsitingPlayerInPvE = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReturnToMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinä vastaan tietokone! Kumpi onkaan parempi pelaamaan?";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 17);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnCreateNerPlayer
            // 
            this.btnCreateNerPlayer.Location = new System.Drawing.Point(34, 83);
            this.btnCreateNerPlayer.Name = "btnCreateNerPlayer";
            this.btnCreateNerPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNerPlayer.TabIndex = 2;
            this.btnCreateNerPlayer.Text = "Uusi";
            this.btnCreateNerPlayer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Luo uusi pelaaja";
            // 
            // lblChooseExsitingPlayerInPvE
            // 
            this.lblChooseExsitingPlayerInPvE.AutoSize = true;
            this.lblChooseExsitingPlayerInPvE.Location = new System.Drawing.Point(31, 128);
            this.lblChooseExsitingPlayerInPvE.Name = "lblChooseExsitingPlayerInPvE";
            this.lblChooseExsitingPlayerInPvE.Size = new System.Drawing.Size(148, 13);
            this.lblChooseExsitingPlayerInPvE.TabIndex = 4;
            this.lblChooseExsitingPlayerInPvE.Text = "Valitse olemassaoleva pelaaja";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(32, 196);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 5;
            this.btnStartGame.Text = "Aloita peli!";
            this.btnStartGame.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnReturnToMainForm
            // 
            this.btnReturnToMainForm.Location = new System.Drawing.Point(135, 196);
            this.btnReturnToMainForm.Name = "btnReturnToMainForm";
            this.btnReturnToMainForm.Size = new System.Drawing.Size(70, 23);
            this.btnReturnToMainForm.TabIndex = 7;
            this.btnReturnToMainForm.Text = "Alkuun";
            this.btnReturnToMainForm.UseVisualStyleBackColor = true;
            this.btnReturnToMainForm.Click += new System.EventHandler(this.btnReturnToMainForm_Click);
            // 
            // PvEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturnToMainForm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblChooseExsitingPlayerInPvE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreateNerPlayer);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "PvEForm";
            this.Text = "Pelaaja vs. tietokone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCreateNerPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChooseExsitingPlayerInPvE;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReturnToMainForm;
    }
}