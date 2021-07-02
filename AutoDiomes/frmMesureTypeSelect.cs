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
        readonly frmAnalytics ths;
        public frmMesureTypeSelect(frmAnalytics frm)
        {
            InitializeComponent();
            ths = frm;
            Globals.lastFrame = "frmMesureTypeSelect";
        }
        
        private void ReWriteProperties()
        {
            string file_path = @"C:\AutoDiomes\temp\" + Globals.project.config_name + @"\" + Globals.project.config_name + @"_properties.json";

            if (System.IO.File.Exists(file_path))
            {
                System.IO.File.Delete(file_path);
            }

            string json = JsonConvert.SerializeObject(Globals.project, Formatting.Indented);
            System.IO.File.WriteAllText(file_path, json);
        }

        private void GoBack()
        {
            ths.PnlProjectLoader.Controls.Clear();
            frmMesureType frmMesureType_Verbose = new frmMesureType(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmMesureType_Verbose.FormBorderStyle = FormBorderStyle.None;
            ths.PnlProjectLoader.Controls.Add(frmMesureType_Verbose);
            frmMesureType_Verbose.Show();
        }

        private void Compare()
        {
            Globals.automatic_test_defined = true;
            Globals.project.compare = true;
            ReWriteProperties();
            ths.PnlProjectLoader.Controls.Clear();
            frmSignalList frmSignalList_Verbose = new frmSignalList(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSignalList_Verbose.FormBorderStyle = FormBorderStyle.None;
            ths.PnlProjectLoader.Controls.Add(frmSignalList_Verbose);
            frmSignalList_Verbose.Show();
        }

        private void NoCompare()
        {
            Globals.automatic_test_defined = true;
            Globals.project.compare = false;
            ReWriteProperties();
            ths.PnlProjectLoader.Controls.Clear();
            frmSignalList frmSignalList_Verbose = new frmSignalList(ths) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSignalList_Verbose.FormBorderStyle = FormBorderStyle.None;
            ths.PnlProjectLoader.Controls.Add(frmSignalList_Verbose);
            frmSignalList_Verbose.Show();
        }

        //Go back

        private void Panel2_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        //Compare

        private void Panel4_Click(object sender, EventArgs e)
        {
            Compare();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Compare();
        }

        //No compare

        private void Label3_Click(object sender, EventArgs e)
        {
            NoCompare();
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            NoCompare();
        }
    }
}
