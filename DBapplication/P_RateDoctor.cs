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

        public P_RateDoctor(long pid)
        {
            InitializeComponent();
            this._pid = pid;
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
<<<<<<< HEAD
            new PatientServices().Show();
=======
            new PatientServices((long)_pid).Show();
>>>>>>> 2682d37b2e82e86193246f25826c9ef9db953279
            this.Close();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
