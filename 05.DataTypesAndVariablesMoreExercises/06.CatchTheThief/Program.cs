using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            int interval = int.Parse(Console.ReadLine());
            sbyte numSbyte;
            int numInt;
            long numL;
            sbyte numCheckSbyte = sbyte.MinValue;
            int numCheckInt = int.MinValue;
            long numCheckLong = long.MinValue;


            if (type == "sbyte")
            {
                for (int i = 0; i < interval; i++)
                {
                    var num = Console.ReadLine();
                    bool numberS = sbyte.TryParse(num, out numSbyte);
                    if (numberS == true)
                    {
                        if (numCheckSbyte <= numSbyte)
                        {
                            numCheckSbyte = numSbyte;
                        }                        
                    }
                }
                Console.WriteLine(numCheckSbyte);
            }
            else if (type == "int")
            {
                for (int i = 0; i < interval; i++)
                {
                    var num = Console.ReadLine();
                    bool numberS = int.TryParse(num, out numInt);
                    if (numberS == true)
                    {
                        if (numCheckInt <= numInt)
                        {
                            numCheckInt = numInt;
                        }
                    }
                }
                Console.WriteLine(numCheckInt);
            }
            else if (type == "long")
            {
                for (int i = 0; i < interval; i++)
                {
                    var num = Console.ReadLine();
                    bool numberS = long.TryParse(num, out numL);
                    if (numberS == true)
                    {
                        if (numCheckLong <= numL)
                        {
                            numCheckLong = numL;
                        }
                    }
                }
                Console.WriteLine(numCheckLong);
            }
        }
    }
}
