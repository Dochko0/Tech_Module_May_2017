using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int[] arr1 =line.Split(' ').Select(int.Parse).ToArray();
            int[] sumArr = new int[arr1.Length];

            int loops = int.Parse(Console.ReadLine());

            for (int i = 0; i < loops; i++)
            {
                int lastDigit = arr1[arr1.Length - 1];

                for (int j = arr1.Length-1; j > 0; j--)
                {
                    arr1[j] = arr1[j - 1];
                }
                arr1[0] = lastDigit;

                for (int k = 0; k < arr1.Length; k++)
                {
                    sumArr[k] += arr1[k];
                }
            }

            //for (int i = 0; i < sumArr.Length; i++)
            //{
            //    Console.Write(sumArr[i]+ " ");
            //}
            //Console.WriteLine();




            Console.WriteLine(string.Join(" ", sumArr));


        }
    }
}
