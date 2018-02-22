using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            long personalID = long.Parse(Console.ReadLine());
            int employeeNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {name}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {sex}");
            Console.WriteLine($"Personal ID: {personalID}");
            Console.WriteLine($"Unique Employee number: {employeeNum}");


        }
    }
}
