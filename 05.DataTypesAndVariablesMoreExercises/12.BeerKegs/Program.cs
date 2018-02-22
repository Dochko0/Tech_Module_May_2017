using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int cycle = int.Parse(Console.ReadLine());
            string nameOfBeer = "";
            double currVolume = 0.0;


            for (int i = 0; i < cycle; i++)
            {
                var first = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;

                if (volume>currVolume)
                {
                    currVolume = volume;
                    nameOfBeer = first;
                }

            }

            Console.WriteLine(nameOfBeer);

        }
    }
}
