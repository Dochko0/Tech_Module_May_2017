using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            double result = 0.0;

            switch (type)
            {
                case "miles":
                     result = value * 1.6;
                    Console.WriteLine($"{value} miles = {result:f2} kilometers");
                    break;
                case "inches":
                     result = value * 2.54;
                    Console.WriteLine($"{value} inches = {result:f2} centimeters");
                    break;
                case "feet":
                     result = value * 30.0;
                    Console.WriteLine($"{value} feet = {result:f2} centimeters");
                    break;
                case "yards":
                     result = value * 0.91;
                    Console.WriteLine($"{value} yards = {result:f2} meters");
                    break;
                case "gallons":
                     result = value * 3.8;
                    Console.WriteLine($"{value} gallons = {result:f2} liters");
                    break;
                default:
                    break;
            }
        }
    }
}
