using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var dict = new Dictionary<string, string>();
            var input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    var key = input[1];
                    var value = input[2];

                    if (dict.ContainsKey(key))
                    {
                        dict[key] = value;
                    }
                    else
                    {
                        dict.Add(key,value);
                    }
                }
                else if (input[0] == "S")
                {
                    string name = input[1];

                    Console.WriteLine(
                        dict.ContainsKey(name) ? $"{name} -> {dict[name]}" : $"Contact {name} does not exist.");

                }
                input = Console.ReadLine().Split(' ').ToArray();
            }








        }
    }
}
