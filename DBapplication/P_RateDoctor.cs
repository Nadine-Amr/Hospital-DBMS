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
    public partial class P_RateDoctor : Form
    {
        private long _pid;
        private long DoctorID;
        private Controller controllerObj = new Controller();
        public P_RateDoctor(long pid)
        {
            InitializeComponent();
            this._pid = pid;
            last_visited_doc_name.Text = controllerObj.GetDoctorNameFromPatientID(_pid);
            DoctorID = controllerObj.GetDoctorIDFromName(last_visited_doc_name.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void last_visited_doc_name_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new PatientServices((long)_pid).Show();
            this.Close();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void rate_doctor_btn_Click(object sender, EventArgs e)
        {
            int result = controllerObj.InsertDoctorRate(_pid, DoctorID, (int)RateNumericUpDown.Value);
            if (result >0)
            {
                MessageBox.Show("Thanks For Rating We appreciate it");
            }
            else
            {
                MessageBox.Show("Sorry, there was an error with submitting your rate");
            }
        }
    }
}
