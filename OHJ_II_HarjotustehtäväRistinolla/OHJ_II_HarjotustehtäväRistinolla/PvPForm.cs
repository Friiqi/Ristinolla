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
            
                        this.cmbPvPForm.ValueMember = "Id";
                       this.cmbPvPForm.DisplayMember = "Displayname";
                        this.cmbPvPForm.DataSource = this.lstBind;

                        
            
            bool exists = System.IO.Directory.Exists(@"c:\temp\savedfiles");
            if (!exists)
            {
                System.IO.Directory.CreateDirectory(@"c:\temp\savedfiles");
            }

            string[] files = System.IO.Directory.GetFiles(@"C:\temp\savedfiles");
             
           listBox1.Items.AddRange(files);
                
        

          
           
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
    }
}
