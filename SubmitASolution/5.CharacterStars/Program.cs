using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CharacterStars
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int allHealth = int.Parse(Console.ReadLine());
            int stamina = int.Parse(Console.ReadLine());
            int allStamina = int.Parse(Console.ReadLine());
            //string line = '|', health;
            //string dot = ".";

            Console.WriteLine($"Name: {hero}");
            Console.WriteLine("Health: |{0}{1}|", new string('|', health) , new string('.', allHealth-health));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', stamina), new string('.', allStamina - stamina));


        }
    }
}
