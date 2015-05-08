//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified //preliminary as array.

using System;
using System.Linq;

namespace Workdays
{
    class Workdays
    {
        static void Main()
        {
            string[] freeDays = { "01.01", "03.03", "05.01", "05.06", "05.24", "09.22", "11,01", "12.24", "12.25", "12.26" };

            Console.WriteLine("Enter date in format year, month and day");
            DateTime inputDate = DateTime.Parse(Console.ReadLine());
            day(inputDate, freeDays);
        }


        static void day(DateTime inputDate, string[] freeDays)
        {
            DateTime today = DateTime.Now.Date;
            int count = 0;

            while (today.CompareTo(inputDate) == -1)
            {
                today = today.AddDays(1);
                string monthDate = today.Month.ToString().PadLeft(2, '0');
                string dayDate = today.Day.ToString().PadLeft(2, '0');
                string monthAndDay = string.Concat(monthDate, ".", dayDate);
                bool flag = true;

                foreach (var item in freeDays)
                {
                    if (item == monthAndDay)
                    {
                        flag = false;
                    }
                }

                string dayOfWeek = today.DayOfWeek.ToString();
                if (dayOfWeek != "Saturday" && dayOfWeek != "Sunday" && flag == true)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
