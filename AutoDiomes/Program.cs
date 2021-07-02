using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AutoDiomes
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Application());
        }
    }

    static class Globals //create a class for use global variable
    {
        public static string lastFrame = "frmProjectStart"; //memorize current state for navigation
        public static string configState = "NoConfigLoad"; //memorize current state of configuration for blur panel
        public static bool automatic_test_defined = false;
        public static Project project = new Project(); //project
        public static Temporary_Project temporary_project = new Temporary_Project(); //real time edited value (for avoid reload of frame)
    }

    class Project
    {
        public string name;
        public string customer;
        public string phase;
        public string serial_number;
        public string software;
        public string hardware;
        public string test_type;
        public UInt16 error_margin;
        public string file_date;
        public string config_name;
        public UInt16 number_signal;
        public bool compare;
    }
    class Temporary_Project
    {
        public string name;
        public string customer;
        public string phase;
        public string serial_number;
        public string software;
        public string hardware;
        public UInt16 error_margin;
        public string config_name;
    }
    class Signal
    {
        public bool ON_OFF;
        public UInt32 frequency;
        public UInt32 period;
        public UInt16 duty_positive;
        public UInt16 duty_negative;
        public UInt32 TON;
        public UInt32 TOFF;

        //This constructor initializes the object Signal in case of ON/OFF signal
        public Signal(bool ON_OFF)
        {
            this.ON_OFF = ON_OFF;
        }

        //This constructor initializes the object Signal in case of none ON/OFF signal
        public Signal(UInt32 frequency, UInt32 period, UInt16 duty_positive, UInt16 duty_negative, UInt32 TON, UInt32 TOFF)
        {
            this.frequency = frequency;
            this.period = period;
            this.duty_positive = duty_positive;
            this.duty_negative = duty_negative;
            this.TON = TON;
            this.TOFF = TOFF;
        }
    }

    

}
