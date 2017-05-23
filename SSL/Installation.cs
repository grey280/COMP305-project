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
    public partial class Installation : Form
    {
        public Installation()
        {
            InitializeComponent();
        }

        private void installationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.installationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sSLDataSet);

        }

        private void Installation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sSLDataSet.Installation' table. You can move, or remove it, as needed.
            this.installationTableAdapter.Fill(this.sSLDataSet.Installation);

        }
    }
}
