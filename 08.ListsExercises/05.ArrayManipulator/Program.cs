using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine().Split(' ').ToList();
            
            while (command[0] != "print")
            {
                switch (command[0])
                {
                    case "add":
                        AddElement(numbers, command);
                        break;
                    case "addMany":
                        AllManyElement(numbers, command);
                        break;
                    case "contains":
                        ContainsList(numbers, command);
                        break;
                    case "remove":
                        RemoveList(numbers, command);
                        break;
                    case "shift":
                        ShiftList(numbers, command);
                        break;
                    case "sumPairs":
                        SumPairsList(numbers, command);
                        break;
                    default:
                        break;
                }
               command = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine("[" + String.Join(", ", numbers) + "]");
        }

        private static void SumPairsList(List<int> numbers, List<string> command)
        {
            int num = numbers.Count / 2;
            for (int i = 0; i < num; i++)
            {

                numbers[i] = numbers[i] + numbers[i + 1];
                numbers.RemoveAt(i + 1);
            }
        }

        private static void ShiftList(List<int> numbers, List<string> command)
        {           
            int process = int.Parse(command[1]);
            for (int i = 0; i < process; i++)
            {
                numbers.Add(numbers[0 + i]);
            }
            for (int i = 0; i < process; i++)
            {
                numbers.RemoveAt(0);
            }
        }

        private static void RemoveList(List<int> numbers, List<string> command)
        {
            int index = int.Parse(command[1]);
            numbers.RemoveAt(index);
        }

        private static void ContainsList(List<int> numbers, List<string> command)
        {
            //SECOND OPTION//
            //int elementWanted = int.Parse(command[1]);
            //int position = numbers.FindIndex(x => x == elementWanted);
            //Console.WriteLine(position);

            //FIRST OPTION//
            List<int> positive = new List<int>();
            int process = int.Parse(command[1]);
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == process)
                {
                    positive.Add(i);
                }
            }
            bool isEmpty = !positive.Any();
            if (isEmpty)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(positive[0]);
            }
        }

        public static void AddElement(List<int> numbers, List<string> command)
        {
            int index = int.Parse(command[1]);
            int element = int.Parse(command[2]);

            numbers.Insert(index, element);
        }

        public static void AllManyElement(List<int> numbers, List<string> command)
        {
            int comm = int.Parse(command[1]);
            List<int> processNum = new List<int>();
            for (int i = 1; i < command.Count; i++)
            {
                processNum.Add(int.Parse(command[i]));
            }
            for (int i = processNum.Count - 1; i > 0; i--)
            {
                numbers.Insert(comm, processNum[i]);
            }
            processNum.Clear();
        }
    }
}
