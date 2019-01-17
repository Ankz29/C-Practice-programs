using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_Name
{
    class Program
    {

        public string HelloName()
    {
        Console.WriteLine("hello world");
        Console.WriteLine("enter the user name: ");
       string name= Console.ReadLine();
       Console.WriteLine("entered name is : " + name); 
       Console.ReadLine();
        return name; 
    }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.HelloName();
            Console.ReadLine();
        }
    }
}
