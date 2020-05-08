namespace DBapplication
{
    partial class A_AddUpdateAdmin
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
            this.adminsComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.upd_admin_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.add_admin_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminsComboBox
            // 
            this.adminsComboBox.FormattingEnabled = true;
            this.adminsComboBox.Location = new System.Drawing.Point(204, 38);
            this.adminsComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminsComboBox.Name = "adminsComboBox";
            this.adminsComboBox.Size = new System.Drawing.Size(177, 21);
            this.adminsComboBox.TabIndex = 63;
            this.adminsComboBox.SelectedIndexChanged += new System.EventHandler(this.adminsComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(23, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Choose Admin to Update:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(74, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(74, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Username:";
            // 
            // upd_admin_button
            // 
            this.upd_admin_button.Location = new System.Drawing.Point(217, 266);
            this.upd_admin_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.upd_admin_button.Name = "upd_admin_button";
            this.upd_admin_button.Size = new System.Drawing.Size(104, 20);
            this.upd_admin_button.TabIndex = 67;
            this.upd_admin_button.Text = "Update Admin";
            this.upd_admin_button.UseVisualStyleBackColor = true;
            this.upd_admin_button.Click += new System.EventHandler(this.upd_admin_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(131, 330);
            this.back_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(79, 22);
            this.back_button.TabIndex = 68;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(214, 330);
            this.logout_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(79, 22);
            this.logout_button.TabIndex = 69;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(157, 155);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(188, 20);
            this.usernameTextBox.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(74, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(157, 197);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(188, 20);
            this.passwordTextBox.TabIndex = 72;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(157, 111);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(188, 20);
            this.nameTextBox.TabIndex = 73;
            // 
            // add_admin_button
            // 
            this.add_admin_button.Location = new System.Drawing.Point(108, 266);
            this.add_admin_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_admin_button.Name = "add_admin_button";
            this.add_admin_button.Size = new System.Drawing.Size(104, 20);
            this.add_admin_button.TabIndex = 74;
            this.add_admin_button.Text = "Add Admin";
            this.add_admin_button.UseVisualStyleBackColor = true;
            this.add_admin_button.Click += new System.EventHandler(this.add_admin_button_Click);
            // 
            // A_AddUpdateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 391);
            this.Controls.Add(this.add_admin_button);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.upd_admin_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adminsComboBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "A_AddUpdateAdmin";
            this.Text = "A_AddUpdateAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox adminsComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button upd_admin_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button add_admin_button;
    }
}