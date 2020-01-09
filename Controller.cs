using System;
using System.Collections.Generic;
using System.Text;

namespace Ankita
{
    class Controller
    {
        public static void Main(string[] args)
        {
            double[] operands = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Addition addition = new Addition();
            addition.SetOperands(operands);
            Console.WriteLine("Sum: "+addition.Calculate());

            Division division = new Division(operands);
            Console.WriteLine("Division: "+division.Calculate());

            Console.ReadKey();
        }

    }
}
