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
    public partial class D_UpdatePatientDiagnosis : Form
    {
        public D_UpdatePatientDiagnosis()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new DoctorServices().Show();
            this.Close();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
