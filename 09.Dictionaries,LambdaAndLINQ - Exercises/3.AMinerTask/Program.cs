using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            Dictionary<string, int> resourses = new Dictionary<string, int>();
            int counter = 0;
            string resourse = "";
            int quantity = 0;
            var check = "";


            while (word != "stop")
            {
                if (counter % 2 == 0)
                {
                    check = word;
                }
                if (resourses.ContainsKey(check))
                {
                    if (counter % 2 != 0)
                    {
                        resourses.TryGetValue(resourse, out quantity);
                        resourses[resourse] = quantity + int.Parse(word);
                    }                     
                }
                else
                {
                    if (counter % 2 == 0)
                    {
                        resourse = word;
                    }
                    else
                    {
                        quantity = int.Parse(word);

                    }
                    resourses[resourse] = quantity;
                }
                counter++;
                word = Console.ReadLine();
            }
            foreach (var item in resourses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} ");
            }
        }
    }
}
