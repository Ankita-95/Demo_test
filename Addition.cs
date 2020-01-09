using System;
using System.Collections.Generic;
using System.Text;

namespace Ankita
{
    class Addition : Calculator
    {
        double[] operands;
        public Addition()
        {

        }

        public Addition(double[] operands)
        {
            this.operands = operands;
        }

        public void SetOperands(double[] operands)
        {
            this.operands = operands;
        }

        public double Calculate()
        {
            double result = 0;
            foreach(int operand in this.operands)
            {
                result = result + operand;
            }
            return result;
        }
    }
}