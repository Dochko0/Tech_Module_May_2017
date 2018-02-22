using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());
            decimal mega = Math.Round((width * height / 1000000), 1);

            Console.WriteLine("{0}x{1} => {2}MP", width , height , mega);
        }
    }
}
