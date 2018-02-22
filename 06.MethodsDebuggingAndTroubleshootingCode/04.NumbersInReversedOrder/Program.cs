using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();

            Console.WriteLine(ReversedDigitsOfNumber(num)); 
        }

        public static string ReversedDigitsOfNumber(string num)
        {
            char[] array = num.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
    }
}
