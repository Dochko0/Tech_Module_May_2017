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
            double quantiy = double.Parse(Console.ReadLine());
            switch (person)
            {
                case "Athlete":
                    Console.WriteLine("The Athlete has to pay {0:f2}." , quantiy*0.7);
                    break;
                case "Businessman":
                    Console.WriteLine("The Businessman has to pay {0:f2}.", quantiy*1);
                    break;
                case "Businesswoman":
                    Console.WriteLine("The Businesswoman has to pay {0:f2}.", quantiy * 1);
                    break;
                case "SoftUni Student":
                    Console.WriteLine("The SoftUni Student has to pay {0:f2}.", quantiy*1.7);
                    break;

                default:
                    Console.WriteLine("The {0} has to pay {1:f2}.", person , quantiy*1.2);
                    break;
            }
        }
    }
}
