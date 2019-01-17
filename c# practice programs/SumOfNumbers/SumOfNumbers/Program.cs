using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfNumbers
{
    class Program
    {
        double num1,num2,sumTotal;
        
        public double Sum()
        {
            num1 = 10;
            num2 = 14;
            sumTotal = num1 + num2;
            Console.WriteLine("the sum of two numbers are: " + sumTotal);
            Console.ReadLine();
            return sumTotal;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Sum();
            
        }
    }
}
