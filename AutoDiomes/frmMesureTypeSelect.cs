using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace AutoDiomes
{
    public partial class frmMesureTypeSelect : Form
    {
        frmAnalytics ths;
        public frmMesureTypeSelect(frmAnalytics frm)
        {
            InitializeComponent();
            ths = frm;
            Globals.lastFrame = "frmMesureTypeSelect";
        }
        
        private void reWriteProperties()
        {
            string file_path = @"C:\AutoDiomes\temp\" + Globals.project.config_name + @"\" + Globals.project.config_name + @"_properties.json";

            if (System.IO.File.Exists(file_path))
            {
                System.IO.File.Delete(file_path);
            }

            string json = JsonConvert.SerializeObject(Globals.project, Formatting.Indented);
            System.IO.File.WriteAllText(file_path, json);
        }

        private void goBack()
        {
            ths.PnlProjectLoader.Controls.Clear();
            frmMesureType frmMesureType_Verbose = new frmMesureType(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmMesureType_Verbose.FormBorderStyle = FormBorderStyle.None;
            ths.PnlProjectLoader.Controls.Add(frmMesureType_Verbose);
            frmMesureType_Verbose.Show();
        }

        private void compare()
        {
            Globals.automatic_test_defined = true;
            Globals.project.compare = true;
            reWriteProperties();
            ths.PnlProjectLoader.Controls.Clear();
            frmSignalList frmSignalList_Verbose = new frmSignalList(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSignalList_Verbose.FormBorderStyle = FormBorderStyle.None;
            ths.PnlProjectLoader.Controls.Add(frmSignalList_Verbose);
            frmSignalList_Verbose.Show();
        }

        private void noCompare()
        {
            Globals.automatic_test_defined = true;
            Globals.project.compare = false;
            reWriteProperties();
            ths.PnlProjectLoader.Controls.Clear();
            frmSignalList frmSignalList_Verbose = new frmSignalList(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSignalList_Verbose.FormBorderStyle = FormBorderStyle.None;
            ths.PnlProjectLoader.Controls.Add(frmSignalList_Verbose);
            frmSignalList_Verbose.Show();
        }

        //Go back

        private void panel2_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            goBack();
        }

        //Compare

        private void panel4_Click(object sender, EventArgs e)
        {
            compare();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            compare();
        }

        //No compare

        private void label3_Click(object sender, EventArgs e)
        {
            noCompare();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            noCompare();
        }
    }
}
