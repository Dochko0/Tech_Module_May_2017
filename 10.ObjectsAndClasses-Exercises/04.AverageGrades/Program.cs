using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{
    public class Student
    {
        public string NameOfCurrentStudent { get; set; }
        public List<double> GradesOfStudent { get; set; }
        public double Average => GradesOfStudent.Average();

    }

    class Program
    {
        static void Main(string[] args)
        {
            var numOfStudents = int.Parse(Console.ReadLine());
            var studentsList = new List<Student>();

            for (int i = 0; i < numOfStudents; i++)
            {
                var inputLine = Console.ReadLine().Split().ToList();

                List<double> gradesOfCurrStudent = new List<double>();
                for (int j = 0; j < inputLine.Count - 1; j++)
                {
                    gradesOfCurrStudent.Add(double.Parse(inputLine[j + 1]));
                }
                Student currStud = new Student()
                {
                    NameOfCurrentStudent = inputLine[0],
                    GradesOfStudent = gradesOfCurrStudent
                };
                studentsList.Add(currStud);
            }

            foreach (var st in studentsList.Where(st => st.Average >= 5.00).OrderBy(st => st.NameOfCurrentStudent).ThenByDescending(st => st.Average))
            {
                Console.WriteLine($"{st.NameOfCurrentStudent} -> {st.Average:f2}");
            }
        }
    }
}


