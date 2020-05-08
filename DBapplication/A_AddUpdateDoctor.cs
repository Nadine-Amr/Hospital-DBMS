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
    public partial class A_AddUpdateDoctor : Form
    {
        Controller controllerObj;
        private long _aid;

        public A_AddUpdateDoctor(long aid)
        {
            InitializeComponent();
            this._aid = aid;

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new AdminServices((long)_aid).Show();
            this.Close();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void add_dr_button_Click(object sender, EventArgs e)
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
    }
    
}
