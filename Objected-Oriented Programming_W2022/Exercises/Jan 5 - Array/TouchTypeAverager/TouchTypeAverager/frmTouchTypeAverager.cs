using System;
using System.Collections;
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

        int count = 0;
        int average = 0;
        int total = 0;

          


        private void frmTouchTypeAverager_Load(object sender, EventArgs e)
        {
            Setup();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            try
            {
                int [] scores = new int[5];
                ArrayList scoreListLocal = new ArrayList();


                if (!ValidInput(txtWordCount.Text))
                {
                    MessageBox.Show("Please input a valid number larger than 0", "Invalid Input", default, 
                        MessageBoxIcon.Error);
                    txtWordCount.Focus();
                    txtWordCount.SelectAll();
                    return;
                }

                #region Method 1: no array or array list.
                //count++;
                //if (count > scores.Length)
                //{
                //    MessageBox.Show($"Maximum allowable tests to be entered is 5. Click clear to calculate " +
                //        $"a new average");
                //    return;
                //}

                //int score = Convert.ToInt32(txtWordCount.Text);
                //total += score;
                //average = total / count;
                //lblRunningAvg.Text = $"{average.ToString()}";
                //lstTests.Items.Add($"Test {count} - Score: {score.ToString()} - Total: {total.ToString()} " +
                //    $"- Average: {average.ToString()}");
                #endregion


                #region Method 2: using array
                //count++;

                //if (count > scores.Length)
                //{
                //    MessageBox.Show($"Maximum allowable tests to be entered is 5. Click clear to calculate " +
                //        $"a new average");
                //    return;
                //}

                //for (int i = count - 1; i < count; i++)
                //{
                //    scores[i] = Convert.ToInt32(txtWordCount.Text);
                //    total += scores[i];
                //    average = total / (i + 1);
                //    lblRunningAvg.Text = $"{average.ToString()}";
                //    lstTests.Items.Add($"Test {i + 1} - Score: {scores[i].ToString()} - Total: {total.ToString()}");
                //}
                #endregion

                #region Method 3: using ArrayList
                count++;

                ArrayList scoreList = new ArrayList();

                if (count > 5)
                {
                    MessageBox.Show($"Maximum allowable tests to be entered is 5. Click clear to calculate " +
                        $"a new average");
                    return;
                }

                scoreList.Insert(0, Convert.ToInt32(txtWordCount.Text));

                foreach (int score in scoreList)
                {
                    total += score;
                }

                average = total / count;
                lblRunningAvg.Text = $"{average.ToString()}";

                lstTests.Items.Add($"Test {count.ToString()} - Score: {txtWordCount.Text} - " +
                        $"Total: {total.ToString()} - Average: {average.ToString()}");

                #endregion

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
            total = 0;
            count = 0;
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
