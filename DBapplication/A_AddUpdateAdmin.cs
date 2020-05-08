using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class A_AddUpdateAdmin : Form
    {
        Controller controllerObj;
        private long _aid;

        public A_AddUpdateAdmin(long aid)
        {
            InitializeComponent();
            this._aid = aid;
            controllerObj = new Controller();

            DataTable dt = controllerObj.SelectAdmin_name_id();
            adminsComboBox.DataSource = dt;
            adminsComboBox.DisplayMember = "Name";
            adminsComboBox.ValueMember = "AID";
            
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new AdminServices((long)_aid).Show();
            this.Close();
        }

        private void add_admin_button_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please, insert all specified values");
            }
            else
            {
                int r = controllerObj.A_AddAdmin(nameTextBox.Text.ToString(), usernameTextBox.Text.ToString(), passwordTextBox.Text.ToString());
                if (r > 0)
                {
                    MessageBox.Show("Admin added successfully");
                }
                else
                {
                    MessageBox.Show("Error in adding Admin");
                }
            }
        }

        private void upd_admin_button_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || usernameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please, insert all specified values");
            }
            else
            {
                int r = controllerObj.A_UpdateAdmin(nameTextBox.Text.ToString(), usernameTextBox.Text.ToString(), passwordTextBox.Text.ToString(), Convert.ToInt32(adminsComboBox.SelectedValue));

                if (r > 0)
                {
                    MessageBox.Show("Admin updated successfully");
                }
                else
                {
                    MessageBox.Show("Error in updating Admin");
                }
            }
        }

        private void adminsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (adminsComboBox.SelectedIndex == -1)
            {
                nameTextBox.Text = string.Empty;
                usernameTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
            }
            else
            {
                /*DataRow Admin = controllerObj.SelectAdmin(adminsComboBox.SelectedValue.ToString()).Rows[0];
                nameTextBox.Text = (string) Admin["Name"];
                usernameTextBox.Text = (string)Admin["Username"];
                passwordTextBox.Text = (string)Admin["Password"];*/

            }
        }
    }
}
