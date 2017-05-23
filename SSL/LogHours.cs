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
    public partial class LogHours : Form
    {
        public LogHours()
        {
            InitializeComponent();
        }

        private void hoursWorkedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hoursWorkedBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sSLDataSet);

        }

        private void LogHours_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sSLDataSet.HoursWorked' table. You can move, or remove it, as needed.
            this.hoursWorkedTableAdapter.Fill(this.sSLDataSet.HoursWorked);
            this.timeInDateTimePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.timeOutDateTimePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss";

        }
    }
}
