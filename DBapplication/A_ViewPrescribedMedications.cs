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
    public partial class A_ViewPrescribedMedications : Form
    {
        private long _aid;

        public A_ViewPrescribedMedications(long aid)
        {
            InitializeComponent();
            this._aid = aid;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OrderedScansCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrderedScansGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void view_orderScans_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
