using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelОrDigit
{
    class Program
    {
        static void Main(string[] args)
        {

            string num = Console.ReadLine().ToLower();

            int value = 0;

            if (int.TryParse(num, out value))
            {
                Console.WriteLine("digit");

            }
            else if (num=="a" || num== "e" || num=="u" || num=="o" || num=="i")
            {
                Console.WriteLine("vowel");

            }
            else
            {
                Console.WriteLine("other");
            }

           
        }
    }
}
