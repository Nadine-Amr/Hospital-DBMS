namespace DBapplication
{
    partial class A_ViewPatientRegistrations
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
            this.patientRegistrationGridView = new System.Windows.Forms.DataGridView();
            this.PatientRegistrationCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.view_registration_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientRegistrationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patientRegistrationGridView
            // 
            this.patientRegistrationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientRegistrationGridView.Location = new System.Drawing.Point(36, 53);
            this.patientRegistrationGridView.Name = "patientRegistrationGridView";
            this.patientRegistrationGridView.Size = new System.Drawing.Size(269, 150);
            this.patientRegistrationGridView.TabIndex = 108;
            // 
            // PatientRegistrationCombobox
            // 
            this.PatientRegistrationCombobox.FormattingEnabled = true;
            this.PatientRegistrationCombobox.Location = new System.Drawing.Point(132, 15);
            this.PatientRegistrationCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.PatientRegistrationCombobox.Name = "PatientRegistrationCombobox";
            this.PatientRegistrationCombobox.Size = new System.Drawing.Size(158, 21);
            this.PatientRegistrationCombobox.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 106;
            this.label1.Text = "Patient Name";
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(171, 265);
            this.logout_button.Margin = new System.Windows.Forms.Padding(2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(79, 22);
            this.logout_button.TabIndex = 105;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(88, 265);
            this.back_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(79, 22);
            this.back_button.TabIndex = 104;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // view_registration_btn
            // 
            this.view_registration_btn.Location = new System.Drawing.Point(117, 221);
            this.view_registration_btn.Margin = new System.Windows.Forms.Padding(2);
            this.view_registration_btn.Name = "view_registration_btn";
            this.view_registration_btn.Size = new System.Drawing.Size(104, 27);
            this.view_registration_btn.TabIndex = 103;
            this.view_registration_btn.Text = "View Regestration";
            this.view_registration_btn.UseVisualStyleBackColor = true;
            // 
            // A_ViewPatientRegistrations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 303);
            this.Controls.Add(this.patientRegistrationGridView);
            this.Controls.Add(this.PatientRegistrationCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.view_registration_btn);
            this.Name = "A_ViewPatientRegistrations";
            this.Text = "A_ViewPatientRegistrations";
            ((System.ComponentModel.ISupportInitialize)(this.patientRegistrationGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patientRegistrationGridView;
        private System.Windows.Forms.ComboBox PatientRegistrationCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button view_registration_btn;
    }
}