using System;
using System.Collections.Generic;
using System.Text;

namespace Ankita
{
    class Division: Calculator
    {
        private double[] operands;
        public Division()
        {

        }

        public Division(double[] operands)
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
            
            for(int i=0; i < this.operands.Length; i++)
            {
                if (i == 0)
                {
                    result = this.operands[i];
                    continue;
                }
                result = result / this.operands[i];
            }

            return result;
        }
    }
}
