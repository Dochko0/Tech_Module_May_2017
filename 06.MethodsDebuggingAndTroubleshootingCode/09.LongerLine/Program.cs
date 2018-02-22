using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            if (DistanceToFirstLineX1Y1AndX2Y2(x1, y1, x2, y2) > DistanceToFirstLineX3Y3AndX4Y4(x3, y3, x4, y4))
            {
                Console.WriteLine(ClosestPointToCenterOfCoordinateSystemFromFirst(x1, y1, x2, y2));
            }
            else
            {
                Console.WriteLine(ClosestPointToCenterOfCoordinateSystemFromSecond(x3, y3, x4, y4));
            }
        }

        public static string ClosestPointToCenterOfCoordinateSystemFromSecond(double x3, double y3, double x4, double y4)
        {
            double currX = 0;
            double currY = 0;
            double otherX = 0;
            double otherY = 0;
            if (Math.Sqrt(x3 * x3 + y3 * y3) <= Math.Sqrt(x4 * x4 + y4 * y4))
            {
                currX = x3;
                currY = y3;
                otherX = x4;
                otherY = y4;
            }
            else
            {
                currX = x4;
                currY = y4;
                otherX = x3;
                otherY = y3;
            }

            string result = "(" + currX + ", " + currY + ")" + "(" + otherX + ", " + otherY + ")";
            return result;
        }

        public static string ClosestPointToCenterOfCoordinateSystemFromFirst(double x1, double y1, double x2, double y2)
        {
            double currX = 0;
            double currY = 0;
            double otherX = 0;
            double otherY = 0;
            if (Math.Sqrt(x1 * x1 + y1 * y1) <= Math.Sqrt(x2 * x2 + y2 * y2))
            {
                currX = x1;
                currY = y1;
                otherX = x2;
                otherY = y2;
            }
            else
            {
                currX = x2;
                currY = y2;
                otherX = x1;
                otherY = y1;
            }

            string result = "(" + currX + ", " + currY + ")" + "(" + otherX + ", " + otherY + ")";
            return result;
        }

        public static double DistanceToFirstLineX3Y3AndX4Y4(double x3, double y3, double x4, double y4)
        {
            double sectionX = Math.Abs(x3 - x4);
            double sectionY = Math.Abs(y3 - y4);

            double distance = Math.Sqrt(sectionX * sectionX + sectionY * sectionY);
            return distance;
        }

        public static double DistanceToFirstLineX1Y1AndX2Y2(double x1, double y1, double x2, double y2)
        {
            double sectionX = Math.Abs(x1 - x2);
            double sectionY = Math.Abs(y1 - y2);

            double distance = Math.Sqrt(sectionX * sectionX + sectionY * sectionY);
            return distance;
        }
    }
}