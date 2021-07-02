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
    public partial class frmSignalAdd : Form
    {
        frmAnalytics ths;
        public frmSignalAdd(frmAnalytics frm)
        {
            InitializeComponent();
            ths = frm;
            Globals.lastFrame = "frmSignalAdd";
            circularProgressBar1.Value = Globals.project.error_margin;
            circularProgressBar1.Text = ConvertLinearToString(Globals.project.error_margin) + @"%";
        }

        private void frame_projectproperties()
        {
            ths.PnlProjectLoader.Controls.Clear();
            frmSignalList frmSignalList_Verbose = new frmSignalList(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSignalList_Verbose.FormBorderStyle = FormBorderStyle.None;
            ths.PnlProjectLoader.Controls.Add(frmSignalList_Verbose);
            frmSignalList_Verbose.Show();
        }

        private static string ConvertLinearToString(ushort data) //Convert UINT16 to string
        {
            var n = GetBitRange(data, 16, 5);
            var y = GetBitRange(data, 21, 11);
            var value = y * Math.Pow(2, n);
            return value.ToString();
        }

        private static int GetBitRange(int data, int offset, int count)
        {
            return data << offset >> (32 - count);
        }

        private void NextState_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            frame_projectproperties();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            frame_projectproperties();
        }
    }
}
