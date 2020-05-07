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
    public partial class R_PersonnelSearch : Form
    {
        private long _recid;

        public R_PersonnelSearch(long recid)
        {
            InitializeComponent();
            this._recid = recid;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new ReceptionistServices((long)_recid).Show();
            this.Close();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
