using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());


            GetMax(a, b, c);

        }

        public static void GetMax(int a, int b, int c)
        {
            int max = 0;
            if (a > b)
            {
                max = Math.Max(a, c);
            }
            max = Math.Max(b, c);

            Console.WriteLine(max);
        }
    }
}
