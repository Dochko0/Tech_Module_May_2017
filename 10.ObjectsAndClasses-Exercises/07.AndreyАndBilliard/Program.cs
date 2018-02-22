using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyАndBilliard
{
    public class PeopleOrder
    {
        public string Name { get; set; }
        public Dictionary<string, int> OrdersList { get; set; }
        public decimal Bill { get; set; }

    }
    class Program
    {
        
        static void Main(string[] args)
        {


            Dictionary<string, decimal> products = new Dictionary<string, decimal>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var entity = Console.ReadLine().Split('-').ToList();

                if (!products.ContainsKey(entity[0]))
                {
                    products[entity[0]] = 0;
                }
                products[entity[0]] = decimal.Parse(entity[1]);
            }

            var orders = Console.ReadLine().Split('-', ',').ToList();
            var listOfOrders = new List<PeopleOrder>();
            while (orders[0] != "end of clients")
            {
                if (!products.ContainsKey(orders[1]))
                {
                    orders = Console.ReadLine().Split('-', ',').ToList();
                    continue;
                }
                decimal currPrice = products[orders[1]];
                int orderQuantity = int.Parse(orders[2]);

                PeopleOrder ord = new PeopleOrder
                {
                    Name = orders[0],
                    OrdersList = new Dictionary<string, int>(),
                    Bill = 0
                };

                if (!ord.OrdersList.ContainsKey(orders[1]))
                {
                    ord.OrdersList[orders[1]] = 0;
                }
                ord.OrdersList[orders[1]] += orderQuantity;
                ord.Bill += orderQuantity * currPrice;

                if (listOfOrders.Any(x => x.Name == ord.Name))
                {
                    PeopleOrder existingPeople = listOfOrders.First(x => x.Name == ord.Name);

                    if (!existingPeople.OrdersList.ContainsKey(orders[1]))
                    {
                        existingPeople.OrdersList[orders[1]] = 0;
                    }
                    existingPeople.OrdersList[orders[1]] += orderQuantity;
                    existingPeople.Bill += ord.Bill;
                }
                else
                {
                    listOfOrders.Add(ord);
                }

                orders = Console.ReadLine().Split('-', ',').ToList();
            }

            decimal bill = 0;

            foreach (var p in listOfOrders.OrderBy(x => x.Name))
            {
                Console.WriteLine(p.Name);

                foreach (var item in p.OrdersList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {p.Bill:f2}");
                bill += p.Bill;
            }
            Console.WriteLine($"Total bill: {bill:f2}");
        }
    }
}
