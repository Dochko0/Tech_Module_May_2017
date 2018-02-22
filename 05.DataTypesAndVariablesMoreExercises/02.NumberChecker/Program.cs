using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            
            try
            {
               long num = long.Parse(Console.ReadLine());
                Console.WriteLine("integer");
            }
            catch (Exception)
            {
                Console.WriteLine("floating-point");
              
            }
        }
    }
}
