using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyToSpend = double.Parse(Console.ReadLine());
            double check = moneyToSpend;

            string game = Console.ReadLine();

            while (game != "Game Time")
            {
                if (game == "OutFall 4")
                {
                    moneyToSpend -= 39.99;
                    if (moneyToSpend<=0)
                    {
                        Console.WriteLine("Too Expensive");
                        moneyToSpend += 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Bought {0}", game);
                    }
                }
                else if (game == "CS: OG")
                {
                    moneyToSpend -= 15.99;
                    if (moneyToSpend < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        moneyToSpend += 15.99;
                    }
                    else
                    {
                        Console.WriteLine("Bought {0}", game);
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    moneyToSpend -= 19.99;
                    if (moneyToSpend < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        moneyToSpend += 19.99;
                    }
                    else
                    {
                        Console.WriteLine("Bought {0}", game);
                    }
                }
                else if (game == "Honored 2")
                {
                    moneyToSpend -= 59.99;
                    if (moneyToSpend < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        moneyToSpend += 59.99;
                    }
                    else
                    {
                        Console.WriteLine("Bought {0}", game);
                    }
                }
                else if (game == "RoverWatch")
                {
                    moneyToSpend -= 29.99;
                    if (moneyToSpend < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        moneyToSpend += 29.99;
                    }
                    else
                    {
                        Console.WriteLine("Bought {0}", game);
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    moneyToSpend -= 39.99;
                    if (moneyToSpend < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        moneyToSpend += 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Bought {0}", game);
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (moneyToSpend == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                game = Console.ReadLine();
            }
                Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}" , check-moneyToSpend , moneyToSpend);
        }
    }
}
