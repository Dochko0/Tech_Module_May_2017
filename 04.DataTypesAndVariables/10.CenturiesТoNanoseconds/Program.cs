using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CenturiesТoNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = years * 365.2422;
            long days1 = (long)days;
            long hours = (long) days * 24;
            double minutes = hours * 60;
            double seconds = minutes * 60;
            long milliseconds = (long)seconds * 1000;
            string mil = Convert.ToString(milliseconds);
            long microseconds = milliseconds * 1000;
            string mic = Convert.ToString(microseconds);
            ulong nanoseconds = (ulong)milliseconds * 1000;
            string nano = Convert.ToString(nanoseconds) + "000";

            Console.WriteLine($"{centuries} centuries = {years} years = {days1} days = {hours} hours = {minutes} minutes = {seconds} seconds = {mil} milliseconds = {mic} microseconds = {nano} nanoseconds");
        }
    }
}
