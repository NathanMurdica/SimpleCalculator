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
using CalcInputs;

namespace ExampleDesktop
{
    public partial class Calculator : Form
    {
        private bool firstVal = true;   
        private CalcInput input;

        public Calculator()
        {
            InitializeComponent();
            input = new CalcInput();
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
            input.Operator = '+';
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            firstVal = false;
            input.Operator = '-';
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            firstVal = false;
            input.Operator = '*';
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstVal = false;
            input.Operator = '/';
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblInput1.Text = 0.ToString();
            lblInput2.Text = 0.ToString();
            lblOutput.Text = 0.ToString();
            input.Val1 = 0;
            input.Val2 = 0;
            firstVal = true;
            input.Operator = '+';
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            var calculator = new CalcFunctions.CalcFunctions();

            lblOutput.Text = calculator.Calculate(input).ToString();
        }

        private void setVal(int val)
        {
            if (firstVal)
            {
                input.Val1 = val;
                lblInput1.Text = input.Val1.ToString();
            }
            else
            {
                input.Val2 = val;
                lblInput2.Text = input.Val2.ToString();
            }
        }
    }
}
