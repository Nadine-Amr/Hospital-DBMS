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
    public partial class R_RegisterPatient : Form
    {
        private long _recid;

        public R_RegisterPatient(long recid)
        {
            InitializeComponent();
            this._recid = recid;
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new ReceptionistServices((long)_recid).Show();
            this.Close();
        }
    }
}
