using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StructuresDemo
{
    public partial class frmStructuresDemo : Form
    {
        private List<Employee> allEmployees = new List<Employee>();

        public frmStructuresDemo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //populate an employee.
                Employee em;
                em.GivenName = txtGivenName.Text.Trim();
                em.FamilyName = txtLastName.Text.Trim();
                em.Extension = Convert.ToInt32(txtExtension.Text);
                em.Salary = Convert.ToDecimal(txtSalary.Text);

                //add that employee to a generic list of employee.
                allEmployees.Add(em);

                MessageBox.Show("Structure Accepted");

                if (allEmployees.Count % 2 == 0)
                {
                    DisplayStructure();
                }

                //clear the form.
                foreach(Control ctl in this.Controls)
                {
                    if (ctl is TextBox)
                    {
                        ctl.Text = "";
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
            DisplayStructure();
        }

        #region user-defined method

        private void DisplayStructure()
        {
            string message = "";
            foreach (Employee em in allEmployees)
            {
                message += $"{em.GivenName} {em.FamilyName} - {em.Salary:c} - {em.Extension} {Environment.NewLine}";
            }

            MessageBox.Show(message);
        }

        #endregion
    }
}
