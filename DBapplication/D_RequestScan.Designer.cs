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
            this.logout_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.requst_scan_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScanComboBox
            // 
            this.ScanComboBox.FormattingEnabled = true;
            this.ScanComboBox.Location = new System.Drawing.Point(134, 74);
            this.ScanComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ScanComboBox.Name = "ScanComboBox";
            this.ScanComboBox.Size = new System.Drawing.Size(158, 21);
            this.ScanComboBox.TabIndex = 7;
            this.ScanComboBox.SelectedIndexChanged += new System.EventHandler(this.ScanComboBox_SelectedIndexChanged);
            // 
            // PatientComboBox
            // 
            this.PatientComboBox.FormattingEnabled = true;
            this.PatientComboBox.Location = new System.Drawing.Point(134, 30);
            this.PatientComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PatientComboBox.Name = "PatientComboBox";
            this.PatientComboBox.Size = new System.Drawing.Size(158, 21);
            this.PatientComboBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(51, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Scan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patient:";
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(280, 260);
            this.logout_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(79, 22);
            this.logout_button.TabIndex = 99;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(80, 260);
            this.back_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(79, 22);
            this.back_button.TabIndex = 98;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // requst_scan_btn
            // 
            this.requst_scan_btn.Location = new System.Drawing.Point(159, 162);
            this.requst_scan_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.requst_scan_btn.Name = "requst_scan_btn";
            this.requst_scan_btn.Size = new System.Drawing.Size(104, 20);
            this.requst_scan_btn.TabIndex = 97;
            this.requst_scan_btn.Text = "Request Scan";
            this.requst_scan_btn.UseVisualStyleBackColor = true;
            this.requst_scan_btn.Click += new System.EventHandler(this.requst_scan_btn_Click);
            // 
            // D_RequestScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 325);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.requst_scan_btn);
            this.Controls.Add(this.ScanComboBox);
            this.Controls.Add(this.PatientComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "D_RequestScan";
            this.Text = "D_RequestScan";
            this.Load += new System.EventHandler(this.D_RequestScan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ScanComboBox;
        private System.Windows.Forms.ComboBox PatientComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button requst_scan_btn;
    }
}