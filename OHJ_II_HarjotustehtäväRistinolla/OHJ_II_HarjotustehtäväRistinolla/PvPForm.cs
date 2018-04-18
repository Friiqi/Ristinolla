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

        private BindingList<PersonInfoAndScore.GameScores> lstBind = new BindingList<PersonInfoAndScore.GameScores>();
        public PvPForm()
        {
            
            InitializeComponent();
            // the code under here is for trying to get listbox/combobox to display something other than the filepath and filename for the stored .dat files, work in progress, maybe need deserialization first applied?
                        this.cmbPvPForm.ValueMember = "Id";
                       this.cmbPvPForm.DisplayMember = "Displayname";
                        this.cmbPvPForm.DataSource = this.lstBind;

            string[] files = System.IO.Directory.GetFiles(@"C:\temp\savedfiles");
            this.listBox1.DisplayMember = "Displayname";
            this.listBox1.ValueMember = "Id";
            listBox1.Items.AddRange(files);

           
            this.listBox1.DataSource = this.lstBind;
   
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

            this.Close();
            DrawForm newDraw = new DrawForm();
            newDraw.Show();
        }
    }
}
