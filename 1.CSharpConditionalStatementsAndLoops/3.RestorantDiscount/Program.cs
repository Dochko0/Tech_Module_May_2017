using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.RestorantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupSize = double.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double toPay = 0.0d;

            if (groupSize<=50)
            {      
                if (package=="Normal")
                {
                    toPay = ((2500 + 500) * 0.95) / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$" , toPay);
                }
                else if (package == "Gold")
                {
                    toPay = ((2500 + 750) * 0.9) / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", toPay);
                }
                else if (package == "Platinum")
                {
                    toPay = ((2500 + 1000) * 0.85) / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine("The price per person is {0:f2}$", toPay);
                }
            }
            else if (groupSize > 50 && groupSize<=100)
            {
                if (package == "Normal")
                {
                    toPay = ((5000 + 500) * 0.95) / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", toPay);
                }
                else if (package == "Gold")
                {
                    toPay = ((5000 + 750) * 0.9) / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", toPay);
                }
                else if (package == "Platinum")
                {
                    toPay = ((5000 + 1000) * 0.85) / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine("The price per person is {0:f2}$", toPay);
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                if (package == "Normal")
                {
                    toPay = ((7500 + 500) * 0.95) / groupSize;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", toPay);
                }
                else if (package == "Gold")
                {
                    toPay = ((7500 + 750) * 0.9) / groupSize;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", toPay);
                }
                else if (package == "Platinum")
                {
                    toPay = ((7500 + 1000) * 0.85) / groupSize;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine("The price per person is {0:f2}$", toPay);
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
