﻿namespace DBapplication
{
    partial class ViewsAndStatisticsForm
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
            this.LogOutbutton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.DoctorStatButton = new System.Windows.Forms.Button();
            this.patientStatsButton = new System.Windows.Forms.Button();
            this.ScanStatButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MedicineStatDutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.Location = new System.Drawing.Point(337, 403);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(114, 23);
            this.LogOutbutton.TabIndex = 5;
            this.LogOutbutton.Text = "Log Out";
            this.LogOutbutton.UseVisualStyleBackColor = true;
            this.LogOutbutton.Click += new System.EventHandler(this.LogOutbutton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 403);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(114, 23);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DoctorStatButton
            // 
            this.DoctorStatButton.Location = new System.Drawing.Point(17, 48);
            this.DoctorStatButton.Name = "DoctorStatButton";
            this.DoctorStatButton.Size = new System.Drawing.Size(135, 23);
            this.DoctorStatButton.TabIndex = 7;
            this.DoctorStatButton.Text = "Doctor Statistics";
            this.DoctorStatButton.UseVisualStyleBackColor = true;
            this.DoctorStatButton.Click += new System.EventHandler(this.DoctorStatButton_Click);
            // 
            // patientStatsButton
            // 
            this.patientStatsButton.Location = new System.Drawing.Point(17, 217);
            this.patientStatsButton.Name = "patientStatsButton";
            this.patientStatsButton.Size = new System.Drawing.Size(135, 23);
            this.patientStatsButton.TabIndex = 8;
            this.patientStatsButton.Text = "Patient Statistics";
            this.patientStatsButton.UseVisualStyleBackColor = true;
            this.patientStatsButton.Click += new System.EventHandler(this.patientStatsButton_Click);
            // 
            // ScanStatButton
            // 
            this.ScanStatButton.Location = new System.Drawing.Point(316, 48);
            this.ScanStatButton.Name = "ScanStatButton";
            this.ScanStatButton.Size = new System.Drawing.Size(135, 23);
            this.ScanStatButton.TabIndex = 9;
            this.ScanStatButton.Text = "Scan Statistics";
            this.ScanStatButton.UseVisualStyleBackColor = true;
            this.ScanStatButton.Click += new System.EventHandler(this.ScanStatButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(316, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Receptionists Statistics";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MedicineStatDutton
            // 
            this.MedicineStatDutton.Location = new System.Drawing.Point(154, 127);
            this.MedicineStatDutton.Name = "MedicineStatDutton";
            this.MedicineStatDutton.Size = new System.Drawing.Size(135, 23);
            this.MedicineStatDutton.TabIndex = 11;
            this.MedicineStatDutton.Text = "Medicine Statistics";
            this.MedicineStatDutton.UseVisualStyleBackColor = true;
            this.MedicineStatDutton.Click += new System.EventHandler(this.MedicineStatDutton_Click);
            // 
            // ViewsAndStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.MedicineStatDutton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ScanStatButton);
            this.Controls.Add(this.patientStatsButton);
            this.Controls.Add(this.DoctorStatButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LogOutbutton);
            this.Name = "ViewsAndStatisticsForm";
            this.Text = "ViewsAndStatisticsForm";
            this.Load += new System.EventHandler(this.ViewsAndStatisticsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LogOutbutton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DoctorStatButton;
        private System.Windows.Forms.Button patientStatsButton;
        private System.Windows.Forms.Button ScanStatButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button MedicineStatDutton;
    }
}