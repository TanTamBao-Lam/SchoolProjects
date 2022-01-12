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

        #endregion

        #region Private Methods


        #endregion

    }
}
