using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            sbyte numberS;
            int numberI;
            long numberL;
            decimal variable = 0.0m;

            bool numberSbyte = sbyte.TryParse(num, out numberS);
            bool numberInt = int.TryParse(num, out numberI);
            bool numberLong = long.TryParse(num, out numberL);
            bool numberDecimal = decimal.TryParse(num, out variable);
            


            if (numberSbyte == true)
            {
                Console.WriteLine("Sunny");
            }
            else if (numberInt == true)
            {
                Console.WriteLine("Cloudy");
            }
            else if (numberLong == true)
            {
                Console.WriteLine("Windy");
            }
            else
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
