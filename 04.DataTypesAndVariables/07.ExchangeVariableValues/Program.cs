using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:\n" + $"a = {a}\n" + $"b = {b}");

            Console.WriteLine("After:\n" + $"a = {b}\n" + $"b = {a}");


        }
    }
}
