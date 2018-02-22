using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                char ch1 = char.Parse(Console.ReadLine());
                sum = sum + ch1;

            }
            Console.WriteLine("The sum equals: " +sum);
        }
    }
}
