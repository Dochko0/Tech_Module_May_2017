using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            long startNum = long.Parse(Console.ReadLine());
            long endNum = long.Parse(Console.ReadLine());
            string toPrint = "";

            foreach (var item in PrimesInRangeOfNumbers(startNum, endNum))
            {
                toPrint = toPrint + item + ", ";
            }
            Console.WriteLine(toPrint.Trim().Trim(','));
        }

        public static List<long> PrimesInRangeOfNumbers(long startNum, long endNum)
        {
            List<long> primes = new List<long>();
            long border = 0;
            long counter = 0;

            for (long i = startNum; i <= endNum; i++)
            {
                counter = 0;
                border = (long)Math.Ceiling(Math.Sqrt(i));
                for (long j = 2; j <= border; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }

                if (counter == 0 && i != 0 && i != 1)
                {
                    primes.Add(i);
                }
                else if (i == 2)
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
    }
}
