using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumberSecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int currNum = 0;
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currCounter = 0;

                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        currCounter++;
                    }
                }
                if (currCounter > counter)
                {
                    currNum = nums[i];
                    counter = currCounter;
                }
            }
            Console.WriteLine(currNum);
        }
    }
}