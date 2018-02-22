using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hours:D2}:{minute:D2}");
            if (size<=1000)
            {
                Console.WriteLine("Size: {0}B", size);
            }
            else if (size>1000 && size<1000000)
            {
                Console.WriteLine("Size: {0}KB", size/1000);
            }
            else if (size >= 1000000)
            {
                Console.WriteLine("Size: {0}MB", size / 1000000);
            }

            if (width==height)
            {
                Console.WriteLine("Resolution: {0}x{1} (square)", width , height);
            }
            else if (width>height)
            {
                Console.WriteLine("Resolution: {0}x{1} (landscape)", width, height);
            }
            else if (width < height)
            {
                Console.WriteLine("Resolution: {0}x{1} (portrait)", width, height);
            }
        }
    }
}
