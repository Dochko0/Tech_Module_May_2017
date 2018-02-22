using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0000.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime t = DateTime.Now;
          
            
            string str= "";

            for (int i = 0; i < 1000000; i++)
            {
                str += "a";
            }
            Console.WriteLine(str.Length);
            TimeSpan dt = DateTime.Now - t;
           // text.Text = dt.TotalMilliseconds.ToString();
            Console.WriteLine(dt.Milliseconds + " millisecons");
            Console.WriteLine(dt.Seconds + " seconds");
            Console.WriteLine(dt.Minutes + " minutes");
            Console.WriteLine(dt.Hours + " Hours");

        }
    }
}
