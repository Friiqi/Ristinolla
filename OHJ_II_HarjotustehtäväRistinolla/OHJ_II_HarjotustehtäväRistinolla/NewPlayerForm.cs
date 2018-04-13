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
    public partial class NewPlayerForm : Form
    {
       
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
    }
}
