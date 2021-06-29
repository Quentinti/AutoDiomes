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


namespace AutoDiomes
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();

            switch (Globals.configState)
            {
                case "NoConfigLoad":
                    break;
                case "ConfigProperties":
                    break;
                case "ConfigSignal":
                    break;
                default:
                    break;
            }
        }
    }
}
