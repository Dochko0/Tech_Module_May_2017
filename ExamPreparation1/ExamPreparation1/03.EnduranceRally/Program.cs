using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = Regex.Split(Console.ReadLine(), @"\s+").Where(t => t.Length > 0);
            double[] route = Regex.Split(Console.ReadLine(), @"\s+").
                Where(t => t.Length > 0).
                Select(p => double.Parse(p) * -1).ToArray();
            var checkPointIndexes = Regex.Split(Console.ReadLine(), @"\s+").
                Where(t => t.Length > 0).

                Select(long.Parse).
                Distinct().
                ToArray();

            foreach (var i in checkPointIndexes)
            {
                if (i >= 0 && i < route.Length)
                {
                    route[i] *= -1;
                }
            }

            foreach (var p in players)
            {
                var fuel = (double)p[0];
                var index = 0;
                foreach (var r in route)
                {
                    fuel += r;
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{p} - reached {index}");
                        break;
                    }
                    index++;
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{p} - fuel left {fuel:f2}");
                }
            }
        }
    }
}
