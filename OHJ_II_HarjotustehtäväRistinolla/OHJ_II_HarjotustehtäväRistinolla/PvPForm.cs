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
        
        public PvPForm()
        {
            InitializeComponent();
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
    }
}
