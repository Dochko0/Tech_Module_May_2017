using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int mNumber = int.Parse(Console.ReadLine());
            int nNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int checker = 0;
            int iNumber = 0;
            int jNumber = 0;
            int numChecker = 0;
            int counter = 0;

            for (int i = mNumber; i <= nNumber; i++)
            {
                for (int j = mNumber; j <= nNumber; j++)
                {
                    checker = i + j;
                    if (checker == magicNumber)
                    {
                        iNumber = i;
                        jNumber = j;
                        numChecker = checker;
                    }
                    counter++;
                }
            }
            if (numChecker == magicNumber)
            {
                Console.WriteLine($"Number found! {iNumber} + {jNumber} = {numChecker}");
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", counter , magicNumber);
            }
            

        }
    }
}
