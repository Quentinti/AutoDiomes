
namespace AutoDiomes
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pnlLastMesure = new System.Windows.Forms.Panel();
            this.lblLastMesure_TONTOFF = new System.Windows.Forms.Label();
            this.lblLastMesure_Duty = new System.Windows.Forms.Label();
            this.lblLastMesure_Period = new System.Windows.Forms.Label();
            this.lblLastMesure_Frequency = new System.Windows.Forms.Label();
            this.pnlScope = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlCurrentMesure = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlProject = new System.Windows.Forms.Panel();
            this.lblProject_Phase = new System.Windows.Forms.Label();
            this.lblProject_Name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNextState = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlWaitingConfig = new System.Windows.Forms.Panel();
            this.lblOverflow = new System.Windows.Forms.Label();
            this.pnlPuddle = new System.Windows.Forms.Panel();
            this.pnlRain = new System.Windows.Forms.Panel();
            this.pbRain7 = new System.Windows.Forms.PictureBox();
            this.pbRain8 = new System.Windows.Forms.PictureBox();
            this.pbRain6 = new System.Windows.Forms.PictureBox();
            this.pbRain5 = new System.Windows.Forms.PictureBox();
            this.pbRain4 = new System.Windows.Forms.PictureBox();
            this.pbRain3 = new System.Windows.Forms.PictureBox();
            this.pbRain2 = new System.Windows.Forms.PictureBox();
            this.pbRain1 = new System.Windows.Forms.PictureBox();
            this.pbPuddle = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentWaitingState = new System.Windows.Forms.Label();
            this.lblConfigState = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlLastMesure.SuspendLayout();
            this.pnlScope.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlCurrentMesure.SuspendLayout();
            this.pnlProject.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlWaitingConfig.SuspendLayout();
            this.pnlRain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPuddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLastMesure
            // 
            this.pnlLastMesure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlLastMesure.Controls.Add(this.lblLastMesure_TONTOFF);
            this.pnlLastMesure.Controls.Add(this.lblLastMesure_Duty);
            this.pnlLastMesure.Controls.Add(this.lblLastMesure_Period);
            this.pnlLastMesure.Controls.Add(this.lblLastMesure_Frequency);
            this.pnlLastMesure.Location = new System.Drawing.Point(533, 5);
            this.pnlLastMesure.Name = "pnlLastMesure";
            this.pnlLastMesure.Size = new System.Drawing.Size(189, 130);
            this.pnlLastMesure.TabIndex = 9;
            // 
            // lblLastMesure_TONTOFF
            // 
            this.lblLastMesure_TONTOFF.AutoSize = true;
            this.lblLastMesure_TONTOFF.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMesure_TONTOFF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblLastMesure_TONTOFF.Location = new System.Drawing.Point(9, 96);
            this.lblLastMesure_TONTOFF.Name = "lblLastMesure_TONTOFF";
            this.lblLastMesure_TONTOFF.Size = new System.Drawing.Size(175, 20);
            this.lblLastMesure_TONTOFF.TabIndex = 6;
            this.lblLastMesure_TONTOFF.Text = "TON : NVms / TOFF NVms";
            // 
            // lblLastMesure_Duty
            // 
            this.lblLastMesure_Duty.AutoSize = true;
            this.lblLastMesure_Duty.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMesure_Duty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblLastMesure_Duty.Location = new System.Drawing.Point(9, 67);
            this.lblLastMesure_Duty.Name = "lblLastMesure_Duty";
            this.lblLastMesure_Duty.Size = new System.Drawing.Size(111, 21);
            this.lblLastMesure_Duty.TabIndex = 5;
            this.lblLastMesure_Duty.Text = "+NV% / -NV%";
            // 
            // lblLastMesure_Period
            // 
            this.lblLastMesure_Period.AutoSize = true;
            this.lblLastMesure_Period.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMesure_Period.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblLastMesure_Period.Location = new System.Drawing.Point(9, 42);
            this.lblLastMesure_Period.Name = "lblLastMesure_Period";
            this.lblLastMesure_Period.Size = new System.Drawing.Size(52, 21);
            this.lblLastMesure_Period.TabIndex = 4;
            this.lblLastMesure_Period.Text = "NVms";
            // 
            // lblLastMesure_Frequency
            // 
            this.lblLastMesure_Frequency.AutoSize = true;
            this.lblLastMesure_Frequency.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMesure_Frequency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblLastMesure_Frequency.Location = new System.Drawing.Point(9, 16);
            this.lblLastMesure_Frequency.Name = "lblLastMesure_Frequency";
            this.lblLastMesure_Frequency.Size = new System.Drawing.Size(50, 21);
            this.lblLastMesure_Frequency.TabIndex = 3;
            this.lblLastMesure_Frequency.Text = "NVHz";
            // 
            // pnlScope
            // 
            this.pnlScope.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlScope.Controls.Add(this.pictureBox2);
            this.pnlScope.Controls.Add(this.label13);
            this.pnlScope.Location = new System.Drawing.Point(285, 147);
            this.pnlScope.Name = "pnlScope";
            this.pnlScope.Size = new System.Drawing.Size(437, 306);
            this.pnlScope.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AutoDiomes.Properties.Resources.chart_diagram;
            this.pictureBox2.Location = new System.Drawing.Point(18, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(390, 234);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(13, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(335, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Informations sur le signal précédent    ";
            // 
            // pnlCurrentMesure
            // 
            this.pnlCurrentMesure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlCurrentMesure.Controls.Add(this.label8);
            this.pnlCurrentMesure.Controls.Add(this.circularProgressBar1);
            this.pnlCurrentMesure.Controls.Add(this.label9);
            this.pnlCurrentMesure.Controls.Add(this.label10);
            this.pnlCurrentMesure.Location = new System.Drawing.Point(10, 147);
            this.pnlCurrentMesure.Name = "pnlCurrentMesure";
            this.pnlCurrentMesure.Size = new System.Drawing.Size(258, 306);
            this.pnlCurrentMesure.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label8.Location = new System.Drawing.Point(14, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Signal : ECBV_11";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar1.AnimationFunction")));
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(50, 99);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(249)))));
            this.circularProgressBar1.ProgressWidth = 7;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 2;
            this.circularProgressBar1.Text = "24%";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.label9.Location = new System.Drawing.Point(12, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "15/72";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(13, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "État de la mesure      ";
            // 
            // pnlProject
            // 
            this.pnlProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlProject.Controls.Add(this.lblProject_Phase);
            this.pnlProject.Controls.Add(this.lblProject_Name);
            this.pnlProject.Controls.Add(this.label7);
            this.pnlProject.Location = new System.Drawing.Point(285, 5);
            this.pnlProject.Name = "pnlProject";
            this.pnlProject.Size = new System.Drawing.Size(232, 130);
            this.pnlProject.TabIndex = 8;
            // 
            // lblProject_Phase
            // 
            this.lblProject_Phase.AutoSize = true;
            this.lblProject_Phase.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject_Phase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblProject_Phase.Location = new System.Drawing.Point(14, 96);
            this.lblProject_Phase.Name = "lblProject_Phase";
            this.lblProject_Phase.Size = new System.Drawing.Size(83, 21);
            this.lblProject_Phase.TabIndex = 2;
            this.lblProject_Phase.Text = "Non défini";
            // 
            // lblProject_Name
            // 
            this.lblProject_Name.AutoSize = true;
            this.lblProject_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.lblProject_Name.Location = new System.Drawing.Point(12, 53);
            this.lblProject_Name.Name = "lblProject_Name";
            this.lblProject_Name.Size = new System.Drawing.Size(154, 32);
            this.lblProject_Name.TabIndex = 1;
            this.lblProject_Name.Text = "Non défini";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = global::AutoDiomes.Properties.Resources.project;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(13, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nom du projet             ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.lblNextState);
            this.panel4.Controls.Add(this.lblState);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(10, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 130);
            this.panel4.TabIndex = 5;
            // 
            // lblNextState
            // 
            this.lblNextState.AutoSize = true;
            this.lblNextState.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblNextState.Location = new System.Drawing.Point(14, 96);
            this.lblNextState.Name = "lblNextState";
            this.lblNextState.Size = new System.Drawing.Size(156, 21);
            this.lblNextState.TabIndex = 2;
            this.lblNextState.Text = "Connexion en cours...";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.lblState.Location = new System.Drawing.Point(12, 53);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(177, 32);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "Déconnecté";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = global::AutoDiomes.Properties.Resources.link;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "État de la connexion        ";
            // 
            // pnlWaitingConfig
            // 
            this.pnlWaitingConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlWaitingConfig.Controls.Add(this.lblOverflow);
            this.pnlWaitingConfig.Controls.Add(this.pnlPuddle);
            this.pnlWaitingConfig.Controls.Add(this.pnlRain);
            this.pnlWaitingConfig.Controls.Add(this.pbPuddle);
            this.pnlWaitingConfig.Controls.Add(this.pictureBox1);
            this.pnlWaitingConfig.Controls.Add(this.lblCurrentWaitingState);
            this.pnlWaitingConfig.Controls.Add(this.lblConfigState);
            this.pnlWaitingConfig.Location = new System.Drawing.Point(10, 147);
            this.pnlWaitingConfig.Name = "pnlWaitingConfig";
            this.pnlWaitingConfig.Size = new System.Drawing.Size(711, 323);
            this.pnlWaitingConfig.TabIndex = 10;
            // 
            // lblOverflow
            // 
            this.lblOverflow.AutoSize = true;
            this.lblOverflow.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverflow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblOverflow.Location = new System.Drawing.Point(467, 291);
            this.lblOverflow.Name = "lblOverflow";
            this.lblOverflow.Size = new System.Drawing.Size(176, 21);
            this.lblOverflow.TabIndex = 8;
            this.lblOverflow.Text = "Attention ! Ça déborde...";
            // 
            // pnlPuddle
            // 
            this.pnlPuddle.Location = new System.Drawing.Point(275, 282);
            this.pnlPuddle.Name = "pnlPuddle";
            this.pnlPuddle.Size = new System.Drawing.Size(174, 35);
            this.pnlPuddle.TabIndex = 7;
            // 
            // pnlRain
            // 
            this.pnlRain.Controls.Add(this.pbRain7);
            this.pnlRain.Controls.Add(this.pbRain8);
            this.pnlRain.Controls.Add(this.pbRain6);
            this.pnlRain.Controls.Add(this.pbRain5);
            this.pnlRain.Controls.Add(this.pbRain4);
            this.pnlRain.Controls.Add(this.pbRain3);
            this.pnlRain.Controls.Add(this.pbRain2);
            this.pnlRain.Controls.Add(this.pbRain1);
            this.pnlRain.Location = new System.Drawing.Point(264, 176);
            this.pnlRain.Name = "pnlRain";
            this.pnlRain.Size = new System.Drawing.Size(185, 100);
            this.pnlRain.TabIndex = 6;
            // 
            // pbRain7
            // 
            this.pbRain7.Image = global::AutoDiomes.Properties.Resources.rain_L;
            this.pbRain7.Location = new System.Drawing.Point(130, 34);
            this.pbRain7.Name = "pbRain7";
            this.pbRain7.Size = new System.Drawing.Size(10, 30);
            this.pbRain7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRain7.TabIndex = 7;
            this.pbRain7.TabStop = false;
            // 
            // pbRain8
            // 
            this.pbRain8.Image = global::AutoDiomes.Properties.Resources.rain_L;
            this.pbRain8.Location = new System.Drawing.Point(148, 3);
            this.pbRain8.Name = "pbRain8";
            this.pbRain8.Size = new System.Drawing.Size(20, 50);
            this.pbRain8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRain8.TabIndex = 6;
            this.pbRain8.TabStop = false;
            // 
            // pbRain6
            // 
            this.pbRain6.Image = global::AutoDiomes.Properties.Resources.rain_L;
            this.pbRain6.Location = new System.Drawing.Point(114, 13);
            this.pbRain6.Name = "pbRain6";
            this.pbRain6.Size = new System.Drawing.Size(10, 30);
            this.pbRain6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRain6.TabIndex = 5;
            this.pbRain6.TabStop = false;
            // 
            // pbRain5
            // 
            this.pbRain5.Image = global::AutoDiomes.Properties.Resources.rain_L;
            this.pbRain5.Location = new System.Drawing.Point(98, 34);
            this.pbRain5.Name = "pbRain5";
            this.pbRain5.Size = new System.Drawing.Size(10, 43);
            this.pbRain5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRain5.TabIndex = 4;
            this.pbRain5.TabStop = false;
            // 
            // pbRain4
            // 
            this.pbRain4.Image = global::AutoDiomes.Properties.Resources.rain_L;
            this.pbRain4.Location = new System.Drawing.Point(82, 13);
            this.pbRain4.Name = "pbRain4";
            this.pbRain4.Size = new System.Drawing.Size(10, 30);
            this.pbRain4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRain4.TabIndex = 3;
            this.pbRain4.TabStop = false;
            // 
            // pbRain3
            // 
            this.pbRain3.Image = global::AutoDiomes.Properties.Resources.rain_L;
            this.pbRain3.Location = new System.Drawing.Point(56, 34);
            this.pbRain3.Name = "pbRain3";
            this.pbRain3.Size = new System.Drawing.Size(20, 50);
            this.pbRain3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRain3.TabIndex = 2;
            this.pbRain3.TabStop = false;
            // 
            // pbRain2
            // 
            this.pbRain2.Image = global::AutoDiomes.Properties.Resources.rain_L;
            this.pbRain2.Location = new System.Drawing.Point(40, 34);
            this.pbRain2.Name = "pbRain2";
            this.pbRain2.Size = new System.Drawing.Size(10, 30);
            this.pbRain2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRain2.TabIndex = 1;
            this.pbRain2.TabStop = false;
            // 
            // pbRain1
            // 
            this.pbRain1.Image = global::AutoDiomes.Properties.Resources.rain_L;
            this.pbRain1.Location = new System.Drawing.Point(14, 3);
            this.pbRain1.Name = "pbRain1";
            this.pbRain1.Size = new System.Drawing.Size(20, 50);
            this.pbRain1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRain1.TabIndex = 0;
            this.pbRain1.TabStop = false;
            // 
            // pbPuddle
            // 
            this.pbPuddle.Image = global::AutoDiomes.Properties.Resources.puddle;
            this.pbPuddle.Location = new System.Drawing.Point(277, 282);
            this.pbPuddle.Name = "pbPuddle";
            this.pbPuddle.Size = new System.Drawing.Size(164, 36);
            this.pbPuddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPuddle.TabIndex = 5;
            this.pbPuddle.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoDiomes.Properties.Resources.cloud;
            this.pictureBox1.Location = new System.Drawing.Point(264, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentWaitingState
            // 
            this.lblCurrentWaitingState.AutoSize = true;
            this.lblCurrentWaitingState.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWaitingState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblCurrentWaitingState.Location = new System.Drawing.Point(205, 54);
            this.lblCurrentWaitingState.Name = "lblCurrentWaitingState";
            this.lblCurrentWaitingState.Size = new System.Drawing.Size(311, 21);
            this.lblCurrentWaitingState.TabIndex = 3;
            this.lblCurrentWaitingState.Text = "Création ou ouverture de projet en attente...";
            this.lblCurrentWaitingState.Click += new System.EventHandler(this.LblCurrentWaitingState_Click);
            // 
            // lblConfigState
            // 
            this.lblConfigState.AutoSize = true;
            this.lblConfigState.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigState.ForeColor = System.Drawing.Color.Red;
            this.lblConfigState.Location = new System.Drawing.Point(158, 16);
            this.lblConfigState.Name = "lblConfigState";
            this.lblConfigState.Size = new System.Drawing.Size(410, 32);
            this.lblConfigState.TabIndex = 2;
            this.lblConfigState.Text = "En attente de configuration...";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.pnlWaitingConfig);
            this.Controls.Add(this.pnlCurrentMesure);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlProject);
            this.Controls.Add(this.pnlLastMesure);
            this.Controls.Add(this.pnlScope);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.pnlLastMesure.ResumeLayout(false);
            this.pnlLastMesure.PerformLayout();
            this.pnlScope.ResumeLayout(false);
            this.pnlScope.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlCurrentMesure.ResumeLayout(false);
            this.pnlCurrentMesure.PerformLayout();
            this.pnlProject.ResumeLayout(false);
            this.pnlProject.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlWaitingConfig.ResumeLayout(false);
            this.pnlWaitingConfig.PerformLayout();
            this.pnlRain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRain7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRain1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPuddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLastMesure;
        private System.Windows.Forms.Label lblLastMesure_TONTOFF;
        private System.Windows.Forms.Label lblLastMesure_Duty;
        private System.Windows.Forms.Label lblLastMesure_Period;
        private System.Windows.Forms.Label lblLastMesure_Frequency;
        private System.Windows.Forms.Panel pnlScope;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlCurrentMesure;
        private System.Windows.Forms.Label label8;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlProject;
        private System.Windows.Forms.Label lblProject_Phase;
        private System.Windows.Forms.Label lblProject_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNextState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlWaitingConfig;
        private System.Windows.Forms.Label lblCurrentWaitingState;
        private System.Windows.Forms.Label lblConfigState;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbPuddle;
        private System.Windows.Forms.Panel pnlRain;
        private System.Windows.Forms.PictureBox pbRain1;
        private System.Windows.Forms.PictureBox pbRain8;
        private System.Windows.Forms.PictureBox pbRain6;
        private System.Windows.Forms.PictureBox pbRain5;
        private System.Windows.Forms.PictureBox pbRain4;
        private System.Windows.Forms.PictureBox pbRain3;
        private System.Windows.Forms.PictureBox pbRain2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbRain7;
        private System.Windows.Forms.Panel pnlPuddle;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblOverflow;
    }
}