using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AverageNumbers
{
    public class Program
    {

        public int Average()
        {
            Console.WriteLine("enter the first number: ");
            int num1=int.Parse(Console.ReadLine());

            Console.WriteLine("enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            int sum = num1 + num2 + num3;
            int avg = sum / 3;
            Console.WriteLine("the average is: "+avg); 
            Console.ReadLine();

            return avg;

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Average();

        }
    }
}
