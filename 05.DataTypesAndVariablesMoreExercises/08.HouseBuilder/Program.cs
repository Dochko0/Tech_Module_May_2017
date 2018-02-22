using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());

            if (a>=0 && a<=127)
            {
                a = a * 4;
                b = b * 10;
            }
            else
            {
                a = a * 10;
                b = b * 4;
            }



            Console.WriteLine(a+b);
        }
    }
}
