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
    public partial class frmMesureType : Form
    {
        frmAnalytics ths;

        public frmMesureType(frmAnalytics frm)
        {
            ths = frm;
            InitializeComponent();
            Globals.lastFrame = "frmMesureType";
        }

        private void nextFrame()
        {
            ths.PnlProjectLoader.Controls.Clear();
            frmMesureTypeSelect frmMesureTypeSelect_Verbose = new frmMesureTypeSelect(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmMesureTypeSelect_Verbose.FormBorderStyle = FormBorderStyle.None;
            ths.PnlProjectLoader.Controls.Add(frmMesureTypeSelect_Verbose);
            frmMesureTypeSelect_Verbose.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            nextFrame();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            nextFrame();
        }
    }
}
