using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbol = Console.ReadLine();
            var criteria = Console.ReadLine();
            StringBuilder myString = new StringBuilder();

            int cycle = int.Parse(Console.ReadLine());
            string connection = "";

            for (int i = 1; i <= cycle; i++)
            {
                string word = Console.ReadLine();
                if (criteria=="odd")
                {
                    if (i%2!=0)
                    {
                        myString.Append(word);
                        myString.Append(symbol);
                    }
                }
                else if (criteria == "even")
                {
                    if (i % 2 == 0)
                    {
                        myString.Append(word);
                        myString.Append(symbol);
                    }
                }
            }
            myString.Length -= 1;
            Console.WriteLine(myString);
        }
    }
}
