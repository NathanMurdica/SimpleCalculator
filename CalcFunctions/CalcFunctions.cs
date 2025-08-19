using System;

namespace CalcFunctions
{
    public class CalcFunctions
    {
        public float calculate(float val1, float val2, char calcOperator)
        {
            float outputVal = 0;

            switch (calcOperator)
            {
                case '+':
                    outputVal = val1 + val2;
                    break;
                case '-':
                    outputVal = val1 - val2;
                    break;
                case '*':
                    outputVal = val1 * val2;
                    break;
                case '/':
                    outputVal = val1 / val2;
                    break;
            }

            return outputVal;
        }
    }
}
