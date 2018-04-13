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
        PersonInfoAndScore.Person person = new PersonInfoAndScore.Person();
        PersonInfoAndScore.GameScores personIASGameScore = new PersonInfoAndScore.GameScores();
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
            this.person.firstName = this.txtNewPlayerFirstName.Text;
            this.person.lastName = this.txtNewPlayerLastName.Text;
            this.person.dateOfBirth = this.dtpickNewPlayerDateOfBirth.Value.Date;
            personIASGameScore.personScores = this.person;
            string player = this.txtNewPlayerFirstName.Text + txtNewPlayerLastName.Text;
            // serialisoidaan tiedot binäärimuotoon
            IFormatter formatter = new BinaryFormatter();
            Stream streamSave = new FileStream($"c:\\temp\\{player}.dat", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(streamSave, this.personIASGameScore);
            streamSave.Close();

        }
    }
}
