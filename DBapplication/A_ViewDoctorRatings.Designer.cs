namespace DBapplication
{
    partial class A_ViewDoctorRatings
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
            this.view_rate_btn = new System.Windows.Forms.Button();
            this.DoctorRatingCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.doctorRatingGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.doctorRatingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(245, 368);
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
            this.back_button.Location = new System.Drawing.Point(135, 368);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(105, 27);
            this.back_button.TabIndex = 98;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // view_rate_btn
            // 
            this.view_rate_btn.Location = new System.Drawing.Point(173, 314);
            this.view_rate_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view_rate_btn.Name = "view_rate_btn";
            this.view_rate_btn.Size = new System.Drawing.Size(139, 33);
            this.view_rate_btn.TabIndex = 97;
            this.view_rate_btn.Text = "View Rating";
            this.view_rate_btn.UseVisualStyleBackColor = true;
            // 
            // DoctorRatingCombobox
            // 
            this.DoctorRatingCombobox.FormattingEnabled = true;
            this.DoctorRatingCombobox.Location = new System.Drawing.Point(193, 60);
            this.DoctorRatingCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoctorRatingCombobox.Name = "DoctorRatingCombobox";
            this.DoctorRatingCombobox.Size = new System.Drawing.Size(209, 24);
            this.DoctorRatingCombobox.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(61, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "Doctor Name";
            // 
            // doctorRatingGridView
            // 
            this.doctorRatingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorRatingGridView.Location = new System.Drawing.Point(65, 107);
            this.doctorRatingGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctorRatingGridView.Name = "doctorRatingGridView";
            this.doctorRatingGridView.RowHeadersWidth = 51;
            this.doctorRatingGridView.Size = new System.Drawing.Size(359, 185);
            this.doctorRatingGridView.TabIndex = 102;
            this.doctorRatingGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // A_ViewDoctorRatings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 412);
            this.Controls.Add(this.doctorRatingGridView);
            this.Controls.Add(this.DoctorRatingCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.view_rate_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "A_ViewDoctorRatings";
            this.Text = "A_ViewDoctorRatings";
            this.Load += new System.EventHandler(this.A_ViewDoctorRatings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorRatingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button view_rate_btn;
        private System.Windows.Forms.ComboBox DoctorRatingCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView doctorRatingGridView;
    }
}