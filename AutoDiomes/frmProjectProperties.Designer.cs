
namespace AutoDiomes
{
    partial class frmProjectProperties
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
            this.components = new System.ComponentModel.Container();
            this.StateText = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBox_phase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_customer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBox_hardware = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_software = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_serial_number = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBox_error_margin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbox_testtype = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBox_config_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.file_date = new System.Windows.Forms.MonthCalendar();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // StateText
            // 
            this.StateText.AutoSize = true;
            this.StateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.StateText.Location = new System.Drawing.Point(12, 9);
            this.StateText.Name = "StateText";
            this.StateText.Size = new System.Drawing.Size(259, 32);
            this.StateText.TabIndex = 14;
            this.StateText.Text = "Création du projet";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.txtBox_phase);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtBox_customer);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtBox_name);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(446, 150);
            this.panel4.TabIndex = 15;
            // 
            // txtBox_phase
            // 
            this.txtBox_phase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtBox_phase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_phase.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_phase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBox_phase.Location = new System.Drawing.Point(215, 110);
            this.txtBox_phase.Name = "txtBox_phase";
            this.txtBox_phase.Size = new System.Drawing.Size(212, 25);
            this.txtBox_phase.TabIndex = 10;
            this.txtBox_phase.Text = "A1, A2, B1, C1...";
            this.txtBox_phase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_phase.Click += new System.EventHandler(this.TxtBox_phase_Click);
            this.txtBox_phase.Leave += new System.EventHandler(this.TxtBox_phase_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::AutoDiomes.Properties.Resources.state;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(36, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phase :        ";
            // 
            // txtBox_customer
            // 
            this.txtBox_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtBox_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_customer.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBox_customer.Location = new System.Drawing.Point(215, 80);
            this.txtBox_customer.Name = "txtBox_customer";
            this.txtBox_customer.Size = new System.Drawing.Size(212, 25);
            this.txtBox_customer.TabIndex = 8;
            this.txtBox_customer.Text = "FORD, RENAULT...";
            this.txtBox_customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_customer.Click += new System.EventHandler(this.TxtBox_customer_Click);
            this.txtBox_customer.Leave += new System.EventHandler(this.TxtBox_customer_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::AutoDiomes.Properties.Resources.partner;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Client :        ";
            // 
            // txtBox_name
            // 
            this.txtBox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtBox_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_name.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBox_name.Location = new System.Drawing.Point(215, 48);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(212, 25);
            this.txtBox_name.TabIndex = 6;
            this.txtBox_name.Text = "EMS2910, EMS3191...";
            this.txtBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_name.Click += new System.EventHandler(this.TxtBox_name_Click);
            this.txtBox_name.Leave += new System.EventHandler(this.TxtBox_name_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Projet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = global::AutoDiomes.Properties.Resources.project1;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(36, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nom du projet :       ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtBox_hardware);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBox_software);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBox_serial_number);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 150);
            this.panel1.TabIndex = 16;
            // 
            // txtBox_hardware
            // 
            this.txtBox_hardware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtBox_hardware.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_hardware.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_hardware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBox_hardware.Location = new System.Drawing.Point(215, 110);
            this.txtBox_hardware.Name = "txtBox_hardware";
            this.txtBox_hardware.Size = new System.Drawing.Size(212, 25);
            this.txtBox_hardware.TabIndex = 10;
            this.txtBox_hardware.Text = "HW1, HW2...";
            this.txtBox_hardware.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_hardware.Click += new System.EventHandler(this.TxtBox_hardware_Click);
            this.txtBox_hardware.Leave += new System.EventHandler(this.TxtBox_hardware_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = global::AutoDiomes.Properties.Resources.hardware;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(36, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hardware :        ";
            // 
            // txtBox_software
            // 
            this.txtBox_software.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtBox_software.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_software.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_software.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBox_software.Location = new System.Drawing.Point(215, 80);
            this.txtBox_software.Name = "txtBox_software";
            this.txtBox_software.Size = new System.Drawing.Size(212, 25);
            this.txtBox_software.TabIndex = 8;
            this.txtBox_software.Text = "SW410, 210...";
            this.txtBox_software.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_software.Click += new System.EventHandler(this.TxtBox_software_Click);
            this.txtBox_software.Leave += new System.EventHandler(this.TxtBox_software_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = global::AutoDiomes.Properties.Resources.software;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(36, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Software :         ";
            // 
            // txtBox_serial_number
            // 
            this.txtBox_serial_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtBox_serial_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_serial_number.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_serial_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBox_serial_number.Location = new System.Drawing.Point(215, 48);
            this.txtBox_serial_number.Name = "txtBox_serial_number";
            this.txtBox_serial_number.Size = new System.Drawing.Size(212, 25);
            this.txtBox_serial_number.TabIndex = 6;
            this.txtBox_serial_number.Text = "410000265, ...";
            this.txtBox_serial_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_serial_number.Click += new System.EventHandler(this.TxtBox_serial_number_Click);
            this.txtBox_serial_number.Leave += new System.EventHandler(this.TxtBox_serial_number_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label7.Location = new System.Drawing.Point(24, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Produit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Image = global::AutoDiomes.Properties.Resources.barcode;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(36, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Numéro de série :       ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.txtBox_error_margin);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cmbox_testtype);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(12, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 98);
            this.panel2.TabIndex = 17;
            // 
            // txtBox_error_margin
            // 
            this.txtBox_error_margin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtBox_error_margin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_error_margin.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_error_margin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBox_error_margin.Location = new System.Drawing.Point(215, 57);
            this.txtBox_error_margin.Name = "txtBox_error_margin";
            this.txtBox_error_margin.Size = new System.Drawing.Size(212, 25);
            this.txtBox_error_margin.TabIndex = 11;
            this.txtBox_error_margin.Text = "1%, 5%, 10%...";
            this.txtBox_error_margin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_error_margin.Click += new System.EventHandler(this.TxtBox_error_margin_Click);
            this.txtBox_error_margin.Leave += new System.EventHandler(this.TxtBox_error_margin_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Image = global::AutoDiomes.Properties.Resources.error;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(36, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 21);
            this.label13.TabIndex = 10;
            this.label13.Text = "Marge d\'erreur       ";
            // 
            // cmbox_testtype
            // 
            this.cmbox_testtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cmbox_testtype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbox_testtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_testtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_testtype.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox_testtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.cmbox_testtype.FormattingEnabled = true;
            this.cmbox_testtype.Items.AddRange(new object[] {
            "CEM",
            "ELEC",
            "Autres"});
            this.cmbox_testtype.Location = new System.Drawing.Point(215, 16);
            this.cmbox_testtype.Margin = new System.Windows.Forms.Padding(0);
            this.cmbox_testtype.Name = "cmbox_testtype";
            this.cmbox_testtype.Size = new System.Drawing.Size(150, 28);
            this.cmbox_testtype.TabIndex = 5;
            this.cmbox_testtype.SelectedIndexChanged += new System.EventHandler(this.Cmbox_testtype_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Image = global::AutoDiomes.Properties.Resources.test;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(36, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 21);
            this.label12.TabIndex = 4;
            this.label12.Text = "Type de test :       ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.txtBox_config_name);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.file_date);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(474, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 291);
            this.panel3.TabIndex = 18;
            // 
            // txtBox_config_name
            // 
            this.txtBox_config_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtBox_config_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_config_name.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_config_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBox_config_name.Location = new System.Drawing.Point(11, 252);
            this.txtBox_config_name.Name = "txtBox_config_name";
            this.txtBox_config_name.Size = new System.Drawing.Size(224, 25);
            this.txtBox_config_name.TabIndex = 7;
            this.txtBox_config_name.Text = "EMS2910_CEMV1...";
            this.txtBox_config_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_config_name.Click += new System.EventHandler(this.TxtBox_config_name_Click);
            this.txtBox_config_name.Leave += new System.EventHandler(this.TxtBox_config_name_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Image = global::AutoDiomes.Properties.Resources.name_file;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(7, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nom de la configuration :       ";
            // 
            // file_date
            // 
            this.file_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.file_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.file_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.file_date.Location = new System.Drawing.Point(11, 48);
            this.file_date.MaxSelectionCount = 1;
            this.file_date.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.file_date.Name = "file_date";
            this.file_date.TabIndex = 5;
            this.file_date.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.file_date.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.file_date.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Image = global::AutoDiomes.Properties.Resources.calendar;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(46, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Date du fichier :       ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panel5.Controls.Add(this.label11);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(475, 413);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 52);
            this.panel5.TabIndex = 19;
            this.panel5.Click += new System.EventHandler(this.Panel5_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Image = global::AutoDiomes.Properties.Resources.signal;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(11, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Configuration des signaux :        ";
            this.label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panel6.Controls.Add(this.label14);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Location = new System.Drawing.Point(475, 352);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(246, 55);
            this.panel6.TabIndex = 22;
            this.panel6.Click += new System.EventHandler(this.Panel6_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Image = global::AutoDiomes.Properties.Resources.cross;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(75, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "Annuler        ";
            this.label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frmProjectProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.StateText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProjectProperties";
            this.Text = "frmProjectProperties";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StateText;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_customer;
        private System.Windows.Forms.TextBox txtBox_phase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBox_hardware;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_software;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_serial_number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbox_testtype;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MonthCalendar file_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBox_config_name;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBox_error_margin;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer1;
    }
}