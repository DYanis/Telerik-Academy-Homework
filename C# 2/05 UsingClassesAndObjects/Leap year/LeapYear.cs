// Write a program that reads a year from the console and checks whether it is a leap one.
// Use System.DateTime.

using System;
using System.Linq;

namespace LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());
            bool x = DateTime.IsLeapYear(year);
            Console.WriteLine(x);
        }
    }
}
