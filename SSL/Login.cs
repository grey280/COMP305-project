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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sSLDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sSLDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.sSLDataSet.Employee);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtPassword.Clear();
            this.txtUsername.Clear();
            this.txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.FillBy(this.sSLDataSet.Employee, this.txtUsername.Text, this.txtPassword.Text);
            if(this.sSLDataSet.Employee.Count == 0)
            {
                MessageBox.Show("Login incorrect. Please check your username and password.");
                this.txtUsername.Clear();
                this.txtPassword.Clear();
                this.txtUsername.Focus();
            }
            else
            {
                MainMenu frmMainMenu = new MainMenu();
                ManagerMenu frmManager = new ManagerMenu();
                ExecutiveMenu frmExecutive = new ExecutiveMenu();
                TechnicianMenu frmTechnician = new TechnicianMenu();
                // Login successful; pull the employee type to see which menu to open
                switch(this.sSLDataSet.Employee[0].EmployeeRole)
                {
                    case "Employee":
                        frmMainMenu.Show();
                        this.Hide();
                        break;
                    case "Executive":
                        frmMainMenu.Show();
                        frmManager.Show();
                        frmExecutive.Show();
                        this.Hide();
                        break;
                    case "Technician":
                        frmTechnician.Show();
                        frmMainMenu.Show();
                        this.Hide();
                        break;
                    case "Manager":
                        frmMainMenu.Show();
                        frmManager.Show();
                        this.Hide();
                        break;
                    default:
                        // well this shouldn't happen
                        MessageBox.Show("Invalid employee type; please contact technical support.");
                        Application.Exit();
                        break; // okay whatever compiler, this can *definitely* happen
                }
            }
        }
    }
}
