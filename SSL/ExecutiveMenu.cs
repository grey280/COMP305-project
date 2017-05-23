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
    public partial class ExecutiveMenu : Form
    {
        public ExecutiveMenu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CustomersReport frmCustReport = new CustomersReport();
            frmCustReport.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeesReport frmEmpRep = new EmployeesReport();
            frmEmpRep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HoursReport frmHrRep = new HoursReport();
            frmHrRep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InstallationsReport frmInstRep = new InstallationsReport();
            frmInstRep.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultationReport frmConsRep = new ConsultationReport();
            frmConsRep.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InvoicesReport frmInvRep = new InvoicesReport();
            frmInvRep.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RentalsReport frmRentRep = new RentalsReport();
            frmRentRep.Show();
        }
    }
}
