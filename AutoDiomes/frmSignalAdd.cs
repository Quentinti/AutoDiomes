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
        readonly frmAnalytics ths;

        public string ON_OFF;
        public UInt32 frequency;
        public UInt32 period;
        public UInt16 duty_positive;
        public UInt16 duty_negative;
        public UInt32 TON;
        public UInt32 TOFF;

        public frmSignalAdd(frmAnalytics frm)
        {
            InitializeComponent();
            ths = frm;
            Globals.lastFrame = "frmSignalAdd";
            circularProgressBar1.Value = Globals.project.error_margin;
            circularProgressBar1.Text = ConvertLinearToString(Globals.project.error_margin) + @"%";
            cmbox_ONOFF.Text = "Non";
        }

        private void Frame_projectproperties()
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

        private void frequency_enable()
        {

        }

        private void period_enable()
        {

        }

        private void positive_duty_enable()
        {

        }

        private void negative_duty_enable()
        {

        }

        private void TON_enable()
        {

        }

        private void TOFF_enable()
        {

        }

        private void NextState_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Panel5_Click(object sender, EventArgs e)
        {
            Frame_projectproperties();
        }

        private void Label11_Click(object sender, EventArgs e)
        {
            Frame_projectproperties();
        }

        private void cmbox_ONOFF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbox_ONOFF.Text == "ON")
            {
                ON_OFF = "ON";
                panel1.Hide();
                panel4.Location = new Point(37, 222);
            }
            else if(cmbox_ONOFF.Text == "OFF")
            {
                ON_OFF = "OFF";
                panel1.Hide();
                panel4.Location = new Point(37, 222);
            }
            else if(cmbox_ONOFF.Text == "Non"){
                ON_OFF = "Non";
                panel1.Show();
                panel4.Location = new Point(18, 60);
            }
            
        }

        //Frequency enable

        private void pnl_Frequency_Click(object sender, EventArgs e)
        {
            frequency_enable();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frequency_enable();
        }

        private void txtBox_frequency_Click(object sender, EventArgs e)
        {
            frequency_enable();
        }

        //Period enable

        private void txtBox_period_Click(object sender, EventArgs e)
        {
            period_enable();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            period_enable();
        }

        private void pnl_Period_Click(object sender, EventArgs e)
        {
            period_enable();
        }

        //Positive Duty Cycle enable

        private void label5_Click(object sender, EventArgs e)
        {
            positive_duty_enable();
        }

        private void txtBox_positive_duty_Click(object sender, EventArgs e)
        {
            positive_duty_enable();
        }

        private void pnl_Positive_duty_Click(object sender, EventArgs e)
        {
            positive_duty_enable();
        }

        //Negative Duty Cycle enable

        private void pnl_Negative_duty_Click(object sender, EventArgs e)
        {
            negative_duty_enable();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            negative_duty_enable();
        }

        private void txtBox_negative_duty_Click(object sender, EventArgs e)
        {
            negative_duty_enable();
        }

        //TON enable

        private void pnl_TON_Click(object sender, EventArgs e)
        {
            TON_enable();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            TON_enable();
        }

        private void txtBox_TON_Click(object sender, EventArgs e)
        {
            TON_enable();
        }

        //TOFF enable

        private void txtBox_TOFF_Click(object sender, EventArgs e)
        {
            TOFF_enable();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            TOFF_enable();
        }

        private void pnl_TOFF_Click(object sender, EventArgs e)
        {
            TOFF_enable();
        }
    }
}
