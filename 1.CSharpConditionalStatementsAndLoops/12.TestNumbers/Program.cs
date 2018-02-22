using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int checker = int.Parse(Console.ReadLine());
            int sumForCheck = 0;
            int counter = 0;
            int j = 1;
            int i = 1;
            int sss = 0;

            for ( i = num1; i >= 1; i--)
            {
                for ( j = 1; j <= num2; j++)
                {
                    sumForCheck = sumForCheck + 3 * (i * j);
                    counter++;
                    
                    if (sumForCheck > checker || sumForCheck == checker)
                    {
                        Console.WriteLine("{0} combinations", counter);
                        Console.WriteLine("Sum: {0} >= {1}", sumForCheck, checker);
                        break;
                    }
                }
                if (sumForCheck > checker || sumForCheck == checker)
                {
                    sss = 1;
                    break;
                }
            }
            if (sss==0)
            {
                Console.WriteLine("{0} combinations", counter);
                Console.WriteLine("Sum: {0}", sumForCheck);
            }
        }
    }
}
