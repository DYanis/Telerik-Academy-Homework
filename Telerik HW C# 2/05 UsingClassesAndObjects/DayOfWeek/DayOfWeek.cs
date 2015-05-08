// Write a program that prints to the console which day of the week is today.
// Use System.DateTime.

using System;
using System.Linq;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Today.DayOfWeek);            
        }
    }
}
