using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(' ');

            while (true)
            {
                var commandLine = Console.ReadLine().ToLower().Trim();
                if (commandLine == "end")
                {
                    break;
                }
                var commandParts = commandLine.Split();
                var commandName = commandParts[0];
                //var commandParams = commandParts.Skip(1).ToArray();

                ProcessCommand(items, commandName, commandParts);
            }
            Console.WriteLine($"[{string.Join(", ", items)}]");
        }

        static void ProcessCommand(string[] items, string cmd, string[] cmdParts)
        {
            if (cmd == "sort" || cmd == "reverse")
            {
                ProcessSortOrReverseCommand(items, cmd, cmdParts);
            }
            else if (cmd == "rollleft" || cmd == "rollright")
            {
                ProcessRollLeftOrRollRightCommand(items, cmd, cmdParts);
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }

        private static void ProcessSortOrReverseCommand(string[] items, string cmd, string[] cmdParts)
        {
            var start = int.Parse(cmdParts[2]);
            var count = int.Parse(cmdParts[4]);
            if (start < 0 || start > items.Length - 1 || (start + count - 1) > (items.Length - 1) || count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            if (cmd == "sort")
            {
                SortRange(items, start, count);
            }
            else if (cmd == "reverse")
            {
                ReverseRange(items, start, count);
            }
        }

        private static void ProcessRollLeftOrRollRightCommand(string[] items, string cmd, string[] cmdParts)
        {

            var count = int.Parse(cmdParts[1]);
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            if (cmd == "rollleft")
            {
                RollRight(items, -count);
            }
            else if (cmd == "rollright")
            {
                RollRight(items, count);
            }
        }

        private static void RollRight(string[] items, int count)
        {

            //for (int i = 0; i < count; i++)
            //{
            //    var first = items[0];
            //    var newItems = items.Skip(1).Take(items.Length - 1).ToList();
            //    newItems.Add(first);
            //    items = newItems.ToArray();

            //}
            var result = new string[items.Length];
            for (int oldIndex = 0; oldIndex < items.Length; oldIndex++)
            {

                var newIndex = oldIndex + count;
                newIndex = newIndex % items.Length;
                if (newIndex < 0)
                {
                    newIndex += items.Length;
                    
                }
                result[newIndex] = items[oldIndex];
            }
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = result[i];
            }
        }

        private static void ReverseRange(string[] items, int start, int count)
        {
            var end = start + count - 1;
            while (start < end)
            {
                var oldItem = items[start];
                items[start] = items[end];
                items[end] = oldItem;
                start++;
                end--;
            }
            // var range = items.ToList().GetRange(start, count).Reverse().Tolist();




        }

        private static void SortRange(string[] items, int start, int count)
        {

            



            Array.Sort(items, start, count);

            //-------------------------------------------------------------------
            //var l = new List<string>();
            //l.Sort(start,count , StringComparer.Ordinal);

            //--------------------------------------------------------------------

            //var sortedSubrange = items.ToList().GetRange(start, count);
            //sortedSubrange.Sort();

            //var first = items.Take(start);
            //var lastItems = items.Skip(start + count);

            //var result = first.Concat(first, sortedSubrange, lastItems);


        }



    }
}
