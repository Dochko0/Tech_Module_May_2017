﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = Convert.ToBoolean(Console.ReadLine());
            //bool tr = Convert.ToBoolean(5);

            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
