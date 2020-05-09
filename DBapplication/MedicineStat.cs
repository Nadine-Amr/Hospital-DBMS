﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class MedicineStat : Form
    {
        long _aid;
        public MedicineStat(long num)
        {
            InitializeComponent();
            _aid = num;
        }

        private void MedicineStat_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            new ViewsAndStatisticsForm(_aid).Show();
            this.Close();
        }

        private void LogOutbutton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
