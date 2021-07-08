using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace AutoDiomes
{
    public partial class frmSignalAdd : Form
    {
        readonly frmAnalytics ths;

        public string signal_name;
        public string ON_OFF;
        public UInt32 frequency;
        public double period;
        public UInt16 positive_duty;
        public UInt16 negative_duty;
        public double TON;
        public double TOFF;

        private bool frequency_mesure = false;
        private bool period_mesure = false;
        private bool positive_duty_mesure = false;
        private bool negative_duty_mesure = false;
        private bool TON_mesure = false;
        private bool TOFF_mesure = false;

        private bool txtBox_signal_name_default = true;
        private bool txtBox_frequency_default = true;
        private bool txtBox_period_default = true;
        private bool txtBox_positive_duty_default = true;
        private bool txtBox_negative_duty_default = true;
        private bool txtBox_TON_default = true;
        private bool txtBox_TOFF_default = true;

        private bool txtBox_signal_name_error = true;
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
                    Globals.signal[Globals.project.number_signal].AddSignal(signal_name, ON_OFF, frequency, period, positive_duty, negative_duty, TON, TOFF); //add a new signal

                    string file_path = @"C:\AutoDiomes\temp\" + Globals.project.config_name + @"\" + Globals.project.config_name + @"_signal#" 
                                        + Globals.signal[Globals.project.number_signal].signal_name + @".json"; 

                    if (System.IO.File.Exists(file_path))
                    {
                        System.IO.File.Delete(file_path);
                    }

                    string json = JsonConvert.SerializeObject(Globals.signal[Globals.project.number_signal], Formatting.Indented);
                    System.IO.File.WriteAllText(file_path, json);

                    ths.PnlProjectLoader.Controls.Clear();
                    frmSignalList frmSignalList_Verbose = new frmSignalList(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    frmSignalList_Verbose.FormBorderStyle = FormBorderStyle.None;
                    ths.PnlProjectLoader.Controls.Add(frmSignalList_Verbose);
                    frmSignalList_Verbose.Show();

                    this.timer1.Stop(); //stop timer 1
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
            if (cmbox_ONOFF.Text == "Non")
            {
                if (!frequency_mesure && !period_mesure && !positive_duty_mesure && !negative_duty_mesure && !TON_mesure && !TOFF_mesure)
                {
                    return true;
                }
                else if (txtBox_frequency_error || txtBox_period_error || txtBox_positive_duty_error
                    || txtBox_negative_duty_error || txtBox_TON_error || txtBox_TOFF_error || txtBox_signal_name_error)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(!txtBox_signal_name_error)
            {
                return false;
            }
            else
            {
                return true;
            }
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
            pnl_Frequency.BackColor = Color.FromArgb(50, 170, 50);
            frequency_mesure = true;
        }

        private void frequency_disable()
        {
            pnl_Frequency.BackColor = Color.FromArgb(180, 30, 50);
            txtBox_frequency.BackColor = Color.FromArgb(74, 79, 99);
            txtBox_frequency.Text = "5Hz min -50 000Hz max";
            txtBox_frequency_error = false;
            frequency_mesure = false;
        }

        private void period_enable()
        {
            pnl_Period.BackColor = Color.FromArgb(50, 170, 50);
            period_mesure = true;
        }

        private void period_disable()
        {
            pnl_Period.BackColor = Color.FromArgb(180, 30, 50);
            txtBox_period.BackColor = Color.FromArgb(74, 79, 99);
            txtBox_period.Text = "200ms - 0.02ms";
            txtBox_period_error = false;
            period_mesure = false;
        }

        private void positive_duty_enable()
        {
            pnl_Positive_duty.BackColor = Color.FromArgb(50, 170, 50);
            positive_duty_mesure = true;
        }

        private void positive_duty_disable()
        {
            pnl_Positive_duty.BackColor = Color.FromArgb(180, 30, 50);
            txtBox_positive_duty.BackColor = Color.FromArgb(74, 79, 99);
            txtBox_positive_duty.Text = "2 à 98%";
            txtBox_positive_duty_error = false;
            positive_duty_mesure = false;
            
        }

        private void negative_duty_enable()
        {
            pnl_Negative_duty.BackColor = Color.FromArgb(50, 170, 50);
            negative_duty_mesure = true;
        }

        private void negative_duty_disable()
        {
            pnl_Negative_duty.BackColor = Color.FromArgb(180, 30, 50);
            txtBox_negative_duty.BackColor = Color.FromArgb(74, 79, 99);
            txtBox_negative_duty.Text = "2 à 98%";
            negative_duty_mesure = false;
            txtBox_negative_duty_error = false;
        }

        private void TON_enable()
        {
            pnl_TON.BackColor = Color.FromArgb(50, 170, 50);
            TON_mesure = true;
        }

        private void TON_disable()
        {
            pnl_TON.BackColor = Color.FromArgb(180, 30, 50);
            txtBox_TON.BackColor = Color.FromArgb(74, 79, 99);
            txtBox_TON.Text = "0.004ms - 196ms";
            TON_mesure = false;
            txtBox_TON_error = false;
        }

        private void TOFF_enable()
        {
            pnl_TOFF.BackColor = Color.FromArgb(50, 170, 50);
            TOFF_mesure = true;
        }

        private void TOFF_disable()
        {
            pnl_TOFF.BackColor = Color.FromArgb(180, 30, 50);
            txtBox_TOFF.BackColor = Color.FromArgb(74, 79, 99);
            txtBox_TOFF.Text = "0.004ms - 196ms";
            TOFF_mesure = false;
            txtBox_TOFF_error = false;
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

        private void panel3_Click(object sender, EventArgs e)
        {
            Frame_SignalList("Validate");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Frame_SignalList("Validate");
        }

        private void cmbox_ONOFF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbox_ONOFF.Text == "ON")
            {
                ON_OFF = "ON";
                panel1.Hide();
                panel4.Location = new Point(37, 222);
                LabelErrorAnimation();
            }
            else if(cmbox_ONOFF.Text == "OFF")
            {
                ON_OFF = "OFF";
                panel1.Hide();
                panel4.Location = new Point(37, 222);
                LabelErrorAnimation();
            }
            else if(cmbox_ONOFF.Text == "Non"){
                ON_OFF = "Non";
                panel1.Show();
                panel4.Location = new Point(18, 60);
                LabelErrorAnimation();
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

        private void txtBox_signal_name_Click(object sender, EventArgs e)
        {
            if (txtBox_signal_name_default)
            {
                txtBox_signal_name.Clear();
                txtBox_signal_name_default = false;
                txtBox_signal_name.BackColor = Color.FromArgb(74, 79, 99);
            }
        }

        private void txtBox_frequency_Click(object sender, EventArgs e)
        {
            if (txtBox_frequency_default)
            {
                txtBox_frequency.Clear();
                txtBox_frequency_default = false;
                txtBox_frequency.BackColor = Color.FromArgb(74, 79, 99);
            }
            frequency_enable();
        }

        //Period enable

        private void txtBox_period_Click(object sender, EventArgs e)
        {
            if (txtBox_period_default)
            {
                txtBox_period.Clear();
                txtBox_period_default = false;
                txtBox_period.BackColor = Color.FromArgb(74, 79, 99);
            }  
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
            if (txtBox_positive_duty_default)
            {
                txtBox_positive_duty.Clear();
                txtBox_positive_duty_default = false;
                txtBox_positive_duty.BackColor = Color.FromArgb(74, 79, 99);
            }
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
            if (txtBox_negative_duty_default)
            {
                txtBox_negative_duty.Clear();
                txtBox_negative_duty_default = false;
                txtBox_negative_duty.BackColor = Color.FromArgb(74, 79, 99);
            }
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
            if (txtBox_TON_default)
            {
                txtBox_TON.Clear();
                txtBox_TON_default = false;
                txtBox_TON.BackColor = Color.FromArgb(74, 79, 99);
            }
            TON_enable();
        }

        //TOFF enable

        private void txtBox_TOFF_Click(object sender, EventArgs e)
        {
            if (txtBox_TOFF_default)
            {
                txtBox_TOFF.Clear();
                txtBox_TOFF_default = false;
                txtBox_TOFF.BackColor = Color.FromArgb(74, 79, 99);
            }
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

        private void txtBox_signal_name_Leave(object sender, EventArgs e)
        {
            if (txtBox_signal_name.Text == "")
            {
                txtBox_signal_name.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_signal_name.Text = "Le champ ne peut être vide !"; //change the text of text box for indicate the error
                txtBox_signal_name_default = true; //Reset for clear after a new click
                txtBox_signal_name_error = true; //Set error to true
                LabelErrorAnimation();
            }
            else if (txtBox_signal_name.Text.Length < 64) //verify if the content is bellow 60 carac
            {
                txtBox_signal_name_error = false;
                txtBox_signal_name.BackColor = Color.FromArgb(74, 79, 99); //change the back color of text box
                txtBox_signal_name.Text = signal_name;
                LabelErrorAnimation();
            }
            else
            {
                txtBox_signal_name.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_signal_name.Text = "Saisie trop longue ! < 64"; //change the text of text box for indicate the error
                txtBox_signal_name_default = true; //Reset for clear after a new click
                txtBox_signal_name_error = true; //Set error to true
                LabelErrorAnimation();
            }

        }

        private void txtBox_frequency_Leave(object sender, EventArgs e)
        {
            if (txtBox_frequency.Text == "")
            {
                txtBox_frequency.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_frequency.Text = "Le champ ne peut être vide !"; //change the text of text box for indicate the error
                txtBox_frequency_default = true; //Reset for clear after a new click
                txtBox_frequency_error = true; //Set error to true
                LabelErrorAnimation();
            }
            else if (UInt32.TryParse(txtBox_frequency.Text, out frequency)) //verify if the content is number and convert it to UINT32
            {
                if ((frequency >= 5) && (frequency <= 50000)) //verify if the number enter is between the plage
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

        private void txtBox_period_Leave(object sender, EventArgs e)
        {
            if (txtBox_period.Text == "")
            {
                txtBox_period.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_period.Text = "Le champ ne peut être vide !"; //change the text of text box for indicate the error
                txtBox_period_default = true; //Reset for clear after a new click
                txtBox_period_error = true; //Set error to true
                LabelErrorAnimation();
            }
            else if (double.TryParse(txtBox_period.Text, out period)) //verify if the content is number and convert it to double
            {
                if ((period >= 0.02) && (period <= 200)) //verify if the number enter is between the plage
                {
                    txtBox_period_error = false;
                    txtBox_period.BackColor = Color.FromArgb(74, 79, 99); //change the back color of text box
                    LabelErrorAnimation();
                }
                else
                {
                    txtBox_period.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                    txtBox_period.Text = "0,02 < valeur < 200"; //change the text of text box for indicate the error
                    txtBox_period_default = true; //Reset for clear after a new click
                    txtBox_period_error = true; //Set error to true
                    LabelErrorAnimation();
                }
            }
            else
            {
                txtBox_period.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_period.Text = "Pas de ms/. ou autre caractères"; //change the text of text box for indicate the error
                txtBox_period_default = true; //Reset for clear after a new click
                txtBox_period_error = true; //Set error to true
                LabelErrorAnimation();
            }
        }

        private void txtBox_positive_duty_Leave(object sender, EventArgs e)
        {
            if (txtBox_positive_duty.Text == "")
            {
                txtBox_positive_duty.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_positive_duty.Text = "Le champ ne peut être vide !"; //change the text of text box for indicate the error
                txtBox_positive_duty_default = true; //Reset for clear after a new click
                txtBox_positive_duty_error = true; //Set error to true
                LabelErrorAnimation();
            }
            else if (UInt16.TryParse(txtBox_positive_duty.Text, out positive_duty)) //verify if the content is number and convert it to UInt16
            {
                if ((positive_duty >= 2) && (positive_duty <= 98)) //verify if the number enter is between the plage
                {
                    txtBox_positive_duty_error = false;
                    txtBox_positive_duty.BackColor = Color.FromArgb(74, 79, 99); //change the back color of text box
                    LabelErrorAnimation();
                }
                else
                {
                    txtBox_positive_duty.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                    txtBox_positive_duty.Text = "2 < valeur < 98"; //change the text of text box for indicate the error
                    txtBox_positive_duty_default = true; //Reset for clear after a new click
                    txtBox_positive_duty_error = true; //Set error to true
                    LabelErrorAnimation();
                }
            }
            else
            {
                txtBox_positive_duty.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_positive_duty.Text = "Pas de % ou autre caractères"; //change the text of text box for indicate the error
                txtBox_positive_duty_default = true; //Reset for clear after a new click
                txtBox_positive_duty_error = true; //Set error to true
            }
        }

        private void txtBox_negative_duty_Leave(object sender, EventArgs e)
        {
            if (txtBox_negative_duty.Text == "")
            {
                txtBox_negative_duty.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_negative_duty.Text = "Le champ ne peut être vide !"; //change the text of text box for indicate the error
                txtBox_negative_duty_default = true; //Reset for clear after a new click
                txtBox_negative_duty_error = true; //Set error to true
                LabelErrorAnimation();
            }
            else if (UInt16.TryParse(txtBox_negative_duty.Text, out negative_duty)) //verify if the content is number and convert it to UInt16
            {
                if ((negative_duty >= 2) && (negative_duty <= 98)) //verify if the number enter is between the plage
                {
                    txtBox_negative_duty_error = false;
                    txtBox_negative_duty.BackColor = Color.FromArgb(74, 79, 99); //change the back color of text box
                    LabelErrorAnimation();
                }
                else
                {
                    txtBox_negative_duty.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                    txtBox_negative_duty.Text = "2 < valeur < 98"; //change the text of text box for indicate the error
                    txtBox_negative_duty_default = true; //Reset for clear after a new click
                    txtBox_negative_duty_error = true; //Set error to true
                    LabelErrorAnimation();
                }
            }
            else
            {
                txtBox_negative_duty.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_negative_duty.Text = "Pas de % ou autre caractères"; //change the text of text box for indicate the error
                txtBox_negative_duty_default = true; //Reset for clear after a new click
                txtBox_negative_duty_error = true; //Set error to true
            }
        }

        private void txtBox_TON_Leave(object sender, EventArgs e)
        {
            if (txtBox_TON.Text == "")
            {
                txtBox_TON.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_TON.Text = "Le champ ne peut être vide !"; //change the text of text box for indicate the error
                txtBox_TON_default = true; //Reset for clear after a new click
                txtBox_TON_error = true; //Set error to true
                LabelErrorAnimation();
            }
            else if (double.TryParse(txtBox_TON.Text, out TON)) //verify if the content is number and convert it to double
            {
                if ((TON >= 0.0004) && (TON <= 196)) //verify if the number enter is between the plage
                {
                    txtBox_TON_error = false;
                    txtBox_TON.BackColor = Color.FromArgb(74, 79, 99); //change the back color of text box
                    LabelErrorAnimation();
                }
                else
                {
                    txtBox_TON.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                    txtBox_TON.Text = "0,0004 < valeur < 196"; //change the text of text box for indicate the error
                    txtBox_TON_default = true; //Reset for clear after a new click
                    txtBox_TON_error = true; //Set error to true
                    LabelErrorAnimation();
                }
            }
            else
            {
                txtBox_TON.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_TON.Text = "Pas de ms/. ou autre caractères"; //change the text of text box for indicate the error
                txtBox_TON_default = true; //Reset for clear after a new click
                txtBox_TON_error = true; //Set error to true
            }
        }

        private void txtBox_TOFF_Leave(object sender, EventArgs e)
        {
            if (txtBox_TOFF.Text == "")
            {
                txtBox_TOFF.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_TOFF.Text = "Le champ ne peut être vide !"; //change the text of text box for indicate the error
                txtBox_TOFF_default = true; //Reset for clear after a new click
                txtBox_TOFF_error = true; //Set error to true
                LabelErrorAnimation();
            }
            else if (double.TryParse(txtBox_TOFF.Text, out TOFF)) //verify if the content is number and convert it to double
            {
                if ((TOFF >= 0.0004) && (TOFF <= 196)) //verify if the number enter is between the plage
                {
                    txtBox_TOFF_error = false;
                    txtBox_TOFF.BackColor = Color.FromArgb(74, 79, 99); //change the back color of text box
                    LabelErrorAnimation();
                }
                else
                {
                    txtBox_TOFF.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                    txtBox_TOFF.Text = "0,0004 < valeur < 196"; //change the text of text box for indicate the error
                    txtBox_TOFF_default = true; //Reset for clear after a new click
                    txtBox_TOFF_error = true; //Set error to true
                    LabelErrorAnimation();
                }
            }
            else
            {
                txtBox_TOFF.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_TOFF.Text = "Pas de ms/. ou autre caractères"; //change the text of text box for indicate the error
                txtBox_TOFF_default = true; //Reset for clear after a new click
                txtBox_TOFF_error = true; //Set error to true
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
    }
}
