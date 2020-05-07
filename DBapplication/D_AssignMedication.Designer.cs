namespace DBapplication
{
    partial class D_AssignMedication
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
            this.logout_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.assign_medication = new System.Windows.Forms.Button();
            this.MedicationComboBox = new System.Windows.Forms.ComboBox();
            this.PatientComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.assignDosageChkBox = new System.Windows.Forms.CheckBox();
            this.DosageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DosageNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(191, 286);
            this.logout_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(79, 22);
            this.logout_button.TabIndex = 30;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(107, 286);
            this.back_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(79, 22);
            this.back_button.TabIndex = 29;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // assign_medication
            // 
            this.assign_medication.Location = new System.Drawing.Point(137, 238);
            this.assign_medication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.assign_medication.Name = "assign_medication";
            this.assign_medication.Size = new System.Drawing.Size(104, 20);
            this.assign_medication.TabIndex = 28;
            this.assign_medication.Text = "Assign Medication";
            this.assign_medication.UseVisualStyleBackColor = true;
            this.assign_medication.Click += new System.EventHandler(this.assign_medication_Click);
            // 
            // MedicationComboBox
            // 
            this.MedicationComboBox.FormattingEnabled = true;
            this.MedicationComboBox.Location = new System.Drawing.Point(198, 72);
            this.MedicationComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MedicationComboBox.Name = "MedicationComboBox";
            this.MedicationComboBox.Size = new System.Drawing.Size(158, 21);
            this.MedicationComboBox.TabIndex = 34;
            // 
            // PatientComboBox
            // 
            this.PatientComboBox.FormattingEnabled = true;
            this.PatientComboBox.Location = new System.Drawing.Point(198, 28);
            this.PatientComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PatientComboBox.Name = "PatientComboBox";
            this.PatientComboBox.Size = new System.Drawing.Size(158, 21);
            this.PatientComboBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Medication";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Patient:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(31, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Dosage";
            // 
            // assignDosageChkBox
            // 
            this.assignDosageChkBox.AutoSize = true;
            this.assignDosageChkBox.Checked = true;
            this.assignDosageChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.assignDosageChkBox.Location = new System.Drawing.Point(92, 123);
            this.assignDosageChkBox.Name = "assignDosageChkBox";
            this.assignDosageChkBox.Size = new System.Drawing.Size(97, 17);
            this.assignDosageChkBox.TabIndex = 37;
            this.assignDosageChkBox.Text = "Assign Dosage";
            this.assignDosageChkBox.UseVisualStyleBackColor = true;
            // 
            // DosageNumericUpDown
            // 
            this.DosageNumericUpDown.Location = new System.Drawing.Point(198, 120);
            this.DosageNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.DosageNumericUpDown.Name = "DosageNumericUpDown";
            this.DosageNumericUpDown.Size = new System.Drawing.Size(158, 20);
            this.DosageNumericUpDown.TabIndex = 38;
            // 
            // D_AssignMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 331);
            this.Controls.Add(this.DosageNumericUpDown);
            this.Controls.Add(this.assignDosageChkBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MedicationComboBox);
            this.Controls.Add(this.PatientComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.assign_medication);
            this.Name = "D_AssignMedication";
            this.Text = "D_AssignMedication";
            this.Load += new System.EventHandler(this.D_AssignMedication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DosageNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button assign_medication;
        private System.Windows.Forms.ComboBox MedicationComboBox;
        private System.Windows.Forms.ComboBox PatientComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox assignDosageChkBox;
        private System.Windows.Forms.NumericUpDown DosageNumericUpDown;
    }
}