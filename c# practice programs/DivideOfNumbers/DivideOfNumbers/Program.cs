using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivideOfNumbers
{
    class Program
    {
        double num1, num2, remainder;

        public double Divide()
        {
            num1 = 10;
            num2 = 14;
            remainder = num1/num2;
            Console.WriteLine("the sum of two numbers are: " + remainder);
            Console.ReadLine();
            return remainder;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Divide();

        }
    }
}
