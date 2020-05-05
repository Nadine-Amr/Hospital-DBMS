namespace DBapplication
{
    partial class P_ChangeRoom
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
            this.ChnageRoom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.curr_type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(146, 251);
            this.logout_button.Margin = new System.Windows.Forms.Padding(2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(79, 22);
            this.logout_button.TabIndex = 95;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(63, 251);
            this.back_button.Margin = new System.Windows.Forms.Padding(2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(79, 22);
            this.back_button.TabIndex = 94;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // ChnageRoom
            // 
            this.ChnageRoom.Location = new System.Drawing.Point(88, 210);
            this.ChnageRoom.Margin = new System.Windows.Forms.Padding(2);
            this.ChnageRoom.Name = "ChnageRoom";
            this.ChnageRoom.Size = new System.Drawing.Size(112, 22);
            this.ChnageRoom.TabIndex = 96;
            this.ChnageRoom.Text = "Change Room";
            this.ChnageRoom.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(14, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 97;
            this.label4.Text = "Current room type is :";
            // 
            // curr_type
            // 
            this.curr_type.AutoSize = true;
            this.curr_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.curr_type.Location = new System.Drawing.Point(199, 65);
            this.curr_type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.curr_type.Name = "curr_type";
            this.curr_type.Size = new System.Drawing.Size(35, 17);
            this.curr_type.TabIndex = 98;
            this.curr_type.Text = "type";
            this.curr_type.Click += new System.EventHandler(this.label1_Click);
            // 
            // P_ChangeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 298);
            this.Controls.Add(this.curr_type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChnageRoom);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.back_button);
            this.Name = "P_ChangeRoom";
            this.Text = "P_ChangeRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button ChnageRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label curr_type;
    }
}