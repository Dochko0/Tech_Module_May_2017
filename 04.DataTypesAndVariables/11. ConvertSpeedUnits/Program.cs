using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceMeters = int.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float min = float.Parse(Console.ReadLine());
            float sec = float.Parse(Console.ReadLine());

            float allSeconds = hours * 3600 + min * 60 + sec;

            float meterPerSecond = (distanceMeters / allSeconds);
            float kilometerPerHour = (float)((distanceMeters / 1000.0) / (allSeconds / 3600.0));
            float milesPerHours = (float)((distanceMeters / 1609.0f) / (allSeconds / 3600.0f));

            Console.WriteLine(meterPerSecond);
            Console.WriteLine(kilometerPerHour);
            Console.WriteLine(milesPerHours);



        }
    }
    
}
