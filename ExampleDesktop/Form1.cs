using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcFunctions;

namespace ExampleDesktop
{
    public partial class Calculator : Form
    {
        private float val1 = 0;
        private float val2 = 0;
        private bool firstVal = true;
        private char calcOperator = '+';

        public Calculator()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            setVal(1);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            setVal(2);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            setVal(3);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            setVal(4);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            setVal(5);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            setVal(6);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            setVal(7);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            setVal(8);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            setVal(9);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstVal = false;
            calcOperator = '+';
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            firstVal = false;
            calcOperator = '-';
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            firstVal = false;
            calcOperator = '*';
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstVal = false;
            calcOperator = '/';
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblInput1.Text = 0.ToString();
            lblInput2.Text = 0.ToString();
            lblOutput.Text = 0.ToString();
            val1 = 0;
            val2 = 0;
            firstVal = true;
            calcOperator = '+';
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            var calc = new CalcFunctions.CalcFunctions();

            lblOutput.Text = calc.calculate(val1, val2, calcOperator).ToString();
        }

        private void setVal(int val)
        {
            if (firstVal)
            {
                val1 = val;
                lblInput1.Text = val1.ToString();
            }
            else
            {
                val2 = val;
                lblInput2.Text = val2.ToString();
            }
        }
    }
}
