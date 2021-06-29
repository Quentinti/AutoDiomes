
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
            this.lblConfigState = new System.Windows.Forms.Label();
            this.lblCurrentWaitingState = new System.Windows.Forms.Label();
            this.pnlLastMesure.SuspendLayout();
            this.pnlScope.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlCurrentMesure.SuspendLayout();
            this.pnlProject.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlWaitingConfig.SuspendLayout();
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
            this.pnlWaitingConfig.Controls.Add(this.lblCurrentWaitingState);
            this.pnlWaitingConfig.Controls.Add(this.lblConfigState);
            this.pnlWaitingConfig.Location = new System.Drawing.Point(10, 147);
            this.pnlWaitingConfig.Name = "pnlWaitingConfig";
            this.pnlWaitingConfig.Size = new System.Drawing.Size(711, 306);
            this.pnlWaitingConfig.TabIndex = 10;
            // 
            // lblConfigState
            // 
            this.lblConfigState.AutoSize = true;
            this.lblConfigState.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigState.ForeColor = System.Drawing.Color.Red;
            this.lblConfigState.Location = new System.Drawing.Point(158, 19);
            this.lblConfigState.Name = "lblConfigState";
            this.lblConfigState.Size = new System.Drawing.Size(410, 32);
            this.lblConfigState.TabIndex = 2;
            this.lblConfigState.Text = "En attente de configuration...";
            // 
            // lblCurrentWaitingState
            // 
            this.lblCurrentWaitingState.AutoSize = true;
            this.lblCurrentWaitingState.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWaitingState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblCurrentWaitingState.Location = new System.Drawing.Point(205, 64);
            this.lblCurrentWaitingState.Name = "lblCurrentWaitingState";
            this.lblCurrentWaitingState.Size = new System.Drawing.Size(311, 21);
            this.lblCurrentWaitingState.TabIndex = 3;
            this.lblCurrentWaitingState.Text = "Création ou ouverture de projet en attente...";
            this.lblCurrentWaitingState.Click += new System.EventHandler(this.lblCurrentWaitingState_Click);
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
    }
}