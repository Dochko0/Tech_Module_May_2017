using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += counter;   
                Console.WriteLine(counter);
                counter += 2;
            }
            Console.WriteLine($"Sum: {sum}");


        }
    }
}
