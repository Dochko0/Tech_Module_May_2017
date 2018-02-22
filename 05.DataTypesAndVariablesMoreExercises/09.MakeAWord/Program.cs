using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string word = "";

            for (int i = 0; i < num; i++)
            {
                string letters = Console.ReadLine();

                word = word + letters;

            }
            Console.WriteLine("The word is: {0}", word);

        }
    }
}
