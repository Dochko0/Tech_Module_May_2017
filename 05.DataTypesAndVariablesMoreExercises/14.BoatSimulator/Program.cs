using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char boat1 = char.Parse(Console.ReadLine());
            char boat2 = char.Parse(Console.ReadLine());
            int moveBoat1 = 0;
            int moveBoat2 = 0;

            int cycles = int.Parse(Console.ReadLine());

            for (int i = 0; i < cycles; i++)
            {
                var add = Console.ReadLine();
                if (add!= "UPGRADE")
                {
                    if (i % 2 == 0)
                    {
                        moveBoat1 = moveBoat1 + add.Length;
                    }
                    else
                    {
                        moveBoat2 = moveBoat2 + add.Length;
                    }
                }
                else
                {
                    boat1 += (char)3;
                    boat2 += (char)3;
                }
                if (moveBoat1>=50)
                {
                    Console.WriteLine(boat1);
                    break;
                }
                else if (moveBoat2>=50)
                {
                    Console.WriteLine(boat2);
                    break;
                }
            }
            if (moveBoat1<50 && moveBoat2<50)
            {
                if (moveBoat1>moveBoat2)
                {
                    Console.WriteLine(boat1);
                }
                else
                {
                    Console.WriteLine(boat2);
                }

            }




        }
    }
}
