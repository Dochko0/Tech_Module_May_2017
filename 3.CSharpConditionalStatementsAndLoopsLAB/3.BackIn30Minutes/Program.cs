using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 30;

            if (minutes<60)
            {
                Console.WriteLine($"{hours}:{minutes:D2}");
            }
            else if (minutes>=60)
            {
                hours = hours + (minutes / 60);
                minutes = minutes - 60;
                if (hours<24)
                {
                    Console.WriteLine($"{hours}:{minutes:D2}");
                }
                else if (hours>=24)
                {
                    hours = hours - 24;
                    Console.WriteLine($"{hours}:{minutes:D2}");
                }
            }


        }
    }
}
