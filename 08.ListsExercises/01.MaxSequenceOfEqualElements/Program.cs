using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            int currLenght=1;
            int currStart = 0;
            int bestLenght=1;
            int bestStart=0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currLenght++;

                    if (bestLenght < currLenght)
                    {
                        bestLenght = currLenght;
                        bestStart = currStart;
                    }
                }
                else
                {
                    currStart = i;
                    currLenght = 1;
                }
            }
            for (int j = bestStart; j < bestStart+bestLenght; j++)
            {
                Console.Write("{0} ", numbers[j]);
            }
            Console.WriteLine();
        }
    }
}
