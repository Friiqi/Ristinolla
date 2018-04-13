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
            this.txtNewPlayerFirstName.Text = this.person.firstName;
            this.txtNewPlayerLastName.Text = this.person.lastName;
            this.dtpickNewPlayerDateOfBirth.Value = this.person.dateOfBirth;
          
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = @"c:\temp\";
            saveFileDialog1.Filter = "rtf files (*.rtf)|*.rtf";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            FileStream fs = new FileStream("DataFile.dat", FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
           
            formatter.Serialize(fs, TÄHÄN);
            
        }
    }
}
