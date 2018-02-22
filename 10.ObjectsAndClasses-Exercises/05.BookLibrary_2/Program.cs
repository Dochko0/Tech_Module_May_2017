using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BookLibrary_2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var bookDescription = Console.ReadLine().Split(' ').ToList();

            decimal o = decimal.Parse(bookDescription[0].Trim());
            string str = bookDescription[1];
            double db = double.Parse(bookDescription[2].Trim());
            //, CultureInfo.InvariantCulture)

            Console.WriteLine(o);
            Console.WriteLine(str);
            Console.WriteLine(db);

        }
    }
}