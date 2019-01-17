using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operations
{
    class Program
    {
        public double Operations()
        {
            Console.WriteLine("x value: ");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("y value: ");
            double y = int.Parse(Console.ReadLine());
            Console.WriteLine("z value: ");
            double z = int.Parse(Console.ReadLine());
            
            double result = (x + y) * z;
            Console.WriteLine("resultant is: " + result);
            Console.ReadLine(); 
            return result;
        }


        public double Operations1()
        {
            Console.WriteLine("x value: ");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("y value: ");
            double y = int.Parse(Console.ReadLine());
            Console.WriteLine("z value: ");
            double z = int.Parse(Console.ReadLine());

            double result1 = x*y+y*z;
            Console.WriteLine("resultant is: " + result1);
            Console.ReadLine();
            return result1;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Operations();
            p.Operations1();
        }
    }
}
