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
    public partial class frmProjectStart : Form
    {
        frmAnalytics ths;
        public frmProjectStart(frmAnalytics frm)
        {
            InitializeComponent();
            ths = frm;
            Globals.lastFrame = "frmProjectStart";
        }

        private void frame_projectproperties()
        {
            ths.PnlProjectLoader.Controls.Clear();
            frmProjectProperties FrmProjectProperties_Verbose = new frmProjectProperties(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmProjectProperties_Verbose.FormBorderStyle = FormBorderStyle.None;
            ths.PnlProjectLoader.Controls.Add(FrmProjectProperties_Verbose);
            FrmProjectProperties_Verbose.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            frame_projectproperties();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frame_projectproperties();
        }
    }
}
