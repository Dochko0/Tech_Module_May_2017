using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingredients = int.Parse(Console.ReadLine());
            int calories = 0;
            for (int i = 0; i < ingredients; i++)
            {
                var product = Console.ReadLine();
                product = product.ToLower();
                switch (product)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Total calories: {0}", calories);
        }
    }
}
