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
    public partial class MainForm : Form
    {
        public const string savePath = @"c:\temp\savedfiles";
        public const string savePathPlayerInfo = @"c:\temp\savedfiles\savedplayerinfo.json";
        public const string savePathComputerPlayerInfo = @"c:\temp\savedfiles\savedcomputerinfo.json";
        public MainForm()
        {
            InitializeComponent();
            //check if a folder for .dat file storing exists, if not, make one.
            bool exists = System.IO.Directory.Exists(savePath);
            if (!exists)
            {
                System.IO.Directory.CreateDirectory(savePath);
            }
        }

        private void btnMainFormChosePlayer_Click(object sender, EventArgs e)
        {
            PvPForm pvpFormi = new PvPForm();
            pvpFormi.Show();
            this.Hide();
        }

        private void btnMainFormChoseComputer_Click(object sender, EventArgs e)
        {
            PvEForm pveFormi = new PvEForm();
            pveFormi.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
