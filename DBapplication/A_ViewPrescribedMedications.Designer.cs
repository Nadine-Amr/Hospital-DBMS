namespace DBapplication
{
    partial class A_ViewPrescribedMedications
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
            this.PrescrbdMediGridView = new System.Windows.Forms.DataGridView();
            this.PrescrbdMediCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.view_PrescrbdMedi_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PrescrbdMediGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PrescrbdMediGridView
            // 
            this.PrescrbdMediGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrescrbdMediGridView.Location = new System.Drawing.Point(34, 73);
            this.PrescrbdMediGridView.Name = "PrescrbdMediGridView";
            this.PrescrbdMediGridView.Size = new System.Drawing.Size(269, 150);
            this.PrescrbdMediGridView.TabIndex = 120;
            this.PrescrbdMediGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderedScansGridView_CellContentClick);
            // 
            // PrescrbdMediCombobox
            // 
            this.PrescrbdMediCombobox.FormattingEnabled = true;
            this.PrescrbdMediCombobox.Location = new System.Drawing.Point(185, 35);
            this.PrescrbdMediCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.PrescrbdMediCombobox.Name = "PrescrbdMediCombobox";
            this.PrescrbdMediCombobox.Size = new System.Drawing.Size(158, 21);
            this.PrescrbdMediCombobox.TabIndex = 119;
            this.PrescrbdMediCombobox.SelectedIndexChanged += new System.EventHandler(this.OrderedScansCombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 118;
            this.label1.Text = "Prescribed Medications";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(169, 285);
            this.logout_button.Margin = new System.Windows.Forms.Padding(2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(79, 22);
            this.logout_button.TabIndex = 117;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(86, 285);
            this.back_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(79, 22);
            this.back_button.TabIndex = 116;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // view_PrescrbdMedi_btn
            // 
            this.view_PrescrbdMedi_btn.Location = new System.Drawing.Point(86, 228);
            this.view_PrescrbdMedi_btn.Margin = new System.Windows.Forms.Padding(2);
            this.view_PrescrbdMedi_btn.Name = "view_PrescrbdMedi_btn";
            this.view_PrescrbdMedi_btn.Size = new System.Drawing.Size(180, 27);
            this.view_PrescrbdMedi_btn.TabIndex = 115;
            this.view_PrescrbdMedi_btn.Text = "View Prescribed Medications";
            this.view_PrescrbdMedi_btn.UseVisualStyleBackColor = true;
            this.view_PrescrbdMedi_btn.Click += new System.EventHandler(this.view_orderScans_btn_Click);
            // 
            // A_ViewPrescribedMedications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 343);
            this.Controls.Add(this.PrescrbdMediGridView);
            this.Controls.Add(this.PrescrbdMediCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.view_PrescrbdMedi_btn);
            this.Name = "A_ViewPrescribedMedications";
            this.Text = "A_ViewPrescribedMedications";
            ((System.ComponentModel.ISupportInitialize)(this.PrescrbdMediGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PrescrbdMediGridView;
        private System.Windows.Forms.ComboBox PrescrbdMediCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button view_PrescrbdMedi_btn;
    }
}