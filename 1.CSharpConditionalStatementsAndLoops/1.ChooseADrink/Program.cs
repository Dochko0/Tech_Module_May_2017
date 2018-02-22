using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Console.ReadLine();
            switch (person)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                case "Businessman":
                    Console.WriteLine("Coffee");
                    break;
                case "usinesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;

                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
