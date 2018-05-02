using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OHJ_II_HarjotustehtäväRistinolla
{
    public partial class PvEForm : Form
    {
        GameScores? playerOne = null;
        GameScores? playerTwo = null;
        List<GameScores> existingPlayers;
        List<GameScores> existingComputer;
       // private BindingList<GameScores> listboxStruct = new BindingList<GameScores>();
        public PvEForm()
        {
            InitializeComponent();
            PopulatePlayerSelection();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxPvE.SelectedIndex != -1)
            {
                playerOne = existingPlayers[lstBoxPvE.SelectedIndex];
            }
        }

        private void btnReturnToMainForm_Click(object sender, EventArgs e)
        {
            Close();
            MainForm openMain = new MainForm();
            openMain.Show();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            string exists = MainForm.savePathComputerPlayerInfo;
           //List<GameScores> existingComputer = null;
            if (!File.Exists(exists))
            {
                existingComputer = new List<GameScores>();
                Person person = new Person();
                GameScores personIASGameScore = new GameScores();
                person.firstName = "Tietokone";
                person.lastName = "";
                person.dateOfBirth = DateTime.Now;
                person.Id = Guid.NewGuid();
                personIASGameScore.personScores = person;
                personIASGameScore.computerPlayer = true;
                //player = this.txtNewPlayerFirstName.Text + " " + txtNewPlayerLastName.Text;

                //var existingPlayers = GameScores.DeserializeList(MainForm.savePathComputerPlayerInfo);
                existingComputer.Add(personIASGameScore);
                //serialize the struct information and save to a .dat file, and then close the form         
                GameScores.Serialize(existingComputer, MainForm.savePathComputerPlayerInfo);
                
               
            }
            else
            {
                existingComputer = GameScores.DeserializeList(MainForm.savePathComputerPlayerInfo);
            }

            DrawForm newDraw = new DrawForm();
            //tells DrawForm that player chose to play against computer.
            newDraw.computerplayer = true;
           // GameScores? playerTwo = null;
            if (!playerOne.HasValue)
            {
                MessageBox.Show("Valitse pelaaja!");
                return;
            }
            playerTwo = existingComputer[0];
            newDraw.playerOne = this.playerOne.Value;
            newDraw.playerTwo = playerTwo.Value;
            
            newDraw.Show();
            this.Close();

        }
        private void PopulatePlayerSelection()
        {
            string savePath = MainForm.savePathPlayerInfo;
            existingPlayers = GameScores.DeserializeList(savePath);
            lstBoxPvE.Items.Clear();
            foreach (var item in existingPlayers)
            {
                lstBoxPvE.Items.Add(item.personScores.Displayname);
               
            }

        }

        private void PvEForm_Load(object sender, EventArgs e)
        {

        }
    }
}
