using System;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        CalculatorClass cal = new CalculatorClass();
        double num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click_1(object sender, EventArgs e)
        {
            num1 = double.Parse(txtBoxInput1.Text);
            num2 = double.Parse(txtBoxInput2.Text);

            if (cbOperator.SelectedIndex == 0)
            {
                cal.CalculateEvent += new Information<double>(CalculatorClass.GetSum);
                lblDisplayTotal.Text = CalculatorClass.GetSum(num1, num2).ToString();
                cal.CalculateEvent -= new Information<double>(CalculatorClass.GetSum);
            }
            else if (cbOperator.SelectedIndex == 1)
            {
                cal.CalculateEvent += new Information<double>(CalculatorClass.GetDifference);
                lblDisplayTotal.Text = CalculatorClass.GetDifference(num1, num2).ToString();
                cal.CalculateEvent -= new Information<double>(CalculatorClass.GetDifference);
            }
            else if (cbOperator.SelectedIndex == 2)
            {
                cal.CalculateEvent += new Information<double>(CalculatorClass.GetProduct);
                lblDisplayTotal.Text = CalculatorClass.GetProduct(num1, num2).ToString();
                cal.CalculateEvent -= new Information<double>(CalculatorClass.GetProduct);
            }
            else if (cbOperator.SelectedIndex == 3)
            {
                cal.CalculateEvent += new Information<double>(CalculatorClass.GetQuotient);
                lblDisplayTotal.Text = CalculatorClass.GetQuotient(num1, num2).ToString();
                cal.CalculateEvent -= new Information<double>(CalculatorClass.GetQuotient);
            }

        }
    }
}