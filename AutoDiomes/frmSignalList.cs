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
    public partial class frmSignalList : Form
    {
        frmAnalytics ths;
        public frmSignalList(frmAnalytics frm)
        {
            InitializeComponent();
            ths = frm;
            Globals.lastFrame = "frmSignalList";
        }

        private void frame_signaladd()
        {
            ths.PnlProjectLoader.Controls.Clear();
            frmSignalAdd frmSignalAdd_Verbose = new frmSignalAdd(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSignalAdd_Verbose.FormBorderStyle = FormBorderStyle.None;
            ths.PnlProjectLoader.Controls.Add(frmSignalAdd_Verbose);
            frmSignalAdd_Verbose.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frame_signaladd();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            frame_signaladd();
        }
    }
}
