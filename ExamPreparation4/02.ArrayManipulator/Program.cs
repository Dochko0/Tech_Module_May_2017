using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                var tokens = line.Split(' ');

                var command = tokens[0];

                if (command == "exchange")
                {
                    var index = int.Parse(tokens[1]);

                    arr = ExchangeElements(arr, index);
                }
                else if (command == "max" || command == "min")
                {
                    var evenOrOdd = tokens[1];

                    FindIndexOfMinOrMaxEvenOrOddElement(arr, command, evenOrOdd);
                }
                else if (command == "first" || command == "last")
                {
                    var count = int.Parse(tokens[1]);
                    var evenOrOdd = tokens[2];

                    FindFirstOrLasrEvenOrOddElementCount(arr, command, count, evenOrOdd);
                }


            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));


        }

        public static void FindFirstOrLasrEvenOrOddElementCount(int[] arr, string command, int count, string evenOrOdd)
        {
            if (count>arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var parity = evenOrOdd == "even" ? 0 : 1;

            var evenOrOddElements = arr
                .Where(a => a % 2 == parity)
                .ToArray();

            var firstOrLastEvenOrOddElements = new List<int>();
            if (command == "first")
            {
                firstOrLastEvenOrOddElements.AddRange(evenOrOddElements.Take(count));
            }
            else
            {
                firstOrLastEvenOrOddElements.AddRange(evenOrOddElements.Skip(evenOrOddElements.Length - count));
            }

            Console.WriteLine("[{0}]", string.Join(", ", firstOrLastEvenOrOddElements));
        }

        public static void FindIndexOfMinOrMaxEvenOrOddElement(int[] arr, string command, string evenOrOdd)
        {
            var parity = evenOrOdd == "even" ? 0 : 1;

            var evenOrOddElements = arr
                .Where(a => a % 2 == parity)
                .ToArray();

            if (!evenOrOddElements.Any())
            {
                Console.WriteLine("No matches");
                return;
            }

            int minOrMaxElement;

            if (command == "min")
            {
                minOrMaxElement = evenOrOddElements.Min();
            }
            else
            {
                minOrMaxElement = evenOrOddElements.Max();
            }
            // втори начин на записване на редове 62-71
            //var minOrMaxElement = command == "min" ? evenOrOddElements.Min() : evenOrOddElements.Max();
            //край на втори начин

            var index = Array.LastIndexOf(arr, minOrMaxElement);
            Console.WriteLine(index);
        }

        public static int[] ExchangeElements(int[] arr, int index)
        {
            var isValidIndex = index >= 0 && index < arr.Length;
            if (!isValidIndex)
            {
                Console.WriteLine("Invalid index");
                return arr;
            }

            var leftPart = arr.Take(index + 1).ToArray();
            var rightPart = arr.Skip(index + 1).ToArray();

            var concatenated = rightPart.Concat(leftPart).ToArray();

            return concatenated;
        }
    }
}
