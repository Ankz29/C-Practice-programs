using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CelsiusFahrenheit
{
    class Program
    {

        public double Values()
        {
            Console.WriteLine("Enter the amount of fahrenheit value: ");
            double f = int.Parse(Console.ReadLine());
          double  Celsius = (5(f - 32)) / 9;


          return;
        }


        static void Main(string[] args)
        {

        }
    }
}
