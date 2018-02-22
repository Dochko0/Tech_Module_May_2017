using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = "";
            command = Console.ReadLine();

            while (!command.Equals("Odd") && !command.Equals("Even"))
            {
                
                 List <string> parts=  command.Split().ToList();

                if (parts[0] == "Delete")
                {
                    int num = int.Parse(parts[1]);
                    //numbers = numbers.Where(x => x != num).ToList();
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        if (numbers[j] == num)
                        {
                            numbers.Remove(num);
                            j--;
                        }
                    }
                }
                else if (parts[0] == "Insert")
                {
                    int element = int.Parse(parts[1]);
                    int position = int.Parse(parts[2]);
                    numbers.Insert(position, element);
                }
                command = Console.ReadLine();
            }

            if (command=="Odd")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i]%2!=0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            if (command == "Even")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
