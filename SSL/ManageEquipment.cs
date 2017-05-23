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
    public partial class ManageEquipment : Form
    {
        public ManageEquipment()
        {
            InitializeComponent();
        }

        private void equipmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.equipmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sSLDataSet);

        }

        private void ManageEquipment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sSLDataSet.Equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.sSLDataSet.Equipment);

        }
    }
}
