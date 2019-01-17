using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArithematicOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num1: ");
            double num1=int.Parse(Console.ReadLine());

            Console.WriteLine("enter num1: ");
             double num2=int.Parse(Console.ReadLine());

            double sum = num1 + num2;
            double sub = num1 - num2;
            double multiply = num1 * num2;
            double divide = num1 / num2;

            Console.WriteLine("sum is : " + sum + " sub is: " + sub + " multiplication is: " + multiply + " remainder is: " + divide);
            Console.ReadLine();

        }
    }
}
