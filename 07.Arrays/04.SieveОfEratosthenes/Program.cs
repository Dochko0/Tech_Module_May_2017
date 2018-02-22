using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SieveОfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
           int num = int.Parse(Console.ReadLine());

           var isPrimeNumber = new bool[num+1];

            for (int i = 2; i<isPrimeNumber.Length; i++)
            {
                isPrimeNumber[i] = true;
            }

            for (int j = 0; j <= num; j++)
            {
                if (!isPrimeNumber[j])
                {
                    continue;
                }
                else
                {
                    Console.Write(j + " ");
                }

                for (int k = 2* j; k <= num; k+=j)
                {
                    isPrimeNumber[k] = false;
                }
            }
        }
    }
}