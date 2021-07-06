
namespace AutoDiomes
{
    partial class frmSignalAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignalAdd));
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbox_ONOFF = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StateText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NextState = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBox_frequency = new System.Windows.Forms.TextBox();
            this.txtBox_period = new System.Windows.Forms.TextBox();
            this.txtBox_positive_duty = new System.Windows.Forms.TextBox();
            this.txtBox_negative_duty = new System.Windows.Forms.TextBox();
            this.txtBox_TON = new System.Windows.Forms.TextBox();
            this.txtBox_TOFF = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_TOFF = new System.Windows.Forms.Panel();
            this.pnl_TON = new System.Windows.Forms.Panel();
            this.pnl_Negative_duty = new System.Windows.Forms.Panel();
            this.pnl_Positive_duty = new System.Windows.Forms.Panel();
            this.pnl_Period = new System.Windows.Forms.Panel();
            this.pnl_Frequency = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_TOFF.SuspendLayout();
            this.pnl_TON.SuspendLayout();
            this.pnl_Negative_duty.SuspendLayout();
            this.pnl_Positive_duty.SuspendLayout();
            this.pnl_Period.SuspendLayout();
            this.pnl_Frequency.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.cmbox_ONOFF);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(18, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(446, 57);
            this.panel4.TabIndex = 16;
            // 
            // cmbox_ONOFF
            // 
            this.cmbox_ONOFF.AutoCompleteCustomSource.AddRange(new string[] {
            "Non",
            "ON",
            "OFF"});
            this.cmbox_ONOFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbox_ONOFF.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbox_ONOFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_ONOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_ONOFF.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox_ONOFF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.cmbox_ONOFF.FormattingEnabled = true;
            this.cmbox_ONOFF.Items.AddRange(new object[] {
            "Non",
            "ON",
            "OFF"});
            this.cmbox_ONOFF.Location = new System.Drawing.Point(253, 14);
            this.cmbox_ONOFF.Margin = new System.Windows.Forms.Padding(0);
            this.cmbox_ONOFF.Name = "cmbox_ONOFF";
            this.cmbox_ONOFF.Size = new System.Drawing.Size(150, 28);
            this.cmbox_ONOFF.TabIndex = 6;
            this.cmbox_ONOFF.SelectedIndexChanged += new System.EventHandler(this.cmbox_ONOFF_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = global::AutoDiomes.Properties.Resources.on_off;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Signal ON/OFF ? :        ";
            // 
            // StateText
            // 
            this.StateText.AutoSize = true;
            this.StateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.StateText.Location = new System.Drawing.Point(12, 9);
            this.StateText.Name = "StateText";
            this.StateText.Size = new System.Drawing.Size(392, 32);
            this.StateText.TabIndex = 15;
            this.StateText.Text = "Ajoutez un nouveau signal :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.circularProgressBar1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(517, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 257);
            this.panel2.TabIndex = 19;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar1.AnimationFunction")));
            this.circularProgressBar1.AnimationSpeed = 0;
            this.circularProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(23, 70);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Red;
            this.circularProgressBar1.ProgressWidth = 7;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(161, 161);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Step = 1;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 19;
            this.circularProgressBar1.Text = "10%";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Image = global::AutoDiomes.Properties.Resources.error;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(24, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Marge d\'erreur       ";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(517, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 57);
            this.panel3.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Image = global::AutoDiomes.Properties.Resources.check;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(24, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Fin configuration        ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(517, 408);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(204, 57);
            this.panel5.TabIndex = 21;
            this.panel5.Click += new System.EventHandler(this.Panel5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Image = global::AutoDiomes.Properties.Resources.cross;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(54, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Annuler        ";
            this.label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 2;
            // 
            // NextState
            // 
            this.NextState.AutoSize = true;
            this.NextState.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.NextState.Location = new System.Drawing.Point(42, 40);
            this.NextState.Name = "NextState";
            this.NextState.Size = new System.Drawing.Size(211, 21);
            this.NextState.TabIndex = 18;
            this.NextState.Text = "Cliquez dessus pour mesurer";
            this.NextState.Click += new System.EventHandler(this.NextState_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::AutoDiomes.Properties.Resources.signal;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fréquence :        ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::AutoDiomes.Properties.Resources.period;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Période :        ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.DoubleClick += new System.EventHandler(this.label3_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = global::AutoDiomes.Properties.Resources.positive_duty;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Rapport cyclique (+) :        ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.DoubleClick += new System.EventHandler(this.label5_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = global::AutoDiomes.Properties.Resources.negative_duty;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Rapport cyclique (-) :        ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.DoubleClick += new System.EventHandler(this.label6_DoubleClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(15, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(294, 25);
            this.label13.TabIndex = 23;
            this.label13.Text = "Configuration signal non ON/OFF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = global::AutoDiomes.Properties.Resources.on_off;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "TON :        ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.DoubleClick += new System.EventHandler(this.label7_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Image = global::AutoDiomes.Properties.Resources.off;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "TOFF :        ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            this.label8.DoubleClick += new System.EventHandler(this.label8_DoubleClick);
            // 
            // txtBox_frequency
            // 
            this.txtBox_frequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtBox_frequency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_frequency.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_frequency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBox_frequency.Location = new System.Drawing.Point(230, 10);
            this.txtBox_frequency.Multiline = true;
            this.txtBox_frequency.Name = "txtBox_frequency";
            this.txtBox_frequency.Size = new System.Drawing.Size(212, 21);
            this.txtBox_frequency.TabIndex = 26;
            this.txtBox_frequency.Text = "5Hz min - 50KHz max";
            this.txtBox_frequency.Click += new System.EventHandler(this.txtBox_frequency_Click);
            this.txtBox_frequency.DoubleClick += new System.EventHandler(this.txtBox_frequency_DoubleClick);
            this.txtBox_frequency.Leave += new System.EventHandler(this.txtBox_frequency_Leave);
            // 
            // txtBox_period
            // 
            this.txtBox_period.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtBox_period.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_period.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_period.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBox_period.Location = new System.Drawing.Point(230, 10);
            this.txtBox_period.Multiline = true;
            this.txtBox_period.Name = "txtBox_period";
            this.txtBox_period.Size = new System.Drawing.Size(212, 21);
            this.txtBox_period.TabIndex = 27;
            this.txtBox_period.Text = "0,2secondes - 0.02ms";
            this.txtBox_period.Click += new System.EventHandler(this.txtBox_period_Click);
            this.txtBox_period.DoubleClick += new System.EventHandler(this.txtBox_period_DoubleClick);
            // 
            // txtBox_positive_duty
            // 
            this.txtBox_positive_duty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtBox_positive_duty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_positive_duty.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_positive_duty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBox_positive_duty.Location = new System.Drawing.Point(230, 6);
            this.txtBox_positive_duty.Multiline = true;
            this.txtBox_positive_duty.Name = "txtBox_positive_duty";
            this.txtBox_positive_duty.Size = new System.Drawing.Size(212, 21);
            this.txtBox_positive_duty.TabIndex = 28;
            this.txtBox_positive_duty.Text = "2 à 98%";
            this.txtBox_positive_duty.Click += new System.EventHandler(this.txtBox_positive_duty_Click);
            this.txtBox_positive_duty.DoubleClick += new System.EventHandler(this.txtBox_positive_duty_DoubleClick);
            // 
            // txtBox_negative_duty
            // 
            this.txtBox_negative_duty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtBox_negative_duty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_negative_duty.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_negative_duty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBox_negative_duty.Location = new System.Drawing.Point(230, 9);
            this.txtBox_negative_duty.Multiline = true;
            this.txtBox_negative_duty.Name = "txtBox_negative_duty";
            this.txtBox_negative_duty.Size = new System.Drawing.Size(212, 21);
            this.txtBox_negative_duty.TabIndex = 29;
            this.txtBox_negative_duty.Text = "2 à 98%";
            this.txtBox_negative_duty.Click += new System.EventHandler(this.txtBox_negative_duty_Click);
            this.txtBox_negative_duty.DoubleClick += new System.EventHandler(this.txtBox_negative_duty_DoubleClick);
            // 
            // txtBox_TON
            // 
            this.txtBox_TON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtBox_TON.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_TON.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_TON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBox_TON.Location = new System.Drawing.Point(230, 14);
            this.txtBox_TON.Multiline = true;
            this.txtBox_TON.Name = "txtBox_TON";
            this.txtBox_TON.Size = new System.Drawing.Size(212, 21);
            this.txtBox_TON.TabIndex = 30;
            this.txtBox_TON.Click += new System.EventHandler(this.txtBox_TON_Click);
            this.txtBox_TON.DoubleClick += new System.EventHandler(this.txtBox_TON_DoubleClick);
            // 
            // txtBox_TOFF
            // 
            this.txtBox_TOFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtBox_TOFF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_TOFF.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_TOFF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBox_TOFF.Location = new System.Drawing.Point(230, 7);
            this.txtBox_TOFF.Multiline = true;
            this.txtBox_TOFF.Name = "txtBox_TOFF";
            this.txtBox_TOFF.Size = new System.Drawing.Size(212, 21);
            this.txtBox_TOFF.TabIndex = 31;
            this.txtBox_TOFF.Click += new System.EventHandler(this.txtBox_TOFF_Click);
            this.txtBox_TOFF.DoubleClick += new System.EventHandler(this.txtBox_TOFF_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pnl_TOFF);
            this.panel1.Controls.Add(this.pnl_TON);
            this.panel1.Controls.Add(this.pnl_Negative_duty);
            this.panel1.Controls.Add(this.pnl_Positive_duty);
            this.panel1.Controls.Add(this.pnl_Period);
            this.panel1.Controls.Add(this.pnl_Frequency);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.NextState);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 330);
            this.panel1.TabIndex = 17;
            // 
            // pnl_TOFF
            // 
            this.pnl_TOFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.pnl_TOFF.Controls.Add(this.label8);
            this.pnl_TOFF.Controls.Add(this.txtBox_TOFF);
            this.pnl_TOFF.Location = new System.Drawing.Point(20, 273);
            this.pnl_TOFF.Name = "pnl_TOFF";
            this.pnl_TOFF.Size = new System.Drawing.Size(445, 42);
            this.pnl_TOFF.TabIndex = 37;
            this.pnl_TOFF.Click += new System.EventHandler(this.pnl_TOFF_Click);
            this.pnl_TOFF.DoubleClick += new System.EventHandler(this.pnl_TOFF_DoubleClick);
            // 
            // pnl_TON
            // 
            this.pnl_TON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.pnl_TON.Controls.Add(this.label7);
            this.pnl_TON.Controls.Add(this.txtBox_TON);
            this.pnl_TON.Location = new System.Drawing.Point(20, 232);
            this.pnl_TON.Name = "pnl_TON";
            this.pnl_TON.Size = new System.Drawing.Size(445, 42);
            this.pnl_TON.TabIndex = 36;
            this.pnl_TON.Click += new System.EventHandler(this.pnl_TON_Click);
            this.pnl_TON.DoubleClick += new System.EventHandler(this.pnl_TON_DoubleClick);
            // 
            // pnl_Negative_duty
            // 
            this.pnl_Negative_duty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.pnl_Negative_duty.Controls.Add(this.label6);
            this.pnl_Negative_duty.Controls.Add(this.txtBox_negative_duty);
            this.pnl_Negative_duty.Location = new System.Drawing.Point(20, 193);
            this.pnl_Negative_duty.Name = "pnl_Negative_duty";
            this.pnl_Negative_duty.Size = new System.Drawing.Size(445, 42);
            this.pnl_Negative_duty.TabIndex = 35;
            this.pnl_Negative_duty.Click += new System.EventHandler(this.pnl_Negative_duty_Click);
            this.pnl_Negative_duty.DoubleClick += new System.EventHandler(this.pnl_Negative_duty_DoubleClick);
            // 
            // pnl_Positive_duty
            // 
            this.pnl_Positive_duty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.pnl_Positive_duty.Controls.Add(this.txtBox_positive_duty);
            this.pnl_Positive_duty.Controls.Add(this.label5);
            this.pnl_Positive_duty.Location = new System.Drawing.Point(20, 154);
            this.pnl_Positive_duty.Name = "pnl_Positive_duty";
            this.pnl_Positive_duty.Size = new System.Drawing.Size(445, 42);
            this.pnl_Positive_duty.TabIndex = 34;
            this.pnl_Positive_duty.Click += new System.EventHandler(this.pnl_Positive_duty_Click);
            this.pnl_Positive_duty.DoubleClick += new System.EventHandler(this.pnl_Positive_duty_DoubleClick);
            // 
            // pnl_Period
            // 
            this.pnl_Period.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.pnl_Period.Controls.Add(this.txtBox_period);
            this.pnl_Period.Controls.Add(this.label3);
            this.pnl_Period.Location = new System.Drawing.Point(20, 112);
            this.pnl_Period.Name = "pnl_Period";
            this.pnl_Period.Size = new System.Drawing.Size(445, 42);
            this.pnl_Period.TabIndex = 33;
            this.pnl_Period.Click += new System.EventHandler(this.pnl_Period_Click);
            this.pnl_Period.DoubleClick += new System.EventHandler(this.pnl_Period_DoubleClick);
            // 
            // pnl_Frequency
            // 
            this.pnl_Frequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.pnl_Frequency.Controls.Add(this.label2);
            this.pnl_Frequency.Controls.Add(this.txtBox_frequency);
            this.pnl_Frequency.Location = new System.Drawing.Point(20, 70);
            this.pnl_Frequency.Name = "pnl_Frequency";
            this.pnl_Frequency.Size = new System.Drawing.Size(445, 42);
            this.pnl_Frequency.TabIndex = 32;
            this.pnl_Frequency.Click += new System.EventHandler(this.pnl_Frequency_Click);
            this.pnl_Frequency.DoubleClick += new System.EventHandler(this.pnl_Frequency_DoubleClick);
            // 
            // frmSignalAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StateText);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignalAdd";
            this.Text = "frmSignalAdd";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_TOFF.ResumeLayout(false);
            this.pnl_TOFF.PerformLayout();
            this.pnl_TON.ResumeLayout(false);
            this.pnl_TON.PerformLayout();
            this.pnl_Negative_duty.ResumeLayout(false);
            this.pnl_Negative_duty.PerformLayout();
            this.pnl_Positive_duty.ResumeLayout(false);
            this.pnl_Positive_duty.PerformLayout();
            this.pnl_Period.ResumeLayout(false);
            this.pnl_Period.PerformLayout();
            this.pnl_Frequency.ResumeLayout(false);
            this.pnl_Frequency.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label StateText;
        private System.Windows.Forms.ComboBox cmbox_ONOFF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NextState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBox_frequency;
        private System.Windows.Forms.TextBox txtBox_period;
        private System.Windows.Forms.TextBox txtBox_positive_duty;
        private System.Windows.Forms.TextBox txtBox_negative_duty;
        private System.Windows.Forms.TextBox txtBox_TON;
        private System.Windows.Forms.TextBox txtBox_TOFF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_TOFF;
        private System.Windows.Forms.Panel pnl_TON;
        private System.Windows.Forms.Panel pnl_Negative_duty;
        private System.Windows.Forms.Panel pnl_Positive_duty;
        private System.Windows.Forms.Panel pnl_Period;
        private System.Windows.Forms.Panel pnl_Frequency;
    }
}