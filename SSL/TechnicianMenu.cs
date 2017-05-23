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
    public partial class TechnicianMenu : Form
    {
        public TechnicianMenu()
        {
            InitializeComponent();
        }

        private void TechnicianMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultation frmConsultation = new Consultation();
            frmConsultation.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Installation frmInstallation = new Installation();
            frmInstallation.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MaintainEquipment frmMaintainEquipment = new MaintainEquipment();
            frmMaintainEquipment.Show();
        }
    }
}
