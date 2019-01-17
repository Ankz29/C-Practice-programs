using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rectangle
{
    class Program
    {
        double length;
        double width;

        public void AcceptValues()
        {
             length = 3.5;
             width = 4.5;
             Console.WriteLine("length: "+length);
             Console.WriteLine("width: " + width);           
             Console.ReadLine();
        }

        public double Area()
        {
            double area=length * width;
            Console.WriteLine(area);
            Console.ReadLine();
            return area;
        }
         

        static void Main(string[] args)
        {
            Program p = new Program();
            p.AcceptValues();
            Console.WriteLine(p.Area());
            Console.ReadLine();

        }
    }
}
