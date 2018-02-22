using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int capacityFull = 0;
            int counter = 0;


            for (int i = 0; i < numberOfLines; i++)
            {
                int litersAdd = int.Parse(Console.ReadLine());

                capacityFull = capacityFull + litersAdd;

                if (capacityFull<=255)
                {
                    capacityFull = capacityFull;
                }
                else
                {
                    capacityFull = capacityFull - litersAdd;
                    Console.WriteLine("Insufficient capacity!");
                    counter++;
                }
            }

           // if (counter==0)
            //{
                Console.WriteLine(capacityFull);
            //}
            //else
            //{
                
              //  Console.WriteLine(capacityFull);
           // }


        }
    }
}
