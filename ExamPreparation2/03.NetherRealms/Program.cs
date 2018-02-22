using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.NetherRealms
{
    class Demon
    {
        public string Name { get; set; }
        public decimal Health { get; set; }
        public decimal Damage { get; set; }

        public static Demon Parse(string demonStr)
        {
            var damageRegex = new Regex(@"-?\d+(?:\.\d+)?");
            var healthRegex = new Regex(@"[^\d\-*\/\.]");
            var name = demonStr;
            var health = healthRegex.Matches(demonStr).Cast<Match>().Select(a=>(int) char.Parse(a.Value)).Sum();
            var damage = damageRegex.Matches(demonStr).Cast<Match>().Select(a => decimal.Parse(a.Value)).Sum();

            var multiplyCount = demonStr.Count(a => a == '*');
            var divideCount = demonStr.Count(a => a == '/');

            
                damage *= (int)Math.Pow(2 , multiplyCount);         
                damage /= (int)Math.Pow(2, divideCount);
            
            var demon = new Demon()
            {
                Name = name,
                Health = health,
                Damage = damage           
            };
            return demon;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Demon.Parse).OrderBy(a => a.Name).ToArray();

            foreach (var item in demons)
            {
                Console.WriteLine($"{item.Name} - {item.Health} health, {item.Damage:f2} damage");
            }
        }
    }
}
