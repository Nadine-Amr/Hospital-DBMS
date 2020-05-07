namespace DBapplication
{
    partial class A_ViewOrderedScans
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
            this.OrderedScansGridView = new System.Windows.Forms.DataGridView();
            this.OrderedScansCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.view_orderScans_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderedScansGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderedScansGridView
            // 
            this.OrderedScansGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderedScansGridView.Location = new System.Drawing.Point(52, 66);
            this.OrderedScansGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderedScansGridView.Name = "OrderedScansGridView";
            this.OrderedScansGridView.RowHeadersWidth = 51;
            this.OrderedScansGridView.Size = new System.Drawing.Size(359, 185);
            this.OrderedScansGridView.TabIndex = 114;
            // 
            // OrderedScansCombobox
            // 
            this.OrderedScansCombobox.FormattingEnabled = true;
            this.OrderedScansCombobox.Location = new System.Drawing.Point(180, 20);
            this.OrderedScansCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderedScansCombobox.Name = "OrderedScansCombobox";
            this.OrderedScansCombobox.Size = new System.Drawing.Size(209, 24);
            this.OrderedScansCombobox.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 112;
            this.label1.Text = "Ordered Scan";
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(232, 327);
            this.logout_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(105, 27);
            this.logout_button.TabIndex = 111;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(121, 327);
            this.back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(105, 27);
            this.back_button.TabIndex = 110;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // view_orderScans_btn
            // 
            this.view_orderScans_btn.Location = new System.Drawing.Point(145, 257);
            this.view_orderScans_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view_orderScans_btn.Name = "view_orderScans_btn";
            this.view_orderScans_btn.Size = new System.Drawing.Size(177, 33);
            this.view_orderScans_btn.TabIndex = 109;
            this.view_orderScans_btn.Text = "View Ordered Scans";
            this.view_orderScans_btn.UseVisualStyleBackColor = true;
            // 
            // A_ViewOrderedScans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 375);
            this.Controls.Add(this.OrderedScansGridView);
            this.Controls.Add(this.OrderedScansCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.view_orderScans_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "A_ViewOrderedScans";
            this.Text = "A_ViewOrderedScans";
            ((System.ComponentModel.ISupportInitialize)(this.OrderedScansGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderedScansGridView;
        private System.Windows.Forms.ComboBox OrderedScansCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button view_orderScans_btn;
    }
}