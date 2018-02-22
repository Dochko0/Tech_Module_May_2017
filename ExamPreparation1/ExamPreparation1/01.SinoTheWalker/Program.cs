using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaveTime = Console.ReadLine().Split(':').Select(int.Parse).ToArray();

            long totalSeconds = leaveTime[0] * 3600 + leaveTime[1] * 60 + leaveTime[2];
            long steps = long.Parse(Console.ReadLine());
            long secondsForStep = long.Parse(Console.ReadLine());
            
            long sumSec = steps * secondsForStep + totalSeconds;
            
            long hours = sumSec / 3600;
            
            sumSec = sumSec % 3600;
            long min = sumSec / 60;
 
            sumSec = sumSec % 60;
            long sec = sumSec;
            if (sec >= 60)
            {
                sec = sec - 60;
                min += sec % 60;
            }
            if (min >= 60)
            {
                min = min - 60;
                hours += min % 60;
            }
            if (hours >= 24)
            {
                hours = hours % 24;
            }
            Console.WriteLine("Time Arrival: "+$"{hours:d2}:{min:d2}:{sumSec:d2}");
        }
    }
}
