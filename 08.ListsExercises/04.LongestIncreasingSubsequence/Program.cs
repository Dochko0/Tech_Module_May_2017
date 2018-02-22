using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestIncreasingSubsequence
{
    class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var longestIncreasingSubsequence = FindLongestIncreasingSubsequence(numbers);

            Console.WriteLine(string.Join(" ", longestIncreasingSubsequence));
        }

        private static List<int> FindLongestIncreasingSubsequence(List<int> numbers)
        {
            var lenghts = new int[numbers.Count];
            var previous = new int[numbers.Count];

            var bestLenght = 0;
            var lastIndex = -1;

            for (int i = 0; i < numbers.Count; i++)
            {
                lenghts[i] = 1;
                previous[i] = -1;

                var iNum = numbers[i];

                for (int j = 0; j < i; j++)
                {
                    var jNum = numbers[j];

                    if (jNum < iNum && lenghts[j] + 1 > lenghts[i])
                    {
                        lenghts[i] = lenghts[j] + 1;
                        previous[i] = j;
                    }
                }

                if (lenghts[i] > bestLenght)
                {
                    bestLenght = lenghts[i];
                    lastIndex = i;
                }
            }

            List<int> longestIncreasingSubsequence = new List<int>();

            while (lastIndex != -1)
            {
                longestIncreasingSubsequence.Add(numbers[lastIndex]);
                lastIndex = previous[lastIndex];
            }

            longestIncreasingSubsequence.Reverse();

            return longestIncreasingSubsequence;
        }
    }
}
