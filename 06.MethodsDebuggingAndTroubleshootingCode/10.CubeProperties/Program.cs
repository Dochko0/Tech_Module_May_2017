using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face":
                    CalculateFaceOfCube(side); 
                    break;
                case "space":
                    CalculateSpaceOfCube(side);
                    break;
                case "volume":
                    CalculateVolumeOfCube(side);
                    break;
                case "area":
                    CalculateAreaOfCube(side);
                    break;
                default:
                    break;
            }
        }

        public static void CalculateAreaOfCube(double side)
        {
            double result = 6 * side * side;
            Console.WriteLine("{0:f2}", result);
        }

        public static void CalculateVolumeOfCube(double side)
        {
            double result = side * side * side;
            Console.WriteLine("{0:f2}", result);
        }

        public static void CalculateSpaceOfCube(double side)
        {
            double result = Math.Sqrt(3* Math.Pow(side, 2));
            Console.WriteLine("{0:f2}", result);
        }

        public static void CalculateFaceOfCube(double side)
        {
            double result = Math.Sqrt(2 * Math.Pow(side, 2)); ;
            Console.WriteLine("{0:f2}", result);
        }
    }
}
