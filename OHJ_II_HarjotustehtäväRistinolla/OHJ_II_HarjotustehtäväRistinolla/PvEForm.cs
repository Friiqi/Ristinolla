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
    public partial class PvEForm : Form
    {
        private BindingList<PersonInfoAndScore> listboxStruct = new BindingList<PersonInfoAndScore>();
        public PvEForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstBoxPvE.DisplayMember = "DisplayName";
            this.lstBoxPvE.ValueMember = "Id";
            this.lstBoxPvE.DataSource = this.listboxStruct;
        }

        private void btnReturnToMainForm_Click(object sender, EventArgs e)
        {
            Close();
            MainForm openMain = new MainForm();
            openMain.Show();
        }
    }
}
