using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            int counter = 0;

            while (peshoHealth>0 && goshoHealth>0)
            {
                counter++;
                goshoHealth -= peshoDamage;
                if (goshoHealth>0)
                {
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                else
                {
                    Console.WriteLine($"Pesho won in {counter}th round.");
                    break;
                }
                counter++;
                peshoHealth -= goshoDamage;
                if (peshoHealth > 0)
                {
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
                else
                {
                    Console.WriteLine($"Gosho won in {counter}th round.");
                    break;
                }
            }
        }
    }
}
