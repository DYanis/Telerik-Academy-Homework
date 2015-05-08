// Write a program to convert decimal numbers to their binary representation.

using System;
using System.Linq;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            Console.WriteLine("Enter decimal number");
            int number = int.Parse(Console.ReadLine());
            string binaryNumber = "";
            int? result = null;
            while (true)
            {
                if (number == 0)
                {
                    break;
                }
                int digit = number % 2;
                number = number / 2;
                binaryNumber += Convert.ToString(digit);
            }
            Console.WriteLine(binaryNumber);
        }
    }
}
