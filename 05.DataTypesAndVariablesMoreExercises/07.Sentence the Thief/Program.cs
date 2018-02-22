using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeralType = Console.ReadLine();
            int cycles = int.Parse(Console.ReadLine());
            sbyte numS;
            int numI;
            long numL;
            sbyte numCheckSbyte = sbyte.MinValue;
            int numcheckInt = int.MinValue;
            long numCheckLong = long.MinValue;
            double durationOfSentence = 0;
            var id = "";

            for (int i = 0; i < cycles; i++)
            {
                var num = Console.ReadLine();
                if (numeralType == "sbyte")
                {
                    bool number = sbyte.TryParse(num, out numS);
                    if (number == true)
                    {
                        if (numS >= numCheckSbyte)
                        {
                            numCheckSbyte = numS;
                        }
                    }
                }
                else if (numeralType == "int")
                {
                    bool number = int.TryParse(num, out numI);
                    if (number == true)
                    {
                        if (numI >= numcheckInt)
                        {
                            numcheckInt = numI;
                        }
                    }
                }
                else if (numeralType == "long")
                {
                    bool number = long.TryParse(num, out numL);
                    if (number == true)
                    {
                        if (numL >= numCheckLong)
                        {
                            numCheckLong = numL;
                        }
                    }
                }
            }
            if (numeralType == "sbyte")
            {
                id = numCheckSbyte + "";
                if (numCheckSbyte<0)
                {
                    durationOfSentence = Math.Floor((double)(numCheckSbyte / sbyte.MinValue));
                }
                else
                {
                    durationOfSentence = Math.Floor((double)(numCheckSbyte / sbyte.MaxValue));
                }

            }
            else if (numeralType == "int")
            {
                id = numcheckInt + "";
                if (numcheckInt<0)
                {
                    durationOfSentence = Math.Floor((double)(numcheckInt / sbyte.MinValue));
                }
                else
                {
                    durationOfSentence = Math.Floor((double)(numcheckInt / sbyte.MaxValue));
                }
            }
            else if (numeralType == "long")
            {
                id = numCheckLong + "";
                if (numCheckLong < 0)
                {
                    durationOfSentence = Math.Floor((double)(numCheckLong / sbyte.MinValue));
                }
                else
                {
                    durationOfSentence = Math.Floor((double)(numCheckLong / sbyte.MaxValue));
                }
            }
            if (durationOfSentence>1)
            {
                Console.WriteLine($"Prisoner with id {id} is sentenced to {durationOfSentence+1} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {id} is sentenced to {durationOfSentence+1} year");
            }
        }
    }
}
