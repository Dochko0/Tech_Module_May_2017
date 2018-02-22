using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int reversedParsedNum = int.Parse(string.Join(string.Empty, numbers[i].Reverse()));
                sum += reversedParsedNum;
                
            }
            Console.WriteLine(sum);
        }
    }
}
