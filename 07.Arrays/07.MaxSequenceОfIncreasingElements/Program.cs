using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceОfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().
                 Split(' ').
                 Select(int.Parse).
                 ToArray();
            int start = 0;
            int lenght = 1;
            int bestLenght = 1;
            int bestStart = 0;

            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i] > arr1[i - 1])
                {
                    lenght++;
                    if (lenght > bestLenght)
                    {
                        bestLenght = lenght;
                        bestStart = start;
                    }
                }
                else
                {
                    start = i;
                    lenght = 1;
                }
            }

            for (int j = bestStart; j < bestLenght + bestStart; j++)
            {
                Console.Write(arr1[j] + " ");
            }
        }
    }
}
