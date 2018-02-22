using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var handMoney = decimal.Parse(Console.ReadLine());
            var numberOfGuests = decimal.Parse(Console.ReadLine());
            var priceBanana = decimal.Parse(Console.ReadLine());
            var priceEgg = decimal.Parse(Console.ReadLine());
            var priceBerry = decimal.Parse(Console.ReadLine());

            var sets = Math.Ceiling(numberOfGuests / 6);

            var price = (2 * priceBanana + 4 * priceEgg + 0.2m * priceBerry) * sets;

            if (price <= handMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {price:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(price-handMoney):f2}lv more.");
            }


            //set of 6 she needs 2 bananas, 4 eggs and 0.2 kilos





        }
    }
}
