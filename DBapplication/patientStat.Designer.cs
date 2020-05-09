namespace DBapplication
{
    partial class patientStat
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
            this.BackButton = new System.Windows.Forms.Button();
            this.LogOutbutton = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 208);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(114, 23);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.Location = new System.Drawing.Point(159, 208);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(114, 23);
            this.LogOutbutton.TabIndex = 9;
            this.LogOutbutton.Text = "Log Out";
            this.LogOutbutton.UseVisualStyleBackColor = true;
            this.LogOutbutton.Click += new System.EventHandler(this.LogOutbutton_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DBapplication.PatientReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-5, -4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(289, 206);
            this.reportViewer1.TabIndex = 10;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // patientStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 243);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.LogOutbutton);
            this.Controls.Add(this.BackButton);
            this.Name = "patientStat";
            this.Text = "patientStat";
            this.Load += new System.EventHandler(this.patientStat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LogOutbutton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}