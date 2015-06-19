//  Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
// Format the output aligned right in 15 symbols

using System;
using System.Globalization;
using System.Linq;

namespace FormatNumber
{
    class FormatNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(number.ToString().PadLeft(15));
            Console.WriteLine(number.ToString("X").PadLeft(15));
            Console.WriteLine(number.ToString("P", CultureInfo.InvariantCulture).PadLeft(15));
            Console.WriteLine(number.ToString("G2", CultureInfo.InvariantCulture).PadLeft(15));
        }
    }
}
