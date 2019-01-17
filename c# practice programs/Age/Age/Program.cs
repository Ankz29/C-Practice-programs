using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Age
{
    class Program
    {

        public string Age()
        {
            Console.WriteLine("enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("you look loder that your " + age);
           string statement= Console.ReadLine();

           return statement;
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.Age();

        }
    }
}
