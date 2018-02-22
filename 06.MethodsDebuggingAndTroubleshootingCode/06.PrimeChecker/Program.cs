using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long currNum = long.Parse(Console.ReadLine());
            long num = Math.Abs(currNum);

            if (IsPrime(num))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public static bool IsPrime(long num)
        {
            if (num == 1 || num==0) return false;
            if (num == 2) return true;

            var boundary = (int)Math.Ceiling(Math.Sqrt(num));

            for (int i = 2; i <= boundary; ++i)
            {
                if (num % i == 0) return false;
            }

            return true;
        }
    }
}
