using System;
using CalcInputs; // reference the input DLL

namespace CalcFunctions
{
    public class CalcFunctions
    {
        public float Calculate(CalcInput input)
        {
            float outputVal = 0;

            switch (input.Operator)
            {
                case '+': outputVal = input.Val1 + input.Val2; break;
                case '-': outputVal = input.Val1 - input.Val2; break;
                case '*': outputVal = input.Val1 * input.Val2; break;
                case '/': outputVal = input.Val1 / input.Val2; break;
            }

            return outputVal;
        }
    }
}
