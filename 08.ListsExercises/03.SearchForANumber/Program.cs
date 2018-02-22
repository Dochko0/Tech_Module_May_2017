using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var checkingNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> correctNumbers = new List<int>();

            for (int i = 0; i < checkingNumbers[0]; i++)
            {
                correctNumbers.Add(numbers[i]);
            }
            for (int i = 0; i < checkingNumbers[1]; i++)
            {

                correctNumbers.RemoveAt(0);
            }
            int counter = 0;

            foreach (var item in correctNumbers)
            {
                if (item == checkingNumbers[2])
                {
                    Console.WriteLine("YES!");
                    counter++;
                    break;
                }
            }
            if (counter==0)
            {
                Console.WriteLine("NO!");
            }




        }
    }
}
