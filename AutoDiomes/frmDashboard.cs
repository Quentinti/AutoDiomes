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
        int[] rainSpeed = { 4, 6, 8, 3, 5, 6, 7, 4 };
        int loadingSpeed = 1;

        public frmDashboard()
        {
            InitializeComponent();

            lblOverflow.Hide();

            switch (Globals.configState)
            {
                case "NoConfigLoad": //no config load, start of software
                    pnlProject.Width = 436;
                    pnlLastMesure.Hide();
                    pnlCurrentMesure.Hide();
                    pnlScope.Hide();
                    timer1.Start();
                    timer2.Start();
                    break;
                case "ConfigProperties": //config properties defined, with the project name
                    pnlProject.Width = 436;
                    pnlLastMesure.Hide();
                    pnlCurrentMesure.Hide();
                    pnlScope.Hide();

                    lblCurrentWaitingState.Text = "Création des signaux du projet en attente...";
                    lblProject_Name.Text = Globals.project.name;
                    lblProject_Phase.Text = Globals.project.phase;
                    timer1.Start();
                    timer2.Start();
                    break;
                case "ConfigSignal": //signal create, waiting for mesure
                    pnlProject.Width = 436;
                    pnlCurrentMesure.Hide();
                    pnlScope.Hide();
                    pnlLastMesure.Hide();
                    lblConfigState.Text = "En attente du lancement de la mesure...";
                    lblCurrentWaitingState.Text = "Vérification de la connexion avec le boitier...";
                    timer1.Start();
                    timer2.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0: //animation for rain 1
                        pbRain1.Location = new Point(pbRain1.Location.X, pbRain1.Location.Y + rainSpeed[i]);
                        if(pbRain1.Location.Y > pnlRain.Size.Height + pbRain1.Size.Height)
                        {
                            pbRain1.Location = new Point(pbRain1.Location.X, 0 - pbRain1.Size.Height);
                        }
                        break;
                    case 1: //animation for rain 2
                        pbRain2.Location = new Point(pbRain2.Location.X, pbRain2.Location.Y + rainSpeed[i]);
                        if (pbRain2.Location.Y > pnlRain.Size.Height + pbRain2.Size.Height)
                        {
                            pbRain2.Location = new Point(pbRain2.Location.X, 0 - pbRain2.Size.Height);
                        }
                        break;
                    case 2: //animation for rain 3
                        pbRain3.Location = new Point(pbRain3.Location.X, pbRain3.Location.Y + rainSpeed[i]);
                        if (pbRain3.Location.Y > pnlRain.Size.Height + pbRain3.Size.Height)
                        {
                            pbRain3.Location = new Point(pbRain3.Location.X, 0 - pbRain3.Size.Height);
                        }
                        break;
                    case 3: //animation for rain 4
                        pbRain4.Location = new Point(pbRain4.Location.X, pbRain4.Location.Y + rainSpeed[i]);
                        if (pbRain4.Location.Y > pnlRain.Size.Height + pbRain4.Size.Height)
                        {
                            pbRain4.Location = new Point(pbRain4.Location.X, 0 - pbRain4.Size.Height);
                        }
                        break;
                    case 4: //animation for rain 5
                        pbRain5.Location = new Point(pbRain5.Location.X, pbRain5.Location.Y + rainSpeed[i]);
                        if (pbRain5.Location.Y > pnlRain.Size.Height + pbRain5.Size.Height)
                        {
                            pbRain5.Location = new Point(pbRain5.Location.X, 0 - pbRain5.Size.Height);
                        }
                        break;
                    case 5: //animation for rain 6
                        pbRain6.Location = new Point(pbRain6.Location.X, pbRain6.Location.Y + rainSpeed[i]);
                        if (pbRain6.Location.Y > pnlRain.Size.Height + pbRain6.Size.Height)
                        {
                            pbRain6.Location = new Point(pbRain6.Location.X, 0 - pbRain6.Size.Height);
                        }
                        break;
                    case 6: //animation for rain 7
                        pbRain7.Location = new Point(pbRain7.Location.X, pbRain7.Location.Y + rainSpeed[i]);
                        if (pbRain7.Location.Y > pnlRain.Size.Height + pbRain7.Size.Height)
                        {
                            pbRain7.Location = new Point(pbRain7.Location.X, 0 - pbRain7.Size.Height);
                        }
                        break;
                    case 7: //animation for rain 8
                        pbRain8.Location = new Point(pbRain8.Location.X, pbRain8.Location.Y + rainSpeed[i]);
                        if (pbRain8.Location.Y > pnlRain.Size.Height + pbRain8.Size.Height)
                        {
                            pbRain8.Location = new Point(pbRain8.Location.X, 0 - pbRain8.Size.Height);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pnlPuddle.Location = new Point(pnlPuddle.Location.X, pnlPuddle.Location.Y + loadingSpeed);
            if (pnlPuddle.Location.Y > pbPuddle.Location.Y + pbPuddle.Height)
            {
                this.timer2.Stop();
                lblOverflow.Show();
            }
        }
    }
}
