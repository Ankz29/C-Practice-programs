using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwapNumbers
{
   public  class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double num2 = int.Parse(Console.ReadLine());
            double temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("num1 is : " + num1);
            Console.WriteLine("num2 is : " + num2);
            Console.ReadLine();

        }
    }
}
