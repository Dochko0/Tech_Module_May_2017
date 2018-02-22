using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num/2; i++)
            {
                Console.WriteLine("{1}x{0}x{1}", new string(' ', num-2-2*i), new string (' ', i) );
            }
            Console.WriteLine("{0}x", new string(' ', num/2));
            for (int j = 0; j < num / 2; j++)
            {
                Console.WriteLine("{1}x{0}x{1}", new string(' ', 1 + 2 * j), new string(' ', num/2-j-1));
            }
        }
    }
}
