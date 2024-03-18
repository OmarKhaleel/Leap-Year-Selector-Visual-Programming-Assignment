using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeapYearSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddLeapYears_Click(object sender, EventArgs e)
        {
            lstLeap.Items.Clear();
            for (int i = 0; i < lstYear.Items.Count; i++)
            {
                if (int.Parse(lstYear.Items[i].ToString()) % 4 == 0)
                {
                    lstLeap.Items.Add(lstYear.Items[i].ToString());
                }
            }
        }

        private void lstYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstYear.SelectedIndex != -1)
            {
                txtLstYear.Text = lstYear.Items[lstYear.SelectedIndex].ToString();
            }
        }

        private void lstLeap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLeap.SelectedIndex != -1)
            {
                txtLstLeap.Text = lstLeap.Items[lstLeap.SelectedIndex].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddToYear.Text != null)
            {
                lstYear.Items.Add(txtAddToYear.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstYear.Items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstYear.SelectedIndex != -1)
            {
                lstYear.Items.RemoveAt(lstYear.SelectedIndex);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int sum = 0;
            txtSum.Text = 0.ToString();
            for (int i = 0; i < lstYear.Items.Count; i++)
            {
                sum += int.Parse(lstYear.Items[i].ToString());
            }
            txtSum.Text = sum.ToString();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            int sum = 0;
            float average = 0;
            int counter = 0;
            txtAverage.Text = 0.ToString();
            for (int i = 0; i < lstYear.Items.Count; i++)
            {
                sum += int.Parse(lstYear.Items[i].ToString());
                counter++;
            }
            average = (float) sum / counter;
            txtAverage.Text = average.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int selectedYear = int.Parse(dateTimePicker1.Value.Year.ToString());
            if (selectedYear % 4 == 0)
            {
                txtDecision.Text = "Yes";
            } else
            {
                txtDecision.Text = "No";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int selectedYear = int.Parse(dateTimePicker1.Value.Year.ToString());
            if (selectedYear % 4 == 0)
            {
                txtDecision.Text = "Yes";
            }
            else
            {
                txtDecision.Text = "No";
            }
        }
    }
}
