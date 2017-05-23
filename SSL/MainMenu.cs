﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSL
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceForm frmInvoice = new InvoiceForm();
            frmInvoice.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogHours frmLogHours = new LogHours();
            frmLogHours.Show();
        }
    }
}
