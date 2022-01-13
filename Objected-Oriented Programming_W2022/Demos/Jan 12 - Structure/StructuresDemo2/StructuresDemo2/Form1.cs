using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StructuresDemo2
{
    public partial class Form1 : Form
    {
        #region Fields and Constructors

        // Create a generic list and Instantiate it
        private List<Employee> emList = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handler Methods

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee;

                employee.GivenName = txtGivenName.Text.Trim();
                employee.FamilyName = txtLastName.Text.Trim();
                employee.Extension = Convert.ToInt16(txtExtension.Text.Trim());
                employee.Salary = Convert.ToDecimal(txtSalary.Text.Trim());

                // Add employee to generic list
                emList.Add(employee);

                MessageBox.Show("Employee Structure added to the Generic List of Employees");

                foreach (Control ctl in this.Controls)
                {
                    if (ctl is TextBox)
                    {
                        ctl.ResetText();
                    }
                }

                txtGivenName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            PrintEmployeesList();
        }

        private void btnQueryLastName_Click(object sender, EventArgs e)
        {
            PrintEmployeeList(txtLastNameQuery.Text);
        }

        private void btnGetByOrdinal_Click(object sender, EventArgs e)
        {
            PrintEmployeesList(Convert.ToInt32(numOrdinal.Text));
        }

        #endregion

        #region Private Methods

        private void PrintEmployeesList(int ? ordinal = null)
        {
            string msg = "";

            if (ordinal == null)
            {
                foreach (Employee employee in emList)
                {
                    msg += $"{employee.GivenName}, {employee.FamilyName} - {employee.Salary:c} - {employee.Extension}" +
                        $"{Environment.NewLine}";
                }
            }
            else
            {
                //the entered an ordinal and want only that employee.
                if (ordinal > emList.Count - 1)
                {
                    MessageBox.Show("Ordinal provided is beyond the size of the generic list.");
                    return;
                }

                Employee emp = emList[ordinal.Value];

                msg += $"{emp.GivenName}, {emp.FamilyName} - {emp.Salary:c} - {emp.Extension}{Environment.NewLine}";
            }
            
            MessageBox.Show(msg);
        }

        private void PrintEmployeeList (string lastName)
        {
            string msg = string.Empty;

            foreach(Employee em in emList)
            {
                if (em.FamilyName == lastName)
                {
                    msg = $"{em.GivenName}, {em.FamilyName} - {em.Salary:c} - {em.Extension}{Environment.NewLine}";
                }
            }

            if (msg == "")
            {
                msg = $"No employee found with last name {lastName}";
            }

            MessageBox.Show(msg);
        }

        #endregion
    }
}
