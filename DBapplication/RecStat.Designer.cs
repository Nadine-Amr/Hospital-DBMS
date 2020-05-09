namespace DBapplication
{
    partial class RecStat
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BackButton = new System.Windows.Forms.Button();
            this.LogOutbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DBapplication.RecReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(326, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(3, 265);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(114, 23);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.Location = new System.Drawing.Point(203, 265);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(114, 23);
            this.LogOutbutton.TabIndex = 10;
            this.LogOutbutton.Text = "Log Out";
            this.LogOutbutton.UseVisualStyleBackColor = true;
            this.LogOutbutton.Click += new System.EventHandler(this.LogOutbutton_Click);
            // 
            // RecStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 300);
            this.Controls.Add(this.LogOutbutton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RecStat";
            this.Text = "RecStat";
            this.Load += new System.EventHandler(this.RecStat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LogOutbutton;
    }
}