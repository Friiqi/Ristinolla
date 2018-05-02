using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OHJ_II_HarjotustehtäväRistinolla
{
    public partial class PvPForm : Form
    {
        //what to put here to be able to get the listbox populated?
        List<GameScores> existingPlayers;
        public PvPForm()
        {
            
            InitializeComponent();
            PopulatePlayerSelection();
            /*
            // the code under here is for trying to get listbox/combobox to display something other than the filepath and filename for the stored .json file.
                        this.cmbPvPForm.ValueMember = "Id";
                       this.cmbPvPForm.DisplayMember = "Displayname";
                     //   this.cmbPvPForm.DataSource = this.lstBind;
            string savePath = @"c:\temp\savedfiles\savedplayerinfo.json";
            var existingPlayers = GameScores.DeserializeList(savePath);

    */
        }

        private void btnReturnToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm openMain = new MainForm();
            openMain.Show();
        }

        public void btnCreateNerPlayer_Click(object sender, EventArgs e)
        {
           
            
            NewPlayerForm newPlayer = new NewPlayerForm();
            if (newPlayer.ShowDialog() == DialogResult.OK)
            {
                PopulatePlayerSelection();
            }
        }
        private void PopulatePlayerSelection()
        {
            string savePath = MainForm.savePathPlayerInfo;
           existingPlayers = GameScores.DeserializeList(savePath);
            lstbPlayerList.Items.Clear();
            lstbPlayerList2.Items.Clear();
            foreach (var item in existingPlayers)
            {
                lstbPlayerList.Items.Add(item.personScores.Displayname);
                lstbPlayerList2.Items.Add(item.personScores.Displayname);
            }
  
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add here the part where you access drawform-forms computerplayer bool and set it to true!

            if (!playerOne.HasValue || !playerTwo.HasValue)
            {
                MessageBox.Show("Valitse pelaajat!");
                return;
            }
            this.Close();
            DrawForm newDraw = new DrawForm();
            newDraw.playerOne = this.playerOne.Value;
            newDraw.playerTwo = this.playerTwo.Value;
            newDraw.Show();
        }

        GameScores? playerOne = null;
        GameScores? playerTwo = null;

        private void lstbPlayerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbPlayerList.SelectedIndex != -1)
            {
                playerOne = existingPlayers[lstbPlayerList.SelectedIndex];
            }
        }

        private void lstbPlayerList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbPlayerList2.SelectedIndex != -1)
            {
                playerTwo = existingPlayers[lstbPlayerList2.SelectedIndex];
            }
        }
    }
}
