using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDemo
{
    public partial class FormMath : Form
    {
        public FormMath()
        {
            InitializeComponent();
        }

        private void btnXOfN_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(txtNumber1.Text);
            int number2 = Convert.ToInt32(txtNumber2.Text);
            labelResult.Text = MathUtil.XOfN(number1, number2).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(txtNumber1.Text);
            int number2 = Convert.ToInt32(txtNumber2.Text);
            labelResult.Text = MathUtil.Add2Numbers(number1, number2).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(txtNumber1.Text);
            int number2 = Convert.ToInt32(txtNumber2.Text);
            labelResult.Text = MathUtil.Mul(number1, number2).ToString();
        }
    }
}
