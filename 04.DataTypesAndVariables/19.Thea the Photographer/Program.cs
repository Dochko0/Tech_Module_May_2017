using System;
class Program
{
    static void Main()
    {
        double allpics = double.Parse(Console.ReadLine());
        double filterTime = double.Parse(Console.ReadLine());
        double goodPics = double.Parse(Console.ReadLine());
        goodPics = Math.Ceiling((allpics * goodPics) / 100.0);
        double uploadTime = double.Parse(Console.ReadLine());

        double all = (allpics * filterTime) + (goodPics * uploadTime);
        TimeSpan newTime = TimeSpan.FromSeconds((ulong)all);

        Console.WriteLine("{0:d1}:{1:d2}:{2:d2}:{3:d2}", newTime.Days, newTime.Hours, newTime.Minutes, newTime.Seconds);

    }
}