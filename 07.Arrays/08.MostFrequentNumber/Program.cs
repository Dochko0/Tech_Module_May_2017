using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var mostFrequentNumber = nums.GroupBy(n => n).OrderByDescending(n => n.Count()).First().Key;

            Console.WriteLine(mostFrequentNumber);
        }
    }
}
