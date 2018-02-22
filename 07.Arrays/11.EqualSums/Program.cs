using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var equalSum = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                var leftSum = numbers.Take(i).Sum();
                var rightSum = numbers.Skip(i + 1).Sum();
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    equalSum = true;
                    break;
                }
            }
            if (!equalSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
