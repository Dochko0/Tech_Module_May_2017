﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            while (number%2==0)
            {
                Console.WriteLine("Please write an odd number.");
                number = Math.Abs(int.Parse(Console.ReadLine()));
            }

            if (number%2!=0)
            {
                Console.WriteLine("The number is: {0}", number);
            }
        }
    }
}
