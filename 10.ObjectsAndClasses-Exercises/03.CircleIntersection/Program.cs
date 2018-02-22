using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CircleIntersection
{
    class Program
    {


        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        class Circle
        {
            public Point Center { get; set; }
            public int Radius { get; set; }

        }

        static void Main(string[] args)
        {
            var firstCircleData = ReadCircle(Console.ReadLine());
            var secondCircleData = ReadCircle(Console.ReadLine());
            double firstRadius = firstCircleData.Radius;
            double secondRadius = secondCircleData.Radius;

            var deltaX = Math.Abs(firstCircleData.Center.X - secondCircleData.Center.X);
            var deltaY = Math.Abs(firstCircleData.Center.Y - secondCircleData.Center.Y);
            var distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            Intersect(firstRadius, secondRadius, distance);
        }

        static Circle ReadCircle(string circleData)
        {
            var tokens = circleData.Split(' ').Select(int.Parse).ToArray();

            return new Circle { Center = new Point { X = tokens[0], Y = tokens[1] }, Radius = tokens[2] };
        }

        static void Intersect(double firstRadius, double secondRadius, double distance)
        {

            if ((firstRadius + secondRadius) >= distance)
            {
                Console.WriteLine("Yes"); ;
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
