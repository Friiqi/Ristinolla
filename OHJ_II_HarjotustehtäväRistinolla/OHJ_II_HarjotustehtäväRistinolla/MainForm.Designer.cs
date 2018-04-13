namespace OHJ_II_HarjotustehtäväRistinolla
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnMainFormChosePlayer = new System.Windows.Forms.Button();
            this.btnMainFormChoseComputer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tervetuloa Reinon Ristinollaan!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Haluatko pelata pelaajaa vai tietokonetta vastaan?";
            // 
            // btnMainFormChosePlayer
            // 
            this.btnMainFormChosePlayer.Location = new System.Drawing.Point(55, 94);
            this.btnMainFormChosePlayer.Name = "btnMainFormChosePlayer";
            this.btnMainFormChosePlayer.Size = new System.Drawing.Size(75, 23);
            this.btnMainFormChosePlayer.TabIndex = 2;
            this.btnMainFormChosePlayer.Text = "Pelaajaa";
            this.btnMainFormChosePlayer.UseVisualStyleBackColor = true;
            this.btnMainFormChosePlayer.Click += new System.EventHandler(this.btnMainFormChosePlayer_Click);
            // 
            // btnMainFormChoseComputer
            // 
            this.btnMainFormChoseComputer.Location = new System.Drawing.Point(150, 94);
            this.btnMainFormChoseComputer.Name = "btnMainFormChoseComputer";
            this.btnMainFormChoseComputer.Size = new System.Drawing.Size(75, 23);
            this.btnMainFormChoseComputer.TabIndex = 3;
            this.btnMainFormChoseComputer.Text = "Tietokonetta";
            this.btnMainFormChoseComputer.UseVisualStyleBackColor = true;
            this.btnMainFormChoseComputer.Click += new System.EventHandler(this.btnMainFormChoseComputer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 155);
            this.Controls.Add(this.btnMainFormChoseComputer);
            this.Controls.Add(this.btnMainFormChosePlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Päävalikko";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMainFormChosePlayer;
        private System.Windows.Forms.Button btnMainFormChoseComputer;
    }
}

