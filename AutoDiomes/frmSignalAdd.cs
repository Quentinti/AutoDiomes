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

        private bool txtBox_frequency_default = true;
        private bool txtBox_period_default = true;
        private bool txtBox_positive_duty_default = true;
        private bool txtBox_negative_duty_default = true;
        private bool txtBox_TON_default = true;
        private bool txtBox_TOFF_default = true;

        private bool txtBox_frequency_error = false;
        private bool txtBox_period_error = false;
        private bool txtBox_positive_duty_error = false;
        private bool txtBox_negative_duty_error = false;
        private bool txtBox_TON_error = false;
        private bool txtBox_TOFF_error = false;

        private string animate = "Right";
        private ushort animate_cpt = 10;


        public frmSignalAdd(frmAnalytics frm)
        {
            InitializeComponent();
            ths = frm;
            Globals.lastFrame = "frmSignalAdd";
            circularProgressBar1.Value = Globals.project.error_margin;
            circularProgressBar1.Text = ConvertLinearToString(Globals.project.error_margin) + @"%";
            cmbox_ONOFF.Text = "Non";

            this.timer1.Start();
        }

        private void Frame_SignalList(string button)
        {
            if (button == "Validate")
            {
                if (!Check_error())
                {
                    ths.PnlProjectLoader.Controls.Clear();
                    frmSignalList frmSignalList_Verbose = new frmSignalList(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    frmSignalList_Verbose.FormBorderStyle = FormBorderStyle.None;
                    ths.PnlProjectLoader.Controls.Add(frmSignalList_Verbose);
                    frmSignalList_Verbose.Show();
                    this.timer1.Stop();
                }
                else
                {
                    animate_cpt = 0;
                    LabelErrorAnimation(); //Update label of error if error is present
                }
            }
            else if(button == "Cancel")
            {
                ths.PnlProjectLoader.Controls.Clear();
                frmSignalList frmSignalList_Verbose = new frmSignalList(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmSignalList_Verbose.FormBorderStyle = FormBorderStyle.None;
                ths.PnlProjectLoader.Controls.Add(frmSignalList_Verbose);
                frmSignalList_Verbose.Show();
            }
        }

        private bool Check_error()
        {
            return true;
        }

        private void LabelErrorAnimation()
        {
            if (Check_error())
            {
                panel3.BackColor = Color.FromArgb(180, 30, 50);
                panel3.Cursor = System.Windows.Forms.Cursors.No;
                label10.Location = new Point(31, 16);
                label10.Text = "Erreur de saisie !       ";
                label10.Image = global::AutoDiomes.Properties.Resources.cross;
                label10.Cursor = System.Windows.Forms.Cursors.No;

            }
            else
            {
                panel3.BackColor = Color.FromArgb(20, 40, 60);
                panel3.Cursor = System.Windows.Forms.Cursors.Hand;
                label10.Location = new Point(24, 16);
                label10.Text = "Fin configuration        ";
                label10.Image = global::AutoDiomes.Properties.Resources.signal;
                label10.Cursor = System.Windows.Forms.Cursors.Hand;
            }
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
            if(txtBox_frequency_default)
            {
                txtBox_frequency.Clear();
                txtBox_frequency_default = false;
            }
            pnl_Frequency.BackColor = Color.FromArgb(50, 170, 50);
        }

        private void frequency_disable()
        {
            pnl_Frequency.BackColor = Color.FromArgb(180, 30, 50);
        }

        private void period_enable()
        {
            if (txtBox_period_default)
            {
                txtBox_period.Clear();
                txtBox_period_default = false;
            }
            pnl_Period.BackColor = Color.FromArgb(50, 170, 50);
        }

        private void period_disable()
        {
            pnl_Period.BackColor = Color.FromArgb(180, 30, 50);
        }

        private void positive_duty_enable()
        {
            if (txtBox_positive_duty_default)
            {
                txtBox_positive_duty.Clear();
                txtBox_positive_duty_default = false;
            }
            pnl_Positive_duty.BackColor = Color.FromArgb(50, 170, 50);
        }

        private void positive_duty_disable()
        {
            pnl_Positive_duty.BackColor = Color.FromArgb(180, 30, 50);
        }

        private void negative_duty_enable()
        {
            if (txtBox_negative_duty_default)
            {
                txtBox_negative_duty.Clear();
                txtBox_negative_duty_default = false;
            }
            pnl_Negative_duty.BackColor = Color.FromArgb(50, 170, 50);
        }

        private void negative_duty_disable()
        {
            pnl_Negative_duty.BackColor = Color.FromArgb(180, 30, 50);
        }

        private void TON_enable()
        {
            if (txtBox_TON_default)
            {
                txtBox_TON.Clear();
                txtBox_TON_default = false;
            }
            pnl_TON.BackColor = Color.FromArgb(50, 170, 50);
        }

        private void TON_disable()
        {
            pnl_TON.BackColor = Color.FromArgb(180, 30, 50);
        }

        private void TOFF_enable()
        {
            if (txtBox_TOFF_default)
            {
                txtBox_TOFF.Clear();
                txtBox_TOFF_default = false;
            }
            pnl_TOFF.BackColor = Color.FromArgb(50, 170, 50);
        }

        private void TOFF_disable()
        {
            pnl_TOFF.BackColor = Color.FromArgb(180, 30, 50);
        }

        private void NextState_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Panel5_Click(object sender, EventArgs e)
        {
            Frame_SignalList("Cancel");
        }

        private void Label11_Click(object sender, EventArgs e)
        {
            Frame_SignalList("Cancel");
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

        /* This part is action for enable or disable items of mesure.
         * On simple click, you enable the item
         * On double click, you disable the item
        */

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

        //Frequency Disable

        private void pnl_Frequency_DoubleClick(object sender, EventArgs e)
        {
            frequency_disable();
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            frequency_disable();
        }

        private void txtBox_frequency_DoubleClick(object sender, EventArgs e)
        {
            frequency_disable();
        }

        //Period Disable

        private void pnl_Period_DoubleClick(object sender, EventArgs e)
        {
            period_disable();
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            period_disable();
        }

        private void txtBox_period_DoubleClick(object sender, EventArgs e)
        {
            period_disable();
        }

        //Positive Duty Cycle Disable

        private void pnl_Positive_duty_DoubleClick(object sender, EventArgs e)
        {
            positive_duty_disable();
        }

        private void label5_DoubleClick(object sender, EventArgs e)
        {
            positive_duty_disable();
        }

        private void txtBox_positive_duty_DoubleClick(object sender, EventArgs e)
        {
            positive_duty_disable();
        }

        //Negative Duty Cycle Disable

        private void pnl_Negative_duty_DoubleClick(object sender, EventArgs e)
        {
            negative_duty_disable();
        }

        private void label6_DoubleClick(object sender, EventArgs e)
        {
            negative_duty_disable();
        }

        private void txtBox_negative_duty_DoubleClick(object sender, EventArgs e)
        {
            negative_duty_disable();
        }

        //TON Disable

        private void pnl_TON_DoubleClick(object sender, EventArgs e)
        {
            TON_disable();
        }

        private void label7_DoubleClick(object sender, EventArgs e)
        {
            TON_disable();
        }

        private void txtBox_TON_DoubleClick(object sender, EventArgs e)
        {
            TON_disable();
        }

        //TOFF Disable

        private void pnl_TOFF_DoubleClick(object sender, EventArgs e)
        {
            TOFF_disable();
        }

        private void label8_DoubleClick(object sender, EventArgs e)
        {
            TOFF_disable();
        }

        private void txtBox_TOFF_DoubleClick(object sender, EventArgs e)
        {
            TOFF_disable();
        }

        private void txtBox_frequency_Leave(object sender, EventArgs e)
        {
            if (UInt32.TryParse(txtBox_frequency.Text, out frequency)) //verify if the content is number and convert it to UINT16
            {
                if ((frequency >= 5) && (frequency <= 50000)) //verify if the number enter is a percent
                {
                    txtBox_frequency_error = false;
                    txtBox_frequency.BackColor = Color.FromArgb(74, 79, 99); //change the back color of text box
                    LabelErrorAnimation();
                }
                else
                {
                    txtBox_frequency.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                    txtBox_frequency.Text = "5 < valeur < 50 000"; //change the text of text box for indicate the error
                    txtBox_frequency_default = true; //Reset for clear after a new click
                    txtBox_frequency_error = true; //Set error to true
                    LabelErrorAnimation();
                }
            }
            else
            {
                txtBox_frequency.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_frequency.Text = "Pas de Hz ou autre caractères"; //change the text of text box for indicate the error
                txtBox_frequency_default = true; //Reset for clear after a new click
                txtBox_frequency_error = true; //Set error to true
                LabelErrorAnimation();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (label10.Text == "Erreur de saisie !       ")
            {
                if (animate_cpt == 6)
                {
                    panel3.Location = new Point(516, 60);
                }
                if (animate_cpt < 6)
                {

                    if (animate == "Right")
                    {
                        panel3.Location = new Point(panel3.Location.X + 6, panel3.Location.Y);
                    }
                    else if (animate == "Left")
                    {
                        panel3.Location = new Point(panel3.Location.X - 6, panel3.Location.Y);
                    }

                    if (panel3.Location.X > 530)
                    {
                        animate = "Left";
                        animate_cpt++;
                    }
                    else if (panel3.Location.X < 500)
                    {
                        animate = "Right";
                        animate_cpt++;
                    }
                }
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Frame_SignalList("Validate");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Frame_SignalList("Validate");
        }
    }
}
