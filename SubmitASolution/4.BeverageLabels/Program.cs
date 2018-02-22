using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyPer100ml = double.Parse(Console.ReadLine());
            double sugarPer100Ml = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", energyPer100ml*(volume/100), sugarPer100Ml*(volume/100));

        }
    }
}
