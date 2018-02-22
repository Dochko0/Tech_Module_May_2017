using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            var language = Console.ReadLine();

            if (language== "England" || language=="USA")
            {
                Console.WriteLine("English");
            }
            else if (language=="Spain" || language=="Argentina" || language=="Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
