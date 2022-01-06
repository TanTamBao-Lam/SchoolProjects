using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchTypeAverager
{
    public partial class frmTouchTypeAverager : Form
    {
        public frmTouchTypeAverager()
        {
            InitializeComponent();
        }

        int average = 0;
        int count = 0;
        int total = 0;

        private void frmTouchTypeAverager_Load(object sender, EventArgs e)
        {
            Setup();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            try
            {
                count++;

                if (!ValidInput(txtWordCount.Text))
                {
                    MessageBox.Show("Please input a valid number larger than 0", "Invalid Input", default, 
                        MessageBoxIcon.Error);
                    txtWordCount.Focus();
                    txtWordCount.SelectAll();
                    return;
                }

                if (count > 5)
                {
                    MessageBox.Show($"Maximum allowable tests to be entered is 5. Click clear to calculate " +
                        $"a new average");
                    return;
                }

                int score = Convert.ToInt32(txtWordCount.Text);
                total += score;
                average = total / count;
                lblRunningAvg.Text = $"{average.ToString()}";
                lstTests.Items.Add($"Test {count} - Score: {score.ToString()} - Average: {average.ToString()}");

                txtWordCount.Clear();
                txtWordCount.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), default, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Setup();
        }

        #region User-defined method
        private void Setup()
        {
            lblRunningAvg.Text = "";
            txtWordCount.Text = "";

            lstTests.Items.Clear();

            txtWordCount.Focus();

            average = 0;
            count = 0;
            total = 0;
        }

        private bool ValidInput(string score)
        {
            if (!Int32.TryParse(score, out int s))
            {
                return false;
            }

            if (Convert.ToInt32(score) < 0)
            {
                return false;
            }

            return true;
        }

        #endregion
    }
}
