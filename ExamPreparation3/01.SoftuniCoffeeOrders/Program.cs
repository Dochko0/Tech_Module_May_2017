using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftuniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 0; i < n; i++)
            {
                var price = decimal.Parse(Console.ReadLine());
                var date = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
                var orders = long.Parse(Console.ReadLine());
                //int days = 0;
                decimal moneyMonth = 0;



                //switch (date[1])
                //{
                //    case 1: days = 31;
                //        break;
                //    case 2:
                //        days = 28;
                //        break;
                //    case 3:
                //        days = 31;
                //        break;
                //    case 4:
                //        days = 30;
                //        break;
                //    case 5:
                //        days = 31;
                //        break;
                //    case 6:
                //        days = 30;
                //        break;
                //    case 7:
                //        days = 31;
                //        break;
                //    case 8:
                //        days = 31;
                //        break;
                //    case 9:
                //        days = 30;
                //        break;
                //    case 10:
                //        days = 31;
                //        break;
                //    case 11:
                //        days = 30;
                //       break;
                //    case 12:
                //        days = 31;
                //        break;
                //    default:
                //        break;
                //}


                if (System.DateTime.DaysInMonth(date[2], date[1])<date[0] || date[1]<1 || date[1]>12)
                {
                    break;
                }
                int days = System.DateTime.DaysInMonth(date[2], date[1]);
               // Console.WriteLine(days);

                moneyMonth = days * price * orders;
                total += moneyMonth;
                Console.WriteLine($"The price for the coffee is: ${moneyMonth:f2}");
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
