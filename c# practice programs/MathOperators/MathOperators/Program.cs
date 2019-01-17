using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathOperators
{
    class Program
    {
        public string  Operators()
        {
            double sum1 = -1 + 4 * 6;
            double sum2 = (35 + 6) / 7;
            double sum3 = 14 + -4 * 6 / 11;
            double sum4 = 2 + 15 / 6 * 1 - 7 % 2;
            string  result=  sum1 + " " + sum2 + " " + sum3 + " " + sum4;
            Console.WriteLine(result);
            Console.ReadLine();
            return result;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Operators();
        }
    }
}
