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
 
        List<GameScores> existingPlayers;
        public PvPForm()
        {
            InitializeComponent();
            PopulatePlayerSelection();
        }

        private void btnReturnToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm openMain = new MainForm();
            openMain.Show();
        }

        public void btnCreateNewPlayer_Click(object sender, EventArgs e)
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

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (!playerOne.HasValue || !playerTwo.HasValue && (!playerOne.Equals(playerTwo)))
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
    }
}
