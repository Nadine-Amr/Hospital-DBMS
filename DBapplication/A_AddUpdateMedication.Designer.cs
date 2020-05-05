namespace DBapplication
{
    partial class A_AddUpdateMedication
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MedicationsComboBox = new System.Windows.Forms.ComboBox();
            this.MedicationIDTextBox = new System.Windows.Forms.TextBox();
            this.MedicationNameBox = new System.Windows.Forms.TextBox();
            this.ProceTextBox3 = new System.Windows.Forms.TextBox();
            this.ExpiaryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddMedicationButton = new System.Windows.Forms.Button();
            this.UpdateMedicationButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Medication to Update : \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medication ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Expiary Date : ";
            // 
            // MedicationsComboBox
            // 
            this.MedicationsComboBox.FormattingEnabled = true;
            this.MedicationsComboBox.Location = new System.Drawing.Point(204, 8);
            this.MedicationsComboBox.Name = "MedicationsComboBox";
            this.MedicationsComboBox.Size = new System.Drawing.Size(121, 21);
            this.MedicationsComboBox.TabIndex = 5;
            // 
            // MedicationIDTextBox
            // 
            this.MedicationIDTextBox.Location = new System.Drawing.Point(115, 48);
            this.MedicationIDTextBox.Name = "MedicationIDTextBox";
            this.MedicationIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.MedicationIDTextBox.TabIndex = 6;
            // 
            // MedicationNameBox
            // 
            this.MedicationNameBox.Location = new System.Drawing.Point(115, 82);
            this.MedicationNameBox.Name = "MedicationNameBox";
            this.MedicationNameBox.Size = new System.Drawing.Size(100, 20);
            this.MedicationNameBox.TabIndex = 7;
            // 
            // ProceTextBox3
            // 
            this.ProceTextBox3.Location = new System.Drawing.Point(115, 128);
            this.ProceTextBox3.Name = "ProceTextBox3";
            this.ProceTextBox3.Size = new System.Drawing.Size(100, 20);
            this.ProceTextBox3.TabIndex = 8;
            // 
            // ExpiaryDateTimePicker
            // 
            this.ExpiaryDateTimePicker.Location = new System.Drawing.Point(117, 162);
            this.ExpiaryDateTimePicker.Name = "ExpiaryDateTimePicker";
            this.ExpiaryDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ExpiaryDateTimePicker.TabIndex = 9;
            // 
            // AddMedicationButton
            // 
            this.AddMedicationButton.Location = new System.Drawing.Point(39, 207);
            this.AddMedicationButton.Name = "AddMedicationButton";
            this.AddMedicationButton.Size = new System.Drawing.Size(112, 23);
            this.AddMedicationButton.TabIndex = 10;
            this.AddMedicationButton.Text = "Add Medication";
            this.AddMedicationButton.UseVisualStyleBackColor = true;
            this.AddMedicationButton.Click += new System.EventHandler(this.AddMedicationButton_Click);
            // 
            // UpdateMedicationButton
            // 
            this.UpdateMedicationButton.Location = new System.Drawing.Point(232, 207);
            this.UpdateMedicationButton.Name = "UpdateMedicationButton";
            this.UpdateMedicationButton.Size = new System.Drawing.Size(112, 23);
            this.UpdateMedicationButton.TabIndex = 11;
            this.UpdateMedicationButton.Text = "Update Medication";
            this.UpdateMedicationButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(39, 246);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(112, 23);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(232, 246);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(112, 23);
            this.LogOutButton.TabIndex = 13;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            // 
            // A_AddUpdateMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 279);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.UpdateMedicationButton);
            this.Controls.Add(this.AddMedicationButton);
            this.Controls.Add(this.ExpiaryDateTimePicker);
            this.Controls.Add(this.ProceTextBox3);
            this.Controls.Add(this.MedicationNameBox);
            this.Controls.Add(this.MedicationIDTextBox);
            this.Controls.Add(this.MedicationsComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "A_AddUpdateMedication";
            this.Text = "A_AddUpdateMedication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MedicationsComboBox;
        private System.Windows.Forms.TextBox MedicationIDTextBox;
        private System.Windows.Forms.TextBox MedicationNameBox;
        private System.Windows.Forms.TextBox ProceTextBox3;
        private System.Windows.Forms.DateTimePicker ExpiaryDateTimePicker;
        private System.Windows.Forms.Button AddMedicationButton;
        private System.Windows.Forms.Button UpdateMedicationButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button LogOutButton;
    }
}