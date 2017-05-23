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
    public partial class ManageEmployee : Form
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sSLDataSet);

        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sSLDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.sSLDataSet.Employee);

        }
    }
}
