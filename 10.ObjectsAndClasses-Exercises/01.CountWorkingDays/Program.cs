using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var officialHolidays = OfficialHollidaysInYear();
           
            int workCounter = 0;

            for (DateTime currDay = startDate; currDay <= endDate; currDay = currDay.AddDays(1))
            {
                int secCounter = 0;
                for (int i = 0; i < officialHolidays.Length; i++)
                {
                    
                    DateTime tempHolidayCheck = officialHolidays[i];
                    
                    if (currDay.Day == tempHolidayCheck.Day && currDay.Month == tempHolidayCheck.Month)
                    {                        
                        secCounter++;
                        break;
                    }                    
                }
                //string str1 = currDay.ToString();
                //string[] str2 = str1.Split('/');
                //string[] str21 = str2[2].Split(' ');
                //string str3 = str2[0] + "-" + str2[1] + "-" + str21[0];
                    //DateTime currD = DateTime.Parse(str3);


                if ((currDay.DayOfWeek.ToString() == DayOfWeek.Saturday.ToString()) || (currDay.DayOfWeek.ToString() == DayOfWeek.Sunday.ToString()))
                {                   
                    secCounter++;
                }
                
                if (secCounter == 0)
                {
                    workCounter++;
                }
            }
            
            Console.WriteLine(workCounter);
        }


        private static DateTime[] OfficialHollidaysInYear()
        {
            DateTime[] officialHollidaysArr = new DateTime[]
                {
                    new DateTime (2015, 1, 1),
                new DateTime (2015, 3, 3),
                new DateTime (2015, 5, 1),
                new DateTime (2015, 5, 6),
                new DateTime (2015, 5, 24),
                new DateTime (2015, 9, 6),
                new DateTime (2015, 9, 22),
                new DateTime (2015, 11, 1),
                new DateTime (2015, 12, 24),
                new DateTime (2015, 12, 25),
                new DateTime (2015, 12, 26)
                };
            return officialHollidaysArr;
        }
    }
}
