using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDiomes
{
    public partial class frmAnalytics : Form
    {
        public frmAnalytics()
        {
            InitializeComponent();
            
            this.PnlProjectLoader.Controls.Clear();
            frmProjectStart FrmProjectStart_Verbose = new frmProjectStart(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmProjectStart_Verbose.FormBorderStyle = FormBorderStyle.None;
            this.PnlProjectLoader.Controls.Add(FrmProjectStart_Verbose);
            FrmProjectStart_Verbose.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
