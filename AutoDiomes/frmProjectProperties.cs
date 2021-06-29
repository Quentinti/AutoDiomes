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

        bool txtBox_name_default = true;
        bool txtBox_customer_default = true;
        bool txtBox_phase_default = true;
        bool txtBox_serial_number_default = true;
        bool txtBox_software_default = true;
        bool txtBox_hardware_default = true;
        bool txtBox_error_margin_default = true;
        bool txtBox_config_name_default = true;

        public frmProjectProperties(frmAnalytics frm)
        {
            InitializeComponent();
            ths = frm;
            Globals.lastFrame = "frmProjectProperties";
        }

        private void frame_projectproperties()
        {
            ths.PnlProjectLoader.Controls.Clear();
            frmSignalList frmSignalList_Verbose = new frmSignalList(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSignalList_Verbose.FormBorderStyle = FormBorderStyle.None;
            ths.PnlProjectLoader.Controls.Add(frmSignalList_Verbose);
            frmSignalList_Verbose.Show();
            Globals.configState = "ConfigProperties";


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
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
    }
}
