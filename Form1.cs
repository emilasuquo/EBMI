using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(txtweight.Text);
            double height = Convert.ToDouble(txtheight.Text);
            double result = 0.0;

            if (radkg.Checked)
            {
                result = weight / (height * height);
            }
            else
            if (radlb.Checked)
            {
                 weight = weight / 2.205;
                 result = weight / (height * height);
            }

            txtresult.Text = "Your BMI is " + result.ToString("#.##");
        }
    }
}
