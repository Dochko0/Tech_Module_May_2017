using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = "";
            string combination = "";

            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();

                if (word == "(")
                {
                    combination = combination + word;
                }
                else if (word == ")")
                {
                    combination = combination + word;
                }

                if (combination == ")(")
                {
                    result = "UNBALANCED";
                    combination = "";
                }
                else if (result != "UNBALANCED" && combination == "()")
                {
                    result = "BALANCED";
                    combination = "";
                }

            }
            if (combination.Length % 2 == 1)
            {
                Console.WriteLine("UNBALANCED");
            }
            else
            {
                if (result == "BALANCED")
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("UNBALANCED");
                }
            }
        }
    }
}
