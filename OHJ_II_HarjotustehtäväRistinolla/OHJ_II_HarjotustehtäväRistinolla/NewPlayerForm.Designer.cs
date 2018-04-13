namespace OHJ_II_HarjotustehtäväRistinolla
{
    partial class NewPlayerForm
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
            this.lblNewPlayerFirstName = new System.Windows.Forms.Label();
            this.lblNewPlayerLastName = new System.Windows.Forms.Label();
            this.lblNewPlayerDateOfBirth = new System.Windows.Forms.Label();
            this.btnNewPlayerEmpty = new System.Windows.Forms.Button();
            this.btnNewPlayerSaveInfo = new System.Windows.Forms.Button();
            this.btnNewPlayerReturnToMainForm = new System.Windows.Forms.Button();
            this.txtNewPlayerFirstName = new System.Windows.Forms.TextBox();
            this.txtNewPlayerLastName = new System.Windows.Forms.TextBox();
            this.dtpickNewPlayerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnBackFromNewPlayerForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewPlayerFirstName
            // 
            this.lblNewPlayerFirstName.AutoSize = true;
            this.lblNewPlayerFirstName.Location = new System.Drawing.Point(29, 66);
            this.lblNewPlayerFirstName.Name = "lblNewPlayerFirstName";
            this.lblNewPlayerFirstName.Size = new System.Drawing.Size(41, 13);
            this.lblNewPlayerFirstName.TabIndex = 1;
            this.lblNewPlayerFirstName.Text = "Etunimi";
            // 
            // lblNewPlayerLastName
            // 
            this.lblNewPlayerLastName.AutoSize = true;
            this.lblNewPlayerLastName.Location = new System.Drawing.Point(164, 66);
            this.lblNewPlayerLastName.Name = "lblNewPlayerLastName";
            this.lblNewPlayerLastName.Size = new System.Drawing.Size(50, 13);
            this.lblNewPlayerLastName.TabIndex = 2;
            this.lblNewPlayerLastName.Text = "Sukunimi";
            // 
            // lblNewPlayerDateOfBirth
            // 
            this.lblNewPlayerDateOfBirth.AutoSize = true;
            this.lblNewPlayerDateOfBirth.Location = new System.Drawing.Point(337, 66);
            this.lblNewPlayerDateOfBirth.Name = "lblNewPlayerDateOfBirth";
            this.lblNewPlayerDateOfBirth.Size = new System.Drawing.Size(67, 13);
            this.lblNewPlayerDateOfBirth.TabIndex = 3;
            this.lblNewPlayerDateOfBirth.Text = "Syntymäaika";
            // 
            // btnNewPlayerEmpty
            // 
            this.btnNewPlayerEmpty.Location = new System.Drawing.Point(32, 155);
            this.btnNewPlayerEmpty.Name = "btnNewPlayerEmpty";
            this.btnNewPlayerEmpty.Size = new System.Drawing.Size(75, 23);
            this.btnNewPlayerEmpty.TabIndex = 4;
            this.btnNewPlayerEmpty.Text = "Tyhjennä";
            this.btnNewPlayerEmpty.UseVisualStyleBackColor = true;
            this.btnNewPlayerEmpty.Click += new System.EventHandler(this.btnNewPlayerEmpty_Click);
            // 
            // btnNewPlayerSaveInfo
            // 
            this.btnNewPlayerSaveInfo.Location = new System.Drawing.Point(167, 155);
            this.btnNewPlayerSaveInfo.Name = "btnNewPlayerSaveInfo";
            this.btnNewPlayerSaveInfo.Size = new System.Drawing.Size(75, 23);
            this.btnNewPlayerSaveInfo.TabIndex = 5;
            this.btnNewPlayerSaveInfo.Text = "Tallenna";
            this.btnNewPlayerSaveInfo.UseVisualStyleBackColor = true;
            this.btnNewPlayerSaveInfo.Click += new System.EventHandler(this.btnNewPlayerSaveInfo_Click);
            // 
            // btnNewPlayerReturnToMainForm
            // 
            this.btnNewPlayerReturnToMainForm.Location = new System.Drawing.Point(409, 210);
            this.btnNewPlayerReturnToMainForm.Name = "btnNewPlayerReturnToMainForm";
            this.btnNewPlayerReturnToMainForm.Size = new System.Drawing.Size(98, 23);
            this.btnNewPlayerReturnToMainForm.TabIndex = 6;
            this.btnNewPlayerReturnToMainForm.Text = "Alkuvalikkoon";
            this.btnNewPlayerReturnToMainForm.UseVisualStyleBackColor = true;
            this.btnNewPlayerReturnToMainForm.Click += new System.EventHandler(this.btnNewPlayerReturnToMainForm_Click);
            // 
            // txtNewPlayerFirstName
            // 
            this.txtNewPlayerFirstName.Location = new System.Drawing.Point(32, 102);
            this.txtNewPlayerFirstName.Name = "txtNewPlayerFirstName";
            this.txtNewPlayerFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtNewPlayerFirstName.TabIndex = 7;
            // 
            // txtNewPlayerLastName
            // 
            this.txtNewPlayerLastName.Location = new System.Drawing.Point(167, 102);
            this.txtNewPlayerLastName.Name = "txtNewPlayerLastName";
            this.txtNewPlayerLastName.Size = new System.Drawing.Size(100, 20);
            this.txtNewPlayerLastName.TabIndex = 8;
            // 
            // dtpickNewPlayerDateOfBirth
            // 
            this.dtpickNewPlayerDateOfBirth.Location = new System.Drawing.Point(307, 102);
            this.dtpickNewPlayerDateOfBirth.Name = "dtpickNewPlayerDateOfBirth";
            this.dtpickNewPlayerDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpickNewPlayerDateOfBirth.TabIndex = 10;
            // 
            // btnBackFromNewPlayerForm
            // 
            this.btnBackFromNewPlayerForm.Location = new System.Drawing.Point(292, 210);
            this.btnBackFromNewPlayerForm.Name = "btnBackFromNewPlayerForm";
            this.btnBackFromNewPlayerForm.Size = new System.Drawing.Size(98, 23);
            this.btnBackFromNewPlayerForm.TabIndex = 11;
            this.btnBackFromNewPlayerForm.Text = "Takaisin";
            this.btnBackFromNewPlayerForm.UseVisualStyleBackColor = true;
            this.btnBackFromNewPlayerForm.Click += new System.EventHandler(this.btnBackFromNewPlayerForm_Click);
            // 
            // NewPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 245);
            this.Controls.Add(this.btnBackFromNewPlayerForm);
            this.Controls.Add(this.dtpickNewPlayerDateOfBirth);
            this.Controls.Add(this.txtNewPlayerLastName);
            this.Controls.Add(this.txtNewPlayerFirstName);
            this.Controls.Add(this.btnNewPlayerReturnToMainForm);
            this.Controls.Add(this.btnNewPlayerSaveInfo);
            this.Controls.Add(this.btnNewPlayerEmpty);
            this.Controls.Add(this.lblNewPlayerDateOfBirth);
            this.Controls.Add(this.lblNewPlayerLastName);
            this.Controls.Add(this.lblNewPlayerFirstName);
            this.Name = "NewPlayerForm";
            this.Text = "Uusi pelaaja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNewPlayerFirstName;
        private System.Windows.Forms.Label lblNewPlayerLastName;
        private System.Windows.Forms.Label lblNewPlayerDateOfBirth;
        private System.Windows.Forms.Button btnNewPlayerEmpty;
        private System.Windows.Forms.Button btnNewPlayerSaveInfo;
        private System.Windows.Forms.Button btnNewPlayerReturnToMainForm;
        private System.Windows.Forms.TextBox txtNewPlayerFirstName;
        private System.Windows.Forms.TextBox txtNewPlayerLastName;
        private System.Windows.Forms.DateTimePicker dtpickNewPlayerDateOfBirth;
        private System.Windows.Forms.Button btnBackFromNewPlayerForm;
    }
}