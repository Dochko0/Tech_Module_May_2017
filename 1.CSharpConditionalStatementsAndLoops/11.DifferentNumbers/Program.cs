using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (Math.Abs(num1-num2)>=5)
            {
                for (int i = num1; i <= num2; i++)
                {
                    for (int j = num1+1; j <= num2; j++)
                    {
                        for (int k = num1+2; k <= num2; k++)
                        {
                            for (int m = num1+3; m <= num2; m++)
                            {
                                for (int n = num1+4; n <= num2; n++)
                                {
                                    if (j!=i && k!=i && m!=i && n!=i && j!=k && j!=m && j!=n && k!=m && k!=n && m!=n)
                                    {
                                        if (i<j && j<k && k<m && m<n)
                                        {
                                            Console.WriteLine($"{i} {j} {k} {m} {n}");
                                        }                              
                                    }
                                }                        
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
