using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_задание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnCalculated_Click(object sender, EventArgs e)
        {
            string a = nUpDSideA.Value.ToString();
            string b = nUpDSideB.Value.ToString();
            string c = nUpDSideC.Value.ToString();
            double A = Convert.ToDouble(a);
            double B = Convert.ToDouble(b);
            double C = Convert.ToDouble(c);
            if (rdBS.Checked==true)
            {
                double p1 = (A + B + C) / 2;
                double S = Math.Sqrt(p1 * (p1 - A)*(p1 - B)*(p1 - C));
                txtBAnswer.Text = S.ToString("##.##");
            }
            else if (rdBP.Checked == true)
            {
                double P = A + B + C;
                txtBAnswer.Text = P.ToString("##.##");
            }
        }

        

        private void nUpDSideA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void nUpDSideB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void nUpDSideC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtBAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
