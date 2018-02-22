using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int firstPart = arr1.Length / 4;
            int middlePart = arr1.Length / 2;
            int lastPart = (3 * arr1.Length) / 4;
            int counter = 0;
            int counter2 = 1;

            int sum = 0;

            for (int i = firstPart-1; i >= 0; i--)
            {
                sum = arr1[firstPart- counter2] + arr1[firstPart + counter2-1];
                Console.Write(sum+ " ");
                counter2++;
            }
            for (int i = arr1.Length-1; i >= lastPart; i--)
            {
                sum = arr1[i] + arr1[middlePart+counter];

                Console.Write(sum + " ");
                counter++;            
            }
        }
    }
}
