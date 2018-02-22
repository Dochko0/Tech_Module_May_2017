using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            
            switch (figure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    CalculateAreaOfTriangle(side, height);
                    break;
                case "square":
                    double sideSq = double.Parse(Console.ReadLine());
                    CalculateAreaOfSquare(sideSq);
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double heightRec = double.Parse(Console.ReadLine());
                    CalculateAreaOfRectangle(width, heightRec);
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    CalculateAreaOfCircle(radius);
                    break;
                default:
                    break;
            }
        }

        public static void CalculateAreaOfCircle(double radius)
        {
            double result = Math.PI*radius*radius;
            Console.WriteLine("{0:f2}", result);
        }

        public static void CalculateAreaOfRectangle(double width , double heightRec)
        {
            double result = width*heightRec;
            Console.WriteLine("{0:f2}", result);
        }

        public static void CalculateAreaOfSquare(double sideSq)
        {
            double result = Math.Pow(sideSq, 2);
            Console.WriteLine("{0:f2}", result);
        }

        public static void CalculateAreaOfTriangle(double side, double height)
        {
            double result = side*height/2; ;
            Console.WriteLine("{0:f2}", result);
        }
    }
}

