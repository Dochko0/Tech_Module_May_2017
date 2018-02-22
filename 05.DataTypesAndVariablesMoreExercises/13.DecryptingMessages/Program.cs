using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string decrypt = "";

            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                ch += (char)key;

                decrypt = decrypt + ch;
            }
            Console.WriteLine(decrypt);
        }
    }
}
