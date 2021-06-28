﻿using System;
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
    public partial class frmAnalytics : Form
    {

        public frmAnalytics()
        {
            InitializeComponent();

            if (Globals.lastFrame == "frmProjectStart")
            {
                this.PnlProjectLoader.Controls.Clear();
                frmProjectStart FrmProjectStart_Verbose = new frmProjectStart(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                FrmProjectStart_Verbose.FormBorderStyle = FormBorderStyle.None;
                this.PnlProjectLoader.Controls.Add(FrmProjectStart_Verbose);
                FrmProjectStart_Verbose.Show();
            }
            if (Globals.lastFrame == "frmProjectProperties")
            {
                this.PnlProjectLoader.Controls.Clear();
                frmProjectProperties FrmProjectProperties_Verbose = new frmProjectProperties(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                FrmProjectProperties_Verbose.FormBorderStyle = FormBorderStyle.None;
                this.PnlProjectLoader.Controls.Add(FrmProjectProperties_Verbose);
                FrmProjectProperties_Verbose.Show();
            }

            if (Globals.lastFrame == "frmSignalList")
            {
                this.PnlProjectLoader.Controls.Clear();
                frmSignalList frmSignalList_Verbose = new frmSignalList(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmSignalList_Verbose.FormBorderStyle = FormBorderStyle.None;
                this.PnlProjectLoader.Controls.Add(frmSignalList_Verbose);
                frmSignalList_Verbose.Show();
            }

            if (Globals.lastFrame == "frmSignalAdd")
            {
                this.PnlProjectLoader.Controls.Clear();
                frmSignalAdd frmSignalAdd_Verbose = new frmSignalAdd(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmSignalAdd_Verbose.FormBorderStyle = FormBorderStyle.None;
                this.PnlProjectLoader.Controls.Add(frmSignalAdd_Verbose);
                frmSignalAdd_Verbose.Show();
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

}
