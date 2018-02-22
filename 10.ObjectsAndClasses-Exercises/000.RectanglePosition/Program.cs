using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000.RectanglePosition
{
    public class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Right { get { return Left + Width; } }
        public int Bottom { get { return Top - Height; } }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Rectangle r1 = ReadRectangle();
            Rectangle r2 = ReadRectangle();

            bool inside = CheckIfFirstInsideSecond(r1, r2);
            Console.WriteLine(inside ? "Inside" : "Not inside");

        }



        public static Rectangle ReadRectangle()
        {
            var size = Console.ReadLine().Split().Select(int.Parse);
            Rectangle rectangle = new Rectangle()
            {
                Left = size.First(),
                Top = size.Skip(1).First(),
                Width = size.Skip(2).First(),
                Height = size.Skip(3).First(),
            };

            return rectangle;
        }



        public static bool CheckIfFirstInsideSecond(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            bool leftIsInside = firstRectangle.Left >= secondRectangle.Left;
            bool rightIsInside = firstRectangle.Right <= secondRectangle.Right;
            bool topIsInside = firstRectangle.Top <= secondRectangle.Top;
            bool bottomIsInside = firstRectangle.Bottom >= secondRectangle.Bottom;

            return leftIsInside && rightIsInside && topIsInside && bottomIsInside;

        }
    }
}
