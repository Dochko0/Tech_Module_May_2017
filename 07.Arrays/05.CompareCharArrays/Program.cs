using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int counter = 0;
            var minLenght = Math.Min(arr1.Length, arr2.Length);

                for (int i = 0; i < minLenght; i++)
                {
                    if (arr1[i] < arr2[i])
                    {
                        Console.WriteLine(string.Join("", arr1));
                        Console.WriteLine(string.Join("", arr2));
                        counter++;
                        break;
                        
                    }
                    else if (arr1[i] > arr2[i])
                    {
                        Console.WriteLine(string.Join("", arr2));
                        Console.WriteLine(string.Join("", arr1));
                        counter++;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                    
                }
          
            if (counter==0 && arr1.Length<=arr2.Length)
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr2));
            }
            else if (counter == 0 && arr1.Length > arr2.Length)
            {
                Console.WriteLine(string.Join("", arr2));
                Console.WriteLine(string.Join("", arr1));
            }
           
        }
    }
}
