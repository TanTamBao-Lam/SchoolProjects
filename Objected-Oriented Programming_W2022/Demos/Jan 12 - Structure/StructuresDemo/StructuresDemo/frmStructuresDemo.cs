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
    public struct Employee
    {
        public string GivenName;
        public string FamilyName;
        public int Extension;
        public decimal Salary;
    }


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

                //clear the form.
                foreach(Control ctl in this.Controls)
                {
                    if (ctl is TextBox)
                    {
                        ctl.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
