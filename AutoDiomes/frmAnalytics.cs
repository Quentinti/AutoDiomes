using System.Windows.Forms;

namespace AutoDiomes
{
    public partial class frmAnalytics : Form
    {

        public frmAnalytics()
        {
            InitializeComponent();

            switch (Globals.lastFrame) //frame persistence for inter-menu navigation of the main form 
            {
                case "frmProjectStart": //in the case of frmProjectStart
                    this.PnlProjectLoader.Controls.Clear(); //Clear the content of PnlProjectLoader
                    frmProjectStart FrmProjectStart_Verbose = new frmProjectStart(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; //Create a verbose for the frame
                    //and dock it
                    FrmProjectStart_Verbose.FormBorderStyle = FormBorderStyle.None; //Bordeless form
                    this.PnlProjectLoader.Controls.Add(FrmProjectStart_Verbose); //Add to panel loader the previous form
                    FrmProjectStart_Verbose.Show(); //Show the form at the panel loader
                    break;

                case "frmProjectProperties":
                    this.PnlProjectLoader.Controls.Clear();
                    frmProjectProperties FrmProjectProperties_Verbose = new frmProjectProperties(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    FrmProjectProperties_Verbose.FormBorderStyle = FormBorderStyle.None;
                    this.PnlProjectLoader.Controls.Add(FrmProjectProperties_Verbose);
                    FrmProjectProperties_Verbose.Show();
                    break;

                case "frmSignalList":
                    this.PnlProjectLoader.Controls.Clear();
                    frmSignalList frmSignalList_Verbose = new frmSignalList(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    frmSignalList_Verbose.FormBorderStyle = FormBorderStyle.None;
                    this.PnlProjectLoader.Controls.Add(frmSignalList_Verbose);
                    frmSignalList_Verbose.Show();
                    break;

                case "frmSignalAdd":
                    this.PnlProjectLoader.Controls.Clear();
                    frmSignalAdd frmSignalAdd_Verbose = new frmSignalAdd(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    frmSignalAdd_Verbose.FormBorderStyle = FormBorderStyle.None;
                    this.PnlProjectLoader.Controls.Add(frmSignalAdd_Verbose);
                    frmSignalAdd_Verbose.Show();
                    break;

                case "frmMesureType":
                    this.PnlProjectLoader.Controls.Clear();
                    frmMesureType frmMesureType_Verbose = new frmMesureType(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    frmMesureType_Verbose.FormBorderStyle = FormBorderStyle.None;
                    this.PnlProjectLoader.Controls.Add(frmMesureType_Verbose);
                    frmMesureType_Verbose.Show();
                    break;

                case "frmMesureTypeSelect":
                    this.PnlProjectLoader.Controls.Clear();
                    frmMesureTypeSelect frmMesureTypeSelect_Verbose = new frmMesureTypeSelect(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    frmMesureTypeSelect_Verbose.FormBorderStyle = FormBorderStyle.None;
                    this.PnlProjectLoader.Controls.Add(frmMesureTypeSelect_Verbose);
                    frmMesureTypeSelect_Verbose.Show();
                    break;



                default:
                    break;
            }
        }
    }
}
