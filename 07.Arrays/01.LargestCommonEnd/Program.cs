using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();

            string[] arr1 = firstLine.Split(' ');
            string[] arr2 = secondLine.Split(' ');
            int counterFirst = 0;
            int counterSecond = 0;

            int shorterLength = Math.Min(arr1.Length, arr2.Length);

            for (int i = 0; i < shorterLength; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    counterFirst++;
                }
                if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
                {
                    counterSecond++;
                }
            }

            if (counterFirst>=counterSecond)
            {
                Console.WriteLine(counterFirst);
            }
            else
            {
                Console.WriteLine(counterSecond);
            }
        }
    }
}
