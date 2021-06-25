
namespace AutoDiomes
{
    partial class frmAnalytics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
            this.PnlProjectLoader = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PnlProjectLoader
            // 
            this.PnlProjectLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlProjectLoader.Location = new System.Drawing.Point(0, 0);
            this.PnlProjectLoader.Name = "PnlProjectLoader";
            this.PnlProjectLoader.Size = new System.Drawing.Size(733, 477);
            this.PnlProjectLoader.TabIndex = 0;
            // 
            // frmAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.PnlProjectLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnalytics";
            this.Text = "frmAnalytics";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel PnlProjectLoader;
    }
}