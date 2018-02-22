using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            double beatsPerMinute = double.Parse(Console.ReadLine());
            double beatsPerSecond = beatsPerMinute / 60;
            double beats = double.Parse(Console.ReadLine());

            double bars = Math.Round(beats / 4.0,1);
            double timeForBeats = (beats / beatsPerSecond);
            int sec =(int) timeForBeats % 60;
            int min = (int) timeForBeats / 60;

            Console.WriteLine($"{bars} bars - {min}m {sec}s");


        }
    }
}
