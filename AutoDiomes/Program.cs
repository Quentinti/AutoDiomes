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
    }

    class Project
    {
        public string name;
        public string customer;
        public string phase;
        public UInt32 serial_number;
        public string software;
        public string hardware;
        public string test_type;
        public UInt16 error_margin;
        public DateTime file_date;
        public string config_name;

        //This constructor initializes the object Project
        public Project(string name, string customer, string phase, 
                       UInt32 serial_number, string software, string hardware ,string test_type, 
                       UInt16 error_margin, DateTime file_date, string config_name)
        {
            this.name = name;
            this.customer = customer;
            this.phase = phase;
            this.serial_number = serial_number;
            this.software = software;
            this.hardware = hardware;
            this.test_type = test_type;
            this.error_margin = error_margin;
            this.file_date = file_date;
            this.config_name = config_name;
        }
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
