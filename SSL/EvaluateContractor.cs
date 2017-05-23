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
    public partial class EvaluateContractor : Form
    {
        public EvaluateContractor()
        {
            InitializeComponent();
        }

        private void contractorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contractorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sSLDataSet);

        }

        private void EvaluateContractor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sSLDataSet.Contractor' table. You can move, or remove it, as needed.
            this.contractorTableAdapter.Fill(this.sSLDataSet.Contractor);

        }
    }
}
