using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long targetFibonacciNum = long.Parse(Console.ReadLine());

            Console.WriteLine(fibonacciNumResult(targetFibonacciNum));


        }

        public static long fibonacciNumResult(long targetFibonacciNum)
        {
            long result = 0;
            long beforeResult = 1;
            long plus = 0;

            for (long i = 1; i <= targetFibonacciNum; i++)
            {

                result = beforeResult + plus;
                plus = beforeResult;
                beforeResult = result;
            }
            if (result == 0)
            {
                result = 1;
            }

            return result;
        }
    }
}
