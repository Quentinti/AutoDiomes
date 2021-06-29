// Librairies

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.IO.Ports;

namespace AutoDiomes
{
    public partial class Application : Form
    {
        //This can be cause lag

        int mov;
        int movX;
        int movY;
        string userName = System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName; //get current user display name
        string userEmail = System.DirectoryServices.AccountManagement.UserPrincipal.Current.EmailAddress; //get current user display name

        DirectoryInfo directorymain = Directory.CreateDirectory(@"C:\AutoDiomes"); //automatic create directory if he is not present
        DirectoryInfo directorytemp = Directory.CreateDirectory(@"C:\AutoDiomes\temp"); //automatic create directory temp for temporary files

        SerialPort port;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] //import dll for create round windows forms

        private static extern IntPtr CreateRoundRectRgn //struct for create round windows forms
        (
            int nLeftRect,
            int nTopRect,
            int nRightREct,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Application()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Menu principal";
            lblUserName.Text = userName;
            lblEmail.Text = userEmail;
            this.PnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Verbose = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Verbose.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Verbose);
            FrmDashboard_Verbose.Show();
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this will make form load on current working monitor
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Menu principal";

            this.PnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Verbose = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Verbose.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Verbose);
            FrmDashboard_Verbose.Show();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnAnalytics.Height;
            PnlNav.Top = btnAnalytics.Top;
            PnlNav.Left = btnAnalytics.Left;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Gestion projet";
            this.PnlFormLoader.Controls.Clear();
            frmAnalytics FrmAnalytics_Verbose = new frmAnalytics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmAnalytics_Verbose.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmAnalytics_Verbose);
            FrmAnalytics_Verbose.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnHelp.Height;
            PnlNav.Top = btnHelp.Top;
            PnlNav.Left = btnHelp.Left;
            btnHelp.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Aide";
            this.PnlFormLoader.Controls.Clear();
            frmHelp FrmHelp_Verbose = new frmHelp() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHelp_Verbose.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmHelp_Verbose);
            FrmHelp_Verbose.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnSettings.Height;
            PnlNav.Top = btnSettings.Top;
            PnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Paramètres";
            this.PnlFormLoader.Controls.Clear();
            frmSettings FrmSettings_Verbose = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmSettings_Verbose.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmSettings_Verbose);
            FrmSettings_Verbose.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnAbout.Height;
            PnlNav.Top = btnAbout.Top;
            PnlNav.Left = btnAbout.Left;
            btnAbout.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "À propos";
            this.PnlFormLoader.Controls.Clear();
            frmAbout FrmAbout_Verbose = new frmAbout() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmAbout_Verbose.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmAbout_Verbose);
            FrmAbout_Verbose.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnHelp_Leave(object sender, EventArgs e)
        {
            btnHelp.BackColor = Color.FromArgb(24, 30, 54);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAbout_Leave(object sender, EventArgs e)
        {
            btnAbout.BackColor = Color.FromArgb(24, 30, 54);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            directorytemp.Delete();
            System.Windows.Forms.Application.ExitThread();
        }

        //For move the no border form

        private void AreaMove_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;

        }

        private void AreaMove_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void AreaMove_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
