using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayForRunning = int.Parse(Console.ReadLine());
            var runnders = long.Parse(Console.ReadLine());
            var laps = long.Parse(Console.ReadLine());
            var lenghtOfLaps = long.Parse(Console.ReadLine());
            var trackCapacity = long.Parse(Console.ReadLine());
            var moneyPerKilometer = decimal.Parse(Console.ReadLine());

            if (trackCapacity*dayForRunning>=runnders)
            {
                runnders = runnders;
            }
            else
            {
                runnders = trackCapacity * dayForRunning;
            }

            var totalM = runnders * laps*lenghtOfLaps;
            double totalKM = (double)totalM / 1000;
            var moneyOfMaraton = (decimal)totalKM * moneyPerKilometer;

            Console.WriteLine($"Money raised: {moneyOfMaraton:f2}");
        }
    }
}
