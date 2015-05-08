// Write a method that reverses the digits of given decimal number.

using System;
using System.Linq;

namespace ReverseNumber
{
   public class ReverseNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter Number :");
            decimal number = decimal.Parse(Console.ReadLine());

            Console.WriteLine(RevertNumber(number));
        }

        static decimal RevertNumber(decimal number)
        {
            string numberStr = number.ToString();
            string reverseNumberStr = string.Empty;

            for (int i = numberStr.Length - 1; i >= 0; i--)
            {
                reverseNumberStr += numberStr[i];
            }

            decimal result = decimal.Parse(reverseNumberStr);
            return result;
        }

    }
}