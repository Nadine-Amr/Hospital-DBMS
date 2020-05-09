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
    public partial class A_AddUpdateRoom : Form
    {
        private long _aid;

        public A_AddUpdateRoom(long aid)
        {
            InitializeComponent();
            this._aid = aid;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new AdminServices((long)_aid).Show();
            this.Close();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void A_AddUpdateRoom_Load(object sender, EventArgs e)
        {

        }

        private void RoomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RoomSizeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
