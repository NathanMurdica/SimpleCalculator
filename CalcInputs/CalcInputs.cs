using System;

namespace CalcInputs
{
    public class CalcInput
    {
        public float Val1 { get; set; }
        public float Val2 { get; set; }
        public char Operator { get; set; }

        public CalcInput()
        {
            Val1 = 0;
            Val2 = 0;
            Operator = '+';
        }
    }
}
