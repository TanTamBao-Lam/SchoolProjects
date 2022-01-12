using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericListEx_AverageScores
{
    public partial class frmAverageScores : Form
    {
        List<int> numList;

        public frmAverageScores()
        {
            InitializeComponent();
        }

        private void frmAverageScores_Load(object sender, EventArgs e)
        {
            numList = new List<int>()
            {
                98, 87, 65, 54, 88, 75, 99, 92, 85, 78, 81, 69, 72, 89, 75, 72, 90, 100, 61, 84
            };
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double average = 0;
            int countSmall = 0;
            int countLarge = 0;

            #region use old way of calculating average.
            //foreach (int number in numList)
            //{
            //    total += number;
            //}

            //average = total / numList.Count;
            #endregion

            #region use built-in Average method of collection list
            average = numList.Average();
            #endregion

            foreach (int number in numList)
            {
                if (number > average)
                {
                    countLarge++;
                }
                else
                {
                    countSmall++;
                }
            }

            lblAvg.Text = average.ToString();
            lblNumAbove.Text = countLarge.ToString();
            lblNumBelow.Text = countSmall.ToString();

        }
    }
}
