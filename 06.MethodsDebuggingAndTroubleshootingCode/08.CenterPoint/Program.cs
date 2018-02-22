using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine(ClosestPointToCenterOfCoordinateSystem(x1, y1, x2, y2));


        }

        public static string ClosestPointToCenterOfCoordinateSystem(double x1, double y1, double x2, double y2)
        {
            double currX = 0;
            double currY = 0;
            if (Math.Sqrt(x1 * x1 + y1 * y1) <= Math.Sqrt(x2 * x2 + y2 * y2))
            {
                currX = x1;
                currY = y1;
            }
            else
            {
                currX = x2;
                currY = y2;
            }

            string result = "(" + currX + ", " + currY + ")";
            return result;
        }
    }
}
