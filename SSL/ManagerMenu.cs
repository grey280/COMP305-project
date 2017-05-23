using System;
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
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RentalsReportForm frmRentalsReport = new RentalsReportForm();
            frmRentalsReport.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageCustomer frmManageCustomer = new ManageCustomer();
            frmManageCustomer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageEmployee frmManageEmployee = new ManageEmployee();
            frmManageEmployee.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageContractors frmManageContractor = new ManageContractors();
            frmManageContractor.Show();
        }
    }
}
