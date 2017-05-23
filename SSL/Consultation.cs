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
    public partial class Consultation : Form
    {
        public Consultation()
        {
            InitializeComponent();
        }

        private void consultationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sSLDataSet);

        }

        private void Consultation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sSLDataSet.Consultation' table. You can move, or remove it, as needed.
            this.consultationTableAdapter.Fill(this.sSLDataSet.Consultation);

        }
    }
}
