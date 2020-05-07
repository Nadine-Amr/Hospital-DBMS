namespace DBapplication
{
    partial class D_RequestScan
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
            this.ScanComboBox = new System.Windows.Forms.ComboBox();
            this.PatientComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shiftStartNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.scanEndTime = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.requst_scan_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shiftStartNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ScanComboBox
            // 
            this.ScanComboBox.FormattingEnabled = true;
            this.ScanComboBox.Location = new System.Drawing.Point(179, 91);
            this.ScanComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScanComboBox.Name = "ScanComboBox";
            this.ScanComboBox.Size = new System.Drawing.Size(209, 24);
            this.ScanComboBox.TabIndex = 7;
            this.ScanComboBox.SelectedIndexChanged += new System.EventHandler(this.ScanComboBox_SelectedIndexChanged);
            // 
            // PatientComboBox
            // 
            this.PatientComboBox.FormattingEnabled = true;
            this.PatientComboBox.Location = new System.Drawing.Point(179, 37);
            this.PatientComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientComboBox.Name = "PatientComboBox";
            this.PatientComboBox.Size = new System.Drawing.Size(209, 24);
            this.PatientComboBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(68, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Scan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(68, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patient:";
            // 
            // shiftStartNumericUpDown
            // 
            this.shiftStartNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.shiftStartNumericUpDown.Location = new System.Drawing.Point(201, 161);
            this.shiftStartNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shiftStartNumericUpDown.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.shiftStartNumericUpDown.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.shiftStartNumericUpDown.Name = "shiftStartNumericUpDown";
            this.shiftStartNumericUpDown.Size = new System.Drawing.Size(45, 26);
            this.shiftStartNumericUpDown.TabIndex = 95;
            this.shiftStartNumericUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(261, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 93;
            this.label9.Text = "Scan End Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(45, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 92;
            this.label8.Text = "Scan Start Time:";
            // 
            // scanEndTime
            // 
            this.scanEndTime.AutoSize = true;
            this.scanEndTime.Location = new System.Drawing.Point(413, 170);
            this.scanEndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scanEndTime.Name = "scanEndTime";
            this.scanEndTime.Size = new System.Drawing.Size(87, 17);
            this.scanEndTime.TabIndex = 96;
            this.scanEndTime.Text = "getfromQury";
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(284, 346);
            this.logout_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(105, 27);
            this.logout_button.TabIndex = 99;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(173, 346);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(105, 27);
            this.back_button.TabIndex = 98;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // requst_scan_btn
            // 
            this.requst_scan_btn.Location = new System.Drawing.Point(212, 267);
            this.requst_scan_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requst_scan_btn.Name = "requst_scan_btn";
            this.requst_scan_btn.Size = new System.Drawing.Size(139, 25);
            this.requst_scan_btn.TabIndex = 97;
            this.requst_scan_btn.Text = "Request Scan";
            this.requst_scan_btn.UseVisualStyleBackColor = true;
            // 
            // D_RequestScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 400);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.requst_scan_btn);
            this.Controls.Add(this.scanEndTime);
            this.Controls.Add(this.shiftStartNumericUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ScanComboBox);
            this.Controls.Add(this.PatientComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "D_RequestScan";
            this.Text = "D_RequestScan";
            ((System.ComponentModel.ISupportInitialize)(this.shiftStartNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ScanComboBox;
        private System.Windows.Forms.ComboBox PatientComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown shiftStartNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label scanEndTime;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button requst_scan_btn;
    }
}