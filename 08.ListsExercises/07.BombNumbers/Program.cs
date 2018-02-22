using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequece = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombCol = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bomb = bombCol[0];
            int range = bombCol[1];

            for (int i = 0; i < sequece.Count; i++)
            {
                if (sequece[i]==bomb)
                {
                    sequece.RemoveAt(i);
                    for (int j = 0; j < range; j++)
                    {
                        if ((i - j) < sequece.Count)
                        {
                            sequece.RemoveAt(i - j);
                        }
                        if ((i - j - 1) < sequece.Count)
                        {
                            sequece.RemoveAt(i - j - 1);
                        }
                    }               
                }
            }
            int sum = sequece.Sum();
            Console.WriteLine(sum);
        }
    }
}
