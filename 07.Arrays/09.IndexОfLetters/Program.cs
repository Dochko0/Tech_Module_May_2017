using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexОfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToCharArray();

            foreach (var let in word)
            {
                var num = (int)let - 97;

                Console.WriteLine($"{let} -> {num}");
            }
        }
    }
}
