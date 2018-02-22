using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var indexesOfLadybugs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] fieldWithBugs = new int[fieldSize];



            foreach (var i in indexesOfLadybugs)
            {
                if (i >= 0 && i <fieldSize )
                {
                    fieldWithBugs[i] = 1;
                }
                
            }

            var command = Console.ReadLine().Split(' ');

            while (command[0] != "end")
            {
                int position = int.Parse(command[0]);
                int move = int.Parse(command[2]);
                int staticMove = int.Parse(command[2]);


                if (command[1] == "right")
                {
                    if (position + move > fieldWithBugs.Length-1 || position + move < 0 || fieldWithBugs[position]!=1)
                    {
                        if (position >= 0 && position < fieldWithBugs.Length)
                        {
                            fieldWithBugs[position] = 0;
                        }

                        command = Console.ReadLine().Split(' ');
                        continue;

                    }
                    while (fieldWithBugs[position + move]==1)
                    {
                        move+= staticMove;
                        if (position + move > fieldWithBugs.Length - 1 || position + move < 0)
                        {
                            break;
                        }
                    }
                    if (position + move > fieldWithBugs.Length - 1 || position + move < 0 || fieldWithBugs[position] != 1)
                    {
                        if (position >= 0 && position < fieldWithBugs.Length)
                        {
                            fieldWithBugs[position] = 0;
                        }

                        command = Console.ReadLine().Split(' ');
                        continue;

                    }


                    fieldWithBugs[position] = 0;
                    fieldWithBugs[position + move] = 1;
                }

                if (command[1] == "left")
                {
                    move = -move;
                    if (position + move > fieldWithBugs.Length-1 || position + move < 0 || fieldWithBugs[position] != 1)
                    {
                        if (position >= 0 && position < fieldWithBugs.Length)
                        {
                            fieldWithBugs[position] = 0;
                        }

                        command = Console.ReadLine().Split(' ');
                        continue;

                    }
                    while (fieldWithBugs[position + move] == 1)
                    {
                        move += staticMove;
                        if (position + move > fieldWithBugs.Length - 1 || position + move < 0)
                        {
                            break;
                        }
                    }
                    if (position + move > fieldWithBugs.Length - 1 || position + move < 0 || fieldWithBugs[position] != 1)
                    {
                        if (position >= 0 && position < fieldWithBugs.Length)
                        {
                            fieldWithBugs[position] = 0;
                        }

                        command = Console.ReadLine().Split(' ');
                        continue;

                    }

                    fieldWithBugs[position] = 0;
                    fieldWithBugs[position + move] = 1;
                }
                command = Console.ReadLine().Split(' ');
            }
            Console.WriteLine(String.Join(" ", fieldWithBugs));
        }
    }
}