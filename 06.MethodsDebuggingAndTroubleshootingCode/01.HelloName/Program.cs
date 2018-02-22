using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            PrintGreeting(name);
        }

         public static void PrintGreeting( string name)
        {
            
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
