using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string first = null;
            string second = null;
            string third = null;
            int sum = 0;
            int counter = 0;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        switch (i)
                        {
                            case 1:
                                first = "A";
                                break;
                            case 2:
                                first = "C";
                                break;
                            case 3:
                                first = "G";
                                break;
                            case 4:
                                first = "T";
                                break;
                            default:
                                break;
                        }
                        switch (j)
                        {
                            case 1:
                                second = "A";
                                break;
                            case 2:
                                second = "C";
                                break;
                            case 3:
                                second = "G";
                                break;
                            case 4:
                                second = "T";
                                break;
                            default:
                                break;
                        }
                        switch (k)
                        {
                            case 1:
                                third = "A";
                                break;
                            case 2:
                                third = "C";
                                break;
                            case 3:
                                third = "G";
                                break;
                            case 4:
                                third = "T";
                                break;
                            default:
                                break;
                        }
                        sum = i + j + k;
                        if (sum >= num)
                        {
                            Console.Write("O{0}{1}{2}O ", first, second, third);
                        }
                        else
                        {
                            Console.Write("X{0}{1}{2}X ", first, second, third);
                        }
                        counter++;
                        if (counter%4==0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
