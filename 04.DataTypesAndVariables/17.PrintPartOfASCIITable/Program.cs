using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            char ch1 = Convert.ToChar(num1);
            char ch2 = Convert.ToChar(num2);


            for (char i = ch1; i <= ch2; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
