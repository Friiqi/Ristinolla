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
       // private BindingList<GameScores> lstBind = new BindingList<GameScores>();
        public PvPForm()
        {
            
            InitializeComponent();
            /*
            // the code under here is for trying to get listbox/combobox to display something other than the filepath and filename for the stored .json file.
                        this.cmbPvPForm.ValueMember = "Id";
                       this.cmbPvPForm.DisplayMember = "Displayname";
                     //   this.cmbPvPForm.DataSource = this.lstBind;
            string savePath = @"c:\temp\savedfiles\savedplayerinfo.json";
            var existingPlayers = GameScores.DeserializeList(savePath);


            listBox1.DataSource = existingPlayers;
            listBox1.DisplayMember = "Displayname";
            //this.listBox1.ValueMember = "Id";

          // this.listBox1.DataSource = this.lstBind;
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
            newPlayer.Show();
        }

 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add here the part where you access drawform-forms computerplayer bool and set it to true!
            this.Close();
            DrawForm newDraw = new DrawForm();
            newDraw.Show();
        }
    }
}
