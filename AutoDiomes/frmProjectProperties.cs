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
    public partial class frmProjectProperties : Form
    {
        frmAnalytics ths;

        bool txtBox_name_error = true;
        bool txtBox_customer_error = true;
        bool txtBox_phase_error = true;
        bool txtBox_serial_number_error = true;
        bool txtBox_software_error = true;
        bool txtBox_hardware_error = true;
        bool cmbBox_test_type_error = true;
        bool txtBox_error_margin_error = true;
        bool txtBox_config_name_error = true;

        bool txtBox_name_default = true;
        bool txtBox_customer_default = true;
        bool txtBox_phase_default = true;
        bool txtBox_serial_number_default = true;
        bool txtBox_software_default = true;
        bool txtBox_hardware_default = true;
        bool txtBox_error_margin_default = true;
        bool txtBox_config_name_default = true;

        private string name;
        private string customer;
        private string phase;
        private string serial_number;
        private string software;
        private string hardware;
        private string test_type;
        private UInt16 error_margin;
        private string date_file;
        private string config_name;

        private string animate = "Right";
        private ushort animate_cpt = 0;



        public frmProjectProperties(frmAnalytics frm)
        {
            InitializeComponent();
            ths = frm;
            Globals.lastFrame = "frmProjectProperties";
            this.timer1.Start();
        }

        private void labelErrorAnimation()
        {
            if (check_error())
            {
                panel5.BackColor = Color.FromArgb(180, 30, 50);
                panel5.Cursor = System.Windows.Forms.Cursors.No;
                label11.Location = new Point(46, 15);
                label11.Text = "Erreur de saisie !        ";
                label11.Image = global::AutoDiomes.Properties.Resources.cross;
                label11.Cursor = System.Windows.Forms.Cursors.No;

            }
            else
            {
                panel5.BackColor = Color.FromArgb(20, 40, 60);
                panel5.Cursor = System.Windows.Forms.Cursors.Hand;
                label11.Location = new Point(11, 15);
                label11.Text = "Configuration des signaux :        ";
                label11.Image = global::AutoDiomes.Properties.Resources.signal;
                label11.Cursor = System.Windows.Forms.Cursors.Default;
            }   
        }

        private bool check_error() //for check if error are present
        {
            if(!txtBox_name_error && !txtBox_customer_error && 
                !txtBox_phase_error && !txtBox_serial_number_error &&
                !txtBox_software_error && !txtBox_hardware_error &&
                !txtBox_error_margin_error && !txtBox_config_name_error &&
                !cmbBox_test_type_error)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void frame_SignalList()
        {
            if (!check_error())
            {
                //Create the new object project and assign value of text box

                date_file = file_date.SelectionRange.Start.ToShortDateString();

                //Project project = new Project();

                //Set the state of project config for the dashboard
                Globals.configState = "ConfigProperties";

                //Show next form with signal list
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
                labelErrorAnimation(); //Update label of error if error is present
            }   
        }

        private void frame_ProjectStart()
        {
            ths.PnlProjectLoader.Controls.Clear();
            frmProjectStart frmProjectStart_Verbose = new frmProjectStart(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProjectStart_Verbose.FormBorderStyle = FormBorderStyle.None;
            ths.PnlProjectLoader.Controls.Add(frmProjectStart_Verbose);
            frmProjectStart_Verbose.Show();
            Globals.configState = "NoConfigLoad";
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            frame_SignalList();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            frame_SignalList();
        }

        private void txtBox_name_Click(object sender, EventArgs e)
        {
            if (txtBox_name_default)
            {
                txtBox_name.Clear();
                txtBox_name_default = false;
            }
        }

        private void txtBox_customer_Click(object sender, EventArgs e)
        {
            if (txtBox_customer_default)
            {
                txtBox_customer.Clear();
                txtBox_customer_default = false;
            }
        }

        private void txtBox_phase_Click(object sender, EventArgs e)
        {
            if (txtBox_phase_default)
            {
                txtBox_phase.Clear();
                txtBox_phase_default = false;
            }
        }

        private void txtBox_serial_number_Click(object sender, EventArgs e)
        {
            if (txtBox_serial_number_default)
            {
                txtBox_serial_number.Clear();
                txtBox_serial_number_default = false;
            }
        }

        private void txtBox_software_Click(object sender, EventArgs e)
        {
            if (txtBox_software_default)
            {
                txtBox_software.Clear();
                txtBox_software_default = false;
            }

        }

        private void txtBox_hardware_Click(object sender, EventArgs e)
        {
            if (txtBox_hardware_default)
            {
                txtBox_hardware.Clear();
                txtBox_hardware_default = false;
            }
        }

        private void txtBox_error_margin_Click(object sender, EventArgs e)
        {
            if (txtBox_error_margin_default)
            {
                txtBox_error_margin.Clear();
                txtBox_error_margin_default = false;
            }
        }

        private void txtBox_config_name_Click(object sender, EventArgs e)
        {
            if (txtBox_config_name_default)
            {
                txtBox_config_name.Clear();
                txtBox_config_name_default = false;
            }

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            frame_ProjectStart();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            frame_ProjectStart();
        }

        private void txtBox_name_Leave(object sender, EventArgs e)
        {
            name = txtBox_name.Text;
            if (name.Length < 64) //verify if the content is bellow 60 carac
            {
                txtBox_name_error = false;
                txtBox_name.BackColor = Color.FromArgb(74, 79, 99); //change the back color of text box
                labelErrorAnimation();
            }
            else
            {
                txtBox_name.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_name.Text = "Saisie trop longue ! < 64"; //change the text of text box for indicate the error
                txtBox_name_default = true; //Reset for clear after a new click
                txtBox_name_error = true; //Set error to true
                labelErrorAnimation();
            }
        }

        private void txtBox_customer_Leave(object sender, EventArgs e)
        {
            customer = txtBox_customer.Text;
            if (customer.Length < 64) //verify if the content is bellow 60 carac
            {
                txtBox_customer_error = false;
                txtBox_customer.BackColor = Color.FromArgb(74, 79, 99); //change the back color of text box
                labelErrorAnimation();
            }
            else
            {
                txtBox_customer.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_customer.Text = "Saisie trop longue ! < 64"; //change the text of text box for indicate the error
                txtBox_customer_default = true; //Reset for clear after a new click
                txtBox_customer_error = true; //Set error to true
                labelErrorAnimation();
            }
        }

        private void txtBox_phase_Leave(object sender, EventArgs e)
        {
            phase = txtBox_phase.Text;
            if (phase.Length < 64) //verify if the content is bellow 60 carac
            {
                txtBox_phase_error = false;
                txtBox_phase.BackColor = Color.FromArgb(74, 79, 99); //change the back color of text box
                labelErrorAnimation();
            }
            else
            {
                txtBox_phase.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_phase.Text = "Saisie trop longue ! < 64"; //change the text of text box for indicate the error
                txtBox_phase_default = true; //Reset for clear after a new click
                txtBox_phase_error = true; //Set error to true
                labelErrorAnimation();
            }
        }

        private void txtBox_serial_number_Leave(object sender, EventArgs e)
        {
            serial_number = txtBox_serial_number.Text;
            if (serial_number.Length < 64) //verify if the content is bellow 60 carac
            {
                txtBox_serial_number_error = false;
                txtBox_serial_number.BackColor = Color.FromArgb(74, 79, 99); //change the back color of text box
                labelErrorAnimation();
            }
            else
            {
                txtBox_serial_number.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_serial_number.Text = "Saisie trop longue ! < 64"; //change the text of text box for indicate the error
                txtBox_serial_number_default = true; //Reset for clear after a new click
                txtBox_serial_number_error = true; //Set error to true
                labelErrorAnimation();
            }
        }

        private void txtBox_software_Leave(object sender, EventArgs e)
        {
            software = txtBox_software.Text;
            if (software.Length < 64) //verify if the content is bellow 60 carac
            {
                txtBox_software_error = false;
                txtBox_software.BackColor = Color.FromArgb(74, 79, 99); //change the back color of text box
                labelErrorAnimation();
            }
            else
            {
                txtBox_software.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_software.Text = "Saisie trop longue ! < 64"; //change the text of text box for indicate the error
                txtBox_software_default = true; //Reset for clear after a new click
                txtBox_software_error = true; //Set error to true
                labelErrorAnimation();
            }
        }

        private void txtBox_hardware_Leave(object sender, EventArgs e)
        {
            hardware = txtBox_hardware.Text;
            if (hardware.Length < 64) //verify if the content is bellow 60 carac
            {
                txtBox_hardware_error = false;
                txtBox_hardware.BackColor = Color.FromArgb(74, 79, 99); //change the back color of text box
                labelErrorAnimation();
            }
            else
            {
                txtBox_hardware.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_hardware.Text = "Saisie trop longue ! < 64"; //change the text of text box for indicate the error
                txtBox_hardware_default = true; //Reset for clear after a new click
                txtBox_hardware_error = true; //Set error to true
                labelErrorAnimation();
            }
        }

        private void txtBox_error_margin_Leave(object sender, EventArgs e)
        {
            if(UInt16.TryParse(txtBox_error_margin.Text, out error_margin)) //verify if the content is number and convert it to UINT16
            {
                if((error_margin >= 0) && (error_margin <= 100)) //verify if the number enter is a percent
                {
                    txtBox_error_margin_error = false;
                    txtBox_error_margin.BackColor = Color.FromArgb(74, 79, 99); //change the back color of text box
                    labelErrorAnimation();
                }
                else
                {
                    txtBox_error_margin.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                    txtBox_error_margin.Text = "Pas de %, 0 < valeur < 100"; //change the text of text box for indicate the error
                    txtBox_error_margin_default = true; //Reset for clear after a new click
                    txtBox_error_margin_error = true; //Set error to true
                    labelErrorAnimation();
                }
            }
            else
            {
                txtBox_error_margin.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_error_margin.Text = "Pas de %, 0 < valeur < 100"; //change the text of text box for indicate the error
                txtBox_error_margin_default = true; //Reset for clear after a new click
                txtBox_error_margin_error = true; //Set error to true
                labelErrorAnimation();
            }
        }

        private void txtBox_config_name_Leave(object sender, EventArgs e)
        {
            config_name = txtBox_config_name.Text;
            if (config_name.Length < 64) //verify if the content is bellow 60 carac
            {
                txtBox_config_name_error = false;
                txtBox_config_name.BackColor = Color.FromArgb(74, 79, 99); //change the back color of text box
                labelErrorAnimation();
            }
            else
            {
                txtBox_config_name.BackColor = Color.FromArgb(180, 30, 50); //change the back color of text box
                txtBox_config_name.Text = "Saisie trop longue ! < 64"; //change the text of text box for indicate the error
                txtBox_config_name_default = true; //Reset for clear after a new click
                txtBox_config_name_error = true; //Set error to true
                labelErrorAnimation();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label11.Text == "Erreur de saisie !        ")
            {
                if (animate_cpt == 6)
                {
                    panel5.Location = new Point(475, 413);
                }
                if (animate_cpt < 6)
                {

                    if (animate == "Right")
                    {
                        panel5.Location = new Point(panel5.Location.X + 6, panel5.Location.Y);
                    }
                    else if (animate == "Left")
                    {
                        panel5.Location = new Point(panel5.Location.X - 6, panel5.Location.Y);
                    }

                    if (panel5.Location.X > 490)
                    {
                        animate = "Left";
                        animate_cpt++;
                    }
                    else if (panel5.Location.X < 460)
                    {
                        animate = "Right";
                        animate_cpt++;
                    }
                }
            }
            
        }

        private void cmbox_testtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            test_type = cmbox_testtype.Text;
            cmbBox_test_type_error = false;
        }

        //private static string ConvertLinearToString(ushort data) //Convert UINT16 to string
        //{
        //    var n = GetBitRange(data, 16, 5);
        //    var y = GetBitRange(data, 21, 11);
        //    var value = y * Math.Pow(2, n);
        //    return value.ToString();
        //}

        //private static int GetBitRange(int data, int offset, int count)
        //{
        //    return data << offset >> (32 - count);
        //}
    }
}
