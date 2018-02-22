using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, string>();
            var input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    var key = input[1];
                    var value = input[2];
                    
                    if (!dict.ContainsKey(key))
                    {
                        dict[key] = string.Empty;
                    }
                    dict[key] = value;
                        
                }
                else if (input[0] == "S")
                {
                    string name = input[1];

                    Console.WriteLine(
                        dict.ContainsKey(name) ? $"{name} -> {dict[name]}" : $"Contact {name} does not exist.");

                }
                else if (input[0] == "ListAll")
                {
                    //Dictionary<string, string> sort = dict.OrderBy(p => p.Value).ThenBy(p => p.Key).ToDictionary(p => p.Key, p => p.Value);
                    foreach (var item in dict)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                 }
                
                input = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
