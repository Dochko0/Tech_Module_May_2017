using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Regex.Split(Console.ReadLine(), @"\s*,\s*").Select(t => t.Trim()).Where(t => t.Length > 0).ToArray();

            foreach (var t in tickets)
            {
                if (t.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var leftSide = t.Substring(0, 10);
                    var rightSide = t.Substring(10);
                    var leftMaxSeq = FindMaxEqualSeq(leftSide);
                    var rightMaxSeq = FindMaxEqualSeq(rightSide);
                    var leftChar = leftMaxSeq[0];
                    var rightChar = rightMaxSeq[0];

                    if (leftMaxSeq.Length >= 6 && rightMaxSeq.Length >= 6
                        && leftChar == rightChar && "@#$^".Contains(leftChar))
                    {
                        var count = Math.Min(leftMaxSeq.Length, rightMaxSeq.Length);
                        Console.Write($"ticket \"{t}\" - {count}{leftChar}");
                        if (count == 10)
                        {
                            Console.Write($" Jackpot!");

                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{t}\" - no match") ;
                    }
                }
            }
        }

        static string FindMaxEqualSeq(string s)
        {
            var bestStr = " " + s[0];
            var max = 1;
            for (int i = 0; i < s.Length - 1; i++)
            {
                var ch = s[i];
                var count = 0;
                while (i + count < s.Length && s[i + count] == s[i])
                {
                    count++;
                    if (count > max)
                    {
                        max = count;
                        bestStr = s.Substring(i, count);
                    }
                }
            }
            return bestStr;
        }
    }
}
