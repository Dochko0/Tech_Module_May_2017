using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> personEmail = new Dictionary<string, string>();
            var input = Console.ReadLine();
            int counter = 0;
            var name = "";
            var mail = "";

            while (input!="stop")
            {
                if (counter%2==0)
                {
                    name=input;
                }
                else
                {
                    mail = input;
                    char[] separator = new char[] { '.' };
                    string[] chechWords = mail.Split(separator);
                    if (chechWords.Any(x => x=="us") || chechWords.Any(x => x == "uk"))
                    {
                        break;
                    }
                    else
                    {
                        personEmail[name] = mail;
                    }
                }
                counter++;
                input = Console.ReadLine();
            }
            foreach (var item in personEmail)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} ");
            }
        }
    }
}
