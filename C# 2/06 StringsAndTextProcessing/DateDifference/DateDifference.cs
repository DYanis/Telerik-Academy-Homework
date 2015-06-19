// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Linq;

class DateDifference
{
    static void Main()
    {
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        var days = firstDate - secondDate;
        Console.WriteLine(Math.Abs(days.Days));        
    }
}
