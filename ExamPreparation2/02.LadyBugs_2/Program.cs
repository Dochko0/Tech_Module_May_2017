using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LadyBugs_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladyBugsIndexes = Console.ReadLine().Split(' ').Select(int.Parse).Where(a => a >= 0 && a < fieldSize).ToArray();

            var ladyBugs = new int[fieldSize];

            foreach (var i in ladyBugsIndexes)
            {
                ladyBugs[i] = 1;
            }

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                var tokens = line.Split(' ');
                var ladybugIndex = int.Parse(tokens[0]);
                var direction = tokens[1];
                var count = int.Parse(tokens[2]);

                var isInsideArea = ladybugIndex >= 0 && ladybugIndex < ladyBugs.Length;
                if (!isInsideArea)
                {
                    continue;
                }

                var ladyBugsExist = ladyBugs[ladybugIndex] == 1;
                if (!ladyBugsExist)
                {
                    continue;
                }

                MoveLadyBug(ladyBugs, ladybugIndex, direction, count);
            }

            Console.WriteLine(string.Join(" ", ladyBugs));


        }

        static void MoveLadyBug(int[] ladyBugs, int ladybugIndex, string direction, int count)
        {
            if (direction=="left")
            {
                count = -count;
            }

            var nextIndex = ladybugIndex + count;
            ladyBugs[ladybugIndex] = 0;

            var hasLeftArrayOrFoundPlace = false;
            while (!hasLeftArrayOrFoundPlace)
            {
                if (nextIndex<0 || nextIndex > ladyBugs.Length-1)
                {
                    hasLeftArrayOrFoundPlace = true;
                    continue;
                }

                var ladyBugsExistOnIndex = ladyBugs[nextIndex] == 1;

                if (ladyBugsExistOnIndex)
                {
                    nextIndex += count;
                    continue;
                }

                ladyBugs[nextIndex] = 1;
                hasLeftArrayOrFoundPlace = true;
            }

        }
    }
}
