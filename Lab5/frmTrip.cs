﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class frmTrip : Form
    {
        private string curUsername;
        public void setUser(string username)
        {
            curUsername = username;
        }
        public frmTrip()
        {
            InitializeComponent();
        }

        private void frmTrip_Load(object sender, EventArgs e)
        {

        }
    }
}
