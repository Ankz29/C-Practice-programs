using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplyThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number: ");
           double num1= int.Parse(Console.ReadLine());

           Console.WriteLine("enter the second number: ");
           double num2 = int.Parse(Console.ReadLine());

           Console.WriteLine("enter the thirs number: ");
           double num3 = int.Parse(Console.ReadLine());

           double result = num1 * num2 * num3;
           Console.WriteLine("result is: " + result);
           Console.ReadLine();
        }

    }
}
