using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OHJ_II_HarjotustehtäväRistinolla
{
    public partial class NewPlayerForm : Form
    {
        
        public string player;
        Person person = new Person();
        GameScores personIASGameScore = new GameScores();
        public NewPlayerForm()
        {
            InitializeComponent();
         

        }

        private void btnNewPlayerReturnToMainForm_Click(object sender, EventArgs e)
        {

            Close();
            MainForm openMain = new MainForm();
            openMain.Show();
        }

        private void btnBackFromNewPlayerForm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
           

        }

        private void btnNewPlayerEmpty_Click(object sender, EventArgs e)
        {
            txtNewPlayerFirstName.Text = string.Empty;
            txtNewPlayerLastName.Text = string.Empty;
            dtpickNewPlayerDateOfBirth.ResetText();
   
        }

        public void btnNewPlayerSaveInfo_Click(object sender, EventArgs e)
        {
            //saves the personal information to PersonInfoAndScore.GameScores struct

            this.person.firstName = this.txtNewPlayerFirstName.Text;
            this.person.lastName = this.txtNewPlayerLastName.Text;
            this.person.dateOfBirth = this.dtpickNewPlayerDateOfBirth.Value.Date;
            this.person.Id = Guid.NewGuid();
            personIASGameScore.personScores = this.person;

            //player = this.txtNewPlayerFirstName.Text + " " + txtNewPlayerLastName.Text;
            string savePath = MainForm.savePathPlayerInfo;
            var existingPlayers = GameScores.DeserializeList(savePath);
            existingPlayers.Add(personIASGameScore);
            //serialize the struct information and save to a .dat file, and then close the form         
            GameScores.Serialize(existingPlayers, savePath);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
