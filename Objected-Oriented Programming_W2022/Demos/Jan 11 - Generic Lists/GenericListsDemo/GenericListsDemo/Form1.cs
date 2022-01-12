using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericListsDemo
{
    public partial class Form1 : Form
    {
        private List<string> customers = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("PLease enter the name of the customer.");
                    return;
                }

                customers.Add(txtName.Text);

                lstNames.Items.Add(customers[customers.Count - 1]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //make sure customer is selected.
                if (lstNames.SelectedIndex == -1)
                {
                    MessageBox.Show("You need to select an item to delete");
                    return;
                }

                //prompt if they are sure
                if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    //remove from collection
                    customers.RemoveAt(lstNames.SelectedIndex);

                    //remove from List
                    lstNames.Items.RemoveAt(lstNames.SelectedIndex);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
