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
    public partial class D_AssignMedication : Form
    {
        private Controller controllerObj = new Controller();
        public D_AssignMedication()
        {
            InitializeComponent();
            DataTable dt1 = controllerObj.SelectMedications();
            MedicationComboBox.DataSource = dt1;
            MedicationComboBox.DisplayMember = "Name";
            DataTable dt2 = controllerObj.SelectPatients();
            PatientComboBox.DataSource = dt2;
            PatientComboBox.DisplayMember = "Name";

        }

        private void D_AssignMedication_Load(object sender, EventArgs e)
        {

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
