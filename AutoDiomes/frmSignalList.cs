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
        readonly frmAnalytics ths;
        public frmSignalList(frmAnalytics frm)
        {
            InitializeComponent();
            ths = frm;
            Globals.lastFrame = "frmSignalList";
            lblProject_Name.Text = Globals.project.name;
            lblProject_Phase.Text = Globals.project.phase;
            lblProject_SignalNumber.Text = ConvertLinearToString(Globals.project.number_signal);
        }

        private void frame_signaladd()
        {
            ths.PnlProjectLoader.Controls.Clear();
            frmSignalAdd frmSignalAdd_Verbose = new frmSignalAdd(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSignalAdd_Verbose.FormBorderStyle = FormBorderStyle.None;
            ths.PnlProjectLoader.Controls.Add(frmSignalAdd_Verbose);
            frmSignalAdd_Verbose.Show();
        }

        private void frame_projectproperties()
        {
            ths.PnlProjectLoader.Controls.Clear();
            frmProjectProperties FrmProjectProperties_Verbose = new frmProjectProperties(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmProjectProperties_Verbose.FormBorderStyle = FormBorderStyle.None;
            ths.PnlProjectLoader.Controls.Add(FrmProjectProperties_Verbose);
            FrmProjectProperties_Verbose.Show();
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

        private void label4_Click(object sender, EventArgs e)
        {
            frame_signaladd();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            frame_signaladd();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            frame_projectproperties();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frame_projectproperties();
        }
    }
}
