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
                case "NoConfigLoad": //no config load, start of software
                    pnlProject.Width = 436;
                    pnlLastMesure.Hide();
                    pnlCurrentMesure.Hide();
                    pnlScope.Hide();
                    break;
                case "ConfigProperties": //config properties defined, with the project name
                    pnlProject.Width = 436;
                    pnlLastMesure.Hide();
                    pnlCurrentMesure.Hide();
                    pnlScope.Hide();
                    lblCurrentWaitingState.Text = "Création des signaux du projet en attente...";
                    break;
                case "ConfigSignal": //signal create, waiting for mesure
                    pnlProject.Width = 436;
                    pnlCurrentMesure.Hide();
                    pnlScope.Hide();
                    pnlLastMesure.Hide();
                    lblConfigState.Text = "En attente du lancement de la mesure...";
                    lblCurrentWaitingState.Text = "Vérification de la connexion avec le boitier...";
                    break;
                case "MesureProgress": //mesure in progress
                    pnlWaitingConfig.Hide();
                    pnlProject.Width = 232;
                    break;

                default:
                    break;
            }
        }

        private void lblCurrentWaitingState_Click(object sender, EventArgs e)
        {

        }
    }
}
